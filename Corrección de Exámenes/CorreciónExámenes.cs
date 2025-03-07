using Corrección_de_Exámenes;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Modulo_C_Examenes
{
    public partial class frmCorEx : Form
    {
        public frmCorEx()
        {
            InitializeComponent();
        }

        private void frmCorEx_Load(object sender, EventArgs e)
        {
            gestor.ObtenerId(cmbID);
        }

        GestorCorrecEx gestor = new GestorCorrecEx();

        string Nombre;
        string Apellido;
        string Id;

        // Entero para saber el numero de pregunta
        int numPreg = 0;

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Nombre = tbNombre.Text;
                if (string.IsNullOrEmpty(Nombre))
                {
                    MessageBox.Show($"Por favor complete la casilla de Nombre", $"Error: Nombre inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show($"Por favor ingrese un nombre válido", $"Error: Nombre inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Apellido = tbApellido.Text;
                if (string.IsNullOrEmpty(Apellido))
                {
                    MessageBox.Show($"Por favor complete la casilla de Apellido", $"Error: Apellido inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show($"Por favor ingrese un apellido válido", $"Error: Apellido inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            gbxDatosAlumno.Enabled = false;
            gbxDatosExamen.Enabled = true;
        }

        private void btnObtenerExamen_Click(object sender, EventArgs e)
        {
            try
            {
                Id = cmbID.Text;
                if (string.IsNullOrEmpty(Id))
                {
                    MessageBox.Show($"Por favor complete la casilla de ID", $"Error: ID inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show($"Por favor seleccione un ID válido", $"Error: ID inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            gbxDatosExamen.Enabled = false;
            gbxExamen.Enabled = true;

            numPreg = 0;

            gestor.AgregarDatos(lblPreguntaAContestar, 
                cmbRespuestas, 
                lblNumPregunta, 
                gbxExamen, 
                gbxDatosAlumno, 
                gbxCorrecionExamen, 
                dgvDatosRespuestas, 
                lblNumTotPregs, 
                lblNumRespCorrectas, 
                lblNumNota, 
                Id, 
                numPreg, 
                tbNombre.Text, 
                tbApellido.Text);
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (cmbRespuestas.Text != string.Empty)
            {
                gestor.AgregarRespuestas(cmbRespuestas, numPreg);
                numPreg++;
                gestor.AgregarDatos(lblPreguntaAContestar, 
                    cmbRespuestas, 
                    lblNumPregunta, 
                    gbxExamen, 
                    gbxDatosAlumno, 
                    gbxCorrecionExamen, 
                    dgvDatosRespuestas, 
                    lblNumTotPregs, 
                    lblNumRespCorrectas, 
                    lblNumNota, 
                    Id, 
                    numPreg, 
                    tbNombre.Text, 
                    tbApellido.Text);
            } else
            {
                MessageBox.Show("Por favor, seleccione una respuesta", "Error: Respuesta Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnVolverAlMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Logica salida del archivo
        private void btnSalirDelPrograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
