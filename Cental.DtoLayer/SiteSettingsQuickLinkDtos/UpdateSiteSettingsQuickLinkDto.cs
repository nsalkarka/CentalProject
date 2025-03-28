using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DtoLayer.SiteSettingsQuickLinkDtos
{
    public class UpdateSiteSettingsQuickLinkDto
    {
        public int SiteSettingsQuickLinkId { get; set; }
        public string LinkTitle { get; set; }
        public string LinkAdress { get; set; }
    }
}
