using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DtoLayer.SiteSettingsTopMenuDtos
{
    public class UpdateSiteSettingsTopMenuDto
    {
        public int SiteSettingsTopMenuId { get; set; }
        public string MenuTitle { get; set; }
        public string MenuAdress { get; set; }
    }
}
