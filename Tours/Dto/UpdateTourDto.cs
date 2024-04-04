﻿namespace Tours.Dto
{
    public record UpdateTourDto
    {
        public string? Name { get; set; }

        public string? Country { get; set; }

        public string? HotelName { get; set; }

        public string? TypeRoom { get; set; }

        public string? TypeFood { get; set; }

        public decimal? PricePurchase { get; set; }

        public decimal? PriceSale { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateEnd { get; set; }

        public int? IsActive { get; set; }
    }
}
