namespace VotingSystem
{
    partial class DrPaulWinsForm
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
            pictureBox1 = new PictureBox();
            lblTrumpWonTitle = new Label();
            lblTumpWonMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Dr__Paul_Akiki;
            pictureBox1.Location = new Point(245, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 326);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTrumpWonTitle
            // 
            lblTrumpWonTitle.AutoSize = true;
            lblTrumpWonTitle.BackColor = Color.Lime;
            lblTrumpWonTitle.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrumpWonTitle.Location = new Point(274, 9);
            lblTrumpWonTitle.Name = "lblTrumpWonTitle";
            lblTrumpWonTitle.Size = new Size(253, 29);
            lblTrumpWonTitle.TabIndex = 9;
            lblTrumpWonTitle.Text = "Election's Results";
            // 
            // lblTumpWonMessage
            // 
            lblTumpWonMessage.AutoSize = true;
            lblTumpWonMessage.BackColor = Color.Lime;
            lblTumpWonMessage.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTumpWonMessage.Location = new Point(23, 406);
            lblTumpWonMessage.Name = "lblTumpWonMessage";
            lblTumpWonMessage.RightToLeft = RightToLeft.No;
            lblTumpWonMessage.Size = new Size(741, 87);
            lblTumpWonMessage.TabIndex = 10;
            lblTumpWonMessage.Text = "DR. PAUL AKIKI HAS ACHIEVED AN UNPRECEDENTED VICTORY,\r\nUNITING THE NATION WITH HIS VISIONARY LEADERSHIP AS \r\nTHE NEW PRESIDENT OF THE UNITED STATES OF AMERICA!";
            lblTumpWonMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DrPaulWinsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(800, 524);
            Controls.Add(lblTumpWonMessage);
            Controls.Add(lblTrumpWonTitle);
            Controls.Add(pictureBox1);
            Name = "DrPaulWinsForm";
            Text = "DrPaulWinsForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTrumpWonTitle;
        private Label lblTumpWonMessage;
    }
}