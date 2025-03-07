namespace Modulo_G_Examenes
{
    partial class frmGenEx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenEx));
            lblExamenes = new Label();
            lblGeneracionDe = new Label();
            gbxGeneracionDeExamenes = new GroupBox();
            gbxExamGene = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dgvPreguntas = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Pregunta = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            dgvListadoExamenes = new DataGridView();
            ExamenId = new DataGridViewTextBoxColumn();
            ExFecha = new DataGridViewTextBoxColumn();
            ExAsig = new DataGridViewTextBoxColumn();
            ExPreg = new DataGridViewTextBoxColumn();
            lblLGeneral = new Label();
            lblListadoG = new Label();
            gbxTemas = new GroupBox();
            dtpFecha = new DateTimePicker();
            label6 = new Label();
            lblNumUnidades = new Label();
            lblUnidades = new Label();
            btnAgregarUnidad = new Button();
            btnGenerarExamen = new Button();
            cmbUnidad = new ComboBox();
            cmbAsignatura = new ComboBox();
            lblNumTotPreg = new Label();
            lblTotPreg = new Label();
            lblUnidad = new Label();
            lblAsignatura = new Label();
            btnVolverAlMenu = new Button();
            btnSalirDelPrograma = new Button();
            gbxGeneracionDeExamenes.SuspendLayout();
            gbxExamGene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreguntas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoExamenes).BeginInit();
            gbxTemas.SuspendLayout();
            SuspendLayout();
            // 
            // lblExamenes
            // 
            lblExamenes.AutoSize = true;
            lblExamenes.BackColor = Color.Transparent;
            lblExamenes.Font = new Font("Myanmar Text", 24F, FontStyle.Bold);
            lblExamenes.ForeColor = Color.FromArgb(63, 114, 175);
            lblExamenes.Location = new Point(731, 31);
            lblExamenes.Name = "lblExamenes";
            lblExamenes.Size = new Size(172, 56);
            lblExamenes.TabIndex = 2;
            lblExamenes.Text = "Exámenes";
            // 
            // lblGeneracionDe
            // 
            lblGeneracionDe.AutoSize = true;
            lblGeneracionDe.BackColor = Color.Transparent;
            lblGeneracionDe.Font = new Font("Myanmar Text", 24F, FontStyle.Bold);
            lblGeneracionDe.ForeColor = Color.FromArgb(17, 45, 78);
            lblGeneracionDe.Location = new Point(506, 31);
            lblGeneracionDe.Name = "lblGeneracionDe";
            lblGeneracionDe.Size = new Size(239, 56);
            lblGeneracionDe.TabIndex = 1;
            lblGeneracionDe.Text = "Generación de";
            // 
            // gbxGeneracionDeExamenes
            // 
            gbxGeneracionDeExamenes.BackColor = Color.Transparent;
            gbxGeneracionDeExamenes.Controls.Add(gbxExamGene);
            gbxGeneracionDeExamenes.Controls.Add(gbxTemas);
            gbxGeneracionDeExamenes.Location = new Point(30, 71);
            gbxGeneracionDeExamenes.Name = "gbxGeneracionDeExamenes";
            gbxGeneracionDeExamenes.Size = new Size(1343, 438);
            gbxGeneracionDeExamenes.TabIndex = 3;
            gbxGeneracionDeExamenes.TabStop = false;
            // 
            // gbxExamGene
            // 
            gbxExamGene.BackColor = Color.Transparent;
            gbxExamGene.Controls.Add(label3);
            gbxExamGene.Controls.Add(label4);
            gbxExamGene.Controls.Add(label5);
            gbxExamGene.Controls.Add(dgvPreguntas);
            gbxExamGene.Controls.Add(label1);
            gbxExamGene.Controls.Add(label2);
            gbxExamGene.Controls.Add(dgvListadoExamenes);
            gbxExamGene.Controls.Add(lblLGeneral);
            gbxExamGene.Controls.Add(lblListadoG);
            gbxExamGene.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxExamGene.ForeColor = Color.FromArgb(17, 45, 78);
            gbxExamGene.Location = new Point(310, 19);
            gbxExamGene.Name = "gbxExamGene";
            gbxExamGene.Size = new Size(1008, 401);
            gbxExamGene.TabIndex = 16;
            gbxExamGene.TabStop = false;
            gbxExamGene.Text = " Examenes Generados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Myanmar Text", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(17, 45, 78);
            label3.Location = new Point(391, 356);
            label3.Name = "label3";
            label3.Size = new Size(393, 29);
            label3.TabIndex = 53;
            label3.Text = "sobre un elemento en alguna lista para eliminarlo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Myanmar Text", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(63, 114, 175);
            label4.Location = new Point(303, 356);
            label4.Name = "label4";
            label4.Size = new Size(96, 29);
            label4.TabIndex = 52;
            label4.Text = "doble click";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Myanmar Text", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(17, 45, 78);
            label5.Location = new Point(258, 356);
            label5.Name = "label5";
            label5.Size = new Size(53, 29);
            label5.TabIndex = 51;
            label5.Text = "Haga";
            // 
            // dgvPreguntas
            // 
            dgvPreguntas.AllowUserToAddRows = false;
            dgvPreguntas.AllowUserToDeleteRows = false;
            dgvPreguntas.AllowUserToResizeColumns = false;
            dgvPreguntas.AllowUserToResizeRows = false;
            dgvPreguntas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPreguntas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPreguntas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Pregunta, dataGridViewTextBoxColumn4 });
            dgvPreguntas.Cursor = Cursors.Hand;
            dgvPreguntas.Location = new Point(515, 66);
            dgvPreguntas.Name = "dgvPreguntas";
            dgvPreguntas.ReadOnly = true;
            dgvPreguntas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvPreguntas.ScrollBars = ScrollBars.Vertical;
            dgvPreguntas.Size = new Size(470, 273);
            dgvPreguntas.TabIndex = 17;
            dgvPreguntas.TabStop = false;
            dgvPreguntas.CellDoubleClick += dgvPreguntas_CellDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn1.FillWeight = 36.790062F;
            dataGridViewTextBoxColumn1.Frozen = true;
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn1.Width = 50;
            // 
            // Pregunta
            // 
            Pregunta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Pregunta.Frozen = true;
            Pregunta.HeaderText = "Nº Preg.";
            Pregunta.Name = "Pregunta";
            Pregunta.ReadOnly = true;
            Pregunta.Resizable = DataGridViewTriState.False;
            Pregunta.SortMode = DataGridViewColumnSortMode.NotSortable;
            Pregunta.Width = 85;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.FillWeight = 68.2660141F;
            dataGridViewTextBoxColumn4.HeaderText = "Pregunta";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn4.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myanmar Text", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(63, 114, 175);
            label1.Location = new Point(736, 28);
            label1.Name = "label1";
            label1.Size = new Size(123, 39);
            label1.TabIndex = 47;
            label1.Text = "Preguntas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Myanmar Text", 16F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(17, 45, 78);
            label2.Location = new Point(620, 28);
            label2.Name = "label2";
            label2.Size = new Size(124, 39);
            label2.TabIndex = 46;
            label2.Text = "Listado de";
            // 
            // dgvListadoExamenes
            // 
            dgvListadoExamenes.AllowUserToAddRows = false;
            dgvListadoExamenes.AllowUserToDeleteRows = false;
            dgvListadoExamenes.AllowUserToResizeColumns = false;
            dgvListadoExamenes.AllowUserToResizeRows = false;
            dgvListadoExamenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoExamenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoExamenes.Columns.AddRange(new DataGridViewColumn[] { ExamenId, ExFecha, ExAsig, ExPreg });
            dgvListadoExamenes.Cursor = Cursors.Hand;
            dgvListadoExamenes.Location = new Point(22, 66);
            dgvListadoExamenes.Name = "dgvListadoExamenes";
            dgvListadoExamenes.ReadOnly = true;
            dgvListadoExamenes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListadoExamenes.ScrollBars = ScrollBars.Vertical;
            dgvListadoExamenes.Size = new Size(457, 273);
            dgvListadoExamenes.TabIndex = 17;
            dgvListadoExamenes.TabStop = false;
            dgvListadoExamenes.CellDoubleClick += dgvListadoExamenes_CellDoubleClick;
            // 
            // ExamenId
            // 
            ExamenId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ExamenId.FillWeight = 36.790062F;
            ExamenId.Frozen = true;
            ExamenId.HeaderText = "ID";
            ExamenId.Name = "ExamenId";
            ExamenId.ReadOnly = true;
            ExamenId.Resizable = DataGridViewTriState.False;
            ExamenId.SortMode = DataGridViewColumnSortMode.NotSortable;
            ExamenId.Width = 50;
            // 
            // ExFecha
            // 
            ExFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ExFecha.FillWeight = 68.2660141F;
            ExFecha.Frozen = true;
            ExFecha.HeaderText = "Fecha";
            ExFecha.Name = "ExFecha";
            ExFecha.ReadOnly = true;
            ExFecha.Resizable = DataGridViewTriState.False;
            ExFecha.SortMode = DataGridViewColumnSortMode.NotSortable;
            ExFecha.Width = 80;
            // 
            // ExAsig
            // 
            ExAsig.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ExAsig.FillWeight = 68.2660141F;
            ExAsig.Frozen = true;
            ExAsig.HeaderText = "Asignatura";
            ExAsig.Name = "ExAsig";
            ExAsig.ReadOnly = true;
            ExAsig.Resizable = DataGridViewTriState.False;
            ExAsig.SortMode = DataGridViewColumnSortMode.NotSortable;
            ExAsig.Width = 190;
            // 
            // ExPreg
            // 
            ExPreg.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ExPreg.FillWeight = 68.2660141F;
            ExPreg.Frozen = true;
            ExPreg.HeaderText = "N. Preguntas";
            ExPreg.Name = "ExPreg";
            ExPreg.ReadOnly = true;
            ExPreg.Resizable = DataGridViewTriState.False;
            ExPreg.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // lblLGeneral
            // 
            lblLGeneral.AutoSize = true;
            lblLGeneral.Font = new Font("Myanmar Text", 16F, FontStyle.Bold);
            lblLGeneral.ForeColor = Color.FromArgb(63, 114, 175);
            lblLGeneral.Location = new Point(258, 28);
            lblLGeneral.Name = "lblLGeneral";
            lblLGeneral.Size = new Size(120, 39);
            lblLGeneral.TabIndex = 45;
            lblLGeneral.Text = "Examenes";
            // 
            // lblListadoG
            // 
            lblListadoG.AutoSize = true;
            lblListadoG.Font = new Font("Myanmar Text", 16F, FontStyle.Bold);
            lblListadoG.ForeColor = Color.FromArgb(17, 45, 78);
            lblListadoG.Location = new Point(142, 28);
            lblListadoG.Name = "lblListadoG";
            lblListadoG.Size = new Size(124, 39);
            lblListadoG.TabIndex = 44;
            lblListadoG.Text = "Listado de";
            // 
            // gbxTemas
            // 
            gbxTemas.BackColor = Color.Transparent;
            gbxTemas.Controls.Add(dtpFecha);
            gbxTemas.Controls.Add(label6);
            gbxTemas.Controls.Add(lblNumUnidades);
            gbxTemas.Controls.Add(lblUnidades);
            gbxTemas.Controls.Add(btnAgregarUnidad);
            gbxTemas.Controls.Add(btnGenerarExamen);
            gbxTemas.Controls.Add(cmbUnidad);
            gbxTemas.Controls.Add(cmbAsignatura);
            gbxTemas.Controls.Add(lblNumTotPreg);
            gbxTemas.Controls.Add(lblTotPreg);
            gbxTemas.Controls.Add(lblUnidad);
            gbxTemas.Controls.Add(lblAsignatura);
            gbxTemas.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold);
            gbxTemas.ForeColor = Color.FromArgb(17, 45, 78);
            gbxTemas.Location = new Point(16, 19);
            gbxTemas.Name = "gbxTemas";
            gbxTemas.Size = new Size(278, 339);
            gbxTemas.TabIndex = 4;
            gbxTemas.TabStop = false;
            gbxTemas.Text = " Temas ";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Myanmar Text", 9.75F);
            dtpFecha.Location = new Point(109, 131);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(148, 32);
            dtpFecha.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(63, 114, 175);
            label6.Location = new Point(25, 131);
            label6.Name = "label6";
            label6.Size = new Size(49, 24);
            label6.TabIndex = 16;
            label6.Text = "Fecha:";
            // 
            // lblNumUnidades
            // 
            lblNumUnidades.AutoSize = true;
            lblNumUnidades.ForeColor = Color.FromArgb(17, 45, 78);
            lblNumUnidades.Location = new Point(169, 250);
            lblNumUnidades.Name = "lblNumUnidades";
            lblNumUnidades.Size = new Size(17, 24);
            lblNumUnidades.TabIndex = 13;
            lblNumUnidades.Text = "0";
            // 
            // lblUnidades
            // 
            lblUnidades.AutoSize = true;
            lblUnidades.ForeColor = Color.FromArgb(63, 114, 175);
            lblUnidades.Location = new Point(104, 250);
            lblUnidades.Name = "lblUnidades";
            lblUnidades.Size = new Size(71, 24);
            lblUnidades.TabIndex = 12;
            lblUnidades.Text = "Unidades:";
            // 
            // btnAgregarUnidad
            // 
            btnAgregarUnidad.BackColor = Color.FromArgb(219, 226, 239);
            btnAgregarUnidad.Cursor = Cursors.Hand;
            btnAgregarUnidad.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnAgregarUnidad.ForeColor = Color.FromArgb(17, 45, 78);
            btnAgregarUnidad.Location = new Point(70, 181);
            btnAgregarUnidad.Name = "btnAgregarUnidad";
            btnAgregarUnidad.Size = new Size(145, 33);
            btnAgregarUnidad.TabIndex = 4;
            btnAgregarUnidad.Text = "Agregar Unidad";
            btnAgregarUnidad.UseVisualStyleBackColor = false;
            btnAgregarUnidad.Click += btnAgregarUnidad_Click;
            // 
            // btnGenerarExamen
            // 
            btnGenerarExamen.BackColor = Color.FromArgb(219, 226, 239);
            btnGenerarExamen.Cursor = Cursors.Hand;
            btnGenerarExamen.Enabled = false;
            btnGenerarExamen.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnGenerarExamen.ForeColor = Color.FromArgb(17, 45, 78);
            btnGenerarExamen.Location = new Point(49, 286);
            btnGenerarExamen.Name = "btnGenerarExamen";
            btnGenerarExamen.Size = new Size(183, 33);
            btnGenerarExamen.TabIndex = 5;
            btnGenerarExamen.Text = "Generar Examen";
            btnGenerarExamen.UseVisualStyleBackColor = false;
            btnGenerarExamen.Click += btnGenerarExamen_Click;
            // 
            // cmbUnidad
            // 
            cmbUnidad.Cursor = Cursors.Hand;
            cmbUnidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnidad.Font = new Font("Myanmar Text", 9.75F);
            cmbUnidad.FormattingEnabled = true;
            cmbUnidad.Location = new Point(109, 90);
            cmbUnidad.MaxDropDownItems = 100;
            cmbUnidad.Name = "cmbUnidad";
            cmbUnidad.Size = new Size(148, 31);
            cmbUnidad.TabIndex = 2;
            // 
            // cmbAsignatura
            // 
            cmbAsignatura.Cursor = Cursors.Hand;
            cmbAsignatura.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAsignatura.Font = new Font("Myanmar Text", 9.75F);
            cmbAsignatura.FormattingEnabled = true;
            cmbAsignatura.Location = new Point(109, 49);
            cmbAsignatura.MaxDropDownItems = 100;
            cmbAsignatura.Name = "cmbAsignatura";
            cmbAsignatura.Size = new Size(148, 31);
            cmbAsignatura.TabIndex = 1;
            cmbAsignatura.SelectedValueChanged += cmbAsignatura_SelectedValueChanged;
            // 
            // lblNumTotPreg
            // 
            lblNumTotPreg.AutoSize = true;
            lblNumTotPreg.ForeColor = Color.FromArgb(17, 45, 78);
            lblNumTotPreg.Location = new Point(200, 226);
            lblNumTotPreg.Name = "lblNumTotPreg";
            lblNumTotPreg.Size = new Size(17, 24);
            lblNumTotPreg.TabIndex = 11;
            lblNumTotPreg.Text = "0";
            // 
            // lblTotPreg
            // 
            lblTotPreg.AutoSize = true;
            lblTotPreg.ForeColor = Color.FromArgb(63, 114, 175);
            lblTotPreg.Location = new Point(72, 226);
            lblTotPreg.Name = "lblTotPreg";
            lblTotPreg.Size = new Size(133, 24);
            lblTotPreg.TabIndex = 10;
            lblTotPreg.Text = "Total De Preguntas:";
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.ForeColor = Color.FromArgb(63, 114, 175);
            lblUnidad.Location = new Point(25, 93);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(58, 24);
            lblUnidad.TabIndex = 7;
            lblUnidad.Text = "Unidad:";
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.ForeColor = Color.FromArgb(63, 114, 175);
            lblAsignatura.Location = new Point(25, 52);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(81, 24);
            lblAsignatura.TabIndex = 5;
            lblAsignatura.Text = "Asignatura:";
            // 
            // btnVolverAlMenu
            // 
            btnVolverAlMenu.BackColor = Color.FromArgb(219, 226, 239);
            btnVolverAlMenu.Cursor = Cursors.Hand;
            btnVolverAlMenu.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnVolverAlMenu.ForeColor = Color.FromArgb(17, 45, 78);
            btnVolverAlMenu.Location = new Point(510, 533);
            btnVolverAlMenu.Name = "btnVolverAlMenu";
            btnVolverAlMenu.Size = new Size(189, 33);
            btnVolverAlMenu.TabIndex = 7;
            btnVolverAlMenu.Text = "Volver al Menú Principal";
            btnVolverAlMenu.UseVisualStyleBackColor = false;
            btnVolverAlMenu.Click += btnVolverAlMenu_Click;
            // 
            // btnSalirDelPrograma
            // 
            btnSalirDelPrograma.BackColor = Color.FromArgb(219, 226, 239);
            btnSalirDelPrograma.Cursor = Cursors.Hand;
            btnSalirDelPrograma.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnSalirDelPrograma.ForeColor = Color.FromArgb(17, 45, 78);
            btnSalirDelPrograma.Location = new Point(731, 533);
            btnSalirDelPrograma.Name = "btnSalirDelPrograma";
            btnSalirDelPrograma.Size = new Size(189, 33);
            btnSalirDelPrograma.TabIndex = 8;
            btnSalirDelPrograma.Text = "Salir del Programa";
            btnSalirDelPrograma.UseVisualStyleBackColor = false;
            btnSalirDelPrograma.Click += btnSalirDelPrograma_Click;
            // 
            // frmGenEx
            // 
            AutoScaleDimensions = new SizeF(7F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Generación_de_Exámenes.Properties.Resources.Back;
            ClientSize = new Size(1417, 590);
            Controls.Add(btnSalirDelPrograma);
            Controls.Add(btnVolverAlMenu);
            Controls.Add(gbxGeneracionDeExamenes);
            Controls.Add(lblExamenes);
            Controls.Add(lblGeneracionDe);
            Font = new Font("Myanmar Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(1433, 629);
            MinimumSize = new Size(1433, 629);
            Name = "frmGenEx";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generación de Exámenes";
            Load += frmGenEx_Load;
            gbxGeneracionDeExamenes.ResumeLayout(false);
            gbxExamGene.ResumeLayout(false);
            gbxExamGene.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreguntas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoExamenes).EndInit();
            gbxTemas.ResumeLayout(false);
            gbxTemas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExamenes;
        private Label lblGeneracionDe;
        private GroupBox gbxGeneracionDeExamenes;
        private GroupBox gbxTemas;
        private GroupBox gbxExamGene;
        private Button btnVolverAlMenu;
        private Button btnSalirDelPrograma;
        private DataGridView dgvListadoExamenes;
        private Label lblUnidad;
        private Label lblAsignatura;
        private Label lblNumTotPreg;
        private Label lblTotPreg;
        private ComboBox cmbUnidad;
        private ComboBox cmbAsignatura;
        private Button btnAgregarUnidad;
        private Button btnGenerarExamen;
        private Label lblNumUnidades;
        private Label lblUnidades;
        private DataGridView dgvPreguntas;
        private Label label1;
        private Label label2;
        private Label lblLGeneral;
        private Label lblListadoG;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpFecha;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Pregunta;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn ExamenId;
        private DataGridViewTextBoxColumn ExFecha;
        private DataGridViewTextBoxColumn ExAsig;
        private DataGridViewTextBoxColumn ExPreg;
    }
}
