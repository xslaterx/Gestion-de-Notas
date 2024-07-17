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
            MenuAula = new FontAwesome.Sharp.IconMenuItem();
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
            MenuTitulo.Size = new System.Drawing.Size(998, 25);
            MenuTitulo.TabIndex = 4;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.BackColor = System.Drawing.Color.DarkSlateBlue;
            lblusuario.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblusuario.ForeColor = System.Drawing.SystemColors.Control;
            lblusuario.Location = new System.Drawing.Point(912, 3);
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
            nombreuser.Location = new System.Drawing.Point(853, 3);
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
            menuadmin.Size = new System.Drawing.Size(999, 66);
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
            AsigAcademicas.Click += AsigAcademicas_Click;
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
            contenedor.Size = new System.Drawing.Size(999, 360);
            contenedor.TabIndex = 6;
            // 
            // AdministrativoForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1000, 450);
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
    }
}