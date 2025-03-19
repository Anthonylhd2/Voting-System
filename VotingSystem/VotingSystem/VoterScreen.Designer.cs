namespace VotingSystem
{
    partial class VoterScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoterScreen));
            btnVoterLogout = new Button();
            btnPaulVote = new Button();
            btnDonaldVote = new Button();
            lblDonaldMoto = new Label();
            lblPaulMoto = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblDrPaul = new Label();
            lblDonaldTrump = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnVoterLogout
            // 
            btnVoterLogout.BackColor = Color.FromArgb(255, 128, 128);
            btnVoterLogout.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnVoterLogout.FlatStyle = FlatStyle.Flat;
            btnVoterLogout.Location = new Point(738, 3);
            btnVoterLogout.Name = "btnVoterLogout";
            btnVoterLogout.Size = new Size(96, 44);
            btnVoterLogout.TabIndex = 1;
            btnVoterLogout.Text = "LogOut";
            btnVoterLogout.UseVisualStyleBackColor = false;
            btnVoterLogout.Click += btnVoterLogout_Click;
            // 
            // btnPaulVote
            // 
            btnPaulVote.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaulVote.Location = new Point(577, 496);
            btnPaulVote.Name = "btnPaulVote";
            btnPaulVote.Size = new Size(187, 59);
            btnPaulVote.TabIndex = 14;
            btnPaulVote.Text = "Vote";
            btnPaulVote.UseVisualStyleBackColor = true;
            btnPaulVote.Click += btnPaulVote_Click;
            // 
            // btnDonaldVote
            // 
            btnDonaldVote.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDonaldVote.Location = new Point(81, 496);
            btnDonaldVote.Name = "btnDonaldVote";
            btnDonaldVote.Size = new Size(187, 59);
            btnDonaldVote.TabIndex = 15;
            btnDonaldVote.Text = "Vote";
            btnDonaldVote.UseVisualStyleBackColor = true;
            btnDonaldVote.Click += btnDonaldVote_Click;
            // 
            // lblDonaldMoto
            // 
            lblDonaldMoto.AutoSize = true;
            lblDonaldMoto.BackColor = Color.CadetBlue;
            lblDonaldMoto.Font = new Font("Calibri", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDonaldMoto.Location = new Point(46, 442);
            lblDonaldMoto.Name = "lblDonaldMoto";
            lblDonaldMoto.Size = new Size(251, 28);
            lblDonaldMoto.TabIndex = 16;
            lblDonaldMoto.Text = "\"Tech for a better world!\"";
            // 
            // lblPaulMoto
            // 
            lblPaulMoto.AutoSize = true;
            lblPaulMoto.BackColor = Color.CadetBlue;
            lblPaulMoto.Font = new Font("Calibri", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPaulMoto.Location = new Point(490, 442);
            lblPaulMoto.Name = "lblPaulMoto";
            lblPaulMoto.Size = new Size(340, 28);
            lblPaulMoto.TabIndex = 17;
            lblPaulMoto.Text = "\"Make Programming Great Again\"";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 269);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(505, 158);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(301, 269);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // lblDrPaul
            // 
            lblDrPaul.AutoSize = true;
            lblDrPaul.BackColor = Color.CadetBlue;
            lblDrPaul.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrPaul.Location = new Point(566, 126);
            lblDrPaul.Name = "lblDrPaul";
            lblDrPaul.Size = new Size(165, 29);
            lblDrPaul.TabIndex = 12;
            lblDrPaul.Text = "Candidate 2";
            // 
            // lblDonaldTrump
            // 
            lblDonaldTrump.AutoSize = true;
            lblDonaldTrump.BackColor = Color.CadetBlue;
            lblDonaldTrump.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDonaldTrump.Location = new Point(81, 126);
            lblDonaldTrump.Name = "lblDonaldTrump";
            lblDonaldTrump.Size = new Size(164, 29);
            lblDonaldTrump.TabIndex = 13;
            lblDonaldTrump.Text = "Candidate 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.CadetBlue;
            label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(342, 56);
            label2.Name = "label2";
            label2.Size = new Size(151, 29);
            label2.TabIndex = 19;
            label2.Text = "Vote Now!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.CadetBlue;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(286, 18);
            label1.Name = "label1";
            label1.Size = new Size(283, 29);
            label1.TabIndex = 18;
            label1.Text = "Your Voice Matters.";
            // 
            // VoterScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(837, 589);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPaulMoto);
            Controls.Add(lblDonaldMoto);
            Controls.Add(btnDonaldVote);
            Controls.Add(btnPaulVote);
            Controls.Add(lblDonaldTrump);
            Controls.Add(lblDrPaul);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnVoterLogout);
            Name = "VoterScreen";
            Text = "VoterScreen";
            Load += VoterScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVoterLogout;
        private Button btnPaulVote;
        private Button btnDonaldVote;
        private Label lblDonaldMoto;
        private Label lblPaulMoto;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblDrPaul;
        private Label lblDonaldTrump;
        private Label label2;
        private Label label1;
    }
}