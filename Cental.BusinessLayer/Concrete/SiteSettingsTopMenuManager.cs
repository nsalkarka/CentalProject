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
    public class SiteSettingsTopMenuManager(ISiteSettingsTopMenuDal _siteSettingsTopMenuDal) : ISiteSettingsTopMenuService
    {
        public void TCreate(SiteSettingsTopMenu entity)
        {
            _siteSettingsTopMenuDal.Create(entity);
        }

        public void TDelete(int id)
        {
            _siteSettingsTopMenuDal.Delete(id);
        }

        public List<SiteSettingsTopMenu> TGetAll()
        {
            return _siteSettingsTopMenuDal.GetAll();
        }

        public SiteSettingsTopMenu TGetById(int id)
        {
            return _siteSettingsTopMenuDal.GetById(id);
        }

        public void TUpdate(SiteSettingsTopMenu entity)
        {
            _siteSettingsTopMenuDal.Update(entity);
        }
    }
}
