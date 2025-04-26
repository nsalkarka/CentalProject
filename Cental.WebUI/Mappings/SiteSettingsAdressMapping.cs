using AutoMapper;
using Cental.DtoLayer.SiteSettingsAdressDtos;
using Cental.EntityLayer.Entities;

namespace Cental.WebUI.Mappings
{
    public class SiteSettingsAdressMapping:Profile
    {
        public SiteSettingsAdressMapping() 
        {
            CreateMap<SiteSettingsAdress,CreateSiteSettingsAdressDto>().ReverseMap();
            CreateMap<SiteSettingsAdress,ResultSiteSettingsAdressDto>().ReverseMap();
            CreateMap<SiteSettingsAdress,UpdateSiteSettingsAdressDto>().ReverseMap();
        }
    }
}
