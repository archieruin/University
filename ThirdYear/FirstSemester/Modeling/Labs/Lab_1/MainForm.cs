using System;
using System.Windows.Forms;

namespace Lab_1
{
    abstract class Weapon
    {
        protected string Name { get; set; }
        protected string OwnerName { get; set; }
        protected double Damage { get; set; }

        protected Weapon(string name, string ownerName, double damage)
        {
            Name = name;
            OwnerName = ownerName;
            Damage = damage;
        }

        public virtual string Info()
        {
            return $"Название: {Name}, Владелец: {OwnerName}, Урон: {Damage}";
        }

        public abstract string TakeDamage(string To);
    }

    class Knife : Weapon
    {
        private readonly double _length;

        public Knife(string name, string ownerName, double damage, double length) : base(name, ownerName, damage)
        {
            _length = length;
        }

        public override string Info()
        {
            return $"Название: {Name}, Владелец: {OwnerName}, Урон: {Damage}, Длина: {_length}";
        }

        public override string TakeDamage(string to)
        {
            return $"{OwnerName} ударил {Name} {to} и нанес(ла) {Damage} урона.";
        }
    }

    class ShotGun : Weapon
    {
        private readonly double _length;
        private int _bulletsCount;

        public ShotGun(string name, string ownerName, double damage, double length, int bulletsCount) : base(name,
            ownerName, damage)
        {
            _length = length;
            _bulletsCount = bulletsCount;
        }

        public override string Info()
        {
            return $"Название: {Name}, Владелец: {OwnerName}, Урон: {Damage}, Длина: {_length}";
        }

        public override string TakeDamage(string to)
        {
            if (_bulletsCount > 0)
            {
                _bulletsCount--;
                return $"{OwnerName} выстрелил из {Name} в {to} и нанес(ла) {Damage} урона.";
            }

            return $"{OwnerName} не смог(ла) выстрелить из {Name} в {to}. Нет патронов!";
        }

        public string addBullets(int count)
        {
            _bulletsCount += count;
            return $"{OwnerName} зарядил в {Name} {count} патронов. Текущее количество: {_bulletsCount}";
        }
    }

    public partial class MainForm : Form
    {
        private Weapon _weapon;

        private string damageTextBoxLastText = "0";
        private string lengthTextBoxLastText = "0";
        private string bulletsCountTextBoxLastText = "15";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            weaponTypeBox.Items.Add("Нож");
            weaponTypeBox.Items.Add("Дробовик");
            weaponTypeBox.SelectedIndex = 0;
            damageTextBox.Text = damageTextBoxLastText;
            lengthTextBox.Text = lengthTextBoxLastText;
            bulletsCountTextBox.Text = bulletsCountTextBoxLastText;
        }

        private void PrintToLogs(string msg)
        {
            logsTextBox.Text += msg;
            logsTextBox.Text += '\n';
        }

        private void reloadWeaponBtn_Click(object sender, EventArgs e)
        {
            if (weaponTypeBox.SelectedIndex == 1)
            {
                ShotGun __weapon = new ShotGun(
                    weaponNameTextBox.Text,
                    nameTextBox.Text,
                    double.Parse(damageTextBox.Text),
                    double.Parse(lengthTextBox.Text),
                    int.Parse(bulletsCountTextBox.Text));
                PrintToLogs(__weapon.addBullets(25));
            }
        }

        private void takeDamageBtn_Click(object sender, EventArgs e)
        {
            #region Checks

            if (nameTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Вы не ввели ваше имя.");
                return;
            }

            if (enemyNameTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Вы не ввели имя противника.");
                return;
            }

            if (weaponNameTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Вы не ввели название оружия.");
                return;
            }

            #endregion

            switch (weaponTypeBox.SelectedIndex)
            {
                case 0:
                    _weapon = new Knife(
                        weaponNameTextBox.Text,
                        nameTextBox.Text,
                        double.Parse(damageTextBox.Text),
                        double.Parse(lengthTextBox.Text));
                    break;
                case 1:
                    _weapon = new ShotGun(
                        weaponNameTextBox.Text,
                        nameTextBox.Text,
                        double.Parse(damageTextBox.Text),
                        double.Parse(lengthTextBox.Text),
                        int.Parse(bulletsCountTextBox.Text));
                    break;
            }

            PrintToLogs(_weapon.TakeDamage(enemyNameTextBox.Text));
        }

        private void clearLogsBtn_Click(object sender, EventArgs e)
        {
            logsTextBox.Text = "";
        }

        private void weaponTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (weaponTypeBox.SelectedIndex)
            {
                case 0:
                    label6.Hide();
                    bulletsCountTextBox.Hide();
                    reloadWeaponBtn.Hide();
                    break;
                case 1:
                    label6.Show();
                    bulletsCountTextBox.Show();
                    reloadWeaponBtn.Show();
                    break;
            }
        }

        private void danageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(damageTextBox.Text, out _))
            {
                damageTextBoxLastText = damageTextBox.Text;
            }
            else
            {
                damageTextBox.Text = damageTextBoxLastText;
            }
        }

        private void lenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(lengthTextBox.Text, out _))
            {
                lengthTextBoxLastText = lengthTextBox.Text;
            }
            else
            {
                lengthTextBox.Text = lengthTextBoxLastText;
            }
        }

        private void bulletsCountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(bulletsCountTextBox.Text, out _))
            {
                bulletsCountTextBoxLastText = bulletsCountTextBox.Text;
            }
            else
            {
                bulletsCountTextBox.Text = bulletsCountTextBoxLastText;
            }
        }

        private void weaponNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (weaponNameTextBox.Text.Length > 0)
            {
                damageTextBox.Enabled = true;
                lengthTextBox.Enabled = true;
                bulletsCountTextBox.Enabled = true;
                takeDamageBtn.Enabled = true;
                reloadWeaponBtn.Enabled = true;
            }
            else
            {
                damageTextBox.Enabled = false;
                lengthTextBox.Enabled = false;
                bulletsCountTextBox.Enabled = false;
                takeDamageBtn.Enabled = false;
                reloadWeaponBtn.Enabled = false;
            }
        }
    }
}