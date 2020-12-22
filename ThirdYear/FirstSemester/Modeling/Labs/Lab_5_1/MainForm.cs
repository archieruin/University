using System.Windows.Forms;

namespace Lab_5_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text.Length <= 10)
                MessageBox.Show("Full name must contain more than 10 characters", "Error");
            else
            {
                CarManufacturing carManufacturing = new CarManufacturing(textBox1.Text);
                richTextBox1.Text = carManufacturing.ManufactureCar();
            }
        }
    }
}
