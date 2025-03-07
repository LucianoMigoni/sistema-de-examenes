using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Generación_de_Exámenes.GestorExamenes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Generación_de_Exámenes
{
    internal class GestorExamenes
    {
        // Declaracion de las listas
        List<string> asigYUnid = new List<string>();
        List<string> asignaturas = new List<string>();
        List<string> unidades = new List<string>();
        List<string> preguntas = new List<string>();
        List<string> subUnidades = new List<string>();

        // Lista con las preguntas con subunidades repetidas, para luego elegir una aleatoriamente
        List<string> preguntasSubunRep = new List<string>();

        string archivoPreguntas = "../Preguntas.txt";
        string archivoExamen = "../Exámenes.txt";

        // Declaracion de la clase examen
        ClaseExamen claseExamen = new ClaseExamen();

        public string? unidadesSelecc { get; set; }

        // Funcion para cargar asignaturas y unidades dentro del combobox
        public void CargarAsignaturasUnidades(int indiceCmb, ComboBox cmbAsig, ComboBox cmbUnid)
        {

            // Seteamos las listas a una nueva lista para trabajar con ellas

            asigYUnid = new List<string>();
            asignaturas = new List<string>();
            unidades = new List<string>();

            subUnidades.Clear();


            if (File.Exists(archivoPreguntas))
            {
                using (StreamReader reader = new StreamReader(archivoPreguntas))
                {
                    string? linea;

                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] partes = linea.Split('|');

                        if (partes.Length >= 6)
                        {
                            // Eliminamos los espacios en blanco
                            string asignatura = partes[4].Trim();
                            string unidad = partes[5].Trim();
                            string subUnidad = partes[6].Trim();

                            subUnidades.Add(subUnidad);

                            // Si la lista no contiene la asignatura aun, se añadira la misma
                            if (!asignaturas.Contains(asignatura))
                                asignaturas.Add(asignatura);

                            asigYUnid.Add($"{asignatura}|{unidad}");
                        }
                    }
                }

                // En caso de que el combobox de asignaturas sea distinto de nulo, se añaden las unidades
                if (cmbAsig.DataSource != null)
                {
                    // Cantidad de preguntas
                    int cantPreg = 0;

                    foreach (string linea2 in asigYUnid)
                    {
                        string[] valores = linea2.Split('|');
                        if (linea2.Contains(asignaturas[indiceCmb]))
                        {
                            cantPreg++;

                            if (!unidades.Contains(valores[1]))
                            {
                                unidades.Add(valores[1]);
                            }
                        }
                    }
                    cmbUnid.DataSource = unidades;
                } else // Caso contrario se añaden primero las asignaturas (para evitar errores de sobrescritura)
                    cmbAsig.DataSource = asignaturas;
            }
            subUnidades.Sort();
        }

        public void AñadirUnidades(int indiceCmbUnidad, string nombreUnidad, Label numPreguntas, Label numUnidades)
        {
            int cantUnidades = Convert.ToInt32(numUnidades.Text.ToString());
            int cantPreguntas = Convert.ToInt32(numPreguntas.Text.ToString());
            int cantPregXUnidad = 0;

            if (unidadesSelecc != null && unidadesSelecc.Contains(indiceCmbUnidad.ToString()))
                MessageBox.Show("La unidad ya se encuentra ingresada, por favor ingrese otra.", "Error: Unidad ya ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // Se guardaran los indices separados por "," (operador ternario que verifica que el string no sea nulo)
                unidadesSelecc = string.IsNullOrEmpty(unidadesSelecc) ? unidadesSelecc += $"{indiceCmbUnidad}" : unidadesSelecc += $"|{indiceCmbUnidad}";
                
                cantUnidades++;
                numUnidades.Text = cantUnidades.ToString();

                cantPregXUnidad = 0;

                if (File.Exists(archivoPreguntas))
                {
                    using (StreamReader reader = new StreamReader(archivoPreguntas))
                    {
                        string? linea;

                        while ((linea = reader.ReadLine()) != null)
                        {
                            if (linea.Contains(nombreUnidad))
                                cantPregXUnidad++;
                        }
                    }
                }
                cantPreguntas += cantPregXUnidad;
                numPreguntas.Text = cantPreguntas.ToString();
            }
        }

        public void GenerarArchivoTxt(DateTime fecha, ComboBox cmbAsig)
        {

            // Indice para saber la cantidad de examenes que hay para recuperar la id
            int indCantEx = 1;

            // Lista ordenada del archivo preguntas por subUnidad alfabeticamente
            List<string> textoOrdSub = new List<string>();

            // Logica para ordenar el texto por subUnidad
            string[] texto;

            using (StreamReader sr = new StreamReader(archivoPreguntas))
                texto = sr.ReadToEnd().Split(Environment.NewLine);

            // Ordenar las líneas por subUnidad
            foreach (string subUnSort in subUnidades)
            {
                foreach (string linea in texto)
                {
                    if (linea != "")
                    {
                        string[] partes = linea.Split('|');
                        string subunidad = partes[6];
                        string pregunta = partes[1];

                        // Verificamos que sea la subunidad ordenada y que el diccionario del texto no contenga la misma pregunta
                        if (subunidad == subUnSort && !textoOrdSub.Contains(linea))
                            textoOrdSub.Add(linea);
                    }
                }
            }

            string subUnidad = string.Empty;

            preguntas.Clear();

            int[] indicesUnidades = unidadesSelecc.Split("|").Select(int.Parse).ToArray();

            List<string> preguntasUnidSubunid = new List<string>();

            foreach(string linea in textoOrdSub)
            {
                string[] partes = linea.Split("|");

                for (int i = 0; i < indicesUnidades.Length; i++)
                {
                    if (partes.Length > 6)
                    {
                        string pregunta = partes[1];
                        string unidad = partes[5];
                        string subunidad = partes[6];

                        if (partes.Contains(cmbAsig.SelectedItem?.ToString()) && partes.Contains(unidades[indicesUnidades[i]]) && !preguntasUnidSubunid.Contains(pregunta))
                            preguntasUnidSubunid.Add($"{pregunta}|{unidad}|{subunidad}");
                    }
                }
            }

            // Lista auxiliar de preguntas con subunidad repetida, de la cual se elegira una pregunta
            List<string> preguntasSubRep = new List<string>();

            // Indice para comparar con la posterior
            int indicePreg = 1;

            foreach (string pregunta in preguntasUnidSubunid)
            {
                string[] partes = pregunta.Split("|");

                // Si no contiene la pregunta
                if (!preguntasSubRep.Contains(partes[0]))
                {
                    if (indicePreg < preguntasUnidSubunid.Count())
                    {
                        if (preguntasUnidSubunid[indicePreg].Contains(partes[1]))
                        {
                            if (preguntasUnidSubunid[indicePreg].Contains(partes[2]))
                                preguntasSubRep.Add(partes[0]);
                            else // Si la subunidad es distinta a la anterior, guardamos pregunta
                            {
                                if (preguntasSubRep.Count() > 0)
                                {
                                    preguntas.Add(preguntaRandom(preguntasSubRep));
                                    preguntasSubRep.Clear();
                                } else
                                    preguntas.Add(partes[0]);
                            }
                        }
                        else // Si la siguiente no es la misma unidad, entonces almacenamos la pregunta
                        {
                            if (preguntasSubRep.Count() > 0)
                            {
                                preguntasSubRep.Add(partes[0]);
                                preguntas.Add(preguntaRandom(preguntasSubRep));
                                preguntasSubRep.Clear();
                            }
                            else
                                preguntas.Add(partes[0]);
                        }
                    } else
                    {
                        if (preguntasSubRep.Count() > 0)
                        {
                            preguntasSubRep.Add(partes[0]);
                            preguntas.Add(preguntaRandom(preguntasSubRep));
                            preguntasSubRep.Clear();
                        }
                        else
                            preguntas.Add(partes[0]);
                    }
                }
                indicePreg++;
            }

            // Leemos linea por linea para recuperar el id del examen siguiente
            if (File.Exists(archivoExamen))
                using (StreamReader reader = new StreamReader(archivoExamen))
                    while (reader.ReadLine() != null)
                        indCantEx++;

            claseExamen.Id = indCantEx;
            claseExamen.Fecha = fecha.Date.ToString("yyyy-MM-dd");
            claseExamen.Asignatura = cmbAsig.SelectedItem?.ToString();
            claseExamen.Preguntas = preguntas;

            // Escritura del archivo txt
            using (StreamWriter writer = new StreamWriter(archivoExamen, true))
                writer.WriteLine(claseExamen.GenerarFormatoTxt());
        }

        private string preguntaRandom(List<string> pregSubRep)
        {
            Random random = new Random();
            int randomIndex = random.Next(pregSubRep.Count);
            return pregSubRep[randomIndex];
        }

        // Clase para guardar temporalmente los datos del texto
        public class datosTexto()
        {
            public int? id;
            public string? fecha;
            public string? asignatura;
            public int? cantPreg = 0;
            public string[]? preg;
        }

        public void CargarDatosDGV(DataGridView dgvListadoExamenes, DataGridView dgvPreguntas)
        {
            datosTexto datosTxt = new datosTexto();

            // Reseteo de dataGridViews
            dgvListadoExamenes.Rows.Clear();
            dgvPreguntas.Rows.Clear();

            if (File.Exists(archivoExamen))
            {
                using (StreamReader reader = new StreamReader(archivoExamen))
                {
                    string? linea;
                    int i = 0;

                    // Almacenamiento de datos en clase datosTxt
                    while((linea = reader.ReadLine()) != null)
                    {
                        datosTxt.cantPreg = 0;
                        string[] partes = linea.Split('|');

                        for (int k = 0; k < partes.Length; k++)
                            partes[k] = partes[k].Trim();

                        datosTxt.id = Convert.ToInt32(partes[0]);
                        datosTxt.fecha = partes[1];
                        datosTxt.asignatura = partes[2];

                        datosTxt.preg = partes[3].Split('-');
                        for (int k = 0; k < datosTxt.preg.Length; k++)
                        {
                            datosTxt.preg[k] = datosTxt.preg[k].Replace("[", "").Replace("]", "");
                            datosTxt.cantPreg++;
                        }

                        AgregarItemsADGV(dgvListadoExamenes, dgvPreguntas, datosTxt);
                        i++;
                    }
                }
            }
        }

        private void AgregarItemsADGV(DataGridView dgvListadoExamenes, DataGridView dgvPreguntas, datosTexto datosTxt)
        {
            // Agregar una nueva fila al listado de exámenes
            dgvListadoExamenes.Rows.Add(datosTxt.id, datosTxt.fecha, datosTxt.asignatura, datosTxt.cantPreg);

            // Agregar preguntas al listado de preguntas
            int j = 1;

            foreach (string pregunta in datosTxt.preg)
            {
                dgvPreguntas.Rows.Add(datosTxt.id, j, pregunta);
                j++;
            }
        }

        public void BorrarExamen(DataGridView dgvExamenes, int id)
        {
            // Archivo temporal
            string archivoTemporal = "archivoTemporal.txt";

            using (StreamReader reader = new StreamReader(archivoExamen))
            using (StreamWriter writer = new StreamWriter(archivoTemporal))
            {
                string? linea;
                int nuevoId = 1;

                while ((linea = reader.ReadLine()) != null)
                {
                    string[] datos = linea.Split('|');

                    // Si el ID actual no es el que se debe eliminar
                    if (Convert.ToInt32(datos[0]) != id)
                    {
                        datos[0] = nuevoId.ToString();
                        nuevoId++;

                        writer.WriteLine(string.Join("|", datos));
                    }
                }
            }

            // Reemplazamos el archivo original con el archivo temporal
            File.Delete(archivoExamen);
            File.Move(archivoTemporal, archivoExamen);

        }

        public void BorrarPregunta(DataGridView dgvExamenes, DataGridView dgvPreguntas, string pregunta, int id)
        {
            // Archivo temporal
            string archivoTemporal = "archivoTemporal.txt";

            using (StreamReader reader = new StreamReader(archivoExamen))
            using(StreamWriter writer = new StreamWriter(archivoTemporal))
            {
                string? linea;

                while (( linea = reader.ReadLine()) != null)
                {
                    string[] datos = linea.Split('|');
                    string[] preguntas = datos[3].Split("-");

                    for (int k = 0; k < preguntas.Length; k++)
                        preguntas[k] = preguntas[k].Replace("[", "").Replace("]", "");

                    if (Convert.ToInt32(datos[0]) != id)
                        writer.WriteLine(string.Join("|", datos));
                    else if (Convert.ToInt32(datos[0]) == id && preguntas.Length > 1)
                    {
                        for (int i = 0; i < preguntas.Length; i++)
                            if (preguntas[i] == pregunta)
                                preguntas[i] = string.Empty;

                        string listaPreg;

                        // Unimos las palabras por "-", en caso de que no sean nulas
                        listaPreg = GenerarListaPreguntas(preguntas);

                        datos[3] = listaPreg;

                        // Escribimos el archivo con los datos modificados
                        writer.WriteLine(string.Join("|", datos));
                    } else
                    {
                        MessageBox.Show("Debe de haber por lo menos una pregunta por examen", "Error: Cantidad de preguntas insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            File.Delete(archivoExamen);
            File.Move(archivoTemporal, archivoExamen);
        }

        string GenerarListaPreguntas(string[] preguntas)
        {
            string listaPreg = "[";
            for (int i = 0; i < preguntas.Length; i++)
            {
                if (!string.IsNullOrEmpty(preguntas[i])) // Ignoramos las preguntas que tengan "" o sean nulas
                {
                    listaPreg += preguntas[i];

                    // Agreamos "-" solo si hay una pregunta valida luego de la misma
                    int j = i + 1;

                    while (j < preguntas.Length && string.IsNullOrEmpty(preguntas[j]))
                        j++;
                    if (j < preguntas.Length)
                        listaPreg += "-";
                }
            }
            listaPreg += "]";
            return listaPreg;
        }

        public void ReiniciarExamen(Label numPreguntas, Label numUnidades)
        {
            unidadesSelecc = "";
            numPreguntas.Text = "0";
            numUnidades.Text = "0";
            preguntas.Clear();
            preguntasSubunRep.Clear();
        }
    }
}
