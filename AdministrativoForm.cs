using BDGestion;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionNotas
{
    public partial class AdministrativoForm : Form
    {

        private static Usuario usuarioActual1;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;


        public AdministrativoForm(Usuario objusuario)
        {
            usuarioActual1 = objusuario;
            InitializeComponent();
        }

        private void MenuDocente_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new DocentesFrm());
        }

        private void AdministrativoForm_Load(object sender, EventArgs e)
        {
            lblusuario.Text = usuarioActual1.Username;
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

        private void MenuEstudiante_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new EstudiantesFrm());
        }

        private void MenuAula_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new AulasFrm());
        }

        private void AsigTecnicas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuAsignatura, new AsignaTecnicaFrm());
        }

        private void AsigAcademicas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuAsignatura, new AsignaAcademicaFrm());
        }

        private void MenuReporte_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new ReportesFrm());
        }

        private void MenuAcerca_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new AcercaFrm());
        }
    }
}
