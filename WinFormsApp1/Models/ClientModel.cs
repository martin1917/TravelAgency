namespace WinFormsApp1.Models
{
    public class ClientModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string SecondName { get; set; }

        public string? Patronymic { get; set; }

        public DateTime Birthday { get; set; }

        public string Email { get; set; }

        public string? PhoneNumber { get; set; }

        public long AccountId { get; set; }
    }
}
