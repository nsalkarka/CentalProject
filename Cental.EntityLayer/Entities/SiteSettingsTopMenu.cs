using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.EntityLayer.Entities
{
    public class SiteSettingsTopMenu
    {
        public int SiteSettingsTopMenuId { get; set; }
        public string MenuTitle { get; set; }
        public string MenuAdress { get; set; }

        public virtual SiteSettings siteSettings { get; set; }
    }
}
