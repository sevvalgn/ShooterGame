using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text;
using System.Text.Json;
using System.Net.Http;
namespace ShooterGame
{
    public partial class FormFeedback : Form
    {
        private string playerName;
        private FormMenu menuForm;
        public FormFeedback(FormMenu menuForm, string playerName)
        {
            InitializeComponent();
            this.menuForm = menuForm;
            this.playerName = playerName;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            try
            {
                string feedback = txtboxfeedback.Text;
                Feedbacks feedbacks = new Feedbacks() { Feedback = feedback, Name = playerName };
                if (!string.IsNullOrWhiteSpace(feedback))
                {
                    HttpClient client = new HttpClient();

                    string json = JsonSerializer.Serialize(feedbacks);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync($"{ApiUrl.url}/api/feedbacks", content);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Feedback submitted successfully.");
                        this.Hide();
                        menuForm.Show();
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        MessageBox.Show("Unsuccesfull.");
                    }
                    else
                    {
                        MessageBox.Show("Already submitted.");
                    }
                }
            }
            finally
            {
                btnSend.Enabled = true;
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

        private void FormFeedback_Load(object sender, EventArgs e)
        {
            txtboxfeedback.MaxLength = 500;
        }

        private void txtboxfeedback_TextChanged(object sender, EventArgs e)
        {
            int remaining = txtboxfeedback.MaxLength - txtboxfeedback.TextLength;
            lblCharacterCount.Text = "/" + remaining;
        }
    }
}
