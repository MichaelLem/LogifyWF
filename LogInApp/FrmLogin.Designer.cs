namespace LogifyWin
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
            btnLogIn = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            errorUserName = new Label();
            errorPassword = new Label();
            chkShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(284, 219);
            btnLogIn.Margin = new Padding(3, 2, 3, 2);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(83, 22);
            btnLogIn.TabIndex = 0;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(170, 69);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 113);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(255, 61);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(139, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(255, 105);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(139, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // errorUserName
            // 
            errorUserName.AutoSize = true;
            errorUserName.ForeColor = Color.Red;
            errorUserName.Location = new Point(514, 64);
            errorUserName.Name = "errorUserName";
            errorUserName.Size = new Size(78, 15);
            errorUserName.TabIndex = 5;
            errorUserName.Text = "ErrorMessage";
            errorUserName.Visible = false;
            // 
            // errorPassword
            // 
            errorPassword.AutoSize = true;
            errorPassword.ForeColor = Color.Red;
            errorPassword.Location = new Point(514, 108);
            errorPassword.Name = "errorPassword";
            errorPassword.Size = new Size(78, 15);
            errorPassword.TabIndex = 6;
            errorPassword.Text = "ErrorMessage";
            errorPassword.Visible = false;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(400, 109);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(108, 19);
            chkShowPassword.TabIndex = 8;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // LogIn
            // 
            AcceptButton = btnLogIn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 327);
            Controls.Add(chkShowPassword);
            Controls.Add(errorPassword);
            Controls.Add(errorUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogIn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LogIn";
            Text = "Logify";
            Load += LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogIn;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label errorUserName;
        private Label errorPassword;
        private CheckBox chkShowPassword;
    }
}
