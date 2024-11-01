using Microsoft.AspNetCore.Mvc;

namespace PsychotechnicsWebApp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
