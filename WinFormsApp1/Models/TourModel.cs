using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1.Models
{
    public class TourModel
    {
        public long Id { get; set; }

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
        public decimal PricePurchase { get; set; }

        [Required]
        public decimal PriceSale { get; set; }

        [Required]
        public DateTime DateStart { get; set; }

        [Required]
        public DateTime DateEnd { get; set; }

        [Required]
        [Range(0, 1)]
        public int IsActive { get; set; }
    }
}
