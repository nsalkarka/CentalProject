using Cental.DtoLayer.RoleDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DtoLayer.UserSocialDtos
{
    public class ResultSocialDto
    {
        public int UserSocialId { get; set; }
        public string SocialMediaUrl { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }

        public int UserId { get; set; }
        public ResultUserDto User { get; set; }
    }
}
