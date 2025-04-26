using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.SiteSettingsAdressDtos;
using Cental.DtoLayer.SiteSettingsDtos;
using Cental.DtoLayer.SiteSettingsQuickLinkDtos;
using Cental.DtoLayer.SiteSettingsSocialMediaDtos;
using Cental.DtoLayer.SiteSettingsTopMenuDtos;
using Cental.DtoLayer.ViewModels;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminSiteSettingsController(IMapper _mapper, ISiteSettingsService _siteSettingsService, ISiteSettingsAdressService _siteSettingsAdressService, ISiteSettingsQuickLinkService _siteSettingsQuickLinkService, ISiteSettingsSocialMediaService _siteSettingsSocialMediaService, ISiteSettingsTopMenuService _siteSettingsTopMenuService) : Controller
    {

        public IActionResult Index()
        {
            
            var siteSettingsValue = _siteSettingsService.TGetAll();
            var siteSettingsDtos = _mapper.Map<List<ResultSiteSettingsDto>>(siteSettingsValue);

           
            var addressSettingsValue = _siteSettingsAdressService.TGetAll();
            var addressSettingsDtos = _mapper.Map<List<ResultSiteSettingsAdressDto>>(addressSettingsValue);

            var socialMediaSettingsValue=_siteSettingsSocialMediaService.TGetAll();
            var socialSettingsDtos=_mapper.Map<List<ResultSiteSettingsSocialMediaDto>>(socialMediaSettingsValue);

            var quickLinkSettingsValue=_siteSettingsQuickLinkService.TGetAll();
            var quickLinkDtos=_mapper.Map<List<ResultSiteSettingsQuickLinkDto>>(quickLinkSettingsValue);

            var topMenuSettingsValue=_siteSettingsTopMenuService.TGetAll();
            var topMenuDtos=_mapper.Map<List<ResultSiteSettingsTopMenuDto>>(topMenuSettingsValue);

          
            var viewModel = new AllSiteSettingsViewModelDto
            {
                ResultSiteSettingsDtos = siteSettingsDtos,
                ResultSiteSettingsAdressDtos = addressSettingsDtos,
                SiteSettingsQuickLinkDtos=quickLinkDtos,
                SiteSettingsSocialMediaDtos=socialSettingsDtos,
                SiteSettingsTopMenuDtos=topMenuDtos
            };


            return View(viewModel);
        }

        //Genel ayarlar

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

        //Adres ayarları

        public IActionResult CreateAdressSettings ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAdressSettings(CreateSiteSettingsAdressDto createSiteSettingsAdressDto)
        {
            var value = _mapper.Map<SiteSettingsAdress>(createSiteSettingsAdressDto);
            _siteSettingsAdressService.TCreate(value);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult UpdateAdressSettings(int id)
        {
            var value = _siteSettingsAdressService.TGetById(id);
            var siteset = _mapper.Map<UpdateSiteSettingsAdressDto>(value);
            return View(siteset);
        }

        [HttpPost]
        public IActionResult UpdateAdressSettings(UpdateSiteSettingsAdressDto  updateSiteSettingsAdressDto)
        {
            var value = _mapper.Map<SiteSettingsAdress>(updateSiteSettingsAdressDto);
            _siteSettingsAdressService.TUpdate(value);
            return RedirectToAction(nameof(Index));
        }

        //Sosyal Medya Ayarları

        public IActionResult CreateSocialSettings() {

            return View();
        }

        [HttpPost]
        public IActionResult CreateSocialSettings(CreateSiteSettingsSocialMediaDto createSiteSettingsSocialMediaDto)
        {
            var value= _mapper.Map<SiteSettingsSocialMedia>(createSiteSettingsSocialMediaDto);
           _siteSettingsSocialMediaService.TCreate(value);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult UpdateSocialSettings(int id)
        {
            var value = _siteSettingsSocialMediaService.TGetById(id);
            var siteset = _mapper.Map<UpdateSiteSettingsSocialMediaDto>(value);
            return View(siteset);
        }

        [HttpPost]
        public IActionResult UpdateSocialSettings(UpdateSiteSettingsSocialMediaDto updateSiteSettingsSocialMediaDto)
        {
            var value = _mapper.Map<SiteSettingsSocialMedia>(updateSiteSettingsSocialMediaDto);
            _siteSettingsSocialMediaService.TUpdate(value);
            return RedirectToAction(nameof(Index));
        }

        //QuickLink Ayarları

        public IActionResult CreateQuickSettings()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateQuickSettings(CreateSiteSettingsQuickLinkDto createSiteSettingsQuickLinkDto)
        {
            var value = _mapper.Map<SiteSettingsQuickLink>(createSiteSettingsQuickLinkDto);
            _siteSettingsQuickLinkService.TCreate(value);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult UpdateQuickSettings(int id)
        {
            var value = _siteSettingsQuickLinkService.TGetById(id);
            var siteset = _mapper.Map<UpdateSiteSettingsQuickLinkDto>(value);
            return View(siteset);
        }

        [HttpPost]
        public IActionResult UpdateQuickSettings(UpdateSiteSettingsQuickLinkDto updateSiteSettingsQuickLinkDto)
        {
            var value = _mapper.Map<SiteSettingsQuickLink>(updateSiteSettingsQuickLinkDto);
            _siteSettingsQuickLinkService.TUpdate(value);
            return RedirectToAction(nameof(Index));
        }

        //Top Menu Ayarları

        public IActionResult CreateTopMenuSettings()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateTopMenuSettings(CreateSiteSettingsTopMenuDto createSiteSettingsTopMenuDto)
        {
            var value = _mapper.Map<SiteSettingsTopMenu>(createSiteSettingsTopMenuDto);
            _siteSettingsTopMenuService.TCreate(value);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult UpdateTopMenuSettings(int id)
        {
            var value = _siteSettingsTopMenuService.TGetById(id);
            var siteset = _mapper.Map<UpdateSiteSettingsTopMenuDto>(value);
            return View(siteset);
        }

        [HttpPost]
        public IActionResult UpdateTopMenuSettings(UpdateSiteSettingsTopMenuDto updateSiteSettingsTopMenuDto)
        {
            var value = _mapper.Map<SiteSettingsTopMenu>(updateSiteSettingsTopMenuDto);
            _siteSettingsTopMenuService.TUpdate(value);
            return RedirectToAction(nameof(Index));
        }

    }
}
