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
            lblCompanyId = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            SuspendLayout();
            // 
            // lblCompanyId
            // 
            lblCompanyId.AutoSize = true;
            lblCompanyId.Location = new Point(107, 77);
            lblCompanyId.Name = "lblCompanyId";
            lblCompanyId.Size = new Size(32, 25);
            lblCompanyId.TabIndex = 0;
            lblCompanyId.Text = "36";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(107, 135);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 25);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(107, 193);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(49, 25);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Data";
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblCompanyId);
            Name = "Employee";
            Text = "Employee";
            Load += Employee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCompanyId;
        private Label lblFirstName;
        private Label lblLastName;
    }
}