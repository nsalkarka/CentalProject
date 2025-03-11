using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.BannerDtos;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Default
{
    public class _DefaultBannerComponent:ViewComponent
    {
        private readonly IBannerService _bannerService;
        private readonly IMapper _mapper;

        public _DefaultBannerComponent(IBannerService bannerService, IMapper mapper)
        {
            _bannerService = bannerService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var values = _bannerService.TGetAll();
            var banners=_mapper.Map<List<ResultBannerDto>>(values);
            return View(banners);

        }
    }
}
