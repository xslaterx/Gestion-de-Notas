using GestionNotas.Utlidades;
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
    public partial class DocentesFrm : Form
    {
        public DocentesFrm()
        {
            InitializeComponent();
        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSexo_Click(object sender, EventArgs e)
        {

        }

        private void dgvDataDocente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDataDocente.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtMaestroId.Text = dgvDataDocente.Rows[indice].Cells["MaestroId"].Value.ToString();
                    txtCodigo.Text = dgvDataDocente.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtNombre.Text = dgvDataDocente.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtApellido.Text = dgvDataDocente.Rows[indice].Cells["Apellido"].Value.ToString();
                    txtTelefono.Text = dgvDataDocente.Rows[indice].Cells["Telefono"].Value.ToString();
                    txtCorreo.Text = dgvDataDocente.Rows[indice].Cells["Correo"].Value.ToString();





                    //AQUI SE CAMBIA LA INFORMACION DEL COMBOBOX ESTADO
                    foreach (OpcionCombo oc in cboEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvDataDocente.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboEstado.Items.IndexOf(oc);
                            cboEstado.SelectedIndex = indice_combo;
                            break;

                        }
                    }

                }
            }
        }

        private void DocentesFrm_Load(object sender, EventArgs e)
        {

        }

        private void lblListaDocentes_Click(object sender, EventArgs e)
        {

        }
    }
}
