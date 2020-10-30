using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_2_2.BetsFactory;
using Lab_2_2.BetsFactory.Games;

namespace Lab_2_2
{
    public partial class MainForm : Form
    {
        GameType _selectedGameType = GameType.BasketBall;
        User _user = new User(1000);

        public MainForm()
        {
            InitializeComponent();

            chooseGameBox.Items.Add("Баскетбол");
            chooseGameBox.Items.Add("CS:GO");
            chooseGameBox.SelectedIndex = 0;

            balanceInfoLabel.Text = _user.Balance + " грн.";
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            switch (chooseGameBox.SelectedIndex)
            {
                case 1: _selectedGameType = GameType.BasketBall; break;
                case 2: _selectedGameType = GameType.Csgo; break;
            }
            

        }
    }
}
