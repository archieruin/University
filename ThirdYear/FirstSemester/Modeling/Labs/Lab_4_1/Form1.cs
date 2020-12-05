using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_4_1
{ 
    public partial class Form1 : Form
    {
        private readonly int _screenWidth;
        private readonly int _screenHeight;

        private readonly Bitmap _bmp;
        private readonly Graphics _g;
        private readonly Pen _pen;
        private readonly LegacyRectangle _legacyRectangle = new LegacyRectangle();
        private readonly RectangleAdapter _rectangleAdapter = new RectangleAdapter();
        
        private string xTextBoxLastText = "";
        private string yTextBoxLastText = "";
        private string aTextBoxLastText = "";
        private string bTextBoxLastText = "";
        
        public Form1()
        {
            InitializeComponent();

            _screenWidth = pictureBox1.Width;
            _screenHeight = pictureBox1.Height;
            
            _bmp = new Bitmap(500, 500);
            _g = Graphics.FromImage(_bmp);
            _pen = new Pen(Color.Black, 5);
            
            pictureBox1.Image = _bmp;
            
            comboBox1.Items.Add("Старый прямоугольник");
            comboBox1.Items.Add("Новый прямоугольник");
            comboBox1.SelectedIndex = 0;

            xTextBox.Text = "0";
            yTextBox.Text = "0";
            aTextBox.Text = "50";
            bTextBox.Text = "50";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    xLabel.Text = "X";
                    yLabel.Text = "Y";
                    aLabel.Text = "Width";
                    bLabel.Text = "Height";
                    break;
                case 1:
                    xLabel.Text = "Top X";
                    yLabel.Text = "Top Y";
                    aLabel.Text = "Bottom X";
                    bLabel.Text = "Bottom Y";
                    break;
            }
        }
        private void drawButton_Click(object sender, EventArgs e)
        {
            _g.Clear(Color.White);
            var x = int.Parse(xTextBox.Text);
            var y = int.Parse(yTextBox.Text);
            var a = int.Parse(aTextBox.Text);
            var b = int.Parse(bTextBox.Text);
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    var rect = _legacyRectangle.Display(x, y, a, b);
                    _g.DrawRectangle(_pen, rect);
                    break;
                case 1:
                    rect = _rectangleAdapter.Display(x, y, a, b);
                    _g.DrawRectangle(_pen, rect);
                    break;
            }
            pictureBox1.Image = _bmp;
        }

        private void xTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(xTextBox.Text, out _))
            {
                xTextBoxLastText = xTextBox.Text;
            }
            else
            {
                xTextBox.Text = xTextBoxLastText;
            }
        }

        private void yTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(yTextBox.Text, out _))
            {
                yTextBoxLastText = yTextBox.Text;
            }
            else
            {
                yTextBox.Text = yTextBoxLastText;
            }
        }

        private void aTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(aTextBox.Text, out _))
            {
                aTextBoxLastText = aTextBox.Text;
            }
            else
            {
                aTextBox.Text = aTextBoxLastText;
            }
        }

        private void bTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(bTextBox.Text, out _))
            {
                bTextBoxLastText = bTextBox.Text;
            }
            else
            {
                bTextBox.Text = bTextBoxLastText;
            }
        }
    }
}