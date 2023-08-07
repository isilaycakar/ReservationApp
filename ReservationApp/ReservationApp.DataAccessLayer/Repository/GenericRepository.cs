﻿using ReservationApp.DataAccessLayer.Abstract;
using ReservationApp.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context c = new Context();
        public void Create(T t)
        {
            c.Add(t);
        }

        public void Delete(T t)
        {
            c.Remove(t);
        }

        public List<T> GetAll()
        {
            return c.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            var values = c.Set<T>().Find(id);
            return values;
        }

        public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            return c.Set<T>().Where(filter).ToList();
        }

        public void Update(T t)
        {
            c.Update(t);
        }
    }
}
