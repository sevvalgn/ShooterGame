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
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string feedback = txtboxfeedback.Text;
            Feedbacks feedbacks = new Feedbacks() { Feedback = feedback, Name = playerName};
            if (!string.IsNullOrWhiteSpace(feedback))
            {
                HttpClient client = new HttpClient();
    
                string json = JsonSerializer.Serialize(feedbacks);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("https://localhost:7287/api/feedbacks", content);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Feedback submitted successfully.");
                    this.Hide();
                    menuForm.Show();
                }
                else if(response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Unsuccesfull.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuForm.Show();
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
