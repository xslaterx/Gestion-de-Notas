using BDGestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBGestion;
using CapaEscolar;
using GestionNotas.Utlidades;
using CapaEscolar;
using System.Xml.Linq;
using CapaDatos;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace GestionNotas
{
    public partial class AsignarcaliFrm : Form
    {
        public Calificacion calificacion;
        public AsignarcaliFrm()
        {
            InitializeComponent();
            calificacion = new Calificacion();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                calificacion.PrimerP = int.Parse(txtPrimerP.Text);
                calificacion.SegundoP = int.Parse(txtSegundoP.Text);
                calificacion.TercerP = int.Parse(txtTercerP.Text);
                calificacion.CuartoP = int.Parse(txtCuartoP.Text);
                calificacion.ExamenF = int.Parse(txtExamenF.Text);



                double promedioPeriodos = calificacion.CalcularPromedioPeriodos();
                double puntuacionFinal = calificacion.CalcularPuntuacionFinal();

                txtPromedio.Text = promedioPeriodos.ToString("F2");
                txtPuntuacionF.Text = puntuacionFinal.ToString("F2");
                if (puntuacionFinal < 70)
                {
                    double acumuladoCompletivo = puntuacionFinal * 0.5;
                    txtAcumuladoC.Text = acumuladoCompletivo.ToString("F2");

                    // Solo calcular la puntuación final del completivo si se ha introducido la nota del examen completivo
                    if (!string.IsNullOrEmpty(txtExamenC.Text))
                    {
                        calificacion.ExamenC = int.Parse(txtExamenC.Text);

                        // Calcular la puntuación final del completivo
                        double puntuacionFinalCompletivo = (calificacion.ExamenC * 0.5) + acumuladoCompletivo;
                        txtFinalC.Text = puntuacionFinalCompletivo.ToString("F2");

                        if (puntuacionFinalCompletivo < 70)
                        {
                            double acumuladoExtraordinario = puntuacionFinalCompletivo * 0.3;
                            txtAcumuladoC.Text = acumuladoExtraordinario.ToString("F2");

                            // Solo calcular la puntuación final del extraordinario si se ha introducido la nota del examen extraordinario
                            if (!string.IsNullOrEmpty(txtAcumuladoE.Text))
                            {
                                calificacion.ExamenEx = int.Parse(txtExamenE.Text);

                                // Calcular la puntuación final del extraordinario
                                double puntuacionFinalExtraordinario = (calificacion.ExamenEx * 0.7) + acumuladoExtraordinario;
                                txtPuntuacionFF.Text = puntuacionFinalExtraordinario.ToString("F2");
                            }
                            else
                            {
                                txtPuntuacionFF.Text = "N/A";
                            }
                        }
                        else
                        {
                            txtAcumuladoE.Text = "N/A";
                            txtExamenE.Text = "N/A";
                            txtPuntuacionFF.Text = "N/A";
                        }
                    }
                    else
                    {
                        txtFinalC.Text = "N/A";
                        txtAcumuladoE.Text = "N/A";
                        txtPuntuacionFF.Text = "N/A";
                    }
                }
                else
                {
                    txtAcumuladoC.Text = "N/A";
                    txtExamenC.Text = "N/A";
                    txtAcumuladoE.Text = "N/A";
                    txtPuntuacionFF.Text = "N/A";
                    txtExamenE.Text = "N/A";
                    txtFinalC.Text = "N/A";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores válidos.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            var calificacionId = Convert.ToInt32(txtCalificacionId.Text);
                var primerP = Convert.ToInt32(txtPrimerP.Text);
            var segundoP = Convert.ToInt32(txtSegundoP.Text);
            var tercerP = Convert.ToInt32(txtTercerP.Text);
            var cuartoP = Convert.ToInt32(txtCuartoP.Text);
            var promedio = Convert.ToDouble(txtPromedio.Text);
            var examenF = Convert.ToInt32(txtExamenF.Text);
            var puntuacionF = Convert.ToDouble(txtPuntuacionF.Text ?? "0");
            int acumuladoC = 0;
            if(txtAcumuladoC.Text != "N/A")
            {
                 acumuladoC = Convert.ToInt32(txtAcumuladoC.Text ?? "");
            }
            int examenC = 0;
            if (txtExamenC.Text != "N/A")
            {
                examenC = Convert.ToInt32(txtExamenC.Text);
            }
            int completivoF = 0;
            if(txtFinalC.Text != "N/A")
            {
                completivoF = Convert.ToInt32(txtFinalC.Text);
            }

    

            int acumuladoEX = 0;
            if (txtAcumuladoE.Text != "N/A")
            {
                acumuladoEX = Convert.ToInt32(txtAcumuladoE.Text ?? "");}
            
            int examenEx = 0;
            if (txtExamenE.Text != "N/A")
            {
                examenEx = Convert.ToInt32(txtExamenE.Text ?? "");
            }
          
            int finalEx = 0;
            if (txtPuntuacionFF.Text != "N/A")
            {
                finalEx = Convert.ToInt32(txtPuntuacionFF.Text);
            }

            Calificacion objcalificacion = new Calificacion(calificacionId,1,1,primerP,puntuacionF,promedio,segundoP,tercerP,cuartoP,examenF,acumuladoC,examenC,acumuladoEX,examenEx,completivoF,finalEx);

            if (objcalificacion.CalificacionId == 0)
            {

                int idcalificagenerado = new CD_Calificacion().Registrar(objcalificacion, out Mensaje);

                if (idcalificagenerado != 0)
                {
                    dgvData.Rows.Add(new object[]
                       { "", idcalificagenerado,txtPrimerP.Text, txtSegundoP, txtTercerP.Text,txtCuartoP.Text,txtPromedio.Text,
                        txtExamenF.Text,txtPuntuacionF.Text,txtAcumuladoC.Text,txtExamenC.Text,txtFinalC.Text,txtAcumuladoE.Text,txtExamenE.Text,txtPuntuacionFF.Text

                    });

                    Limpiar();
                }


                else { MessageBox.Show("Calificacion asignada correctamente!"); }

                Limpiar();
            }
            else
            {
                bool resultado = new CD_Calificacion().Editar(objcalificacion, out Mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["CalificacionId"].Value = txtCalificacionId.Text;
                    row.Cells["PrimerP"].Value = txtPrimerP.Text;
                    row.Cells["SegundoP"].Value = txtSegundoP.Text;
                    row.Cells["TercerP"].Value = txtTercerP.Text;
                    row.Cells["CuartoP"].Value = txtCuartoP.Text;
                    row.Cells["Promedio"].Value = txtPromedio.Text;
                    row.Cells["ExamenF"].Value = txtExamenF.Text;
                    row.Cells["PuntuacionF"].Value = txtPuntuacionF.Text;
                    row.Cells["AcumuladoC"].Value = txtAcumuladoC.Text;
                    row.Cells["ExamenC"].Value = txtExamenC.Text;
                    row.Cells["FinalC"].Value = txtFinalC.Text;
                    row.Cells["AcumuladoE"].Value = txtAcumuladoE.Text;
                    row.Cells["ExamenE"].Value = txtExamenE.Text;
                    row.Cells["PuntuacionFF"].Value = txtPuntuacionFF.Text;


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
            txtCalificacionId.Text = "0";
            txtPrimerP.Text = "";
            txtSegundoP.Text = "";
            txtTercerP.Text = "";
            txtCuartoP.Text = "";
            txtPromedio.Text = "";
            txtExamenF.Text = "";
            txtPuntuacionF.Text = "";
            txtAcumuladoC.Text = "";
            txtExamenC.Text = "";
            txtFinalC.Text = "";
            txtAcumuladoE.Text = "";
            txtExamenE.Text = "";
            txtPuntuacionFF.Text = "";


            txtPrimerP.Select();
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
                    txtCalificacionId.Text = dgvData.Rows[indice].Cells["CalificacionId"].Value.ToString();
                    txtPrimerP.Text = dgvData.Rows[indice].Cells["PrimerP"].Value.ToString();
                    txtSegundoP.Text = dgvData.Rows[indice].Cells["SegundoP"].Value.ToString();
                    txtTercerP.Text = dgvData.Rows[indice].Cells["TercerP"].Value.ToString();
                    txtCuartoP.Text = dgvData.Rows[indice].Cells["CuartoP"].Value.ToString();
                    txtPromedio.Text = dgvData.Rows[indice].Cells["Promedio"].Value.ToString();
                    txtExamenF.Text = dgvData.Rows[indice].Cells["ExamenF"].Value.ToString();
                    txtPuntuacionF.Text = dgvData.Rows[indice].Cells["PuntuacionF"].Value.ToString();
                    txtAcumuladoC.Text = dgvData.Rows[indice].Cells["AcumuladoC"].Value.ToString();
                    txtExamenC.Text = dgvData.Rows[indice].Cells["ExamenC"].Value.ToString();
                    txtFinalC.Text = dgvData.Rows[indice].Cells["FinalC"].Value.ToString();
                    txtAcumuladoE.Text = dgvData.Rows[indice].Cells["AcumuladoE"].Value.ToString();
                    txtExamenE.Text = dgvData.Rows[indice].Cells["ExamenE"].Value.ToString();
                    txtPuntuacionFF.Text = dgvData.Rows[indice].Cells["PuntuacionFF"].Value.ToString();







                }
            }

        }

        private void AsignarcaliFrm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
