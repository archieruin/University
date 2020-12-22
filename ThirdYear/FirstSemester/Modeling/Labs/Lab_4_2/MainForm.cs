using System;
using System.Windows.Forms;

namespace Lab_4_2
{
    public partial class MainForm : Form
    {
        private IConnectTires _tires;
        public MainForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("Легковой автомобиль");
            comboBox1.Items.Add("Автобус");
            comboBox1.Items.Add("Камаз");
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    _tires = new LightCarTires();
                    richTextBox1.Text = _tires.Connect();
                    break;
                case 1:
                    _tires = new BusTires();
                    richTextBox1.Text = _tires.Connect();
                    break;
                case 2:
                    _tires = new KamazTiresAdapter(new KamazTires());
                    richTextBox1.Text = _tires.Connect();
                    break;
            }
        }
    }
}