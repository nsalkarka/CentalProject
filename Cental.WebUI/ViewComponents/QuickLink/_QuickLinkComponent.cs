using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.SiteSettingsQuickLinkDtos;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.QuickLink
{
    public class _QuickLinkComponent(ISiteSettingsQuickLinkService _siteSettingsQuickLinkService, IMapper _mapper) :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var value = _siteSettingsQuickLinkService.TGetAll();
            var link = _mapper.Map<List<ResultSiteSettingsQuickLinkDto>>(value);
            return View(link);
        }


    }
}
