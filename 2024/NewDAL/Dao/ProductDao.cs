using Models;
using NewDAL.DaoBeng.NewDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDAL.Dao
{
   public class ProductDao
    {
        string Sql;
        public IList<Product> GetProductList()
        {
            Sql = "Select ProductID,ProductName,SafeStock,LastPurchaseDate," +
                "LastDeliveryDate,Quantity,SuggestBuyPrice,SuggestSalePrice from Product";
            return new DB().GetEntities<Product>(Sql, CommandType.Text, null);
        }
        public Product GetByProductID(string productID)
        {
            Sql = "Select ProductID,ProductName,SafeStock,LastPurchaseDate," +
                "LastDeliveryDate,Quantity,SuggestBuyPrice,SuggestSalePrice from Product" +
                " Where ProductID=@ProductID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ProductID", productID);
            return new DB().GetEntity<Product>(Sql, CommandType.Text, param);
        }

        public bool InputProduct(Product product)
        {
            Sql = "Insert into Product(ProductID,ProductName,SafeStock,SuggestBuyPrice,SuggestSalePrice)" +
                " values(@ProductID,@ProductName,@SafeStock,@SuggestBuyPrice,@SuggestSalePrice)";
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ProductID", product.ProductID);
            param[1] = new SqlParameter("@ProductName", product.ProductName);
            param[2] = new SqlParameter("@SafeStock", product.SafeStock);
            param[3] = new SqlParameter("@SuggestBuyPrice", product.SuggestBuyPrice);
            param[4] = new SqlParameter("@SuggestSalePrice", product.SuggestSalePrice);

            return new DB().executeSql(Sql, CommandType.Text, param);
        }

        public bool DelectProduct(Product product)
        {
            Sql = "Delete Product where ProductID=@ProductID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ProductID", product.ProductID);
            return new DB().executeSql(Sql, CommandType.Text, param);
        }

        public bool UpdataProduct(Product product)
        {
            Sql = "UPDATE Product Set ProductID=@ProductID,ProductName=@ProductName,SafeStock=@SafeStock," +
                "SuggestBuyPrice=@SuggestBuyPrice,SuggestSalePrice=@SuggestSalePrice" +
                " Where ProductID=@ProductID";
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ProductID", product.ProductID);
            param[1] = new SqlParameter("@ProductName", product.ProductName);
            param[2] = new SqlParameter("@SafeStock", product.SafeStock);
            param[3] = new SqlParameter("@SuggestBuyPrice", product.SuggestBuyPrice);
            param[4] = new SqlParameter("@SuggestSalePrice", product.SuggestSalePrice);

            return new DB().executeSql(Sql, CommandType.Text, param);

        }
    }
}
