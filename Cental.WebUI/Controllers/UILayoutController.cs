using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.SiteSettingsSocialMediaDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [AllowAnonymous]
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }
    }
}
