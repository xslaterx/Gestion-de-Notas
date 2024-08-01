namespace GestionNotas
{
    partial class AsistenciaFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            cboEstado = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            txtIndice = new System.Windows.Forms.TextBox();
            txtAsistenciaID = new System.Windows.Forms.TextBox();
            cboAsignatura = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            cboCurso = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            txtCodigo = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            lblusuario = new System.Windows.Forms.Label();
            dgvData = new System.Windows.Forms.DataGridView();
            btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            AsistenciaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(cboEstado);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtIndice);
            panel1.Controls.Add(txtAsistenciaID);
            panel1.Controls.Add(cboAsignatura);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cboCurso);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblusuario);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(317, 604);
            panel1.TabIndex = 8;
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboEstado.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new System.Drawing.Point(12, 368);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new System.Drawing.Size(111, 27);
            cboEstado.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.DarkSlateBlue;
            label5.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            label5.ForeColor = System.Drawing.Color.AliceBlue;
            label5.Location = new System.Drawing.Point(12, 333);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 19);
            label5.TabIndex = 29;
            label5.Text = "Estado";
            // 
            // txtIndice
            // 
            txtIndice.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtIndice.Location = new System.Drawing.Point(3, 577);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new System.Drawing.Size(29, 24);
            txtIndice.TabIndex = 28;
            txtIndice.Text = "0";
            txtIndice.Visible = false;
            // 
            // txtAsistenciaID
            // 
            txtAsistenciaID.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtAsistenciaID.Location = new System.Drawing.Point(38, 577);
            txtAsistenciaID.Name = "txtAsistenciaID";
            txtAsistenciaID.Size = new System.Drawing.Size(29, 24);
            txtAsistenciaID.TabIndex = 27;
            txtAsistenciaID.Text = "0";
            txtAsistenciaID.Visible = false;
            // 
            // cboAsignatura
            // 
            cboAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboAsignatura.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            cboAsignatura.FormattingEnabled = true;
            cboAsignatura.Location = new System.Drawing.Point(177, 118);
            cboAsignatura.Name = "cboAsignatura";
            cboAsignatura.Size = new System.Drawing.Size(111, 27);
            cboAsignatura.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.DarkSlateBlue;
            label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.Color.AliceBlue;
            label3.Location = new System.Drawing.Point(177, 83);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(85, 19);
            label3.TabIndex = 14;
            label3.Text = "Asignatura";
            // 
            // cboCurso
            // 
            cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCurso.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            cboCurso.FormattingEnabled = true;
            cboCurso.Location = new System.Drawing.Point(12, 118);
            cboCurso.Name = "cboCurso";
            cboCurso.Size = new System.Drawing.Size(111, 27);
            cboCurso.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.AliceBlue;
            label2.Location = new System.Drawing.Point(12, 83);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 19);
            label2.TabIndex = 12;
            label2.Text = "Curso";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            label1.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.AliceBlue;
            label1.Location = new System.Drawing.Point(20, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(250, 31);
            label1.TabIndex = 10;
            label1.Text = "ASISTENCIA DEL DIA";
            // 
            // txtNombre
            // 
            txtNombre.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtNombre.Location = new System.Drawing.Point(12, 286);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(205, 24);
            txtNombre.TabIndex = 9;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtCodigo.Location = new System.Drawing.Point(12, 211);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new System.Drawing.Size(205, 24);
            txtCodigo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.DarkSlateBlue;
            label4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            label4.ForeColor = System.Drawing.Color.AliceBlue;
            label4.Location = new System.Drawing.Point(12, 250);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 19);
            label4.TabIndex = 7;
            label4.Text = "Nombre:";
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.BackColor = System.Drawing.Color.DarkSlateBlue;
            lblusuario.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblusuario.ForeColor = System.Drawing.Color.AliceBlue;
            lblusuario.Location = new System.Drawing.Point(12, 178);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new System.Drawing.Size(61, 19);
            lblusuario.TabIndex = 6;
            lblusuario.Text = "Codigo:";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { btnSeleccionar, AsistenciaID, Codigo, Nombre, EstadoValor, Estado });
            dgvData.GridColor = System.Drawing.Color.SlateBlue;
            dgvData.Location = new System.Drawing.Point(317, 3);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.Size = new System.Drawing.Size(840, 598);
            dgvData.TabIndex = 19;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            btnSeleccionar.HeaderText = "";
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.ReadOnly = true;
            // 
            // AsistenciaID
            // 
            AsistenciaID.HeaderText = "AsistenciaId";
            AsistenciaID.Name = "AsistenciaID";
            AsistenciaID.ReadOnly = true;
            AsistenciaID.Visible = false;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre de Estudiante";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 350;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "PresenteValor";
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 200;
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
            btnLimpiar.IconSize = 18;
            btnLimpiar.Location = new System.Drawing.Point(20, 491);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(269, 30);
            btnLimpiar.TabIndex = 33;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
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
            btnEliminar.IconSize = 18;
            btnEliminar.Location = new System.Drawing.Point(21, 527);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(268, 30);
            btnEliminar.TabIndex = 32;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
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
            btnGuardar.IconSize = 18;
            btnGuardar.Location = new System.Drawing.Point(20, 455);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(268, 30);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // AsistenciaFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1157, 604);
            Controls.Add(dgvData);
            Controls.Add(panel1);
            Name = "AsistenciaFrm";
            Text = "AsistenciaFrm";
            Load += AsistenciaFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsistenciaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAsignatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.TextBox txtAsistenciaID;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label5;
        public FontAwesome.Sharp.IconButton btnLimpiar;
        public FontAwesome.Sharp.IconButton btnEliminar;
        public FontAwesome.Sharp.IconButton btnGuardar;
    }
}