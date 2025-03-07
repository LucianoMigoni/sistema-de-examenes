namespace Generacion_Examen_Texto
{
    partial class frmGenArchExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenArchExam));
            lblGeneracionArchivo = new Label();
            lblExamen = new Label();
            gbxDatosCabecera = new GroupBox();
            cmbID = new ComboBox();
            tbFecha = new DateTimePicker();
            tbUniversidad = new TextBox();
            tbCarrera = new TextBox();
            btnGenerarCabecera = new Button();
            lblIDExamen = new Label();
            lblFecha = new Label();
            lblCarrera = new Label();
            lblUniversidad = new Label();
            gbxDatosImpresion = new GroupBox();
            tbNombreArchivo = new TextBox();
            lblNombreArchivo = new Label();
            btnGenerarImpresion = new Button();
            label11 = new Label();
            btnVolverAlMenu = new Button();
            btnSalirDelPrograma = new Button();
            gbxGeneracionArchivo = new GroupBox();
            gbxDatosCabecera.SuspendLayout();
            gbxDatosImpresion.SuspendLayout();
            gbxGeneracionArchivo.SuspendLayout();
            SuspendLayout();
            // 
            // lblGeneracionArchivo
            // 
            lblGeneracionArchivo.AutoSize = true;
            lblGeneracionArchivo.BackColor = Color.Transparent;
            lblGeneracionArchivo.FlatStyle = FlatStyle.Popup;
            lblGeneracionArchivo.Font = new Font("Myanmar Text", 24F, FontStyle.Bold);
            lblGeneracionArchivo.ForeColor = Color.FromArgb(17, 45, 78);
            lblGeneracionArchivo.Location = new Point(70, 19);
            lblGeneracionArchivo.Name = "lblGeneracionArchivo";
            lblGeneracionArchivo.Size = new Size(410, 56);
            lblGeneracionArchivo.TabIndex = 1;
            lblGeneracionArchivo.Text = "Generación de Archivo de";
            // 
            // lblExamen
            // 
            lblExamen.AutoSize = true;
            lblExamen.BackColor = Color.Transparent;
            lblExamen.Font = new Font("Myanmar Text", 24F, FontStyle.Bold);
            lblExamen.ForeColor = Color.FromArgb(63, 114, 175);
            lblExamen.Location = new Point(468, 19);
            lblExamen.Name = "lblExamen";
            lblExamen.Size = new Size(141, 56);
            lblExamen.TabIndex = 2;
            lblExamen.Text = "Exámen";
            // 
            // gbxDatosCabecera
            // 
            gbxDatosCabecera.BackColor = Color.Transparent;
            gbxDatosCabecera.Controls.Add(cmbID);
            gbxDatosCabecera.Controls.Add(tbFecha);
            gbxDatosCabecera.Controls.Add(tbUniversidad);
            gbxDatosCabecera.Controls.Add(tbCarrera);
            gbxDatosCabecera.Controls.Add(btnGenerarCabecera);
            gbxDatosCabecera.Controls.Add(lblIDExamen);
            gbxDatosCabecera.Controls.Add(lblFecha);
            gbxDatosCabecera.Controls.Add(lblCarrera);
            gbxDatosCabecera.Controls.Add(lblUniversidad);
            gbxDatosCabecera.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold);
            gbxDatosCabecera.ForeColor = Color.FromArgb(17, 45, 78);
            gbxDatosCabecera.Location = new Point(18, 23);
            gbxDatosCabecera.Name = "gbxDatosCabecera";
            gbxDatosCabecera.Size = new Size(303, 295);
            gbxDatosCabecera.TabIndex = 4;
            gbxDatosCabecera.TabStop = false;
            gbxDatosCabecera.Text = " Datos de la Cabecera ";
            // 
            // cmbID
            // 
            cmbID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbID.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbID.FormattingEnabled = true;
            cmbID.Location = new Point(124, 39);
            cmbID.Name = "cmbID";
            cmbID.Size = new Size(150, 31);
            cmbID.TabIndex = 6;
            // 
            // tbFecha
            // 
            tbFecha.CalendarFont = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbFecha.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbFecha.Location = new Point(124, 116);
            tbFecha.Name = "tbFecha";
            tbFecha.Size = new Size(150, 32);
            tbFecha.TabIndex = 10;
            // 
            // tbUniversidad
            // 
            tbUniversidad.Font = new Font("Myanmar Text", 9.75F);
            tbUniversidad.Location = new Point(124, 157);
            tbUniversidad.MaxLength = 60;
            tbUniversidad.Name = "tbUniversidad";
            tbUniversidad.Size = new Size(150, 32);
            tbUniversidad.TabIndex = 12;
            tbUniversidad.TextAlign = HorizontalAlignment.Center;
            // 
            // tbCarrera
            // 
            tbCarrera.Font = new Font("Myanmar Text", 9.75F);
            tbCarrera.Location = new Point(124, 78);
            tbCarrera.MaxLength = 60;
            tbCarrera.Name = "tbCarrera";
            tbCarrera.Size = new Size(150, 32);
            tbCarrera.TabIndex = 8;
            tbCarrera.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGenerarCabecera
            // 
            btnGenerarCabecera.BackColor = Color.FromArgb(219, 226, 239);
            btnGenerarCabecera.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnGenerarCabecera.Location = new Point(80, 246);
            btnGenerarCabecera.Name = "btnGenerarCabecera";
            btnGenerarCabecera.Size = new Size(149, 31);
            btnGenerarCabecera.TabIndex = 13;
            btnGenerarCabecera.Text = "Generar Cabecera";
            btnGenerarCabecera.UseVisualStyleBackColor = false;
            btnGenerarCabecera.Click += btnGenerarCabecera_Click_1;
            // 
            // lblIDExamen
            // 
            lblIDExamen.AutoSize = true;
            lblIDExamen.ForeColor = Color.FromArgb(63, 114, 175);
            lblIDExamen.Location = new Point(19, 43);
            lblIDExamen.Name = "lblIDExamen";
            lblIDExamen.Size = new Size(99, 24);
            lblIDExamen.TabIndex = 5;
            lblIDExamen.Text = "ID de examen:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = Color.FromArgb(63, 114, 175);
            lblFecha.Location = new Point(19, 119);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(49, 24);
            lblFecha.TabIndex = 9;
            lblFecha.Text = "Fecha:";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.ForeColor = Color.FromArgb(63, 114, 175);
            lblCarrera.Location = new Point(19, 81);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(58, 24);
            lblCarrera.TabIndex = 7;
            lblCarrera.Text = "Carrera:";
            // 
            // lblUniversidad
            // 
            lblUniversidad.AutoSize = true;
            lblUniversidad.ForeColor = Color.FromArgb(63, 114, 175);
            lblUniversidad.Location = new Point(19, 162);
            lblUniversidad.Name = "lblUniversidad";
            lblUniversidad.Size = new Size(87, 24);
            lblUniversidad.TabIndex = 11;
            lblUniversidad.Text = "Universidad:";
            // 
            // gbxDatosImpresion
            // 
            gbxDatosImpresion.BackColor = Color.Transparent;
            gbxDatosImpresion.Controls.Add(tbNombreArchivo);
            gbxDatosImpresion.Controls.Add(lblNombreArchivo);
            gbxDatosImpresion.Controls.Add(btnGenerarImpresion);
            gbxDatosImpresion.Controls.Add(label11);
            gbxDatosImpresion.Enabled = false;
            gbxDatosImpresion.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold);
            gbxDatosImpresion.ForeColor = Color.FromArgb(17, 45, 78);
            gbxDatosImpresion.Location = new Point(331, 23);
            gbxDatosImpresion.Name = "gbxDatosImpresion";
            gbxDatosImpresion.Size = new Size(311, 295);
            gbxDatosImpresion.TabIndex = 14;
            gbxDatosImpresion.TabStop = false;
            gbxDatosImpresion.Text = " Datos de la Impresión ";
            // 
            // tbNombreArchivo
            // 
            tbNombreArchivo.Font = new Font("Myanmar Text", 9.75F);
            tbNombreArchivo.Location = new Point(141, 40);
            tbNombreArchivo.MaxLength = 120;
            tbNombreArchivo.Name = "tbNombreArchivo";
            tbNombreArchivo.Size = new Size(150, 32);
            tbNombreArchivo.TabIndex = 16;
            tbNombreArchivo.TextAlign = HorizontalAlignment.Center;
            // 
            // lblNombreArchivo
            // 
            lblNombreArchivo.AutoSize = true;
            lblNombreArchivo.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold);
            lblNombreArchivo.ForeColor = Color.FromArgb(63, 114, 175);
            lblNombreArchivo.Location = new Point(20, 43);
            lblNombreArchivo.Name = "lblNombreArchivo";
            lblNombreArchivo.Size = new Size(115, 24);
            lblNombreArchivo.TabIndex = 15;
            lblNombreArchivo.Text = "Nombre Archivo:";
            // 
            // btnGenerarImpresion
            // 
            btnGenerarImpresion.BackColor = Color.FromArgb(219, 226, 239);
            btnGenerarImpresion.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnGenerarImpresion.ForeColor = Color.FromArgb(17, 45, 78);
            btnGenerarImpresion.Location = new Point(81, 246);
            btnGenerarImpresion.Name = "btnGenerarImpresion";
            btnGenerarImpresion.Size = new Size(149, 31);
            btnGenerarImpresion.TabIndex = 17;
            btnGenerarImpresion.Text = "Generar Impresión";
            btnGenerarImpresion.UseVisualStyleBackColor = false;
            btnGenerarImpresion.Click += btnGenerarImpresion_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold);
            label11.Location = new Point(6, 119);
            label11.Name = "label11";
            label11.Size = new Size(0, 24);
            label11.TabIndex = 3;
            // 
            // btnVolverAlMenu
            // 
            btnVolverAlMenu.BackColor = Color.FromArgb(219, 226, 239);
            btnVolverAlMenu.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnVolverAlMenu.ForeColor = Color.FromArgb(17, 45, 78);
            btnVolverAlMenu.Location = new Point(122, 423);
            btnVolverAlMenu.Name = "btnVolverAlMenu";
            btnVolverAlMenu.Size = new Size(187, 33);
            btnVolverAlMenu.TabIndex = 18;
            btnVolverAlMenu.Text = "Volver al Menú Principal";
            btnVolverAlMenu.UseVisualStyleBackColor = false;
            btnVolverAlMenu.Click += btnVolverAlMenu_Click;
            // 
            // btnSalirDelPrograma
            // 
            btnSalirDelPrograma.BackColor = Color.FromArgb(219, 226, 239);
            btnSalirDelPrograma.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnSalirDelPrograma.ForeColor = Color.FromArgb(17, 45, 78);
            btnSalirDelPrograma.Location = new Point(369, 423);
            btnSalirDelPrograma.Name = "btnSalirDelPrograma";
            btnSalirDelPrograma.Size = new Size(187, 31);
            btnSalirDelPrograma.TabIndex = 19;
            btnSalirDelPrograma.Text = "Salir del programa";
            btnSalirDelPrograma.UseVisualStyleBackColor = false;
            btnSalirDelPrograma.Click += btnSalirDelPrograma_Click;
            // 
            // gbxGeneracionArchivo
            // 
            gbxGeneracionArchivo.BackColor = Color.Transparent;
            gbxGeneracionArchivo.Controls.Add(gbxDatosCabecera);
            gbxGeneracionArchivo.Controls.Add(gbxDatosImpresion);
            gbxGeneracionArchivo.Location = new Point(12, 68);
            gbxGeneracionArchivo.Name = "gbxGeneracionArchivo";
            gbxGeneracionArchivo.Size = new Size(662, 337);
            gbxGeneracionArchivo.TabIndex = 3;
            gbxGeneracionArchivo.TabStop = false;
            // 
            // frmGenArchExam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Generación_de_Archivo_Texto_Exámenes.Properties.Resources.Back;
            ClientSize = new Size(691, 477);
            Controls.Add(gbxGeneracionArchivo);
            Controls.Add(btnSalirDelPrograma);
            Controls.Add(btnVolverAlMenu);
            Controls.Add(lblExamen);
            Controls.Add(lblGeneracionArchivo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(707, 516);
            MinimumSize = new Size(707, 516);
            Name = "frmGenArchExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generación Archivo de Exámen";
            gbxDatosCabecera.ResumeLayout(false);
            gbxDatosCabecera.PerformLayout();
            gbxDatosImpresion.ResumeLayout(false);
            gbxDatosImpresion.PerformLayout();
            gbxGeneracionArchivo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGeneracionArchivo;
        private Label lblExamen;
        private GroupBox gbxDatosCabecera;
        private TextBox tbCarrera;
        private TextBox tbUniversidad;
        private Button btnGenerarCabecera;
        private Label lblIDExamen;
        private Label lblFecha;
        private Label lblCarrera;
        private Label lblUniversidad;
        private GroupBox gbxDatosImpresion;
        private Button btnGenerarImpresion;
        private Label label11;
        private Button btnVolverAlMenu;
        private Button btnSalirDelPrograma;
        private GroupBox gbxGeneracionArchivo;
        private Label lblNombreArchivo;
        private TextBox tbNombreArchivo;
        private DateTimePicker tbFecha;
        private ComboBox cmbID;
    }
}
