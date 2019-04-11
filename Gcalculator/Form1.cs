using System;
using System.Windows.Forms;

namespace Gcalculator
{
    public partial class Form1 : Form
    {
        double weight;
        double price;
        double answer;


        public Form1()
        {
            InitializeComponent();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button_WOC2.Focus();
            }
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            price = Convert.ToDouble(textBox1.Text);
            weight = Convert.ToDouble(textBox2.Text);

            answer = price * weight;

            label3.Text = "Итог: " + answer.ToString("n") + "тг" + "\nза " + weight.ToString() + "кг";
        }
    }
}
