namespace ShooterGame
{
    partial class FormLeaderboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLeaderboard));
            lblLeaderboard = new Label();
            btnReturnMenu = new Button();
            picFeedback = new PictureBox();
            pictureBox1 = new PictureBox();
            lblLoading = new Label();
            ((System.ComponentModel.ISupportInitialize)picFeedback).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblLeaderboard
            // 
            lblLeaderboard.BackColor = Color.Transparent;
            lblLeaderboard.Font = new Font("Tempus Sans ITC", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeaderboard.ForeColor = Color.Black;
            lblLeaderboard.Location = new Point(428, 88);
            lblLeaderboard.Name = "lblLeaderboard";
            lblLeaderboard.Size = new Size(627, 364);
            lblLeaderboard.TabIndex = 0;
            // 
            // btnReturnMenu
            // 
            btnReturnMenu.BackColor = Color.DarkOliveGreen;
            btnReturnMenu.Cursor = Cursors.Hand;
            btnReturnMenu.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturnMenu.ForeColor = Color.FromArgb(255, 255, 192);
            btnReturnMenu.Location = new Point(48, 748);
            btnReturnMenu.Name = "btnReturnMenu";
            btnReturnMenu.Size = new Size(220, 46);
            btnReturnMenu.TabIndex = 1;
            btnReturnMenu.Text = "<<<Back to Menu";
            btnReturnMenu.UseVisualStyleBackColor = false;
            btnReturnMenu.Click += btnReturnMenu_Click;
            // 
            // picFeedback
            // 
            picFeedback.BackColor = Color.Transparent;
            picFeedback.BackgroundImage = (Image)resources.GetObject("picFeedback.BackgroundImage");
            picFeedback.BackgroundImageLayout = ImageLayout.Stretch;
            picFeedback.Cursor = Cursors.Hand;
            picFeedback.Location = new Point(1251, 676);
            picFeedback.Name = "picFeedback";
            picFeedback.Size = new Size(214, 192);
            picFeedback.SizeMode = PictureBoxSizeMode.StretchImage;
            picFeedback.TabIndex = 2;
            picFeedback.TabStop = false;
            picFeedback.Click += picFeedback_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1130, 592);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.BackColor = Color.Transparent;
            lblLoading.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLoading.ForeColor = Color.Olive;
            lblLoading.Location = new Point(573, 238);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(349, 42);
            lblLoading.TabIndex = 4;
            lblLoading.Text = "Leaderboard is loadig...";
            // 
            // FormLeaderboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.BackgroundLeaderboard;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1462, 880);
            Controls.Add(picFeedback);
            Controls.Add(pictureBox1);
            Controls.Add(btnReturnMenu);
            Controls.Add(lblLoading);
            Controls.Add(lblLeaderboard);
            DoubleBuffered = true;
            Name = "FormLeaderboard";
            Text = "Leaderboard";
            ((System.ComponentModel.ISupportInitialize)picFeedback).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLeaderboard;
        private Button btnReturnMenu;
        private PictureBox picFeedback;
        private PictureBox pictureBox1;
        private Label lblLoading;
    }
}