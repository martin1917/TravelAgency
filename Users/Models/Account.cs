namespace Users.Models
{
    public class Account
    {
        public long Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public Client? Client { get; set; }
        public TourAgent? TourAgent { get; set; }
    }
}
