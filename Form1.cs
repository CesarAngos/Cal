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

        private void btn9_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = btn9.Text;
        }
    }
}
