using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using NewDAL.Dao;

namespace NewBLL
{
   public class ProductsService
    {
       public static ProductsDao productsdao = new ProductsDao();

        public  IList<Products> getProductsList(int pageIndex, int pageSize)
        {
            return productsdao.getProductsList(pageIndex,pageSize);
        }
        public Products getByproducts(int ProductId)
        {
            return productsdao.getByproducts(ProductId);
        }

        public int getProductSum(int pageSize)
        {
            return productsdao.getProductSum(pageSize);
        }

        public bool inputProducts(Products products)
        {
            return productsdao.inputProducts(products);
        }
        
        public bool undataProducts(Products products)
        {
            return productsdao.undataProducts(products);
        }

        

    }
}
