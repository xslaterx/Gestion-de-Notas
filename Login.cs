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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (var context = new AppDbContext())
            {
                var user = context.Usuarios.Include(u => u.Rol)
                            .SingleOrDefault(u => u.Username == username);

                if (user != null && VerifyPassword(password, user.PasswordHash))
                {
                    MessageBox.Show("Login Successful!");

                    // Open MainForm or other forms based on the user's role
                    if (user.Rol.Nombre == "Administrador")
                    {
                        var adminForm = new AdminForm();
                        adminForm.Show();
                    }
                    else if (user.Rol.Nombre == "Maestro")
                    {
                        var maestroForm = new MaestroForm();
                        maestroForm.Show();
                    }
                    else if (user.Rol.Nombre == "Administrativo")
                    {
                        var adminstrativoForm = new AdministrativoForm();
                        adminstrativoForm.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
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
    }
}
    
    

