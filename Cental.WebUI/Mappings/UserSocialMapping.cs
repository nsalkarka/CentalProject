using AutoMapper;
using Cental.DtoLayer.RoleDtos;
using Cental.DtoLayer.UserSocialDtos;
using Cental.EntityLayer.Entities;

namespace Cental.WebUI.Mappings
{
    public class UserSocialMapping:Profile
    {
        public UserSocialMapping() { 

        CreateMap<UserSocial, ResultSocialDto>().ForMember(dest=>dest.SocialMediaUrl,o=>o.MapFrom(src=>src.Url));
        CreateMap<UserSocial, CreateSocialDto>().ReverseMap();
        CreateMap<UserSocial, UpdateSocialDto>().ReverseMap();

        }
    }
}
