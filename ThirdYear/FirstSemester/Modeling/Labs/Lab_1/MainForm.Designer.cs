namespace Lab_1
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.weaponNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.weaponTypeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.damageTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bulletsCountTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.logsTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.takeDamageBtn = new System.Windows.Forms.Button();
            this.reloadWeaponBtn = new System.Windows.Forms.Button();
            this.clearLogsBtn = new System.Windows.Forms.Button();
            this.enemyNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 36);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(143, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ваше имя";
            // 
            // weaponNameTextBox
            // 
            this.weaponNameTextBox.Location = new System.Drawing.Point(12, 187);
            this.weaponNameTextBox.Name = "weaponNameTextBox";
            this.weaponNameTextBox.Size = new System.Drawing.Size(143, 20);
            this.weaponNameTextBox.TabIndex = 3;
            this.weaponNameTextBox.TextChanged += new System.EventHandler(this.weaponNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название оружия";
            // 
            // weaponTypeBox
            // 
            this.weaponTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weaponTypeBox.FormattingEnabled = true;
            this.weaponTypeBox.Location = new System.Drawing.Point(12, 136);
            this.weaponTypeBox.Name = "weaponTypeBox";
            this.weaponTypeBox.Size = new System.Drawing.Size(143, 21);
            this.weaponTypeBox.TabIndex = 2;
            this.weaponTypeBox.SelectedIndexChanged += new System.EventHandler(this.weaponTypeBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Выберите тип оружия";
            // 
            // damageTextBox
            // 
            this.damageTextBox.Enabled = false;
            this.damageTextBox.Location = new System.Drawing.Point(12, 237);
            this.damageTextBox.Name = "damageTextBox";
            this.damageTextBox.Size = new System.Drawing.Size(143, 20);
            this.damageTextBox.TabIndex = 4;
            this.damageTextBox.TextChanged += new System.EventHandler(this.danageTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 14);
            this.label4.TabIndex = 99;
            this.label4.Text = "Урон";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Enabled = false;
            this.lengthTextBox.Location = new System.Drawing.Point(12, 287);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(143, 20);
            this.lengthTextBox.TabIndex = 5;
            this.lengthTextBox.TextChanged += new System.EventHandler(this.lenghtTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 14);
            this.label5.TabIndex = 99;
            this.label5.Text = "Длина";
            // 
            // bulletsCountTextBox
            // 
            this.bulletsCountTextBox.Enabled = false;
            this.bulletsCountTextBox.Location = new System.Drawing.Point(12, 337);
            this.bulletsCountTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.bulletsCountTextBox.Name = "bulletsCountTextBox";
            this.bulletsCountTextBox.Size = new System.Drawing.Size(143, 20);
            this.bulletsCountTextBox.TabIndex = 6;
            this.bulletsCountTextBox.TextChanged += new System.EventHandler(this.bulletsCountTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 320);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 14);
            this.label6.TabIndex = 99;
            this.label6.Text = "Количество патронов";
            // 
            // logsTextBox
            // 
            this.logsTextBox.Location = new System.Drawing.Point(188, 36);
            this.logsTextBox.Margin = new System.Windows.Forms.Padding(30, 0, 3, 8);
            this.logsTextBox.Name = "logsTextBox";
            this.logsTextBox.Size = new System.Drawing.Size(226, 271);
            this.logsTextBox.TabIndex = 99;
            this.logsTextBox.Text = "";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(188, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 14);
            this.label7.TabIndex = 1;
            this.label7.Text = "Logs";
            // 
            // takeDamageBtn
            // 
            this.takeDamageBtn.Enabled = false;
            this.takeDamageBtn.Location = new System.Drawing.Point(188, 318);
            this.takeDamageBtn.Name = "takeDamageBtn";
            this.takeDamageBtn.Size = new System.Drawing.Size(138, 23);
            this.takeDamageBtn.TabIndex = 7;
            this.takeDamageBtn.Text = "Нанести Урон";
            this.takeDamageBtn.UseVisualStyleBackColor = true;
            this.takeDamageBtn.Click += new System.EventHandler(this.takeDamageBtn_Click);
            // 
            // reloadWeaponBtn
            // 
            this.reloadWeaponBtn.Enabled = false;
            this.reloadWeaponBtn.Location = new System.Drawing.Point(188, 347);
            this.reloadWeaponBtn.Name = "reloadWeaponBtn";
            this.reloadWeaponBtn.Size = new System.Drawing.Size(138, 23);
            this.reloadWeaponBtn.TabIndex = 9;
            this.reloadWeaponBtn.Text = "Перезарядить";
            this.reloadWeaponBtn.UseVisualStyleBackColor = true;
            this.reloadWeaponBtn.Click += new System.EventHandler(this.reloadWeaponBtn_Click);
            // 
            // clearLogsBtn
            // 
            this.clearLogsBtn.Location = new System.Drawing.Point(343, 318);
            this.clearLogsBtn.Name = "clearLogsBtn";
            this.clearLogsBtn.Size = new System.Drawing.Size(71, 23);
            this.clearLogsBtn.TabIndex = 8;
            this.clearLogsBtn.Text = "Очистить";
            this.clearLogsBtn.UseVisualStyleBackColor = true;
            this.clearLogsBtn.Click += new System.EventHandler(this.clearLogsBtn_Click);
            // 
            // enemyNameTextBox
            // 
            this.enemyNameTextBox.Location = new System.Drawing.Point(12, 86);
            this.enemyNameTextBox.Name = "enemyNameTextBox";
            this.enemyNameTextBox.Size = new System.Drawing.Size(143, 20);
            this.enemyNameTextBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 14);
            this.label8.TabIndex = 1;
            this.label8.Text = "Имя противника";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 382);
            this.Controls.Add(this.clearLogsBtn);
            this.Controls.Add(this.reloadWeaponBtn);
            this.Controls.Add(this.takeDamageBtn);
            this.Controls.Add(this.logsTextBox);
            this.Controls.Add(this.weaponTypeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bulletsCountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.damageTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.enemyNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.weaponNameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Name = "MainForm";
            this.Text = "Weapons";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox enemyNameTextBox;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Button clearLogsBtn;

        private System.Windows.Forms.Button takeDamageBtn;
        private System.Windows.Forms.Button reloadWeaponBtn;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox logsTextBox;
        private System.Windows.Forms.TextBox bulletsCountTextBox;

        private System.Windows.Forms.ComboBox weaponTypeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox damageTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox weaponNameTextBox;

        #endregion
    }
}

