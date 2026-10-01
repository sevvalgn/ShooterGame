using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;
using System.Net.Http;

namespace ShooterGame
{
    public partial class FormGame : Form
    {
        private FormMenu menuForm;
        private Player player;
        private Player Enemy = new Enemy("Enemy", "Enemy", 0);
        private List<Image> playerImages;
        private List<Image> enemyImages;
        private List<Image> playerHpImages;
        private List<Image> enemyHpImages;
        private int playerHpFrame = 0;
        private decimal enemyHpFrame = 0;
        private bool isJumping;
        private int jumpPhase = 0;
        private bool isPlayerDamaged;
        private int playerDamagedTime = 0;
        private bool isEnemyDamaged;
        private int enemyDamagedTime = 0;
        private DateTime gameStart;



        public FormGame(FormMenu menuForm, Player player)
        {
            InitializeComponent();

            this.menuForm = menuForm;
            this.player = player;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            playerImages = player.GetPlayerImage();
            enemyImages = Enemy.GetPlayerImage();
            playerHpImages = player.GetHPBarImage();
            enemyHpImages = Enemy.GetHPBarImage();
            timer1.Tick -= timer1_Tick;
            timer1.Tick += timer1_Tick;
            KeyDown -= FormGame_KeyDown;
            KeyDown += FormGame_KeyDown;
            this.DoubleBuffered = true;

        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"Resources\BackgroundGame1.png");
            pnlIsExisting.Visible = false;
            lblResult.Visible = false;
            lblScoreResult.Visible = false;
            picEnemyBullet.Visible = false;
            picPlayerBullet.Visible = false;
            btnBack.Visible = false;
            picPlayer.Image = playerImages.ElementAt(0);
            picEnemy.Image = enemyImages.ElementAt(0);
            picPlayerHP.Image = playerHpImages.ElementAt(0);
            picEnemyHP.Image = enemyHpImages.ElementAt(0);
            picPlayerBullet.Image = player.GetBulletImage();
            picEnemyBullet.Image = Enemy.GetBulletImage();
            gameStart = DateTime.Now;
            timer1.Start();
        }
        private void FormGame_KeyDown(object sender, KeyEventArgs a)
        {
            if (a.KeyCode == Keys.Space && !isJumping)
            {
                picPlayer.Image = playerImages.ElementAt(5);
                picPlayerBullet.Visible = true;
            }
            else if (a.KeyCode == Keys.Up)
            {
                isJumping = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int enemyAttack = Enemy.Attack();
            int playerAttack = player.Attack();
            if (isJumping)
            {
                jumpPhase++;
                if (jumpPhase == 1)
                {
                    picPlayer.Image = playerImages.ElementAt(1);
                    picPlayer.Top -= 150;
                }
                else if (jumpPhase == 2)
                {
                    picPlayer.Image = playerImages.ElementAt(2);
                    picPlayer.Top -= 150;
                }
                else if (jumpPhase == 11)
                {
                    picPlayer.Image = playerImages.ElementAt(3);
                    picPlayer.Top += 150;
                }
                else if (jumpPhase == 13)
                {
                    picPlayer.Image = playerImages.ElementAt(3);
                    picPlayer.Top += 150;

                }
                else if (jumpPhase == 15)
                {
                    picPlayer.Image = playerImages.ElementAt(0);
                    jumpPhase = 0;
                    isJumping = false;
                }
            }
            picEnemyBullet.Visible = true;

            if (picEnemyBullet.Right < 0)
            {
                picEnemyBullet.Location = new Point(830, 469);
                picEnemyBullet.Visible = false;
            }
            else if (picEnemyBullet.Bounds.IntersectsWith(picPlayer.Bounds))
            {
                isPlayerDamaged = true;
                picEnemyBullet.Visible = false;
                picEnemyBullet.Location = new Point(830, 469);
                playerHpFrame += enemyAttack / 100;
                if (playerHpFrame < playerHpImages.Count)
                {
                    picPlayerHP.Image = playerHpImages.ElementAt(playerHpFrame);
                }
                player.CurrentHealth = player.CurrentHealth - enemyAttack;
                player.PlayerScore -= (int)((double)enemyAttack / player.Health() * 1200);
            }
            else
            {
                picEnemyBullet.Left -= 40;
            }
            if (isPlayerDamaged)
            {
                playerDamagedTime++;
                if (playerDamagedTime == 1)
                {
                    picPlayer.Image = playerImages.ElementAt(4);
                }
                else if (playerDamagedTime == 3)
                {
                    picPlayer.Image = playerImages.ElementAt(0);
                    playerDamagedTime = 0;
                    isPlayerDamaged = false;
                }
            }

            if (picPlayerBullet.Visible)
            {
                picPlayerBullet.Left += 40;
                if (picPlayerBullet.Bounds.IntersectsWith(picEnemy.Bounds))
                {
                    isEnemyDamaged = true;
                    picPlayerBullet.Visible = false;
                    picPlayerBullet.Location = new Point(381, 507);
                    Enemy.CurrentHealth = Enemy.CurrentHealth - playerAttack;
                    enemyHpFrame = enemyHpImages.Count - (Enemy.CurrentHealth / 1000 + 1);
                    if (enemyHpFrame < enemyHpImages.Count)
                    {
                        picEnemyHP.Image = enemyHpImages.ElementAt((int)enemyHpFrame);
                    }
                    else if (enemyHpFrame >= enemyHpImages.Count)
                    {
                        picEnemyHP.Image = enemyHpImages.ElementAt(14);
                    }
                    player.PlayerScore += playerAttack;
                }
            }
            if (isEnemyDamaged)
            {
                enemyDamagedTime++;
                if (enemyDamagedTime == 1)
                {
                    picEnemy.Image = enemyImages.ElementAt(2);
                }
                else if (enemyDamagedTime == 3)
                {
                    picEnemy.Image = enemyImages.ElementAt(0);
                    isEnemyDamaged = false;
                    enemyDamagedTime = 0;
                }
            }
            if (Enemy.CurrentHealth <= 0)
            {
                int timespent = (int)(DateTime.Now - gameStart).TotalSeconds;
                player.PlayerScore = player.PlayerScore + timespent * 100;
                timer1.Stop();
                lblResult.Text = "<<VICTORY>>";
                lblScoreResult.Text = "Your current score is: " + player.PlayerScore;
                this.BackgroundImage = Image.FromFile(@"Resources\BackgroundGame2.png");
                btnPicPause.Visible = false;
                lblResult.Visible = true;
                lblScoreResult.Visible = true;
                this.Refresh();
                _ = SaveScore(player);
                btnBack.Visible = true;
                btnBack.Enabled = true;
            }
            else if (player.CurrentHealth <= 0)
            {
                int timespent = (int)(DateTime.Now - gameStart).TotalSeconds;
                player.PlayerScore = player.PlayerScore + timespent * 100;
                timer1.Stop();
                lblResult.Text = "<<GAME OVER>>";
                lblScoreResult.Text = "Your current score is: " + player.PlayerScore;
                btnPicPause.Visible = false;
                lblResult.Visible = true;
                lblScoreResult.Visible = true;
                this.Refresh();
                _ = SaveScore(player);
                btnBack.Visible = true;
                btnBack.Enabled = true;
            }
        }
        static async Task SaveScore(Player player)
        {

            HttpClient client = new HttpClient();
            LeaderboardPlayer leaderboardPlayer = new LeaderboardPlayer()
            {
                Name = player.PlayerName,
                CharacterType = player.CharacterType,
                Score = player.PlayerScore
            };
            string json = JsonSerializer.Serialize(leaderboardPlayer);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync($"{ApiUrl.url}/api/leaderboard", content);
            if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
            {
                await client.PutAsync($"{ApiUrl.url}/api/leaderboard", content);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnBack.Enabled = false;
            try
            {
                this.Hide();
                menuForm.Show();
            }
            finally
            {
                btnBack.Enabled = true;
            }
        }

        private void btnPicPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pnlIsExisting.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            menuForm.Show();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pnlIsExisting.Visible = false;
            this.ActiveControl = null;
            this.Focus();
        }
    }
}

