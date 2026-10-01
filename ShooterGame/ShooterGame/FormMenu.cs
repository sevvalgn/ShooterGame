using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShooterGame
{
    public partial class FormMenu : Form
    {
        private string playerName;
        public FormMenu(string playerName)
        {
            InitializeComponent();
            this.playerName = playerName;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"Resources\BackgroundMenu.png");
        }

        private void picbtnStart_Click(object sender, EventArgs e)
        {
            //hide menu, show characterchoice
            picbtnStart.Enabled = false;
            try
            {
                this.Hide();
                FormCharacterChoice characterchoice = new FormCharacterChoice(this, playerName);
                characterchoice.Show();
            }
            finally
            {
                picbtnStart.Enabled = true;
            }
            
        }

        private void picbtnLeaderboard_Click(object sender, EventArgs e)
        {
            //hide menu, show leaderboard
            picbtnLeaderboard.Enabled = false;
            try
            {
                this.Hide();
                FormLeaderboard leaderboard = new FormLeaderboard(this, playerName);
                leaderboard.Show();
            }
            finally
            {
                picbtnLeaderboard.Enabled = true;
            }
        }

        private void picbtnExit_Click(object sender, EventArgs e)
        {
            //exit the program
            Application.Exit();
        }
    }
}
