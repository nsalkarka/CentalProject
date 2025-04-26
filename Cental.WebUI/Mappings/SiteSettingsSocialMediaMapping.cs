using AutoMapper;
using Cental.DtoLayer.SiteSettingsSocialMediaDtos;
using Cental.EntityLayer.Entities;

namespace Cental.WebUI.Mappings
{
    public class SiteSettingsSocialMediaMapping:Profile
    {
        public SiteSettingsSocialMediaMapping() 
        { 
            CreateMap<SiteSettingsSocialMedia, CreateSiteSettingsSocialMediaDto>().ReverseMap();
            CreateMap<SiteSettingsSocialMedia, UpdateSiteSettingsSocialMediaDto>().ReverseMap();
            CreateMap<SiteSettingsSocialMedia, ResultSiteSettingsSocialMediaDto>().ReverseMap();
        }
    }
}
