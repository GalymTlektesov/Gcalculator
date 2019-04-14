using System;
using System.Windows.Forms;

namespace Gcalculator
{
    public partial class Form1 : Form 
    {
        double weightone;
        double price;
        double weight;
        double answer;
        string name;



        public Form1()
        {
            InitializeComponent();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Activated(object sender, EventArgs e)
        {
            textBox1.Focus();
        }


        private void button_WOC2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox4.Text == ""))
            {
                label3.Text = "Не все данные введны";
            }
            else
            {
                name = textBox1.Text;
                price = double.Parse(textBox2.Text);
                weightone = double.Parse(textBox3.Text);
                weight = double.Parse(textBox4.Text);
                answer = price * (weight / weightone);

                label3.Text = "Итог: " + answer.ToString("n") + "тг" + "\nза " + weight.ToString() + "кг";


                textBox1.Focus();
                textBox1.Text = "";
            }
        }

        public static void function_textbox(TextBox text, KeyPressEventArgs e, char a, char b)
        {

            if ((e.KeyChar >= a) && (e.KeyChar <= b))
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (text.Text.IndexOf(',') != 1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;

        }


        private void button_WOC3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            function_textbox(textBox1, e, 'а', 'я');

            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox2.Focus();
            }

            if ((e.KeyChar == (char)Keys.Back) && (textBox3.Text == ""))
            {
                textBox1.Focus();
            }
        }



        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            function_textbox(textBox2, e, '0', '9');

            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox3.Enabled = true;
                textBox3.Focus();
            }

            if ((e.KeyChar == (char)Keys.Back) && (textBox3.Text == ""))
            {
                textBox3.Focus();
            }
        }


        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            function_textbox(textBox4, e, '0', '9');

            if (e.KeyChar == (char)Keys.Enter)
            {
                button_WOC2.Focus();
            }

            if ((e.KeyChar == (char)Keys.Back) && (textBox2.Text == ""))
            {
                if (textBox3.Enabled == false)
                {
                    textBox3.Focus();
                }
                else
                {
                    textBox3.Focus();
                }
            }
        }


        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            function_textbox(textBox3, e, '0', '9');

            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox4.Focus();
                textBox4.Text = "";
            }

            if ((e.KeyChar == (char)Keys.Back) && (textBox3.Text == ""))
            {
                textBox2.Focus();
            }
        }
    }
}
