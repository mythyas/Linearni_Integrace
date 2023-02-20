using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerickaIntegrace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            index.Maximum = 500;
            index.Minimum = 0;
        }
        public delegate double FunkceDelegate(double x);
        public delegate double Pravidla(double a, double b, int m, FunkceDelegate F);
        FunkceDelegate vybranaFunkce;
        Pravidla vybranePravidlo;
        private void button1_Click(object sender, EventArgs e)
        {
            double x = vybranePravidlo(Convert.ToDouble(dolniMez.Text), Convert.ToDouble(horniMez.Text), Convert.ToInt32(index.Value), vybranaFunkce);
            textBox1.Text = $"S = {x}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sin_CheckedChanged(object sender, EventArgs e)
        {
            vybranaFunkce = Funkce.Sinus;
        }

        private void cos_CheckedChanged(object sender, EventArgs e)
        {
            vybranaFunkce = Funkce.Cosinus;
        }

        private void linear_CheckedChanged(object sender, EventArgs e)
        {
            vybranaFunkce = Funkce.Linear;
        }

        private void lichobeznikove_CheckedChanged(object sender, EventArgs e)
        {
            vybranePravidlo = Metody.LichobeznikovaMetoda;
        }

        private void simpsonovo_CheckedChanged(object sender, EventArgs e)
        {
            vybranePravidlo = Metody.SimpsonovaMetoda;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
