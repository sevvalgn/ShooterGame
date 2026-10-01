using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace ShooterGame
{
    public partial class FormRegister : Form
    {
        private FormLogin loginform;
        public FormRegister(FormLogin formLogin)
        {
            InitializeComponent();
            this.loginform = formLogin;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }
        private async void btnRegister_Click(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;
            try
            {
                if (txtboxPwd.Text == txtboxPwdAgain.Text)
                {
                    string password = txtboxPwd.Text.Trim();
                    string playerName = txtboxName.Text;

                    if (!string.IsNullOrWhiteSpace(playerName) && !string.IsNullOrWhiteSpace(password))
                    {
                        HttpClient client = new HttpClient();
                        User user = new User() { Name = playerName, Password = password };

                        string json = JsonSerializer.Serialize(user);
                        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                        HttpResponseMessage response = await client.PostAsync($"{ApiUrl.url}/api/loginregister/register", content);

                        if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                        {
                            MessageBox.Show("Account for " + playerName + " already exist. Please enter a different name.");
                            return;
                        }
                        else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                        {
                            MessageBox.Show("Please fill in required fields.");
                            return;
                        }

                        MessageBox.Show("Registration successful.");
                        this.Hide();
                        loginform.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please fill in required fields.");
                    }
                }
                else
                {
                    MessageBox.Show("The passwords do not match. Please try again.");
                }
            }
            finally
            {
                btnRegister.Enabled = true;
            }
            
        }
        private void btnBacktoLogin_Click(object sender, EventArgs e)
        {
            btnBacktoLogin.Enabled = false;
            try
            {
                this.Hide();
                loginform.Show();
            }
            finally
            {
                btnBacktoLogin.Enabled = true;
            }
        }
    }
}
