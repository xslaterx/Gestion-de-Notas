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

        }
    }
}
