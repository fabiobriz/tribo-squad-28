using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Tribo.Controllers
{
    public class ClienteController : Controller
    {
        [Authorize(Roles = "Cliente,Admin")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
