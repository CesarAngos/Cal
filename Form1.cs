using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caclculadora
{
    public partial class Form1 : Form
    {
        double numero1, numero2;
        string operacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = btn2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = btn6.Text;
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(resultadotxt.Text);
            operacion = "*";
            resultadotxt.Text = "";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = btn1.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = btn5.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = btn8.Text;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            resultadotxt.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(resultadotxt.Text, out numero2))
            {
                MessageBox.Show("Ingrese un segundo numero");
                return;
            }
            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    break;

                case "/":
                    if (numero2 == 0)
                    {
                        MessageBox.Show("No se puede dividir para cero");
                        return;
                    }

                    resultado = numero1 / numero2;
                    break;




            }
            resultadotxt.Text = resultado.ToString();

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(resultadotxt.Text);
            operacion = "+";
            resultadotxt.Text = "";

        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(resultadotxt.Text);
            operacion = "-";
            resultadotxt.Text = "";

        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(resultadotxt.Text);
            operacion = "/";
            resultadotxt.Text = "";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = btn9.Text;
        }
    }
}
