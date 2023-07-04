using Microsoft.AspNetCore.Mvc;

namespace HELPDESK.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
