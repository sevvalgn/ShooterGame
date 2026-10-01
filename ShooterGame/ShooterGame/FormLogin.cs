using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace ShooterGame
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"Resources\BackgroundLogin.png");
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            try
            {
                string playerName = txtboxName.Text.Trim();
                string password = txtboxPwd.Text;
                if (!string.IsNullOrWhiteSpace(playerName) && !string.IsNullOrWhiteSpace(password))
                {
                    HttpClient client = new HttpClient();
                    User user = new User() { Name = playerName, Password = password };

                    string json = JsonSerializer.Serialize(user);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync($"{ApiUrl.url}/api/loginregister/login", content);
                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("No account for " + playerName + " please register.");
                        return;
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        MessageBox.Show("Unvalid password, please try again.");
                        return;
                    }
                    //hide the login page and show the menu page
                    this.Hide();
                    FormMenu menu = new FormMenu(playerName);
                    menu.Show();
                    btnLogin.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please fill in required fields.");
                }
            }
            finally
            {
                btnLogin.Enabled = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;
            try
            {
                this.Hide();
                FormRegister register = new FormRegister(this);
                register.Show();

            }
            finally
            {
                btnRegister.Enabled = true;
            }
        }
    }
}
