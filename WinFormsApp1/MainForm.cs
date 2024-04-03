using System.Net.Http.Json;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnLoadClients_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7181/api/"),
                Timeout = new TimeSpan(0, 0, 30)
            };

            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + CurrentUser.AccessToken);

            var response = await httpClient.GetAsync("users");
            if (!response.IsSuccessStatusCode)
            {
                return;
            }

            dataGridViewClients.Rows.Clear();

            var clients = await response.Content.ReadFromJsonAsync<List<ClientModel>>();
            foreach(var client in clients)
            {
                dataGridViewClients.Rows.Add(
                    client.Id, 
                    client.SecondName,
                    client.Name, 
                    client.Patronymic, 
                    client.Birthday, 
                    client.Email, 
                    client.PhoneNumber);
            }
        }
    }
}
