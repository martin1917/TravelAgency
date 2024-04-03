namespace Users.Models
{
    public class TourAgent
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string SecondName { get; set; }

        public string? Patronymic { get; set; }

        public long AccountId { get; set; }
        public Account? Account { get; set; }
    }
}
