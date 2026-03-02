namespace Github_csharp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_somar = new System.Windows.Forms.Button();
            this.lbl_alg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_res = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(57, 30);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(141, 26);
            this.txtBox1.TabIndex = 0;
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(57, 90);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(141, 26);
            this.txtBox2.TabIndex = 0;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(362, 193);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(141, 47);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.Text = "&Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(57, 193);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(141, 47);
            this.btn_limpar.TabIndex = 1;
            this.btn_limpar.Text = "&Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_somar
            // 
            this.btn_somar.Location = new System.Drawing.Point(362, 20);
            this.btn_somar.Name = "btn_somar";
            this.btn_somar.Size = new System.Drawing.Size(141, 47);
            this.btn_somar.TabIndex = 1;
            this.btn_somar.Text = "&Somar";
            this.btn_somar.UseVisualStyleBackColor = true;
            this.btn_somar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_alg
            // 
            this.lbl_alg.AutoSize = true;
            this.lbl_alg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_alg.Location = new System.Drawing.Point(32, 90);
            this.lbl_alg.Name = "lbl_alg";
            this.lbl_alg.Size = new System.Drawing.Size(20, 22);
            this.lbl_alg.TabIndex = 2;
            this.lbl_alg.Text = "?";
            this.lbl_alg.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "________________";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_res
            // 
            this.lbl_res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_res.Location = new System.Drawing.Point(45, 143);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(153, 29);
            this.lbl_res.TabIndex = 3;
            this.lbl_res.Text = "?";
            this.lbl_res.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 262);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_alg);
            this.Controls.Add(this.btn_somar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_somar;
        private System.Windows.Forms.Label lbl_alg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_res;
    }
}

