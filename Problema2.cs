using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSimulacion
{
    public partial class Problema2 : Form
    {
        public static double[] Almacenar;
        int juegos;
        public static double Monto, Apuesta, pierde = 0, gana = 0;
        public Problema2()
        {
            InitializeComponent();
        }

        private void btnBorrarJuego_Click(object sender, EventArgs e)
        {
            txtJuegos.Text = "";
            txtMonto.Text = "";
            txtApuesta.Text = "";
            txtGanadas.Text = "";
            txtPerdidas.Text = "";
            lblResultado.Text = "";

            dataGridJuego.Rows.Clear();
        }

        private void txtBorrar_Click_1(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtC.Text = "";
            txtXo.Text = "";
            txtM.Text = "";
            txtNumGen.Text = "";

            dataGridNumeros.Rows.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridNumeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

        private void Problema2_Load(object sender, EventArgs e)
            {

            }

        private void txtMenu_Click_1(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Hide();
        }

        private void btnGenNum_Click_1(object sender, EventArgs e)
        {
            double xn, proc, proc1, proc2;
            try
            {
                double A = Convert.ToDouble(txtA.Text);
                double C = Convert.ToDouble(txtC.Text);
                double Xo = Convert.ToDouble(txtXo.Text);
                double M = Convert.ToDouble(txtM.Text);
                int Num = int.Parse(txtNumGen.Text);
                Almacenar = new double[Num];
                //Confirma que los valores sean mayores a 0
                if (Convert.ToDouble(txtA.Text) > 0 && Convert.ToDouble(txtC.Text) > 0 && Convert.ToDouble(txtXo.Text) > 0 && Convert.ToDouble(txtM.Text) > 0)
                {
                    if (Convert.ToDouble(txtM.Text) > Convert.ToDouble(txtXo.Text) && Convert.ToDouble(txtM.Text) > Convert.ToDouble(txtA.Text) && Convert.ToDouble(txtM.Text) > Convert.ToDouble(txtC.Text))
                    {
                        //Generador de numeros pseudoaleatorios
                        for (int i = 0; i < Num; i++)
                        {
                            xn = Xo;
                            proc = (A * xn) + C;
                            proc1 = proc % M;
                            proc2 = proc1 / M;
                            Xo = proc1;

                            Almacenar[i] = proc2;

                            dataGridNumeros.Rows.Add(i, proc2);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se cumplen los parametros de M > A, M > C y M > Xo");
                    }
                }
                else
                {
                    MessageBox.Show("No se cumplen los parametros de A > 0, C > 0 y Xn > 0");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("No se ingreso algun dato correcto, recuerde que tiene que tener valores numericos");
            }
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (Almacenar != null)
            {
                try
                {
                    //variables 
                    Monto = double.Parse(txtMonto.Text);
                    Apuesta = double.Parse(txtApuesta.Text);
                    juegos = int.Parse(txtJuegos.Text);

                    bool bandera = false;
                    double MontoSave,ApuestaSave;
                    MontoSave = Monto;
                    ApuestaSave = Apuesta;

                    dataGridJuego.Refresh();
                    for (int i = 0; i < juegos; i++)
                    {

                        int n = dataGridJuego.Rows.Add();

                        dataGridJuego.Rows[n].Cells[0].Value = (i + 1);
                        dataGridJuego.Rows[n].Cells[1].Value = Almacenar[i];

                        //activa la bandera para reiniciar la apuesta
                        if(bandera == true)
                        {
                            Apuesta = ApuestaSave;
                        }

                        //cuando pierde
                        if (Almacenar[i] < 0.5)
                        {
                            dataGridJuego.Rows[n].Cells[2].Value = "DERROTA";

                            if (Monto < MontoSave)
                            {
                                //Se le resta al monto la apuesta
                                Monto = Monto - Apuesta;

                                //Como se perdio la Apuesta sube el doble
                                Apuesta = Apuesta + Apuesta;

                                //Aumenta en 1 el contador de derrotas
                                pierde = pierde + 1;

                                dataGridJuego.Rows[n].Cells[3].Value = Monto;
                                dataGridJuego.Rows[n].Cells[4].Value = Apuesta;
                            }
                            else
                            {
                                //Se le resta al monto la apuesta
                                Monto = Monto - Apuesta;

                                //Aumenta en 1 el contador de derrotas
                                pierde = pierde + 1;

                                dataGridJuego.Rows[n].Cells[3].Value = Monto;
                                dataGridJuego.Rows[n].Cells[4].Value = Apuesta;
                                if (Monto <= 0)
                                {
                                    lblResultado.Text = "MEJOR NO JUEGUES DE VERDAD!!";
                                }
                            }
                        }
                        //cuando gana
                        else if (Almacenar[i] > 0.5 && Almacenar[i] < 1)
                        {
                            dataGridJuego.Rows[n].Cells[2].Value = "VICTORIA";

                            //Se le suma al monto la apuesta
                            Monto = Monto + Apuesta;

                            if (Monto >= MontoSave)
                            {
                                bandera = true;
                            }
                            //Se le suma en 1 al contador de victorias
                            gana = gana + 1;

                            dataGridJuego.Rows[n].Cells[3].Value = Monto;
                            dataGridJuego.Rows[n].Cells[4].Value = Apuesta;
                        }                      
                    }
                    //desplegar resultados
                    txtGanadas.Text = gana.ToString();
                    txtPerdidas.Text = pierde.ToString();
                    if (Monto > MontoSave)
                    {
                        lblResultado.Text = "VE Y JUEGATE LA LECHE DEL BEBE!!";
                    }
                    else if (Monto == MontoSave)
                    {
                        lblResultado.Text = "QUEDASTE TABLAS, INTENTA DE NUEVO";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe de ingresar un valor numerico");
                }
                //llenado de tabla
            }
            else
            {
                MessageBox.Show("Genere primero los números pseudoaleatorios");
            }
        }
    }
}
