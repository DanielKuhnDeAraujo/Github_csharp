namespace Github_csharp.Formulários
{
    partial class CalcRadio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadBSubtrair = new System.Windows.Forms.RadioButton();
            this.RadBMultiplicar = new System.Windows.Forms.RadioButton();
            this.RadBDividir = new System.Windows.Forms.RadioButton();
            this.RadBSomar = new System.Windows.Forms.RadioButton();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.lbl_alg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_res = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadBSubtrair);
            this.groupBox1.Controls.Add(this.RadBMultiplicar);
            this.groupBox1.Controls.Add(this.RadBDividir);
            this.groupBox1.Controls.Add(this.RadBSomar);
            this.groupBox1.Location = new System.Drawing.Point(38, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RadBSubtrair
            // 
            this.RadBSubtrair.AutoSize = true;
            this.RadBSubtrair.Location = new System.Drawing.Point(34, 76);
            this.RadBSubtrair.Name = "RadBSubtrair";
            this.RadBSubtrair.Size = new System.Drawing.Size(90, 24);
            this.RadBSubtrair.TabIndex = 3;
            this.RadBSubtrair.TabStop = true;
            this.RadBSubtrair.Text = "Subtrair";
            this.RadBSubtrair.UseVisualStyleBackColor = true;
            this.RadBSubtrair.CheckedChanged += new System.EventHandler(this.RadBSubtrair_CheckedChanged);
            // 
            // RadBMultiplicar
            // 
            this.RadBMultiplicar.AutoSize = true;
            this.RadBMultiplicar.Location = new System.Drawing.Point(34, 106);
            this.RadBMultiplicar.Name = "RadBMultiplicar";
            this.RadBMultiplicar.Size = new System.Drawing.Size(104, 24);
            this.RadBMultiplicar.TabIndex = 2;
            this.RadBMultiplicar.TabStop = true;
            this.RadBMultiplicar.Text = "Multiplicar";
            this.RadBMultiplicar.UseVisualStyleBackColor = true;
            this.RadBMultiplicar.CheckedChanged += new System.EventHandler(this.RadBMultiplicar_CheckedChanged);
            // 
            // RadBDividir
            // 
            this.RadBDividir.AutoSize = true;
            this.RadBDividir.Location = new System.Drawing.Point(34, 136);
            this.RadBDividir.Name = "RadBDividir";
            this.RadBDividir.Size = new System.Drawing.Size(76, 24);
            this.RadBDividir.TabIndex = 1;
            this.RadBDividir.TabStop = true;
            this.RadBDividir.Text = "Dividir";
            this.RadBDividir.UseVisualStyleBackColor = true;
            this.RadBDividir.CheckedChanged += new System.EventHandler(this.RadBDividir_CheckedChanged);
            // 
            // RadBSomar
            // 
            this.RadBSomar.AutoSize = true;
            this.RadBSomar.Location = new System.Drawing.Point(34, 46);
            this.RadBSomar.Name = "RadBSomar";
            this.RadBSomar.Size = new System.Drawing.Size(81, 24);
            this.RadBSomar.TabIndex = 0;
            this.RadBSomar.TabStop = true;
            this.RadBSomar.Text = "Somar";
            this.RadBSomar.UseVisualStyleBackColor = true;
            this.RadBSomar.CheckedChanged += new System.EventHandler(this.RadBSomar_CheckedChanged);
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(354, 31);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(151, 26);
            this.txtBox1.TabIndex = 1;
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(354, 74);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(151, 26);
            this.txtBox2.TabIndex = 2;
            // 
            // lbl_alg
            // 
            this.lbl_alg.AutoSize = true;
            this.lbl_alg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_alg.Location = new System.Drawing.Point(318, 77);
            this.lbl_alg.Name = "lbl_alg";
            this.lbl_alg.Size = new System.Drawing.Size(20, 22);
            this.lbl_alg.TabIndex = 3;
            this.lbl_alg.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(356, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "________________";
            // 
            // lbl_res
            // 
            this.lbl_res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_res.Location = new System.Drawing.Point(360, 131);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(145, 28);
            this.lbl_res.TabIndex = 5;
            this.lbl_res.Text = "?";
            this.lbl_res.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(293, 195);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 34);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(393, 195);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 34);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(493, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CalcRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 272);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_alg);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CalcRadio";
            this.Text = "CalcRadio";
            this.Load += new System.EventHandler(this.CalcRadio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadBSomar;
        private System.Windows.Forms.RadioButton RadBSubtrair;
        private System.Windows.Forms.RadioButton RadBMultiplicar;
        private System.Windows.Forms.RadioButton RadBDividir;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Label lbl_alg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button button2;
    }
}