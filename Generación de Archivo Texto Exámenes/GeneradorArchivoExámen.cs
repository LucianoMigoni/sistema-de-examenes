using Generaci�n_de_Archivo_Texto_Ex�menes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;

namespace Generacion_Examen_Texto
{
    public partial class frmGenArchExam : Form
    {
        ClaseCabecera cabecera = new ClaseCabecera();
        List<string> asignaturas = new List<string>();

        Dictionary<string, List<string>> unidadesPorAsignatura = new Dictionary<string, List<string>>();
        Dictionary<string, List<string>> subunidadesPorUnidad = new Dictionary<string, List<string>>();

        List<string> IDexamenes = new List<string>();

        string cabeceraFinal, ID;

        string archivoPreguntas = "../Preguntas.txt";
        string archivoExamen = "../Ex�menes.txt";

        public frmGenArchExam()
        {
            InitializeComponent();
            InicializarDatos();
        }

        public void InicializarDatos()
        {
            try
            {
                using (StreamReader lector = new StreamReader(archivoExamen))
                {
                    string? linea;
                    while ((linea = lector.ReadLine()) != null)
                    {
                        string[] partes = linea.Split('|');
                        if (partes.Length >= 4)
                        {
                            string IDexamen = partes[0];
                            IDexamenes.Add(IDexamen);
                        }

                    }
                    cmbID.DataSource = IDexamenes;
                }
            }
            catch
            {
                MessageBox.Show("Archivo de ex�men inexistente, por favor genere uno.", "Warning: ex�men inexistente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGenerarCabecera_Click_1(object sender, EventArgs e)
        {
            if (tbCarrera.Text.Length == 0)
            {
                MessageBox.Show("Por favor, ingrese una carrera v�lida.", "Error: carrera inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCarrera.Focus();
            }
            else if (tbFecha.Text.Length == 0)
            {
                MessageBox.Show("Por favor, ingrese una fecha v�lida.", "Error: fecha inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFecha.Focus();
            }
            else if (cmbID.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, ingrese un ID v�lido.", "Error: ID inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbID.Focus();
            }
            else if (!int.TryParse(cmbID.Text, out int id)) // Validaci�n espec�fica del ID
            {
                MessageBox.Show("Por favor, ingrese un n�mero v�lido en el campo ID.", "Error: ID inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbID.Focus();
            }
            else if (tbUniversidad.Text.Length == 0)
            {
                MessageBox.Show("Por favor, ingrese una universidad v�lida.", "Error: universidad inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUniversidad.Focus();
            }
            else
            {
                // Todos los campos est�n validados
                cabecera.Carrera = tbCarrera.Text;
                cabecera.Fecha = tbFecha.Value.ToString("yyyy-MM-dd");
                cabecera.Universidad = tbUniversidad.Text;
                cabecera.Id = Convert.ToInt32(cmbID.SelectedItem);
                ID = cmbID.SelectedItem.ToString();



                // Limpieza de los campos
                tbCarrera.Text = "";
                cmbID.SelectedIndex = -1;
                tbUniversidad.Text = "";

                cabeceraFinal = cabecera.GenerarCabecera();

                gbxDatosCabecera.Enabled = false;
                gbxDatosImpresion.Enabled = true;
            }
        }

        private void btnGenerarImpresion_Click(object sender, EventArgs e)
        {
            List<string> preguntasID = new List<string>();
            List<string> PreguntasyRespuestas = new List<string>();
            string nombreArchivo;

            if (tbNombreArchivo.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese un nombre de archivo v�lido.", "Error: nombre inv�lido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNombreArchivo.Focus();
            }
            else if (tbNombreArchivo.Text.Contains('/'))
            {
                MessageBox.Show("El nombre del archivo no puede contener el simbolo \"/\".", "Error: nombre inv�lido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNombreArchivo.Focus();
            }
            else if (tbNombreArchivo.Text.Contains('\\'))
            {
                MessageBox.Show("El nombre del archivo no puede contener el s�mbolo \"\\\".", "Error: nombre inv�lido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNombreArchivo.Focus();
            }
            else
            {
                nombreArchivo = $"../{tbNombreArchivo.Text}.txt";

                // Limpieza de los campos
                tbNombreArchivo.Text = "";

                preguntasID = ObtenerPreguntas();
                preguntasID = preguntasID[0].Replace("[", "").Replace("]", "").Split('-').ToList();
                PreguntasyRespuestas = ObtenerRespuestas(preguntasID);
                cabeceraFinal = cabecera.GenerarCabecera();

                // Escritura en el archivo
                using (StreamWriter escritor = new StreamWriter(nombreArchivo))
                {
                    escritor.WriteLine(cabeceraFinal);

                    foreach (string elemento in PreguntasyRespuestas)
                    {
                        escritor.WriteLine(elemento.Replace("[", "").Replace("]", "").Replace("-", " - "));
                    }
                }

                gbxDatosImpresion.Enabled = false;
                gbxDatosCabecera.Enabled = true;
            }
        }

        public List<string> ObtenerPreguntas()
        {
            List<string> preguntasEncontradas = new List<string>();


            using (StreamReader reader = new StreamReader(archivoExamen))
            {
                string? linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] partes = linea.Split('|');

                    if (partes.Length >= 4) // Verificamos el formato de la l�nea
                    {
                        string exID = partes[0].Trim();
                        string exAsignatura = partes[2].Trim(); // Asignatura
                        string pregunta = partes[3].Trim(); // Pregunta

                        if (exID.Equals(ID, StringComparison.OrdinalIgnoreCase))
                        {
                            preguntasEncontradas.Add(pregunta);
                            cabecera.Asignatura = exAsignatura;
                        }
                    }
                }
            }
            return preguntasEncontradas;
        }

        public List<string> ObtenerRespuestas(List<string> preguntasID)
        {
            List<string> preguntasYRespuestas = new List<string>();

            using (StreamReader reader = new StreamReader(archivoPreguntas))
            {
                string? linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] partes = linea.Split('|');

                    string pregunta = partes[1].Trim(); // Texto de la pregunta
                    string respuesta = partes[2].Trim(); // Texto de la respuesta

                    if (preguntasID.Contains(pregunta))
                    {
                        preguntasYRespuestas.Add(pregunta);
                        preguntasYRespuestas.Add(respuesta);
                        preguntasYRespuestas.Add("");
                    }
                }
            }
            return preguntasYRespuestas;
        }

        private void btnVolverAlMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalirDelPrograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}