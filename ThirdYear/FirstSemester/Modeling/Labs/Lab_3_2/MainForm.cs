using System;
using System.Windows.Forms;

namespace Lab_3_2
{
    public partial class MainForm : Form
    {
        TiresFactory _tiresFactory;
        public MainForm()
        {
            InitializeComponent();
            carTypeBox.Items.Add("Джип");
            carTypeBox.Items.Add("Купе");
            carTypeBox.Items.Add("Внедорожник");
            carTypeBox.SelectedIndex = 0;
        }

        private void carTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _tiresFactory = carTypeBox.SelectedIndex switch
            {
                0 => new JeepTiresFactory(),
                1 => new CoupeTiresFactory(),
                2 => new SUVTiresFactory(),
                _ => new JeepTiresFactory()
            };
            FillTiresTypeBox(_tiresFactory);
        }

        private void tiresTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = "";
            switch (tiresTypeBox.SelectedIndex)
            {
                case 0:
                    var summerTires = _tiresFactory.CreateSummerTire();
                    text = $"Название: {summerTires.Name}\n\n";
                    text += $"Категория: {summerTires.season}\n\n";
                    text += $"Информация:\n{summerTires.GetInfo()}";
                    break;
                case 1:
                    var winterTires = _tiresFactory.CreateWinterTire();
                    text = $"Название: {winterTires.Name}\n\n";
                    text += $"Категория: {winterTires.season}\n\n";
                    text += $"Информация:\n{winterTires.GetInfo()}";
                    break;
                case 2:
                    var allSeasonTires = _tiresFactory.CreateAllSeasonTire();
                    text = $"Название: {allSeasonTires.Name}\n\n";
                    text += $"Категория: {allSeasonTires.season}\n\n";
                    text += $"Информация:\n{allSeasonTires.GetInfo()}";
                    break;
            }
            resultTextBox.Text = text;
        }

        private void FillTiresTypeBox(TiresFactory tiresFactory)
        {
            tiresTypeBox.Items.Clear();
            tiresTypeBox.Items.Add(tiresFactory.CreateSummerTire().Name);
            tiresTypeBox.Items.Add(tiresFactory.CreateWinterTire().Name);
            tiresTypeBox.Items.Add(tiresFactory.CreateAllSeasonTire().Name);
            tiresTypeBox.Enabled = true;
            tiresTypeBox.SelectedIndex = 0;
        }
    }
}