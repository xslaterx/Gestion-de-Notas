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
using System.Data.Entity;
using CapaEscolar;



namespace GestionNotas
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {

            List<Usuario> TEST = new CN_Usuario().Listar();


            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Username == txtUsername.Text && u.Password == txtPassword.Text).
                FirstOrDefault();

            string Username = txtUsername.Text;
            string Password = txtPassword.Text;

            using (var context = new AppDbContext())
            {
                var user = context.Usuarios.Include(u => u.Rol)
                            .SingleOrDefault(u => u.Username == Username);

                if (user != null && VerifyPassword(Password, user.Password))
                {
                    

                    string rol = user.Rol.Descripcion.ToLower().Trim();

                    // Se abre un formulario dependiendo el tipo de rol que tiene el usuario
                    switch (rol)
                    {
                        case "administrador":
                            var adminForm = new AdminForm(ousuario);
                            adminForm.Show();
                            break;
                        case "maestro":
                            var maestroForm = new MaestroForm(ousuario);
                            maestroForm.Show();
                            break;
                        case "administrativo":
                            var adminstrativoForm = new AdministrativoForm(ousuario);
                            adminstrativoForm.Show();
                            break;
                        default:
                            this.Hide();
                            break;
                    }

                    
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectas.");
                }
            } 
        }
        


        private bool VerifyPassword(string enteredPassword, string storedHash)
        {
            // Implement your password verification logic here
            return enteredPassword == storedHash; // Esto es solo para fines de demostración.
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Cerrarimg_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void minimizarimg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimaxiimg_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
    

