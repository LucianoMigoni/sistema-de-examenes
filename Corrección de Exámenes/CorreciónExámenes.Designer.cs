namespace Modulo_C_Examenes
{
    partial class frmCorEx
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCorEx));
            gbxIngresoDatos = new GroupBox();
            gbxDatosExamen = new GroupBox();
            btnObtenerExamen = new Button();
            cmbID = new ComboBox();
            lblID = new Label();
            gbxDatosAlumno = new GroupBox();
            btnIngresar = new Button();
            tbApellido = new TextBox();
            tbNombre = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            lblExamenes = new Label();
            lblCorrecionDe = new Label();
            btnSalirDelPrograma = new Button();
            btnVolverAlMenu = new Button();
            gbxExamen = new GroupBox();
            lblNumPregunta = new Label();
            btnResponder = new Button();
            cmbRespuestas = new ComboBox();
            lblRespuesta = new Label();
            lblPreguntaAContestar = new Label();
            lblPregunta = new Label();
            gbxCorrecionExamen = new GroupBox();
            dgvDatosRespuestas = new DataGridView();
            lblExamen = new Label();
            lblNumRespCorrectas = new Label();
            lblDatosDel = new Label();
            lblNota = new Label();
            lblRespCorrectas = new Label();
            lblNumNota = new Label();
            lblNumTotPregs = new Label();
            lblTotPregs = new Label();
            gbxCorrecionExamenes = new GroupBox();
            Respuesta = new DataGridViewTextBoxColumn();
            RespuestaCorrecta = new DataGridViewTextBoxColumn();
            gbxIngresoDatos.SuspendLayout();
            gbxDatosExamen.SuspendLayout();
            gbxDatosAlumno.SuspendLayout();
            gbxExamen.SuspendLayout();
            gbxCorrecionExamen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosRespuestas).BeginInit();
            gbxCorrecionExamenes.SuspendLayout();
            SuspendLayout();
            // 
            // gbxIngresoDatos
            // 
            gbxIngresoDatos.BackColor = Color.Transparent;
            gbxIngresoDatos.Controls.Add(gbxDatosExamen);
            gbxIngresoDatos.Controls.Add(gbxDatosAlumno);
            gbxIngresoDatos.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold);
            gbxIngresoDatos.ForeColor = Color.FromArgb(17, 45, 78);
            gbxIngresoDatos.Location = new Point(19, 22);
            gbxIngresoDatos.Name = "gbxIngresoDatos";
            gbxIngresoDatos.Size = new Size(655, 198);
            gbxIngresoDatos.TabIndex = 4;
            gbxIngresoDatos.TabStop = false;
            gbxIngresoDatos.Text = " Ingreso de Datos ";
            // 
            // gbxDatosExamen
            // 
            gbxDatosExamen.BackColor = Color.Transparent;
            gbxDatosExamen.Controls.Add(btnObtenerExamen);
            gbxDatosExamen.Controls.Add(cmbID);
            gbxDatosExamen.Controls.Add(lblID);
            gbxDatosExamen.Enabled = false;
            gbxDatosExamen.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold);
            gbxDatosExamen.ForeColor = Color.FromArgb(17, 45, 78);
            gbxDatosExamen.Location = new Point(415, 22);
            gbxDatosExamen.Name = "gbxDatosExamen";
            gbxDatosExamen.Size = new Size(223, 163);
            gbxDatosExamen.TabIndex = 11;
            gbxDatosExamen.TabStop = false;
            gbxDatosExamen.Text = " Datos Exámen ";
            // 
            // btnObtenerExamen
            // 
            btnObtenerExamen.BackColor = Color.FromArgb(219, 226, 239);
            btnObtenerExamen.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnObtenerExamen.ForeColor = Color.FromArgb(17, 45, 78);
            btnObtenerExamen.Location = new Point(60, 93);
            btnObtenerExamen.Name = "btnObtenerExamen";
            btnObtenerExamen.Size = new Size(124, 33);
            btnObtenerExamen.TabIndex = 14;
            btnObtenerExamen.Text = "Obtener Examen";
            btnObtenerExamen.UseVisualStyleBackColor = false;
            btnObtenerExamen.Click += btnObtenerExamen_Click;
            // 
            // cmbID
            // 
            cmbID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbID.FormattingEnabled = true;
            cmbID.Location = new Point(60, 44);
            cmbID.Name = "cmbID";
            cmbID.Size = new Size(124, 32);
            cmbID.TabIndex = 13;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.ForeColor = Color.FromArgb(63, 114, 175);
            lblID.Location = new Point(26, 50);
            lblID.Name = "lblID";
            lblID.Size = new Size(28, 24);
            lblID.TabIndex = 12;
            lblID.Text = "ID:";
            // 
            // gbxDatosAlumno
            // 
            gbxDatosAlumno.BackColor = Color.Transparent;
            gbxDatosAlumno.Controls.Add(btnIngresar);
            gbxDatosAlumno.Controls.Add(tbApellido);
            gbxDatosAlumno.Controls.Add(tbNombre);
            gbxDatosAlumno.Controls.Add(lblApellido);
            gbxDatosAlumno.Controls.Add(lblNombre);
            gbxDatosAlumno.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold);
            gbxDatosAlumno.ForeColor = Color.FromArgb(17, 45, 78);
            gbxDatosAlumno.Location = new Point(21, 22);
            gbxDatosAlumno.Name = "gbxDatosAlumno";
            gbxDatosAlumno.Size = new Size(388, 163);
            gbxDatosAlumno.TabIndex = 5;
            gbxDatosAlumno.TabStop = false;
            gbxDatosAlumno.Text = " Datos Alumno ";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(219, 226, 239);
            btnIngresar.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.FromArgb(17, 45, 78);
            btnIngresar.Location = new Point(140, 115);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(124, 33);
            btnIngresar.TabIndex = 10;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // tbApellido
            // 
            tbApellido.Font = new Font("Myanmar Text", 9.75F);
            tbApellido.Location = new Point(95, 69);
            tbApellido.MaxLength = 60;
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(278, 32);
            tbApellido.TabIndex = 9;
            tbApellido.TextAlign = HorizontalAlignment.Center;
            // 
            // tbNombre
            // 
            tbNombre.Font = new Font("Myanmar Text", 9.75F);
            tbNombre.Location = new Point(95, 31);
            tbNombre.MaxLength = 60;
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(278, 32);
            tbNombre.TabIndex = 7;
            tbNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.ForeColor = Color.FromArgb(63, 114, 175);
            lblApellido.Location = new Point(25, 72);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 24);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.FromArgb(63, 114, 175);
            lblNombre.Location = new Point(25, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 24);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre:";
            // 
            // lblExamenes
            // 
            lblExamenes.AutoSize = true;
            lblExamenes.BackColor = Color.Transparent;
            lblExamenes.Font = new Font("Myanmar Text", 24F, FontStyle.Bold);
            lblExamenes.ForeColor = Color.FromArgb(63, 114, 175);
            lblExamenes.Location = new Point(652, 15);
            lblExamenes.Name = "lblExamenes";
            lblExamenes.Size = new Size(172, 56);
            lblExamenes.TabIndex = 2;
            lblExamenes.Text = "Exámenes";
            // 
            // lblCorrecionDe
            // 
            lblCorrecionDe.AutoSize = true;
            lblCorrecionDe.BackColor = Color.Transparent;
            lblCorrecionDe.Font = new Font("Myanmar Text", 24F, FontStyle.Bold);
            lblCorrecionDe.ForeColor = Color.FromArgb(17, 45, 78);
            lblCorrecionDe.Location = new Point(451, 15);
            lblCorrecionDe.Name = "lblCorrecionDe";
            lblCorrecionDe.Size = new Size(216, 56);
            lblCorrecionDe.TabIndex = 1;
            lblCorrecionDe.Text = "Correción de";
            // 
            // btnSalirDelPrograma
            // 
            btnSalirDelPrograma.BackColor = Color.FromArgb(219, 226, 239);
            btnSalirDelPrograma.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnSalirDelPrograma.ForeColor = Color.FromArgb(17, 45, 78);
            btnSalirDelPrograma.Location = new Point(652, 471);
            btnSalirDelPrograma.Name = "btnSalirDelPrograma";
            btnSalirDelPrograma.Size = new Size(186, 33);
            btnSalirDelPrograma.TabIndex = 33;
            btnSalirDelPrograma.Text = "Salir del Programa";
            btnSalirDelPrograma.UseVisualStyleBackColor = false;
            btnSalirDelPrograma.Click += btnSalirDelPrograma_Click;
            // 
            // btnVolverAlMenu
            // 
            btnVolverAlMenu.BackColor = Color.FromArgb(219, 226, 239);
            btnVolverAlMenu.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnVolverAlMenu.ForeColor = Color.FromArgb(17, 45, 78);
            btnVolverAlMenu.Location = new Point(429, 471);
            btnVolverAlMenu.Name = "btnVolverAlMenu";
            btnVolverAlMenu.Size = new Size(189, 33);
            btnVolverAlMenu.TabIndex = 32;
            btnVolverAlMenu.Text = "Volver al Menú Principal";
            btnVolverAlMenu.UseVisualStyleBackColor = false;
            btnVolverAlMenu.Click += btnVolverAlMenu_Click;
            // 
            // gbxExamen
            // 
            gbxExamen.BackColor = Color.Transparent;
            gbxExamen.Controls.Add(lblNumPregunta);
            gbxExamen.Controls.Add(btnResponder);
            gbxExamen.Controls.Add(cmbRespuestas);
            gbxExamen.Controls.Add(lblRespuesta);
            gbxExamen.Controls.Add(lblPreguntaAContestar);
            gbxExamen.Controls.Add(lblPregunta);
            gbxExamen.Enabled = false;
            gbxExamen.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold);
            gbxExamen.ForeColor = Color.FromArgb(17, 45, 78);
            gbxExamen.Location = new Point(19, 219);
            gbxExamen.Name = "gbxExamen";
            gbxExamen.Size = new Size(655, 141);
            gbxExamen.TabIndex = 15;
            gbxExamen.TabStop = false;
            gbxExamen.Text = " Exámen ";
            // 
            // lblNumPregunta
            // 
            lblNumPregunta.AutoSize = true;
            lblNumPregunta.ForeColor = Color.FromArgb(63, 114, 175);
            lblNumPregunta.Location = new Point(545, 28);
            lblNumPregunta.Name = "lblNumPregunta";
            lblNumPregunta.Size = new Size(93, 24);
            lblNumPregunta.TabIndex = 18;
            lblNumPregunta.Text = "Pregunta 1/--";
            // 
            // btnResponder
            // 
            btnResponder.BackColor = Color.FromArgb(219, 226, 239);
            btnResponder.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnResponder.ForeColor = Color.FromArgb(17, 45, 78);
            btnResponder.Location = new Point(545, 86);
            btnResponder.Name = "btnResponder";
            btnResponder.Size = new Size(93, 34);
            btnResponder.TabIndex = 21;
            btnResponder.Text = "Responder";
            btnResponder.UseVisualStyleBackColor = false;
            btnResponder.Click += btnResponder_Click;
            // 
            // cmbRespuestas
            // 
            cmbRespuestas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRespuestas.FormattingEnabled = true;
            cmbRespuestas.Location = new Point(106, 87);
            cmbRespuestas.Name = "cmbRespuestas";
            cmbRespuestas.Size = new Size(423, 32);
            cmbRespuestas.TabIndex = 20;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.ForeColor = Color.FromArgb(63, 114, 175);
            lblRespuesta.Location = new Point(21, 93);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(76, 24);
            lblRespuesta.TabIndex = 19;
            lblRespuesta.Text = "Respuesta:";
            // 
            // lblPreguntaAContestar
            // 
            lblPreguntaAContestar.AutoSize = true;
            lblPreguntaAContestar.ForeColor = Color.FromArgb(17, 45, 78);
            lblPreguntaAContestar.Location = new Point(100, 28);
            lblPreguntaAContestar.MaximumSize = new Size(430, 0);
            lblPreguntaAContestar.MinimumSize = new Size(400, 0);
            lblPreguntaAContestar.Name = "lblPreguntaAContestar";
            lblPreguntaAContestar.Size = new Size(400, 24);
            lblPreguntaAContestar.TabIndex = 17;
            lblPreguntaAContestar.Text = "--";
            lblPreguntaAContestar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.ForeColor = Color.FromArgb(63, 114, 175);
            lblPregunta.Location = new Point(21, 28);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(70, 24);
            lblPregunta.TabIndex = 16;
            lblPregunta.Text = "Pregunta:";
            // 
            // gbxCorrecionExamen
            // 
            gbxCorrecionExamen.BackColor = Color.Transparent;
            gbxCorrecionExamen.Controls.Add(dgvDatosRespuestas);
            gbxCorrecionExamen.Controls.Add(lblExamen);
            gbxCorrecionExamen.Controls.Add(lblNumRespCorrectas);
            gbxCorrecionExamen.Controls.Add(lblDatosDel);
            gbxCorrecionExamen.Controls.Add(lblNota);
            gbxCorrecionExamen.Controls.Add(lblRespCorrectas);
            gbxCorrecionExamen.Controls.Add(lblNumNota);
            gbxCorrecionExamen.Controls.Add(lblNumTotPregs);
            gbxCorrecionExamen.Controls.Add(lblTotPregs);
            gbxCorrecionExamen.Enabled = false;
            gbxCorrecionExamen.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold);
            gbxCorrecionExamen.ForeColor = Color.FromArgb(17, 45, 78);
            gbxCorrecionExamen.Location = new Point(689, 22);
            gbxCorrecionExamen.Name = "gbxCorrecionExamen";
            gbxCorrecionExamen.Size = new Size(439, 338);
            gbxCorrecionExamen.TabIndex = 22;
            gbxCorrecionExamen.TabStop = false;
            gbxCorrecionExamen.Text = " Corrección del Exámen ";
            // 
            // dgvDatosRespuestas
            // 
            dgvDatosRespuestas.AllowUserToAddRows = false;
            dgvDatosRespuestas.AllowUserToDeleteRows = false;
            dgvDatosRespuestas.AllowUserToResizeColumns = false;
            dgvDatosRespuestas.AllowUserToResizeRows = false;
            dgvDatosRespuestas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(17, 45, 78);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDatosRespuestas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatosRespuestas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosRespuestas.Columns.AddRange(new DataGridViewColumn[] { Respuesta, RespuestaCorrecta });
            dgvDatosRespuestas.Location = new Point(20, 53);
            dgvDatosRespuestas.Name = "dgvDatosRespuestas";
            dgvDatosRespuestas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(17, 45, 78);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDatosRespuestas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDatosRespuestas.ScrollBars = ScrollBars.Vertical;
            dgvDatosRespuestas.Size = new Size(398, 212);
            dgvDatosRespuestas.TabIndex = 25;
            dgvDatosRespuestas.TabStop = false;
            // 
            // lblExamen
            // 
            lblExamen.AutoSize = true;
            lblExamen.Font = new Font("Myanmar Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExamen.ForeColor = Color.FromArgb(63, 114, 175);
            lblExamen.Location = new Point(219, 22);
            lblExamen.Name = "lblExamen";
            lblExamen.Size = new Size(85, 34);
            lblExamen.TabIndex = 24;
            lblExamen.Text = "Exámen";
            // 
            // lblNumRespCorrectas
            // 
            lblNumRespCorrectas.AutoSize = true;
            lblNumRespCorrectas.Font = new Font("Myanmar Text", 11F, FontStyle.Bold);
            lblNumRespCorrectas.Location = new Point(376, 274);
            lblNumRespCorrectas.Name = "lblNumRespCorrectas";
            lblNumRespCorrectas.Size = new Size(21, 27);
            lblNumRespCorrectas.TabIndex = 29;
            lblNumRespCorrectas.Text = "0";
            // 
            // lblDatosDel
            // 
            lblDatosDel.AutoSize = true;
            lblDatosDel.Font = new Font("Myanmar Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosDel.ForeColor = Color.FromArgb(17, 45, 78);
            lblDatosDel.Location = new Point(130, 22);
            lblDatosDel.Name = "lblDatosDel";
            lblDatosDel.Size = new Size(98, 34);
            lblDatosDel.TabIndex = 23;
            lblDatosDel.Text = "Datos del";
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Myanmar Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNota.ForeColor = Color.FromArgb(63, 114, 175);
            lblNota.Location = new Point(170, 301);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(64, 34);
            lblNota.TabIndex = 30;
            lblNota.Text = "Nota:";
            // 
            // lblRespCorrectas
            // 
            lblRespCorrectas.AutoSize = true;
            lblRespCorrectas.Font = new Font("Myanmar Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRespCorrectas.ForeColor = Color.FromArgb(63, 114, 175);
            lblRespCorrectas.Location = new Point(219, 274);
            lblRespCorrectas.Name = "lblRespCorrectas";
            lblRespCorrectas.Size = new Size(165, 27);
            lblRespCorrectas.TabIndex = 28;
            lblRespCorrectas.Text = "Respuestas Correctas:";
            // 
            // lblNumNota
            // 
            lblNumNota.AutoSize = true;
            lblNumNota.Font = new Font("Myanmar Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumNota.Location = new Point(228, 301);
            lblNumNota.Name = "lblNumNota";
            lblNumNota.Size = new Size(26, 34);
            lblNumNota.TabIndex = 31;
            lblNumNota.Text = "0";
            // 
            // lblNumTotPregs
            // 
            lblNumTotPregs.AutoSize = true;
            lblNumTotPregs.Font = new Font("Myanmar Text", 11F, FontStyle.Bold);
            lblNumTotPregs.Location = new Point(173, 274);
            lblNumTotPregs.Name = "lblNumTotPregs";
            lblNumTotPregs.Size = new Size(21, 27);
            lblNumTotPregs.TabIndex = 27;
            lblNumTotPregs.Text = "0";
            // 
            // lblTotPregs
            // 
            lblTotPregs.AutoSize = true;
            lblTotPregs.Font = new Font("Myanmar Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotPregs.ForeColor = Color.FromArgb(63, 114, 175);
            lblTotPregs.Location = new Point(33, 274);
            lblTotPregs.Name = "lblTotPregs";
            lblTotPregs.Size = new Size(148, 27);
            lblTotPregs.TabIndex = 26;
            lblTotPregs.Text = "Total de preguntas:";
            // 
            // gbxCorrecionExamenes
            // 
            gbxCorrecionExamenes.BackColor = Color.Transparent;
            gbxCorrecionExamenes.Controls.Add(gbxIngresoDatos);
            gbxCorrecionExamenes.Controls.Add(gbxCorrecionExamen);
            gbxCorrecionExamenes.Controls.Add(gbxExamen);
            gbxCorrecionExamenes.Location = new Point(35, 61);
            gbxCorrecionExamenes.Name = "gbxCorrecionExamenes";
            gbxCorrecionExamenes.Size = new Size(1147, 384);
            gbxCorrecionExamenes.TabIndex = 3;
            gbxCorrecionExamenes.TabStop = false;
            // 
            // Respuesta
            // 
            Respuesta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Respuesta.Frozen = true;
            Respuesta.HeaderText = "Respuesta Usuario";
            Respuesta.Name = "Respuesta";
            Respuesta.ReadOnly = true;
            Respuesta.Resizable = DataGridViewTriState.False;
            Respuesta.SortMode = DataGridViewColumnSortMode.NotSortable;
            Respuesta.Width = 178;
            // 
            // RespuestaCorrecta
            // 
            RespuestaCorrecta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            RespuestaCorrecta.Frozen = true;
            RespuestaCorrecta.HeaderText = "Respuesta Correcta";
            RespuestaCorrecta.Name = "RespuestaCorrecta";
            RespuestaCorrecta.ReadOnly = true;
            RespuestaCorrecta.Resizable = DataGridViewTriState.False;
            RespuestaCorrecta.SortMode = DataGridViewColumnSortMode.NotSortable;
            RespuestaCorrecta.Width = 177;
            // 
            // frmCorEx
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Corrección_de_Exámenes.Properties.Resources.Back;
            ClientSize = new Size(1211, 528);
            Controls.Add(gbxCorrecionExamenes);
            Controls.Add(btnSalirDelPrograma);
            Controls.Add(btnVolverAlMenu);
            Controls.Add(lblExamenes);
            Controls.Add(lblCorrecionDe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1227, 567);
            MinimumSize = new Size(1227, 567);
            Name = "frmCorEx";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Corrección de Exámenes";
            Load += frmCorEx_Load;
            gbxIngresoDatos.ResumeLayout(false);
            gbxDatosExamen.ResumeLayout(false);
            gbxDatosExamen.PerformLayout();
            gbxDatosAlumno.ResumeLayout(false);
            gbxDatosAlumno.PerformLayout();
            gbxExamen.ResumeLayout(false);
            gbxExamen.PerformLayout();
            gbxCorrecionExamen.ResumeLayout(false);
            gbxCorrecionExamen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosRespuestas).EndInit();
            gbxCorrecionExamenes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxIngresoDatos;
        private Label lblExamenes;
        private Label lblCorrecionDe;
        private Button btnSalirDelPrograma;
        private Button btnVolverAlMenu;
        private GroupBox gbxDatosAlumno;
        private Label lblApellido;
        private Label lblNombre;
        private GroupBox gbxDatosExamen;
        private Label lblID;
        private TextBox tbApellido;
        private TextBox tbNombre;
        private ComboBox cmbID;
        private Button btnObtenerExamen;
        private GroupBox gbxExamen;
        private ComboBox cmbRespuestas;
        private Label lblRespuesta;
        private Label lblPreguntaAContestar;
        private Label lblPregunta;
        private GroupBox gbxCorrecionExamen;
        private GroupBox gbxCorrecionExamenes;
        private Button btnResponder;
        private Label lblNumNota;
        private Label lblNota;
        private DataGridView dgvDatosRespuestas;
        private Label lblDatosDel;
        private Label lblNumRespCorrectas;
        private Label lblRespCorrectas;
        private Label lblNumTotPregs;
        private Label lblTotPregs;
        private Label lblExamen;
        private Label lblNumPregunta;
        private Button btnIngresar;
        private DataGridViewTextBoxColumn Respuesta;
        private DataGridViewTextBoxColumn RespuestaCorrecta;
    }
}
