using Microsoft.AspNetCore.Mvc;

namespace PsychotechnicsWebApp.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult _MainLayout()
        {
            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult SpinnerPartial()
        {
            return PartialView();
        }
        
        public PartialViewResult TopBarPartial()
        {
            return PartialView();
        }
        
        public PartialViewResult NavBarPartial()
        {
            return PartialView();
        }
        
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
        
        public PartialViewResult CopyrightPartial()
        {
            return PartialView();
        }
        
        public PartialViewResult BacktotheTopPartial()
        {
            return PartialView();
        }
        
        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
    }
}

