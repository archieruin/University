namespace Lab_2_1
{
    partial class Form1
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
            System.Windows.Forms.Button addSwimmerButton;
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.addSwimmerGroupBox = new System.Windows.Forms.GroupBox();
            this.swimmersListRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateTracksButton = new System.Windows.Forms.Button();
            this.QualifyingContestTextBox = new System.Windows.Forms.RichTextBox();
            this.FinalContestTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            addSwimmerButton = new System.Windows.Forms.Button();
            this.addSwimmerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addSwimmerButton
            // 
            addSwimmerButton.Location = new System.Drawing.Point(7, 187);
            addSwimmerButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            addSwimmerButton.Name = "addSwimmerButton";
            addSwimmerButton.Size = new System.Drawing.Size(215, 33);
            addSwimmerButton.TabIndex = 3;
            addSwimmerButton.Text = "Add";
            addSwimmerButton.UseVisualStyleBackColor = true;
            addSwimmerButton.Click += new System.EventHandler(this.addSwimmerButton_Click);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.Location = new System.Drawing.Point(7, 24);
            this.fullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(119, 23);
            this.fullNameLabel.TabIndex = 3;
            this.fullNameLabel.Text = "ФИО:";
            this.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(7, 157);
            this.ratingTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(213, 23);
            this.ratingTextBox.TabIndex = 2;
            // 
            // ageLabel
            // 
            this.ageLabel.Location = new System.Drawing.Point(7, 77);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(119, 23);
            this.ageLabel.TabIndex = 3;
            this.ageLabel.Text = "Возраст:";
            this.ageLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(7, 104);
            this.ageTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(213, 23);
            this.ageTextBox.TabIndex = 1;
            // 
            // ratingLabel
            // 
            this.ratingLabel.Location = new System.Drawing.Point(7, 130);
            this.ratingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(119, 23);
            this.ratingLabel.TabIndex = 3;
            this.ratingLabel.Text = "Место в рейтинге:";
            this.ratingLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(7, 51);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(213, 23);
            this.fullNameTextBox.TabIndex = 0;
            // 
            // addSwimmerGroupBox
            // 
            this.addSwimmerGroupBox.Controls.Add(this.fullNameTextBox);
            this.addSwimmerGroupBox.Controls.Add(this.ageTextBox);
            this.addSwimmerGroupBox.Controls.Add(this.ratingTextBox);
            this.addSwimmerGroupBox.Controls.Add(this.fullNameLabel);
            this.addSwimmerGroupBox.Controls.Add(this.ageLabel);
            this.addSwimmerGroupBox.Controls.Add(this.ratingLabel);
            this.addSwimmerGroupBox.Controls.Add(addSwimmerButton);
            this.addSwimmerGroupBox.Location = new System.Drawing.Point(14, 14);
            this.addSwimmerGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addSwimmerGroupBox.Name = "addSwimmerGroupBox";
            this.addSwimmerGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addSwimmerGroupBox.Size = new System.Drawing.Size(229, 239);
            this.addSwimmerGroupBox.TabIndex = 1;
            this.addSwimmerGroupBox.TabStop = false;
            this.addSwimmerGroupBox.Text = "Добавить Плавца";
            // 
            // swimmersListRichTextBox
            // 
            this.swimmersListRichTextBox.Location = new System.Drawing.Point(271, 36);
            this.swimmersListRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.swimmersListRichTextBox.Name = "swimmersListRichTextBox";
            this.swimmersListRichTextBox.Size = new System.Drawing.Size(569, 168);
            this.swimmersListRichTextBox.TabIndex = 5;
            this.swimmersListRichTextBox.TabStop = false;
            this.swimmersListRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(271, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Список Плавцов:";
            // 
            // calculateTracksButton
            // 
            this.calculateTracksButton.Location = new System.Drawing.Point(271, 211);
            this.calculateTracksButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.calculateTracksButton.Name = "calculateTracksButton";
            this.calculateTracksButton.Size = new System.Drawing.Size(295, 32);
            this.calculateTracksButton.TabIndex = 4;
            this.calculateTracksButton.Text = "Рассчитать дорожки";
            this.calculateTracksButton.UseVisualStyleBackColor = true;
            this.calculateTracksButton.Click += new System.EventHandler(this.calculateTracksButton_Click);
            // 
            // QualifyingContestTextBox
            // 
            this.QualifyingContestTextBox.Enabled = false;
            this.QualifyingContestTextBox.Location = new System.Drawing.Point(271, 295);
            this.QualifyingContestTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.QualifyingContestTextBox.Name = "QualifyingContestTextBox";
            this.QualifyingContestTextBox.Size = new System.Drawing.Size(569, 168);
            this.QualifyingContestTextBox.TabIndex = 5;
            this.QualifyingContestTextBox.Text = "";
            this.QualifyingContestTextBox.Click += new System.EventHandler(this.calculateTracksButton_Click);
            // 
            // FinalContestTextBox
            // 
            this.FinalContestTextBox.Enabled = false;
            this.FinalContestTextBox.Location = new System.Drawing.Point(271, 510);
            this.FinalContestTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FinalContestTextBox.Name = "FinalContestTextBox";
            this.FinalContestTextBox.Size = new System.Drawing.Size(569, 168);
            this.FinalContestTextBox.TabIndex = 5;
            this.FinalContestTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(271, 273);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Отборочные Состязания:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(271, 488);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Финальные Состязания:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(713, 211);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(127, 32);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 688);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateTracksButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FinalContestTextBox);
            this.Controls.Add(this.QualifyingContestTextBox);
            this.Controls.Add(this.swimmersListRichTextBox);
            this.Controls.Add(this.addSwimmerGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "FactoryMethod";
            this.addSwimmerGroupBox.ResumeLayout(false);
            this.addSwimmerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button clearButton;

        public System.Windows.Forms.RichTextBox FinalContestTextBox;
        public System.Windows.Forms.RichTextBox QualifyingContestTextBox;

        private System.Windows.Forms.Button calculateTracksButton;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        public System.Windows.Forms.RichTextBox swimmersListRichTextBox;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.GroupBox addSwimmerGroupBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label ageLabel;

        #endregion
    }
}