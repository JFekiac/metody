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

        double faktorial(double x)
        {
            double vysledek = 1;
            while (x > 0)
            {
                vysledek *= x;
                --x;
            }
            return vysledek;
        }

        bool prvocislo(int x)
        {
            if (x <= 1) return false;
            if (x == 2) return true;
            for (int i = 3; i < x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Vzdalenost bodu: " + Vzdalenost(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            label2.Text = "Mocnina: " + Mocnina(int.Parse(textBox5.Text), int.Parse(textBox6.Text));
            label3.Text = "Faktorial: " + faktorial(int.Parse(textBox7.Text)).ToString();
            if (prvocislo(int.Parse(textBox8.Text))) label4.Text = "ANO, je to prvocislo";
            else label4.Text = "NE, neni to prvocislo";
        }
    }
}
