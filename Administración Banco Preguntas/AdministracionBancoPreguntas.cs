using Administracion_Banco_Preguntas;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace Administracion_Banco_Preguntas
{
    public partial class frmMenuAdminBancPreg : Form
    {
        string archivoPreguntasExamenes = "../Preguntas.txt";

        GestorPreguntas gestorPreguntas = new GestorPreguntas();

        ClasePregunta clasePregunta = new ClasePregunta();
        ClasePregunta clasePregunta2 = new ClasePregunta();

        List<string>? respuesta = new List<string>();
        List<string>? respuesta2 = new List<string>();

        bool banderaRespuesta = false;
        bool banderaRespuesta2 = false;

        int ContadorRespuestas = 0;
        int ContadorRespuestas2 = 0;

        List<string> archivoViejo = new List<string>(); // Lista que se va a usar para verificar que no haya algún cambio en el archivo durante la ejecución del programa
        private System.Windows.Forms.Timer timer;

        public frmMenuAdminBancPreg()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;

            timer.Tick += Timer_Tick!;
        }

        // Función para desabilitar el groupbox "Modificar preguntas existentes"
        private void DesabilitarModPreg()
        {
            clasePregunta2 = new ClasePregunta();
            respuesta2 = new List<string>();

            banderaRespuesta2 = false;
            ContadorRespuestas2 = 0;

            txtIDpregunta.Text = "";
            txtAsignatura2.Text = "";
            txtUnidad2.Text = "";
            txtSubunidad2.Text = "";
            txtPregunta2.Text = "";
            txtRespuesta2.Text = "";

            lblIDPregunta.Enabled = true;
            txtIDpregunta.Enabled = true;
            btnIngresarIDPregunta.Enabled = true;
            btnIngresarIDPregunta.BackColor = Color.FromArgb(219, 226, 239); // Al activar/desactivar un botón se le cambia el color para que coincida con el resto

            lblAsignatura2.Enabled = false;
            txtAsignatura2.Enabled = false;
            lblUnidad2.Enabled = false;
            txtUnidad2.Enabled = false;
            lblSubunidad2.Enabled = false;
            txtSubunidad2.Enabled = false;
            btnIngresarAUS2.Enabled = false;
            btnIngresarIDPregunta.BackColor = Color.Gainsboro;

            lblPregunta2.Enabled = false;
            txtPregunta2.Enabled = false;
            btnIngresarPregunta2.Enabled = false;
            btnIngresarPregunta2.BackColor = Color.Gainsboro;

            lblRespuesta2.Enabled = false;
            lblMax4_2.Enabled = false;
            txtRespuesta2.Enabled = false;

            cbxRespCorrecta2.Enabled = false;
            cbxRespCorrecta2.Checked = false;

            btnIngresarRespuesta2.Enabled = false;
            btnIngresarRespuesta2.BackColor = Color.Gainsboro;

            btnModificar.Enabled = false;
            btnModificar.BackColor = Color.Gainsboro;

            gbxModPreg.Enabled = false;
        }

        // Función que se activa cada un segundo para verificar si hubo algún cambio en el archivo
        private void Timer_Tick(object sender, EventArgs e)
        {
            List<string> archivoNuevo = new List<string>();

            if (File.Exists(archivoPreguntasExamenes))
                archivoNuevo = new List<string>(File.ReadAllLines(archivoPreguntasExamenes));

            if (!archivoViejo.SequenceEqual(archivoNuevo)) // Compara si los 2 archivos no son iguales
            {
                FileInfo archivo = new FileInfo(archivoPreguntasExamenes);

                if (File.Exists(archivoPreguntasExamenes) && archivo.Length > 0)
                {
                    if (gbxModPreg.Enabled == false)
                    {
                        gbxModPreg.Enabled = true;
                        btnIngresarIDPregunta.BackColor = Color.FromArgb(219, 226, 239);
                    }

                    MostrarListadoGeneral();
                    MostrarListadoPorUnidad();
                }
                else
                {
                    if (gbxModPreg.Enabled)
                        DesabilitarModPreg();

                    dgvListadoGeneral.Rows.Clear();
                    dgvListadoPorUnidad.Rows.Clear();
                }
            }
        }

        // Función para cargar los DataGridViews
        private void CargarDGVs()
        {
            FileInfo archivo = new FileInfo(archivoPreguntasExamenes);

            if (File.Exists(archivoPreguntasExamenes) && archivo.Length > 0)
            {
                gbxModPreg.Enabled = true;
                btnIngresarIDPregunta.BackColor = Color.FromArgb(219, 226, 239);

                MostrarListadoGeneral();
                MostrarListadoPorUnidad();
            }
            else
            {
                dgvListadoGeneral.Rows.Clear();
                dgvListadoPorUnidad.Rows.Clear();
            }
        }

        private void frmMenuAdminBancPreg_Load(object sender, EventArgs e)
        {
            timer.Start();
            CargarDGVs();
        }

        private void frmMenuAdminBancPreg_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
        }

        // Función para mostrar el DataGridView general
        private void MostrarListadoGeneral()
        {
            dgvListadoGeneral.Rows.Clear();
            gestorPreguntas.AnadirPreguntasListadoGeneral(dgvListadoGeneral);
            archivoViejo = new List<string>(File.ReadAllLines(archivoPreguntasExamenes));
        }

        // Función para mostrar el DataGridView por unidad
        private void MostrarListadoPorUnidad()
        {
            dgvListadoPorUnidad.Rows.Clear();
            gestorPreguntas.AnadirPreguntasListadoPorUnidad(dgvListadoPorUnidad);
            archivoViejo = new List<string>(File.ReadAllLines(archivoPreguntasExamenes));
        }

        // Función para verificar que la Asignatura, Unidad y Subunidad no estén vacíos y no contengan carácteres inválidos
        private bool VerificarAUS()
        {
            if (txtAsignatura.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar una asignatura.", "Error: asignatura inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAsignatura.Focus();
                return false;
            }
            else if (txtAsignatura.Text.Contains('|'))
            {
                MessageBox.Show("La asignatura no puede contener el cáracter \"|\".", "Error: asignatura inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAsignatura.Focus();
                return false;
            }

            if (txtUnidad.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar una unidad.", "Error: unidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnidad.Focus();
                return false;
            }
            else if (txtUnidad.Text.Contains('|'))
            {
                MessageBox.Show("La unidad no puede contener el cáracter \"|\".", "Error: asignatura inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnidad.Focus();
                return false;
            }

            if (txtSubunidad.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar una subunidad.", "Error: subunidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSubunidad.Focus();
                return false;
            }
            else if (txtSubunidad.Text.Contains('|'))
            {
                MessageBox.Show("La subunidad no puede contener el cáracter \"|\".", "Error: asignatura inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSubunidad.Focus();
                return false;
            }

            return true;
        }

        // Función para ingresar la Asignatura, Unidad y Subunidad a clasePregunta
        private void IngresarAUS()
        {
            clasePregunta.Asignatura = txtAsignatura.Text;
            clasePregunta.Unidad = txtUnidad.Text;
            clasePregunta.Subunidad = txtSubunidad.Text;

            txtAsignatura.Text = "";
            txtUnidad.Text = "";
            txtSubunidad.Text = "";
        }

        // Función para pasar a la sección de pregunta
        private void PasarAPregunta()
        {
            lblAsignatura.Enabled = false;
            txtAsignatura.Enabled = false;
            lblUnidad.Enabled = false;
            txtUnidad.Enabled = false;
            lblSubunidad.Enabled = false;
            txtSubunidad.Enabled = false;
            btnIngresarAUS.Enabled = false;
            btnIngresarAUS.BackColor = Color.Gainsboro;

            lblPregunta.Enabled = true;
            txtPregunta.Enabled = true;
            btnIngresarPregunta.Enabled = true;
            btnIngresarPregunta.BackColor = Color.FromArgb(219, 226, 239);

            txtPregunta.Focus();
        }

        private void btnIngresarAUS_Click(object sender, EventArgs e)
        {
            if (VerificarAUS() == true)
            {
                IngresarAUS();
                PasarAPregunta();
            }
        }

        // Función para verificar que la pregunta no este vacío y no contenga carácteres inválidos
        private bool VerificarP()
        {
            if (txtPregunta.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar una pregunta.", "Error: pregunta inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPregunta.Focus();
                return false;
            }
            else if (txtPregunta.Text.Contains('|'))
            {
                MessageBox.Show("La pregunta no puede contener el cáracter \"|\".", "Error: asignatura inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPregunta.Focus();
                return false;
            }

            return true;
        }

        // Función para ingresar la pregunta a clasePregunta
        private void IngresarP()
        {
            clasePregunta.Pregunta = txtPregunta.Text;

            txtPregunta.Text = "";
        }

        // Función para pasar a la sección de respuestas
        private void PasarARespuesta()
        {
            lblPregunta.Enabled = false;
            txtPregunta.Enabled = false;
            btnIngresarPregunta.Enabled = false;
            btnIngresarPregunta.BackColor = Color.Gainsboro;

            lblRespuesta.Enabled = true;
            lblMax4.Enabled = true;
            txtRespuesta.Enabled = true;
            cbxRespCorrecta.Enabled = true;
            btnIngresarRespuesta.Enabled = true;
            btnIngresarRespuesta.BackColor = Color.FromArgb(219, 226, 239);

            txtRespuesta.Focus();
        }

        private void btnIngresarPregunta_Click(object sender, EventArgs e)
        {
            if (VerificarP() == true)
            {
                IngresarP();
                PasarARespuesta();
            }
        }

        // Función para verificar que la respuesta no este vacía y no contenga carácteres inválidos
        private bool VerificarR()
        {
            if (txtRespuesta.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar una respuesta.", "Error: respuesta inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRespuesta.Focus();
                return false;
            }
            else if (txtRespuesta.Text.Contains('|'))
            {
                MessageBox.Show("La respuesta no puede contener el cáracter \"|\".", "Error: asignatura inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRespuesta.Focus();
                return false;
            }

            return true;
        }
        // Función para ingresar las respuestas y la respuesta correcta a clasePregunta
        private void IngresarR()
        {
            if (cbxRespCorrecta.Checked == true)
            {
                clasePregunta.RespCorrecta = txtRespuesta.Text;

                cbxRespCorrecta.Checked = false;
                cbxRespCorrecta.Enabled = false;

                banderaRespuesta = true;
            }

            if (banderaRespuesta == true && ContadorRespuestas > 1)
            {
                btnSiguientePregunta.Enabled = true;
                btnSiguientePregunta.BackColor = Color.FromArgb(219, 226, 239);

                btnSiguienteAUS.Enabled = true;
                btnSiguienteAUS.BackColor = Color.FromArgb(219, 226, 239);
            }

            respuesta?.Add(txtRespuesta.Text);
            clasePregunta.Respuestas = respuesta;

            txtRespuesta.Text = "";
        }

        // Función para bloquear la sección de respuestas
        private void BloquearRespuesta()
        {
            lblRespuesta.Enabled = false;
            lblMax4.Enabled = false;
            txtRespuesta.Enabled = false;
            cbxRespCorrecta.Enabled = false;
            btnIngresarRespuesta.Enabled = false;
            btnIngresarRespuesta.BackColor = Color.Gainsboro;
        }

        private void btnIngresarRespuesta_Click(object sender, EventArgs e)
        {
            if (VerificarR() == true)
            {
                ContadorRespuestas++;

                if (ContadorRespuestas == 4 && banderaRespuesta == false && cbxRespCorrecta.Checked == false)
                {
                    MessageBox.Show("Debe ingresar una respuesta correcta.", "Error: respuesta correcta no ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ContadorRespuestas--;
                    return;
                }

                IngresarR();

                if (ContadorRespuestas == 4)
                    BloquearRespuesta();

                txtRespuesta.Focus();
            }
        }

        // Función para añadir los datos al archivo de preguntas
        public void AnadirPregunta()
        {
            using (StreamWriter sw = new StreamWriter(archivoPreguntasExamenes, true))
            {
                sw.WriteLine(clasePregunta.GenerarFormatoTxt());
            }
        }

        // Función para resetear los datos ya ingresados
        private void ResetearDatos()
        {
            clasePregunta = new ClasePregunta();
            respuesta = new List<string>();
            ContadorRespuestas = 0;
            banderaRespuesta = false;
        }

        // Función para pasar a la siguiente pregunta
        private void SiguientePregunta()
        {
            BloquearRespuesta();

            string? Asignatura = clasePregunta.Asignatura;
            string? Unidad = clasePregunta.Unidad;
            string? Subunidad = clasePregunta.Subunidad;

            clasePregunta.ID = gestorPreguntas.AsignarId();

            AnadirPregunta();

            MostrarListadoGeneral();
            MostrarListadoPorUnidad();

            ResetearDatos();

            clasePregunta.Asignatura = Asignatura;
            clasePregunta.Unidad = Unidad;
            clasePregunta.Subunidad = Subunidad;

            btnSiguientePregunta.Enabled = false;
            btnSiguientePregunta.BackColor = Color.Gainsboro;

            btnSiguienteAUS.Enabled = false;
            btnSiguienteAUS.BackColor = Color.Gainsboro;

            if (!gbxModPreg.Enabled)
            {
                gbxModPreg.Enabled = true;
                btnIngresarIDPregunta.BackColor = Color.FromArgb(219, 226, 239);
            }

            lblPregunta.Enabled = true;
            txtPregunta.Enabled = true;
            txtPregunta.Focus();

            btnIngresarPregunta.Enabled = true;
            btnIngresarPregunta.BackColor = Color.FromArgb(219, 226, 239);
        }

        private void btnSiguientePregunta_Click(object sender, EventArgs e)
        {
            txtRespuesta.Text = "";
            SiguientePregunta();
        }

        // Función para pasar a la siguiente Asignatura, Unidad y Subunidad 
        private void SiguienteAUS()
        {
            BloquearRespuesta();

            clasePregunta.ID = gestorPreguntas.AsignarId();

            AnadirPregunta();

            MostrarListadoGeneral();
            MostrarListadoPorUnidad();

            ResetearDatos();

            btnSiguientePregunta.Enabled = false;
            btnSiguientePregunta.BackColor = Color.Gainsboro;

            btnSiguienteAUS.Enabled = false;
            btnSiguienteAUS.BackColor = Color.Gainsboro;

            if (!gbxModPreg.Enabled)
            {
                gbxModPreg.Enabled = true;
                btnIngresarIDPregunta.BackColor = Color.FromArgb(219, 226, 239);
            }

            lblAsignatura.Enabled = true;
            txtAsignatura.Enabled = true;
            txtAsignatura.Focus();

            lblUnidad.Enabled = true;
            txtUnidad.Enabled = true;
            lblSubunidad.Enabled = true;
            txtSubunidad.Enabled = true;
            btnIngresarAUS.Enabled = true;
            btnIngresarAUS.BackColor = Color.FromArgb(219, 226, 239);
        }

        private void btnSiguienteAUS_Click(object sender, EventArgs e)
        {
            txtRespuesta.Text = "";
            SiguienteAUS();
        }

        // Función para verificar que la ID no esté vacía, que contenga solo caractéres númericos y esté dentro del archivo de preguntas
        private bool VerificarID()
        {
            if (txtIDpregunta.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar una ID.", "Error: ID inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDpregunta.Focus();
                return false;
            }

            try
            {
                Convert.ToInt32(txtIDpregunta.Text);
            }
            catch
            {
                MessageBox.Show("La ID debe contener únicamente números", "Error: ID inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDpregunta.Text = "";
                txtIDpregunta.Focus();
                return false;
            }

            if (gestorPreguntas.ExisteID(Convert.ToInt32(txtIDpregunta.Text)) == false)
            {
                MessageBox.Show("La ID ingresada no se encuentra dentro de las IDs almacenadas", "Error: ID inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDpregunta.Text = "";
                txtIDpregunta.Focus();
                return false;
            }

            return true;
        }

        // Función para ingresar la ID a clasePregunta
        private void IngresarID()
        {
            clasePregunta2.ID = Convert.ToInt32(txtIDpregunta.Text);

            txtIDpregunta.Text = "";
        }

        // Función para pasar a Asignatura, Unidad y Subunidad del GroupBox "Modificar preguntas existentes"
        private void PasarAAUS2()
        {
            lblIDPregunta.Enabled = false;
            txtIDpregunta.Enabled = false;
            btnIngresarIDPregunta.Enabled = false;
            btnIngresarIDPregunta.BackColor = Color.Gainsboro;

            lblAsignatura2.Enabled = true;
            txtAsignatura2.Enabled = true;
            txtAsignatura2.Focus();

            lblUnidad2.Enabled = true;
            txtUnidad2.Enabled = true;
            lblSubunidad2.Enabled = true;
            txtSubunidad2.Enabled = true;
            btnIngresarAUS2.Enabled = true;
            btnIngresarAUS2.BackColor = Color.FromArgb(219, 226, 239);
        }

        private void btnIngresarIDPregunta_Click(object sender, EventArgs e)
        {
            if (VerificarID() == true)
            {
                IngresarID();
                PasarAAUS2();
            }
        }

        // Función para verificar que la Asignatura, Unidad y Subunidad del GroupBox "Modificar preguntas existentes" no estén vacíos y no tengan caractéres inválidos
        private bool VerificarAUS2()
        {
            if (txtAsignatura2.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar una asignatura.", "Error: asignatura inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAsignatura2.Focus();
                return false;
            }
            else if (txtAsignatura2.Text.Contains('|'))
            {
                MessageBox.Show("La asignatura no puede contener el cáracter \"|\".", "Error: asignatura inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAsignatura2.Focus();
                return false;
            }

            if (txtUnidad2.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar una unidad.", "Error: unidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnidad2.Focus();
                return false;
            }
            else if (txtUnidad2.Text.Contains('|'))
            {
                MessageBox.Show("La unidad no puede contener el cáracter \"|\".", "Error: asignatura inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnidad2.Focus();
                return false;
            }

            if (txtSubunidad2.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar una subunidad.", "Error: subunidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSubunidad2.Focus();
                return false;
            }
            else if (txtSubunidad2.Text.Contains('|'))
            {
                MessageBox.Show("La subunidad no puede contener el cáracter \"|\".", "Error: asignatura inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSubunidad2.Focus();
                return false;
            }

            return true;
        }

        // Función para ingresar la Asignatura, Unidad y Subunidad del GroupBox "Modificar preguntas existentes" a clasePregunta2
        private void IngresarAUS2()
        {
            clasePregunta2.Asignatura = txtAsignatura2.Text;
            clasePregunta2.Unidad = txtUnidad2.Text;
            clasePregunta2.Subunidad = txtSubunidad2.Text;


            txtAsignatura2.Text = "";
            txtUnidad2.Text = "";
            txtSubunidad2.Text = "";
        }

        // Función para pasar a sección de pregunta del GroupBox "Modificar preguntas existentes"
        private void PasarAPregunta2()
        {
            lblAsignatura2.Enabled = false;
            txtAsignatura2.Enabled = false;
            lblUnidad2.Enabled = false;
            txtUnidad2.Enabled = false;
            lblSubunidad2.Enabled = false;
            txtSubunidad2.Enabled = false;
            btnIngresarAUS2.Enabled = false;
            btnIngresarAUS2.BackColor = Color.Gainsboro;

            lblPregunta2.Enabled = true;
            txtPregunta2.Enabled = true;
            btnIngresarPregunta2.Enabled = true;
            btnIngresarPregunta2.BackColor = Color.FromArgb(219, 226, 239);

            txtPregunta2.Focus();
        }

        private void btnIngresarAUS2_Click(object sender, EventArgs e)
        {
            if (VerificarAUS2() == true)
            {
                IngresarAUS2();
                PasarAPregunta2();
            }
        }

        // Función para verificar que la pregunta del GroupBox "Modificar preguntas existentes" no esté vacía y no tenga caractéres inválidos
        private bool VerificarP2()
        {
            if (txtPregunta2.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar una pregunta.", "Error: pregunta inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPregunta2.Focus();
                return false;
            }
            else if (txtPregunta2.Text.Contains('|'))
            {
                MessageBox.Show("La pregunta no puede contener el cáracter \"|\".", "Error: asignatura inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPregunta2.Focus();
                return false;
            }

            return true;
        }

        // Función para ingresar la pregunta del GroupBox "Modificar preguntas existentes" a clasePregunta2
        private void IngresarP2()
        {
            clasePregunta2.Pregunta = txtPregunta2.Text;

            txtPregunta2.Text = "";
        }

        // Función para pasar a la sección de respuestas del GroupBox "Modificar preguntas existentes"
        private void PasarARespuesta2()
        {
            lblPregunta2.Enabled = false;
            txtPregunta2.Enabled = false;
            btnIngresarPregunta2.Enabled = false;
            btnIngresarPregunta2.BackColor = Color.Gainsboro;

            lblRespuesta2.Enabled = true;
            lblMax4_2.Enabled = true;
            txtRespuesta2.Enabled = true;
            cbxRespCorrecta2.Enabled = true;
            btnIngresarRespuesta2.Enabled = true;
            btnIngresarRespuesta2.BackColor = Color.FromArgb(219, 226, 239);

            txtRespuesta2.Focus();
        }

        private void btnIngresarPregunta2_Click(object sender, EventArgs e)
        {
            if (VerificarP2() == true)
            {
                IngresarP2();
                PasarARespuesta2();
            }
        }

        // Función para verificar que la respuesta del GroupBox "Modificar preguntas existentes" no esté vacía y no tenga caractéres inválidos
        private bool VerificarR2()
        {
            if (txtRespuesta2.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar una respuesta.", "Error: respuesta inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRespuesta2.Focus();
                return false;
            }
            else if (txtRespuesta2.Text.Contains('|'))
            {
                MessageBox.Show("La respuesta no puede contener el cáracter \"|\".", "Error: asignatura inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRespuesta2.Focus();
                return false;
            }

            return true;
        }

        // Función para ingresar la respuesta del GroupBox "Modificar preguntas existentes" a clasePregunta2
        private void IngresarR2()
        {
            if (cbxRespCorrecta2.Checked == true)
            {
                clasePregunta2.RespCorrecta = txtRespuesta2.Text;

                cbxRespCorrecta2.Checked = false;
                cbxRespCorrecta2.Enabled = false;

                banderaRespuesta2 = true;
            }

            if (banderaRespuesta2 == true && ContadorRespuestas2 > 1)
            {
                btnModificar.Enabled = true;
                btnModificar.BackColor = Color.FromArgb(219, 226, 239);
            }

            respuesta2?.Add(txtRespuesta2.Text);
            clasePregunta2.Respuestas = respuesta2;

            txtRespuesta2.Text = "";
        }

        // Función para bloquear la sección de respuestas del GroupBox "Modificar preguntas existentes"
        private void BloquearRespuesta2()
        {
            lblRespuesta2.Enabled = false;
            lblMax4_2.Enabled = false;
            txtRespuesta2.Enabled = false;
            cbxRespCorrecta2.Enabled = false;
            btnIngresarRespuesta2.Enabled = false;
            btnIngresarRespuesta2.BackColor = Color.Gainsboro;
        }

        private void btnIngresarRespuesta2_Click(object sender, EventArgs e)
        {
            if (VerificarR2() == true)
            {
                ContadorRespuestas2++;

                if (ContadorRespuestas2 == 4 && banderaRespuesta2 == false && cbxRespCorrecta2.Checked == false)
                {
                    MessageBox.Show("Debe ingresar una respuesta correcta.", "Error: respuesta correcta no ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ContadorRespuestas2--;
                    return;
                }

                IngresarR2();

                if (ContadorRespuestas2 == 4)
                    BloquearRespuesta2();

                txtRespuesta2.Focus();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            BloquearRespuesta2();

            gestorPreguntas.ModificarPregunta(clasePregunta2);

            MostrarListadoGeneral();
            MostrarListadoPorUnidad();

            clasePregunta2 = new ClasePregunta();
            respuesta2 = new List<string>();
            ContadorRespuestas2 = 0;
            banderaRespuesta2 = false;

            lblIDPregunta.Enabled = true;
            txtIDpregunta.Enabled = true;
            txtIDpregunta.Focus();

            btnIngresarIDPregunta.Enabled = true;
            btnIngresarIDPregunta.BackColor = Color.FromArgb(219, 226, 239);

            btnModificar.Enabled = false;
            btnModificar.BackColor = Color.Gainsboro;
        }

        private void dgvListadoGeneral_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                FileInfo archivo = new FileInfo(archivoPreguntasExamenes);

                int IDparaEliminar = (int)dgvListadoGeneral.Rows[e.RowIndex].Cells[0].Value;

                gestorPreguntas.EliminarPregunta(IDparaEliminar);

                MostrarListadoGeneral();
                MostrarListadoPorUnidad();

                if (archivo.Length == 0)
                {
                    File.Delete(archivoPreguntasExamenes);
                    gbxModPreg.Enabled = false;
                    btnIngresarIDPregunta.BackColor = Color.Gainsboro;
                }
            }
        }

        private void dgvListadoPorUnidad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                FileInfo archivo = new FileInfo(archivoPreguntasExamenes);

                int IDparaEliminar = (int)dgvListadoPorUnidad.Rows[e.RowIndex].Cells[0].Value;

                gestorPreguntas.EliminarPregunta(IDparaEliminar);

                MostrarListadoGeneral();
                MostrarListadoPorUnidad();

                if (archivo.Length == 0)
                {
                    File.Delete(archivoPreguntasExamenes);
                    gbxModPreg.Enabled = false;
                    btnIngresarIDPregunta.BackColor = Color.Gainsboro;
                }
            }
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
