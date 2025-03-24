using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;

namespace Cental.WebUI.ViewComponents.Default
{
    public class _DefaultStatisticComponent(ICarService _carService, UserManager<AppUser> _userManager ):ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            ViewBag.carCount= _carService.GetCarCount();
            ViewBag.userCount = _userManager.Users.Count();
            return View();
        }
    }
}
