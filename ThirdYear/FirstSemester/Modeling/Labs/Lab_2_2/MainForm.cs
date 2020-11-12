using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab_2_2
{
    public partial class MainForm : Form
    {
        private BeatsFactory _beatsFactory = new BeatsFactory();
        
        private List<Game> _dotaGames;
        private List<Game> _csgoGames;
        private List<Game> _footBallGames;
        private List<Game> _basketBallGames;
        
        public MainForm()
        {
            InitializeComponent();
            
            _dotaGames = new List<Game>
            {
                _beatsFactory.CreateGame(GameType.Dota, "Dota tournament v1", 1.2, 2.34),
                _beatsFactory.CreateGame(GameType.Dota, "Dota tournament v2", 2.21, 1.26),
                _beatsFactory.CreateGame(GameType.Dota, "Dota tournament v3", 1.11, 2.41),
                _beatsFactory.CreateGame(GameType.Dota, "Dota tournament v4", 3.04, 0.22),
                _beatsFactory.CreateGame(GameType.Dota, "Dota tournament v5", 1.52, 2.12),
                _beatsFactory.CreateGame(GameType.Dota, "Dota tournament v6", 1.24, 2.31)
            };
            _csgoGames = new List<Game>
            {
                _beatsFactory.CreateGame(GameType.Csgo, "NAVI vs The Alliance", 2.53, 1.30),
                _beatsFactory.CreateGame(GameType.Csgo, "OG vs NiP", 3.11, 0.53),
                _beatsFactory.CreateGame(GameType.Csgo, "NiP vs NAVI", 2.34, 1.25)
            };
            _footBallGames = new List<Game>
            {
                _beatsFactory.CreateGame(GameType.FootBall, "Сербия vs Шотландия", 1.88, 4.80),
                _beatsFactory.CreateGame(GameType.FootBall, "Венгрия vs Исландия", 2.21, 4.20),
                _beatsFactory.CreateGame(GameType.FootBall, "Уэльс vs США", 2.70, 2.75)
            };
            _basketBallGames = new List<Game>
            {
                _beatsFactory.CreateGame(GameType.FootBall, "Гран Канария vs Тренто", 1.92, 1.89),
                _beatsFactory.CreateGame(GameType.FootBall, "Нижний Новгород vs Парма Пермь", 1.87, 1.91),
            };
            
            gameTypeComboBox.Items.Add(GameType.Dota);
            gameTypeComboBox.Items.Add(GameType.Csgo);
            gameTypeComboBox.Items.Add(GameType.FootBall);
            gameTypeComboBox.Items.Add(GameType.BasketBall);
            gameTypeComboBox.SelectedIndex = 0;
        }

        private void gameTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputTextBox.Text = "Доступные матчи:\r\n";
            
            List<Game> selectedGames;
            
            switch (gameTypeComboBox.SelectedIndex)
            {
                case 0: selectedGames = _dotaGames; break;
                case 1: selectedGames = _csgoGames; break;
                case 2: selectedGames = _footBallGames; break;
                case 3: selectedGames = _basketBallGames; break;
                default: selectedGames = new List<Game>(); break;
            }

            if (selectedGames.Count <= 0)
            {
                outputTextBox.Text = "В этом типе пока нет игр.";
            }
            
            foreach (var game in selectedGames)
            {
                outputTextBox.Text += $"{game.GetCoefs()}\r\n";
            }
        }
    }
}
