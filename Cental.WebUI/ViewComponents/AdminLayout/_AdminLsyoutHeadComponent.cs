﻿using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.AdminLayout
{
    public class _AdminLsyoutHeadComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
