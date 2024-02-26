using Microsoft.AspNetCore.Mvc;

namespace MoonWebUI.ViewComponents
{
    public class FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
