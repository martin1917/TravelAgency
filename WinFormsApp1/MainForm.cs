using OxyPlot;
using OxyPlot.Series;
using System.Net.Http.Json;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public static Dictionary<string, string> StatusToText { get; } = new()
        {
            {"new", "НЕОБРАБОТАНА" },
            {"wait_operator_answer", "ОЖИДАНИЕ" },
            {"paid", "ОПЛАЧЕНА" },
            {"cancel", "ОТМЕНЕНА" },
        };

        public static Dictionary<string, string> TextToStatus { get; } = new()
        {
            { "НЕОБРАБОТАНА", "new" },
            { "ОЖИДАНИЕ", "wait_operator_answer" },
            { "ОПЛАЧЕНА", "paid" },
            { "ОТМЕНЕНА", "cancel" }
        };

        private DataGridViewCell selectedCellTour;

        private DataGridViewCell selectedCellRequest;

        public MainForm()
        {
            InitializeComponent();
            if (CurrentUser.Role!.Equals("client"))
            {
                tabControl1.TabPages.Remove(tabClients);
                tabControl1.TabPages.Remove(tabAnalytics);

                btnAddTour.Visible = false;
                dataGridViewTours.CellDoubleClick -= dataGridViewTours_CellDoubleClick!;
                dataGridViewTours.CellMouseClick += dataGridViewTours_CellMouseClick!;

                btnLoadRequests.Click -= btnLoadRequests_Click!;
                btnLoadRequests.Click += btnLoadRequests_ClickClient!;
                dataGridViewRequests.CellMouseClick -= dataGridViewRequests_CellMouseClick!;
            }
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            tbCurrentRole.Text = CurrentUser.Role;

            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7120/api/"),
                Timeout = new TimeSpan(0, 0, 30)
            };

            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + CurrentUser.AccessToken);

            if (CurrentUser.Role.Equals("client"))
            {
                var response = await httpClient.GetAsync("clients/me");
                if (!response.IsSuccessStatusCode)
                {
                    return;
                }

                var data = await response.Content.ReadFromJsonAsync<ClientModel>();
                tbCurrentUsername.Text = $"{data.SecondName} {data.Name[0]}. {data.Patronymic?[0]}.";
            }
            else if (CurrentUser.Role.Equals("touragent"))
            {
                var response = await httpClient.GetAsync("touragents/me");
                if (!response.IsSuccessStatusCode)
                {
                    return;
                }

                var data = await response.Content.ReadFromJsonAsync<TourAgentModel>();
                tbCurrentUsername.Text = $"{data.SecondName} {data.Name[0]}. {data.Patronymic?[0]}.";
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CurrentUser.Username = null;
            CurrentUser.Role = null;
            CurrentUser.AccessToken = null;
        }

        #region clients tab
        private async void btnLoadClients_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7120/api/"),
                Timeout = new TimeSpan(0, 0, 30)
            };

            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + CurrentUser.AccessToken);

            var response = await httpClient.GetAsync("clients");
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
        #endregion

        #region tours tab
        private async void btnLoadTours_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7120/api/"),
                Timeout = new TimeSpan(0, 0, 30)
            };

            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {CurrentUser.AccessToken}");

            var response = await httpClient.GetAsync("tours");
            if (!response.IsSuccessStatusCode)
            {
                return;
            }

            dataGridViewTours.Rows.Clear();
            var tours = await response.Content.ReadFromJsonAsync<List<TourModel>>();
            foreach (var tour in tours)
            {
                dataGridViewTours.Rows.Add(
                    tour.Id,
                    tour.Name,
                    tour.Country,
                    tour.HotelName,
                    tour.TypeRoom,
                    tour.TypeFood,
                    tour.PricePurchase,
                    tour.PriceSale,
                    tour.DateStart,
                    tour.DateEnd,
                    tour.IsActive);
            }
        }

        private async void btnAddTour_Click(object sender, EventArgs e)
        {
            var createTourForm = new CreateUpdateTourForm();
            createTourForm.ShowDialog();

            if (createTourForm.TourModel is null)
            {
                return;
            }

            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7120/api/"),
                Timeout = new TimeSpan(0, 0, 30)
            };

            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {CurrentUser.AccessToken}");

            var addResponse = await httpClient.PostAsJsonAsync("tours", createTourForm.TourModel);
            if (addResponse.IsSuccessStatusCode)
            {
                var addedTour = await addResponse.Content.ReadFromJsonAsync<TourModel>();
                dataGridViewTours.Rows.Add(
                    addedTour.Id,
                    addedTour.Name,
                    addedTour.Country,
                    addedTour.HotelName,
                    addedTour.TypeRoom,
                    addedTour.TypeFood,
                    addedTour.PricePurchase,
                    addedTour.PriceSale,
                    addedTour.DateStart,
                    addedTour.DateEnd,
                    addedTour.IsActive);
            }
        }

        private async void dataGridViewTours_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTours.Rows[e.RowIndex].Cells[e.ColumnIndex].Value is null)
            {
                return;
            }

            var row = dataGridViewTours.Rows[e.RowIndex];
            var selectedTour = new TourModel
            {
                Id = long.Parse(row.Cells[0].Value.ToString()),
                Name = row.Cells[1].Value.ToString(),
                Country = row.Cells[2].Value.ToString(),
                HotelName = row.Cells[3].Value.ToString(),
                TypeRoom = row.Cells[4].Value.ToString(),
                TypeFood = row.Cells[5].Value.ToString(),
                PricePurchase = decimal.Parse(row.Cells[6].Value.ToString()),
                PriceSale = decimal.Parse(row.Cells[7].Value.ToString()),
                DateStart = DateTime.Parse(row.Cells[8].Value.ToString()),
                DateEnd = DateTime.Parse(row.Cells[9].Value.ToString()),
                IsActive = int.Parse(row.Cells[10].Value.ToString())
            };

            var createTourForm = new CreateUpdateTourForm(selectedTour);
            createTourForm.ShowDialog();

            if (!createTourForm.ReadyToUpdate)
            {
                return;
            }

            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7120/api/"),
                Timeout = new TimeSpan(0, 0, 30)
            };

            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {CurrentUser.AccessToken}");

            var updateResponse = await httpClient.PutAsJsonAsync($"tours/{selectedTour.Id}", createTourForm.TourModel);
            if (updateResponse.IsSuccessStatusCode)
            {
                var updatedTour = await updateResponse.Content.ReadFromJsonAsync<TourModel>();
                row.Cells[0].Value = updatedTour.Id;
                row.Cells[1].Value = updatedTour.Name;
                row.Cells[2].Value = updatedTour.Country;
                row.Cells[3].Value = updatedTour.HotelName;
                row.Cells[4].Value = updatedTour.TypeRoom;
                row.Cells[5].Value = updatedTour.TypeFood;
                row.Cells[6].Value = updatedTour.PricePurchase;
                row.Cells[7].Value = updatedTour.PriceSale;
                row.Cells[8].Value = updatedTour.DateStart;
                row.Cells[9].Value = updatedTour.DateEnd;
                row.Cells[10].Value = updatedTour.IsActive;
            }

            dataGridViewTours.Update();
        }

        private void dataGridViewTours_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var cell = selectedCellTour = dataGridViewTours.Rows[e.RowIndex].Cells[e.ColumnIndex];
                Rectangle r = dataGridViewTours.GetCellDisplayRectangle(cell.ColumnIndex, cell.RowIndex, false);
                var p = new Point(r.X + r.Width / 2, r.Y + r.Height / 2);
                contextMenuStripTours.Show(dataGridViewTours, p);
            }
        }
        #endregion

        #region requests tab
        private async void btnLoadRequests_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7120/api/"),
                Timeout = new TimeSpan(0, 0, 30)
            };

            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + CurrentUser.AccessToken);

            if (!TextToStatus.TryGetValue(comboBoxStatus.Text, out var status))
            {
                status = "";
            }

            var response = await httpClient.GetAsync($"requests?status={status}");
            if (!response.IsSuccessStatusCode)
            {
                return;
            }

            dataGridViewRequests.Rows.Clear();
            var requests = await response.Content.ReadFromJsonAsync<List<RequestModel>>();
            foreach(var req in requests)
            {
                dataGridViewRequests.Rows.Add(
                    req.Id,
                    req.UserId,
                    req.TourId,
                    req.TourAgentId,
                    StatusToText[req.Status],
                    req.Date
                    );
            }
        }

        private async void btnLoadRequests_ClickClient(object sender, EventArgs e)
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7120/api/"),
                Timeout = new TimeSpan(0, 0, 30)
            };

            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + CurrentUser.AccessToken);

            if (!TextToStatus.TryGetValue(comboBoxStatus.Text, out var status))
            {
                status = "";
            }

            var response = await httpClient.GetAsync($"requests/me?status={status}");
            if (!response.IsSuccessStatusCode)
            {
                return;
            }

            dataGridViewRequests.Rows.Clear();
            var requests = await response.Content.ReadFromJsonAsync<List<RequestModel>>();
            foreach (var req in requests)
            {
                dataGridViewRequests.Rows.Add(
                    req.Id,
                    req.UserId,
                    req.TourId,
                    req.TourAgentId,
                    StatusToText[req.Status],
                    req.Date
                    );
            }
        }

        private async void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7120/api/"),
                Timeout = new TimeSpan(0, 0, 30)
            };

            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + CurrentUser.AccessToken);

            var row = dataGridViewTours.Rows[selectedCellTour.RowIndex];
            var tourId = long.Parse(row.Cells[0].Value.ToString());
            var response = await httpClient.PostAsJsonAsync("requests", new { ToorId = tourId });
            if (!response.IsSuccessStatusCode)
            {
                return;
            }

            dataGridViewTours.Rows.Remove(row);

            var addedRequest = await response.Content.ReadFromJsonAsync<RequestModel>();
            if (dataGridViewRequests.RowCount != 0)
            {
                dataGridViewRequests.Rows.Add(
                    addedRequest.Id,
                    addedRequest.UserId,
                    addedRequest.TourId,
                    addedRequest.TourAgentId,
                    StatusToText[addedRequest.Status],
                    addedRequest.Date);
            }
        }

        private void dataGridViewRequests_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var cell = selectedCellRequest = dataGridViewRequests.Rows[e.RowIndex].Cells[e.ColumnIndex];
                Rectangle r = dataGridViewRequests.GetCellDisplayRectangle(cell.ColumnIndex, cell.RowIndex, false);
                var p = new Point(r.X + r.Width / 2, r.Y + r.Height / 2);
                contextMenuStripRequests.Show(dataGridViewRequests, p);
            }
        }

        private void contextMenuStripRequests_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var row = dataGridViewRequests.Rows[selectedCellRequest.RowIndex];
            var requestId = long.Parse(row.Cells[0].Value.ToString());
            var status = row.Cells[4].Value.ToString();

            var changeStatusForm = new ChangeStatusForm(requestId, status);
            changeStatusForm.ShowDialog();

            if (changeStatusForm.ChangingIsSuccess)
            {
                row.Cells[4].Value = changeStatusForm.NewState;
            }
        }
        #endregion

        #region stats
        private async void btnStatCountry_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7120/api/"),
                Timeout = new TimeSpan(0, 0, 30)
            };

            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + CurrentUser.AccessToken);
            var response = await httpClient.GetAsync("analytics/top_country");
            if (!response.IsSuccessStatusCode)
            {
                return;
            }

            var countriesStats = await response.Content.ReadFromJsonAsync<List<CountriesStat>>();

            dataGridViewStats.Rows.Clear();
            dataGridViewStats.Columns.Clear();

            dataGridViewStats.Columns.Add("ColumnStatsCountry", "Страна");
            dataGridViewStats.Columns.Add("ColumnStatsCountryCountTours", "Количество купленных путевок");
            dataGridViewStats.Columns.Add("ColumnStatsTotalProfit", "Общая выручка");

            var model = new PlotModel { Title = "Статистика по странам" };
            var series = new PieSeries { StrokeThickness = 2.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 };
            foreach (var stat in countriesStats)
            {
                dataGridViewStats.Rows.Add(stat.Country, stat.Count, stat.TotalProfit);
                series.Slices.Add(new PieSlice($"{stat.Country}", (double)stat.TotalProfit));
            }
            model.Series.Add(series);
            plotView1.Model = model;
        }

        private async void btnStatClient_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7120/api/"),
                Timeout = new TimeSpan(0, 0, 30)
            };

            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + CurrentUser.AccessToken);
            var response = await httpClient.GetAsync("analytics/client_stats");
            if (!response.IsSuccessStatusCode)
            {
                return;
            }

            var clientsStats = await response.Content.ReadFromJsonAsync<List<ClientsStat>>();

            dataGridViewStats.Rows.Clear();
            dataGridViewStats.Columns.Clear();

            dataGridViewStats.Columns.Add("ColumnStatsClientID", "ID Клиента");
            dataGridViewStats.Columns.Add("ColumnStatsCountTours", "Количество купленных путевок");
            dataGridViewStats.Columns.Add("ColumnStatsTotalMoney", "Общая потраченная сумма");

            var model = new PlotModel { Title = "Статистика по клиентам" };
            var series = new PieSeries { StrokeThickness = 2.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0,  };
            foreach (var stat in clientsStats)
            {
                dataGridViewStats.Rows.Add(stat.ClientId, stat.Count, stat.TotalMoney);
                series.Slices.Add(new PieSlice($"{stat.ClientId}", (double)stat.TotalMoney));
            }

            model.Series.Add(series);
            plotView1.Model = model;
        }
        #endregion
    }
}
