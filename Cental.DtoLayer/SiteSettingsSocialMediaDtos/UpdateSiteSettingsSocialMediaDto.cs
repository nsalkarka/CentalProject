using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DtoLayer.SiteSettingsSocialMediaDtos
{
    public class UpdateSiteSettingsSocialMediaDto
    {
        public int SiteSettingsSocialMediaId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}
