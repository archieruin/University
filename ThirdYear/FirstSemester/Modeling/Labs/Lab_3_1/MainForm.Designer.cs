using Microsoft.Win32;

namespace Lab_3_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.chooseCuisineBox = new System.Windows.Forms.ComboBox();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chooseEatBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите кухню:";
            // 
            // chooseCuisineBox
            // 
            this.chooseCuisineBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseCuisineBox.FormattingEnabled = true;
            this.chooseCuisineBox.Location = new System.Drawing.Point(18, 33);
            this.chooseCuisineBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.chooseCuisineBox.Name = "chooseCuisineBox";
            this.chooseCuisineBox.Size = new System.Drawing.Size(265, 21);
            this.chooseCuisineBox.TabIndex = 1;
            this.chooseCuisineBox.SelectedIndexChanged += new System.EventHandler(this.chooseCuisineBox_SelectedIndexChanged);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(18, 142);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(265, 268);
            this.resultTextBox.TabIndex = 2;
            this.resultTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(15, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Выберите блюдо:";
            // 
            // chooseEatBox
            // 
            this.chooseEatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseEatBox.Enabled = false;
            this.chooseEatBox.FormattingEnabled = true;
            this.chooseEatBox.Location = new System.Drawing.Point(18, 87);
            this.chooseEatBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.chooseEatBox.Name = "chooseEatBox";
            this.chooseEatBox.Size = new System.Drawing.Size(265, 21);
            this.chooseEatBox.TabIndex = 1; 
            this.chooseEatBox.SelectedIndexChanged += new System.EventHandler(this.chooseEatBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 428);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.chooseEatBox);
            this.Controls.Add(this.chooseCuisineBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "Меню";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox chooseEatBox;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.ComboBox chooseCuisineBox;
        private System.Windows.Forms.RichTextBox resultTextBox;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}