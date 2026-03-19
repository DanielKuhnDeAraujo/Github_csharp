using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Github_csharp.Formulários
{
    public partial class CalcRadio : Form
    {
        public CalcRadio()
        {
            InitializeComponent();
        }

        private void CalcRadio_Load(object sender, EventArgs e)
        {

        }

        //BOTÃO DE FECHAMENTO
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBox1.Text = "";
            txtBox2.Text = "";
            lbl_res.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal a, b;
            try
            {
                a = decimal.Parse(txtBox1.Text);
                b = decimal.Parse(txtBox2.Text);
                if (RadBSomar.Checked)
                { 
                    lbl_res.Text = (a + b).ToString();

                }
                else if (RadBSubtrair.Checked)
                {
                    lbl_res.Text = (a - b).ToString();
                }
                else if (RadBMultiplicar.Checked)
                {
                    lbl_res.Text = (a * b).ToString();
                }
                else if (RadBDividir.Checked)
                {
                    lbl_res.Text = (a / b).ToString();
                }
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

        private void RadBSomar_CheckedChanged(object sender, EventArgs e)
        {
            lbl_alg.Text = "+";
        }

        private void RadBSubtrair_CheckedChanged(object sender, EventArgs e)
        {
            lbl_alg.Text = "-";
        }

        private void RadBMultiplicar_CheckedChanged(object sender, EventArgs e)
        {
            lbl_alg.Text = "X";
        }

        private void RadBDividir_CheckedChanged(object sender, EventArgs e)
        {
            lbl_alg.Text = "÷";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
