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
            //lblVisor.Focus();
            this.ActiveControl = null;
        }
        private void f_operacoes(object sender, EventArgs e)
        {

            if (lblvisor.Text[lblvisor.Text.Length - 1] == ',')
            {
                lblvisor.Text += "0";
            }
            if (vOperacao != "")
            {
                btnIgual_Click(sender, e);
            }
            vNumant = decimal.Parse(lblvisor.Text);
            vOperacao = ((Button)sender).Text;
            vLimparVisor = true;
            lblHistorico.Text = vNumant + " " + vOperacao + " ";
            lblvisor.Focus();

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
                lblHistorico.Text = vNumant + " " + vOperacao + " " + Numatual +" = ";
                vOperacao = "";
            }
            
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {   if (!lblvisor.Text.Contains(',')) {
                lblvisor.Text += ",";
            }
            lblvisor.Focus();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblvisor.Text = "0";
            vOperacao = "";
            lblHistorico.Text = "";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblvisor.Text = "0";
        }

        private void CalcDeVdd_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyCode.ToString();
            Button botao= new Button();
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if ((e.KeyCode>=Keys.NumPad0 && e.KeyCode <= Keys.NumPad9 )||( e.KeyCode>=Keys.D0 && e.KeyCode<=Keys.D9))
            {
                botao.Text = e.KeyCode.ToString().Substring(e.KeyCode.ToString().Length-1);
                f_digitos(botao,e);
            }
        }
    }
}
