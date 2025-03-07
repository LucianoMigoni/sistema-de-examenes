using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corrección_de_Exámenes
{
    internal class GestorCorrecEx
    {
        // Instancia de la clase correccion
        ClaseCorrecEx claseCorrec = new ClaseCorrecEx();

        // Declaracion de listas necesarias
        List<string> preguntas = new List<string>();
        List<string> respuestas = new List<string>();
        List<List<string>> respPosibles = new List<List<string>>();

        // Listas de respuestas del usuario
        List<string> respUsuario = new List<string>();

        // Archivos a utilizar
        string archivoPreguntas = "../Preguntas.txt";
        string archivoExamenes = "../Exámenes.txt";
        string archivoExCorregidos = "../Correcciones.txt";

        int cantPreg = 0;

        int cantPregCorr = 0;

        public void ObtenerId(ComboBox cmbID)
        {
            try
            {
                using (StreamReader reader = new StreamReader(archivoExamenes))
                {
                    string? linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] datos = linea.Split('|');

                        cmbID.Items.Add(datos[0]);
                    }
                }
            } catch
            {
                MessageBox.Show("No existen exámenes generados, por favor ingrese uno antes de simular una correción.", "Warning: Archivo examenes inexistente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Funcion que obtiene los datos mediante la id y completa los campos necesarios
        public void ObtenerDatos(string ID)
        {
            cantPreg = 0;
            respPosibles.Clear();

            try
            {
                using(StreamReader readerEx = new StreamReader(archivoExamenes))
                {
                    string? linea;
                    while ((linea = readerEx.ReadLine()) != null)
                    {
                        string[] datosEx = linea.Split('|');

                        string[] preguntasAux = datosEx[3].Split('-');

                        if (datosEx[0] == ID)
                        {
                            for (int i = 0; i < preguntasAux.Length; i++)
                            {
                                preguntasAux[i] = preguntasAux[i].Replace("[", "").Replace("]", "");
                                cantPreg++;
                            }

                            using (StreamReader readerPg = new StreamReader(archivoPreguntas))
                            {
                                string? lineaPg;

                                // Indice de pregunta
                                int j = 0;

                                while ((lineaPg = readerPg.ReadLine()) != null)
                                {
                                    string[] datosPg = lineaPg.Split('|');

                                    foreach (string pregunta in preguntasAux)
                                    {
                                        if (datosPg.Contains(pregunta))
                                        {
                                            // Lista auxiliar de respuestas posibles
                                            List<string> respPosAux = new List<string>();
                                            string[] respPos = datosPg[2].Split("-");

                                            // Limpiar y agregar las respuestas
                                            for (int i = 0; i < respPos.Length; i++)
                                            {
                                                respPosAux.Add(respPos[i].Replace("[", "").Replace("]", ""));
                                            }

                                            // Agregar las respuestas a la lista de respuestas posibles
                                            respPosibles.Add(respPosAux);

                                            // Guardamos la respuesta de la pregunta
                                            respuestas.Add(datosPg[3]);

                                            // Guardamos la pregunta con el indice correspondiente
                                            preguntas.Add(pregunta);

                                            j++;
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            } catch
            {
                return;
            }
        }

        public void AgregarDatos(Label lblPregunta, ComboBox cmbRespuestas, Label lblCantPreg, GroupBox gbxExamen, GroupBox gbxDatosAlumno, GroupBox gbxExamenCorregido, DataGridView dgvExamenes, Label lblCantTotResp, Label lblRespCorr, Label lblNotaFinal, string ID, int numPreg, string nombre, string apellido)
        {
            ObtenerDatos(ID);

            if (respuestas.Count() == 0)
            {
                MessageBox.Show("No se han encontrado las preguntas en el archivo preguntas, por favor ingreselas nuevamente en un examen.", "Error: Archivo inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gbxExamen.Enabled = false;
                gbxDatosAlumno.Enabled = true;
                return;
            }
            claseCorrec.RespuestasCorrectas = respuestas;

            cmbRespuestas.Items.Clear();

            dgvExamenes.Rows.Clear();
            lblRespCorr.Text = "0";
            lblCantTotResp.Text = "0";
            lblNotaFinal.Text = "0";

            if (numPreg <= respPosibles.Count() - 1)
            {
                lblPregunta.Text = preguntas[numPreg];

                for (int i = 0; i < respPosibles[numPreg].Count(); i++)
                    cmbRespuestas.Items.Add(respPosibles[numPreg][i]);

                lblCantPreg.Text = $"Pregunta {numPreg + 1} / {cantPreg}";

            } else
            {
                claseCorrec.Nombre = nombre;
                claseCorrec.Apellido = apellido;

                ImprimirResultados();

                AgregarDatosDGV(dgvExamenes, lblCantTotResp, lblRespCorr, lblNotaFinal);

                gbxExamenCorregido.Enabled = true;

                ResetearDatos();
                gbxDatosAlumno.Enabled = true;
                gbxExamen.Enabled = false;
                cmbRespuestas.Items.Clear();
                lblPregunta.Text = "--";
                lblCantPreg.Text = $"Pregunta 1 / --";
            }
        }

        void ImprimirResultados()
        {
            // Redondeamos a 2 decimales
            decimal notaFinal = Math.Round((claseCorrec.CantRespCorrectas / claseCorrec.CantResp), 2);
            claseCorrec.NotaFinal = notaFinal * 10;

            using (StreamWriter writer = new StreamWriter(archivoExCorregidos, true))
            {
                writer.WriteLine(claseCorrec.GenerarCabeceraSecundaria());
                writer.WriteLine(claseCorrec.GenerarFormatoTxt());
            }
        }

        void AgregarDatosDGV(DataGridView dgvExamenes, Label lblCantTotResp, Label lblRespCorr, Label lblNotaFinal)
        {
            for (int i = 0; i < claseCorrec.RespuestasUsuario?.Count(); i++)
                dgvExamenes.Rows.Add(claseCorrec.RespuestasUsuario[i], claseCorrec.RespuestasCorrectas?[i]);

            lblCantTotResp.Text = claseCorrec.CantResp.ToString();
            lblRespCorr.Text = claseCorrec.CantRespCorrectas.ToString();
            lblNotaFinal.Text = claseCorrec.NotaFinal.ToString();
        }

        void ResetearDatos()
        {
            // Reseteo de datos para trabajar con ellos desde 0
            preguntas = new List<string>();
            respuestas = new List<string>();
            respPosibles = new List<List<string>>();
            respUsuario = new List<string>();

            cantPreg = 0;
            cantPregCorr = 0;

            claseCorrec.Nombre = "";
            claseCorrec.Apellido = "";
            claseCorrec.RespuestasUsuario?.Clear();
            claseCorrec.RespuestasCorrectas?.Clear();
            claseCorrec.CantResp = 0;
            claseCorrec.CantRespCorrectas = 0;
            claseCorrec.NotaFinal = 0;
        }

        public void AgregarRespuestas(ComboBox cmbRespuestas, int numPreg)
        {
            respUsuario.Add(cmbRespuestas.Text);

            claseCorrec.RespuestasUsuario = respUsuario;

            if (cmbRespuestas.Text == respuestas[numPreg])
                cantPregCorr++;

            claseCorrec.CantRespCorrectas = cantPregCorr;
            claseCorrec.CantResp++;
        }
    }
}
