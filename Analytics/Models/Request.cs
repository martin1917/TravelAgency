namespace Analytics.Models
{
    public class Request
    {
        public long Id { get; set; }

        public long TourId { get; set; }

        public long UserId { get; set; }

        public long? TourAgentId { get; set; }

        public string Status { get; set; }

        public DateTime Date { get; set; }

        public Tour? Tour { get; set; }
    }
}
