using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Github_csharp.Formulários
{
    public partial class MDI_Menu : Form
    {
        public MDI_Menu()
        {
            InitializeComponent();
        }

        private void MDI_Menu_Load(object sender, EventArgs e)
        {

        }

        private void cálculosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void especiaisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comRadioButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm<CalcRadio>();

        }
        private void OpenChildForm<T>() where T : Form, new()
        {
                var existingForm = this.MdiChildren.FirstOrDefault(f => f is T);

                if (existingForm != null)
                {
                    // Se já existe, traz para frente e ativa
                    existingForm.BringToFront();
                    existingForm.Activate();
                }
                else
                {
                    // Se não existe, cria e exibe
                    var newForm = new T
                    {
                        MdiParent = this,
                    };
                    newForm.Show();
                }
        }
        private void janelasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm<Form1>(); // ChildForm é o tipo do formulário filho
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }


        private void MDI_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Saindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;   
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stahora.Text = DateTime.Now.ToString();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void verticalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }
    }
}
