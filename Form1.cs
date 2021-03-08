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

        int Mocnina(int a, int b)
        {
            int vysledek = 1;
            if (b > 0)
            {
                for (int i = 0; i < b; ++i)
                {
                    vysledek *= a;
                }
            }
            else if (b < 0)
            {
                for (int i = 0; i > b; --i)
                {
                    vysledek /= a;
                }
            }
            return vysledek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Vzdalenost bodu: " + Vzdalenost(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            label2.Text = "Mocnina: " + Mocnina(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }
    }
}
