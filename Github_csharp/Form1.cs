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
            Close();
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
                        lbl_res.Text = $"{a} é o maior";
                    }
                    else
                    {
                        lbl_alg.Text = ">";
                        lbl_res.Text = $"{b} é o maior";
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
    }
}
