namespace VotingSystem
{
    partial class AdminScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminScreen));
            btnAdminLogout = new Button();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            progressBarDonald = new ProgressBar();
            progressBarPaul = new ProgressBar();
            lblAdminTitle = new Label();
            lblDrPaul = new Label();
            lblDonaldTrump = new Label();
            lblDonaldvoteCount = new Label();
            lblDrPaulvoteCount = new Label();
            lblDrPaulVotes = new Label();
            lblTrumpVotes = new Label();
            btnEndElections = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAdminLogout
            // 
            btnAdminLogout.BackColor = Color.Tomato;
            btnAdminLogout.BackgroundImageLayout = ImageLayout.None;
            btnAdminLogout.FlatAppearance.BorderColor = Color.CadetBlue;
            btnAdminLogout.FlatStyle = FlatStyle.Flat;
            btnAdminLogout.Location = new Point(873, 2);
            btnAdminLogout.Name = "btnAdminLogout";
            btnAdminLogout.Size = new Size(90, 46);
            btnAdminLogout.TabIndex = 2;
            btnAdminLogout.Text = "LogOut";
            btnAdminLogout.UseVisualStyleBackColor = false;
            btnAdminLogout.Click += btnAdminLogout_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Dr. Paul Akiki.jpg");
            imageList1.Images.SetKeyName(1, "Donald Trump.jpg");
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "Dr. Paul Akiki.jpg");
            imageList2.Images.SetKeyName(1, "Donald Trump.jpg");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Donald_Trump;
            pictureBox1.Location = new Point(81, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 269);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Dr__Paul_Akiki;
            pictureBox2.Location = new Point(566, 131);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(301, 269);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // progressBarDonald
            // 
            progressBarDonald.Location = new Point(81, 417);
            progressBarDonald.Name = "progressBarDonald";
            progressBarDonald.Size = new Size(301, 41);
            progressBarDonald.TabIndex = 5;
            // 
            // progressBarPaul
            // 
            progressBarPaul.Location = new Point(566, 417);
            progressBarPaul.Name = "progressBarPaul";
            progressBarPaul.Size = new Size(301, 41);
            progressBarPaul.TabIndex = 6;
            // 
            // lblAdminTitle
            // 
            lblAdminTitle.AutoSize = true;
            lblAdminTitle.BackColor = Color.CadetBlue;
            lblAdminTitle.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminTitle.Location = new Point(427, 19);
            lblAdminTitle.Name = "lblAdminTitle";
            lblAdminTitle.Size = new Size(173, 29);
            lblAdminTitle.TabIndex = 7;
            lblAdminTitle.Text = "Live Results";
            // 
            // lblDrPaul
            // 
            lblDrPaul.AutoSize = true;
            lblDrPaul.BackColor = Color.CadetBlue;
            lblDrPaul.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrPaul.Location = new Point(627, 99);
            lblDrPaul.Name = "lblDrPaul";
            lblDrPaul.Size = new Size(198, 29);
            lblDrPaul.TabIndex = 8;
            lblDrPaul.Text = "Dr. Paul Akiki";
            // 
            // lblDonaldTrump
            // 
            lblDonaldTrump.AutoSize = true;
            lblDonaldTrump.BackColor = Color.CadetBlue;
            lblDonaldTrump.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDonaldTrump.Location = new Point(128, 99);
            lblDonaldTrump.Name = "lblDonaldTrump";
            lblDonaldTrump.Size = new Size(201, 29);
            lblDonaldTrump.TabIndex = 9;
            lblDonaldTrump.Text = "Donald Trump";
            // 
            // lblDonaldvoteCount
            // 
            lblDonaldvoteCount.AutoSize = true;
            lblDonaldvoteCount.BackColor = Color.CadetBlue;
            lblDonaldvoteCount.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDonaldvoteCount.Location = new Point(161, 461);
            lblDonaldvoteCount.Name = "lblDonaldvoteCount";
            lblDonaldvoteCount.Size = new Size(28, 29);
            lblDonaldvoteCount.TabIndex = 10;
            lblDonaldvoteCount.Text = "0";
            // 
            // lblDrPaulvoteCount
            // 
            lblDrPaulvoteCount.AutoSize = true;
            lblDrPaulvoteCount.BackColor = Color.CadetBlue;
            lblDrPaulvoteCount.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrPaulvoteCount.Location = new Point(649, 461);
            lblDrPaulvoteCount.Name = "lblDrPaulvoteCount";
            lblDrPaulvoteCount.Size = new Size(28, 29);
            lblDrPaulvoteCount.TabIndex = 11;
            lblDrPaulvoteCount.Text = "0";
            // 
            // lblDrPaulVotes
            // 
            lblDrPaulVotes.AutoSize = true;
            lblDrPaulVotes.BackColor = Color.CadetBlue;
            lblDrPaulVotes.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrPaulVotes.Location = new Point(709, 461);
            lblDrPaulVotes.Name = "lblDrPaulVotes";
            lblDrPaulVotes.Size = new Size(89, 29);
            lblDrPaulVotes.TabIndex = 12;
            lblDrPaulVotes.Text = "Votes";
            // 
            // lblTrumpVotes
            // 
            lblTrumpVotes.AutoSize = true;
            lblTrumpVotes.BackColor = Color.CadetBlue;
            lblTrumpVotes.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrumpVotes.Location = new Point(221, 461);
            lblTrumpVotes.Name = "lblTrumpVotes";
            lblTrumpVotes.Size = new Size(89, 29);
            lblTrumpVotes.TabIndex = 13;
            lblTrumpVotes.Text = "Votes";
            // 
            // btnEndElections
            // 
            btnEndElections.Location = new Point(376, 536);
            btnEndElections.Name = "btnEndElections";
            btnEndElections.Size = new Size(200, 81);
            btnEndElections.TabIndex = 14;
            btnEndElections.Text = "End ELection";
            btnEndElections.UseVisualStyleBackColor = true;
            btnEndElections.Click += button1_Click;
            // 
            // AdminScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(967, 661);
            Controls.Add(btnEndElections);
            Controls.Add(lblTrumpVotes);
            Controls.Add(lblDrPaulVotes);
            Controls.Add(lblDrPaulvoteCount);
            Controls.Add(lblDonaldvoteCount);
            Controls.Add(lblDonaldTrump);
            Controls.Add(lblDrPaul);
            Controls.Add(lblAdminTitle);
            Controls.Add(progressBarPaul);
            Controls.Add(progressBarDonald);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnAdminLogout);
            Name = "AdminScreen";
            Text = "AdminScreen";
            Load += AdminScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdminLogout;
        private ImageList imageList1;
        private ImageList imageList2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ProgressBar progressBarDonald;
        private ProgressBar progressBarPaul;
        private Label lblAdminTitle;
        private Label lblDrPaul;
        private Label lblDonaldTrump;
        private Label lblDonaldvoteCount;
        private Label lblDrPaulvoteCount;
        private Label lblDrPaulVotes;
        private Label lblTrumpVotes;
        private Button btnEndElections;
    }
}