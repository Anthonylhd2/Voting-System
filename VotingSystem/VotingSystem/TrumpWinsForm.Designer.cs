namespace VotingSystem
{
    partial class TrumpWinsForm
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
            pictureBox1.Image = Properties.Resources.Donald_Trump;
            pictureBox1.Location = new Point(330, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 326);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTrumpWonTitle
            // 
            lblTrumpWonTitle.AutoSize = true;
            lblTrumpWonTitle.BackColor = Color.Red;
            lblTrumpWonTitle.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrumpWonTitle.Location = new Point(359, 21);
            lblTrumpWonTitle.Name = "lblTrumpWonTitle";
            lblTrumpWonTitle.Size = new Size(253, 29);
            lblTrumpWonTitle.TabIndex = 8;
            lblTrumpWonTitle.Text = "Election's Results";
            // 
            // lblTumpWonMessage
            // 
            lblTumpWonMessage.AutoSize = true;
            lblTumpWonMessage.BackColor = Color.Red;
            lblTumpWonMessage.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTumpWonMessage.Location = new Point(266, 434);
            lblTumpWonMessage.Name = "lblTumpWonMessage";
            lblTumpWonMessage.RightToLeft = RightToLeft.No;
            lblTumpWonMessage.Size = new Size(465, 87);
            lblTumpWonMessage.TabIndex = 9;
            lblTumpWonMessage.Text = "Donald J. Trump has been Elected  \r\nas the new president of the \r\nUnited States of America";
            lblTumpWonMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TrumpWinsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(975, 583);
            Controls.Add(lblTumpWonMessage);
            Controls.Add(lblTrumpWonTitle);
            Controls.Add(pictureBox1);
            Name = "TrumpWinsForm";
            Text = "TrumpWinsForm";
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