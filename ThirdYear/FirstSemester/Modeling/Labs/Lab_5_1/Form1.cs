using System.Windows.Forms;

namespace Lab_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text.Length <= 5)
                MessageBox.Show("Full name input must contain more than 10 characters", "Error");
            else
            {
                CarManufacturing carManufacturing = new CarManufacturing(textBox1.Text);
                richTextBox1.Text = carManufacturing.ManufactureCar();
            }
        }
    }
}
