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
    public class SiteSettingsQuickLinkManager(ISiteSettingsQuickLinkDal _siteSettingsQuickLinkDal) : ISiteSettingsQuickLinkService
    {
        public void TCreate(SiteSettingsQuickLink entity)
        {
            _siteSettingsQuickLinkDal.Create(entity);
        }

        public void TDelete(int id)
        {
            _siteSettingsQuickLinkDal.Delete(id);
        }

        public List<SiteSettingsQuickLink> TGetAll()
        {
            return _siteSettingsQuickLinkDal.GetAll();
        }

        public SiteSettingsQuickLink TGetById(int id)
        {
            return _siteSettingsQuickLinkDal.GetById(id);
        }

        public void TUpdate(SiteSettingsQuickLink entity)
        {
            _siteSettingsQuickLinkDal.Update(entity);
        }
    }
}
