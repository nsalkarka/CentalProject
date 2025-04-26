using Cental.DtoLayer.SiteSettingsAdressDtos;
using Cental.DtoLayer.SiteSettingsDtos;
using Cental.DtoLayer.SiteSettingsSocialMediaDtos;
using Cental.DtoLayer.SiteSettingsTopMenuDtos;
using Cental.DtoLayer.SiteSettingsQuickLinkDtos;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DtoLayer.ViewModels
{
    public class AllSiteSettingsViewModelDto
    {
        public List<ResultSiteSettingsDto>  ResultSiteSettingsDtos { get; set; }
        public List<ResultSiteSettingsAdressDto> ResultSiteSettingsAdressDtos { get; set; }
        public List<ResultSiteSettingsQuickLinkDto> SiteSettingsQuickLinkDtos { get; set; }
        public List<ResultSiteSettingsSocialMediaDto> SiteSettingsSocialMediaDtos { get;set; }
        public List<ResultSiteSettingsTopMenuDto> SiteSettingsTopMenuDtos { get; set;}
    }
}
