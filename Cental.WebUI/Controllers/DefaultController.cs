using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DataAccessLayer.Migrations;
using Cental.DtoLayer.SiteSettingsSocialMediaDtos;
using Cental.DtoLayer.UserSocialDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [AllowAnonymous]
    public class DefaultController(ISiteSettingsService _siteSettingsService) : Controller
    {
        public IActionResult Index()
        {
            var value = _siteSettingsService.TGetAll();
            var setting = value.FirstOrDefault();

            

            ViewBag.SiteName = setting.SiteName;
            ViewBag.SiteLogo = setting.SiteLogo;
            ViewBag.SiteLink = setting.SiteLink;
            ViewBag.Mail = setting.Mail;
            ViewBag.Phone = setting.Phone;
            ViewBag.Fax = setting.Fax;
            ViewBag.WeekendHour = setting.WeekendHours;
            ViewBag.MidWeekHour = setting.MidweekHours;
            ViewBag.VacationHour = setting.Vacationours;

            return View();
        }
    }
}
