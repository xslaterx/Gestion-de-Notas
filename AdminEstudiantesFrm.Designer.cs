namespace GestionNotas
{
    partial class AdminEstudiantesFrm
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
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtApellido = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            lblSexo = new System.Windows.Forms.Label();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtTelefono = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            txtCodigo = new System.Windows.Forms.TextBox();
            lblNombre = new System.Windows.Forms.Label();
            lblTelefono = new System.Windows.Forms.Label();
            lblEstudiante = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtEnfermedad = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtMedicamento = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txtNumeroEmergencia = new System.Windows.Forms.TextBox();
            txtTutorNombre = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            dgvData = new System.Windows.Forms.DataGridView();
            btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            UsuarioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Enfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NombreApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Parentesco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NumeroEmergencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtIndice = new System.Windows.Forms.TextBox();
            txtEstudianteID = new System.Windows.Forms.TextBox();
            txtTutor = new System.Windows.Forms.TextBox();
            txtSexo = new System.Windows.Forms.TextBox();
            txtFechaRegistro = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            txtBuscar = new System.Windows.Forms.TextBox();
            cboBuscar = new System.Windows.Forms.ComboBox();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            cbocursos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1108, 588);
            label1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.DarkSlateBlue;
            label3.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.AliceBlue;
            label3.Location = new System.Drawing.Point(194, 5);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(347, 31);
            label3.TabIndex = 34;
            label3.Text = "ADMINISTRAR ESTUDIANTES";
            // 
            // txtApellido
            // 
            txtApellido.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtApellido.Location = new System.Drawing.Point(12, 229);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(218, 24);
            txtApellido.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.AliceBlue;
            label2.Location = new System.Drawing.Point(12, 193);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 19);
            label2.TabIndex = 56;
            label2.Text = "Apellidos:";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.BackColor = System.Drawing.Color.DarkSlateBlue;
            lblSexo.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSexo.ForeColor = System.Drawing.Color.AliceBlue;
            lblSexo.Location = new System.Drawing.Point(12, 415);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new System.Drawing.Size(48, 23);
            lblSexo.TabIndex = 53;
            lblSexo.Text = "Sexo";
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
            btnLimpiar.Location = new System.Drawing.Point(376, 452);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(262, 30);
            btnLimpiar.TabIndex = 52;
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
            btnEliminar.Location = new System.Drawing.Point(376, 494);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(262, 30);
            btnEliminar.TabIndex = 51;
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
            btnGuardar.Location = new System.Drawing.Point(376, 409);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(262, 30);
            btnGuardar.TabIndex = 50;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtTelefono.Location = new System.Drawing.Point(12, 298);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(218, 24);
            txtTelefono.TabIndex = 47;
            // 
            // txtNombre
            // 
            txtNombre.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtNombre.Location = new System.Drawing.Point(12, 156);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(218, 24);
            txtNombre.TabIndex = 46;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtCodigo.Location = new System.Drawing.Point(12, 81);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new System.Drawing.Size(218, 24);
            txtCodigo.TabIndex = 45;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = System.Drawing.Color.DarkSlateBlue;
            lblNombre.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            lblNombre.ForeColor = System.Drawing.Color.AliceBlue;
            lblNombre.Location = new System.Drawing.Point(12, 120);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(76, 19);
            lblNombre.TabIndex = 44;
            lblNombre.Text = "Nombres:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = System.Drawing.Color.DarkSlateBlue;
            lblTelefono.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            lblTelefono.ForeColor = System.Drawing.Color.AliceBlue;
            lblTelefono.Location = new System.Drawing.Point(12, 265);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new System.Drawing.Size(69, 19);
            lblTelefono.TabIndex = 43;
            lblTelefono.Text = "Telefono";
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.BackColor = System.Drawing.Color.DarkSlateBlue;
            lblEstudiante.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblEstudiante.ForeColor = System.Drawing.Color.AliceBlue;
            lblEstudiante.Location = new System.Drawing.Point(12, 48);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new System.Drawing.Size(167, 19);
            lblEstudiante.TabIndex = 42;
            lblEstudiante.Text = "Codigo del Estudiante:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.DarkSlateBlue;
            label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.AliceBlue;
            label4.Location = new System.Drawing.Point(361, 49);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(221, 24);
            label4.TabIndex = 58;
            label4.Text = "DATOS DE EMERGENCIA\r\n";
            // 
            // txtEnfermedad
            // 
            txtEnfermedad.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtEnfermedad.Location = new System.Drawing.Point(275, 136);
            txtEnfermedad.Multiline = true;
            txtEnfermedad.Name = "txtEnfermedad";
            txtEnfermedad.Size = new System.Drawing.Size(218, 44);
            txtEnfermedad.TabIndex = 59;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.DarkSlateBlue;
            label5.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            label5.ForeColor = System.Drawing.Color.AliceBlue;
            label5.Location = new System.Drawing.Point(283, 110);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(200, 19);
            label5.TabIndex = 60;
            label5.Text = "Enfermedades o Alergico a:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.DarkSlateBlue;
            label6.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            label6.ForeColor = System.Drawing.Color.AliceBlue;
            label6.Location = new System.Drawing.Point(530, 110);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(172, 19);
            label6.TabIndex = 63;
            label6.Text = "Medicamentos que usa:";
            // 
            // txtMedicamento
            // 
            txtMedicamento.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtMedicamento.Location = new System.Drawing.Point(521, 136);
            txtMedicamento.Multiline = true;
            txtMedicamento.Name = "txtMedicamento";
            txtMedicamento.Size = new System.Drawing.Size(205, 44);
            txtMedicamento.TabIndex = 64;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.DarkSlateBlue;
            label7.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            label7.ForeColor = System.Drawing.Color.AliceBlue;
            label7.Location = new System.Drawing.Point(283, 209);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(177, 19);
            label7.TabIndex = 65;
            label7.Text = "Numero de Emergencia:";
            // 
            // txtNumeroEmergencia
            // 
            txtNumeroEmergencia.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtNumeroEmergencia.Location = new System.Drawing.Point(275, 245);
            txtNumeroEmergencia.Name = "txtNumeroEmergencia";
            txtNumeroEmergencia.Size = new System.Drawing.Size(218, 24);
            txtNumeroEmergencia.TabIndex = 66;
            // 
            // txtTutorNombre
            // 
            txtTutorNombre.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtTutorNombre.Location = new System.Drawing.Point(275, 314);
            txtTutorNombre.Name = "txtTutorNombre";
            txtTutorNombre.Size = new System.Drawing.Size(218, 24);
            txtTutorNombre.TabIndex = 68;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.DarkSlateBlue;
            label8.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            label8.ForeColor = System.Drawing.Color.AliceBlue;
            label8.Location = new System.Drawing.Point(275, 281);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(143, 19);
            label8.TabIndex = 67;
            label8.Text = "Nombre y Apellido:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.DarkSlateBlue;
            label9.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            label9.ForeColor = System.Drawing.Color.AliceBlue;
            label9.Location = new System.Drawing.Point(521, 281);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(91, 19);
            label9.TabIndex = 69;
            label9.Text = "Parentesco:";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { btnSeleccionar, UsuarioId, Codigo, Username, Password, Telefono, FechaRegistro, Enfermedad, Medicamento, NombreApellido, Parentesco, NumeroEmergencia, Sexo });
            dgvData.Location = new System.Drawing.Point(741, 108);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.Size = new System.Drawing.Size(368, 454);
            dgvData.TabIndex = 71;
            dgvData.CellContentClick += dgvData_CellContentClick;
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
            UsuarioId.HeaderText = "EstudianteId";
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
            Username.HeaderText = "Nombres";
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Width = 200;
            // 
            // Password
            // 
            Password.HeaderText = "Apellidos";
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "Fecha de Registro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            // 
            // Enfermedad
            // 
            Enfermedad.HeaderText = "Enfermedad";
            Enfermedad.Name = "Enfermedad";
            Enfermedad.ReadOnly = true;
            // 
            // Medicamento
            // 
            Medicamento.HeaderText = "Medicamento";
            Medicamento.Name = "Medicamento";
            Medicamento.ReadOnly = true;
            // 
            // NombreApellido
            // 
            NombreApellido.HeaderText = "Nombre y Apellido";
            NombreApellido.Name = "NombreApellido";
            NombreApellido.ReadOnly = true;
            // 
            // Parentesco
            // 
            Parentesco.HeaderText = "Parentesco";
            Parentesco.Name = "Parentesco";
            Parentesco.ReadOnly = true;
            // 
            // NumeroEmergencia
            // 
            NumeroEmergencia.HeaderText = "Numero de Emergencia";
            NumeroEmergencia.Name = "NumeroEmergencia";
            NumeroEmergencia.ReadOnly = true;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            // 
            // txtIndice
            // 
            txtIndice.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtIndice.Location = new System.Drawing.Point(12, 12);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new System.Drawing.Size(29, 24);
            txtIndice.TabIndex = 73;
            txtIndice.Text = "0";
            txtIndice.Visible = false;
            // 
            // txtEstudianteID
            // 
            txtEstudianteID.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtEstudianteID.Location = new System.Drawing.Point(47, 12);
            txtEstudianteID.Name = "txtEstudianteID";
            txtEstudianteID.Size = new System.Drawing.Size(29, 24);
            txtEstudianteID.TabIndex = 72;
            txtEstudianteID.Text = "0";
            txtEstudianteID.Visible = false;
            // 
            // txtTutor
            // 
            txtTutor.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtTutor.Location = new System.Drawing.Point(508, 314);
            txtTutor.Name = "txtTutor";
            txtTutor.Size = new System.Drawing.Size(218, 24);
            txtTutor.TabIndex = 75;
            // 
            // txtSexo
            // 
            txtSexo.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtSexo.Location = new System.Drawing.Point(12, 454);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new System.Drawing.Size(48, 24);
            txtSexo.TabIndex = 76;
            // 
            // txtFechaRegistro
            // 
            txtFechaRegistro.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtFechaRegistro.Location = new System.Drawing.Point(12, 376);
            txtFechaRegistro.Name = "txtFechaRegistro";
            txtFechaRegistro.Size = new System.Drawing.Size(218, 24);
            txtFechaRegistro.TabIndex = 78;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.DarkSlateBlue;
            label10.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            label10.ForeColor = System.Drawing.Color.AliceBlue;
            label10.Location = new System.Drawing.Point(12, 339);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(134, 19);
            label10.TabIndex = 77;
            label10.Text = "Fecha de Registro";
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
            btnBuscar.Location = new System.Drawing.Point(1003, 34);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(49, 27);
            btnBuscar.TabIndex = 83;
            btnBuscar.UseVisualStyleBackColor = false;
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
            btnLimpiarBuscador.Location = new System.Drawing.Point(1058, 34);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.Size = new System.Drawing.Size(49, 27);
            btnLimpiarBuscador.TabIndex = 82;
            btnLimpiarBuscador.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtBuscar.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtBuscar.Location = new System.Drawing.Point(825, 75);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(120, 27);
            txtBuscar.TabIndex = 81;
            // 
            // cboBuscar
            // 
            cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            cboBuscar.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            cboBuscar.FormattingEnabled = true;
            cboBuscar.Location = new System.Drawing.Point(825, 34);
            cboBuscar.Name = "cboBuscar";
            cboBuscar.Size = new System.Drawing.Size(120, 27);
            cboBuscar.TabIndex = 80;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.DarkSlateBlue;
            label11.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.AliceBlue;
            label11.Location = new System.Drawing.Point(712, 37);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(89, 19);
            label11.TabIndex = 79;
            label11.Text = "Filtrar por:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = System.Drawing.Color.DarkSlateBlue;
            label12.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.Color.AliceBlue;
            label12.Location = new System.Drawing.Point(111, 416);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(122, 23);
            label12.TabIndex = 84;
            label12.Text = "Asignar Curso";
            // 
            // cbocursos
            // 
            cbocursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbocursos.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            cbocursos.FormattingEnabled = true;
            cbocursos.Location = new System.Drawing.Point(111, 451);
            cbocursos.Name = "cbocursos";
            cbocursos.Size = new System.Drawing.Size(205, 27);
            cbocursos.TabIndex = 85;
            cbocursos.SelectedIndexChanged += cbocursos_SelectedIndexChanged;
            // 
            // AdminEstudiantesFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1108, 566);
            Controls.Add(cbocursos);
            Controls.Add(label12);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiarBuscador);
            Controls.Add(txtBuscar);
            Controls.Add(cboBuscar);
            Controls.Add(label11);
            Controls.Add(txtFechaRegistro);
            Controls.Add(label10);
            Controls.Add(txtSexo);
            Controls.Add(txtTutor);
            Controls.Add(txtIndice);
            Controls.Add(txtEstudianteID);
            Controls.Add(dgvData);
            Controls.Add(label9);
            Controls.Add(txtTutorNombre);
            Controls.Add(label8);
            Controls.Add(txtNumeroEmergencia);
            Controls.Add(label7);
            Controls.Add(txtMedicamento);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtEnfermedad);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(lblSexo);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(lblNombre);
            Controls.Add(lblTelefono);
            Controls.Add(lblEstudiante);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "AdminEstudiantesFrm";
            Text = "EstudiantesFrm";
            Load += AdminEstudiantesFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSexo;
        public FontAwesome.Sharp.IconButton btnLimpiar;
        public FontAwesome.Sharp.IconButton btnEliminar;
        public FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnfermedad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumeroEmergencia;
        private System.Windows.Forms.TextBox txtTutorNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.TextBox txtEstudianteID;
        private System.Windows.Forms.TextBox txtTutor;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtFechaRegistro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enfermedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parentesco;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroEmergencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        public FontAwesome.Sharp.IconButton btnBuscar;
        public FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbocursos;
    }
}