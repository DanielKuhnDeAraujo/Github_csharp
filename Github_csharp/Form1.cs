using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Github_csharp
{
    public partial class Form1 : Form
    {
        // utilidades
        public bool Par(int num)
        {
            return (num % 2 == 0);
        }
        // código mesmo
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_alg.Text = "+";
            decimal a, b;

            try
            {
                a = decimal.Parse(txtBox1.Text);
                b = decimal.Parse(txtBox2.Text);
                lbl_res.Text = (a + b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txtBox1.Text = "";
            txtBox2.Text = "";
            lbl_res.Text = "";
            lbl_alg.Text = "";

        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            lbl_alg.Text = "-";
            decimal a, b;

            try
            {
                a = decimal.Parse(txtBox1.Text);
                b = decimal.Parse(txtBox2.Text);
                lbl_res.Text = (a - b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_alg.Text = "X";
            decimal a, b;

            try
            {
                a = decimal.Parse(txtBox1.Text);
                b = decimal.Parse(txtBox2.Text);
                lbl_res.Text = (a * b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            lbl_alg.Text = "/";
            decimal a, b;

            try
            {
                a = decimal.Parse(txtBox1.Text);
                b = decimal.Parse(txtBox2.Text);
                lbl_res.Text = (a / b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Impossível divisão por zero");
            }

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl_alg.Text = "/";
            decimal a, b;
            try
            {
                a = decimal.Parse(txtBox1.Text);
                b = decimal.Parse(txtBox2.Text);
                if (a != b)
                {
                    if (a < b)
                    {
                        lbl_alg.Text = "<";
                        lbl_res.Text = $"{b} é o maior";
                    }
                    else
                    {
                        lbl_alg.Text = ">";
                        lbl_res.Text = $"{a} é o maior";
                    }
                }
                else
                {
                    lbl_alg.Text = "=";
                    lbl_res.Text = "São iguais";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbl_alg.Text = "%";
            lbl_res.Text = "";
            decimal a, b;
            try
            {
                a = decimal.Parse(txtBox1.Text);
                b = decimal.Parse(txtBox2.Text);
                if (Par((int)a)) {
                    lbl_res.Text = $"{a}: par";
                }
                else
                {
                    lbl_res.Text = $"{a}: ímpar";
                }
                if (Par((int)b))
                {
                    lbl_res.Text += $"\n{b}: par";
                }
                else
                {
                    lbl_res.Text += $"\n{b}: ímpar";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void lbl_res_Click(object sender, EventArgs e)
        {

        }

        private void txtBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
