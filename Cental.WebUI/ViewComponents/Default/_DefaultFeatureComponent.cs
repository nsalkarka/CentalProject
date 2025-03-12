using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.FeatureDtos;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Default
{
    public class _DefaultFeatureComponent:ViewComponent
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public _DefaultFeatureComponent(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var values= _featureService.TGetAll();
            var banners = _mapper.Map<List<ResultFeatureDto>>(values);
            return View(banners);
        }

        
    }
}
