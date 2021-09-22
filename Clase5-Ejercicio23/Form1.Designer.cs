
namespace Clase5_Ejercicio23
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnEuro = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.ImageList(this.components);
            this.textCotEuro = new System.Windows.Forms.TextBox();
            this.textCotDolar = new System.Windows.Forms.TextBox();
            this.textCotPeso = new System.Windows.Forms.TextBox();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.textBoxDolar = new System.Windows.Forms.TextBox();
            this.textCantEuro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEuro = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBoxEuro = new System.Windows.Forms.TextBox();
            this.textResultPeso = new System.Windows.Forms.TextBox();
            this.textResultDolar = new System.Windows.Forms.TextBox();
            this.textResultEuro = new System.Windows.Forms.TextBox();
            this.textResultPesoP = new System.Windows.Forms.TextBox();
            this.textResultDolarP = new System.Windows.Forms.TextBox();
            this.textResultEuroP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotización";
            // 
            // btnEuro
            // 
            this.btnEuro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEuro.ImageIndex = 1;
            this.btnEuro.ImageList = this.btn;
            this.btnEuro.Location = new System.Drawing.Point(276, 41);
            this.btnEuro.Name = "btnEuro";
            this.btnEuro.Size = new System.Drawing.Size(94, 29);
            this.btnEuro.TabIndex = 1;
            this.btnEuro.UseVisualStyleBackColor = true;
            this.btnEuro.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn
            // 
            this.btn.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("btn.ImageStream")));
            this.btn.TransparentColor = System.Drawing.Color.Transparent;
            this.btn.Images.SetKeyName(0, "candado-abierto.png");
            this.btn.Images.SetKeyName(1, "candado-cerrado.png");
            // 
            // textCotEuro
            // 
            this.textCotEuro.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textCotEuro.Location = new System.Drawing.Point(386, 42);
            this.textCotEuro.Name = "textCotEuro";
            this.textCotEuro.ReadOnly = true;
            this.textCotEuro.Size = new System.Drawing.Size(125, 27);
            this.textCotEuro.TabIndex = 2;
            this.textCotEuro.TextChanged += new System.EventHandler(this.textCotEuro_TextChanged);
            // 
            // textCotDolar
            // 
            this.textCotDolar.Location = new System.Drawing.Point(534, 42);
            this.textCotDolar.Name = "textCotDolar";
            this.textCotDolar.ReadOnly = true;
            this.textCotDolar.Size = new System.Drawing.Size(125, 27);
            this.textCotDolar.TabIndex = 3;
            this.textCotDolar.Text = "1";
            this.textCotDolar.TextChanged += new System.EventHandler(this.textCotDolar_TextChanged);
            // 
            // textCotPeso
            // 
            this.textCotPeso.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textCotPeso.Location = new System.Drawing.Point(681, 43);
            this.textCotPeso.Name = "textCotPeso";
            this.textCotPeso.ReadOnly = true;
            this.textCotPeso.Size = new System.Drawing.Size(125, 27);
            this.textCotPeso.TabIndex = 4;
            this.textCotPeso.TextChanged += new System.EventHandler(this.textCotPeso_TextChanged);
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(146, 249);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(125, 27);
            this.textBoxPeso.TabIndex = 5;
            // 
            // textBoxDolar
            // 
            this.textBoxDolar.Location = new System.Drawing.Point(146, 187);
            this.textBoxDolar.Name = "textBoxDolar";
            this.textBoxDolar.Size = new System.Drawing.Size(125, 27);
            this.textBoxDolar.TabIndex = 6;
            this.textBoxDolar.TextChanged += new System.EventHandler(this.textBoxDolar_TextChanged);
            // 
            // textCantEuro
            // 
            this.textCantEuro.Location = new System.Drawing.Point(146, 126);
            this.textCantEuro.Name = "textCantEuro";
            this.textCantEuro.Size = new System.Drawing.Size(125, 27);
            this.textCantEuro.TabIndex = 7;
            this.textCantEuro.TextChanged += new System.EventHandler(this.textCantEuro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Euro";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dolar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Peso";
            // 
            // buttonEuro
            // 
            this.buttonEuro.ImageList = this.btn;
            this.buttonEuro.Location = new System.Drawing.Point(277, 124);
            this.buttonEuro.Name = "buttonEuro";
            this.buttonEuro.Size = new System.Drawing.Size(94, 29);
            this.buttonEuro.TabIndex = 11;
            this.buttonEuro.Text = "->";
            this.buttonEuro.UseVisualStyleBackColor = true;
            this.buttonEuro.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ImageList = this.btn;
            this.button3.Location = new System.Drawing.Point(277, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 12;
            this.button3.Text = "->";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ImageList = this.btn;
            this.button4.Location = new System.Drawing.Point(277, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 13;
            this.button4.Text = "->";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(725, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Peso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(574, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dolar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Euro";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox7.Location = new System.Drawing.Point(681, 125);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(125, 27);
            this.textBox7.TabIndex = 19;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox8.Location = new System.Drawing.Point(534, 124);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(125, 27);
            this.textBox8.TabIndex = 18;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBoxEuro
            // 
            this.textBoxEuro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxEuro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxEuro.Location = new System.Drawing.Point(386, 124);
            this.textBoxEuro.Name = "textBoxEuro";
            this.textBoxEuro.ReadOnly = true;
            this.textBoxEuro.Size = new System.Drawing.Size(125, 27);
            this.textBoxEuro.TabIndex = 17;
            this.textBoxEuro.TextChanged += new System.EventHandler(this.textBoxEuro_TextChanged);
            // 
            // textResultPeso
            // 
            this.textResultPeso.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textResultPeso.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textResultPeso.Location = new System.Drawing.Point(681, 186);
            this.textResultPeso.Name = "textResultPeso";
            this.textResultPeso.ReadOnly = true;
            this.textResultPeso.Size = new System.Drawing.Size(125, 27);
            this.textResultPeso.TabIndex = 22;
            // 
            // textResultDolar
            // 
            this.textResultDolar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textResultDolar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textResultDolar.Location = new System.Drawing.Point(534, 185);
            this.textResultDolar.Name = "textResultDolar";
            this.textResultDolar.ReadOnly = true;
            this.textResultDolar.Size = new System.Drawing.Size(125, 27);
            this.textResultDolar.TabIndex = 21;
            // 
            // textResultEuro
            // 
            this.textResultEuro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textResultEuro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textResultEuro.Location = new System.Drawing.Point(386, 185);
            this.textResultEuro.Name = "textResultEuro";
            this.textResultEuro.ReadOnly = true;
            this.textResultEuro.Size = new System.Drawing.Size(125, 27);
            this.textResultEuro.TabIndex = 20;
            // 
            // textResultPesoP
            // 
            this.textResultPesoP.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textResultPesoP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textResultPesoP.Location = new System.Drawing.Point(681, 249);
            this.textResultPesoP.Name = "textResultPesoP";
            this.textResultPesoP.ReadOnly = true;
            this.textResultPesoP.Size = new System.Drawing.Size(125, 27);
            this.textResultPesoP.TabIndex = 25;
            // 
            // textResultDolarP
            // 
            this.textResultDolarP.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textResultDolarP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textResultDolarP.Location = new System.Drawing.Point(534, 248);
            this.textResultDolarP.Name = "textResultDolarP";
            this.textResultDolarP.ReadOnly = true;
            this.textResultDolarP.Size = new System.Drawing.Size(125, 27);
            this.textResultDolarP.TabIndex = 24;
            // 
            // textResultEuroP
            // 
            this.textResultEuroP.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textResultEuroP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textResultEuroP.Location = new System.Drawing.Point(386, 248);
            this.textResultEuroP.Name = "textResultEuroP";
            this.textResultEuroP.ReadOnly = true;
            this.textResultEuroP.Size = new System.Drawing.Size(125, 27);
            this.textResultEuroP.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1063, 354);
            this.Controls.Add(this.textResultPesoP);
            this.Controls.Add(this.textResultDolarP);
            this.Controls.Add(this.textResultEuroP);
            this.Controls.Add(this.textResultPeso);
            this.Controls.Add(this.textResultDolar);
            this.Controls.Add(this.textResultEuro);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBoxEuro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonEuro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCantEuro);
            this.Controls.Add(this.textBoxDolar);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.textCotPeso);
            this.Controls.Add(this.textCotDolar);
            this.Controls.Add(this.textCotEuro);
            this.Controls.Add(this.btnEuro);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEuro;
        private System.Windows.Forms.ImageList btn;
        private System.Windows.Forms.TextBox textCotEuro;
        private System.Windows.Forms.TextBox textCotDolar;
        private System.Windows.Forms.TextBox textCotPeso;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.TextBox textBoxDolar;
        private System.Windows.Forms.TextBox textCantEuro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEuro;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBoxEuro;
        private System.Windows.Forms.TextBox textResultPeso;
        private System.Windows.Forms.TextBox textResultDolar;
        private System.Windows.Forms.TextBox textResultEuro;
        private System.Windows.Forms.TextBox textResultPesoP;
        private System.Windows.Forms.TextBox textResultDolarP;
        private System.Windows.Forms.TextBox textResultEuroP;
    }
}

