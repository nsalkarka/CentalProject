using AutoMapper;
using Cental.DtoLayer.MailingListDtos;
using Cental.EntityLayer.Entities;

namespace Cental.WebUI.Mappings
{
    public class MailingListMapping:Profile
    {
        public MailingListMapping() 
        { 

            CreateMap<MailingList,CreateMailingListDto>().ReverseMap();
        
        }
    }
}
