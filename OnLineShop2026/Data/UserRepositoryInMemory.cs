using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public class UserRepositoryInMemory : IUserRepository
    {
        private static List<User> users = new List<User>()
        {
            new User("Анастасия", "Иванова", "shadyworkq@gmail.com", "/images/avatar.jpg"),
            new User("Яна", "Кайтукова", "yana@gmail.com", "/images/avatar.jpg"),
            new User("Арина", "Цагараева", "arinayo@gmail.com", "/images/avatar.jpg"),
        };

        public List<User> GetAll()
        {
            return users;
        }

        public User? TryGetById(Guid id)
        {
            return users.FirstOrDefault(user => user.Id == id);
        }
    }
}