namespace LogifyWin
{
    partial class FrmEmployee
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
            btnSearch = new Button();
            tbxFirstName = new TextBox();
            tbxLastName = new TextBox();
            tbxSSN = new TextBox();
            tbxEmail = new TextBox();
            tbxPhoneNumber = new TextBox();
            tbxHourlyRate = new TextBox();
            dtpDateHired = new DateTimePicker();
            cbRoleNames = new ComboBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCreate = new Button();
            btnClear = new Button();
            btnClose = new Button();
            btnLogin = new Button();
            cbCompanyNames = new ComboBox();
            lblCompanyName = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblSSN = new Label();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblHourlyRate = new Label();
            lblHireDate = new Label();
            lblRole = new Label();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(141, 416);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Location = new Point(48, 76);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.PlaceholderText = "Jon";
            tbxFirstName.Size = new Size(100, 23);
            tbxFirstName.TabIndex = 6;
            // 
            // tbxLastName
            // 
            tbxLastName.Location = new Point(48, 120);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.PlaceholderText = "Doe";
            tbxLastName.Size = new Size(100, 23);
            tbxLastName.TabIndex = 7;
            // 
            // tbxSSN
            // 
            tbxSSN.Location = new Point(48, 163);
            tbxSSN.Name = "tbxSSN";
            tbxSSN.PlaceholderText = "555-55-5555";
            tbxSSN.Size = new Size(100, 23);
            tbxSSN.TabIndex = 8;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(48, 207);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.PlaceholderText = "email@email.com";
            tbxEmail.Size = new Size(193, 23);
            tbxEmail.TabIndex = 9;
            // 
            // tbxPhoneNumber
            // 
            tbxPhoneNumber.Location = new Point(48, 255);
            tbxPhoneNumber.Name = "tbxPhoneNumber";
            tbxPhoneNumber.PlaceholderText = "555-555-5555";
            tbxPhoneNumber.Size = new Size(100, 23);
            tbxPhoneNumber.TabIndex = 10;
            // 
            // tbxHourlyRate
            // 
            tbxHourlyRate.Location = new Point(48, 299);
            tbxHourlyRate.Name = "tbxHourlyRate";
            tbxHourlyRate.PlaceholderText = "Hourly Rate";
            tbxHourlyRate.Size = new Size(100, 23);
            tbxHourlyRate.TabIndex = 11;
            // 
            // dtpDateHired
            // 
            dtpDateHired.Location = new Point(48, 343);
            dtpDateHired.Name = "dtpDateHired";
            dtpDateHired.Size = new Size(193, 23);
            dtpDateHired.TabIndex = 12;
            // 
            // cbRoleNames
            // 
            cbRoleNames.FormattingEnabled = true;
            cbRoleNames.Location = new Point(48, 387);
            cbRoleNames.Name = "cbRoleNames";
            cbRoleNames.Size = new Size(193, 23);
            cbRoleNames.TabIndex = 13;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(237, 416);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(339, 416);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Deactivate";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.AutoSize = true;
            btnCreate.Location = new Point(48, 416);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 25);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(453, 416);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(534, 416);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(534, 17);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 16;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // cbCompanyNames
            // 
            cbCompanyNames.FormattingEnabled = true;
            cbCompanyNames.Location = new Point(48, 18);
            cbCompanyNames.Name = "cbCompanyNames";
            cbCompanyNames.Size = new Size(193, 23);
            cbCompanyNames.TabIndex = 17;
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(48, 0);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(94, 15);
            lblCompanyName.TabIndex = 18;
            lblCompanyName.Text = "Company Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(47, 58);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 19;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(48, 102);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 20;
            lblLastName.Text = "Last Name";
            // 
            // lblSSN
            // 
            lblSSN.AutoSize = true;
            lblSSN.Location = new Point(48, 145);
            lblSSN.Name = "lblSSN";
            lblSSN.Size = new Size(28, 15);
            lblSSN.TabIndex = 21;
            lblSSN.Text = "SSN";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(48, 189);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(48, 237);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(88, 15);
            lblPhoneNumber.TabIndex = 23;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblHourlyRate
            // 
            lblHourlyRate.AutoSize = true;
            lblHourlyRate.Location = new Point(48, 281);
            lblHourlyRate.Name = "lblHourlyRate";
            lblHourlyRate.Size = new Size(69, 15);
            lblHourlyRate.TabIndex = 24;
            lblHourlyRate.Text = "Hourly Rate";
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.Location = new Point(48, 325);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(56, 15);
            lblHireDate.TabIndex = 25;
            lblHireDate.Text = "Hire Date";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(48, 369);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(30, 15);
            lblRole.TabIndex = 26;
            lblRole.Text = "Role";
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 452);
            Controls.Add(lblRole);
            Controls.Add(lblHireDate);
            Controls.Add(lblHourlyRate);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblSSN);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblCompanyName);
            Controls.Add(cbCompanyNames);
            Controls.Add(btnLogin);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnCreate);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(cbRoleNames);
            Controls.Add(dtpDateHired);
            Controls.Add(tbxHourlyRate);
            Controls.Add(tbxPhoneNumber);
            Controls.Add(tbxEmail);
            Controls.Add(tbxSSN);
            Controls.Add(tbxLastName);
            Controls.Add(tbxFirstName);
            Controls.Add(btnSearch);
            Name = "FrmEmployee";
            Text = "Logify";
            Load += FrmEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox tbxFirstName;
        private TextBox tbxLastName;
        private TextBox tbxSSN;
        private TextBox tbxEmail;
        private TextBox tbxPhoneNumber;
        private TextBox tbxHourlyRate;
        private DateTimePicker dtpDateHired;
        private ComboBox cbRoleNames;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCreate;
        private Button btnClear;
        private Button btnClose;
        private Button btnLogin;
        private ComboBox cbCompanyNames;
        private Label lblCompanyName;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblSSN;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblHourlyRate;
        private Label lblHireDate;
        private Label lblRole;
    }
}