using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Red)
            {
                button1.BackColor = Color.Blue;
                button2.BackColor = Color.Red;
            }
            else
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Blue;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Red)
            {
                button1.BackColor = Color.Blue;
                button2.BackColor = Color.Red;
            }
            else
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Blue;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x = 6.37;
            double a = 2.56;
            double b = 7.18;
            double y = (a * x + b) / (Math.Pow(Math.Log(b * x), 2) + Math.Sqrt(a));
            MessageBox.Show(y.ToString(), "Решение");
        }
    }
}