using System.Net.Http.Json;

namespace WinFormsApp1
{
    public partial class ChangeStatusForm : Form
    {
        private readonly long requestId;

        public bool ChangingIsSuccess { get; private set; } = false;

        public string NewState { get; private set; }

        public ChangeStatusForm(long requestId, string currentStatus)
        {
            InitializeComponent();
            this.requestId = requestId;
            tbCurrentStatus.Text = currentStatus;
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            var httpClient = HttpClientFactory.Create();

            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + CurrentUser.AccessToken);

            var newStatus = MainForm.TextToStatus[comboBoxNewStatus.Text];
            var response = await httpClient.PostAsJsonAsync("requests/change_status", new { RequestId = requestId, NewState = newStatus });
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show($"HTTP code = {response.StatusCode}\n{response.Content}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Статус изменен на {MainForm.StatusToText[newStatus]}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NewState = MainForm.StatusToText[newStatus];
            ChangingIsSuccess = true;
            Close();
        }
    }
}