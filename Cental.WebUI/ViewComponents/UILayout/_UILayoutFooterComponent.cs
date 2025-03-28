using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.UILayout
{
    public class _UILayoutFooterComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
