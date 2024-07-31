using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaDatos;
using DBGestion;
using CapaEscolar;
using GestionNotas.Utlidades;
using BDGestion;

namespace GestionNotas
{
    public partial class CursoFrm : Form
    {
        public CursoFrm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            Curso objcurso = new Curso()
            {
                CursoId = Convert.ToInt32(txtCursoID.Text),
                Nombre = txtNombre.Text,
                Calificaciones = new List<Calificacion> { new Calificacion { } }

            };
            if (objcurso.CursoId == 0)
            {

                int idcursogenerado = new CN_Cursos().Registrar(objcurso, out Mensaje);

                if (idcursogenerado != 0)
                {
                    dgvDataCurso.Rows.Add(new object[]
                       { "", idcursogenerado, txtNombre.Text
                    });

                    Limpiar();
                }


                else { MessageBox.Show(Mensaje); }

                Limpiar();
            }
            else
            {
                bool resultado = new CN_Cursos().Editar(objcurso, out Mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvDataCurso.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["CursoId"].Value = txtCursoID.Text;
                    row.Cells["Nombre"].Value = txtNombre.Text;
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
            txtCursoID.Text = "0";
            txtNombre.Text = "";
            txtNombre.Select();
        }

        private void dgvDataCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDataCurso.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtCursoID.Text = dgvDataCurso.Rows[indice].Cells["CursoID"].Value.ToString();
                    txtNombre.Text = dgvDataCurso.Rows[indice].Cells["Nombre"].Value.ToString();

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCursoID.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el curso", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Curso objcurso = new Curso()
                    {
                        CursoId = Convert.ToInt32(txtCursoID.Text),
                        Nombre = "Nombre".ToString(),
                        Calificaciones = new List<Calificacion> { new Calificacion { } }
                    };

                    bool respuesta = new CN_Cursos().Eliminar(objcurso, out mensaje);

                    if (respuesta)
                    {
                        dgvDataCurso.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void CursoFrm_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvDataCurso.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cboBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cboBuscar.DisplayMember = "Texto";
            cboBuscar.ValueMember = "Valor";
            cboBuscar.SelectedIndex = 0;


            List<Curso> listaCurso = new CN_Cursos().Listar();

            foreach (Curso item in listaCurso)
            {

                dgvDataCurso.Rows.Add(new object[] { "", item.CursoId, item.Nombre });


            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBuscar.SelectedItem).Valor.ToString();

            if (dgvDataCurso.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDataCurso.Rows)
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
            foreach (DataGridViewRow row in dgvDataCurso.Rows)
            {
                row.Visible = true;
            }
        }
    }




}

