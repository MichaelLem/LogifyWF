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
            lblCompanyId = new Label();
            lblDateHired = new Label();
            lblSSN = new Label();
            lblEmployeeId = new Label();
            lblHourlyRate = new Label();
            cbRoleNames = new ComboBox();
            btnSubmit = new Button();
            tbxLastName = new TextBox();
            btnCreate = new Button();
            txtHourlyRate = new TextBox();
            btnEditEmployee = new Button();
            lblEditEmployee = new Label();
            tbxCreateEmployee = new Label();
            SuspendLayout();
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(377, 11);
            lblCompanyName.Margin = new Padding(2, 0, 2, 0);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(91, 15);
            lblCompanyName.TabIndex = 0;
            lblCompanyName.Text = "CompanyName";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(377, 91);
            lblFirstName.Margin = new Padding(2, 0, 2, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(377, 116);
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
            // lblCompanyId
            // 
            lblCompanyId.AutoSize = true;
            lblCompanyId.Location = new Point(377, 36);
            lblCompanyId.Margin = new Padding(2, 0, 2, 0);
            lblCompanyId.Name = "lblCompanyId";
            lblCompanyId.Size = new Size(72, 15);
            lblCompanyId.TabIndex = 7;
            lblCompanyId.Text = "Company Id";
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
            lblSSN.Location = new Point(377, 141);
            lblSSN.Margin = new Padding(2, 0, 2, 0);
            lblSSN.Name = "lblSSN";
            lblSSN.Size = new Size(28, 15);
            lblSSN.TabIndex = 9;
            lblSSN.Text = "SSN";
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Location = new Point(377, 67);
            lblEmployeeId.Margin = new Padding(2, 0, 2, 0);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(69, 15);
            lblEmployeeId.TabIndex = 10;
            lblEmployeeId.Text = "EmployeeId";
            // 
            // lblHourlyRate
            // 
            lblHourlyRate.AutoSize = true;
            lblHourlyRate.Location = new Point(377, 166);
            lblHourlyRate.Margin = new Padding(2, 0, 2, 0);
            lblHourlyRate.Name = "lblHourlyRate";
            lblHourlyRate.Size = new Size(66, 15);
            lblHourlyRate.TabIndex = 11;
            lblHourlyRate.Text = "HourlyRate";
            // 
            // cbRoleNames
            // 
            cbRoleNames.FormattingEnabled = true;
            cbRoleNames.Location = new Point(10, 91);
            cbRoleNames.Margin = new Padding(3, 2, 3, 2);
            cbRoleNames.Name = "cbRoleNames";
            cbRoleNames.Size = new Size(133, 23);
            cbRoleNames.TabIndex = 12;
            cbRoleNames.Text = "Roles";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(30, 137);
            btnSubmit.Margin = new Padding(3, 2, 3, 2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(82, 22);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // tbxLastName
            // 
            tbxLastName.ForeColor = SystemColors.ControlDark;
            tbxLastName.Location = new Point(10, 64);
            tbxLastName.Margin = new Padding(3, 2, 3, 2);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.PlaceholderText = "Last Name";
            tbxLastName.Size = new Size(133, 23);
            tbxLastName.TabIndex = 14;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(214, 92);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(82, 22);
            btnCreate.TabIndex = 15;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.Location = new Point(468, 158);
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.Size = new Size(100, 23);
            txtHourlyRate.TabIndex = 17;
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
            tbxCreateEmployee.Location = new Point(214, 53);
            tbxCreateEmployee.Name = "tbxCreateEmployee";
            tbxCreateEmployee.Size = new Size(96, 15);
            tbxCreateEmployee.TabIndex = 20;
            tbxCreateEmployee.Text = "Create Employee";
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 270);
            Controls.Add(tbxCreateEmployee);
            Controls.Add(lblEditEmployee);
            Controls.Add(btnEditEmployee);
            Controls.Add(txtHourlyRate);
            Controls.Add(btnCreate);
            Controls.Add(tbxLastName);
            Controls.Add(btnSubmit);
            Controls.Add(cbRoleNames);
            Controls.Add(lblHourlyRate);
            Controls.Add(lblEmployeeId);
            Controls.Add(lblSSN);
            Controls.Add(lblDateHired);
            Controls.Add(lblCompanyId);
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
        private TextBox tbxLastName;
        private Button btnCreate;
        private TextBox txtHourlyRate;
        private Button btnEditEmployee;
        private Label lblEditEmployee;
        private Label tbxCreateEmployee;
    }
}