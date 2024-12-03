namespace VotingSystem
{
    partial class LoginForm
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
            txtLoginID = new TextBox();
            txtLoginPassword = new TextBox();
            loginBtn = new Button();
            lblLoginID = new Label();
            lblLoginPassword = new Label();
            lblLoginTitle = new Label();
            SuspendLayout();
            // 
            // txtLoginID
            // 
            txtLoginID.Location = new Point(405, 145);
            txtLoginID.Name = "txtLoginID";
            txtLoginID.Size = new Size(172, 27);
            txtLoginID.TabIndex = 0;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(405, 209);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(172, 27);
            txtLoginPassword.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = SystemColors.ControlDarkDark;
            loginBtn.FlatAppearance.BorderColor = Color.DarkCyan;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.ForeColor = SystemColors.Control;
            loginBtn.Location = new Point(301, 310);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(276, 39);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "LogIn";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += button1_Click;
            // 
            // lblLoginID
            // 
            lblLoginID.AutoSize = true;
            lblLoginID.Location = new Point(363, 148);
            lblLoginID.Name = "lblLoginID";
            lblLoginID.Size = new Size(31, 20);
            lblLoginID.TabIndex = 3;
            lblLoginID.Text = "ID: ";
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.Location = new Point(321, 212);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(73, 20);
            lblLoginPassword.TabIndex = 4;
            lblLoginPassword.Text = "Password:";
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.BackColor = Color.CadetBlue;
            lblLoginTitle.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginTitle.Location = new Point(157, 44);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(610, 29);
            lblLoginTitle.TabIndex = 5;
            lblLoginTitle.Text = "Welcome to the United States' Voting System";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(875, 545);
            Controls.Add(lblLoginTitle);
            Controls.Add(lblLoginPassword);
            Controls.Add(lblLoginID);
            Controls.Add(loginBtn);
            Controls.Add(txtLoginPassword);
            Controls.Add(txtLoginID);
            ForeColor = SystemColors.ControlText;
            Name = "LoginForm";
            Text = "v";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLoginID;
        private TextBox txtLoginPassword;
        private Button loginBtn;
        private Label lblLoginID;
        private Label lblLoginPassword;
        private Label lblLoginTitle;
    }
}
