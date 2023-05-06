using System;
using System.Windows.Forms;

namespace Proiect
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			Complex p, q, delta, t, alpha, j;

			Complex a = Complex.setReIm(0, 0);
			Complex b = Complex.setReIm(0, 0);
			Complex c = Complex.setReIm(0, 0);
			Complex d = Complex.setReIm(0, 0);

			a.Re = Convert.ToInt32(aRe.Text);
			a.Im= Convert.ToInt32(aIm.Text);

			b.Re = Convert.ToInt32(bRe.Text);
			b.Im = Convert.ToInt32(bIm.Text);

			c.Re = Convert.ToInt32(cRe.Text);
			c.Im = Convert.ToInt32(cIm.Text);

			d.Re = Convert.ToInt32(dRe.Text);
			d.Im = Convert.ToInt32(dIm.Text);

			ec.Text = "("+a+")" + "x^3+" + "("+ b + ")" + "x^2+" + "("+ c + ")" + "x+" + "("+ d+ ")" + "=0";

            Complex z1 = Complex.setReIm(0, 1);
			p = (-(b * b) + 3 * a * c) / (3 * a * a);
			q = (2 * b * b * b + 27 * d * a * a - 9 * a * b * c) / (27 * a * a * a);
			delta = q * q + (4 * p * p * p / 27);
			t = (-q + delta.sqrt(2)) / 2;
			alpha = t.sqrt(3);
			j = (-1 + z1 * Math.Sqrt(3)) / 2;
			Complex h = b / (3 * a);

			if (delta != 0)
			{
				sol1.Text = j.pow(0) * alpha - j.pow(2 * 0) * (p / (3 * alpha)) - h + " ";
				sol2.Text = j.pow(1) * alpha - j.pow(2 * 1) * (p / (3 * alpha)) - h + " ";
				sol3.Text = j.pow(2) * alpha - j.pow(2 * 2) * (p / (3 * alpha)) - h + " ";
			}
			else
			{
				alpha = (-p / 3).sqrt(2);
				sol1.Text = 2 * alpha - b / 3 * a + " ";
				sol2.Text=-alpha - b / 3 * a+" ";
			}



		}
    }
}
