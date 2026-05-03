namespace LogifyWin
{
    partial class Employee
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
            lblCompanyName = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblDateHired = new Label();
            lblSSN = new Label();
            lblEmployeeId = new Label();
            lblHourlyRate = new Label();
            cbRoleNames = new ComboBox();
            btnSubmit = new Button();
            tbxFindLastName = new TextBox();
            btnCreate = new Button();
            tbxEditHourlyRate = new TextBox();
            btnEditEmployee = new Button();
            lblEditEmployee = new Label();
            tbxCreateEmployee = new Label();
            tbxEditPhoneNumber = new TextBox();
            tbxEditEmail = new TextBox();
            tbxEditFirstName = new TextBox();
            tbxEditLastName = new TextBox();
            lblDeleteEmployee = new Label();
            btnDeleteEmployee = new Button();
            SuspendLayout();
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(377, 20);
            lblCompanyName.Margin = new Padding(2, 0, 2, 0);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(94, 15);
            lblCompanyName.TabIndex = 0;
            lblCompanyName.Text = "Company Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(377, 72);
            lblFirstName.Margin = new Padding(2, 0, 2, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(377, 99);
            lblLastName.Margin = new Padding(2, 0, 2, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(377, 192);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(377, 220);
            lblPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(88, 15);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblDateHired
            // 
            lblDateHired.AutoSize = true;
            lblDateHired.Location = new Point(377, 246);
            lblDateHired.Margin = new Padding(2, 0, 2, 0);
            lblDateHired.Name = "lblDateHired";
            lblDateHired.Size = new Size(63, 15);
            lblDateHired.TabIndex = 8;
            lblDateHired.Text = "Date Hired";
            // 
            // lblSSN
            // 
            lblSSN.AutoSize = true;
            lblSSN.Location = new Point(377, 127);
            lblSSN.Margin = new Padding(2, 0, 2, 0);
            lblSSN.Name = "lblSSN";
            lblSSN.Size = new Size(28, 15);
            lblSSN.TabIndex = 9;
            lblSSN.Text = "SSN";
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Location = new Point(377, 44);
            lblEmployeeId.Margin = new Padding(2, 0, 2, 0);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(72, 15);
            lblEmployeeId.TabIndex = 10;
            lblEmployeeId.Text = "Employee Id";
            // 
            // lblHourlyRate
            // 
            lblHourlyRate.AutoSize = true;
            lblHourlyRate.Location = new Point(377, 163);
            lblHourlyRate.Margin = new Padding(2, 0, 2, 0);
            lblHourlyRate.Name = "lblHourlyRate";
            lblHourlyRate.Size = new Size(69, 15);
            lblHourlyRate.TabIndex = 11;
            lblHourlyRate.Text = "Hourly Rate";
            // 
            // cbRoleNames
            // 
            cbRoleNames.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbRoleNames.FormattingEnabled = true;
            cbRoleNames.Location = new Point(12, 47);
            cbRoleNames.Margin = new Padding(3, 2, 3, 2);
            cbRoleNames.Name = "cbRoleNames";
            cbRoleNames.Size = new Size(133, 23);
            cbRoleNames.TabIndex = 12;
            cbRoleNames.Text = "Roles";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(30, 74);
            btnSubmit.Margin = new Padding(3, 2, 3, 2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(82, 22);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // tbxFindLastName
            // 
            tbxFindLastName.ForeColor = SystemColors.ControlDark;
            tbxFindLastName.Location = new Point(12, 20);
            tbxFindLastName.Margin = new Padding(3, 2, 3, 2);
            tbxFindLastName.Name = "tbxFindLastName";
            tbxFindLastName.PlaceholderText = "Last Name";
            tbxFindLastName.Size = new Size(133, 23);
            tbxFindLastName.TabIndex = 14;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(30, 153);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(82, 25);
            btnCreate.TabIndex = 15;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // tbxEditHourlyRate
            // 
            tbxEditHourlyRate.Location = new Point(468, 155);
            tbxEditHourlyRate.Name = "tbxEditHourlyRate";
            tbxEditHourlyRate.Size = new Size(100, 23);
            tbxEditHourlyRate.TabIndex = 17;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.Location = new Point(214, 216);
            btnEditEmployee.Margin = new Padding(3, 2, 3, 2);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(82, 22);
            btnEditEmployee.TabIndex = 18;
            btnEditEmployee.Text = "Edit";
            btnEditEmployee.UseVisualStyleBackColor = true;
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // lblEditEmployee
            // 
            lblEditEmployee.AutoSize = true;
            lblEditEmployee.Location = new Point(205, 192);
            lblEditEmployee.Name = "lblEditEmployee";
            lblEditEmployee.Size = new Size(106, 15);
            lblEditEmployee.TabIndex = 19;
            lblEditEmployee.Text = "Edit Employee Info";
            // 
            // tbxCreateEmployee
            // 
            tbxCreateEmployee.AutoSize = true;
            tbxCreateEmployee.Font = new Font("Segoe UI", 9.5F);
            tbxCreateEmployee.Location = new Point(16, 118);
            tbxCreateEmployee.Name = "tbxCreateEmployee";
            tbxCreateEmployee.Size = new Size(107, 17);
            tbxCreateEmployee.TabIndex = 20;
            tbxCreateEmployee.Text = "Create Employee";
            tbxCreateEmployee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxEditPhoneNumber
            // 
            tbxEditPhoneNumber.Location = new Point(468, 215);
            tbxEditPhoneNumber.Name = "tbxEditPhoneNumber";
            tbxEditPhoneNumber.Size = new Size(100, 23);
            tbxEditPhoneNumber.TabIndex = 21;
            // 
            // tbxEditEmail
            // 
            tbxEditEmail.Location = new Point(468, 184);
            tbxEditEmail.Name = "tbxEditEmail";
            tbxEditEmail.Size = new Size(100, 23);
            tbxEditEmail.TabIndex = 23;
            // 
            // tbxEditFirstName
            // 
            tbxEditFirstName.Location = new Point(468, 69);
            tbxEditFirstName.Name = "tbxEditFirstName";
            tbxEditFirstName.Size = new Size(100, 23);
            tbxEditFirstName.TabIndex = 24;
            // 
            // tbxEditLastName
            // 
            tbxEditLastName.Location = new Point(468, 96);
            tbxEditLastName.Name = "tbxEditLastName";
            tbxEditLastName.Size = new Size(100, 23);
            tbxEditLastName.TabIndex = 25;
            // 
            // lblDeleteEmployee
            // 
            lblDeleteEmployee.AutoSize = true;
            lblDeleteEmployee.Font = new Font("Segoe UI", 9.5F);
            lblDeleteEmployee.Location = new Point(16, 192);
            lblDeleteEmployee.Name = "lblDeleteEmployee";
            lblDeleteEmployee.Size = new Size(106, 17);
            lblDeleteEmployee.TabIndex = 26;
            lblDeleteEmployee.Text = "Delete Employee";
            lblDeleteEmployee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Location = new Point(30, 220);
            btnDeleteEmployee.Margin = new Padding(3, 2, 3, 2);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(82, 25);
            btnDeleteEmployee.TabIndex = 27;
            btnDeleteEmployee.Text = "Delete";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 270);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(lblDeleteEmployee);
            Controls.Add(tbxEditLastName);
            Controls.Add(tbxEditFirstName);
            Controls.Add(tbxEditEmail);
            Controls.Add(tbxEditPhoneNumber);
            Controls.Add(tbxCreateEmployee);
            Controls.Add(lblEditEmployee);
            Controls.Add(btnEditEmployee);
            Controls.Add(tbxEditHourlyRate);
            Controls.Add(btnCreate);
            Controls.Add(tbxFindLastName);
            Controls.Add(btnSubmit);
            Controls.Add(cbRoleNames);
            Controls.Add(lblHourlyRate);
            Controls.Add(lblEmployeeId);
            Controls.Add(lblSSN);
            Controls.Add(lblDateHired);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblCompanyName);
            Margin = new Padding(2);
            Name = "Employee";
            Text = "Employee";
            Load += Employee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCompanyName;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblCompanyId;
        private Label lblDateHired;
        private Label lblSSN;
        private Label lblEmployeeId;
        private Label lblHourlyRate;
        private ComboBox cbRoleNames;
        private Button btnSubmit;
        private TextBox tbxFindLastName;
        private Button btnCreate;
        private TextBox tbxEditHourlyRate;
        private Button btnEditEmployee;
        private Label lblEditEmployee;
        private Label tbxCreateEmployee;
        private TextBox tbxEditPhoneNumber;
        private TextBox tbxEditEmail;
        private TextBox tbxEditFirstName;
        private TextBox tbxEditLastName;
        private Label lblDeleteEmployee;
        private Button btnDeleteEmployee;
    }
}