﻿using Cental.BusinessLayer.Abstract;
using Cental.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BusinessLayer.Concrete
{
    //İlk yaptığımızda diğer concrete metotlar bundan miras alıyordu şu an bir işlevi yok 18. bölümde 1. saatte değiştirdik

    public class GenericManager<T> : IGenericService<T> where T : class
    {
        private readonly IGenericDal<T> _genericDal;

        public GenericManager(IGenericDal<T> genericDal)
        {
            _genericDal = genericDal;
        }

        public void TCreate(T entity)
        {
            _genericDal.Create(entity);
        }

        public void TDelete(int id)
        {
           _genericDal.Delete(id);
        }

        public List<T> TGetAll()
        {
            return _genericDal.GetAll();
        }

        public T TGetById(int id)
        {
            return _genericDal.GetById(id);
        }

        public void TUpdate(T entity)
        {
            _genericDal.Update(entity);
        }
    }
}
