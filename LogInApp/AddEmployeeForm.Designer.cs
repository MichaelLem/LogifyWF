namespace LogifyWin
{
    partial class AddEmployeeForm
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
            btnSubmitEmployee = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtSSN = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtHourlyRate = new TextBox();
            dtpDateHired = new DateTimePicker();
            cbRoleNames = new ComboBox();
            SuspendLayout();
            // 
            // btnSubmitEmployee
            // 
            btnSubmitEmployee.Location = new Point(354, 369);
            btnSubmitEmployee.Name = "btnSubmitEmployee";
            btnSubmitEmployee.Size = new Size(75, 23);
            btnSubmitEmployee.TabIndex = 0;
            btnSubmitEmployee.Text = "Submit";
            btnSubmitEmployee.UseVisualStyleBackColor = true;
            btnSubmitEmployee.Click += btnSubmitEmployee_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(48, 51);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(48, 92);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtSSN
            // 
            txtSSN.Location = new Point(48, 135);
            txtSSN.Name = "txtSSN";
            txtSSN.PlaceholderText = "SSN";
            txtSSN.Size = new Size(100, 23);
            txtSSN.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(48, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(48, 218);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Phone Number";
            txtPhoneNumber.Size = new Size(100, 23);
            txtPhoneNumber.TabIndex = 5;
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.Location = new Point(48, 261);
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.PlaceholderText = "Hourly Rate";
            txtHourlyRate.Size = new Size(100, 23);
            txtHourlyRate.TabIndex = 6;
            // 
            // dtpDateHired
            // 
            dtpDateHired.Location = new Point(48, 304);
            dtpDateHired.Name = "dtpDateHired";
            dtpDateHired.Size = new Size(193, 23);
            dtpDateHired.TabIndex = 7;
            // 
            // cbRoleNames
            // 
            cbRoleNames.FormattingEnabled = true;
            cbRoleNames.Location = new Point(48, 352);
            cbRoleNames.Name = "cbRoleNames";
            cbRoleNames.Size = new Size(193, 23);
            cbRoleNames.TabIndex = 8;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbRoleNames);
            Controls.Add(dtpDateHired);
            Controls.Add(txtHourlyRate);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtSSN);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(btnSubmitEmployee);
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            Load += AddEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmitEmployee;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtSSN;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtHourlyRate;
        private DateTimePicker dtpDateHired;
        private ComboBox cbRoleNames;
    }
}