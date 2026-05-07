using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoSimulacion
{
    public partial class Generador : Form
    {
        public static double[] Almacenar;
        public Generador()
        {
            InitializeComponent();
        }

        private void Generador_Load(object sender, EventArgs e)
        {
                
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtAlphaProm.Text = "";
            txtAlpha2.Text = "";
            txtProm.Text = "";
            txtZo.Text = "";
            txtZAlpha2.Text = "";
            txtArea.Text = "";
        }     

        private void btnCalculoFrec_Click(object sender, EventArgs e)
        {
                if(Almacenar != null)
            {
                try
                {
                    //Se divide la cantidad de numeros generados entre nuestra cantidad de grupos
                    double Fe = Convert.ToDouble(txtNumGen.Text) / 4;
                    //Chi cuadrada calculada
                    double chi1 = 0, chi2 = 0, chi3 = 0, chi4 = 0, ChiCuadrada = 0 ;
                    //variables para contar en el grupo que cae cada numero pseudoaleatorio
                    int c1 = 0, c2 = 0, c3 = 0, c4 = 0;
                    //chi de tablas segun el alpha que se eligio
                    double ChiTablas = 0;

                    int i = 0;
                    txtFe1.Text = Fe.ToString();
                    txtFe2.Text = Fe.ToString();
                    txtFe3.Text = Fe.ToString();
                    txtFe4.Text = Fe.ToString();

                    //Se crea un ciclo hasta que la longitud del arreglo donde se estan almacenando los numeros
                    //Como so 4 intervalos se divide 1/4 = 0.25 y se va acumulando para cada uno de los grupos
                    while(i < Almacenar.Length)
                    {
                        //Grupo1
                        if (Almacenar[i] >= 0 && Almacenar[i] < 0.25)
                            c1++;
                        //Grupo2
                        if (Almacenar[i] >= 0.25 && Almacenar[i] < 0.50)
                            c2++;
                        //Grupo3
                        if (Almacenar[i] >= 0.50 && Almacenar[i] < 0.75)
                            c3++;
                        //Grupo4
                        if (Almacenar[i] >= 0.75 && Almacenar[i] < 1)
                            c4++;

                        i++;
                    }
                    //La frecuencia observada se imprime en la pantalla 
                    txtFo1.Text = c1.ToString();
                    txtFo2.Text = c2.ToString();
                    txtFo3.Text = c3.ToString();
                    txtFo4.Text = c4.ToString();
                    //Determinar la Chi cuadrada calculada
                    chi1 = Math.Pow((c1 - Fe), 2) / Fe;
                    chi2 = Math.Pow((c2 - Fe), 2) / Fe;
                    chi3 = Math.Pow((c3 - Fe), 2) / Fe;
                    chi4 = Math.Pow((c4 - Fe), 2) / Fe;
                    //Imprime el valor de chi cuadrada calculada
                    txtChi1.Text = chi1.ToString();
                    txtChi2.Text = chi2.ToString();
                    txtChi3.Text = chi3.ToString();
                    txtChi4.Text = chi4.ToString();
                    //Acumular los valores de chi obtenidos para buscar el valor de tablas con el alfa seleccionado
                    ChiCuadrada = chi1 + chi2 + chi3 + chi4;
                    //Imprime chi acumulada
                    txtChiCuadrada.Text = ChiCuadrada.ToString();
                    //Dependiendo del valor de alfa seleccionado depende del valor de tablas para chi
                    if(double.Parse(cmbAlpha.Text) == 0.995)
                    {
                        ChiTablas = 0.07;
                    }
                    else if (double.Parse(cmbAlpha.Text) == 0.990)
                    {
                        ChiTablas = 0.11;
                    }
                    else if (double.Parse(cmbAlpha.Text) == 0.975)
                    {
                        ChiTablas = 0.21;
                    }
                    else if (double.Parse(cmbAlpha.Text) == 0.950)
                    {
                        ChiTablas = 0.35;
                    }
                    else if (double.Parse(cmbAlpha.Text) == 0.500)
                    {
                        ChiTablas = 2.36;
                    }
                    else if (double.Parse(cmbAlpha.Text) == 0.050)
                    {
                        ChiTablas = 7.81;
                    }
                    else if (double.Parse(cmbAlpha.Text) == 0.250)
                    {
                        ChiTablas = 9.34;
                    }
                    else if (double.Parse(cmbAlpha.Text) == 0.010)
                    {
                        ChiTablas = 11.34;
                    }
                    else if (double.Parse(cmbAlpha.Text) == 0.005)
                    {
                        ChiTablas = 12.83;
                    }
                    //Imprime Chi de Tablas
                    txtChiTablas.Text = ChiTablas.ToString();

                    //despliegue de resultados
                    if (double.Parse(txtChiCuadrada.Text) <= double.Parse(txtChiTablas.Text))
                    {
                        lblFrecuencia.Text = "Los números SI estan distribuidos uniformemente";
                    }
                    else
                    {
                        lblFrecuencia.Text = "Los numeros NO estan distribuidos uniformemente";
                    }
                }
                  
                catch
                {
                    MessageBox.Show("No se ha ingresado los datos correctos, recuerde que tienen que ser valores numericos");
                }
            }
            else
            {
                MessageBox.Show("Aun no se han generado los numeros pseudoaleatorios");
            }
        }

        private void btnCalculoProm_Click(object sender, EventArgs e)
        {
            double alpha, alpha2, prom, Zo, area, suma = 0, res = 0;
            if(Almacenar != null)
            {
                try
                {
                    alpha = Convert.ToDouble(txtAlphaProm.Text);
                    if(alpha > 0 && alpha < 1)
                    {
                        int Num = int.Parse(txtNumGen.Text);
                        //Division de alpha/2
                        alpha2 = alpha / 2;
                        txtAlpha2.Text = alpha2.ToString();
                        //Suma de los numeros pseudoaleatorios
                        for (int i = 0; i < Almacenar.Length; i++)
                        {
                            suma = suma + Almacenar[i];
                        }
                        //Divide la suma entre la cantidad de los valores
                        prom = suma / Num;
                        txtProm.Text = Math.Round(prom, 2).ToString();
                        //Formula para Zo
                        Zo = (prom - 0.5) * (Math.Sqrt(Num)) / Math.Sqrt(0.8333333333);
                        txtZo.Text = Zo.ToString();
                        //Calculando area bajo la curva en la tabla de distribucion normal
                        area = 1 - alpha2;
                        txtArea.Text = area.ToString();
                        //Calcular el valor de las tablas
                        var chart1 = new Chart();
                        res = chart1.DataManipulator.Statistics.InverseNormalDistribution(area);
                        txtZAlpha2.Text = Math.Round(res, 2).ToString();

                        //despliegue de resultados
                        if (double.Parse(txtZo.Text) <= double.Parse(txtZAlpha2.Text))
                        {
                            lblPromedio.Text = "Los números SI estan distribuidos uniformemente";
                        }
                        else
                        {
                            lblPromedio.Text = "Los numeros NO estan distribuidos uniformemente";
                        }
                    }

                    else
                    {
                        MessageBox.Show("El valor de alpha debe estar dentro del rango de 0 y 1");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese un valor de Alpha");
                }
            }
            else
            {
                MessageBox.Show("Aun no se han generado los numeros pseudoaleatorios");
            }
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

        private void txtMenu_Click_1(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Hide();
        }

        private void btnBorrarF_Click(object sender, EventArgs e)
        {
            cmbAlpha.Text = "";
            txtFe1.Text = "";
            txtFe2.Text = "";
            txtFe3.Text = "";
            txtFe4.Text = "";
            txtFo1.Text = "";
            txtFo2.Text = "";
            txtFo3.Text = "";
            txtFo4.Text = "";
            txtChi1.Text = "";
            txtChi2.Text = "";
            txtChi3.Text = "";
            txtChi4.Text = "";
        }

        private void dataGridNumeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

        private void txtA_TextChanged(object sender, EventArgs e)
            {

            }

        private void label31_Click(object sender, EventArgs e)
            {

            }

        private void txtC_TextChanged(object sender, EventArgs e)
            {

            }

        private void txtAlphaProm_TextChanged(object sender, EventArgs e)
            {

            }
        }
}