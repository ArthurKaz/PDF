namespace PDF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.button1 = new System.Windows.Forms.Button();
            this.ModuleTypeComboBox = new System.Windows.Forms.ComboBox();
            this.BatteryStorageComboBox = new System.Windows.Forms.ComboBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Street = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modulePrice = new System.Windows.Forms.Label();
            this.batteryPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate a pdf document";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModuleTypeComboBox
            // 
            this.ModuleTypeComboBox.DisplayMember = "1";
            this.ModuleTypeComboBox.FormattingEnabled = true;
            this.ModuleTypeComboBox.Items.AddRange(new object[] {
            "Jinko Solar",
            "Phono Solar",
            "Heckert Solar"});
            this.ModuleTypeComboBox.Location = new System.Drawing.Point(407, 114);
            this.ModuleTypeComboBox.Name = "ModuleTypeComboBox";
            this.ModuleTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.ModuleTypeComboBox.TabIndex = 1;
            this.ModuleTypeComboBox.Tag = "";
            this.ModuleTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ModuleTypeComboBox_SelectedIndexChanged);
            // 
            // BatteryStorageComboBox
            // 
            this.BatteryStorageComboBox.FormattingEnabled = true;
            this.BatteryStorageComboBox.Items.AddRange(new object[] {
            "5 kWh",
            "10 kWh",
            "15 kWh"});
            this.BatteryStorageComboBox.Location = new System.Drawing.Point(407, 174);
            this.BatteryStorageComboBox.Name = "BatteryStorageComboBox";
            this.BatteryStorageComboBox.Size = new System.Drawing.Size(121, 24);
            this.BatteryStorageComboBox.TabIndex = 2;
            this.BatteryStorageComboBox.SelectedIndexChanged += new System.EventHandler(this.BatteryStorageComboBox_SelectedIndexChanged);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(71, 47);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(173, 22);
            this.Name.TabIndex = 3;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(71, 90);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(173, 22);
            this.Surname.TabIndex = 4;
            // 
            // Street
            // 
            this.Street.Location = new System.Drawing.Point(71, 136);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(173, 22);
            this.Street.TabIndex = 5;
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(71, 180);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(173, 22);
            this.City.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Street";
            // 
            // modulePrice
            // 
            this.modulePrice.AutoSize = true;
            this.modulePrice.Location = new System.Drawing.Point(415, 142);
            this.modulePrice.Name = "modulePrice";
            this.modulePrice.Size = new System.Drawing.Size(38, 16);
            this.modulePrice.TabIndex = 11;
            this.modulePrice.Text = "1.000";
            // 
            // batteryPrice
            // 
            this.batteryPrice.AutoSize = true;
            this.batteryPrice.Location = new System.Drawing.Point(415, 201);
            this.batteryPrice.Name = "batteryPrice";
            this.batteryPrice.Size = new System.Drawing.Size(38, 16);
            this.batteryPrice.TabIndex = 12;
            this.batteryPrice.Text = "1.000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 435);
            this.Controls.Add(this.batteryPrice);
            this.Controls.Add(this.modulePrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Street);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.BatteryStorageComboBox);
            this.Controls.Add(this.ModuleTypeComboBox);
            this.Controls.Add(this.button1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ModuleTypeComboBox;
        private System.Windows.Forms.ComboBox BatteryStorageComboBox;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Street;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label modulePrice;
        private System.Windows.Forms.Label batteryPrice;
    }
}

