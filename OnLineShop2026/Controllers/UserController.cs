using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Models;
using OnLineShop2026.Data;

namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            User user = new User(
                "Анастасия",
                "Иванова",
                "shadyworkq@gmail.com",
                "/images/avatar.jpg"
            );

            return View(user);
        }

        public IActionResult List()
        {
            var users = _userRepository.GetAll();

            return View(users);
        }
    }
}
