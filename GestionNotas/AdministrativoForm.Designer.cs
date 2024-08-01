namespace GestionNotas
{
    partial class AdministrativoForm
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
            MenuTitulo = new System.Windows.Forms.Panel();
            lblusuario = new System.Windows.Forms.Label();
            nombreuser = new System.Windows.Forms.Label();
            Titulotxt = new System.Windows.Forms.Label();
            menuadmin = new System.Windows.Forms.MenuStrip();
            MenuDocente = new FontAwesome.Sharp.IconMenuItem();
            MenuEstudiante = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            MenuAula = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            MenuAsignatura = new FontAwesome.Sharp.IconMenuItem();
            AsigTecnicas = new FontAwesome.Sharp.IconMenuItem();
            AsigAcademicas = new FontAwesome.Sharp.IconMenuItem();
            MenuReporte = new FontAwesome.Sharp.IconMenuItem();
            MenuAcerca = new FontAwesome.Sharp.IconMenuItem();
            contenedor = new System.Windows.Forms.Panel();
            MenuTitulo.SuspendLayout();
            menuadmin.SuspendLayout();
            SuspendLayout();
            // 
            // MenuTitulo
            // 
            MenuTitulo.BackColor = System.Drawing.Color.DarkSlateBlue;
            MenuTitulo.Controls.Add(lblusuario);
            MenuTitulo.Controls.Add(nombreuser);
            MenuTitulo.Controls.Add(Titulotxt);
            MenuTitulo.Location = new System.Drawing.Point(1, 1);
            MenuTitulo.Name = "MenuTitulo";
            MenuTitulo.Size = new System.Drawing.Size(1085, 25);
            MenuTitulo.TabIndex = 4;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.BackColor = System.Drawing.Color.DarkSlateBlue;
            lblusuario.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblusuario.ForeColor = System.Drawing.SystemColors.Control;
            lblusuario.Location = new System.Drawing.Point(1003, 3);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new System.Drawing.Size(75, 18);
            lblusuario.TabIndex = 2;
            lblusuario.Text = "lblusuario";
            // 
            // nombreuser
            // 
            nombreuser.AutoSize = true;
            nombreuser.BackColor = System.Drawing.Color.DarkSlateBlue;
            nombreuser.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nombreuser.ForeColor = System.Drawing.SystemColors.Control;
            nombreuser.Location = new System.Drawing.Point(944, 3);
            nombreuser.Name = "nombreuser";
            nombreuser.Size = new System.Drawing.Size(68, 18);
            nombreuser.TabIndex = 1;
            nombreuser.Text = "Usuario: ";
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
            // 
            // menuadmin
            // 
            menuadmin.AutoSize = false;
            menuadmin.BackColor = System.Drawing.Color.Gainsboro;
            menuadmin.Dock = System.Windows.Forms.DockStyle.None;
            menuadmin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            menuadmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { MenuDocente, MenuEstudiante, MenuAula, MenuAsignatura, MenuReporte, MenuAcerca });
            menuadmin.Location = new System.Drawing.Point(1, 29);
            menuadmin.Name = "menuadmin";
            menuadmin.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            menuadmin.Size = new System.Drawing.Size(1085, 66);
            menuadmin.TabIndex = 5;
            menuadmin.Text = "menuStrip1";
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
            MenuEstudiante.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { iconMenuItem1, iconMenuItem2 });
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
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = System.Drawing.Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new System.Drawing.Size(238, 24);
            iconMenuItem1.Text = "Administrar Estudiantes";
            iconMenuItem1.Click += iconMenuItem1_Click;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem2.IconColor = System.Drawing.Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new System.Drawing.Size(238, 24);
            iconMenuItem2.Text = "Asignar Calificaciones";
            iconMenuItem2.Click += iconMenuItem2_Click;
            // 
            // MenuAula
            // 
            MenuAula.AutoSize = false;
            MenuAula.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { iconMenuItem3, iconMenuItem4 });
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
            // iconMenuItem3
            // 
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem3.IconColor = System.Drawing.Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new System.Drawing.Size(198, 24);
            iconMenuItem3.Text = "Administrar Aulas";
            // 
            // iconMenuItem4
            // 
            iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem4.IconColor = System.Drawing.Color.Black;
            iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem4.Name = "iconMenuItem4";
            iconMenuItem4.Size = new System.Drawing.Size(198, 24);
            iconMenuItem4.Text = "iconMenuItem4";
            // 
            // MenuAsignatura
            // 
            MenuAsignatura.AutoSize = false;
            MenuAsignatura.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { AsigTecnicas, AsigAcademicas });
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
            // 
            // AsigTecnicas
            // 
            AsigTecnicas.IconChar = FontAwesome.Sharp.IconChar.None;
            AsigTecnicas.IconColor = System.Drawing.Color.Black;
            AsigTecnicas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AsigTecnicas.Name = "AsigTecnicas";
            AsigTecnicas.Size = new System.Drawing.Size(156, 24);
            AsigTecnicas.Text = "Tecnicas";
            AsigTecnicas.Click += AsigTecnicas_Click;
            // 
            // AsigAcademicas
            // 
            AsigAcademicas.IconChar = FontAwesome.Sharp.IconChar.None;
            AsigAcademicas.IconColor = System.Drawing.Color.Black;
            AsigAcademicas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AsigAcademicas.Name = "AsigAcademicas";
            AsigAcademicas.Size = new System.Drawing.Size(156, 24);
            AsigAcademicas.Text = "Academicas";
           
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
            // MenuAcerca
            // 
            MenuAcerca.AutoSize = false;
            MenuAcerca.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MenuAcerca.IconChar = FontAwesome.Sharp.IconChar.Reply;
            MenuAcerca.IconColor = System.Drawing.Color.Black;
            MenuAcerca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuAcerca.IconSize = 26;
            MenuAcerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            MenuAcerca.Name = "MenuAcerca";
            MenuAcerca.Size = new System.Drawing.Size(122, 62);
            MenuAcerca.Text = "Acerca de";
            MenuAcerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            MenuAcerca.Click += MenuAcerca_Click;
            // 
            // contenedor
            // 
            contenedor.Location = new System.Drawing.Point(1, 89);
            contenedor.Name = "contenedor";
            contenedor.Size = new System.Drawing.Size(1085, 660);
            contenedor.TabIndex = 6;
            // 
            // AdministrativoForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1088, 749);
            Controls.Add(contenedor);
            Controls.Add(menuadmin);
            Controls.Add(MenuTitulo);
            Name = "AdministrativoForm";
            Text = "AdministrativoForm";
            Load += AdministrativoForm_Load;
            MenuTitulo.ResumeLayout(false);
            MenuTitulo.PerformLayout();
            menuadmin.ResumeLayout(false);
            menuadmin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel MenuTitulo;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label nombreuser;
        private System.Windows.Forms.Label Titulotxt;
        private System.Windows.Forms.MenuStrip menuadmin;
        private FontAwesome.Sharp.IconMenuItem MenuDocente;
        private FontAwesome.Sharp.IconMenuItem MenuEstudiante;
        private FontAwesome.Sharp.IconMenuItem MenuAula;
        private FontAwesome.Sharp.IconMenuItem MenuAsignatura;
        private FontAwesome.Sharp.IconMenuItem AsigTecnicas;
        private FontAwesome.Sharp.IconMenuItem AsigAcademicas;
        private FontAwesome.Sharp.IconMenuItem MenuReporte;
        private FontAwesome.Sharp.IconMenuItem MenuAcerca;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
    }
}