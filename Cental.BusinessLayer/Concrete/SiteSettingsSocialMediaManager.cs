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
    public class SiteSettingsSocialMediaManager(ISiteSettingsSocialMediaDal _siteSettingsSocialMediaDal) : ISiteSettingsSocialMediaService
    {
        public void TCreate(SiteSettingsSocialMedia entity)
        {
            _siteSettingsSocialMediaDal.Create(entity);
        }

        public void TDelete(int id)
        {
            _siteSettingsSocialMediaDal.Delete(id);
        }

        public List<SiteSettingsSocialMedia> TGetAll()
        {
            return _siteSettingsSocialMediaDal.GetAll();
        }

        public SiteSettingsSocialMedia TGetById(int id)
        {
            return _siteSettingsSocialMediaDal.GetById(id);
        }

        public void TUpdate(SiteSettingsSocialMedia entity)
        {
            _siteSettingsSocialMediaDal.Update(entity);
        }
    }
}
