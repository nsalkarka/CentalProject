using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.SiteSettingsSocialMediaDtos;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.UILayout
{
    public class _UILayoutTopbarComponent(ISiteSettingsSocialMediaService _siteSettingsSocialMediaService, IMapper _mapper) :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var social = _siteSettingsSocialMediaService.TGetAll();
            var socialdto = _mapper.Map<List<ResultSiteSettingsSocialMediaDto>>(social);
            ViewBag.social = socialdto;
            return View();
        }
    }
}
