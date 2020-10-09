using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        private bool doDraw = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            doDraw = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            doDraw = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (doDraw)
            {
                Graphics g = Graphics.FromHwnd(this.Handle);
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                Pen pen = new Pen(blackBrush);
                // g.FillRectangle(blackBrush, e.X, e.Y, 10, 10);
                Point p1 = new Point(e.Y, e.Y);
                Point p2 = new Point(e.X, e.X);
                g.DrawLine(pen, p1, p2);
            }
        }
    }
}