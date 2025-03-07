using Generación_de_Exámenes;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;

namespace Modulo_G_Examenes
{
    public partial class frmGenEx : Form
    {
        public frmGenEx()
        {
            InitializeComponent();
        }

        GestorExamenes gestor = new GestorExamenes();

        // Función que toma el valor de la asignatura y carga sus unidades
        private void cmbAsignatura_SelectedValueChanged(object sender, EventArgs e)
        {
            int asignaturaSeleccionada = cmbAsignatura.SelectedIndex;
            gestor.CargarAsignaturasUnidades(asignaturaSeleccionada, cmbAsignatura, cmbUnidad);
        }


        private void btnAgregarUnidad_Click(object sender, EventArgs e)
        {
            if (cmbUnidad.SelectedItem != null)
            {
                gestor.AñadirUnidades(
                    cmbUnidad.SelectedIndex,
                    cmbUnidad.SelectedItem?.ToString() ?? string.Empty,
                    lblNumTotPreg,
                    lblNumUnidades
                );
                cmbAsignatura.Enabled = false;
                btnGenerarExamen.Enabled = true;
            }
            else
            {
                MessageBox.Show(
                    "No se ha ingresado ninguna asignatura, por favor ingrese una antes de agregar una unidad.",
                    "Error: Asignatura sin seleccionar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Lógica para generar un examen txt
        private void btnGenerarExamen_Click(object sender, EventArgs e)
        {
            gestor.GenerarArchivoTxt(dtpFecha.Value, cmbAsignatura);
            gestor.CargarDatosDGV(dgvListadoExamenes, dgvPreguntas);
            gestor.ReiniciarExamen(lblNumTotPreg, lblNumUnidades);

            btnGenerarExamen.Enabled = false;
            cmbAsignatura.Enabled = true;
        }

        // Función para eliminar un examen por completo
        private void dgvListadoExamenes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int indiceFila = e.RowIndex;

                var id = dgvListadoExamenes.Rows[indiceFila].Cells[0].Value;

                gestor.BorrarExamen(dgvListadoExamenes, Convert.ToInt32(id));

                gestor.CargarDatosDGV(dgvListadoExamenes, dgvPreguntas);
            }
        }

        // Lógica para eliminar preguntas
        private void dgvPreguntas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int indiceFila = e.RowIndex;

                var id = dgvPreguntas.Rows[indiceFila].Cells[0].Value;

                var pregunta = dgvPreguntas.Rows[indiceFila].Cells[2].Value;

                gestor.BorrarPregunta(dgvListadoExamenes, 
                    dgvPreguntas, 
                    pregunta.ToString() ?? string.Empty, 
                    Convert.ToInt32(id)
                );

                gestor.CargarDatosDGV(dgvListadoExamenes, dgvPreguntas);
            }
        }

        private void frmGenEx_Load(object sender, EventArgs e)
        {
            // Al cargar, pasamos el indice la primer unidad (0) a la función para cargar asignaturas
            gestor.CargarAsignaturasUnidades(0, cmbAsignatura, cmbUnidad);
            gestor.CargarDatosDGV(dgvListadoExamenes, dgvPreguntas);
        }

        private void btnVolverAlMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Lógica de salida de programa
        private void btnSalirDelPrograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
