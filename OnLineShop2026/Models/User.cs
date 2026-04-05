namespace OnLineShop2026.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? Avatar { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        private const string DefaultAvatar = "/images/defaultAvatar.jpg";

        public User()
        {
            Id = Guid.NewGuid();
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Avatar = DefaultAvatar;
        }

        public User(string firstName, string lastName, string email, string? avatar = null)
        {
            Id = Guid.NewGuid();
            FirstName = firstName ?? string.Empty;
            LastName = lastName ?? string.Empty;
            Email = email ?? string.Empty;
            Avatar = string.IsNullOrEmpty(avatar) ? DefaultAvatar : avatar!;
        }

        public override string ToString()
        {
            return $"User: {FullName}, Email: {Email}, Avatar: {(Avatar ?? DefaultAvatar)}";
        }
    }
}