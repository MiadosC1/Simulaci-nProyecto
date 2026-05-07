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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnGenerador_Click(object sender, EventArgs e)
        {
            Generador gen = new Generador();
            gen.Show();
            this.Hide();
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            Acercade a = new Acercade();
            a.ShowDialog();
        }

       

        private void btnProblem2_Click(object sender, EventArgs e)
        {
            Problema2 p2 = new Problema2();
            p2.Show();
            this.Hide();
        }

       
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
