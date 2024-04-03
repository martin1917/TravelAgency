namespace Users.Dto
{
    public class RegistrationDto
    {
        public string Name { get; set; }

        public string SecondName { get; set; }

        public string? Patronymic { get; set; }

        public DateTime Birthday { get; set; }

        public string Email { get; set; }

        public string? PhoneNumber { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string RepeatPassword { get; set; }
    }
}
