namespace Lab_2_2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceInfoLabel = new System.Windows.Forms.Label();
            this.chooseGameLabel = new System.Windows.Forms.Label();
            this.chooseGameBox = new System.Windows.Forms.ComboBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // balanceLabel
            // 
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.balanceLabel.Location = new System.Drawing.Point(12, 22);
            this.balanceLabel.Margin = new System.Windows.Forms.Padding(4, 12, 0, 0);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(54, 17);
            this.balanceLabel.TabIndex = 0;
            this.balanceLabel.Text = "Баланс:";
            // 
            // balanceInfoLabel
            // 
            this.balanceInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balanceInfoLabel.Location = new System.Drawing.Point(66, 22);
            this.balanceInfoLabel.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.balanceInfoLabel.Name = "balanceInfoLabel";
            this.balanceInfoLabel.Size = new System.Drawing.Size(111, 17);
            this.balanceInfoLabel.TabIndex = 0;
            this.balanceInfoLabel.Text = "0 грн.";
            // 
            // chooseGameLabel
            // 
            this.chooseGameLabel.Location = new System.Drawing.Point(12, 50);
            this.chooseGameLabel.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.chooseGameLabel.Name = "chooseGameLabel";
            this.chooseGameLabel.Size = new System.Drawing.Size(117, 18);
            this.chooseGameLabel.TabIndex = 1;
            this.chooseGameLabel.Text = "Выберите игру:";
            // 
            // chooseGameBox
            // 
            this.chooseGameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseGameBox.FormattingEnabled = true;
            this.chooseGameBox.Location = new System.Drawing.Point(12, 71);
            this.chooseGameBox.Name = "chooseGameBox";
            this.chooseGameBox.Size = new System.Drawing.Size(275, 23);
            this.chooseGameBox.TabIndex = 2;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(109, 109);
            this.enterButton.Margin = new System.Windows.Forms.Padding(100, 12, 100, 3);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(81, 22);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 375);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.chooseGameBox);
            this.Controls.Add(this.chooseGameLabel);
            this.Controls.Add(this.balanceInfoLabel);
            this.Controls.Add(this.balanceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Букмекерская контора";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label chooseGameLabel;

        private System.Windows.Forms.Label balanceInfoLabel;

        private System.Windows.Forms.Label balanceLabel;

        #endregion

        private System.Windows.Forms.ComboBox chooseGameBox;
        private System.Windows.Forms.Button enterButton;
    }
}

