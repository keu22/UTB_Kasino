using Kasino.Application.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace Kasino.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }
        
        public IActionResult Index()
        {
            return View(_userService.GetAll());
        }
    }
}
