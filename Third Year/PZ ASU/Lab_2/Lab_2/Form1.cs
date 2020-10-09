using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            comboBox1.Items.Add("Ничего, 0 грн.");
            comboBox1.Items.Add("Борщ, 30.0 грн.");
            comboBox1.Items.Add("Куриный суп, 25.0 грн.");
            comboBox1.Items.Add("Гороховый суп, 40.0 грн.");
            comboBox1.SelectedIndex = 0;
            
            comboBox2.Items.Add("Ничего, 0 грн.");
            comboBox2.Items.Add("Гречка с котлетой, 15.0 грн.");
            comboBox2.Items.Add("Рис с овощами, 25.50 грн.");
            comboBox2.Items.Add("Макароны с сыром, 35.25 грн.");
            comboBox2.SelectedIndex = 0;
            
            comboBox3.Items.Add("Ничего, 0 грн.");
            comboBox3.Items.Add("Компот с булкой, 10.0 грн.");
            comboBox3.Items.Add("Молоко с печеньем, 12.0 грн.");
            comboBox3.Items.Add("Колла с пиццей, 16.99 грн.");
            comboBox3.SelectedIndex = 0;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 0)
            {
                MessageBox.Show("Вы не выбрали ни одного блюда", "Ошибка");
            }
            else
            {
                string receiptText = $"Первое: {comboBox1.Text}\r\n";
                if (checkBox1.Checked) receiptText += "(Большая порция)\r\n";
                
                receiptText += $"Второе: {comboBox2.Text}\r\n";
                if (checkBox2.Checked) receiptText += "(Большая порция)\r\n";
                
                receiptText += $"Третье: {comboBox3.Text}\r\n";
                if (checkBox3.Checked) receiptText += "(Большая порция)\r\n";

                if (textBox1.TextLength > 0)
                {
                    receiptText += "\r\n\r\n";
                    receiptText += $"Комментарий к заказу:\r\n{textBox1.Text}";
                }
                
                receiptText += "\r\n\r\n";
                receiptText += "Способ доставки: ";
                if (radioButton1.Checked) receiptText += "На месте";
                else if (radioButton2.Checked) receiptText += "Самовывоз";
                else if (radioButton3.Checked) receiptText += "Доставка";
                
                ReceiptForm receiptForm = new ReceiptForm(this, receiptText);
                receiptForm.Show();
                Hide();
            }
        }
    }
}
