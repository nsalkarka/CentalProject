using AutoMapper;
using Cental.DtoLayer.SiteSettingsTopMenuDtos;
using Cental.EntityLayer.Entities;

namespace Cental.WebUI.Mappings
{
    public class SiteSettingsTopMenuMapping:Profile
    {
        public SiteSettingsTopMenuMapping() 
        {
            CreateMap<SiteSettingsTopMenu, CreateSiteSettingsTopMenuDto>().ReverseMap();
            CreateMap<SiteSettingsTopMenu, ResultSiteSettingsTopMenuDto>().ReverseMap();
            CreateMap<SiteSettingsTopMenu, UpdateSiteSettingsTopMenuDto>().ReverseMap();
        
        
        }
    }
}
