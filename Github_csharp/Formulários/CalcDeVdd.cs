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
        public CalcDeVdd()
        {
            InitializeComponent();
        }

        private void f_digitos(object sender, EventArgs e)
        {
            string digito = ((Button)sender).Text;
            lblvisor.Text = lblvisor.Text == "0" ? digito : lblvisor.Text+digito;
        }

        private void removerClick(object sender, EventArgs e)
        {
            lblvisor.Text = lblvisor.Text.Substring(0, lblvisor.Text.Length - 1);
        }
    }
}
