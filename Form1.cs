using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double Vzdalenost(double a1, double a2, double b1, double b2)
        {
            double aVzdalenost = Math.Abs(b1 - a1);
            double bVzdalenost = Math.Abs(b2 - a1);
            double vysledek = Math.Sqrt((aVzdalenost * aVzdalenost) + (bVzdalenost * bVzdalenost));
            return vysledek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Vzdalenost bodu: " + Vzdalenost(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }
    }
}
