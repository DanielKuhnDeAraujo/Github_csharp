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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_somar = new System.Windows.Forms.Button();
            this.lbl_alg = new System.Windows.Forms.Label();
            this.lbl_res = new System.Windows.Forms.Label();
            this.btn_sub = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(157, 106);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(138, 26);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(157, 146);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(138, 26);
            this.txtBox2.TabIndex = 0;
            this.txtBox2.TextChanged += new System.EventHandler(this.txtBox2_TextChanged);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(454, 303);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(141, 47);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.Text = "&Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(10, 303);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(141, 47);
            this.btn_limpar.TabIndex = 1;
            this.btn_limpar.Text = "&Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_somar
            // 
            this.btn_somar.Location = new System.Drawing.Point(454, 85);
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
            this.lbl_alg.Location = new System.Drawing.Point(105, 150);
            this.lbl_alg.Name = "lbl_alg";
            this.lbl_alg.Size = new System.Drawing.Size(20, 22);
            this.lbl_alg.TabIndex = 2;
            this.lbl_alg.Text = "?";
            this.lbl_alg.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_res
            // 
            this.lbl_res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_res.Location = new System.Drawing.Point(157, 209);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(141, 69);
            this.lbl_res.TabIndex = 3;
            this.lbl_res.Text = "?";
            this.lbl_res.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_res.Click += new System.EventHandler(this.lbl_res_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(454, 144);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(141, 47);
            this.btn_sub.TabIndex = 4;
            this.btn_sub.Text = "Sub&trair";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Multiplicação";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "&Dividir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(157, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 47);
            this.button3.TabIndex = 7;
            this.button3.Text = "&Comparar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Stencil", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(55, 22);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(377, 61);
            this.titulo.TabIndex = 9;
            this.titulo.Text = "Calculadora";
            this.titulo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(304, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 47);
            this.button4.TabIndex = 8;
            this.button4.Text = "&Par Ímpar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "________________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(625, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.lbl_alg);
            this.Controls.Add(this.btn_somar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
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
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}

