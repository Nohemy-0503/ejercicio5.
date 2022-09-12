using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            if (checkBox1.Checked == true)
            {
                double suma = numero1 + numero2;
                label3.Text = suma.ToString();
            }
            if (checkBox2.Checked == true)
            {
                double resta = numero1 - numero2;
                label3.Text = resta.ToString();
            }
            if (checkBox3.Checked == true)
            {
                double multiplicar = numero1 * numero2;
                label3.Text = multiplicar.ToString();
            }
            if (checkBox4.Checked == true)
            {
                double dividir = numero1 / numero2;
                label3.Text = dividir.ToString();
            }
        }
    }
}
