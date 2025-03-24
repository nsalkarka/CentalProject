using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.BrandDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PagedList.Core;

namespace Cental.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminBrandController(IBrandService _brandService, IMapper _mapper) : Controller
    {
        
        public IActionResult Index(int page = 1, int pageSize = 3)
        {
            var brands = _brandService.TGetAll().AsQueryable(); // IQueryable<Brand>
            var branddto = brands.ProjectTo<ResultBrandDto>(_mapper.ConfigurationProvider); // IQueryable<ResultBrandDto>
            var values=new PagedList<ResultBrandDto>(branddto,page,pageSize);
            return View(values);
        }

        public IActionResult DeleteBrand(int id) 
        {
            _brandService.TDelete(id);
            return RedirectToAction("Index");
        }

        public IActionResult CreateBrand() 
        { 
            return View();  
        }

        [HttpPost]
        public IActionResult CreateBrand(CreateBrandDto createBrandDto) 
        {

            if (!ModelState.IsValid) 
            {
                return View(createBrandDto);
            
            }
            var brand= _mapper.Map<Brand>(createBrandDto);
            _brandService.TCreate(brand);
            return RedirectToAction("Index");
        }

        
        public IActionResult UpdateBrand(int id) 
        {
            var value= _brandService.TGetById(id);
            var brand= _mapper.Map<UpdateBrandDto>(value);
            return View(brand);
        }

        [HttpPost]
        public IActionResult UpdateBrand(UpdateBrandDto updateBrandDto)
        {
            var value= _mapper.Map<Brand>(updateBrandDto);
            _brandService.TUpdate(value);
            return RedirectToAction("Index");
        }
      
    }
}
