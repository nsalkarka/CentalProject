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
    public class SiteSettingsAdressManager(ISiteSettingsAdressDal _siteSettingsAdressDal) : ISiteSettingsAdressService
    {
        public void TCreate(SiteSettingsAdress entity)
        {
            _siteSettingsAdressDal.Create(entity);
        }

        public void TDelete(int id)
        {
            _siteSettingsAdressDal.Delete(id);
        }

        public List<SiteSettingsAdress> TGetAll()
        {
            return _siteSettingsAdressDal.GetAll();
        }

        public SiteSettingsAdress TGetById(int id)
        {
            return _siteSettingsAdressDal.GetById(id);
        }

        public void TUpdate(SiteSettingsAdress entity)
        {
            _siteSettingsAdressDal.Update(entity);
        }
    }
}
