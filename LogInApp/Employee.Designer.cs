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
            lblRoleId = new Label();
            lblRoleName = new Label();
            lblCompanyId = new Label();
            lblDateHired = new Label();
            lblSSN = new Label();
            lblEmployeeId = new Label();
            lblHourlyRate = new Label();
            SuspendLayout();
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(167, 19);
            lblCompanyName.Margin = new Padding(2, 0, 2, 0);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(112, 20);
            lblCompanyName.TabIndex = 0;
            lblCompanyName.Text = "CompanyName";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(168, 150);
            lblFirstName.Margin = new Padding(2, 0, 2, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(168, 170);
            lblLastName.Margin = new Padding(2, 0, 2, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(168, 245);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(167, 282);
            lblPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(108, 20);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblRoleId
            // 
            lblRoleId.AutoSize = true;
            lblRoleId.Location = new Point(167, 96);
            lblRoleId.Margin = new Padding(2, 0, 2, 0);
            lblRoleId.Name = "lblRoleId";
            lblRoleId.Size = new Size(56, 20);
            lblRoleId.TabIndex = 5;
            lblRoleId.Text = "Role Id";
            // 
            // lblRoleName
            // 
            lblRoleName.AutoSize = true;
            lblRoleName.Location = new Point(167, 76);
            lblRoleName.Margin = new Padding(2, 0, 2, 0);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(83, 20);
            lblRoleName.TabIndex = 6;
            lblRoleName.Text = "Role Name";
            // 
            // lblCompanyId
            // 
            lblCompanyId.AutoSize = true;
            lblCompanyId.Location = new Point(167, 39);
            lblCompanyId.Margin = new Padding(2, 0, 2, 0);
            lblCompanyId.Name = "lblCompanyId";
            lblCompanyId.Size = new Size(89, 20);
            lblCompanyId.TabIndex = 7;
            lblCompanyId.Text = "Company Id";
            // 
            // lblDateHired
            // 
            lblDateHired.AutoSize = true;
            lblDateHired.Location = new Point(168, 311);
            lblDateHired.Margin = new Padding(2, 0, 2, 0);
            lblDateHired.Name = "lblDateHired";
            lblDateHired.Size = new Size(82, 20);
            lblDateHired.TabIndex = 8;
            lblDateHired.Text = "Date Hired";
            // 
            // lblSSN
            // 
            lblSSN.AutoSize = true;
            lblSSN.Location = new Point(168, 197);
            lblSSN.Margin = new Padding(2, 0, 2, 0);
            lblSSN.Name = "lblSSN";
            lblSSN.Size = new Size(36, 20);
            lblSSN.TabIndex = 9;
            lblSSN.Text = "SSN";
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Location = new Point(167, 130);
            lblEmployeeId.Margin = new Padding(2, 0, 2, 0);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(88, 20);
            lblEmployeeId.TabIndex = 10;
            lblEmployeeId.Text = "EmployeeId";
            // 
            // lblHourlyRate
            // 
            lblHourlyRate.AutoSize = true;
            lblHourlyRate.Location = new Point(167, 217);
            lblHourlyRate.Margin = new Padding(2, 0, 2, 0);
            lblHourlyRate.Name = "lblHourlyRate";
            lblHourlyRate.Size = new Size(83, 20);
            lblHourlyRate.TabIndex = 11;
            lblHourlyRate.Text = "HourlyRate";
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(lblHourlyRate);
            Controls.Add(lblEmployeeId);
            Controls.Add(lblSSN);
            Controls.Add(lblDateHired);
            Controls.Add(lblCompanyId);
            Controls.Add(lblRoleName);
            Controls.Add(lblRoleId);
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
        private Label lblRoleId;
        private Label lblRoleName;
        private Label lblCompanyId;
        private Label lblDateHired;
        private Label lblSSN;
        private Label lblEmployeeId;
        private Label lblHourlyRate;
    }
}