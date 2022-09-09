﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T t)
        {
            Context c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Delete(T t)
        {
            Context c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            Context c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            Context c = new Context();
            return c.Set<T>().ToList();
        }

        public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            Context c = new Context();
            return c.Set<T>().Where(filter).ToList();   
        }

        public void Update(T t)
        {
            Context c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
