using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1.Models
{
    public class CreateTour
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Country { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string HotelName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string TypeRoom { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string TypeFood { get; set; }

        [Required]
        [RegularExpression(@"^\d{1,6}([,.]\d{1,2})?$", ErrorMessage = $"{nameof(PricePurchase)} Неверный формат для денег")]
        public string PricePurchase { get; set; }

        [Required]
        [RegularExpression(@"^\d{1,6}([,.]\d{1,2})?$", ErrorMessage = $"{nameof(PriceSale)} Неверный формат для денег")]
        public string PriceSale { get; set; }

        [Required]
        public DateTime DateStart { get; set; }

        [Required]
        public DateTime DateEnd { get; set; }

        [Required]
        [Range(0, 1)]
        public int IsActive { get; set; }
    }
}
