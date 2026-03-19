namespace EchoMessenger
{
    partial class Form1
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
            lblTitle = new Label();
            lstChat = new ListBox();
            txtInput = new TextBox();
            btnSend = new Button();
            lblCount = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("한컴 말랑말랑 Bold", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTitle.Location = new Point(30, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(344, 56);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "EchoMessenger";
            lblTitle.Click += lblTitle_Click;
            // 
            // lstChat
            // 
            lstChat.Font = new Font("한컴 고딕", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lstChat.FormattingEnabled = true;
            lstChat.Location = new Point(30, 85);
            lstChat.Name = "lstChat";
            lstChat.Size = new Size(739, 262);
            lstChat.TabIndex = 1;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("한컴 말랑말랑 Bold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtInput.Location = new Point(30, 389);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(586, 50);
            txtInput.TabIndex = 2;
            txtInput.KeyDown += txtInput_KeyDown;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Yellow;
            btnSend.Font = new Font("한컴 말랑말랑 Bold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSend.Location = new Point(622, 389);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(147, 50);
            btnSend.TabIndex = 3;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblCount.Location = new Point(30, 350);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(174, 35);
            lblCount.TabIndex = 4;
            lblCount.Text = "현재 대화: 0개";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 472);
            Controls.Add(lblCount);
            Controls.Add(btnSend);
            Controls.Add(txtInput);
            Controls.Add(lstChat);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListBox lstChat;
        private TextBox txtInput;
        private Button btnSend;
        private Label lblCount;
    }
}
