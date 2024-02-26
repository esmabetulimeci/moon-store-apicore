using Microsoft.AspNetCore.Mvc;

namespace MoonWebUI.ViewComponents
{
    public class ScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
