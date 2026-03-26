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
    public partial class CalcDeVdd : Form
    {
        decimal vNumant;
        string vOperacao = "";
        bool vLimparVisor;
        public CalcDeVdd()
        {
            InitializeComponent();
        }

        private void f_digitos(object sender, EventArgs e)
        {
            string digito = ((Button)sender).Text;
            /*if (lblvisor.Text == "0") lblvisor.Text = "";*/
            if ( lblvisor.Text == "0" || vLimparVisor){
                lblvisor.Text = "";
                vLimparVisor = false;
            }
            lblvisor.Text += digito;
        }
        private void f_operacoes(object sender, EventArgs e)
        {

                if (lblvisor.Text[lblvisor.Text.Length - 1] == ',')
                {
                    lblvisor.Text += "0";
                }
                vNumant = decimal.Parse(lblvisor.Text);
                vOperacao = ((Button)sender).Text;
                vLimparVisor = true;
            if (vOperacao != "")
            {
                btnIgual_Click(sender, e);
            }

        }

        private void removerClick(object sender, EventArgs e)
        {
            lblvisor.Text = lblvisor.Text.Substring(0, lblvisor.Text.Length - 1);
            if (lblvisor.Text.Length <1)
            {
                lblvisor.Text = "0";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (vOperacao != "")
            {
                decimal Numatual = decimal.Parse(lblvisor.Text);
                switch (vOperacao)
                {
                    case "+":
                        lblvisor.Text = (vNumant + Numatual).ToString();
                        break;
                    case "-":
                        lblvisor.Text = (vNumant - Numatual).ToString();
                        break;
                    case ":":
                        lblvisor.Text = (vNumant / Numatual).ToString();
                        break;
                    case "X":
                        lblvisor.Text = (vNumant * Numatual).ToString();
                        break;
                    case "^":
                        lblvisor.Text = (Math.Pow((double)vNumant, (double)Numatual)).ToString();
                        break;
                }
                vOperacao = "";
            }
            
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {   if (!lblvisor.Text.Contains(',')) {
                lblvisor.Text += ",";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblvisor.Text = "0";
            vOperacao = "";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblvisor.Text = "0";
        }
    }
}
