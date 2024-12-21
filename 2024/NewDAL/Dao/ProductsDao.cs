using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using NewDAL.DaoBeng.NewDAL;

namespace NewDAL.Dao
{
    public class ProductsDao
    {
        public String Sql;
        public IList<Products> getProductsList(int pageIndex,int pageSize)
        {
            Sql = "paging";
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@pageIndex", pageIndex);
            param[1] = new SqlParameter("@pageSize", pageSize);
            return new DB().GetEntities<Products>(Sql, CommandType.StoredProcedure, param);
        }
        public Products getByproducts(int ProductId)
        {
            Sql = "Select ProductId,Pname,Unit,ShowText,Price,Photo from T_Products where ProductID=@ProductID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ProductID", ProductId);
            return new DB().GetEntity<Products>(Sql, CommandType.Text, param);
        }

        public int getProductSum(int pageSize)
        {
            Sql = "Select count(ProductId) from T_Products";
            int count = (int) new DB().GetScalar(Sql);
            return (count + pageSize - 1) / pageSize;
        }

        //public IList<Products> get

        //添加
        public bool inputProducts(Products products)
        {
            Sql = "insert into T_Products(PName,Unit,ShowText,Price,Photo) values (@PName,@Unit,@ShowText,@Price,@Photo);";
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@PName", products.Pname);
            param[1] = new SqlParameter("@Unit", products.Unit);
            param[2] = new SqlParameter("@ShowText", products.ShowText);
            param[3] = new SqlParameter("@Price", products.Price);
            param[4] = new SqlParameter("@Photo", products.Photo);

            return new DB().executeSql(Sql, CommandType.Text, param);
        }

        //修改
        public bool undataProducts(Products products)
        {
            Sql = "UPDATE T_Products SET PName=@PName,ShowText=@ShowText,Price=@Price,Photo=@Photo  Where ProductID=@ProductID;";
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@PName", products.Pname);
            param[1] = new SqlParameter("@ProductID", products.ProductId);
            param[2] = new SqlParameter("@ShowText", products.ShowText);
            param[3] = new SqlParameter("@Price", products.Price);
            param[4] = new SqlParameter("@Photo", products.Photo);

            return new DB().executeSql(Sql, CommandType.Text, param);
        }
    }
}
