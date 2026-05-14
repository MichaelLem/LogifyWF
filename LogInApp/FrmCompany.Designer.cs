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
            tbxPcPhoneNumber = new TextBox();
            tbxPcEmail = new TextBox();
            tbxPcLastName = new TextBox();
            btnClear = new Button();
            btnCreate = new Button();
            btnClose = new Button();
            lblRolePrimaryContact = new Label();
            grpCompanyInformation = new GroupBox();
            grpPrimaryContact = new GroupBox();
            grpActions = new GroupBox();
            grpCompanyInformation.SuspendLayout();
            grpPrimaryContact.SuspendLayout();
            grpActions.SuspendLayout();
            SuspendLayout();
            // 
            // tbxCompanyName
            // 
            tbxCompanyName.Location = new Point(113, 39);
            tbxCompanyName.Name = "tbxCompanyName";
            tbxCompanyName.PlaceholderText = "Company Name";
            tbxCompanyName.Size = new Size(100, 23);
            tbxCompanyName.TabIndex = 0;
            // 
            // tbxCompanyEmail
            // 
            tbxCompanyEmail.Location = new Point(248, 39);
            tbxCompanyEmail.Name = "tbxCompanyEmail";
            tbxCompanyEmail.PlaceholderText = "Company Email";
            tbxCompanyEmail.Size = new Size(100, 23);
            tbxCompanyEmail.TabIndex = 1;
            // 
            // tbxPcFirstName
            // 
            tbxPcFirstName.Location = new Point(55, 55);
            tbxPcFirstName.Name = "tbxPcFirstName";
            tbxPcFirstName.PlaceholderText = "FirstName";
            tbxPcFirstName.Size = new Size(100, 23);
            tbxPcFirstName.TabIndex = 2;
            // 
            // tbxPcPhoneNumber
            // 
            tbxPcPhoneNumber.Location = new Point(312, 55);
            tbxPcPhoneNumber.Name = "tbxPcPhoneNumber";
            tbxPcPhoneNumber.PlaceholderText = "Phone Number";
            tbxPcPhoneNumber.Size = new Size(100, 23);
            tbxPcPhoneNumber.TabIndex = 4;
            // 
            // tbxPcEmail
            // 
            tbxPcEmail.Location = new Point(312, 96);
            tbxPcEmail.Name = "tbxPcEmail";
            tbxPcEmail.PlaceholderText = "Email";
            tbxPcEmail.Size = new Size(100, 23);
            tbxPcEmail.TabIndex = 5;
            // 
            // tbxPcLastName
            // 
            tbxPcLastName.Location = new Point(55, 96);
            tbxPcLastName.Name = "tbxPcLastName";
            tbxPcLastName.PlaceholderText = "Last Name";
            tbxPcLastName.Size = new Size(100, 23);
            tbxPcLastName.TabIndex = 7;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(200, 45);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 34);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCreate.Location = new Point(55, 45);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 34);
            btnCreate.TabIndex = 18;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(337, 45);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 34);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // lblRolePrimaryContact
            // 
            lblRolePrimaryContact.AutoSize = true;
            lblRolePrimaryContact.Location = new Point(173, 30);
            lblRolePrimaryContact.Name = "lblRolePrimaryContact";
            lblRolePrimaryContact.Size = new Size(122, 15);
            lblRolePrimaryContact.TabIndex = 20;
            lblRolePrimaryContact.Text = "Role: Primary Contact";
            // 
            // grpCompanyInformation
            // 
            grpCompanyInformation.Controls.Add(tbxCompanyName);
            grpCompanyInformation.Controls.Add(tbxCompanyEmail);
            grpCompanyInformation.Location = new Point(94, 24);
            grpCompanyInformation.Name = "grpCompanyInformation";
            grpCompanyInformation.Size = new Size(471, 100);
            grpCompanyInformation.TabIndex = 21;
            grpCompanyInformation.TabStop = false;
            grpCompanyInformation.Text = "Company Information";
            // 
            // grpPrimaryContact
            // 
            grpPrimaryContact.Controls.Add(tbxPcFirstName);
            grpPrimaryContact.Controls.Add(tbxPcLastName);
            grpPrimaryContact.Controls.Add(lblRolePrimaryContact);
            grpPrimaryContact.Controls.Add(tbxPcPhoneNumber);
            grpPrimaryContact.Controls.Add(tbxPcEmail);
            grpPrimaryContact.Location = new Point(94, 156);
            grpPrimaryContact.Name = "grpPrimaryContact";
            grpPrimaryContact.Size = new Size(471, 191);
            grpPrimaryContact.TabIndex = 22;
            grpPrimaryContact.TabStop = false;
            grpPrimaryContact.Text = "Primary Contact";
            // 
            // grpActions
            // 
            grpActions.Controls.Add(btnCreate);
            grpActions.Controls.Add(btnClear);
            grpActions.Controls.Add(btnClose);
            grpActions.Location = new Point(94, 382);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(471, 100);
            grpActions.TabIndex = 23;
            grpActions.TabStop = false;
            grpActions.Text = "Actions";
            // 
            // FrmCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 494);
            Controls.Add(grpActions);
            Controls.Add(grpPrimaryContact);
            Controls.Add(grpCompanyInformation);
            Name = "FrmCompany";
            Text = "FrmCompany";
            grpCompanyInformation.ResumeLayout(false);
            grpCompanyInformation.PerformLayout();
            grpPrimaryContact.ResumeLayout(false);
            grpPrimaryContact.PerformLayout();
            grpActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbxCompanyName;
        private TextBox tbxCompanyEmail;
        private TextBox tbxPcFirstName;
        private TextBox tbxPcPhoneNumber;
        private TextBox tbxPcEmail;
        private TextBox tbxPcLastName;
        private Button btnClear;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClose;
        private Label lblRolePrimaryContact;
        private GroupBox grpCompanyInformation;
        private GroupBox grpPrimaryContact;
        private GroupBox grpActions;
    }
}