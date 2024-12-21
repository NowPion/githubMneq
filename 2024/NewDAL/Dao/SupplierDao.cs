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
    public class SupplierDao
    {
        string Sql;
        public IList<Supplier> GetSupplierList(int coar, string Conting)
        {
            Sql = "Select SupplierID,SupplierSimpleName," +
               "SupplierName,Owner,Title,Telephone,MobilePhone,Fax,CompanyAddress,FactoryAddress,LastDeliveryDate from Supplier";
            if(coar == 0)
            {
                Sql += "  where SupplierID like '%" +Conting + "%'";
            }
            if(coar == 1)
            {
                Sql += " where SupplierSimpleName like '%" + Conting + "%'";
            }
         
                
            return new DB().GetEntities<Supplier>(Sql, CommandType.Text, null);
        }
        public Supplier GetBySupplierID(string suppLierID)
        {
            Sql = "Select SupplierID,SupplierSimpleName," +
               "SupplierName,Owner,Title,Telephone,MobilePhone,Fax,CompanyAddress,FactoryAddress,LastDeliveryDate from Supplier"
               + " where SupplierID=@SupplierID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@SupplierID", suppLierID);
            return new DB().GetEntity<Supplier>(Sql, CommandType.Text, param);
        }

        public bool InputSupplier(Supplier supplier)
        {
            Sql = "insert into Supplier(SupplierID,SupplierSimpleName,SupplierName,Owner,Title,Telephone,MobilePhone,Fax,CompanyAddress,FactoryAddress,LastDeliveryDate)" +
                 " values (@SupplierID,@SupplierSimpleName,@SupplierName,@Owner,@Title,@Telephone,@MobilePhone,@Fax,@CompanyAddress,@FactoryAddress,@LastDeliveryDate);";
            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@SupplierID", supplier.SupplierID);
            param[1] = new SqlParameter("@SupplierSimpleName", supplier.SupplierSimpleName);
            param[2] = new SqlParameter("@SupplierName", supplier.SupplierName);
            param[3] = new SqlParameter("@Owner", supplier.Owner);
            param[4] = new SqlParameter("@Title", supplier.Title);
            param[5] = new SqlParameter("@Telephone", supplier.Telephone);
            param[6] = new SqlParameter("@MobilePhone", supplier.MobilePhone);
            param[7] = new SqlParameter("@Fax", supplier.Fax);
            param[8] = new SqlParameter("@CompanyAddress", supplier.CompanyAddress);
            param[9] = new SqlParameter("@FactoryAddress", supplier.FactoryAddress);
            param[10] = new SqlParameter("@LastDeliveryDate", supplier.LastDeliveryDate);

            return new DB().executeSql(Sql, CommandType.Text, param);
        }

        public bool DelectSupplier(Supplier supplier)
        {
            Sql = "Delete Supplier where SupplierID=@SupplierID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@SupplierID", supplier.SupplierID);
            return new DB().executeSql(Sql, CommandType.Text, param);
        }

        public bool UpdataSupplier(Supplier supplier)
        {

            Sql = 
                "UPDATE Supplier Set SupplierID=@SupplierID,SupplierSimpleName=@SupplierSimpleName," +
                "SupplierName=@SupplierName,Owner=@Owner,Title=@Title,Telephone=@Telephone," +
                "MobilePhone=@MobilePhone,Fax=@Fax,CompanyAddress=@CompanyAddress," +
                "FactoryAddress=@FactoryAddress,LastDeliveryDate=@LastDeliveryDate" + 
                " where SupplierID=@SupplierID";

            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@SupplierID", supplier.SupplierID);
            param[1] = new SqlParameter("@SupplierSimpleName", supplier.SupplierSimpleName);
            param[2] = new SqlParameter("@SupplierName", supplier.SupplierName);
            param[3] = new SqlParameter("@Owner", supplier.Owner);
            param[4] = new SqlParameter("@Title", supplier.Title);
            param[5] = new SqlParameter("@Telephone", supplier.Telephone);
            param[6] = new SqlParameter("@MobilePhone", supplier.MobilePhone);
            param[7] = new SqlParameter("@Fax", supplier.Fax);
            param[8] = new SqlParameter("@CompanyAddress", supplier.CompanyAddress);
            param[9] = new SqlParameter("@FactoryAddress", supplier.FactoryAddress);
            param[10] = new SqlParameter("@LastDeliveryDate", supplier.LastDeliveryDate);

            return new DB().executeSql(Sql, CommandType.Text, param);
        }
    }
}
