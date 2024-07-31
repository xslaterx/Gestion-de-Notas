namespace GestionNotas
{
    partial class CursoFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombre = new System.Windows.Forms.TextBox();
            lblNombre = new System.Windows.Forms.Label();
            dgvDataCurso = new System.Windows.Forms.DataGridView();
            btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            CursoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtIndice = new System.Windows.Forms.TextBox();
            txtCursoID = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            txtBuscar = new System.Windows.Forms.TextBox();
            cboBuscar = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvDataCurso).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.DarkSlateBlue;
            label3.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.AliceBlue;
            label3.Location = new System.Drawing.Point(58, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(275, 31);
            label3.TabIndex = 35;
            label3.Text = "ADMINISTRAR CURSOS";
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            label1.Dock = System.Windows.Forms.DockStyle.Left;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(414, 562);
            label1.TabIndex = 36;
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = System.Drawing.SystemColors.HotTrack;
            btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpiar.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold);
            btnLimpiar.ForeColor = System.Drawing.Color.Lavender;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.File;
            btnLimpiar.IconColor = System.Drawing.Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 20;
            btnLimpiar.Location = new System.Drawing.Point(32, 398);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(319, 30);
            btnLimpiar.TabIndex = 73;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEliminar.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold);
            btnEliminar.ForeColor = System.Drawing.Color.Lavender;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashCan;
            btnEliminar.IconColor = System.Drawing.Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 20;
            btnEliminar.Location = new System.Drawing.Point(32, 446);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(319, 30);
            btnEliminar.TabIndex = 72;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold);
            btnGuardar.ForeColor = System.Drawing.Color.Lavender;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            btnGuardar.IconColor = System.Drawing.Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 20;
            btnGuardar.Location = new System.Drawing.Point(32, 351);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(319, 30);
            btnGuardar.TabIndex = 71;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtNombre.Location = new System.Drawing.Point(32, 189);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(218, 24);
            txtNombre.TabIndex = 67;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = System.Drawing.Color.DarkSlateBlue;
            lblNombre.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            lblNombre.ForeColor = System.Drawing.Color.AliceBlue;
            lblNombre.Location = new System.Drawing.Point(32, 156);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(69, 19);
            lblNombre.TabIndex = 65;
            lblNombre.Text = "Nombre:";
            // 
            // dgvDataCurso
            // 
            dgvDataCurso.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvDataCurso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDataCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { btnSeleccionar, CursoId, Nombre });
            dgvDataCurso.Location = new System.Drawing.Point(414, 57);
            dgvDataCurso.MultiSelect = false;
            dgvDataCurso.Name = "dgvDataCurso";
            dgvDataCurso.ReadOnly = true;
            dgvDataCurso.Size = new System.Drawing.Size(683, 505);
            dgvDataCurso.TabIndex = 74;
            dgvDataCurso.CellContentClick += dgvDataCurso_CellContentClick;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "";
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.ReadOnly = true;
            btnSeleccionar.Width = 30;
            // 
            // CursoId
            // 
            CursoId.HeaderText = "Curso ID";
            CursoId.Name = "CursoId";
            CursoId.ReadOnly = true;
            CursoId.Width = 200;
            // 
            // Nombre
            // 
            Nombre.FillWeight = 70F;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 400;
            // 
            // txtIndice
            // 
            txtIndice.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtIndice.Location = new System.Drawing.Point(304, 57);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new System.Drawing.Size(29, 24);
            txtIndice.TabIndex = 76;
            txtIndice.Text = "0";
            txtIndice.Visible = false;
            // 
            // txtCursoID
            // 
            txtCursoID.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtCursoID.Location = new System.Drawing.Point(339, 57);
            txtCursoID.Name = "txtCursoID";
            txtCursoID.Size = new System.Drawing.Size(29, 24);
            txtCursoID.TabIndex = 75;
            txtCursoID.Text = "0";
            txtCursoID.Visible = false;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Location = new System.Drawing.Point(414, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(683, 58);
            label2.TabIndex = 77;
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = System.Drawing.Color.DarkSlateBlue;
            btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuscar.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold);
            btnBuscar.ForeColor = System.Drawing.Color.AliceBlue;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = System.Drawing.SystemColors.Window;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 22;
            btnBuscar.Location = new System.Drawing.Point(950, 16);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(49, 27);
            btnBuscar.TabIndex = 82;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiarBuscador
            // 
            btnLimpiarBuscador.BackColor = System.Drawing.Color.DarkSlateBlue;
            btnLimpiarBuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLimpiarBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpiarBuscador.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold);
            btnLimpiarBuscador.ForeColor = System.Drawing.Color.AliceBlue;
            btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiarBuscador.IconColor = System.Drawing.SystemColors.Window;
            btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiarBuscador.IconSize = 22;
            btnLimpiarBuscador.Location = new System.Drawing.Point(1005, 16);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.Size = new System.Drawing.Size(49, 27);
            btnLimpiarBuscador.TabIndex = 81;
            btnLimpiarBuscador.UseVisualStyleBackColor = false;
            btnLimpiarBuscador.Click += btnLimpiarBuscador_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtBuscar.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtBuscar.Location = new System.Drawing.Point(807, 16);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(127, 27);
            txtBuscar.TabIndex = 80;
            // 
            // cboBuscar
            // 
            cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            cboBuscar.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            cboBuscar.FormattingEnabled = true;
            cboBuscar.Location = new System.Drawing.Point(678, 16);
            cboBuscar.Name = "cboBuscar";
            cboBuscar.Size = new System.Drawing.Size(116, 27);
            cboBuscar.TabIndex = 79;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.DarkSlateBlue;
            label6.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.AliceBlue;
            label6.Location = new System.Drawing.Point(579, 19);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(89, 19);
            label6.TabIndex = 78;
            label6.Text = "Filtrar por:";
            // 
            // CursoFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1097, 562);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiarBuscador);
            Controls.Add(txtBuscar);
            Controls.Add(cboBuscar);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(txtIndice);
            Controls.Add(txtCursoID);
            Controls.Add(dgvDataCurso);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "CursoFrm";
            Text = "AulasFrm";
            Load += CursoFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDataCurso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public FontAwesome.Sharp.IconButton btnLimpiar;
        public FontAwesome.Sharp.IconButton btnEliminar;
        public FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvDataCurso;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.TextBox txtCursoID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CursoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        public FontAwesome.Sharp.IconButton btnBuscar;
        public FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.Label label6;
    }
}