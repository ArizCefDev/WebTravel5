﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Feature2Service : IFeature2Service
    {
        IFeature2Dal _feature2Dal;

        public Feature2Service(IFeature2Dal feature2Dal)
        {
            _feature2Dal = feature2Dal;
        }

        public void TDelete(Feature2 t)
        {
            _feature2Dal.Delete(t);
        }

        public Feature2 TGetById(int id)
        {
            return _feature2Dal.GetById(id);
        }

        public List<Feature2> TGetList()
        {
            return _feature2Dal.GetList();
        }

        public void TInsert(Feature2 t)
        {
            _feature2Dal.Add(t);
        }

        public void TUpdate(Feature2 t)
        {
            _feature2Dal.Update(t);
        }
    }
}
