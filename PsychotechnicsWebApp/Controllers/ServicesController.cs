using Microsoft.AspNetCore.Mvc;

namespace PsychotechnicsWebApp.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
