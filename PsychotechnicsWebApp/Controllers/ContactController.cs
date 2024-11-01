using Microsoft.AspNetCore.Mvc;

namespace PsychotechnicsWebApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
