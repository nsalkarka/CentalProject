using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.TestimonialDtos;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Default
{
    public class _DefaultTestimonialComponent(ITestimonialService _testimonialService, IMapper _mapper):ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var value= _testimonialService.TGetAll();
            var testimonial= _mapper.Map<List<ResultTestimonialDto>>(value);
            return View(testimonial);
        }
    }
}
