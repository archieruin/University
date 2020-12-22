using System;
using System.Windows.Forms;

namespace Lab_3_1
{
    public partial class MainForm : Form
    {
        СuisineFactory _cuisineFactory;
        public MainForm()
        {
            InitializeComponent();
            chooseCuisineBox.Items.Add("Украинская Кухня");
            chooseCuisineBox.Items.Add("Восточная Кухня");
            chooseEatBox.Items.Clear();
            chooseEatBox.Enabled = false;
        }

        private void chooseCuisineBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cuisineFactory = chooseCuisineBox.SelectedIndex switch
            {
                0 => new UkrainianСuisine(),
                1 => new EasternСuisine(),
                _ => _cuisineFactory
            };
            FillChooseEatBox(_cuisineFactory);
        }

        private void chooseEatBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = "";
            switch (chooseEatBox.SelectedIndex)
            {
                case 0:
                    var soup = _cuisineFactory.CreateSoup();
                    text = $"Название: {soup.Name}\n\n";
                    text += $"Категория: {soup.category}\n\n";
                    text += $"Ингридиенты:\n{soup.GetIngredients()}";
                    break;
                case 1:
                    var dumplings = _cuisineFactory.CreateDumplings();
                    text = $"Название: {dumplings.Name}\n\n";
                    text += $"Категория: {dumplings.category}\n\n";
                    text += $"Ингридиенты:\n{dumplings.GetIngredients()}";
                    break;
                case 2:
                    var cake = _cuisineFactory.CreateCake();
                    text = $"Название: {cake.Name}\n\n";
                    text += $"Категория: {cake.category}\n\n";
                    text += $"Ингридиенты:\n{cake.GetIngredients()}";
                    break;
                case 3:
                    var icecream = _cuisineFactory.CreateIceCream();
                    text = $"Название: {icecream.Name}\n\n";
                    text += $"Категория: {icecream.category}\n\n";
                    text += $"Ингридиенты:\n{icecream.GetIngredients()}";
                    break;
            }
            resultTextBox.Text = text;
        }

        private void FillChooseEatBox(СuisineFactory cuisineFactory)
        {
            chooseEatBox.Items.Clear();
            chooseEatBox.Items.Add(cuisineFactory.CreateSoup().Name);
            chooseEatBox.Items.Add(cuisineFactory.CreateDumplings().Name);
            chooseEatBox.Items.Add(cuisineFactory.CreateCake().Name);
            chooseEatBox.Items.Add(cuisineFactory.CreateIceCream().Name);
            chooseEatBox.Enabled = true;
            chooseEatBox.SelectedIndex = 0;
        }
    }
}