using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.ServiceDtos;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Default
{
    

    public class _DefaultServiceComponent:ViewComponent
    {
        private readonly IServiceService _serviceService;
        private readonly IMapper _mapper;

        public _DefaultServiceComponent(IServiceService serviceService, IMapper mapper)
        {
            _serviceService = serviceService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var values = _serviceService.TGetAll();
            var service= _mapper.Map<List<ResultServiceDto>>(values);
            return View(service);
        }
        

    }
}
