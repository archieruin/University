using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab_2_1
{
    public partial class Form1 : Form
    {
        List<Swimmer> _swimmers;

        public Form1()
        {
            InitializeComponent();
            _swimmers = new List<Swimmer>();
        }

        private string swimmersListToString(List<Swimmer> swimmers)
        {
            string result = "";
            foreach (var swimmer in swimmers)
            {
                result += swimmer + "\r\n";
            }
            return result;
        }

        private void addSwimmerButton_Click(object sender, EventArgs e)
        {
            string fullName = fullNameTextBox.Text;
            int age;
            int rating;

            if (fullName == "" || fullName == "Введите ФИО")
            {
                fullNameTextBox.Text = "Введите ФИО";
                return;
            }

            try
            {
                age = Convert.ToInt32(ageTextBox.Text);
            }
            catch (Exception)
            {
                ageTextBox.Text = "Введите число";
                return;
            }

            try
            {
                rating = Convert.ToInt32(ratingTextBox.Text);
            }
            catch (Exception)
            {
                ratingTextBox.Text = "Введите число";
                return;
            }

            _swimmers.Add(new Swimmer(fullName, age, rating));
            swimmersListRichTextBox.Text = swimmersListToString(_swimmers);
        }

        private void calculateTracksButton_Click(object sender, EventArgs e)
        {
            if (_swimmers.Count <= 0)
            {
                MessageBox.Show("Для начала добавтьте плавцов через форму с лева.", "Ошибка");
            }
            else
            {
                ContestCreator qualifyingContestCreator = new QualifyingContestCreator();
                ContestCreator finalContestCreator = new FinalContestCreator();
                IContest qualifyingContest = qualifyingContestCreator.FactoryMethod();
                IContest finalContest = finalContestCreator.FactoryMethod();


                QualifyingContestTextBox.Enabled = true;
                FinalContestTextBox.Enabled = true;
                
                QualifyingContestTextBox.Text = swimmersListToString(qualifyingContest.SortSwimmersByTracks(_swimmers));
                FinalContestTextBox.Text = swimmersListToString(finalContest.SortSwimmersByTracks(_swimmers));
            }
        }
        
        private void clearButton_Click(object sender, EventArgs e)
        {
            _swimmers.Clear();
            
            swimmersListRichTextBox.Text = "";
            QualifyingContestTextBox.Text = "";
            FinalContestTextBox.Text = "";
            
            QualifyingContestTextBox.Enabled = false;
            FinalContestTextBox.Enabled = false;
            
            MessageBox.Show("Список плавцов был очищен.", "Очищенно");
        }
    }
}