namespace GestionNotas
{
    partial class AsignarcaliFrm
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
            System.Windows.Forms.Label label14;
            txtCuartoP = new System.Windows.Forms.TextBox();
            txtSegundoP = new System.Windows.Forms.TextBox();
            txtTercerP = new System.Windows.Forms.TextBox();
            txtPrimerP = new System.Windows.Forms.TextBox();
            lblusuario = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtAcumuladoC = new System.Windows.Forms.TextBox();
            txtAcumuladoE = new System.Windows.Forms.TextBox();
            txtExamenC = new System.Windows.Forms.TextBox();
            txtExamenE = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            txtPuntuacionFF = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            txtIndice = new System.Windows.Forms.TextBox();
            txtCalificacionId = new System.Windows.Forms.TextBox();
            btncalcular = new System.Windows.Forms.Button();
            btningresar = new System.Windows.Forms.Button();
            txtFinalC = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtPromedio = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtPuntuacionF = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            txtExamenF = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            dgvData = new System.Windows.Forms.DataGridView();
            btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            CalificacionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IdEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NombreEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ApellidoEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PrimerPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SegundoPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TercerPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CuartoPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PromedioPeriodos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ExamenFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PuntuacionFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AcumuladoCompletivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ExamenCompletivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FinalCompletivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AcumuladoExtraordinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ExamenExtraordinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FinalExtraordinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label14 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = System.Drawing.Color.DarkSlateBlue;
            label14.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label14.ForeColor = System.Drawing.Color.AliceBlue;
            label14.Location = new System.Drawing.Point(235, 459);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(185, 19);
            label14.TabIndex = 39;
            label14.Text = "FINAL EXTRAORDINARIO";
            // 
            // txtCuartoP
            // 
            txtCuartoP.Location = new System.Drawing.Point(30, 331);
            txtCuartoP.Name = "txtCuartoP";
            txtCuartoP.Size = new System.Drawing.Size(94, 23);
            txtCuartoP.TabIndex = 1;
            // 
            // txtSegundoP
            // 
            txtSegundoP.Location = new System.Drawing.Point(30, 180);
            txtSegundoP.Name = "txtSegundoP";
            txtSegundoP.Size = new System.Drawing.Size(94, 23);
            txtSegundoP.TabIndex = 2;
            // 
            // txtTercerP
            // 
            txtTercerP.Location = new System.Drawing.Point(30, 255);
            txtTercerP.Name = "txtTercerP";
            txtTercerP.Size = new System.Drawing.Size(94, 23);
            txtTercerP.TabIndex = 3;
            // 
            // txtPrimerP
            // 
            txtPrimerP.Location = new System.Drawing.Point(33, 98);
            txtPrimerP.Name = "txtPrimerP";
            txtPrimerP.Size = new System.Drawing.Size(94, 23);
            txtPrimerP.TabIndex = 4;
            txtPrimerP.TextChanged += textBox4_TextChanged;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.BackColor = System.Drawing.Color.DarkSlateBlue;
            lblusuario.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblusuario.ForeColor = System.Drawing.Color.AliceBlue;
            lblusuario.Location = new System.Drawing.Point(94, 9);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new System.Drawing.Size(168, 19);
            lblusuario.TabIndex = 5;
            lblusuario.Text = "CURSO / ASIGNATURA:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(268, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(207, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.AliceBlue;
            label2.Location = new System.Drawing.Point(30, 58);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(134, 19);
            label2.TabIndex = 9;
            label2.Text = "PRIMER PERIODO";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.DarkSlateBlue;
            label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.AliceBlue;
            label3.Location = new System.Drawing.Point(29, 296);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(135, 19);
            label3.TabIndex = 10;
            label3.Text = "CUARTO PERIODO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.DarkSlateBlue;
            label4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.AliceBlue;
            label4.Location = new System.Drawing.Point(29, 223);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(133, 19);
            label4.TabIndex = 11;
            label4.Text = "TERCER PERIODO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.DarkSlateBlue;
            label5.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.AliceBlue;
            label5.Location = new System.Drawing.Point(27, 148);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(146, 19);
            label5.TabIndex = 12;
            label5.Text = "SEGUNDO PERIODO";
            label5.Click += label5_Click;
            // 
            // txtAcumuladoC
            // 
            txtAcumuladoC.Location = new System.Drawing.Point(235, 98);
            txtAcumuladoC.Name = "txtAcumuladoC";
            txtAcumuladoC.Size = new System.Drawing.Size(100, 23);
            txtAcumuladoC.TabIndex = 18;
            // 
            // txtAcumuladoE
            // 
            txtAcumuladoE.Location = new System.Drawing.Point(235, 333);
            txtAcumuladoE.Name = "txtAcumuladoE";
            txtAcumuladoE.Size = new System.Drawing.Size(100, 23);
            txtAcumuladoE.TabIndex = 17;
            // 
            // txtExamenC
            // 
            txtExamenC.Location = new System.Drawing.Point(235, 180);
            txtExamenC.Name = "txtExamenC";
            txtExamenC.Size = new System.Drawing.Size(100, 23);
            txtExamenC.TabIndex = 16;
            // 
            // txtExamenE
            // 
            txtExamenE.Location = new System.Drawing.Point(235, 409);
            txtExamenE.Name = "txtExamenE";
            txtExamenE.Size = new System.Drawing.Size(100, 23);
            txtExamenE.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.DarkSlateBlue;
            label8.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.AliceBlue;
            label8.Location = new System.Drawing.Point(235, 148);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(166, 19);
            label8.TabIndex = 22;
            label8.Text = "EXAMEN COMPLETIVO";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.DarkSlateBlue;
            label9.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.AliceBlue;
            label9.Location = new System.Drawing.Point(235, 301);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(232, 19);
            label9.TabIndex = 21;
            label9.Text = "ACUMULADO EXTRAORDINARIO";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.DarkSlateBlue;
            label10.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.AliceBlue;
            label10.Location = new System.Drawing.Point(235, 371);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(201, 19);
            label10.TabIndex = 20;
            label10.Text = "EXAMEN EXTRAORDINARIO";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.DarkSlateBlue;
            label11.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.AliceBlue;
            label11.Location = new System.Drawing.Point(235, 58);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(197, 19);
            label11.TabIndex = 19;
            label11.Text = "ACUMULADO COMPLETIVO";
            // 
            // txtPuntuacionFF
            // 
            txtPuntuacionFF.Location = new System.Drawing.Point(235, 496);
            txtPuntuacionFF.Name = "txtPuntuacionFF";
            txtPuntuacionFF.Size = new System.Drawing.Size(100, 23);
            txtPuntuacionFF.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            panel1.Controls.Add(txtIndice);
            panel1.Controls.Add(txtCalificacionId);
            panel1.Controls.Add(txtPrimerP);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(btncalcular);
            panel1.Controls.Add(btningresar);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtFinalC);
            panel1.Controls.Add(txtAcumuladoC);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtPromedio);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPuntuacionF);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtExamenF);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(dgvData);
            panel1.Controls.Add(txtPuntuacionFF);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(lblusuario);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtExamenE);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtAcumuladoE);
            panel1.Controls.Add(txtCuartoP);
            panel1.Controls.Add(txtTercerP);
            panel1.Controls.Add(txtExamenC);
            panel1.Controls.Add(txtSegundoP);
            panel1.Controls.Add(label4);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1104, 618);
            panel1.TabIndex = 25;
            // 
            // txtIndice
            // 
            txtIndice.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtIndice.Location = new System.Drawing.Point(2, 4);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new System.Drawing.Size(14, 24);
            txtIndice.TabIndex = 41;
            txtIndice.Text = "0";
            txtIndice.Visible = false;
            // 
            // txtCalificacionId
            // 
            txtCalificacionId.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            txtCalificacionId.Location = new System.Drawing.Point(37, 4);
            txtCalificacionId.Name = "txtCalificacionId";
            txtCalificacionId.Size = new System.Drawing.Size(14, 24);
            txtCalificacionId.TabIndex = 40;
            txtCalificacionId.Text = "0";
            txtCalificacionId.Visible = false;
            // 
            // btncalcular
            // 
            btncalcular.Location = new System.Drawing.Point(235, 580);
            btncalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new System.Drawing.Size(201, 30);
            btncalcular.TabIndex = 38;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // btningresar
            // 
            btningresar.Location = new System.Drawing.Point(235, 545);
            btningresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btningresar.Name = "btningresar";
            btningresar.Size = new System.Drawing.Size(201, 30);
            btningresar.TabIndex = 37;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += btningresar_Click;
            // 
            // txtFinalC
            // 
            txtFinalC.Enabled = false;
            txtFinalC.Location = new System.Drawing.Point(235, 255);
            txtFinalC.Name = "txtFinalC";
            txtFinalC.Size = new System.Drawing.Size(100, 23);
            txtFinalC.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.DarkSlateBlue;
            label6.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.AliceBlue;
            label6.Location = new System.Drawing.Point(235, 223);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(150, 19);
            label6.TabIndex = 35;
            label6.Text = "FINAL COMPLETIVO";
            // 
            // txtPromedio
            // 
            txtPromedio.Enabled = false;
            txtPromedio.Location = new System.Drawing.Point(33, 409);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new System.Drawing.Size(91, 23);
            txtPromedio.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            label1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.AliceBlue;
            label1.Location = new System.Drawing.Point(27, 374);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 19);
            label1.TabIndex = 33;
            label1.Text = "PROMEDIO FINAL";
            // 
            // txtPuntuacionF
            // 
            txtPuntuacionF.Enabled = false;
            txtPuntuacionF.Location = new System.Drawing.Point(33, 568);
            txtPuntuacionF.Name = "txtPuntuacionF";
            txtPuntuacionF.Size = new System.Drawing.Size(94, 23);
            txtPuntuacionF.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = System.Drawing.Color.DarkSlateBlue;
            label12.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.Color.AliceBlue;
            label12.Location = new System.Drawing.Point(27, 533);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(153, 19);
            label12.TabIndex = 31;
            label12.Text = "PUNTUACION FINAL";
            // 
            // txtExamenF
            // 
            txtExamenF.Location = new System.Drawing.Point(33, 492);
            txtExamenF.Name = "txtExamenF";
            txtExamenF.Size = new System.Drawing.Size(94, 23);
            txtExamenF.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = System.Drawing.Color.DarkSlateBlue;
            label13.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label13.ForeColor = System.Drawing.Color.AliceBlue;
            label13.Location = new System.Drawing.Point(33, 453);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(117, 19);
            label13.TabIndex = 29;
            label13.Text = "EXAMEN FINAL";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { btnSeleccionar, CalificacionId, IdEstudiante, NombreEstudiante, ApellidoEstudiante, PrimerPeriodo, SegundoPeriodo, TercerPeriodo, CuartoPeriodo, PromedioPeriodos, ExamenFinal, PuntuacionFinal, AcumuladoCompletivo, ExamenCompletivo, FinalCompletivo, AcumuladoExtraordinario, ExamenExtraordinario, FinalExtraordinario, Estado });
            dgvData.Location = new System.Drawing.Point(500, 26);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new System.Drawing.Size(592, 580);
            dgvData.TabIndex = 26;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "";
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Width = 30;
            // 
            // CalificacionId
            // 
            CalificacionId.HeaderText = "CalificacionId";
            CalificacionId.Name = "CalificacionId";
            CalificacionId.Visible = false;
            // 
            // IdEstudiante
            // 
            IdEstudiante.HeaderText = "Id Estudiante";
            IdEstudiante.MinimumWidth = 6;
            IdEstudiante.Name = "IdEstudiante";
            IdEstudiante.Width = 125;
            // 
            // NombreEstudiante
            // 
            NombreEstudiante.HeaderText = "Nombre";
            NombreEstudiante.MinimumWidth = 6;
            NombreEstudiante.Name = "NombreEstudiante";
            NombreEstudiante.Width = 125;
            // 
            // ApellidoEstudiante
            // 
            ApellidoEstudiante.HeaderText = "Apellido";
            ApellidoEstudiante.MinimumWidth = 6;
            ApellidoEstudiante.Name = "ApellidoEstudiante";
            ApellidoEstudiante.Width = 125;
            // 
            // PrimerPeriodo
            // 
            PrimerPeriodo.HeaderText = "1er Periodo";
            PrimerPeriodo.MinimumWidth = 6;
            PrimerPeriodo.Name = "PrimerPeriodo";
            PrimerPeriodo.Width = 125;
            // 
            // SegundoPeriodo
            // 
            SegundoPeriodo.HeaderText = "2do Periodo";
            SegundoPeriodo.MinimumWidth = 6;
            SegundoPeriodo.Name = "SegundoPeriodo";
            SegundoPeriodo.Width = 125;
            // 
            // TercerPeriodo
            // 
            TercerPeriodo.HeaderText = "3er Periodo";
            TercerPeriodo.MinimumWidth = 6;
            TercerPeriodo.Name = "TercerPeriodo";
            TercerPeriodo.Width = 125;
            // 
            // CuartoPeriodo
            // 
            CuartoPeriodo.HeaderText = "4to Periodo";
            CuartoPeriodo.MinimumWidth = 6;
            CuartoPeriodo.Name = "CuartoPeriodo";
            CuartoPeriodo.Width = 125;
            // 
            // PromedioPeriodos
            // 
            PromedioPeriodos.HeaderText = "Promedio";
            PromedioPeriodos.MinimumWidth = 6;
            PromedioPeriodos.Name = "PromedioPeriodos";
            PromedioPeriodos.Width = 125;
            // 
            // ExamenFinal
            // 
            ExamenFinal.HeaderText = "Examen Final";
            ExamenFinal.MinimumWidth = 6;
            ExamenFinal.Name = "ExamenFinal";
            ExamenFinal.Width = 125;
            // 
            // PuntuacionFinal
            // 
            PuntuacionFinal.HeaderText = "Puntuacion Final";
            PuntuacionFinal.MinimumWidth = 6;
            PuntuacionFinal.Name = "PuntuacionFinal";
            PuntuacionFinal.Width = 125;
            // 
            // AcumuladoCompletivo
            // 
            AcumuladoCompletivo.HeaderText = "Acumulado Completivo";
            AcumuladoCompletivo.MinimumWidth = 6;
            AcumuladoCompletivo.Name = "AcumuladoCompletivo";
            AcumuladoCompletivo.Width = 125;
            // 
            // ExamenCompletivo
            // 
            ExamenCompletivo.HeaderText = "Examen Completivo";
            ExamenCompletivo.MinimumWidth = 6;
            ExamenCompletivo.Name = "ExamenCompletivo";
            ExamenCompletivo.Width = 125;
            // 
            // FinalCompletivo
            // 
            FinalCompletivo.HeaderText = "Final Completivo";
            FinalCompletivo.MinimumWidth = 6;
            FinalCompletivo.Name = "FinalCompletivo";
            FinalCompletivo.Width = 125;
            // 
            // AcumuladoExtraordinario
            // 
            AcumuladoExtraordinario.HeaderText = "Acumulado Extraordinario";
            AcumuladoExtraordinario.MinimumWidth = 6;
            AcumuladoExtraordinario.Name = "AcumuladoExtraordinario";
            AcumuladoExtraordinario.Width = 125;
            // 
            // ExamenExtraordinario
            // 
            ExamenExtraordinario.HeaderText = "Examen Extraordinario";
            ExamenExtraordinario.MinimumWidth = 6;
            ExamenExtraordinario.Name = "ExamenExtraordinario";
            ExamenExtraordinario.Width = 125;
            // 
            // FinalExtraordinario
            // 
            FinalExtraordinario.HeaderText = "Final Extraordinario";
            FinalExtraordinario.MinimumWidth = 6;
            FinalExtraordinario.Name = "FinalExtraordinario";
            FinalExtraordinario.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 125;
            // 
            // AsignarcaliFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(1104, 618);
            Controls.Add(panel1);
            Name = "AsignarcaliFrm";
            Text = "Calificaciones";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TextBox txtCuartoP;
        private System.Windows.Forms.TextBox txtSegundoP;
        private System.Windows.Forms.TextBox txtTercerP;
        private System.Windows.Forms.TextBox txtPrimerP;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAcumuladoC;
        private System.Windows.Forms.TextBox txtAcumuladoE;
        private System.Windows.Forms.TextBox txtExamenC;
        private System.Windows.Forms.TextBox txtExamenE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPuntuacionFF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtFinalC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPuntuacionF;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtExamenF;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.TextBox txtCalificacionId;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalificacionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TercerPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuartoPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromedioPeriodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamenFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntuacionFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcumuladoCompletivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamenCompletivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalCompletivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcumuladoExtraordinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamenExtraordinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalExtraordinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}