using AutoMapper;
using Cental.DtoLayer.SiteSettingsDtos;
using Cental.EntityLayer.Entities;

namespace Cental.WebUI.Mappings
{
    public class SiteSettingsMapping:Profile
    {
        public SiteSettingsMapping() 
        {
            CreateMap<SiteSettings,CreateSiteSettingsDto>().ReverseMap();
            CreateMap<SiteSettings,UpdateSiteSettingsDto>().ReverseMap();
            CreateMap<SiteSettings,ResultSiteSettingsDto>().ReverseMap();
           
        }
    }
}
