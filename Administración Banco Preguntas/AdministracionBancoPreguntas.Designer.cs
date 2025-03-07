namespace Administracion_Banco_Preguntas
{
    partial class frmMenuAdminBancPreg
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAdminBancPreg));
            lblAdmDel = new Label();
            lblBancPreg = new Label();
            gbxOpciones = new GroupBox();
            gbxPregAlm = new GroupBox();
            dgvListadoPorUnidad = new DataGridView();
            dgvLPUID = new DataGridViewTextBoxColumn();
            dgvLPUAsignatura = new DataGridViewTextBoxColumn();
            dgvLPUUnidad = new DataGridViewTextBoxColumn();
            dgvLPUSubunidad = new DataGridViewTextBoxColumn();
            dgvLPUPregunta = new DataGridViewTextBoxColumn();
            dgvLPURespuestaCorrecta = new DataGridViewTextBoxColumn();
            lblSobreUnElemento = new Label();
            lblDobleClick = new Label();
            lblHaga = new Label();
            lblLUnidad = new Label();
            lblLGeneral = new Label();
            lblListadoG = new Label();
            lblListadoU = new Label();
            dgvListadoGeneral = new DataGridView();
            dgvLGID = new DataGridViewTextBoxColumn();
            dgvLGAsignatura = new DataGridViewTextBoxColumn();
            dgvLGUnidad = new DataGridViewTextBoxColumn();
            dgvLGSubunidad = new DataGridViewTextBoxColumn();
            dgvLGPregunta = new DataGridViewTextBoxColumn();
            dgvLGRespuestaCorrecta = new DataGridViewTextBoxColumn();
            gbxAñadirPreg = new GroupBox();
            lblMax4 = new Label();
            cbxRespCorrecta = new CheckBox();
            btnSiguienteAUS = new Button();
            btnSiguientePregunta = new Button();
            btnIngresarRespuesta = new Button();
            lblRespuesta = new Label();
            txtRespuesta = new TextBox();
            lblPregunta = new Label();
            btnIngresarAUS = new Button();
            lblSubunidad = new Label();
            txtPregunta = new TextBox();
            txtSubunidad = new TextBox();
            txtUnidad = new TextBox();
            btnIngresarPregunta = new Button();
            lblAsignatura = new Label();
            lblUnidad = new Label();
            txtAsignatura = new TextBox();
            gbxModPreg = new GroupBox();
            btnModificar = new Button();
            lblMax4_2 = new Label();
            btnIngresarIDPregunta = new Button();
            cbxRespCorrecta2 = new CheckBox();
            txtIDpregunta = new TextBox();
            btnIngresarRespuesta2 = new Button();
            lblIDPregunta = new Label();
            lblRespuesta2 = new Label();
            txtAsignatura2 = new TextBox();
            txtRespuesta2 = new TextBox();
            lblUnidad2 = new Label();
            lblPregunta2 = new Label();
            lblAsignatura2 = new Label();
            btnIngresarAUS2 = new Button();
            btnIngresarPregunta2 = new Button();
            lblSubunidad2 = new Label();
            txtUnidad2 = new TextBox();
            txtPregunta2 = new TextBox();
            txtSubunidad2 = new TextBox();
            btnVolverAlMenu = new Button();
            btnSalirDelPrograma = new Button();
            gbxOpciones.SuspendLayout();
            gbxPregAlm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoPorUnidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoGeneral).BeginInit();
            gbxAñadirPreg.SuspendLayout();
            gbxModPreg.SuspendLayout();
            SuspendLayout();
            // 
            // lblAdmDel
            // 
            lblAdmDel.AutoSize = true;
            lblAdmDel.BackColor = Color.Transparent;
            lblAdmDel.Font = new Font("Myanmar Text", 24F, FontStyle.Bold);
            lblAdmDel.ForeColor = Color.FromArgb(17, 45, 78);
            lblAdmDel.Location = new Point(624, 18);
            lblAdmDel.Name = "lblAdmDel";
            lblAdmDel.Size = new Size(307, 56);
            lblAdmDel.TabIndex = 1;
            lblAdmDel.Text = "Administración del";
            // 
            // lblBancPreg
            // 
            lblBancPreg.AutoSize = true;
            lblBancPreg.BackColor = Color.Transparent;
            lblBancPreg.Font = new Font("Myanmar Text", 24F, FontStyle.Bold);
            lblBancPreg.ForeColor = Color.FromArgb(63, 114, 175);
            lblBancPreg.Location = new Point(915, 18);
            lblBancPreg.Name = "lblBancPreg";
            lblBancPreg.Size = new Size(322, 56);
            lblBancPreg.TabIndex = 2;
            lblBancPreg.Text = "Banco de Preguntas";
            // 
            // gbxOpciones
            // 
            gbxOpciones.BackColor = Color.Transparent;
            gbxOpciones.Controls.Add(gbxPregAlm);
            gbxOpciones.Controls.Add(gbxAñadirPreg);
            gbxOpciones.Controls.Add(gbxModPreg);
            gbxOpciones.Location = new Point(24, 77);
            gbxOpciones.Name = "gbxOpciones";
            gbxOpciones.Size = new Size(1810, 653);
            gbxOpciones.TabIndex = 3;
            gbxOpciones.TabStop = false;
            // 
            // gbxPregAlm
            // 
            gbxPregAlm.Controls.Add(dgvListadoPorUnidad);
            gbxPregAlm.Controls.Add(lblSobreUnElemento);
            gbxPregAlm.Controls.Add(lblDobleClick);
            gbxPregAlm.Controls.Add(lblHaga);
            gbxPregAlm.Controls.Add(lblLUnidad);
            gbxPregAlm.Controls.Add(lblLGeneral);
            gbxPregAlm.Controls.Add(lblListadoG);
            gbxPregAlm.Controls.Add(lblListadoU);
            gbxPregAlm.Controls.Add(dgvListadoGeneral);
            gbxPregAlm.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            gbxPregAlm.ForeColor = Color.FromArgb(17, 45, 78);
            gbxPregAlm.Location = new Point(891, 17);
            gbxPregAlm.Name = "gbxPregAlm";
            gbxPregAlm.RightToLeft = RightToLeft.No;
            gbxPregAlm.Size = new Size(905, 613);
            gbxPregAlm.TabIndex = 42;
            gbxPregAlm.TabStop = false;
            gbxPregAlm.Text = " Preguntas almacenadas en el banco ";
            // 
            // dgvListadoPorUnidad
            // 
            dgvListadoPorUnidad.AllowUserToAddRows = false;
            dgvListadoPorUnidad.AllowUserToDeleteRows = false;
            dgvListadoPorUnidad.AllowUserToResizeColumns = false;
            dgvListadoPorUnidad.AllowUserToResizeRows = false;
            dgvListadoPorUnidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoPorUnidad.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(17, 45, 78);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListadoPorUnidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListadoPorUnidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoPorUnidad.Columns.AddRange(new DataGridViewColumn[] { dgvLPUID, dgvLPUAsignatura, dgvLPUUnidad, dgvLPUSubunidad, dgvLPUPregunta, dgvLPURespuestaCorrecta });
            dgvListadoPorUnidad.Cursor = Cursors.Hand;
            dgvListadoPorUnidad.Location = new Point(22, 343);
            dgvListadoPorUnidad.Name = "dgvListadoPorUnidad";
            dgvListadoPorUnidad.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(17, 45, 78);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListadoPorUnidad.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListadoPorUnidad.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListadoPorUnidad.ScrollBars = ScrollBars.Vertical;
            dgvListadoPorUnidad.Size = new Size(863, 210);
            dgvListadoPorUnidad.TabIndex = 48;
            dgvListadoPorUnidad.TabStop = false;
            dgvListadoPorUnidad.CellDoubleClick += dgvListadoPorUnidad_CellDoubleClick;
            // 
            // dgvLPUID
            // 
            dgvLPUID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvLPUID.Frozen = true;
            dgvLPUID.HeaderText = "ID";
            dgvLPUID.MaxInputLength = 4;
            dgvLPUID.Name = "dgvLPUID";
            dgvLPUID.ReadOnly = true;
            dgvLPUID.Resizable = DataGridViewTriState.False;
            dgvLPUID.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvLPUID.Width = 60;
            // 
            // dgvLPUAsignatura
            // 
            dgvLPUAsignatura.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvLPUAsignatura.Frozen = true;
            dgvLPUAsignatura.HeaderText = "Asignatura";
            dgvLPUAsignatura.MaxInputLength = 60;
            dgvLPUAsignatura.Name = "dgvLPUAsignatura";
            dgvLPUAsignatura.ReadOnly = true;
            dgvLPUAsignatura.Resizable = DataGridViewTriState.False;
            dgvLPUAsignatura.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvLPUAsignatura.Width = 120;
            // 
            // dgvLPUUnidad
            // 
            dgvLPUUnidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvLPUUnidad.Frozen = true;
            dgvLPUUnidad.HeaderText = "Unidad";
            dgvLPUUnidad.MaxInputLength = 60;
            dgvLPUUnidad.Name = "dgvLPUUnidad";
            dgvLPUUnidad.ReadOnly = true;
            dgvLPUUnidad.Resizable = DataGridViewTriState.False;
            dgvLPUUnidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvLPUUnidad.Width = 120;
            // 
            // dgvLPUSubunidad
            // 
            dgvLPUSubunidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvLPUSubunidad.Frozen = true;
            dgvLPUSubunidad.HeaderText = "Subunidad";
            dgvLPUSubunidad.MaxInputLength = 60;
            dgvLPUSubunidad.Name = "dgvLPUSubunidad";
            dgvLPUSubunidad.ReadOnly = true;
            dgvLPUSubunidad.Resizable = DataGridViewTriState.False;
            dgvLPUSubunidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvLPUSubunidad.Width = 120;
            // 
            // dgvLPUPregunta
            // 
            dgvLPUPregunta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvLPUPregunta.Frozen = true;
            dgvLPUPregunta.HeaderText = "Pregunta";
            dgvLPUPregunta.MaxInputLength = 120;
            dgvLPUPregunta.Name = "dgvLPUPregunta";
            dgvLPUPregunta.ReadOnly = true;
            dgvLPUPregunta.Resizable = DataGridViewTriState.False;
            dgvLPUPregunta.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvLPUPregunta.Width = 200;
            // 
            // dgvLPURespuestaCorrecta
            // 
            dgvLPURespuestaCorrecta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvLPURespuestaCorrecta.Frozen = true;
            dgvLPURespuestaCorrecta.HeaderText = "Respuesta Correcta";
            dgvLPURespuestaCorrecta.MaxInputLength = 120;
            dgvLPURespuestaCorrecta.Name = "dgvLPURespuestaCorrecta";
            dgvLPURespuestaCorrecta.ReadOnly = true;
            dgvLPURespuestaCorrecta.Resizable = DataGridViewTriState.False;
            dgvLPURespuestaCorrecta.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvLPURespuestaCorrecta.Width = 200;
            // 
            // lblSobreUnElemento
            // 
            lblSobreUnElemento.AutoSize = true;
            lblSobreUnElemento.Font = new Font("Myanmar Text", 12F, FontStyle.Bold);
            lblSobreUnElemento.ForeColor = Color.FromArgb(17, 45, 78);
            lblSobreUnElemento.Location = new Point(339, 571);
            lblSobreUnElemento.Name = "lblSobreUnElemento";
            lblSobreUnElemento.Size = new Size(393, 29);
            lblSobreUnElemento.TabIndex = 51;
            lblSobreUnElemento.Text = "sobre un elemento en alguna lista para eliminarlo";
            // 
            // lblDobleClick
            // 
            lblDobleClick.AutoSize = true;
            lblDobleClick.Font = new Font("Myanmar Text", 12F, FontStyle.Bold);
            lblDobleClick.ForeColor = Color.FromArgb(63, 114, 175);
            lblDobleClick.Location = new Point(251, 571);
            lblDobleClick.Name = "lblDobleClick";
            lblDobleClick.Size = new Size(96, 29);
            lblDobleClick.TabIndex = 50;
            lblDobleClick.Text = "doble click";
            // 
            // lblHaga
            // 
            lblHaga.AutoSize = true;
            lblHaga.Font = new Font("Myanmar Text", 12F, FontStyle.Bold);
            lblHaga.ForeColor = Color.FromArgb(17, 45, 78);
            lblHaga.Location = new Point(206, 571);
            lblHaga.Name = "lblHaga";
            lblHaga.Size = new Size(53, 29);
            lblHaga.TabIndex = 49;
            lblHaga.Text = "Haga";
            // 
            // lblLUnidad
            // 
            lblLUnidad.AutoSize = true;
            lblLUnidad.Font = new Font("Myanmar Text", 16F, FontStyle.Bold);
            lblLUnidad.ForeColor = Color.FromArgb(63, 114, 175);
            lblLUnidad.Location = new Point(475, 301);
            lblLUnidad.Name = "lblLUnidad";
            lblLUnidad.Size = new Size(92, 39);
            lblLUnidad.TabIndex = 47;
            lblLUnidad.Text = "Unidad";
            // 
            // lblLGeneral
            // 
            lblLGeneral.AutoSize = true;
            lblLGeneral.Font = new Font("Myanmar Text", 16F, FontStyle.Bold);
            lblLGeneral.ForeColor = Color.FromArgb(63, 114, 175);
            lblLGeneral.Location = new Point(461, 29);
            lblLGeneral.Name = "lblLGeneral";
            lblLGeneral.Size = new Size(97, 39);
            lblLGeneral.TabIndex = 44;
            lblLGeneral.Text = "General";
            // 
            // lblListadoG
            // 
            lblListadoG.AutoSize = true;
            lblListadoG.Font = new Font("Myanmar Text", 16F, FontStyle.Bold);
            lblListadoG.ForeColor = Color.FromArgb(17, 45, 78);
            lblListadoG.Location = new Point(379, 29);
            lblListadoG.Name = "lblListadoG";
            lblListadoG.Size = new Size(92, 39);
            lblListadoG.TabIndex = 43;
            lblListadoG.Text = "Listado";
            // 
            // lblListadoU
            // 
            lblListadoU.AutoSize = true;
            lblListadoU.Font = new Font("Myanmar Text", 16F, FontStyle.Bold);
            lblListadoU.ForeColor = Color.FromArgb(17, 45, 78);
            lblListadoU.Location = new Point(349, 301);
            lblListadoU.Name = "lblListadoU";
            lblListadoU.Size = new Size(134, 39);
            lblListadoU.TabIndex = 46;
            lblListadoU.Text = "Listado por";
            // 
            // dgvListadoGeneral
            // 
            dgvListadoGeneral.AllowUserToAddRows = false;
            dgvListadoGeneral.AllowUserToDeleteRows = false;
            dgvListadoGeneral.AllowUserToResizeColumns = false;
            dgvListadoGeneral.AllowUserToResizeRows = false;
            dgvListadoGeneral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoGeneral.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(17, 45, 78);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListadoGeneral.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListadoGeneral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoGeneral.Columns.AddRange(new DataGridViewColumn[] { dgvLGID, dgvLGAsignatura, dgvLGUnidad, dgvLGSubunidad, dgvLGPregunta, dgvLGRespuestaCorrecta });
            dgvListadoGeneral.Cursor = Cursors.Hand;
            dgvListadoGeneral.Location = new Point(22, 69);
            dgvListadoGeneral.Name = "dgvListadoGeneral";
            dgvListadoGeneral.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(17, 45, 78);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvListadoGeneral.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvListadoGeneral.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListadoGeneral.ScrollBars = ScrollBars.Vertical;
            dgvListadoGeneral.Size = new Size(863, 210);
            dgvListadoGeneral.TabIndex = 45;
            dgvListadoGeneral.TabStop = false;
            dgvListadoGeneral.CellDoubleClick += dgvListadoGeneral_CellDoubleClick;
            // 
            // dgvLGID
            // 
            dgvLGID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvLGID.Frozen = true;
            dgvLGID.HeaderText = "ID";
            dgvLGID.MaxInputLength = 4;
            dgvLGID.Name = "dgvLGID";
            dgvLGID.ReadOnly = true;
            dgvLGID.Resizable = DataGridViewTriState.False;
            dgvLGID.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvLGID.Width = 60;
            // 
            // dgvLGAsignatura
            // 
            dgvLGAsignatura.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvLGAsignatura.Frozen = true;
            dgvLGAsignatura.HeaderText = "Asignatura";
            dgvLGAsignatura.MaxInputLength = 60;
            dgvLGAsignatura.Name = "dgvLGAsignatura";
            dgvLGAsignatura.ReadOnly = true;
            dgvLGAsignatura.Resizable = DataGridViewTriState.False;
            dgvLGAsignatura.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvLGAsignatura.Width = 120;
            // 
            // dgvLGUnidad
            // 
            dgvLGUnidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvLGUnidad.Frozen = true;
            dgvLGUnidad.HeaderText = "Unidad";
            dgvLGUnidad.MaxInputLength = 60;
            dgvLGUnidad.Name = "dgvLGUnidad";
            dgvLGUnidad.ReadOnly = true;
            dgvLGUnidad.Resizable = DataGridViewTriState.False;
            dgvLGUnidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvLGUnidad.Width = 120;
            // 
            // dgvLGSubunidad
            // 
            dgvLGSubunidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvLGSubunidad.Frozen = true;
            dgvLGSubunidad.HeaderText = "Subunidad";
            dgvLGSubunidad.MaxInputLength = 60;
            dgvLGSubunidad.Name = "dgvLGSubunidad";
            dgvLGSubunidad.ReadOnly = true;
            dgvLGSubunidad.Resizable = DataGridViewTriState.False;
            dgvLGSubunidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvLGSubunidad.Width = 120;
            // 
            // dgvLGPregunta
            // 
            dgvLGPregunta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvLGPregunta.Frozen = true;
            dgvLGPregunta.HeaderText = "Pregunta";
            dgvLGPregunta.MaxInputLength = 120;
            dgvLGPregunta.Name = "dgvLGPregunta";
            dgvLGPregunta.ReadOnly = true;
            dgvLGPregunta.Resizable = DataGridViewTriState.False;
            dgvLGPregunta.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvLGPregunta.Width = 200;
            // 
            // dgvLGRespuestaCorrecta
            // 
            dgvLGRespuestaCorrecta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvLGRespuestaCorrecta.Frozen = true;
            dgvLGRespuestaCorrecta.HeaderText = "Respuesta Correcta";
            dgvLGRespuestaCorrecta.MaxInputLength = 120;
            dgvLGRespuestaCorrecta.Name = "dgvLGRespuestaCorrecta";
            dgvLGRespuestaCorrecta.ReadOnly = true;
            dgvLGRespuestaCorrecta.Resizable = DataGridViewTriState.False;
            dgvLGRespuestaCorrecta.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvLGRespuestaCorrecta.Width = 200;
            // 
            // gbxAñadirPreg
            // 
            gbxAñadirPreg.Controls.Add(lblMax4);
            gbxAñadirPreg.Controls.Add(cbxRespCorrecta);
            gbxAñadirPreg.Controls.Add(btnSiguienteAUS);
            gbxAñadirPreg.Controls.Add(btnSiguientePregunta);
            gbxAñadirPreg.Controls.Add(btnIngresarRespuesta);
            gbxAñadirPreg.Controls.Add(lblRespuesta);
            gbxAñadirPreg.Controls.Add(txtRespuesta);
            gbxAñadirPreg.Controls.Add(lblPregunta);
            gbxAñadirPreg.Controls.Add(btnIngresarAUS);
            gbxAñadirPreg.Controls.Add(lblSubunidad);
            gbxAñadirPreg.Controls.Add(txtPregunta);
            gbxAñadirPreg.Controls.Add(txtSubunidad);
            gbxAñadirPreg.Controls.Add(txtUnidad);
            gbxAñadirPreg.Controls.Add(btnIngresarPregunta);
            gbxAñadirPreg.Controls.Add(lblAsignatura);
            gbxAñadirPreg.Controls.Add(lblUnidad);
            gbxAñadirPreg.Controls.Add(txtAsignatura);
            gbxAñadirPreg.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxAñadirPreg.ForeColor = Color.FromArgb(17, 45, 78);
            gbxAñadirPreg.Location = new Point(15, 17);
            gbxAñadirPreg.Name = "gbxAñadirPreg";
            gbxAñadirPreg.Size = new Size(432, 613);
            gbxAñadirPreg.TabIndex = 4;
            gbxAñadirPreg.TabStop = false;
            gbxAñadirPreg.Text = " Añadir nuevas preguntas al banco ";
            // 
            // lblMax4
            // 
            lblMax4.AutoSize = true;
            lblMax4.Enabled = false;
            lblMax4.Font = new Font("Myanmar Text", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMax4.ForeColor = Color.FromArgb(63, 114, 175);
            lblMax4.Location = new Point(36, 347);
            lblMax4.Name = "lblMax4";
            lblMax4.Size = new Size(39, 17);
            lblMax4.TabIndex = 16;
            lblMax4.Text = "(máx 4)";
            // 
            // cbxRespCorrecta
            // 
            cbxRespCorrecta.AutoSize = true;
            cbxRespCorrecta.Cursor = Cursors.Hand;
            cbxRespCorrecta.Enabled = false;
            cbxRespCorrecta.Location = new Point(150, 377);
            cbxRespCorrecta.Name = "cbxRespCorrecta";
            cbxRespCorrecta.Size = new Size(146, 28);
            cbxRespCorrecta.TabIndex = 18;
            cbxRespCorrecta.Text = "Respuesta Correcta";
            cbxRespCorrecta.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteAUS
            // 
            btnSiguienteAUS.BackColor = Color.Gainsboro;
            btnSiguienteAUS.Cursor = Cursors.Hand;
            btnSiguienteAUS.Enabled = false;
            btnSiguienteAUS.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnSiguienteAUS.ForeColor = Color.FromArgb(17, 45, 78);
            btnSiguienteAUS.Location = new Point(55, 525);
            btnSiguienteAUS.Name = "btnSiguienteAUS";
            btnSiguienteAUS.Size = new Size(339, 42);
            btnSiguienteAUS.TabIndex = 21;
            btnSiguienteAUS.Text = "Siguiente Asignatura/Unidad/Subunidad";
            btnSiguienteAUS.UseVisualStyleBackColor = false;
            btnSiguienteAUS.Click += btnSiguienteAUS_Click;
            // 
            // btnSiguientePregunta
            // 
            btnSiguientePregunta.BackColor = Color.Gainsboro;
            btnSiguientePregunta.Cursor = Cursors.Hand;
            btnSiguientePregunta.Enabled = false;
            btnSiguientePregunta.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnSiguientePregunta.ForeColor = Color.FromArgb(17, 45, 78);
            btnSiguientePregunta.Location = new Point(131, 481);
            btnSiguientePregunta.Name = "btnSiguientePregunta";
            btnSiguientePregunta.Size = new Size(177, 38);
            btnSiguientePregunta.TabIndex = 20;
            btnSiguientePregunta.Text = "Siguiente Pregunta";
            btnSiguientePregunta.UseVisualStyleBackColor = false;
            btnSiguientePregunta.Click += btnSiguientePregunta_Click;
            // 
            // btnIngresarRespuesta
            // 
            btnIngresarRespuesta.BackColor = Color.Gainsboro;
            btnIngresarRespuesta.Cursor = Cursors.Hand;
            btnIngresarRespuesta.Enabled = false;
            btnIngresarRespuesta.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnIngresarRespuesta.ForeColor = Color.FromArgb(17, 45, 78);
            btnIngresarRespuesta.Location = new Point(131, 411);
            btnIngresarRespuesta.Name = "btnIngresarRespuesta";
            btnIngresarRespuesta.Size = new Size(177, 33);
            btnIngresarRespuesta.TabIndex = 19;
            btnIngresarRespuesta.Text = "Ingresar";
            btnIngresarRespuesta.UseVisualStyleBackColor = false;
            btnIngresarRespuesta.Click += btnIngresarRespuesta_Click;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Enabled = false;
            lblRespuesta.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            lblRespuesta.ForeColor = Color.FromArgb(63, 114, 175);
            lblRespuesta.Location = new Point(16, 330);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(83, 25);
            lblRespuesta.TabIndex = 15;
            lblRespuesta.Text = "Respuesta:";
            // 
            // txtRespuesta
            // 
            txtRespuesta.Cursor = Cursors.IBeam;
            txtRespuesta.Enabled = false;
            txtRespuesta.Font = new Font("Myanmar Text", 9.75F);
            txtRespuesta.Location = new Point(110, 327);
            txtRespuesta.MaxLength = 120;
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(304, 32);
            txtRespuesta.TabIndex = 17;
            txtRespuesta.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Enabled = false;
            lblPregunta.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            lblPregunta.ForeColor = Color.FromArgb(63, 114, 175);
            lblPregunta.Location = new Point(16, 220);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(77, 25);
            lblPregunta.TabIndex = 12;
            lblPregunta.Text = "Pregunta:";
            // 
            // btnIngresarAUS
            // 
            btnIngresarAUS.BackColor = Color.FromArgb(219, 226, 239);
            btnIngresarAUS.Cursor = Cursors.Hand;
            btnIngresarAUS.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnIngresarAUS.ForeColor = Color.FromArgb(17, 45, 78);
            btnIngresarAUS.Location = new Point(131, 157);
            btnIngresarAUS.Name = "btnIngresarAUS";
            btnIngresarAUS.Size = new Size(177, 33);
            btnIngresarAUS.TabIndex = 11;
            btnIngresarAUS.Text = "Ingresar";
            btnIngresarAUS.UseVisualStyleBackColor = false;
            btnIngresarAUS.Click += btnIngresarAUS_Click;
            // 
            // lblSubunidad
            // 
            lblSubunidad.AutoSize = true;
            lblSubunidad.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            lblSubunidad.ForeColor = Color.FromArgb(63, 114, 175);
            lblSubunidad.Location = new Point(16, 113);
            lblSubunidad.Name = "lblSubunidad";
            lblSubunidad.Size = new Size(87, 25);
            lblSubunidad.TabIndex = 9;
            lblSubunidad.Text = "Subunidad:";
            // 
            // txtPregunta
            // 
            txtPregunta.Cursor = Cursors.IBeam;
            txtPregunta.Enabled = false;
            txtPregunta.Font = new Font("Myanmar Text", 9.75F);
            txtPregunta.Location = new Point(110, 217);
            txtPregunta.MaxLength = 120;
            txtPregunta.Name = "txtPregunta";
            txtPregunta.Size = new Size(304, 32);
            txtPregunta.TabIndex = 13;
            txtPregunta.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSubunidad
            // 
            txtSubunidad.Cursor = Cursors.IBeam;
            txtSubunidad.Font = new Font("Myanmar Text", 9.75F);
            txtSubunidad.Location = new Point(110, 110);
            txtSubunidad.MaxLength = 60;
            txtSubunidad.Name = "txtSubunidad";
            txtSubunidad.Size = new Size(304, 32);
            txtSubunidad.TabIndex = 10;
            txtSubunidad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUnidad
            // 
            txtUnidad.Cursor = Cursors.IBeam;
            txtUnidad.Font = new Font("Myanmar Text", 9.75F);
            txtUnidad.Location = new Point(110, 72);
            txtUnidad.MaxLength = 60;
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(304, 32);
            txtUnidad.TabIndex = 8;
            txtUnidad.TextAlign = HorizontalAlignment.Center;
            // 
            // btnIngresarPregunta
            // 
            btnIngresarPregunta.BackColor = Color.Gainsboro;
            btnIngresarPregunta.Cursor = Cursors.Hand;
            btnIngresarPregunta.Enabled = false;
            btnIngresarPregunta.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnIngresarPregunta.ForeColor = Color.FromArgb(17, 45, 78);
            btnIngresarPregunta.Location = new Point(131, 266);
            btnIngresarPregunta.Name = "btnIngresarPregunta";
            btnIngresarPregunta.Size = new Size(177, 33);
            btnIngresarPregunta.TabIndex = 14;
            btnIngresarPregunta.Text = "Ingresar";
            btnIngresarPregunta.UseVisualStyleBackColor = false;
            btnIngresarPregunta.Click += btnIngresarPregunta_Click;
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            lblAsignatura.ForeColor = Color.FromArgb(63, 114, 175);
            lblAsignatura.Location = new Point(16, 38);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(88, 25);
            lblAsignatura.TabIndex = 5;
            lblAsignatura.Text = "Asignatura:";
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            lblUnidad.ForeColor = Color.FromArgb(63, 114, 175);
            lblUnidad.Location = new Point(16, 75);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(64, 25);
            lblUnidad.TabIndex = 7;
            lblUnidad.Text = "Unidad:";
            // 
            // txtAsignatura
            // 
            txtAsignatura.Cursor = Cursors.IBeam;
            txtAsignatura.Font = new Font("Myanmar Text", 9.75F);
            txtAsignatura.Location = new Point(110, 34);
            txtAsignatura.MaxLength = 60;
            txtAsignatura.Name = "txtAsignatura";
            txtAsignatura.Size = new Size(304, 32);
            txtAsignatura.TabIndex = 6;
            txtAsignatura.TextAlign = HorizontalAlignment.Center;
            // 
            // gbxModPreg
            // 
            gbxModPreg.Controls.Add(btnModificar);
            gbxModPreg.Controls.Add(lblMax4_2);
            gbxModPreg.Controls.Add(btnIngresarIDPregunta);
            gbxModPreg.Controls.Add(cbxRespCorrecta2);
            gbxModPreg.Controls.Add(txtIDpregunta);
            gbxModPreg.Controls.Add(btnIngresarRespuesta2);
            gbxModPreg.Controls.Add(lblIDPregunta);
            gbxModPreg.Controls.Add(lblRespuesta2);
            gbxModPreg.Controls.Add(txtAsignatura2);
            gbxModPreg.Controls.Add(txtRespuesta2);
            gbxModPreg.Controls.Add(lblUnidad2);
            gbxModPreg.Controls.Add(lblPregunta2);
            gbxModPreg.Controls.Add(lblAsignatura2);
            gbxModPreg.Controls.Add(btnIngresarAUS2);
            gbxModPreg.Controls.Add(btnIngresarPregunta2);
            gbxModPreg.Controls.Add(lblSubunidad2);
            gbxModPreg.Controls.Add(txtUnidad2);
            gbxModPreg.Controls.Add(txtPregunta2);
            gbxModPreg.Controls.Add(txtSubunidad2);
            gbxModPreg.Enabled = false;
            gbxModPreg.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            gbxModPreg.ForeColor = Color.FromArgb(17, 45, 78);
            gbxModPreg.Location = new Point(453, 17);
            gbxModPreg.Name = "gbxModPreg";
            gbxModPreg.Size = new Size(432, 613);
            gbxModPreg.TabIndex = 22;
            gbxModPreg.TabStop = false;
            gbxModPreg.Text = " Modificar preguntas existentes ";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Gainsboro;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.Enabled = false;
            btnModificar.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnModificar.ForeColor = Color.FromArgb(17, 45, 78);
            btnModificar.Location = new Point(222, 526);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(177, 33);
            btnModificar.TabIndex = 41;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // lblMax4_2
            // 
            lblMax4_2.AutoSize = true;
            lblMax4_2.Enabled = false;
            lblMax4_2.Font = new Font("Myanmar Text", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMax4_2.ForeColor = Color.FromArgb(63, 114, 175);
            lblMax4_2.Location = new Point(39, 461);
            lblMax4_2.Name = "lblMax4_2";
            lblMax4_2.Size = new Size(39, 17);
            lblMax4_2.TabIndex = 37;
            lblMax4_2.Text = "(máx 4)";
            // 
            // btnIngresarIDPregunta
            // 
            btnIngresarIDPregunta.BackColor = Color.Gainsboro;
            btnIngresarIDPregunta.Cursor = Cursors.Hand;
            btnIngresarIDPregunta.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnIngresarIDPregunta.ForeColor = Color.FromArgb(17, 45, 78);
            btnIngresarIDPregunta.Location = new Point(128, 87);
            btnIngresarIDPregunta.Name = "btnIngresarIDPregunta";
            btnIngresarIDPregunta.Size = new Size(177, 33);
            btnIngresarIDPregunta.TabIndex = 25;
            btnIngresarIDPregunta.Text = "Ingresar";
            btnIngresarIDPregunta.UseVisualStyleBackColor = false;
            btnIngresarIDPregunta.Click += btnIngresarIDPregunta_Click;
            // 
            // cbxRespCorrecta2
            // 
            cbxRespCorrecta2.AutoSize = true;
            cbxRespCorrecta2.Cursor = Cursors.Hand;
            cbxRespCorrecta2.Enabled = false;
            cbxRespCorrecta2.Location = new Point(152, 491);
            cbxRespCorrecta2.Name = "cbxRespCorrecta2";
            cbxRespCorrecta2.Size = new Size(160, 29);
            cbxRespCorrecta2.TabIndex = 39;
            cbxRespCorrecta2.Text = "Respuesta Correcta";
            cbxRespCorrecta2.UseVisualStyleBackColor = true;
            // 
            // txtIDpregunta
            // 
            txtIDpregunta.Cursor = Cursors.IBeam;
            txtIDpregunta.Font = new Font("Myanmar Text", 9.75F);
            txtIDpregunta.Location = new Point(222, 42);
            txtIDpregunta.MaxLength = 4;
            txtIDpregunta.Name = "txtIDpregunta";
            txtIDpregunta.Size = new Size(83, 32);
            txtIDpregunta.TabIndex = 24;
            txtIDpregunta.TextAlign = HorizontalAlignment.Center;
            // 
            // btnIngresarRespuesta2
            // 
            btnIngresarRespuesta2.BackColor = Color.Gainsboro;
            btnIngresarRespuesta2.Cursor = Cursors.Hand;
            btnIngresarRespuesta2.Enabled = false;
            btnIngresarRespuesta2.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnIngresarRespuesta2.ForeColor = Color.FromArgb(17, 45, 78);
            btnIngresarRespuesta2.Location = new Point(39, 526);
            btnIngresarRespuesta2.Name = "btnIngresarRespuesta2";
            btnIngresarRespuesta2.Size = new Size(177, 33);
            btnIngresarRespuesta2.TabIndex = 40;
            btnIngresarRespuesta2.Text = "Ingresar";
            btnIngresarRespuesta2.UseVisualStyleBackColor = false;
            btnIngresarRespuesta2.Click += btnIngresarRespuesta2_Click;
            // 
            // lblIDPregunta
            // 
            lblIDPregunta.AutoSize = true;
            lblIDPregunta.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            lblIDPregunta.ForeColor = Color.FromArgb(63, 114, 175);
            lblIDPregunta.Location = new Point(128, 47);
            lblIDPregunta.Name = "lblIDPregunta";
            lblIDPregunta.Size = new Size(95, 25);
            lblIDPregunta.TabIndex = 23;
            lblIDPregunta.Text = "ID pregunta:";
            // 
            // lblRespuesta2
            // 
            lblRespuesta2.AutoSize = true;
            lblRespuesta2.Enabled = false;
            lblRespuesta2.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            lblRespuesta2.ForeColor = Color.FromArgb(63, 114, 175);
            lblRespuesta2.Location = new Point(18, 444);
            lblRespuesta2.Name = "lblRespuesta2";
            lblRespuesta2.Size = new Size(83, 25);
            lblRespuesta2.TabIndex = 36;
            lblRespuesta2.Text = "Respuesta:";
            // 
            // txtAsignatura2
            // 
            txtAsignatura2.Cursor = Cursors.IBeam;
            txtAsignatura2.Enabled = false;
            txtAsignatura2.Font = new Font("Myanmar Text", 9.75F);
            txtAsignatura2.Location = new Point(112, 148);
            txtAsignatura2.MaxLength = 60;
            txtAsignatura2.Name = "txtAsignatura2";
            txtAsignatura2.Size = new Size(304, 32);
            txtAsignatura2.TabIndex = 27;
            txtAsignatura2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRespuesta2
            // 
            txtRespuesta2.Cursor = Cursors.IBeam;
            txtRespuesta2.Enabled = false;
            txtRespuesta2.Font = new Font("Myanmar Text", 9.75F);
            txtRespuesta2.Location = new Point(112, 441);
            txtRespuesta2.MaxLength = 120;
            txtRespuesta2.Name = "txtRespuesta2";
            txtRespuesta2.Size = new Size(304, 32);
            txtRespuesta2.TabIndex = 38;
            txtRespuesta2.TextAlign = HorizontalAlignment.Center;
            // 
            // lblUnidad2
            // 
            lblUnidad2.AutoSize = true;
            lblUnidad2.Enabled = false;
            lblUnidad2.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            lblUnidad2.ForeColor = Color.FromArgb(63, 114, 175);
            lblUnidad2.Location = new Point(18, 189);
            lblUnidad2.Name = "lblUnidad2";
            lblUnidad2.Size = new Size(64, 25);
            lblUnidad2.TabIndex = 28;
            lblUnidad2.Text = "Unidad:";
            // 
            // lblPregunta2
            // 
            lblPregunta2.AutoSize = true;
            lblPregunta2.Enabled = false;
            lblPregunta2.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            lblPregunta2.ForeColor = Color.FromArgb(63, 114, 175);
            lblPregunta2.Location = new Point(18, 334);
            lblPregunta2.Name = "lblPregunta2";
            lblPregunta2.Size = new Size(77, 25);
            lblPregunta2.TabIndex = 33;
            lblPregunta2.Text = "Pregunta:";
            // 
            // lblAsignatura2
            // 
            lblAsignatura2.AutoSize = true;
            lblAsignatura2.Enabled = false;
            lblAsignatura2.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            lblAsignatura2.ForeColor = Color.FromArgb(63, 114, 175);
            lblAsignatura2.Location = new Point(18, 152);
            lblAsignatura2.Name = "lblAsignatura2";
            lblAsignatura2.Size = new Size(88, 25);
            lblAsignatura2.TabIndex = 26;
            lblAsignatura2.Text = "Asignatura:";
            // 
            // btnIngresarAUS2
            // 
            btnIngresarAUS2.BackColor = Color.Gainsboro;
            btnIngresarAUS2.Cursor = Cursors.Hand;
            btnIngresarAUS2.Enabled = false;
            btnIngresarAUS2.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnIngresarAUS2.ForeColor = Color.FromArgb(17, 45, 78);
            btnIngresarAUS2.Location = new Point(133, 271);
            btnIngresarAUS2.Name = "btnIngresarAUS2";
            btnIngresarAUS2.Size = new Size(177, 33);
            btnIngresarAUS2.TabIndex = 32;
            btnIngresarAUS2.Text = "Ingresar";
            btnIngresarAUS2.UseVisualStyleBackColor = false;
            btnIngresarAUS2.Click += btnIngresarAUS2_Click;
            // 
            // btnIngresarPregunta2
            // 
            btnIngresarPregunta2.BackColor = Color.Gainsboro;
            btnIngresarPregunta2.Cursor = Cursors.Hand;
            btnIngresarPregunta2.Enabled = false;
            btnIngresarPregunta2.Font = new Font("Myanmar Text", 9F, FontStyle.Bold);
            btnIngresarPregunta2.ForeColor = Color.FromArgb(17, 45, 78);
            btnIngresarPregunta2.Location = new Point(133, 380);
            btnIngresarPregunta2.Name = "btnIngresarPregunta2";
            btnIngresarPregunta2.Size = new Size(177, 33);
            btnIngresarPregunta2.TabIndex = 35;
            btnIngresarPregunta2.Text = "Ingresar";
            btnIngresarPregunta2.UseVisualStyleBackColor = false;
            btnIngresarPregunta2.Click += btnIngresarPregunta2_Click;
            // 
            // lblSubunidad2
            // 
            lblSubunidad2.AutoSize = true;
            lblSubunidad2.Enabled = false;
            lblSubunidad2.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            lblSubunidad2.ForeColor = Color.FromArgb(63, 114, 175);
            lblSubunidad2.Location = new Point(18, 227);
            lblSubunidad2.Name = "lblSubunidad2";
            lblSubunidad2.Size = new Size(87, 25);
            lblSubunidad2.TabIndex = 30;
            lblSubunidad2.Text = "Subunidad:";
            // 
            // txtUnidad2
            // 
            txtUnidad2.Cursor = Cursors.IBeam;
            txtUnidad2.Enabled = false;
            txtUnidad2.Font = new Font("Myanmar Text", 9.75F);
            txtUnidad2.Location = new Point(112, 186);
            txtUnidad2.MaxLength = 60;
            txtUnidad2.Name = "txtUnidad2";
            txtUnidad2.Size = new Size(304, 32);
            txtUnidad2.TabIndex = 29;
            txtUnidad2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPregunta2
            // 
            txtPregunta2.Cursor = Cursors.IBeam;
            txtPregunta2.Enabled = false;
            txtPregunta2.Font = new Font("Myanmar Text", 9.75F);
            txtPregunta2.Location = new Point(112, 331);
            txtPregunta2.MaxLength = 120;
            txtPregunta2.Name = "txtPregunta2";
            txtPregunta2.Size = new Size(304, 32);
            txtPregunta2.TabIndex = 34;
            txtPregunta2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSubunidad2
            // 
            txtSubunidad2.Cursor = Cursors.IBeam;
            txtSubunidad2.Enabled = false;
            txtSubunidad2.Font = new Font("Myanmar Text", 9.75F);
            txtSubunidad2.Location = new Point(112, 224);
            txtSubunidad2.MaxLength = 60;
            txtSubunidad2.Name = "txtSubunidad2";
            txtSubunidad2.Size = new Size(304, 32);
            txtSubunidad2.TabIndex = 31;
            txtSubunidad2.TextAlign = HorizontalAlignment.Center;
            // 
            // btnVolverAlMenu
            // 
            btnVolverAlMenu.BackColor = Color.FromArgb(219, 226, 239);
            btnVolverAlMenu.Cursor = Cursors.Hand;
            btnVolverAlMenu.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverAlMenu.ForeColor = Color.FromArgb(17, 45, 78);
            btnVolverAlMenu.Location = new Point(588, 750);
            btnVolverAlMenu.Name = "btnVolverAlMenu";
            btnVolverAlMenu.Size = new Size(301, 36);
            btnVolverAlMenu.TabIndex = 52;
            btnVolverAlMenu.Text = "Volver al Menú Principal";
            btnVolverAlMenu.UseVisualStyleBackColor = false;
            btnVolverAlMenu.Click += btnVolverAlMenu_Click;
            // 
            // btnSalirDelPrograma
            // 
            btnSalirDelPrograma.BackColor = Color.FromArgb(219, 226, 239);
            btnSalirDelPrograma.Cursor = Cursors.Hand;
            btnSalirDelPrograma.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalirDelPrograma.ForeColor = Color.FromArgb(17, 45, 78);
            btnSalirDelPrograma.Location = new Point(937, 750);
            btnSalirDelPrograma.Name = "btnSalirDelPrograma";
            btnSalirDelPrograma.Size = new Size(301, 36);
            btnSalirDelPrograma.TabIndex = 53;
            btnSalirDelPrograma.Text = "Salir del Programa";
            btnSalirDelPrograma.UseVisualStyleBackColor = false;
            btnSalirDelPrograma.Click += btnSalirDelPrograma_Click;
            // 
            // frmMenuAdminBancPreg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Administracion_Banco_Preguntas.Properties.Resources.Back;
            ClientSize = new Size(1856, 816);
            Controls.Add(btnSalirDelPrograma);
            Controls.Add(btnVolverAlMenu);
            Controls.Add(gbxOpciones);
            Controls.Add(lblBancPreg);
            Controls.Add(lblAdmDel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1872, 855);
            MinimumSize = new Size(1872, 855);
            Name = "frmMenuAdminBancPreg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administración del Banco de Preguntas";
            FormClosed += frmMenuAdminBancPreg_FormClosed;
            Load += frmMenuAdminBancPreg_Load;
            gbxOpciones.ResumeLayout(false);
            gbxPregAlm.ResumeLayout(false);
            gbxPregAlm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoPorUnidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoGeneral).EndInit();
            gbxAñadirPreg.ResumeLayout(false);
            gbxAñadirPreg.PerformLayout();
            gbxModPreg.ResumeLayout(false);
            gbxModPreg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdmDel;
        private Label lblBancPreg;
        private GroupBox gbxOpciones;
        private GroupBox gbxAñadirPreg;
        private GroupBox gbxModPreg;
        private GroupBox gbxPregAlm;
        private DataGridView dgvListadoGeneral;
        private Button btnVolverAlMenu;
        private Button btnSalirDelPrograma;
        private Label lblLGeneral;
        private Label lblListadoG;
        private Label lblListadoU;
        private Label lblLUnidad;
        private Label lblAsignatura;
        private Label lblUnidad;
        private TextBox txtAsignatura;
        private Label lblPregunta;
        private Button btnIngresarAUS;
        private Label lblSubunidad;
        private TextBox txtPregunta;
        private TextBox txtSubunidad;
        private TextBox txtUnidad;
        private Button btnIngresarPregunta;
        private Label lblRespuesta;
        private TextBox txtRespuesta;
        private Button btnSiguienteAUS;
        private Button btnSiguientePregunta;
        private Button btnIngresarRespuesta;
        private CheckBox cbxRespCorrecta;
        private TextBox txtIDpregunta;
        private Label lblIDPregunta;
        private CheckBox cbxRespCorrecta2;
        private Button btnIngresarRespuesta2;
        private Label lblRespuesta2;
        private TextBox txtAsignatura2;
        private TextBox txtRespuesta2;
        private Label lblUnidad2;
        private Label lblPregunta2;
        private Label lblAsignatura2;
        private Button btnIngresarAUS2;
        private Button btnIngresarPregunta2;
        private Label lblSubunidad2;
        private TextBox txtUnidad2;
        private TextBox txtPregunta2;
        private TextBox txtSubunidad2;
        private Button btnIngresarIDPregunta;
        private Label lblHaga;
        private Label lblSobreUnElemento;
        private Label lblDobleClick;
        private Label lblMax4;
        private Label lblMax4_2;
        private DataGridView dgvListadoPorUnidad;
        private DataGridViewTextBoxColumn dgvLPUID;
        private DataGridViewTextBoxColumn dgvLPUAsignatura;
        private DataGridViewTextBoxColumn dgvLPUUnidad;
        private DataGridViewTextBoxColumn dgvLPUSubunidad;
        private DataGridViewTextBoxColumn dgvLPUPregunta;
        private DataGridViewTextBoxColumn dgvLPURespuestaCorrecta;
        private Button btnModificar;
        private DataGridViewTextBoxColumn dgvLGID;
        private DataGridViewTextBoxColumn dgvLGAsignatura;
        private DataGridViewTextBoxColumn dgvLGUnidad;
        private DataGridViewTextBoxColumn dgvLGSubunidad;
        private DataGridViewTextBoxColumn dgvLGPregunta;
        private DataGridViewTextBoxColumn dgvLGRespuestaCorrecta;
    }
}
