using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.ProcessDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminProcessController(IProcessService _processService,IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var value=_processService.TGetAll();
            var process = _mapper.Map<List<ResultProcessDto>>(value);
            return View(process);
        }

        public IActionResult CreateProcess()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProcess(CreateProcessDto _createProcessDto)
        {
            var value= _mapper.Map<Process>(_createProcessDto);
            _processService.TCreate(value);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProcess(int id)
        {
            _processService.TDelete(id);
            return RedirectToAction("Index");
        }

        
        public IActionResult UpdateProcess(int id)
        {
            var value= _processService.TGetById(id);
            var process=_mapper.Map<UpdateProcessDto>(value);
            return View(process);
        }

        [HttpPost]
        public IActionResult UpdateProcess(UpdateProcessDto _updateProcessDto)
        {
            var value= _mapper.Map<Process>(_updateProcessDto);
            _processService.TUpdate(value);
            return RedirectToAction("Index");
        }
    }
}
