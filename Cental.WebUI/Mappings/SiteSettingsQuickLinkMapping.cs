using AutoMapper;
using Cental.DtoLayer.SiteSettingsQuickLinkDtos;
using Cental.EntityLayer.Entities;

namespace Cental.WebUI.Mappings
{
    public class SiteSettingsQuickLinkMapping:Profile
    {
        public SiteSettingsQuickLinkMapping() {

         CreateMap<SiteSettingsQuickLink, CreateSiteSettingsQuickLinkDto>().ReverseMap();
         CreateMap<SiteSettingsQuickLink, UpdateSiteSettingsQuickLinkDto>().ReverseMap();
         CreateMap<SiteSettingsQuickLink, ResultSiteSettingsQuickLinkDto>().ReverseMap();
        
        }
    }
}
