using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDGestion;
using CapaDatos;
using CapaEscolar;
//using GestionNotas.Properties;
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


            List<Rol> listaRol = new CD_Rol().Listar();
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
            List<Usuario> listaUsuario = new CD_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {

                dgvData.Rows.Add(new object[]{"",
                    item.UsuarioId,
                    item.Codigo,
                    item.Username,
                    item.Password,
                    item.Descripcion,
                    item.RolId,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "Inactivo",
                });


            }
        }
        //CONFIGURACION DEL BOTON GUARDAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            Usuario objusuario = new Usuario()
            {
                UsuarioId = Convert.ToInt32(txtUsuarioID.Text),
                Codigo = txtCodigo.Text,
                Username = txtNombre.Text,
                Password = txtContrasena.Text,
                Rol = new Rol() { RolId = Convert.ToInt32(((OpcionCombo)cboRol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objusuario.UsuarioId == 0)
            {

                int idusuariogenerado = new CD_Usuario().Registrar(objusuario, out Mensaje);

                if (idusuariogenerado != 0)
                {
                    dgvData.Rows.Add(new object[]
                       { "", idusuariogenerado,txtCodigo.Text, txtNombre.Text, txtContrasena.Text,
                       ((OpcionCombo)cboRol.SelectedItem).Texto.ToString(),
                       ((OpcionCombo)cboRol.SelectedItem).Valor.ToString(),
                       ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString(),
                       ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString(),
                    });

                    Limpiar();
                }


                else { MessageBox.Show(Mensaje); }

                Limpiar();
            }
            else
            {
                bool resultado = new CD_Usuario().Editar(objusuario, out Mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["UsuarioId"].Value = txtUsuarioID.Text;
                    row.Cells["Codigo"].Value = txtCodigo.Text;
                    row.Cells["Username"].Value = txtNombre.Text;
                    row.Cells["Password"].Value = txtContrasena.Text;
                    row.Cells["RolId"].Value = ((OpcionCombo)cboRol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)cboRol.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString();

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }
            }
        }









        //METODO PARA LIMPIAR LAS CAJAS DE TEXTO
        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtUsuarioID.Text = "0";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtContrasena.Text = "";
            txtConfirmContra.Text = "";
            cboRol.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;

            txtCodigo.Select();
        }


        //METODO PARA PASAR LA DATA HACIA LOS TEXTBOX
        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtUsuarioID.Text = dgvData.Rows[indice].Cells["UsuarioID"].Value.ToString();
                    txtCodigo.Text = dgvData.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtNombre.Text = dgvData.Rows[indice].Cells["Username"].Value.ToString();
                    txtContrasena.Text = dgvData.Rows[indice].Cells["Password"].Value.ToString();
                    txtConfirmContra.Text = dgvData.Rows[indice].Cells["Password"].Value.ToString();

                    //AQUI SE CAMBIA LA INFORMACION DEL COMBOBOX ROL
                    foreach (OpcionCombo oc in cboRol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["RolId"].Value))
                        {
                            int indice_combo = cboRol.Items.IndexOf(oc);
                            cboRol.SelectedIndex = indice_combo;
                            break;

                        }
                    }


                    //AQUI SE CAMBIA LA INFORMACION DEL COMBOBOX ESTADO
                    foreach (OpcionCombo oc in cboEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboEstado.Items.IndexOf(oc);
                            cboEstado.SelectedIndex = indice_combo;
                            break;

                        }
                    }

                }
            }




        }




        //ESTE METODO ES PARA COLOCAR LA IMAGEN DE CHECK EN EL DATAGRIDVIEW
        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
          /*  if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);


                var w = Properties.Resources.checkmark.Width;
                var h = Properties.Resources.checkmark.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.checkmark, new Rectangle(x, y, w, h));
                e.Handled = true;
            }*/
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtUsuarioID.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el usuario", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        UsuarioId = Convert.ToInt32(txtUsuarioID.Text)
                    };

                    bool respuesta = new CD_Usuario().Eliminar(objusuario, out mensaje);

                    if (respuesta)
                    {
                        dgvData.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBuscar.SelectedItem).Valor.ToString();

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
