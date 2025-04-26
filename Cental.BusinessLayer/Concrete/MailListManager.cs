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
    public class MailListManager(IMailingListDal _mailingListDal) : IMailListService
    {
        public void TCreate(MailingList entity)
        {
            _mailingListDal.Create(entity);
        }

        public void TDelete(int id)
        {
            _mailingListDal.Delete(id);
        }

        public List<MailingList> TGetAll()
        {
            return _mailingListDal.GetAll();
        }

        public MailingList TGetById(int id)
        {
            return _mailingListDal.GetById(id);
        }

        public void TUpdate(MailingList entity)
        {
            _mailingListDal.Update(entity);
        }
    }
}
