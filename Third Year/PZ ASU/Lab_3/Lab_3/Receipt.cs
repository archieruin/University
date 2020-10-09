using System;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class ReceiptForm : Form
    {
        private Form _previousForm;
        public ReceiptForm(Form previousForm, string receiptText)
        {
            InitializeComponent();
            _previousForm = previousForm;
            receiptTextBox.Text = receiptText;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            _previousForm.Close();
            Close();
        }
    }
}