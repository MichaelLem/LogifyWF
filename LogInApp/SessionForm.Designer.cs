namespace LogifyWin
{
    partial class SessionForm
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
            txbNotes = new TextBox();
            btnStart = new Button();
            btnBreak = new Button();
            btnReturn = new Button();
            btnEnd = new Button();
            lblTimeStart = new Label();
            lblTimeBreak = new Label();
            lblTimeReturn = new Label();
            lblTimeEnd = new Label();
            btnSaveNotes = new Button();
            btnViewHistory = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txbNotes
            // 
            txbNotes.BackColor = SystemColors.ButtonHighlight;
            txbNotes.BorderStyle = BorderStyle.FixedSingle;
            txbNotes.Cursor = Cursors.IBeam;
            txbNotes.ForeColor = SystemColors.ControlText;
            txbNotes.Location = new Point(219, 132);
            txbNotes.Multiline = true;
            txbNotes.Name = "txbNotes";
            txbNotes.PlaceholderText = "Enter message here...";
            txbNotes.Size = new Size(331, 133);
            txbNotes.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(74, 82);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnBreak
            // 
            btnBreak.Location = new Point(74, 169);
            btnBreak.Name = "btnBreak";
            btnBreak.Size = new Size(94, 29);
            btnBreak.TabIndex = 2;
            btnBreak.Text = "Break";
            btnBreak.UseVisualStyleBackColor = true;
            btnBreak.Click += btnBreak_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(74, 258);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 29);
            btnReturn.TabIndex = 3;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnEnd
            // 
            btnEnd.Location = new Point(74, 350);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(94, 29);
            btnEnd.TabIndex = 4;
            btnEnd.Text = "End";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // lblTimeStart
            // 
            lblTimeStart.AutoSize = true;
            lblTimeStart.Location = new Point(101, 35);
            lblTimeStart.Name = "lblTimeStart";
            lblTimeStart.Size = new Size(44, 20);
            lblTimeStart.TabIndex = 5;
            lblTimeStart.Text = "00:00";
            lblTimeStart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTimeBreak
            // 
            lblTimeBreak.AutoSize = true;
            lblTimeBreak.Location = new Point(101, 132);
            lblTimeBreak.Name = "lblTimeBreak";
            lblTimeBreak.Size = new Size(44, 20);
            lblTimeBreak.TabIndex = 6;
            lblTimeBreak.Text = "00:00";
            lblTimeBreak.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTimeReturn
            // 
            lblTimeReturn.AutoSize = true;
            lblTimeReturn.Location = new Point(101, 219);
            lblTimeReturn.Name = "lblTimeReturn";
            lblTimeReturn.Size = new Size(44, 20);
            lblTimeReturn.TabIndex = 7;
            lblTimeReturn.Text = "00:00";
            lblTimeReturn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTimeEnd
            // 
            lblTimeEnd.AutoSize = true;
            lblTimeEnd.Location = new Point(101, 310);
            lblTimeEnd.Name = "lblTimeEnd";
            lblTimeEnd.Size = new Size(44, 20);
            lblTimeEnd.TabIndex = 8;
            lblTimeEnd.Text = "00:00";
            lblTimeEnd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSaveNotes
            // 
            btnSaveNotes.Location = new Point(387, 288);
            btnSaveNotes.Name = "btnSaveNotes";
            btnSaveNotes.Size = new Size(163, 29);
            btnSaveNotes.TabIndex = 9;
            btnSaveNotes.Text = "&Save Notes";
            btnSaveNotes.UseVisualStyleBackColor = true;
            btnSaveNotes.Click += btnSaveNotes_Click;
            // 
            // btnViewHistory
            // 
            btnViewHistory.Location = new Point(535, 350);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(100, 29);
            btnViewHistory.TabIndex = 10;
            btnViewHistory.Text = "View History";
            btnViewHistory.UseVisualStyleBackColor = true;
            btnViewHistory.Click += btnViewHistory_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(362, 350);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "&Save To File";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // SessionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 411);
            Controls.Add(btnSave);
            Controls.Add(btnViewHistory);
            Controls.Add(btnSaveNotes);
            Controls.Add(lblTimeEnd);
            Controls.Add(lblTimeReturn);
            Controls.Add(lblTimeBreak);
            Controls.Add(lblTimeStart);
            Controls.Add(btnEnd);
            Controls.Add(btnReturn);
            Controls.Add(btnBreak);
            Controls.Add(btnStart);
            Controls.Add(txbNotes);
            Name = "SessionForm";
            Text = "Logify";
            Load += SessionForm_Load;
            Shown += SessionForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnBreak;
        private Button btnReturn;
        private Button btnEnd;
        private Label lblTimeStart;
        private Label lblTimeBreak;
        private Label lblTimeReturn;
        private Label lblTimeEnd;
        private TextBox txbNotes;
        private Button btnSaveNotes;
        private Button btnViewHistory;
        private Button btnSave;
    }
}