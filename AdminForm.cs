using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDGestion;
using FontAwesome.Sharp;

namespace GestionNotas
{
    public partial class AdminForm : Form
    {

        private static Usuario usuarioActual1;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public AdminForm(Usuario objusuario)
        {
            usuarioActual1 = objusuario;
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblusuario.Text = usuarioActual1.Username;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Titulotxt_Click(object sender, EventArgs e)
        {

        }



        private void AbrirFormulario(IconMenuItem menu, Form Formulario)
        {

            if (MenuActivo != null) { MenuActivo.BackColor = Color.White; }

            menu.BackColor = Color.DarkSlateBlue;
            MenuActivo = menu;


            if (FormularioActivo != null) { FormularioActivo.Close(); }
            FormularioActivo = Formulario;
            Formulario.TopLevel = false;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            Formulario.BackColor = Color.FloralWhite;

            contenedor.Controls.Add(Formulario);
            Formulario.Show();

        }

        private void MenuUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new UsuariosFrm());
        }

        private void AsigTecnicas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuAsignatura, new AsignarcaliFrm());
        }
        

        private void MenuDocente_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new DocentesFrm());
        }

        private void MenuEstudiante_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new AdminEstudiantesFrm());
        }

        private void MenuAula_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new CursoFrm());
        }

        private void MenuMantenimiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new MantenimientoFrm());
        }

        private void MenuReporte_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new ReportesFrm());
        }

        private void MenuAcerca_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new AsistenciaFrm());
        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        private void menuadmin_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuAsignatura_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new AsignarcaliFrm());
        }
    }
}
