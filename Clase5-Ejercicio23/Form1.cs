using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase5_Ejercicio23Biblioteca;

namespace Clase5_Ejercicio23
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        #region Unusual
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void acept_Click(object sender, EventArgs e)
        {
            
        }


        #endregion


        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if(this.btnEuro.ImageIndex == 0)
            {
                this.btnEuro.ImageIndex = 1;
                textCotEuro.ReadOnly = true;
                textCotEuro.BackColor = SystemColors.ActiveBorder;
                textCotPeso.ReadOnly = true;
                textCotPeso.BackColor = SystemColors.ActiveBorder;
            }
            else if (this.btnEuro.ImageIndex == 1)
            {
                this.btnEuro.ImageIndex = 0;
                textCotEuro.ReadOnly = false;
                textCotEuro.BackColor = SystemColors.Window;
                textCotPeso.ReadOnly = false;
                textCotPeso.BackColor = SystemColors.Window;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double aux;

            if(double.TryParse(textCantEuro.Text, out aux))
            {
                Euro moneda = new Euro(aux);
                textBoxEuro.Text = moneda.GetCantidad.ToString();
                textBox8.Text = ((Dolar)moneda).GetCantidad.ToString();
                textBox7.Text = ((Peso)moneda).GetCantidad.ToString();

            }
        }

        private void textCotEuro_TextChanged(object sender, EventArgs e)
        {
            double aux;
            if(textCotEuro.Text != "1" || textCotEuro.Text != "2" || textCotEuro.Text != "3" ||
                textCotEuro.Text != "4" || textCotEuro.Text != "5" || textCotEuro.Text != "6" ||
                textCotEuro.Text != "7" || textCotEuro.Text != "8" || textCotEuro.Text != "9" ||
            textCotEuro.Text != "0" || textCotEuro.Text != ".")
            {
               
            }
            else
            {
                if (double.TryParse(textCotEuro.Text, out aux))
                {
                    Euro.setCotizaicon(aux);
                }
            }


            
        }

        private void textCantEuro_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxEuro_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textCotPeso_TextChanged(object sender, EventArgs e)
        {
            double aux;
     
            if(double.TryParse(textCotPeso.Text,out aux))
            {
                Peso.setCotizaicon(aux);
            }


        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCotDolar_TextChanged(object sender, EventArgs e)
        {
            //Dolar moneda = new Dolar(1, 1);
        }

        private void textBoxDolar_TextChanged(object sender, EventArgs e)
        {
            double aux;

            if(double.TryParse(textBoxDolar.Text, out aux))
            {
                Dolar moneda = new Dolar(aux);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double aux;

            if(double.TryParse(textBoxDolar.Text, out aux))
            {
                Dolar moneda = new Dolar(aux);
                textResultDolar.Text = moneda.GetCantidad.ToString();
                textResultEuro.Text = ((Euro)moneda).GetCantidad.ToString();
                textResultPeso.Text = ((Peso)moneda).GetCantidad.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double aux;

            if (double.TryParse(textBoxDolar.Text, out aux))
            {
                Peso moneda = new Peso(aux);
                textResultDolarP.Text = ((Dolar)moneda).GetCantidad.ToString();
                textResultEuroP.Text = ((Euro)moneda).GetCantidad.ToString();
                textResultPesoP.Text = moneda.GetCantidad.ToString();

            }
        }
    }
}
