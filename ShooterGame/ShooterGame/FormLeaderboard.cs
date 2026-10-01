using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

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
            string json = await client.GetStringAsync($"{ApiUrl.url}/api/leaderboard/10");
            List<LeaderboardPlayer> leaderboard = JsonSerializer.Deserialize<List<LeaderboardPlayer>>(json, options);
            if(leaderboard == null)
            {
                return;
            }
            lblLoading.SendToBack();
            for(int i = 0; i < leaderboard.Count; i++)
            {
                if (leaderboard[i].Name == playerName)
                {
                    lblLeaderboard.Text += ">>";
                }
                if (i == 0)
                {
                    lblLeaderboard.Text += "🥇 ";
                }
                if (i == 1)
                    lblLeaderboard.Text += "🥈 ";

                if (i == 2)
                    lblLeaderboard.Text += "🥉 ";
                lblLeaderboard.Text += $"{i + 1}. {leaderboard[i].Name} - {leaderboard[i].CharacterType} - {leaderboard[i].Score} \n";
                await Task.Delay(150);
            }
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            btnReturnMenu.Enabled = false;
            try
            {
                this.Hide();
                menuForm.Show();

            }
            finally
            {
                btnReturnMenu.Enabled = true;
            }
        }

        private void picFeedback_Click(object sender, EventArgs e)
        {
            picFeedback.Enabled = false;
            try
            {
                this.Hide();
                FormFeedback feedback = new FormFeedback(menuForm, playerName);
                feedback.Show();
            }
            finally
            {
                picFeedback.Enabled = true;
            }


        }
    }
}
