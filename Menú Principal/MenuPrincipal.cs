using Administracion_Banco_Preguntas;
using Generacion_Examen_Texto;
using Modulo_C_Examenes;
using Modulo_G_Examenes;
using System.Windows.Forms;

namespace Menu_Principal
{
    public partial class frmMenúPrincipal : Form
    {
        public frmMenúPrincipal()
        {
            InitializeComponent();
        }


        private void btnAdmBancPreg_Click(object sender, EventArgs e)
        {
            Hide();

            frmMenuAdminBancPreg AdminEx = new frmMenuAdminBancPreg();
            AdminEx.Show();

            MostrarForm(AdminEx);
        }

        private void btnModGenEx_Click(object sender, EventArgs e)
        {
            Hide();

            frmGenEx GenEx = new frmGenEx();
            GenEx.Show();

            MostrarForm(GenEx);
        }

        private void btnGenArchText_Click(object sender, EventArgs e)
        {
            Hide();

            frmGenArchExam GenArcEx = new frmGenArchExam();
            GenArcEx.Show();

            MostrarForm(GenArcEx);
        }

        private void btnModCorrec_Click(object sender, EventArgs e)
        {
            Hide();

            frmCorEx CorrecEx = new frmCorEx();
            CorrecEx.Show();

            MostrarForm(CorrecEx);
        }

        // Mostrar el formulario principal cuando el secundario se cierre
        void MostrarForm(Form form)
        {
            form.FormClosed += (s, args) => Show();
        }

        // Logica para salir del programa
        private void btnSalirDelPrograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
