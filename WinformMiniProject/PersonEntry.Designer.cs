
namespace WinformMiniProject
{
    partial class PersonEntry
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FirstNameLabel = new Label();
            firstNameText = new TextBox();
            lastNameLabel = new Label();
            lastNameText = new TextBox();
            isActive = new CheckBox();
            ActiveLabel = new Label();
            addressesList = new ListBox();
            addressListLabel = new Label();
            addNewAddress = new Button();
            saverecord = new Button();
            SuspendLayout();
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(173, 117);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(166, 42);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "First Name";
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(359, 114);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(240, 49);
            firstNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(173, 190);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(163, 42);
            lastNameLabel.TabIndex = 0;
            lastNameLabel.Text = "Last Name";
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(359, 187);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(240, 49);
            lastNameText.TabIndex = 2;
            // 
            // isActive
            // 
            isActive.AutoSize = true;
            isActive.Location = new Point(368, 277);
            isActive.Name = "isActive";
            isActive.Size = new Size(18, 17);
            isActive.TabIndex = 3;
            isActive.UseVisualStyleBackColor = true;
            // 
            // ActiveLabel
            // 
            ActiveLabel.AutoSize = true;
            ActiveLabel.Location = new Point(182, 263);
            ActiveLabel.Name = "ActiveLabel";
            ActiveLabel.Size = new Size(102, 42);
            ActiveLabel.TabIndex = 0;
            ActiveLabel.Text = "Active";
            // 
            // addressesList
            // 
            addressesList.Font = new Font("Segoe UI", 10.9439993F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressesList.FormattingEnabled = true;
            addressesList.ItemHeight = 25;
            addressesList.Location = new Point(182, 463);
            addressesList.Name = "addressesList";
            addressesList.Size = new Size(435, 279);
            addressesList.TabIndex = 3;
            addressesList.SelectedIndexChanged += addressesList_SelectedIndexChanged;
            // 
            // addressListLabel
            // 
            addressListLabel.AutoSize = true;
            addressListLabel.Location = new Point(180, 418);
            addressListLabel.Name = "addressListLabel";
            addressListLabel.Size = new Size(156, 42);
            addressListLabel.TabIndex = 0;
            addressListLabel.Text = "Addresses";
            // 
            // addNewAddress
            // 
            addNewAddress.Location = new Point(321, 340);
            addNewAddress.Name = "addNewAddress";
            addNewAddress.Size = new Size(106, 52);
            addNewAddress.TabIndex = 4;
            addNewAddress.Text = "Add";
            addNewAddress.UseVisualStyleBackColor = true;
            addNewAddress.Click += addNewAddress_Click;
            // 
            // saverecord
            // 
            saverecord.Location = new Point(338, 808);
            saverecord.Name = "saverecord";
            saverecord.Size = new Size(98, 63);
            saverecord.TabIndex = 5;
            saverecord.Text = "Save";
            saverecord.UseVisualStyleBackColor = true;
            saverecord.Click += Saverecord_Click;
            // 
            // PersonEntry
            // 
            AutoScaleDimensions = new SizeF(17F, 42F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 900);
            Controls.Add(saverecord);
            Controls.Add(addNewAddress);
            Controls.Add(addressesList);
            Controls.Add(isActive);
            Controls.Add(lastNameText);
            Controls.Add(firstNameText);
            Controls.Add(ActiveLabel);
            Controls.Add(addressListLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(FirstNameLabel);
            Font = new Font("Segoe UI", 17.855999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "PersonEntry";
            Text = "Person Entry Form By Micheal Shodamola";
            ResumeLayout(false);
            PerformLayout();
        }

        private void addressesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Label FirstNameLabel;
        private TextBox firstNameText;
        private Label lastNameLabel;
        private TextBox lastNameText;
        private CheckBox isActive;
        private Label ActiveLabel;
        private ListBox addressesList;
        private Label addressListLabel;
        private Button addNewAddress;
        private Button saverecord;
    }
}
