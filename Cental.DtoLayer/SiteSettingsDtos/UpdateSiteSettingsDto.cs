using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DtoLayer.SiteSettingsDtos
{
    public class UpdateSiteSettingsDto
    {
        public int SiteSettingsId { get; set; }
        public string SiteName { get; set; }
        public string SiteLogo { get; set; }
        public string SiteLink { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string WeekendHours { get; set; }
        public string MidweekHours { get; set; }
        public string Vacationours { get; set; }

       
    }
}
