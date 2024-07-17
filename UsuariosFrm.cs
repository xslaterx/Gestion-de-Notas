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
using GestionNotas.Utlidades;

namespace GestionNotas
{
    public partial class UsuariosFrm : Form
    {
        public UsuariosFrm()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

            //METODO PARA LOS COMBOBOX
            cboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;


            List<Rol> listaRol = new CN_Rol().Listar();
            foreach (Rol item in listaRol) { cboRol.Items.Add(new OpcionCombo() { Valor = item.RolId, Texto = item.Descripcion }); }
            cboRol.DisplayMember = "Texto";
            cboRol.ValueMember = "Valor";
            cboRol.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cboBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cboBuscar.DisplayMember = "Texto";
            cboBuscar.ValueMember = "Valor";
            cboBuscar.SelectedIndex = 0;




            //MOSTRAR TODOS LOS USUARIOS
            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {

                dgvData.Rows.Add(new object[]{"",
                    item.UsuarioId,
                    item.Username,
                    item.Password,
                    item.FechaRegistro,
                    item.Descripcion,
                    item.RolId,                 
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "Inactivo"



                });


            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Add(new object[]
            { "", txtId.Text, txtNombre.Text, txtContrasena.Text, txtConfirmContra.Text,
               ((OpcionCombo)cboRol.SelectedItem).Texto.ToString(),
               ((OpcionCombo)cboRol.SelectedItem).Valor.ToString(),
               ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString(),
               ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString(),
            });

            Limpiar();
        }

        //METODO PARA LIMPIAR LAS CAJAS DE TEXTO
        private void Limpiar()
        {
            txtId.Text = "0";
            txtNombre.Text = "";
            txtContrasena.Text = "";
            txtConfirmContra.Text = "";
            cboRol.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
