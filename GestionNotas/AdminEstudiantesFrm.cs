using BDGestion;
using CapaDatos;
using CapaEscolar;
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
    public partial class AdminEstudiantesFrm : Form
    {
        public AdminEstudiantesFrm()
        {
            InitializeComponent();
        }

        private void AdminEstudiantesFrm_Load(object sender, EventArgs e)
        {

            //METODO PARA LOS COMBOBOX
            cboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;



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


            List<Curso> listacurso = new CN_Cursos().Listar();
            foreach (Curso item in listacurso) { cbocursos.Items.Add(new OpcionCombo() { Valor = item.CursoId, Texto = item.Nombre }); }
            cbocursos.DisplayMember = "Texto";
            cbocursos.ValueMember = "Valor";




            //MOSTRAR TODOS LOS ESTUDIANTES
            List<Estudiante> listaEstudiante = new CN_Estudiante().Listar();

            foreach (Estudiante item in listaEstudiante)
            {

                dgvData.Rows.Add(new object[]{"",
                    item.EstudianteId,
                    item.Codigo,
                    item.Nombre,
                    item.Apellido,
                    item.Telefono,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "Inactivo",
                    item.FechaRegistro,
                    item.Enfermedad,
                    item.Medicamento,
                    item.TutorNombre,
                    item.Tutor,
                    item.NumeroEmergencia,
                    item.Sexo

                });


            }

        }
        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtEstudianteID.Text = dgvData.Rows[indice].Cells["EstudianteID"].Value.ToString();
                    txtCodigo.Text = dgvData.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtNombre.Text = dgvData.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtApellido.Text = dgvData.Rows[indice].Cells["Apellido"].Value.ToString();
                    txtTelefono.Text = dgvData.Rows[indice].Cells["Telefono"].Value.ToString();
                    txtFechaRegistro.Text = dgvData.Rows[indice].Cells["FechaRegistro"].Value.ToString();
                    txtEnfermedad.Text = dgvData.Rows[indice].Cells["Enfermedad"].Value.ToString();
                    txtMedicamento.Text = dgvData.Rows[indice].Cells["Medicamento"].Value.ToString();
                    txtTutorNombre.Text = dgvData.Rows[indice].Cells["TutorNombre"].Value.ToString();
                    txtTutor.Text = dgvData.Rows[indice].Cells["Tutor"].Value.ToString();
                    txtNumeroEmergencia.Text = dgvData.Rows[indice].Cells["NumeroEmergencia"].Value.ToString();
                    txtSexo.Text = dgvData.Rows[indice].Cells["Sexo"].Value.ToString();



                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            Estudiante objestudiante = new Estudiante()
            {
                EstudianteId = Convert.ToInt32(txtEstudianteID.Text),
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false,
                FechaRegistro = txtFechaRegistro.Text,
                Enfermedad = txtEnfermedad.Text,
                Medicamento = txtMedicamento.Text,
                TutorNombre = txtTutorNombre.Text,
                Tutor = txtTutor.Text,
                NumeroEmergencia = txtNumeroEmergencia.Text,
                Sexo = txtSexo.Text,
                Calificaciones = new List<Calificacion> { new Calificacion { } }

            };

            if (objestudiante.EstudianteId == 0)
            {

                int idestudiantegenerado = new CN_Estudiante().Registrar(objestudiante, out Mensaje);

                if (idestudiantegenerado != 0)
                {
                    dgvData.Rows.Add(new object[]
                       { "", idestudiantegenerado,txtCodigo.Text, txtNombre.Text, txtApellido.Text,txtTelefono.Text,
                       ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString(),
                       ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString(),
                       txtFechaRegistro.Text,txtEnfermedad.Text,txtMedicamento.Text,txtTutorNombre.Text,txtTutor.Text,txtNumeroEmergencia.Text,txtSexo.Text,

                    });

                    Limpiar();
                }


                else { MessageBox.Show(Mensaje); }

                Limpiar();
            }
            else
            {
                bool resultado = new CN_Estudiante().Editar(objestudiante, out Mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["EstudianteId"].Value = txtEstudianteID.Text;
                    row.Cells["Codigo"].Value = txtCodigo.Text;
                    row.Cells["Nombre"].Value = txtNombre.Text;
                    row.Cells["Apellido"].Value = txtApellido.Text;
                    row.Cells["Telefono"].Value = txtTelefono.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString();
                    row.Cells["FechaRegistro"].Value = txtFechaRegistro.Text;
                    row.Cells["Enfermedad"].Value = txtEnfermedad.Text;
                    row.Cells["Medicamento"].Value = txtMedicamento.Text;
                    row.Cells["TutorNombre"].Value = txtTutorNombre.Text;
                    row.Cells["Tutor"].Value = txtTutor.Text;
                    row.Cells["NumeroEmergencia"].Value = txtNumeroEmergencia.Text;
                    row.Cells["Sexo"].Value = txtSexo.Text;

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
            txtEstudianteID.Text = "0";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtFechaRegistro.Text = "";
            txtEnfermedad.Text = "";
            txtMedicamento.Text = "";
            txtTutorNombre.Text = "";
            txtTutor.Text = "";
            txtNumeroEmergencia.Text = "";
            txtSexo.Text = "";

            txtCodigo.Select();
        }

        private void cbocursos_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtEstudianteID.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el estudiante", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Estudiante objestudiante = new Estudiante()
                    {
                        EstudianteId = Convert.ToInt32(txtEstudianteID.Text)
                    };

                    bool respuesta = new CD_Estudiante().Eliminar(objestudiante, out mensaje);

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
    }
}
