using System;

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
            this.gameTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // gameTypeComboBox
            // 
            this.gameTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameTypeComboBox.FormattingEnabled = true;
            this.gameTypeComboBox.Location = new System.Drawing.Point(19, 40);
            this.gameTypeComboBox.Name = "gameTypeComboBox";
            this.gameTypeComboBox.Size = new System.Drawing.Size(184, 21);
            this.gameTypeComboBox.TabIndex = 0;
            this.gameTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.gameTypeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите тип игры:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(19, 67);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(433, 245);
            this.outputTextBox.TabIndex = 2;
            this.outputTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 331);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameTypeComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Букмекерская контора";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RichTextBox outputTextBox;

        private System.Windows.Forms.ComboBox gameTypeComboBox;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}

