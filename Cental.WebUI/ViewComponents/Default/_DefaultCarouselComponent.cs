using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.CarDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Default
{
    public class _DefaultCarouselComponent(ICarService _carService, IMapper _mapper):ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var value = _carService.TGetAll();
            var car= _mapper.Map<List<ResultCarDto>>(value);
            return View(car);
        }
    }
}
