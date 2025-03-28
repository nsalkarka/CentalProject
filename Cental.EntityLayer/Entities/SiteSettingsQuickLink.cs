using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.EntityLayer.Entities
{
    public class SiteSettingsQuickLink
    {
        public int SiteSettingsQuickLinkId { get; set; }
        public string LinkTitle { get; set; }
        public string LinkAdress { get; set; }

        public virtual SiteSettings siteSettings { get; set; }
    }
}
