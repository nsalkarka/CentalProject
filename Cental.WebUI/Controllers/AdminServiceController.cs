using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.ServiceDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminServiceController(IServiceService _serviceService,IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var value= _serviceService.TGetAll();
            var service=_mapper.Map<List<ResultServiceDto>>(value);
            return View(service);
        }

        public IActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateService(CreateServiceDto _createServiceDto)
        {
            var service = _mapper.Map<Service>(_createServiceDto);
            _serviceService.TCreate(service);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int id)
        {
            _serviceService.TDelete(id);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateService(int id)
        {
            var value= _serviceService.TGetById(id);
            var service=_mapper.Map<UpdateServiceDto>(value);
            return View(service);
        }

        [HttpPost]
        public IActionResult UpdateService(UpdateServiceDto _updateServiceDto)
        {
            var service=_mapper.Map<Service>(_updateServiceDto);
            _serviceService.TUpdate(service);
            return RedirectToAction("Index");
        }
    }
}
