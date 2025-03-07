namespace Menu_Principal
{
    partial class frmMenúPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenúPrincipal));
            btnAdmBancPreg = new Button();
            lblMenú = new Label();
            lblPrincipal = new Label();
            btnModGenEx = new Button();
            btnGenArchText = new Button();
            btnModCorrec = new Button();
            btnSalirDelPrograma = new Button();
            SuspendLayout();
            // 
            // btnAdmBancPreg
            // 
            btnAdmBancPreg.BackColor = Color.FromArgb(219, 226, 239);
            btnAdmBancPreg.Cursor = Cursors.Hand;
            resources.ApplyResources(btnAdmBancPreg, "btnAdmBancPreg");
            btnAdmBancPreg.ForeColor = Color.FromArgb(17, 45, 78);
            btnAdmBancPreg.Name = "btnAdmBancPreg";
            btnAdmBancPreg.UseVisualStyleBackColor = false;
            btnAdmBancPreg.Click += btnAdmBancPreg_Click;
            // 
            // lblMenú
            // 
            resources.ApplyResources(lblMenú, "lblMenú");
            lblMenú.BackColor = Color.Transparent;
            lblMenú.ForeColor = Color.FromArgb(17, 45, 78);
            lblMenú.Name = "lblMenú";
            // 
            // lblPrincipal
            // 
            resources.ApplyResources(lblPrincipal, "lblPrincipal");
            lblPrincipal.BackColor = Color.Transparent;
            lblPrincipal.ForeColor = Color.FromArgb(63, 114, 175);
            lblPrincipal.Name = "lblPrincipal";
            // 
            // btnModGenEx
            // 
            btnModGenEx.BackColor = Color.FromArgb(219, 226, 239);
            btnModGenEx.Cursor = Cursors.Hand;
            resources.ApplyResources(btnModGenEx, "btnModGenEx");
            btnModGenEx.ForeColor = Color.FromArgb(17, 45, 78);
            btnModGenEx.Name = "btnModGenEx";
            btnModGenEx.UseVisualStyleBackColor = false;
            btnModGenEx.Click += btnModGenEx_Click;
            // 
            // btnGenArchText
            // 
            btnGenArchText.BackColor = Color.FromArgb(219, 226, 239);
            btnGenArchText.Cursor = Cursors.Hand;
            resources.ApplyResources(btnGenArchText, "btnGenArchText");
            btnGenArchText.ForeColor = Color.FromArgb(17, 45, 78);
            btnGenArchText.Name = "btnGenArchText";
            btnGenArchText.UseVisualStyleBackColor = false;
            btnGenArchText.Click += btnGenArchText_Click;
            // 
            // btnModCorrec
            // 
            btnModCorrec.BackColor = Color.FromArgb(219, 226, 239);
            btnModCorrec.Cursor = Cursors.Hand;
            resources.ApplyResources(btnModCorrec, "btnModCorrec");
            btnModCorrec.ForeColor = Color.FromArgb(17, 45, 78);
            btnModCorrec.Name = "btnModCorrec";
            btnModCorrec.UseVisualStyleBackColor = false;
            btnModCorrec.Click += btnModCorrec_Click;
            // 
            // btnSalirDelPrograma
            // 
            btnSalirDelPrograma.BackColor = Color.FromArgb(219, 226, 239);
            btnSalirDelPrograma.Cursor = Cursors.Hand;
            resources.ApplyResources(btnSalirDelPrograma, "btnSalirDelPrograma");
            btnSalirDelPrograma.ForeColor = Color.FromArgb(17, 45, 78);
            btnSalirDelPrograma.Name = "btnSalirDelPrograma";
            btnSalirDelPrograma.UseVisualStyleBackColor = false;
            btnSalirDelPrograma.Click += btnSalirDelPrograma_Click;
            // 
            // frmMenúPrincipal
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Menú_Principal.Properties.Resources.Back;
            Controls.Add(btnAdmBancPreg);
            Controls.Add(btnModGenEx);
            Controls.Add(btnSalirDelPrograma);
            Controls.Add(btnModCorrec);
            Controls.Add(btnGenArchText);
            Controls.Add(lblPrincipal);
            Controls.Add(lblMenú);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMenúPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdmBancPreg;
        private Label lblMenú;
        private Label lblPrincipal;
        private Button btnModGenEx;
        private Button btnGenArchText;
        private Button btnModCorrec;
        private Button btnSalirDelPrograma;
    }
}
