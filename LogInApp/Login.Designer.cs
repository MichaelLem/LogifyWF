namespace Logify
{
    partial class LogIn
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
            btnSubmit = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            errorUserName = new Label();
            errorPassword = new Label();
            //btnSqlTest = new Button();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(31, 210);
            btnSubmit.Margin = new Padding(4, 4, 4, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(118, 36);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(25, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 155);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(188, 74);
            txtUsername.Margin = new Padding(4, 4, 4, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(155, 31);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(188, 155);
            txtPassword.Margin = new Padding(4, 4, 4, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(155, 31);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // errorUserName
            // 
            errorUserName.AutoSize = true;
            errorUserName.ForeColor = Color.Red;
            errorUserName.Location = new Point(372, 82);
            errorUserName.Margin = new Padding(4, 0, 4, 0);
            errorUserName.Name = "errorUserName";
            errorUserName.Size = new Size(120, 25);
            errorUserName.TabIndex = 5;
            errorUserName.Text = "ErrorMessage";
            errorUserName.Visible = false;
            // 
            // errorPassword
            // 
            errorPassword.AutoSize = true;
            errorPassword.ForeColor = Color.Red;
            errorPassword.Location = new Point(372, 164);
            errorPassword.Margin = new Padding(4, 0, 4, 0);
            errorPassword.Name = "errorPassword";
            errorPassword.Size = new Size(120, 25);
            errorPassword.TabIndex = 6;
            errorPassword.Text = "ErrorMessage";
            errorPassword.Visible = false;
            // 
            // LogIn
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 267);
            Controls.Add(errorPassword);
            Controls.Add(errorUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Margin = new Padding(4, 4, 4, 4);
            Name = "LogIn";
            Text = "Login";
            Load += LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label errorUserName;
        private Label errorPassword;
    }
}
