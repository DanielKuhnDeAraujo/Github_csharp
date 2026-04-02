namespace Github_csharp.Formulários
{
    partial class CalcDeVdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btnAbs = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnElevado = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btmMenos = new System.Windows.Forms.Button();
            this.lblvisor = new System.Windows.Forms.Label();
            this.btnIgual = new System.Windows.Forms.Button();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn1sobre = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnPorcento = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.btn1sobre);
            this.panel1.Controls.Add(this.btnRaiz);
            this.panel1.Controls.Add(this.btnPorcento);
            this.panel1.Controls.Add(this.btnVirgula);
            this.panel1.Controls.Add(this.btn10);
            this.panel1.Controls.Add(this.btnAbs);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.btnCE);
            this.panel1.Controls.Add(this.btnC);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Location = new System.Drawing.Point(12, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 426);
            this.panel1.TabIndex = 20;
            // 
            // btnVirgula
            // 
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(157, 358);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(64, 63);
            this.btnVirgula.TabIndex = 14;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btn10
            // 
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.Location = new System.Drawing.Point(87, 358);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(64, 63);
            this.btn10.TabIndex = 13;
            this.btn10.Text = "0";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.f_digitos);
            // 
            // btnAbs
            // 
            this.btnAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbs.Location = new System.Drawing.Point(17, 358);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(64, 63);
            this.btnAbs.TabIndex = 12;
            this.btnAbs.Text = "+/-";
            this.btnAbs.UseVisualStyleBackColor = true;
            this.btnAbs.Click += new System.EventHandler(this.btnAbs_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(157, 13);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(64, 63);
            this.button10.TabIndex = 11;
            this.button10.Text = "<=";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.removerClick);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(87, 13);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(64, 63);
            this.btnCE.TabIndex = 10;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(17, 13);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(64, 63);
            this.btnC.TabIndex = 9;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(157, 151);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(64, 63);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(87, 151);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(64, 63);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(17, 151);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(64, 63);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(157, 220);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(64, 63);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(87, 220);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(64, 63);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(17, 220);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(64, 63);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(157, 289);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(64, 63);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(87, 289);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(64, 63);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Control;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(17, 289);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(64, 63);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.f_digitos);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.BtnElevado);
            this.panel2.Controls.Add(this.btnDividir);
            this.panel2.Controls.Add(this.btnIgual);
            this.panel2.Controls.Add(this.btnMais);
            this.panel2.Controls.Add(this.btnVezes);
            this.panel2.Controls.Add(this.btmMenos);
            this.panel2.Location = new System.Drawing.Point(257, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 426);
            this.panel2.TabIndex = 21;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BtnElevado
            // 
            this.BtnElevado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElevado.Location = new System.Drawing.Point(15, 289);
            this.BtnElevado.Name = "BtnElevado";
            this.BtnElevado.Size = new System.Drawing.Size(88, 63);
            this.BtnElevado.TabIndex = 19;
            this.BtnElevado.Text = "^";
            this.BtnElevado.UseVisualStyleBackColor = true;
            this.BtnElevado.Click += new System.EventHandler(this.f_operacoes);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(15, 220);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(88, 63);
            this.btnDividir.TabIndex = 15;
            this.btnDividir.Text = ":";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.f_operacoes);
            // 
            // btnMais
            // 
            this.btnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(15, 13);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(88, 63);
            this.btnMais.TabIndex = 18;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.f_operacoes);
            // 
            // btnVezes
            // 
            this.btnVezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVezes.Location = new System.Drawing.Point(15, 151);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(88, 63);
            this.btnVezes.TabIndex = 16;
            this.btnVezes.Text = "X";
            this.btnVezes.UseVisualStyleBackColor = true;
            this.btnVezes.Click += new System.EventHandler(this.f_operacoes);
            // 
            // btmMenos
            // 
            this.btmMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmMenos.Location = new System.Drawing.Point(15, 82);
            this.btmMenos.Name = "btmMenos";
            this.btmMenos.Size = new System.Drawing.Size(88, 63);
            this.btmMenos.TabIndex = 17;
            this.btmMenos.Text = "-";
            this.btmMenos.UseVisualStyleBackColor = true;
            this.btmMenos.Click += new System.EventHandler(this.f_operacoes);
            // 
            // lblvisor
            // 
            this.lblvisor.BackColor = System.Drawing.SystemColors.Control;
            this.lblvisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblvisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvisor.Location = new System.Drawing.Point(12, 29);
            this.lblvisor.Name = "lblvisor";
            this.lblvisor.Size = new System.Drawing.Size(362, 61);
            this.lblvisor.TabIndex = 0;
            this.lblvisor.Text = "0";
            this.lblvisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIgual.Location = new System.Drawing.Point(15, 355);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(88, 63);
            this.btnIgual.TabIndex = 12;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // lblHistorico
            // 
            this.lblHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorico.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHistorico.Location = new System.Drawing.Point(99, 6);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(275, 23);
            this.lblHistorico.TabIndex = 22;
            this.lblHistorico.Text = "0";
            this.lblHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // btn1sobre
            // 
            this.btn1sobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1sobre.Location = new System.Drawing.Point(157, 82);
            this.btn1sobre.Name = "btn1sobre";
            this.btn1sobre.Size = new System.Drawing.Size(64, 63);
            this.btn1sobre.TabIndex = 17;
            this.btn1sobre.Text = "1/x";
            this.btn1sobre.UseVisualStyleBackColor = true;
            this.btn1sobre.Click += new System.EventHandler(this.btn1sobre_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(87, 82);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(64, 63);
            this.btnRaiz.TabIndex = 16;
            this.btnRaiz.Text = "²√x";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnPorcento
            // 
            this.btnPorcento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcento.Location = new System.Drawing.Point(17, 82);
            this.btnPorcento.Name = "btnPorcento";
            this.btnPorcento.Size = new System.Drawing.Size(64, 63);
            this.btnPorcento.TabIndex = 15;
            this.btnPorcento.Text = "%";
            this.btnPorcento.UseVisualStyleBackColor = true;
            this.btnPorcento.Click += new System.EventHandler(this.f_operacoes);
            // 
            // CalcDeVdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(386, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.lblvisor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KeyPreview = true;
            this.Name = "CalcDeVdd";
            this.Text = "CalcDeVdd";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalcDeVdd_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CalcDeVdd_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblvisor;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btnAbs;
        private System.Windows.Forms.Button BtnElevado;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnVezes;
        private System.Windows.Forms.Button btmMenos;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1sobre;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnPorcento;
    }
}