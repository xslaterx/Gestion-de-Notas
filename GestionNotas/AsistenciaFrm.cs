using BDGestion;
using CapaDatos;
using CapaEscolar;
using DBGestion;
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
    public partial class AsistenciaFrm : Form
    {
        public AsistenciaFrm()
        {
            InitializeComponent();
        }

        private void AsistenciaFrm_Load(object sender, EventArgs e)
        {
            //METODO PARA LOS COMBOBOX
            cboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Presente" });
            cboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Ausente" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;



            List<Curso> listacurso = new CN_Cursos().Listar();
            foreach (Curso item in listacurso) { cboCurso.Items.Add(new OpcionCombo() { Valor = item.CursoId, Texto = item.Nombre }); }
            cboCurso.DisplayMember = "Texto";
            cboCurso.ValueMember = "Valor";
            cboCurso.SelectedIndex = 0;

            List<Asignatura> listaasignatura = new CN_Asignatura().Listar();
            foreach (Asignatura item in listaasignatura) { cboAsignatura.Items.Add(new OpcionCombo() { Valor = item.AsignaturaId, Texto = item.Nombre_asignatura }); }
            cboAsignatura.DisplayMember = "Texto";
            cboAsignatura.ValueMember = "Valor";
            cboAsignatura.SelectedIndex = 0;


            //MOSTRAR TODOS LOS USUARIOS
            List<Asistencia> listaAsistencia = new CD_Asistencia().Listar();

            foreach (Asistencia item in listaAsistencia)
            {

                dgvData.Rows.Add(new object[]{"",
                    item.AsistenciaId,
                    // item.Codigo,
                   //  item.Nombre,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Presente" : "Ausente",
                });


            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            Asistencia objasistencia = new Asistencia()
            {
                AsistenciaId = Convert.ToInt32(txtAsistenciaID.Text),
                Curso = new Curso() { CursoId = Convert.ToInt32(((OpcionCombo)cboCurso.SelectedItem).Valor) },
                Asignatura = new Asignatura() { AsignaturaId = Convert.ToInt32(((OpcionCombo)cboAsignatura.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false
            };

            objasistencia.Estudiante = new()
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text
            };

            if (objasistencia.AsistenciaId == 0)
            {

                int idasistenciagenerado = new CN_Asistencia().Registrar(objasistencia, out Mensaje);

                if (idasistenciagenerado != 0)
                {
                    dgvData.Rows.Add(new object[]
                       { "", idasistenciagenerado,txtCodigo.Text, txtNombre.Text, 
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
                // bool resultado = new CN_Asistencia().Editar(idasistenciagenerado, out Mensaje);
                //
                // if (resultado)
                // {
                //     DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                //     row.Cells["UsuarioId"].Value = txtUsuarioID.Text;
                //     row.Cells["Codigo"].Value = txtCodigo.Text;
                //     row.Cells["Username"].Value = txtNombre.Text;
                //     row.Cells["Password"].Value = txtContrasena.Text;
                //     row.Cells["RolId"].Value = ((OpcionCombo)cboRol.SelectedItem).Valor.ToString();
                //     row.Cells["Rol"].Value = ((OpcionCombo)cboRol.SelectedItem).Texto.ToString();
                //     row.Cells["EstadoValor"].Value = ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString();
                //     row.Cells["Estado"].Value = ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString();
                //
                //     Limpiar();
                // }
                // else
                // {
                //     MessageBox.Show(Mensaje);
                // }
            }

        }

        //METODO PARA LIMPIAR LAS CAJAS DE TEXTO
        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtAsistenciaID.Text = "0";
            txtCodigo.Text = "";
            txtNombre.Text = "";

            txtCodigo.Select();
        }


        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtAsistenciaID.Text = dgvData.Rows[indice].Cells["AsistenciaId"].Value.ToString();
                    txtCodigo.Text = dgvData.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtNombre.Text = dgvData.Rows[indice].Cells["Nombre"].Value.ToString();
                  

                    //AQUI SE CAMBIA LA INFORMACION DEL COMBOBOX ASIGNATURA
                    foreach (OpcionCombo oc in cboAsignatura.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["RolId"].Value))
                        {
                            int indice_combo = cboAsignatura.Items.IndexOf(oc);
                            cboAsignatura.SelectedIndex = indice_combo;
                            break;

                        }
                    }
                    foreach (OpcionCombo oc in cboCurso.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["RolId"].Value))
                        {
                            int indice_combo = cboCurso.Items.IndexOf(oc);
                            cboCurso.SelectedIndex = indice_combo;
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
    }
}
