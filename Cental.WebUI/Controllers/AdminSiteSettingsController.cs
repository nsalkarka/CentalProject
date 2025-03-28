using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.SiteSettingsDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminSiteSettingsController(IMapper _mapper, ISiteSettingsService _siteSettingsService) : Controller
    {

        public IActionResult Index()
        {
            var value= _siteSettingsService.TGetAll();
            var siteset= _mapper.Map<List<ResultSiteSettingsDto>>(value);
            return View(siteset);
        }


        public IActionResult CreateSettings()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSettings(CreateSiteSettingsDto createSiteSettingsDto)
        {
            var value= _mapper.Map<SiteSettings>(createSiteSettingsDto);
            _siteSettingsService.TCreate(value);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult UpdateSettings(int id)
        {
            var value= _siteSettingsService.TGetById(id);
            var siteset= _mapper.Map<UpdateSiteSettingsDto>(value);
            return View(siteset);
        }

        [HttpPost]
        public IActionResult UpdateSettings (UpdateSiteSettingsDto updateSiteSettingsDto)
        {
            var value= _mapper.Map<SiteSettings>(updateSiteSettingsDto);
            _siteSettingsService.TUpdate(value);
            return RedirectToAction(nameof(Index));
        }
    }
}
