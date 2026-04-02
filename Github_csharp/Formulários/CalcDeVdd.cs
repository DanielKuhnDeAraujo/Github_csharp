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
            if (vOperacao != "" && !vLimparVisor)
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
            if (lblvisor.Text.Length <1 || vLimparVisor)
            {
                lblvisor.Text = "0";
                vLimparVisor = false;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (vOperacao != "")
            {
                bool zeroexep=false;
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
                        try
                        {
                            lblvisor.Text = (vNumant / Numatual).ToString();
                        }
                        catch (DivideByZeroException)
                        {
                            MessageBox.Show("Impossível divisão por zero");
                            return;
                        }
                        break;
                    case "X":
                        lblvisor.Text = (vNumant * Numatual).ToString();
                        break;
                    case "^":
                        lblvisor.Text = (Math.Pow((double)vNumant, (double)Numatual)).ToString();
                        break;
                    case "%":
                        lblvisor.Text = (vNumant * Numatual / 100).ToString();
                        break;
                }
                lblHistorico.Text = vNumant + " " + vOperacao + " " + Numatual +" = ";
                vOperacao = "";
            }
            
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (vLimparVisor)
            {
                lblvisor.Text = "0";
            }
            if (!lblvisor.Text.Contains(',')) {
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
                foreach (Control ctr in panel1.Controls) {
                    if(((Button)ctr).Text == botao.Text)
                    {
                        ctr.BackColor = Color.Gray;
                    }
                }
            }
            switch(e.KeyCode)
            {
                case Keys.Back:
                    removerClick(botao, e);
                    break;
                case Keys.Decimal: 
                    btnVirgula_Click(botao, e);
                    break;
                case Keys.Return:
                    btnIgual_Click(botao, e);  
                    break;

            }
            bool operacoes = true;
            switch(e.KeyCode)
            {
                case Keys.Add:
                    botao.Text = "+";
                    break;
                case Keys.OemMinus:
                case Keys.Subtract:
                    botao.Text = "-";
                    break;
                case Keys.Multiply:
                    botao.Text = "X";
                    break;
                case Keys.Divide:
                    botao.Text = ":";
                    break;
                default:
                    operacoes= false;
                    break;
            }
            if (operacoes)
            {
                f_operacoes(botao,e);
            }
            
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            if (vLimparVisor)
            {
                lblvisor.Text = "0";
            }
            if (lblvisor.Text[lblvisor.Text.Length - 1] == ',')
            {
                lblvisor.Text += "0";
            }
            decimal absoluter = decimal.Parse(lblvisor.Text);
            absoluter = -(absoluter);
            lblvisor.Text = absoluter.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CalcDeVdd_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (Control control in panel1.Controls) {
                control.BackColor = Color.White;
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (vLimparVisor)
            {
                lblvisor.Text = "0";
            }
            if (lblvisor.Text[lblvisor.Text.Length - 1] == ',')
            {
                lblvisor.Text += "0";
            }
            decimal raizeiro = decimal.Parse(lblvisor.Text);
            double raizado = Math.Sqrt((double)raizeiro);
            lblvisor.Text = raizado.ToString();
        }

        private void btn1sobre_Click(object sender, EventArgs e)
        {
            if (vLimparVisor)
            {
                lblvisor.Text = "0";
            }
            if (lblvisor.Text[lblvisor.Text.Length - 1] == ',')
            {
                lblvisor.Text += "0";
            }
            decimal sobre = decimal.Parse(lblvisor.Text);
            sobre = 1 / sobre;
            lblvisor.Text = sobre.ToString();
        }
    }
}
