namespace LogifyWin
{
    partial class FrmCompany
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
            tbxCompanyName = new TextBox();
            tbxCompanyEmail = new TextBox();
            tbxPcFirstName = new TextBox();
            tbxHourlyRate = new TextBox();
            tbxPhoneNumber = new TextBox();
            tbxEmail = new TextBox();
            tbxSSN = new TextBox();
            tbxLastName = new TextBox();
            lblPrimaryContact = new Label();
            lblCompany = new Label();
            btnClear = new Button();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            lblRolePrimaryContact = new Label();
            SuspendLayout();
            // 
            // tbxCompanyName
            // 
            tbxCompanyName.Location = new Point(50, 52);
            tbxCompanyName.Name = "tbxCompanyName";
            tbxCompanyName.PlaceholderText = "Company Name";
            tbxCompanyName.Size = new Size(100, 23);
            tbxCompanyName.TabIndex = 0;
            // 
            // tbxCompanyEmail
            // 
            tbxCompanyEmail.Location = new Point(50, 95);
            tbxCompanyEmail.Name = "tbxCompanyEmail";
            tbxCompanyEmail.PlaceholderText = "Company Email";
            tbxCompanyEmail.Size = new Size(100, 23);
            tbxCompanyEmail.TabIndex = 1;
            // 
            // tbxPcFirstName
            // 
            tbxPcFirstName.Location = new Point(50, 168);
            tbxPcFirstName.Name = "tbxPcFirstName";
            tbxPcFirstName.PlaceholderText = "FirstName";
            tbxPcFirstName.Size = new Size(100, 23);
            tbxPcFirstName.TabIndex = 2;
            // 
            // tbxHourlyRate
            // 
            tbxHourlyRate.Location = new Point(50, 376);
            tbxHourlyRate.Name = "tbxHourlyRate";
            tbxHourlyRate.PlaceholderText = "Hourly Rate";
            tbxHourlyRate.Size = new Size(100, 23);
            tbxHourlyRate.TabIndex = 3;
            // 
            // tbxPhoneNumber
            // 
            tbxPhoneNumber.Location = new Point(50, 334);
            tbxPhoneNumber.Name = "tbxPhoneNumber";
            tbxPhoneNumber.PlaceholderText = "Phone Number";
            tbxPhoneNumber.Size = new Size(100, 23);
            tbxPhoneNumber.TabIndex = 4;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(50, 289);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.PlaceholderText = "Email";
            tbxEmail.Size = new Size(100, 23);
            tbxEmail.TabIndex = 5;
            // 
            // tbxSSN
            // 
            tbxSSN.Location = new Point(50, 247);
            tbxSSN.Name = "tbxSSN";
            tbxSSN.PlaceholderText = "SSN";
            tbxSSN.Size = new Size(100, 23);
            tbxSSN.TabIndex = 6;
            // 
            // tbxLastName
            // 
            tbxLastName.Location = new Point(50, 209);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.PlaceholderText = "Last Name";
            tbxLastName.Size = new Size(100, 23);
            tbxLastName.TabIndex = 7;
            // 
            // lblPrimaryContact
            // 
            lblPrimaryContact.AutoSize = true;
            lblPrimaryContact.Location = new Point(57, 138);
            lblPrimaryContact.Name = "lblPrimaryContact";
            lblPrimaryContact.Size = new Size(93, 15);
            lblPrimaryContact.TabIndex = 9;
            lblPrimaryContact.Text = "Primary Contact";
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Location = new Point(70, 19);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(59, 15);
            lblCompany.TabIndex = 10;
            lblCompany.Text = "Company";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(669, 414);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(198, 414);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 18;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(489, 414);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Deactivate";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(387, 414);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(291, 414);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblRolePrimaryContact
            // 
            lblRolePrimaryContact.AutoSize = true;
            lblRolePrimaryContact.Location = new Point(50, 414);
            lblRolePrimaryContact.Name = "lblRolePrimaryContact";
            lblRolePrimaryContact.Size = new Size(122, 15);
            lblRolePrimaryContact.TabIndex = 20;
            lblRolePrimaryContact.Text = "Role: Primary Contact";
            // 
            // FrmCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRolePrimaryContact);
            Controls.Add(btnClear);
            Controls.Add(btnCreate);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(lblCompany);
            Controls.Add(lblPrimaryContact);
            Controls.Add(tbxLastName);
            Controls.Add(tbxSSN);
            Controls.Add(tbxEmail);
            Controls.Add(tbxPhoneNumber);
            Controls.Add(tbxHourlyRate);
            Controls.Add(tbxPcFirstName);
            Controls.Add(tbxCompanyEmail);
            Controls.Add(tbxCompanyName);
            Name = "FrmCompany";
            Text = "FrmCompany";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxCompanyName;
        private TextBox tbxCompanyEmail;
        private TextBox tbxPcFirstName;
        private TextBox tbxHourlyRate;
        private TextBox tbxPhoneNumber;
        private TextBox tbxEmail;
        private TextBox tbxSSN;
        private TextBox tbxLastName;
        private Label lblPrimaryContact;
        private Label lblCompany;
        private Button btnClear;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSearch;
        private Label lblRolePrimaryContact;
    }
}