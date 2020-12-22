namespace Lab_3_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.carTypeBox = new System.Windows.Forms.ComboBox();
            this.tiresTypeBox = new System.Windows.Forms.ComboBox();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите ваш тип автомобиля:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Выберите тип шин:";
            // 
            // carTypeBox
            // 
            this.carTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carTypeBox.FormattingEnabled = true;
            this.carTypeBox.Location = new System.Drawing.Point(23, 42);
            this.carTypeBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.carTypeBox.Name = "carTypeBox";
            this.carTypeBox.Size = new System.Drawing.Size(270, 21);
            this.carTypeBox.TabIndex = 1;
            this.carTypeBox.SelectedIndexChanged += new System.EventHandler(this.carTypeBox_SelectedIndexChanged);
            // 
            // tiresTypeBox
            // 
            this.tiresTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tiresTypeBox.FormattingEnabled = true;
            this.tiresTypeBox.Location = new System.Drawing.Point(23, 105);
            this.tiresTypeBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.tiresTypeBox.Name = "tiresTypeBox";
            this.tiresTypeBox.Size = new System.Drawing.Size(270, 21);
            this.tiresTypeBox.TabIndex = 1;
            this.tiresTypeBox.SelectedIndexChanged += new System.EventHandler(this.tiresTypeBox_SelectedIndexChanged);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(23, 173);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(270, 232);
            this.resultTextBox.TabIndex = 2;
            this.resultTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(23, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Информация:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 428);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.tiresTypeBox);
            this.Controls.Add(this.carTypeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Шиномонтаж";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox carTypeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.ComboBox tiresTypeBox;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}