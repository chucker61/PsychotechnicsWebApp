using Microsoft.AspNetCore.Mvc;

namespace PsychotechnicsWebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
