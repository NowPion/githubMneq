using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using NewDAL.Dao;

namespace NewBLL
{
   public class ProductService
    {
        public ProductDao productDao = new ProductDao();
        public IList<Product> GetProductList()
        {
            return productDao.GetProductList();
        }
        public Product GetByProductID(string productID)
        {
            return productDao.GetByProductID(productID);
        }

        public bool InputProduct(Product product)
        {
            return productDao.InputProduct(product);
        }

        public bool DelectProduct(Product product)
        {
            return productDao.DelectProduct(product);
        }

        public bool UpdataProduct(Product product)
        {
            return productDao.UpdataProduct(product);
        }
    }
}
