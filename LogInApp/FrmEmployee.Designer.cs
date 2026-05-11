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
            lblEmployeeId = new Label();
            lblCompanyName = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(141, 416);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Location = new Point(48, 79);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.PlaceholderText = "First Name";
            tbxFirstName.Size = new Size(100, 23);
            tbxFirstName.TabIndex = 1;
            // 
            // tbxLastName
            // 
            tbxLastName.Location = new Point(48, 120);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.PlaceholderText = "Last Name";
            tbxLastName.Size = new Size(100, 23);
            tbxLastName.TabIndex = 2;
            // 
            // tbxSSN
            // 
            tbxSSN.Location = new Point(48, 163);
            tbxSSN.Name = "tbxSSN";
            tbxSSN.PlaceholderText = "SSN";
            tbxSSN.Size = new Size(100, 23);
            tbxSSN.TabIndex = 3;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(48, 208);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.PlaceholderText = "Email";
            tbxEmail.Size = new Size(100, 23);
            tbxEmail.TabIndex = 4;
            // 
            // tbxPhoneNumber
            // 
            tbxPhoneNumber.Location = new Point(48, 246);
            tbxPhoneNumber.Name = "tbxPhoneNumber";
            tbxPhoneNumber.PlaceholderText = "Phone Number";
            tbxPhoneNumber.Size = new Size(100, 23);
            tbxPhoneNumber.TabIndex = 5;
            // 
            // tbxHourlyRate
            // 
            tbxHourlyRate.Location = new Point(48, 289);
            tbxHourlyRate.Name = "tbxHourlyRate";
            tbxHourlyRate.PlaceholderText = "Hourly Rate";
            tbxHourlyRate.Size = new Size(100, 23);
            tbxHourlyRate.TabIndex = 6;
            // 
            // dtpDateHired
            // 
            dtpDateHired.Location = new Point(48, 336);
            dtpDateHired.Name = "dtpDateHired";
            dtpDateHired.Size = new Size(193, 23);
            dtpDateHired.TabIndex = 7;
            // 
            // cbRoleNames
            // 
            cbRoleNames.FormattingEnabled = true;
            cbRoleNames.Location = new Point(48, 376);
            cbRoleNames.Name = "cbRoleNames";
            cbRoleNames.Size = new Size(193, 23);
            cbRoleNames.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(237, 416);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(339, 416);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Deactivate";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(48, 416);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Location = new Point(48, 52);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(73, 15);
            lblEmployeeId.TabIndex = 12;
            lblEmployeeId.Text = "Employee ID";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(48, 21);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(94, 15);
            lblCompanyName.TabIndex = 13;
            lblCompanyName.Text = "Company Name";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(519, 416);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 452);
            Controls.Add(btnClear);
            Controls.Add(lblCompanyName);
            Controls.Add(lblEmployeeId);
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
        private Label lblEmployeeId;
        private Label lblCompanyName;
        private Button btnClear;
    }
}