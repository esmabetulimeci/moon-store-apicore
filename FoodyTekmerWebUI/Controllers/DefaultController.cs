using Microsoft.AspNetCore.Mvc;

namespace MoonWebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.title1 = "Minimalist Giyim";
        

            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialPageHeader()
        {
            return PartialView();
        }
    }
}
