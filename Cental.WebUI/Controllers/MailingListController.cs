using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.MailingListDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [AllowAnonymous]
    public class MailingListController(IMailListService _mailListService, IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult SendMailingList(CreateMailingListDto dto) 
        {

            //_mailListService.TCreate(mailingList);
            //return NoContent();


            if (ModelState.IsValid)
            {
                var value = _mapper.Map<MailingList>(dto);
                _mailListService.TCreate(value);

                return NoContent();

                //return Json(new { success = true, message = "Thank you for subscribing!" });
            }
            else
            {
                return Json(new { success = false, message = "Failed to subscribe.", errors = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage)) });
            }

        }
    }
}
