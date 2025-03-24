using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.ProcessDtos;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Default
{
    public class _DefaultProcessComponent(IProcessService _processService,IMapper _mapper):ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var value = _processService.TGetAll();
            var process= _mapper.Map<List<ResultProcessDto>>(value);
            return View(process);
        }
    }
}
