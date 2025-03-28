using Cental.BusinessLayer.Abstract;
using Cental.DataAccessLayer.Abstract;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BusinessLayer.Concrete
{
    public class SiteSettingsManager(ISiteSettingsDal _siteSettingsDal) : ISiteSettingsService
    {
        public void TCreate(SiteSettings entity)
        {
            _siteSettingsDal.Create(entity);
        }

        public void TDelete(int id)
        {
            _siteSettingsDal.Delete(id);
        }

        public List<SiteSettings> TGetAll()
        {
            return _siteSettingsDal.GetAll();
        }

        public SiteSettings TGetById(int id)
        {
            return _siteSettingsDal.GetById(id);
        }

        public void TUpdate(SiteSettings entity)
        {
            _siteSettingsDal.Update(entity);
        }
    }
}
