using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;

namespace ShooterGame
{
    public partial class FormLeaderboard : Form
    {
        private FormMenu menuForm;

        private string playerName;
        public FormLeaderboard(FormMenu menu, string playerName)
        {
            this.playerName = playerName;

            InitializeComponent();
            this.menuForm = menu;
            Load += FormLeaderboard_Load;

        }
        private async void FormLeaderboard_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"Resources\BackgroundLeaderboard.png");
            await Leaderboard();
        }
        public async Task Leaderboard()
        {
            HttpClient client = new HttpClient();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            string json = await client.GetStringAsync("https://localhost:7287/api/leaderboard/10");
            List<LeaderboardPlayer> leaderboard = JsonSerializer.Deserialize<List<LeaderboardPlayer>>(json, options);
            if(leaderboard == null)
            {
                return;
            }
            foreach (LeaderboardPlayer player in leaderboard)
            {
                if (player.Name == playerName)
                {
                    lblLeaderboard.Text += ">>";
                }
                lblLeaderboard.Text += $"{player.Name} - {player.CharacterType} - {player.Score} \n";
            }
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuForm.Show();
        }

        private void picFeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFeedback feedback = new FormFeedback(menuForm, playerName);
            feedback.Show();
        }
    }
}
