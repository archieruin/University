using System;
using System.Windows.Forms;

namespace Lab_5_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TiresService tiresService = new TiresService();
            var result = tiresService.MakeService();
            result += "\nHave nice day! :)";
            richTextBox1.Text = result;
        }
    }
}
