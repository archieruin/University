using System;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        Found found;
        Derived derived;

        class Found
        {
            protected string name;
            protected int credit;
            protected static int count;
            public Found()
            {
                name = "Artur Boyun";
                credit = 0;
                count++;
            }
            //public Found(string name, int credit) 
            //{
            //  this.name = name;
            //  this.credit = credit;
            //  count++;

            //}
            public Found(string n, int c)
            {
                this.name = n;
                this.credit = c;
                count++;
            }

            public override string ToString()
            {
                string s = "Поля : name = {0}, credit = {1}";
                return String.Format(s, name, credit);
            }

            public virtual string Virt()
            {
                return "Found: " + this.ToString();
            }

            public virtual string NonVirt()
            {
                return "Found: " + this.ToString();
            }

            public virtual string Parse()
            {
                return "Выполнен разбор кода: " + this.ToString();
            }

            public virtual string Job()
            {
                string res = "";
                res += "VirtMethod: " + Virt() + "\r\n";
                res += "NonVirtMethod: " + NonVirt() + "\r\n";
                res += "ParseMethod: " + Parse() + "\r\n";
                return res;
            }

            public static string NumberOfObjects()
            {
                return "Создано обектов класса Found: " + count;
            }
        }

        class Derived : Found
        {
            protected double debit;
            new protected double credit;

            public Derived () : base()
            {
                credit = 1.5;
                debit = 0.0;
            }

            public Derived (string name, double debit, double credit): base(name, (int)credit)
            {
                this.debit = debit;
                this.credit = credit;
            }

            public string MyBaseCredit()
            {
                return base.credit.ToString();
            }
            new public string Parse()
            {
                string res = base.Parse();
                res += "Выполнена проверка кода";
                return res;
            }
            public override string ToString()
            {
                string s = "Поля : name = {0}, BaseCredit = {1}, credit = {2}, debit = {3}";
                return String.Format(s, name, base.credit, credit, debit);
            }
        }

        public Form1()
        {
            found = new Found();
            derived = new Derived();

            InitializeComponent();
        }

        private void createObject1_Click(object sender, EventArgs e)
        {
            string name = nameTextBox1.Text;
            int credit = 0;
            try
            {
                credit = int.Parse(creditTextBox1.Text);
            }
            catch (Exception)
            {
                creditTextBox1.Text = "Введите число!";
            }
            if (name != "")
                found = new Found(name, credit);
            nameTextBox1.Text = "Объект класса Found успешно создан.";
        }

        private void buttonVrt1_Click(object sender, EventArgs e)
        {
            string res = found.Virt();
            textBoxRes1.Text = res;
        }

        private void buttonNonVirt_Click(object sender, EventArgs e)
        {
            string res = found.NonVirt();
            textBoxRes1.Text = res;
        }

        private void buttonToString1_Click(object sender, EventArgs e)
        {
            string res = found.ToString();
            textBoxRes1.Text = res;
        }

        private void buttonParse1_Click(object sender, EventArgs e)
        {
            string res = found.Parse();
            textBoxRes1.Text = res;
        }

        private void buttonJob1_Click(object sender, EventArgs e)
        {
            string res = found.Job();
            textBoxRes1.Text = res;
        }

        private void buttonNumber1_Click(object sender, EventArgs e)
        {
            string res = Found.NumberOfObjects();
            textBoxRes1.Text = res;
        }

        private void createObject2_Click(object sender, EventArgs e)
        {
            string name = nameTextBox2.Text;
            double debit = 0;
            double credit = 0;
            try
            {
                debit = int.Parse(debitTextBox2.Text);
            }
            catch (Exception)
            {
                debitTextBox2.Text = "Введите число!";
            }
            try
            {
                credit = int.Parse(creditTextBox2.Text);
            }
            catch (Exception)
            {
                creditTextBox2.Text = "Введите число!";
            }
            if (name != "")
                derived = new Derived(name, debit, credit);
            nameTextBox2.Text = "Объект класса Derived успешно создан.";
        }

        private void buttonVrt2_Click(object sender, EventArgs e)
        {
            string res = derived.Virt();
            textBoxRes2.Text = res;
        }

        private void buttonNonVirt2_Click(object sender, EventArgs e)
        {
            string res = derived.NonVirt();
            textBoxRes2.Text = res;
        }

        private void buttonToString2_Click(object sender, EventArgs e)
        {
            string res = derived.ToString();
            textBoxRes2.Text = res;
        }

        private void buttonParse2_Click(object sender, EventArgs e)
        {
            string res = derived.Parse();
            textBoxRes2.Text = res;
        }

        private void buttonJob2_Click(object sender, EventArgs e)
        {
            string res = derived.Job();
            textBoxRes2.Text = res;
        }

        private void buttonNumber2_Click(object sender, EventArgs e)
        {
            string res = Derived.NumberOfObjects();
            textBoxRes2.Text = res;
        }
    }
}
