namespace ShooterGame
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            picEnemy = new PictureBox();
            picPlayer = new PictureBox();
            picEnemyBullet = new PictureBox();
            picPlayerHP = new PictureBox();
            picEnemyHP = new PictureBox();
            picPlayerBullet = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lblResult = new Label();
            lblScoreResult = new Label();
            btnBack = new Button();
            btnPicPause = new PictureBox();
            pnlIsExisting = new Panel();
            btnResume = new Button();
            btnExit = new Button();
            lblAreYouSure = new Label();
            ((System.ComponentModel.ISupportInitialize)picEnemy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEnemyBullet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayerHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEnemyHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayerBullet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPicPause).BeginInit();
            pnlIsExisting.SuspendLayout();
            SuspendLayout();
            // 
            // picEnemy
            // 
            picEnemy.BackColor = Color.Transparent;
            picEnemy.BackgroundImageLayout = ImageLayout.Stretch;
            picEnemy.Location = new Point(930, 324);
            picEnemy.Name = "picEnemy";
            picEnemy.Size = new Size(396, 454);
            picEnemy.SizeMode = PictureBoxSizeMode.StretchImage;
            picEnemy.TabIndex = 1;
            picEnemy.TabStop = false;
            // 
            // picPlayer
            // 
            picPlayer.BackColor = Color.Transparent;
            picPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            picPlayer.Location = new Point(180, 450);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(206, 258);
            picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayer.TabIndex = 2;
            picPlayer.TabStop = false;
            // 
            // picEnemyBullet
            // 
            picEnemyBullet.BackColor = Color.Transparent;
            picEnemyBullet.BackgroundImageLayout = ImageLayout.Stretch;
            picEnemyBullet.Location = new Point(830, 469);
            picEnemyBullet.Name = "picEnemyBullet";
            picEnemyBullet.Size = new Size(126, 88);
            picEnemyBullet.SizeMode = PictureBoxSizeMode.StretchImage;
            picEnemyBullet.TabIndex = 3;
            picEnemyBullet.TabStop = false;
            // 
            // picPlayerHP
            // 
            picPlayerHP.BackColor = Color.Transparent;
            picPlayerHP.Location = new Point(-1, 12);
            picPlayerHP.Name = "picPlayerHP";
            picPlayerHP.Size = new Size(423, 159);
            picPlayerHP.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayerHP.TabIndex = 4;
            picPlayerHP.TabStop = false;
            // 
            // picEnemyHP
            // 
            picEnemyHP.BackColor = Color.Transparent;
            picEnemyHP.Location = new Point(879, -1);
            picEnemyHP.Name = "picEnemyHP";
            picEnemyHP.Size = new Size(581, 170);
            picEnemyHP.SizeMode = PictureBoxSizeMode.StretchImage;
            picEnemyHP.TabIndex = 5;
            picEnemyHP.TabStop = false;
            // 
            // picPlayerBullet
            // 
            picPlayerBullet.BackColor = Color.Transparent;
            picPlayerBullet.BackgroundImageLayout = ImageLayout.Stretch;
            picPlayerBullet.Location = new Point(381, 507);
            picPlayerBullet.Name = "picPlayerBullet";
            picPlayerBullet.Size = new Size(100, 88);
            picPlayerBullet.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayerBullet.TabIndex = 6;
            picPlayerBullet.TabStop = false;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Transparent;
            lblResult.Font = new Font("Tempus Sans ITC", 30F, FontStyle.Bold | FontStyle.Italic);
            lblResult.ForeColor = Color.Red;
            lblResult.Location = new Point(381, 288);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(626, 99);
            lblResult.TabIndex = 7;
            lblResult.Text = "<<GAME OVER>>";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScoreResult
            // 
            lblScoreResult.BackColor = Color.Transparent;
            lblScoreResult.Font = new Font("Tempus Sans ITC", 15F, FontStyle.Bold);
            lblScoreResult.ForeColor = Color.Red;
            lblScoreResult.Location = new Point(512, 400);
            lblScoreResult.Name = "lblScoreResult";
            lblScoreResult.Size = new Size(400, 136);
            lblScoreResult.TabIndex = 8;
            lblScoreResult.Text = "Your current score is: this\r\n\r\n\r\n\r\n";
            lblScoreResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Black;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Enabled = false;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Tempus Sans ITC", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Silver;
            btnBack.Location = new Point(592, 667);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(234, 52);
            btnBack.TabIndex = 9;
            btnBack.TabStop = false;
            btnBack.Text = "Back to Menu";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnPicPause
            // 
            btnPicPause.BackColor = Color.Transparent;
            btnPicPause.Image = (Image)resources.GetObject("btnPicPause.Image");
            btnPicPause.Location = new Point(1342, 816);
            btnPicPause.Name = "btnPicPause";
            btnPicPause.Size = new Size(77, 74);
            btnPicPause.SizeMode = PictureBoxSizeMode.StretchImage;
            btnPicPause.TabIndex = 3;
            btnPicPause.TabStop = false;
            btnPicPause.Click += btnPicPause_Click;
            // 
            // pnlIsExisting
            // 
            pnlIsExisting.BackColor = Color.DarkRed;
            pnlIsExisting.Controls.Add(btnResume);
            pnlIsExisting.Controls.Add(btnExit);
            pnlIsExisting.Controls.Add(lblAreYouSure);
            pnlIsExisting.Location = new Point(521, 288);
            pnlIsExisting.Name = "pnlIsExisting";
            pnlIsExisting.Size = new Size(467, 269);
            pnlIsExisting.TabIndex = 10;
            // 
            // btnResume
            // 
            btnResume.BackColor = Color.Chocolate;
            btnResume.FlatStyle = FlatStyle.Popup;
            btnResume.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnResume.ForeColor = Color.Black;
            btnResume.Location = new Point(252, 150);
            btnResume.Name = "btnResume";
            btnResume.Size = new Size(181, 71);
            btnResume.TabIndex = 2;
            btnResume.Text = "No\r\nResume game\r\n";
            btnResume.UseVisualStyleBackColor = false;
            btnResume.Click += btnResume_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Chocolate;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(30, 150);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(184, 71);
            btnExit.TabIndex = 1;
            btnExit.Text = "Yes\r\nReturn to menu";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblAreYouSure
            // 
            lblAreYouSure.AutoSize = true;
            lblAreYouSure.Font = new Font("Tempus Sans ITC", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAreYouSure.ForeColor = Color.Black;
            lblAreYouSure.Location = new Point(30, 33);
            lblAreYouSure.Name = "lblAreYouSure";
            lblAreYouSure.Size = new Size(403, 114);
            lblAreYouSure.TabIndex = 0;
            lblAreYouSure.Text = "     Do you want to exit?\r\n(Your score will not be saved)\r\n\r\n";
            // 
            // FormGame
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1455, 944);
            Controls.Add(pnlIsExisting);
            Controls.Add(btnPicPause);
            Controls.Add(btnBack);
            Controls.Add(lblScoreResult);
            Controls.Add(lblResult);
            Controls.Add(picEnemyBullet);
            Controls.Add(picPlayerBullet);
            Controls.Add(picEnemyHP);
            Controls.Add(picPlayer);
            Controls.Add(picPlayerHP);
            Controls.Add(picEnemy);
            ForeColor = Color.AntiqueWhite;
            Name = "FormGame";
            Load += FormGame_Load;
            ((System.ComponentModel.ISupportInitialize)picEnemy).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEnemyBullet).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayerHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEnemyHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayerBullet).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPicPause).EndInit();
            pnlIsExisting.ResumeLayout(false);
            pnlIsExisting.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picEnemy;
        private PictureBox picPlayer;
        private PictureBox picEnemyBullet;
        private PictureBox picPlayerHP;
        private PictureBox picEnemyHP;
        private PictureBox picPlayerBullet;
        private System.Windows.Forms.Timer timer1;
        private Label lblResult;
        private Label lblScoreResult;
        private Button btnBack;
        private PictureBox btnPicPause;
        private Panel pnlIsExisting;
        private Label lblAreYouSure;
        private Button btnResume;
        private Button btnExit;
    }
}