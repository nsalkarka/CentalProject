using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.MailingList
{
    public class _MailingListComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
