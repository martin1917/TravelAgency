using System.ComponentModel.DataAnnotations;
using System.Globalization;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class CreateUpdateTourForm : Form
    {
        public TourModel? TourModel { get; private set; }

        public bool ReadyToUpdate { get; private set; } = false;

        public CreateUpdateTourForm(TourModel? tourModel = null)
        {
            InitializeComponent();
            TourModel = tourModel;

            if (tourModel is not null)
            {
                tbTourName.Text = tourModel.Name;
                tbCountry.Text =  tourModel.Country;
                tbHotel.Text = tourModel.HotelName;
                tbTypeRoom.Text = tourModel.TypeRoom;
                tbTypeFood.Text =  tourModel.TypeFood;
                tbPricePurchase.Text = $"{tourModel.PricePurchase}";
                tbPriceSale.Text = $"{tourModel.PriceSale}";
                dtpStart.Value = tourModel.DateStart;
                dtpEnd.Value = tourModel.DateEnd;
                cbTourIsActive.Checked = tourModel.IsActive == 1;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var newData = new CreateTour
            {
                Name = tbTourName.Text,
                HotelName = tbHotel.Text,
                Country = tbCountry.Text,
                TypeRoom = tbTypeRoom.Text,
                TypeFood = tbTypeFood.Text,
                PricePurchase = tbPricePurchase.Text,
                PriceSale = tbPriceSale.Text,
                DateStart = dtpStart.Value,
                DateEnd = dtpEnd.Value,
                IsActive = cbTourIsActive.Checked ? 1 : 0
            };

            var results = new List<ValidationResult>();
            var context = new ValidationContext(newData);
            if (!Validator.TryValidateObject(newData, context, results, true))
            {
                var errorMessage = string.Join("\n", results.Select(err => $"• {err.ErrorMessage};"));
                MessageBox.Show($"{errorMessage}", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TourModel ??= new TourModel();
            TourModel.Name = newData.Name;
            TourModel.HotelName = newData.HotelName;
            TourModel.Country = newData.Country;
            TourModel.TypeRoom = newData.TypeRoom;
            TourModel.TypeFood = newData.TypeFood;
            TourModel.PricePurchase = decimal.Parse(newData.PricePurchase, CultureInfo.InvariantCulture);
            TourModel.PriceSale = decimal.Parse(newData.PriceSale, CultureInfo.InvariantCulture);
            TourModel.DateStart = newData.DateStart;
            TourModel.DateEnd = newData.DateEnd;
            TourModel.IsActive = newData.IsActive;
            ReadyToUpdate = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
