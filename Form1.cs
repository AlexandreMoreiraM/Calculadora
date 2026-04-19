using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 0, res = 0;
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);

            res = n1 + n2;

            label5.Text = res.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n1 =0, n2 = 0, res = 0;

            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);

            res = n1 - n2;

            label5.Text = res.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 0, res = 0;

            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);

            res = n1 * n2;

            label5.Text = res.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0, res = 0;

            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);

            res = n1 / n2;

            label5.Text = res.ToString();
        }
    }
}
