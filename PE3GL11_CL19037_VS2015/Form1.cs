using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE3GL11_CL19037_VS2015
{
    public partial class Form1 : Form
    {
        Operaciones Jugar = new Operaciones();
        public Form1()
        {
            InitializeComponent();
            ttAyuda.SetToolTip(btnOperar, "OPRIMA ESTE BOTON PARA PODER OPERAR LOS DATOS INGRESADOS");
            ttAyuda.SetToolTip(btnIngresar, "OPRIMA ESTE BOTON PARA PODER INGRESAR LOS DATOS DESEADOS");
            ttAyuda.SetToolTip(btnLimpiar, "OPRIMA ESTE BOTON PARA PODER LIMPIAR LOS DATOS REGISTADOS Y OPERADOS");
            ttAyuda.SetToolTip(btnCerrar, "OPRIMA ESTE BOTON PARA PODER CERRAR EL PROGRAMA");

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string[] zonas = { "OCCIDENTAL", "CENTRAL", "ORIENTAL" };
            string[] year = { "2018", "2019", "2020" };
            int i = 0, j = 0;
            double dato, year1 = 0, year2 = 0, year3 = 0;
            bool verdadero = false;
            do
            {
                verdadero = double.TryParse(Microsoft.VisualBasic.Interaction.InputBox("ingrese el dato del primer año para la zona " + zonas[j] + " en el año " + year[i]), out dato);
                if (verdadero == true)
                {
                    if (i==0)
                    {
                        year1 = dato;
                        i++;
                    }
                    else if (i==1)
                    {
                        year2 = dato;
                        i++;
                    }
                    else if (i==2)
                    {
                        year3 = dato;
                        dgvAllData.Rows.Add(zonas[j] + "","" + year1, "" + year2, "" + year3);
                        i = 0;
                        j++;
                    }
                }

            } while (j != 3);

            dgvAllData.Rows[3].Cells[0].Value = "TOTAL";
            btnOperar.Enabled = true;
            btnIngresar.Enabled = false;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double[,] datos = new double[3, 3];
            double sumaTotal = 0;
            datos[0, 0] = Convert.ToDouble(dgvAllData.Rows[0].Cells[1].Value);
            datos[0, 1] = Convert.ToDouble(dgvAllData.Rows[0].Cells[2].Value);
            datos[0, 2] = Convert.ToDouble(dgvAllData.Rows[0].Cells[3].Value);

            datos[1, 0] = Convert.ToDouble(dgvAllData.Rows[1].Cells[1].Value);
            datos[1, 1] = Convert.ToDouble(dgvAllData.Rows[1].Cells[2].Value);
            datos[1, 2] = Convert.ToDouble(dgvAllData.Rows[1].Cells[3].Value);

            datos[2, 0] = Convert.ToDouble(dgvAllData.Rows[2].Cells[1].Value);
            datos[2, 1] = Convert.ToDouble(dgvAllData.Rows[2].Cells[2].Value);
            datos[2, 2] = Convert.ToDouble(dgvAllData.Rows[2].Cells[3].Value);

            Jugar.Datos = datos;

            lblProduccion1Ma.Text = Jugar.ZonaMayor1Can().ToString();
            lblProduccion2Ma.Text = Jugar.ZonaMayor2Can().ToString();
            lblProduccion3Ma.Text = Jugar.ZonaMayor3Can().ToString();
            lblZona1Ma.Text = Jugar.ZonaMayor1();
            lblZona2Ma.Text = Jugar.ZonaMayor2();
            lblZona3Ma.Text = Jugar.ZonaMayor3();

            lblProduccion1Me.Text = Jugar.YearMenor1Can().ToString();
            lblProduccion2Me.Text = Jugar.YearMenor2Can().ToString();
            lblProduccion3Me.Text = Jugar.YearMenor3Can().ToString();
            lblYear1Me.Text = Jugar.YearMenor1();
            lblYear2Me.Text = Jugar.YearMenor2();
            lblYear3Me.Text = Jugar.YearMenor3();

            dgvAllData.Rows[3].Cells[1].Value = Jugar.SumasXYear()[0].ToString();
            dgvAllData.Rows[3].Cells[2].Value = Jugar.SumasXYear()[1].ToString();
            dgvAllData.Rows[3].Cells[3].Value = Jugar.SumasXYear()[2].ToString();

            dgvAllData.Rows[0].Cells[4].Value = Jugar.SumasXZone()[0].ToString();
            dgvAllData.Rows[1].Cells[4].Value = Jugar.SumasXZone()[1].ToString();
            dgvAllData.Rows[2].Cells[4].Value = Jugar.SumasXZone()[2].ToString();

            foreach (double suma in Jugar.SumasXYear())
            {
                sumaTotal += suma;
            }

            dgvAllData.Rows[3].Cells[4].Value = sumaTotal.ToString();
             
            lblProduccion1.Text = dgvAllData.Rows[0].Cells[2].Value.ToString();
            lblProduccion2.Text = dgvAllData.Rows[1].Cells[2].Value.ToString();
            lblProduccion3.Text = dgvAllData.Rows[2].Cells[2].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnOperar.Enabled = false;
            btnIngresar.Enabled = true;

            dgvAllData.Rows.Clear();

            lblProduccion1Ma.Text = "-";
            lblProduccion2Ma.Text = "-";
            lblProduccion3Ma.Text = "-";
            lblZona1Ma.Text = "-";
            lblZona2Ma.Text = "-";
            lblZona3Ma.Text = "-";

            lblProduccion1Me.Text = "-";
            lblProduccion2Me.Text = "-";
            lblProduccion3Me.Text = "-";
            lblYear1Me.Text = "-";
            lblYear2Me.Text = "-";
            lblYear3Me.Text = "-";

            lblProduccion1.Text = "-";
            lblProduccion2.Text = "-";
            lblProduccion3.Text = "-";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult close;
            close = MessageBox.Show("DESEA CERRAR YA EL PROGRAMA?", "ADVERTENCIA DE CIERRE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (close == DialogResult.Yes)
                Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOperar.Enabled = false;
        }
    }
}
