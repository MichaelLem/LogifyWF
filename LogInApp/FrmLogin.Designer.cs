namespace LogifyWin
{
    partial class FrmLogIn
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
            //button1 = new Button();
            SuspendLayout();
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(527, 467);
            btnLogIn.Margin = new Padding(6, 4, 6, 4);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(154, 47);
            btnLogIn.TabIndex = 0;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(316, 147);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 241);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(640, 344);
            txtUsername.Margin = new Padding(6, 4, 6, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(255, 39);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(474, 224);
            txtPassword.Margin = new Padding(6, 4, 6, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(255, 39);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // errorUserName
            // 
            errorUserName.AutoSize = true;
            errorUserName.ForeColor = Color.Red;
            errorUserName.Location = new Point(955, 137);
            errorUserName.Margin = new Padding(6, 0, 6, 0);
            errorUserName.Name = "errorUserName";
            errorUserName.Size = new Size(158, 32);
            errorUserName.TabIndex = 5;
            errorUserName.Text = "ErrorMessage";
            errorUserName.Visible = false;
            // 
            // errorPassword
            // 
            errorPassword.AutoSize = true;
            errorPassword.ForeColor = Color.Red;
            errorPassword.Location = new Point(955, 230);
            errorPassword.Margin = new Padding(6, 0, 6, 0);
            errorPassword.Name = "errorPassword";
            errorPassword.Size = new Size(158, 32);
            errorPassword.TabIndex = 6;
            errorPassword.Text = "ErrorMessage";
            errorPassword.Visible = false;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(743, 233);
            chkShowPassword.Margin = new Padding(6);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(208, 36);
            chkShowPassword.TabIndex = 8;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // button1
            // 
            //button1.Location = new Point(548, 198);
            //button1.Name = "button1";
            //button1.Size = new Size(150, 46);
            //button1.TabIndex = 9;
            //button1.Text = "button1";
            //button1.UseVisualStyleBackColor = true;
            // 
            // FrmLogIn
            // 
            AcceptButton = btnLogIn;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 698);
            //Controls.Add(button1);
            Controls.Add(chkShowPassword);
            Controls.Add(errorPassword);
            Controls.Add(errorUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogIn);
            Margin = new Padding(6, 4, 6, 4);
            Name = "FrmLogIn";
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
        //private Button button1;
    }
}
