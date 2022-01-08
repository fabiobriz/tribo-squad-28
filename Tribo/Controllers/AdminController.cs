using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Tribo.Controllers
{
    public class AdminController : Controller
    {
        [Authorize(Roles="Admin")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
