namespace GestionNotas
{
    partial class UsuariosFrm
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
            label1 = new System.Windows.Forms.Label();
            lblusuario = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtUsuarioID = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            txtContrasena = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            cboRol = new System.Windows.Forms.ComboBox();
            cboEstado = new System.Windows.Forms.ComboBox();
            txtConfirmContra = new System.Windows.Forms.TextBox();
            ConfirContra = new System.Windows.Forms.Label();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            dgvData = new System.Windows.Forms.DataGridView();
            label8 = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            cboBuscar = new System.Windows.Forms.ComboBox();
            txtBuscar = new System.Windows.Forms.TextBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            txtIndice = new System.Windows.Forms.TextBox();
            btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            UsuarioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            label1.Dock = System.Windows.Forms.DockStyle.Left;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(266, 585);
            label1.TabIndex = 0;
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.BackColor = System.Drawing.Color.DarkSlateBlue;
            lblusuario.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblusuario.ForeColor = System.Drawing.Color.AliceBlue;
            lblusuario.Location = new System.Drawing.Point(28, 40);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new System.Drawing.Size(89, 19);
            lblusuario.TabIndex = 1;
            lblusuario.Text = "Usuario ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.DarkSlateBlue;
            label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.Color.AliceBlue;
            label3.Location = new System.Drawing.Point(28, 185);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 19);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.DarkSlateBlue;
            label4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            label4.ForeColor = System.Drawing.Color.AliceBlue;
            label4.Location = new System.Drawing.Point(28, 112);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 19);
            label4.TabIndex = 3;
            label4.Text = "Nombre:";
            // 
            // txtUsuarioID
            // 
            txtUsuarioID.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtUsuarioID.Location = new System.Drawing.Point(28, 73);
            txtUsuarioID.Name = "txtUsuarioID";
            txtUsuarioID.Size = new System.Drawing.Size(205, 24);
            txtUsuarioID.TabIndex = 4;
           
            // 
            // txtNombre
            // 
            txtNombre.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtNombre.Location = new System.Drawing.Point(28, 148);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(205, 24);
            txtNombre.TabIndex = 5;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtContrasena.Location = new System.Drawing.Point(28, 218);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new System.Drawing.Size(205, 24);
            txtContrasena.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.AliceBlue;
            label2.Location = new System.Drawing.Point(28, 331);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 19);
            label2.TabIndex = 7;
            label2.Text = "Rol:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.DarkSlateBlue;
            label5.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            label5.ForeColor = System.Drawing.Color.AliceBlue;
            label5.Location = new System.Drawing.Point(28, 405);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(61, 19);
            label5.TabIndex = 9;
            label5.Text = "Estado:";
            // 
            // cboRol
            // 
            cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboRol.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            cboRol.FormattingEnabled = true;
            cboRol.Location = new System.Drawing.Point(28, 364);
            cboRol.Name = "cboRol";
            cboRol.Size = new System.Drawing.Size(205, 27);
            cboRol.TabIndex = 10;
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboEstado.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new System.Drawing.Point(28, 438);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new System.Drawing.Size(205, 27);
            cboEstado.TabIndex = 11;
            // 
            // txtConfirmContra
            // 
            txtConfirmContra.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtConfirmContra.Location = new System.Drawing.Point(28, 294);
            txtConfirmContra.Name = "txtConfirmContra";
            txtConfirmContra.Size = new System.Drawing.Size(205, 24);
            txtConfirmContra.TabIndex = 13;
            // 
            // ConfirContra
            // 
            ConfirContra.AutoSize = true;
            ConfirContra.BackColor = System.Drawing.Color.DarkSlateBlue;
            ConfirContra.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            ConfirContra.ForeColor = System.Drawing.Color.AliceBlue;
            ConfirContra.Location = new System.Drawing.Point(28, 257);
            ConfirContra.Name = "ConfirContra";
            ConfirContra.Size = new System.Drawing.Size(169, 19);
            ConfirContra.TabIndex = 12;
            ConfirContra.Text = "Confirmar Contraseña:";
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
            btnGuardar.Location = new System.Drawing.Point(25, 485);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(96, 30);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
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
            btnEliminar.Location = new System.Drawing.Point(81, 521);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(96, 30);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = System.Drawing.SystemColors.HotTrack;
            btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditar.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold);
            btnEditar.ForeColor = System.Drawing.Color.Lavender;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnEditar.IconColor = System.Drawing.Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 18;
            btnEditar.Location = new System.Drawing.Point(140, 485);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(97, 30);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
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
            dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { btnSeleccionar, UsuarioId, Username, Password, Rol, RolId, EstadoValor, Estado });
            dgvData.Location = new System.Drawing.Point(272, 73);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.Size = new System.Drawing.Size(770, 512);
            dgvData.TabIndex = 18;
            dgvData.CellContentClick += dgvData_CellContentClick;
            dgvData.CellPainting += dgvData_CellPainting;
            // 
            // label8
            // 
            label8.BackColor = System.Drawing.Color.SlateBlue;
            label8.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.AliceBlue;
            label8.Location = new System.Drawing.Point(272, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(770, 70);
            label8.TabIndex = 19;
            label8.Text = "Lista de Usuarios:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            txtId.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtId.Location = new System.Drawing.Point(204, 35);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(29, 24);
            txtId.TabIndex = 20;
            
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.SlateBlue;
            label6.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.AliceBlue;
            label6.Location = new System.Drawing.Point(555, 35);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(89, 19);
            label6.TabIndex = 21;
            label6.Text = "Filtrar por:";
            // 
            // cboBuscar
            // 
            cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            cboBuscar.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            cboBuscar.FormattingEnabled = true;
            cboBuscar.Location = new System.Drawing.Point(654, 32);
            cboBuscar.Name = "cboBuscar";
            cboBuscar.Size = new System.Drawing.Size(116, 27);
            cboBuscar.TabIndex = 22;
            // 
            // txtBuscar
            // 
            txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtBuscar.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtBuscar.Location = new System.Drawing.Point(783, 32);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(127, 27);
            txtBuscar.TabIndex = 23;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = System.Drawing.Color.SlateBlue;
            btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuscar.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold);
            btnBuscar.ForeColor = System.Drawing.Color.AliceBlue;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = System.Drawing.SystemColors.Window;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 22;
            btnBuscar.Location = new System.Drawing.Point(926, 32);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(49, 27);
            btnBuscar.TabIndex = 25;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = System.Drawing.Color.SlateBlue;
            btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpiar.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold);
            btnLimpiar.ForeColor = System.Drawing.Color.AliceBlue;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiar.IconColor = System.Drawing.SystemColors.Window;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 22;
            btnLimpiar.Location = new System.Drawing.Point(981, 32);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(49, 27);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // txtIndice
            // 
            txtIndice.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtIndice.Location = new System.Drawing.Point(169, 35);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new System.Drawing.Size(29, 24);
            txtIndice.TabIndex = 26;
            txtIndice.Text = "0";
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
            UsuarioId.HeaderText = "UsuarioId";
            UsuarioId.Name = "UsuarioId";
            UsuarioId.ReadOnly = true;
            UsuarioId.Visible = false;
            // 
            // Username
            // 
            Username.HeaderText = "Nombre de Usuario";
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Width = 300;
            // 
            // Password
            // 
            Password.HeaderText = "Contraseña";
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Visible = false;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.Width = 200;
            // 
            // RolId
            // 
            RolId.HeaderText = "RolId";
            RolId.Name = "RolId";
            RolId.ReadOnly = true;
            RolId.Visible = false;
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
            Estado.Width = 180;
            // 
            // UsuariosFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.AliceBlue;
            ClientSize = new System.Drawing.Size(1043, 585);
            Controls.Add(txtIndice);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtBuscar);
            Controls.Add(cboBuscar);
            Controls.Add(label6);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(dgvData);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtConfirmContra);
            Controls.Add(ConfirContra);
            Controls.Add(cboEstado);
            Controls.Add(cboRol);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txtContrasena);
            Controls.Add(txtNombre);
            Controls.Add(txtUsuarioID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblusuario);
            Controls.Add(label1);
            Name = "UsuariosFrm";
            Text = "Usuarios";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuarioID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtConfirmContra;
        private System.Windows.Forms.Label ConfirContra;
        public FontAwesome.Sharp.IconButton btnGuardar;
        public FontAwesome.Sharp.IconButton btnEliminar;
        public FontAwesome.Sharp.IconButton btnEditar;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        public FontAwesome.Sharp.IconButton btnLimpiar;
        public FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}