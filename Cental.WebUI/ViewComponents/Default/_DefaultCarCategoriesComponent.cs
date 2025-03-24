using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.CarDtos;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Default
{
    public class _DefaultCarCategoriesComponent(ICarService _carService,IMapper _mapper):ViewComponent
    {
        public  IViewComponentResult Invoke()
        {
           var value= _carService.TGetCarsWithBrands().TakeLast(6).OrderByDescending(x => x.CarId);
           var car= _mapper.Map<List<ResultCarDto>>(value);
            
            return View(car);
        }
    }
}
