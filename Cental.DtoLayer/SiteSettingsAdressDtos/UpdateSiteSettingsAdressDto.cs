using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DtoLayer.SiteSettingsAdressDtos
{
    public class UpdateSiteSettingsAdressDto
    {
        public int SiteSettingsAdressId { get; set; }
        public string Title { get; set; }
        public string Adress { get; set; }
        public string MapLocation { get; set; }
    }
}
