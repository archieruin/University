using System;

namespace Lab_4_1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.yLabel = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 189);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 346);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите что рисовать:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 45);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(350, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(27, 113);
            this.xTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 20, 20);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(63, 23);
            this.xTextBox.TabIndex = 3;
            this.xTextBox.TextChanged += new System.EventHandler(this.xTextBox_TextChanged);
            // 
            // xLabel
            // 
            this.xLabel.Location = new System.Drawing.Point(27, 93);
            this.xLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(64, 16);
            this.xLabel.TabIndex = 4;
            this.xLabel.Text = "X";
            this.xLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(114, 113);
            this.yTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 20, 20);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(63, 23);
            this.yTextBox.TabIndex = 3;
            this.yTextBox.TextChanged += new System.EventHandler(this.yTextBox_TextChanged);
            // 
            // yLabel
            // 
            this.yLabel.Location = new System.Drawing.Point(114, 93);
            this.yLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(64, 16);
            this.yLabel.TabIndex = 4;
            this.yLabel.Text = "Y";
            this.yLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(201, 113);
            this.aTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 20, 20);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(63, 23);
            this.aTextBox.TabIndex = 3;
            this.aTextBox.TextChanged += new System.EventHandler(this.aTextBox_TextChanged);
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(288, 113);
            this.bTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 20, 20);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(63, 23);
            this.bTextBox.TabIndex = 3;
            this.bTextBox.TextChanged += new System.EventHandler(this.bTextBox_TextChanged);
            // 
            // aLabel
            // 
            this.aLabel.Location = new System.Drawing.Point(201, 93);
            this.aLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(64, 16);
            this.aLabel.TabIndex = 4;
            this.aLabel.Text = "Width";
            this.aLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bLabel
            // 
            this.bLabel.Location = new System.Drawing.Point(288, 93);
            this.bLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(64, 16);
            this.bLabel.TabIndex = 4;
            this.bLabel.Text = "Height";
            this.bLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(27, 160);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(169, 23);
            this.drawButton.TabIndex = 5;
            this.drawButton.Text = "Нарисовать";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 561);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(23);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.TextBox yTextBox;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion

        private System.Windows.Forms.Button drawButton;
    }
}