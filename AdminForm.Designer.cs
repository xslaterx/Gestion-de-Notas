namespace GestionNotas
{
    partial class AdminForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            nombreuser = new System.Windows.Forms.Label();
            menuadmin = new System.Windows.Forms.MenuStrip();
            MenuUsuario = new FontAwesome.Sharp.IconMenuItem();
            MenuDocente = new FontAwesome.Sharp.IconMenuItem();
            MenuEstudiante = new FontAwesome.Sharp.IconMenuItem();
            MenuAula = new FontAwesome.Sharp.IconMenuItem();
            MenuAsignatura = new FontAwesome.Sharp.IconMenuItem();
            MenuMantenimiento = new FontAwesome.Sharp.IconMenuItem();
            MenuReporte = new FontAwesome.Sharp.IconMenuItem();
            MenuAsistencia = new FontAwesome.Sharp.IconMenuItem();
            contenedor = new System.Windows.Forms.Panel();
            lblusuario = new System.Windows.Forms.Label();
            Titulotxt = new System.Windows.Forms.Label();
            MenuTitulo = new System.Windows.Forms.Panel();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            menuadmin.SuspendLayout();
            MenuTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(197, 116);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 15);
            label1.TabIndex = 2;
            // 
            // nombreuser
            // 
            nombreuser.AutoSize = true;
            nombreuser.BackColor = System.Drawing.Color.DarkSlateBlue;
            nombreuser.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nombreuser.ForeColor = System.Drawing.SystemColors.Control;
            nombreuser.Location = new System.Drawing.Point(876, 4);
            nombreuser.Name = "nombreuser";
            nombreuser.Size = new System.Drawing.Size(68, 18);
            nombreuser.TabIndex = 1;
            nombreuser.Text = "Usuario: ";
            // 
            // menuadmin
            // 
            menuadmin.AutoSize = false;
            menuadmin.BackColor = System.Drawing.Color.Gainsboro;
            menuadmin.Dock = System.Windows.Forms.DockStyle.None;
            menuadmin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            menuadmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { MenuUsuario, MenuDocente, MenuEstudiante, MenuAsistencia, MenuAula, MenuAsignatura, MenuMantenimiento, MenuReporte, iconMenuItem1 });
            menuadmin.Location = new System.Drawing.Point(0, 28);
            menuadmin.Name = "menuadmin";
            menuadmin.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            menuadmin.Size = new System.Drawing.Size(1141, 66);
            menuadmin.TabIndex = 4;
            menuadmin.Text = "menuStrip1";
            // 
            // MenuUsuario
            // 
            MenuUsuario.AutoSize = false;
            MenuUsuario.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MenuUsuario.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            MenuUsuario.IconColor = System.Drawing.Color.Black;
            MenuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuUsuario.IconSize = 26;
            MenuUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            MenuUsuario.Name = "MenuUsuario";
            MenuUsuario.Size = new System.Drawing.Size(122, 62);
            MenuUsuario.Text = "Usuarios";
            MenuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            MenuUsuario.Click += MenuUsuario_Click;
            // 
            // MenuDocente
            // 
            MenuDocente.AutoSize = false;
            MenuDocente.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MenuDocente.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            MenuDocente.IconColor = System.Drawing.Color.Black;
            MenuDocente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuDocente.IconSize = 26;
            MenuDocente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            MenuDocente.Name = "MenuDocente";
            MenuDocente.Size = new System.Drawing.Size(122, 62);
            MenuDocente.Text = "Docentes";
            MenuDocente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            MenuDocente.Click += MenuDocente_Click;
            // 
            // MenuEstudiante
            // 
            MenuEstudiante.AutoSize = false;
            MenuEstudiante.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MenuEstudiante.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            MenuEstudiante.IconColor = System.Drawing.Color.Black;
            MenuEstudiante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuEstudiante.IconSize = 26;
            MenuEstudiante.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            MenuEstudiante.Name = "MenuEstudiante";
            MenuEstudiante.Size = new System.Drawing.Size(122, 62);
            MenuEstudiante.Text = "Estudiantes";
            MenuEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            MenuEstudiante.Click += MenuEstudiante_Click;
            // 
            // MenuAula
            // 
            MenuAula.AutoSize = false;
            MenuAula.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MenuAula.IconChar = FontAwesome.Sharp.IconChar.School;
            MenuAula.IconColor = System.Drawing.Color.Black;
            MenuAula.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuAula.IconSize = 26;
            MenuAula.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            MenuAula.Name = "MenuAula";
            MenuAula.Size = new System.Drawing.Size(122, 62);
            MenuAula.Text = "Aulas";
            MenuAula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            MenuAula.Click += MenuAula_Click;
            // 
            // MenuAsignatura
            // 
            MenuAsignatura.AutoSize = false;
            MenuAsignatura.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MenuAsignatura.IconChar = FontAwesome.Sharp.IconChar.Suitcase;
            MenuAsignatura.IconColor = System.Drawing.Color.Black;
            MenuAsignatura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuAsignatura.IconSize = 26;
            MenuAsignatura.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            MenuAsignatura.Name = "MenuAsignatura";
            MenuAsignatura.Size = new System.Drawing.Size(122, 62);
            MenuAsignatura.Text = "Asignaturas";
            MenuAsignatura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            MenuAsignatura.Click += MenuAsignatura_Click;
            // 
            // MenuMantenimiento
            // 
            MenuMantenimiento.AutoSize = false;
            MenuMantenimiento.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MenuMantenimiento.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            MenuMantenimiento.IconColor = System.Drawing.Color.Black;
            MenuMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuMantenimiento.IconSize = 26;
            MenuMantenimiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            MenuMantenimiento.Name = "MenuMantenimiento";
            MenuMantenimiento.Size = new System.Drawing.Size(122, 62);
            MenuMantenimiento.Text = "Mantenimiento";
            MenuMantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            MenuMantenimiento.Click += MenuMantenimiento_Click;
            // 
            // MenuReporte
            // 
            MenuReporte.AutoSize = false;
            MenuReporte.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MenuReporte.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            MenuReporte.IconColor = System.Drawing.Color.Black;
            MenuReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuReporte.IconSize = 26;
            MenuReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            MenuReporte.Name = "MenuReporte";
            MenuReporte.Size = new System.Drawing.Size(122, 62);
            MenuReporte.Text = "Reportes";
            MenuReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            MenuReporte.Click += MenuReporte_Click;
            // 
            // MenuAsistencia
            // 
            MenuAsistencia.AutoSize = false;
            MenuAsistencia.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MenuAsistencia.IconChar = FontAwesome.Sharp.IconChar.Award;
            MenuAsistencia.IconColor = System.Drawing.Color.Black;
            MenuAsistencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuAsistencia.IconSize = 26;
            MenuAsistencia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            MenuAsistencia.Name = "MenuAsistencia";
            MenuAsistencia.Size = new System.Drawing.Size(122, 62);
            MenuAsistencia.Text = "Asistencia";
            MenuAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            MenuAsistencia.Click += MenuAcerca_Click;
            // 
            // contenedor
            // 
            contenedor.Location = new System.Drawing.Point(0, 97);
            contenedor.Name = "contenedor";
            contenedor.Size = new System.Drawing.Size(1141, 608);
            contenedor.TabIndex = 5;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.BackColor = System.Drawing.Color.DarkSlateBlue;
            lblusuario.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblusuario.ForeColor = System.Drawing.SystemColors.Control;
            lblusuario.Location = new System.Drawing.Point(942, 4);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new System.Drawing.Size(75, 18);
            lblusuario.TabIndex = 2;
            lblusuario.Text = "lblusuario";
            lblusuario.Click += lblusuario_Click;
            // 
            // Titulotxt
            // 
            Titulotxt.AutoSize = true;
            Titulotxt.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Titulotxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            Titulotxt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            Titulotxt.Location = new System.Drawing.Point(3, 3);
            Titulotxt.Name = "Titulotxt";
            Titulotxt.Size = new System.Drawing.Size(62, 19);
            Titulotxt.TabIndex = 0;
            Titulotxt.Text = "SILOCA";
            Titulotxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Titulotxt.Click += Titulotxt_Click;
            // 
            // MenuTitulo
            // 
            MenuTitulo.BackColor = System.Drawing.Color.DarkSlateBlue;
            MenuTitulo.Controls.Add(lblusuario);
            MenuTitulo.Controls.Add(nombreuser);
            MenuTitulo.Controls.Add(Titulotxt);
            MenuTitulo.Location = new System.Drawing.Point(0, 0);
            MenuTitulo.Name = "MenuTitulo";
            MenuTitulo.Size = new System.Drawing.Size(1141, 25);
            MenuTitulo.TabIndex = 3;
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.AutoSize = false;
            iconMenuItem1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.Reply;
            iconMenuItem1.IconColor = System.Drawing.Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.IconSize = 26;
            iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new System.Drawing.Size(122, 62);
            iconMenuItem1.Text = "Acerca de";
            iconMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1143, 705);
            Controls.Add(contenedor);
            Controls.Add(MenuTitulo);
            Controls.Add(menuadmin);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AdminForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Sistema de Calificaciones";
            Load += Form1_Load;
            menuadmin.ResumeLayout(false);
            menuadmin.PerformLayout();
            MenuTitulo.ResumeLayout(false);
            MenuTitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuadmin;
        private FontAwesome.Sharp.IconMenuItem MenuEstudiante;
        private FontAwesome.Sharp.IconMenuItem MenuUsuario;
        private FontAwesome.Sharp.IconMenuItem MenuAula;
        private FontAwesome.Sharp.IconMenuItem MenuDocente;
        private FontAwesome.Sharp.IconMenuItem MenuMantenimiento;
        private FontAwesome.Sharp.IconMenuItem MenuAsignatura;
        private FontAwesome.Sharp.IconMenuItem MenuReporte;
        private FontAwesome.Sharp.IconMenuItem MenuAsistencia;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label nombreuser;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label Titulotxt;
        private System.Windows.Forms.Panel MenuTitulo;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
    }
}

