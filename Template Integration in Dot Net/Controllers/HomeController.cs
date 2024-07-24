using Microsoft.AspNetCore.Mvc;

namespace Template_Integration_in_Dot_Net.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
