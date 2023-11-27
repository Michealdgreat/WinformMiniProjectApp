

namespace WinformMiniProject
{
    partial class AddressEntry
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
            lastNameText = new TextBox();
            firstNameText = new TextBox();
            CityText = new Label();
            StreeAddressText = new Label();
            StateText = new Label();
            ZipText = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            AdressEntryLabel = new Label();
            saverecord = new Button();
            SuspendLayout();
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(357, 185);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(240, 45);
            lastNameText.TabIndex = 6;
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(357, 112);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(240, 45);
            firstNameText.TabIndex = 5;
           
            // 
            // CityText
            // 
            CityText.AutoSize = true;
            CityText.Location = new Point(270, 188);
            CityText.Name = "CityText";
            CityText.Size = new Size(64, 38);
            CityText.TabIndex = 3;
            CityText.Text = "City";
            // 
            // StreeAddressText
            // 
            StreeAddressText.AutoSize = true;
            StreeAddressText.Location = new Point(138, 112);
            StreeAddressText.Name = "StreeAddressText";
            StreeAddressText.Size = new Size(196, 38);
            StreeAddressText.TabIndex = 4;
            StreeAddressText.Text = "Street Address";
            // 
            // StateText
            // 
            StateText.AutoSize = true;
            StateText.Location = new Point(256, 267);
            StateText.Name = "StateText";
            StateText.Size = new Size(78, 38);
            StateText.TabIndex = 4;
            StateText.Text = "State";
            // 
            // ZipText
            // 
            ZipText.AutoSize = true;
            ZipText.Location = new Point(206, 347);
            ZipText.Name = "ZipText";
            ZipText.Size = new Size(128, 38);
            ZipText.TabIndex = 3;
            ZipText.Text = "Zip Code";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(357, 267);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 45);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(357, 340);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 45);
            textBox2.TabIndex = 6;
            // 
            // AdressEntryLabel
            // 
            AdressEntryLabel.AutoSize = true;
            AdressEntryLabel.Font = new Font("Segoe UI", 16.128F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdressEntryLabel.Location = new Point(357, 47);
            AdressEntryLabel.Name = "AdressEntryLabel";
            AdressEntryLabel.Size = new Size(199, 38);
            AdressEntryLabel.TabIndex = 7;
            AdressEntryLabel.Text = "Address Entry";
            // 
            // saverecord
            // 
            saverecord.Location = new Point(369, 403);
            saverecord.Name = "saverecord";
            saverecord.Size = new Size(98, 63);
            saverecord.TabIndex = 8;
            saverecord.Text = "Save";
            saverecord.UseVisualStyleBackColor = true;
            saverecord.Click += saverecord_Click;
            // 
            // AddressEntry
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 518);
            Controls.Add(saverecord);
            Controls.Add(AdressEntryLabel);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lastNameText);
            Controls.Add(ZipText);
            Controls.Add(firstNameText);
            Controls.Add(StateText);
            Controls.Add(CityText);
            Controls.Add(StreeAddressText);
            Font = new Font("Segoe UI", 16.128F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "AddressEntry";
            Text = "Address Entry Form By Micheal Shodamola";
            ResumeLayout(false);
            PerformLayout();
        }

        private void saverecord_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox lastNameText;
        private TextBox firstNameText;
        private Label CityText;
        private Label StreeAddressText;
        private Label StateText;
        private Label ZipText;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label AdressEntryLabel;
        private Button saverecord;
    }
}