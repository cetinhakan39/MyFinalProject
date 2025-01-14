﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        

        public List<Product> GetAll()
        {
            //İş kodları    
            //Yetkisi var mı?

            return _productDal.GetAll();
        }


        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public void Delete(Product product) 
        {
            _productDal.Delete(product);
        }
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId == id);
        }

        public List<Product> GetAllByUnitPrice(decimal min,decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice>=min &&  p.UnitPrice<=max);
        }
    }
}
