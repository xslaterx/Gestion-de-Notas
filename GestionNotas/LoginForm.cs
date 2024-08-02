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
using CapaEscolar;
using Microsoft.EntityFrameworkCore;

namespace GestionNotas
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }


        private bool VerifyPassword(string enteredPassword, string storedHash)
        {
            // Implement your password verification logic here
            return enteredPassword == storedHash; // Esto es solo para fines de demostración.
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar();


            Usuario ousuario = new CN_Usuario()
                .Listar().FirstOrDefault(u => u.Username == txtUsername.Text && u.Password == txtPassword.Text);

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
    }
}