using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int i, j;
        double[,] matrixA = new double[6, 6];
        double[] vectorB = new double[6];
        double lineV;
        double factorial = 1;
        double[] dobV = new double[6];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Text += "Матрица А:" + Environment.NewLine;
            for (i = 1; i <=5; i++)
            {
                for (j = 1; j <=5; j++)
                {
                    matrixA[i, j] = Math.Round(Math.Asin((i + j) * Math.PI / 180), 3);
                    textBox1.Text += Math.Round(matrixA[i, j], 5) + "\t";
                }
                textBox1.Text += Environment.NewLine;
            }


            textBox1.Text += Environment.NewLine;
            textBox1.Text += "Vektor B:" + Environment.NewLine;
            for (int i = 1; i <= 5; i++)
            {
                if (i > 1)
                {
                    factorial = 1;
                    for (int j = 2; j <= i; j++)
                        factorial *= j;

                }
                vectorB[i - 1] = Math.Round(1 / (factorial + 3), 5);
                textBox1.Text += vectorB[i-1] + Environment.NewLine;
            }

            
            textBox1.Text += Environment.NewLine+ "Добуток Матрицы А на вектор В:" + Environment.NewLine;
            for (i = 1; i <=5; i++)
            {
                for (j = 1; j <=5; j++)
                {
                    lineV +=matrixA[i,j]*vectorB[j];
                }
                dobV[i] = lineV;
                lineV = 0;
            }

            for (i = 1; i <=5; i++)
            {
                textBox1.Text += dobV[i] + Environment.NewLine;
            }


            textBox1.Text += Environment.NewLine + "Транспонированная матрица А" + Environment.NewLine;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= 5; j++)
                {
                    textBox1.Text += Math.Round(matrixA[j, i], 5) + "\t";
                }
                textBox1.Text += Environment.NewLine;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
