using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.TestimonialDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{

    [Authorize(Roles ="Admin")]
    public class AdminTestimonialController(ITestimonialService _testimonialService, IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var values = _testimonialService.TGetAll();
            var testimonial = _mapper.Map<List<ResultTestimonialDto>>(values);
            return View(testimonial);
        }

        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto model)
        {
            var testimonial = _mapper.Map<Testimonial>(model);
            _testimonialService.TCreate(testimonial);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTestimonial(int id)
        {
            _testimonialService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            var testimonial = _mapper.Map<UpdateTestimonialDto>(value);
            return View(testimonial);
        }


        [HttpPost]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto model)
        {
            // UpdateBannerDto'yu Banner entity'sine dönüştür
            var testimonial = _mapper.Map<Testimonial>(model);

            // Banner entity'sini güncelle
            _testimonialService.TUpdate(testimonial);
            return RedirectToAction("Index");
        }
    }
}
