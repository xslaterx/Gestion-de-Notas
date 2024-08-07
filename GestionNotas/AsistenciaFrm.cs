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
            foreach (Curso item in listacurso)
            {
                cboCurso.Items.Add(new OpcionCombo() { Valor = item.CursoId, Texto = item.Nombre });
            }

            cboCurso.DisplayMember = "Texto";
            cboCurso.ValueMember = "Valor";
            cboCurso.SelectedIndex = 0;

            List<Asignatura> listaasignatura = new CN_Asignatura().Listar();
            foreach (Asignatura item in listaasignatura)
            {
                cboAsignatura.Items.Add(new OpcionCombo()
                    { Valor = item.AsignaturaId, Texto = item.Nombre_asignatura });
            }

            cboAsignatura.DisplayMember = "Texto";
            cboAsignatura.ValueMember = "Valor";
            cboAsignatura.SelectedIndex = 0;


            //MOSTRAR TODOS LOS USUARIOS
            List<Asistencia> listaAsistencia = new CN_Asistencia().Listar();

            foreach (Asistencia item in listaAsistencia)
            {
                dgvData.Rows.Add(new object[]
                {
                    "",
                    item.AsistenciaId,
                    // item.Codigo,
                    // item.Nombre,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Presente" : "Ausente",
                });
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            CN_Estudiante estudianteDb = new();
            var estudiante = estudianteDb.Listar()
                .FirstOrDefault(w => w.Codigo == txtCodigo.Text && w.Nombre == txtNombre.Text);
            int estudianteId = 0;
            if (estudiante is not null)
            {
                estudianteId = estudiante.EstudianteId;
            }

            Asistencia objasistencia = new Asistencia()
            {
                AsistenciaId = Convert.ToInt32(txtAsistenciaID.Text),
                EstudianteId = estudianteId,
                CursoId = Convert.ToInt32(((OpcionCombo)cboCurso.SelectedItem).Valor),
                AsignaturaId = Convert.ToInt32(((OpcionCombo)cboCurso.SelectedItem).Valor),
                Estudiante = estudiante ?? new(),
                Curso = new Curso() { CursoId = Convert.ToInt32(((OpcionCombo)cboCurso.SelectedItem).Valor) },
                Asignatura = new Asignatura()
                    { AsignaturaId = Convert.ToInt32(((OpcionCombo)cboAsignatura.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false
            };


            if (objasistencia.AsistenciaId == 0)
            {
                int idasistenciagenerado = new CN_Asistencia().Registrar(objasistencia, out Mensaje);

                if (idasistenciagenerado != 0)
                {
                    dgvData.Rows.Add(new object[]
                    {
                        "", idasistenciagenerado, txtCodigo.Text, txtNombre.Text,
                        // txtContrasena.Text,
                        // ((OpcionCombo)cboRol.SelectedItem).Texto.ToString(),
                        // ((OpcionCombo)cboRol.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString(),
                    });

                    // Limpiar();
                }


                else
                {
                    MessageBox.Show(Mensaje);
                }

                // Limpiar();
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
    }
}