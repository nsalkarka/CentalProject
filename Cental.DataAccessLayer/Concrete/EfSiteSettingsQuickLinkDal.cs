﻿using Cental.DataAccessLayer.Abstract;
using Cental.DataAccessLayer.Context;
using Cental.DataAccessLayer.Repositories;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DataAccessLayer.Concrete
{
    public class EfSiteSettingsQuickLinkDal : GenericRepository<SiteSettingsQuickLink>, ISiteSettingsQuickLinkDal
    {
        public EfSiteSettingsQuickLinkDal(CentalContext context) : base(context)
        {
        }
    }
}
