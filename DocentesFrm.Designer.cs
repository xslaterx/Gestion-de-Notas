namespace GestionNotas
{
    partial class DocentesFrm
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtCorreo = new System.Windows.Forms.TextBox();
            lblCorreo = new System.Windows.Forms.Label();
            cboEstado = new System.Windows.Forms.ComboBox();
            cboAula = new System.Windows.Forms.ComboBox();
            lblEstado = new System.Windows.Forms.Label();
            lblAula = new System.Windows.Forms.Label();
            txtTelefono = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            txtCodigo = new System.Windows.Forms.TextBox();
            lblNombreApe = new System.Windows.Forms.Label();
            lblTelefono = new System.Windows.Forms.Label();
            lblDocente = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            dgvDataDocente = new System.Windows.Forms.DataGridView();
            btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            UsuarioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AulaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maestroBindingSource = new System.Windows.Forms.BindingSource(components);
            lblListaDocentes = new System.Windows.Forms.Label();
            lblSexo = new System.Windows.Forms.Label();
            txtApellido = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            txtIndice = new System.Windows.Forms.TextBox();
            txtMaestroId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDataDocente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maestroBindingSource).BeginInit();
            SuspendLayout();
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
            btnLimpiar.Location = new System.Drawing.Point(245, 468);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(150, 30);
            btnLimpiar.TabIndex = 31;
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
            btnEliminar.IconSize = 20;
            btnEliminar.Location = new System.Drawing.Point(140, 511);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(150, 30);
            btnEliminar.TabIndex = 30;
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
            btnGuardar.IconSize = 20;
            btnGuardar.Location = new System.Drawing.Point(32, 468);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(150, 30);
            btnGuardar.TabIndex = 29;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtCorreo.Location = new System.Drawing.Point(17, 406);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new System.Drawing.Size(218, 24);
            txtCorreo.TabIndex = 28;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = System.Drawing.Color.DarkSlateBlue;
            lblCorreo.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            lblCorreo.ForeColor = System.Drawing.Color.AliceBlue;
            lblCorreo.Location = new System.Drawing.Point(17, 369);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new System.Drawing.Size(56, 19);
            lblCorreo.TabIndex = 27;
            lblCorreo.Text = "Correo\r\n";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboEstado.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new System.Drawing.Point(283, 187);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new System.Drawing.Size(99, 27);
            cboEstado.TabIndex = 26;
            // 
            // cboAula
            // 
            cboAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboAula.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            cboAula.FormattingEnabled = true;
            cboAula.Location = new System.Drawing.Point(283, 113);
            cboAula.Name = "cboAula";
            cboAula.Size = new System.Drawing.Size(99, 27);
            cboAula.TabIndex = 25;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = System.Drawing.Color.DarkSlateBlue;
            lblEstado.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            lblEstado.ForeColor = System.Drawing.Color.AliceBlue;
            lblEstado.Location = new System.Drawing.Point(283, 154);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new System.Drawing.Size(61, 19);
            lblEstado.TabIndex = 24;
            lblEstado.Text = "Estado:";
            // 
            // lblAula
            // 
            lblAula.AutoSize = true;
            lblAula.BackColor = System.Drawing.Color.DarkSlateBlue;
            lblAula.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            lblAula.ForeColor = System.Drawing.Color.AliceBlue;
            lblAula.Location = new System.Drawing.Point(283, 80);
            lblAula.Name = "lblAula";
            lblAula.Size = new System.Drawing.Size(45, 19);
            lblAula.TabIndex = 23;
            lblAula.Text = "Aula:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtTelefono.Location = new System.Drawing.Point(17, 330);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(218, 24);
            txtTelefono.TabIndex = 22;
            // 
            // txtNombre
            // 
            txtNombre.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtNombre.Location = new System.Drawing.Point(17, 188);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(218, 24);
            txtNombre.TabIndex = 21;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtCodigo.Location = new System.Drawing.Point(17, 113);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new System.Drawing.Size(218, 24);
            txtCodigo.TabIndex = 20;
            // 
            // lblNombreApe
            // 
            lblNombreApe.AutoSize = true;
            lblNombreApe.BackColor = System.Drawing.Color.DarkSlateBlue;
            lblNombreApe.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            lblNombreApe.ForeColor = System.Drawing.Color.AliceBlue;
            lblNombreApe.Location = new System.Drawing.Point(17, 152);
            lblNombreApe.Name = "lblNombreApe";
            lblNombreApe.Size = new System.Drawing.Size(76, 19);
            lblNombreApe.TabIndex = 19;
            lblNombreApe.Text = "Nombres:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = System.Drawing.Color.DarkSlateBlue;
            lblTelefono.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            lblTelefono.ForeColor = System.Drawing.Color.AliceBlue;
            lblTelefono.Location = new System.Drawing.Point(17, 297);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new System.Drawing.Size(69, 19);
            lblTelefono.TabIndex = 18;
            lblTelefono.Text = "Telefono";
            // 
            // lblDocente
            // 
            lblDocente.AutoSize = true;
            lblDocente.BackColor = System.Drawing.Color.DarkSlateBlue;
            lblDocente.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDocente.ForeColor = System.Drawing.Color.AliceBlue;
            lblDocente.Location = new System.Drawing.Point(17, 80);
            lblDocente.Name = "lblDocente";
            lblDocente.Size = new System.Drawing.Size(61, 19);
            lblDocente.TabIndex = 17;
            lblDocente.Text = "Codigo:";
            lblDocente.Click += lblusuario_Click;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            label1.Dock = System.Windows.Forms.DockStyle.Left;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(411, 553);
            label1.TabIndex = 32;
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.DarkSlateBlue;
            label3.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.AliceBlue;
            label3.Location = new System.Drawing.Point(22, 2);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(307, 31);
            label3.TabIndex = 33;
            label3.Text = "ADMINISTRAR DOCENTES";
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            textBox1.Location = new System.Drawing.Point(0, 37);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(411, 5);
            textBox1.TabIndex = 34;
            // 
            // dgvDataDocente
            // 
            dgvDataDocente.AllowUserToAddRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvDataDocente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDataDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { btnSeleccionar, UsuarioId, Codigo, Username, Apellidos, Telefono, Correo, Aula, AulaId, EstadoValor, Estado });
            dgvDataDocente.Location = new System.Drawing.Point(417, 41);
            dgvDataDocente.MultiSelect = false;
            dgvDataDocente.Name = "dgvDataDocente";
            dgvDataDocente.ReadOnly = true;
            dgvDataDocente.Size = new System.Drawing.Size(768, 512);
            dgvDataDocente.TabIndex = 35;
            dgvDataDocente.CellContentClick += dgvDataDocente_CellContentClick;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "";
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.ReadOnly = true;
            btnSeleccionar.Width = 30;
            // 
            // UsuarioId
            // 
            UsuarioId.HeaderText = "Docente ID";
            UsuarioId.Name = "UsuarioId";
            UsuarioId.ReadOnly = true;
            UsuarioId.Visible = false;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Username
            // 
            Username.FillWeight = 70F;
            Username.HeaderText = "Nombres";
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Width = 180;
            // 
            // Apellidos
            // 
            Apellidos.HeaderText = "Apellidos";
            Apellidos.Name = "Apellidos";
            Apellidos.ReadOnly = true;
            Apellidos.Width = 150;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 120;
            // 
            // Aula
            // 
            Aula.HeaderText = "Aula";
            Aula.Name = "Aula";
            Aula.ReadOnly = true;
            Aula.Width = 50;
            // 
            // AulaId
            // 
            AulaId.HeaderText = "AulaId";
            AulaId.Name = "AulaId";
            AulaId.ReadOnly = true;
            AulaId.Visible = false;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 150;
            // 
            // maestroBindingSource
            // 
            maestroBindingSource.DataSource = typeof(BDGestion.Maestro);
            // 
            // lblListaDocentes
            // 
            lblListaDocentes.BackColor = System.Drawing.Color.DarkSlateBlue;
            lblListaDocentes.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblListaDocentes.ForeColor = System.Drawing.Color.AliceBlue;
            lblListaDocentes.Location = new System.Drawing.Point(417, 0);
            lblListaDocentes.Name = "lblListaDocentes";
            lblListaDocentes.Size = new System.Drawing.Size(768, 38);
            lblListaDocentes.TabIndex = 36;
            lblListaDocentes.Text = "LISTA DE DOCENTES\r\n";
            lblListaDocentes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            lblListaDocentes.Click += lblListaDocentes_Click;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.BackColor = System.Drawing.Color.DarkSlateBlue;
            lblSexo.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSexo.ForeColor = System.Drawing.Color.AliceBlue;
            lblSexo.Location = new System.Drawing.Point(283, 225);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new System.Drawing.Size(48, 23);
            lblSexo.TabIndex = 37;
            lblSexo.Text = "Sexo";
            lblSexo.Click += lblSexo_Click;
            // 
            // txtApellido
            // 
            txtApellido.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtApellido.Location = new System.Drawing.Point(17, 261);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(218, 24);
            txtApellido.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.AliceBlue;
            label2.Location = new System.Drawing.Point(17, 225);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 19);
            label2.TabIndex = 40;
            label2.Text = "Apellidos:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = System.Drawing.Color.DarkSlateBlue;
            radioButton2.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            radioButton2.ForeColor = System.Drawing.Color.AliceBlue;
            radioButton2.Location = new System.Drawing.Point(283, 296);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(89, 22);
            radioButton2.TabIndex = 64;
            radioButton2.TabStop = true;
            radioButton2.Text = "Femenino";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = System.Drawing.Color.DarkSlateBlue;
            radioButton1.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            radioButton1.ForeColor = System.Drawing.Color.AliceBlue;
            radioButton1.Location = new System.Drawing.Point(283, 261);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(92, 22);
            radioButton1.TabIndex = 63;
            radioButton1.TabStop = true;
            radioButton1.Text = "Masculino";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // txtIndice
            // 
            txtIndice.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtIndice.Location = new System.Drawing.Point(315, 48);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new System.Drawing.Size(29, 24);
            txtIndice.TabIndex = 66;
            txtIndice.Text = "0";
            txtIndice.Visible = false;
            // 
            // txtMaestroId
            // 
            txtMaestroId.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtMaestroId.Location = new System.Drawing.Point(350, 48);
            txtMaestroId.Name = "txtMaestroId";
            txtMaestroId.Size = new System.Drawing.Size(29, 24);
            txtMaestroId.TabIndex = 65;
            txtMaestroId.Text = "0";
            txtMaestroId.Visible = false;
            // 
            // DocentesFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1185, 553);
            Controls.Add(txtIndice);
            Controls.Add(txtMaestroId);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(lblSexo);
            Controls.Add(lblListaDocentes);
            Controls.Add(dgvDataDocente);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(cboEstado);
            Controls.Add(cboAula);
            Controls.Add(lblEstado);
            Controls.Add(lblAula);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(lblNombreApe);
            Controls.Add(lblTelefono);
            Controls.Add(lblDocente);
            Controls.Add(label1);
            Name = "DocentesFrm";
            Text = "Docentes";
            Load += DocentesFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDataDocente).EndInit();
            ((System.ComponentModel.ISupportInitialize)maestroBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public FontAwesome.Sharp.IconButton btnLimpiar;
        public FontAwesome.Sharp.IconButton btnEliminar;
        public FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.ComboBox cboAula;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombreApe;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvDataDocente;
        private System.Windows.Forms.Label lblListaDocentes;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.BindingSource maestroBindingSource;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.TextBox txtMaestroId;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aula;
        private System.Windows.Forms.DataGridViewTextBoxColumn AulaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}