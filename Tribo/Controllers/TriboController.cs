using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Tribo.Controllers
{
    public class TriboController : Controller
    {        
        [Authorize(Roles = "Tribo,Admin")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
