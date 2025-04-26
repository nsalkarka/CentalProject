using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.SiteSettingsTopMenuDtos;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.UILayout
{
    public class _UILayoutNavbarComponent(ISiteSettingsTopMenuService _siteSettingsTopMenuService,IMapper _mapper):ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var value= _siteSettingsTopMenuService.TGetAll();
            var menu=_mapper.Map<List<ResultSiteSettingsTopMenuDto>>(value);
            return View(menu);
        }
    }
}
