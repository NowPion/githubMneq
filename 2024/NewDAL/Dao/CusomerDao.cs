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
    public class CusomerDao
    {
        string Sql;
        public IList<Customer> GetCustomerList()
        {
            Sql = "Select CustomerID,CustomerSimpleName,CustomerName,Owner,Title,Telephone," +
                  "MobilePhone,Fax,SalesManId,CustomerAddress,DeliveryAddress,InvoiceAddress,LastDeliveryDate" +
                  " from Customer";
            return new DB().GetEntities<Customer>(Sql, CommandType.Text, null);
        }
        public Customer GetByCustomerID(string CustomerID)
        {

            Sql = "Select CustomerID,CustomerSimpleName,CustomerName,Owner,Title,Telephone," +
                "MobilePhone,Fax,SalesManId,CustomerAddress,DeliveryAddress,InvoiceAddress,LastDeliveryDate" +
                " from Customer Where CustomerID=@CustomerID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CustomerID", CustomerID);
            return new DB().GetEntity<Customer>(Sql, CommandType.Text, param);
        }

        public bool InputCustomer(Customer Cusomer)
        {
            Sql = "insert into Customer(CustomerID,CustomerSimpleName,CustomerName,Owner,Title,Telephone,MobilePhone,Fax,SalesManId,CustomerAddress,DeliveryAddress,InvoiceAddress,LastDeliveryDate)" +
                 " values (@CustomerID,@CustomerSimpleName,@CustomerName,@Owner,@Title,@Telephone,@MobilePhone,@Fax,@SalesManId,@CustomerAddress,@DeliveryAddress,@InvoiceAddress,@LastDeliveryDate);";
            SqlParameter[] param = new SqlParameter[13];

            param[0] = new SqlParameter("@CustomerID", Cusomer.CustomerID);
            param[1] = new SqlParameter("@CustomerSimpleName", Cusomer.CustomerSimpleName);
            param[2] = new SqlParameter("@CustomerName", Cusomer.CustomerName);
            param[3] = new SqlParameter("@Owner", Cusomer.Owner);
            param[4] = new SqlParameter("@Title", Cusomer.Title);
            param[5] = new SqlParameter("@Telephone", Cusomer.Telephone);
            param[6] = new SqlParameter("@MobilePhone", Cusomer.MobilePhone);
            param[7] = new SqlParameter("@Fax", Cusomer.Fax);
            param[8] = new SqlParameter("@SalesManId", Cusomer.SalesManId);
            param[9] = new SqlParameter("@CustomerAddress", Cusomer.CustomerAddress);
            param[10] = new SqlParameter("@DeliveryAddress", Cusomer.DeliveryAddress);
            param[11] = new SqlParameter("@InvoiceAddress", Cusomer.InvoiceAddress);
            param[12] = new SqlParameter("@LastDeliveryDate", Cusomer.LastDeliveryDate);


            return new DB().executeSql(Sql, CommandType.Text, param);
        }

        public bool DelectCustomer(Customer Cusomer)
        {
            Sql = "Delete Customer where CustomerID=@CustomerID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CustomerID", Cusomer.CustomerID);
            return new DB().executeSql(Sql, CommandType.Text, param);
        }

        public bool UpdataCustomer(Customer Cusomer)
        {
            Sql =
              "UPDATE Customer Set CustomerID=@CustomerID,CustomerSimpleName=@CustomerSimpleName," +
              "CustomerName=@CustomerName,Owner=@Owner,Title=@Title,Telephone=@Telephone," +
              "MobilePhone=@MobilePhone,Fax=@Fax,SalesManId=@SalesManId," +
              "CustomerAddress=@CustomerAddress,DeliveryAddress=@DeliveryAddress,InvoiceAddress=@InvoiceAddress,LastDeliveryDate=@LastDeliveryDate" +
              " where CustomerID=@CustomerID";

            SqlParameter[] param = new SqlParameter[13];

            param[0] = new SqlParameter("@CustomerID", Cusomer.CustomerID);
            param[1] = new SqlParameter("@CustomerSimpleName", Cusomer.CustomerSimpleName);
            param[2] = new SqlParameter("@CustomerName", Cusomer.CustomerName);
            param[3] = new SqlParameter("@Owner", Cusomer.Owner);
            param[4] = new SqlParameter("@Title", Cusomer.Title);
            param[5] = new SqlParameter("@Telephone", Cusomer.Telephone);
            param[6] = new SqlParameter("@MobilePhone", Cusomer.MobilePhone);
            param[7] = new SqlParameter("@Fax", Cusomer.Fax);
            param[8] = new SqlParameter("@SalesManId", Cusomer.SalesManId);
            param[9] = new SqlParameter("@CustomerAddress", Cusomer.CustomerAddress);
            param[10] = new SqlParameter("@DeliveryAddress", Cusomer.DeliveryAddress);
            param[11] = new SqlParameter("@InvoiceAddress", Cusomer.InvoiceAddress);
            param[12] = new SqlParameter("@LastDeliveryDate", Cusomer.LastDeliveryDate);

            return new DB().executeSql(Sql, CommandType.Text, param);
        }
    }
}
