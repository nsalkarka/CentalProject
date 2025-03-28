using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.EntityLayer.Entities
{
    public class SiteSettingsSocialMedia
    {
        public int SiteSettingsSocialMediaId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }

        public virtual SiteSettings siteSettings { get; set; }
    }
}
