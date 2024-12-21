using Models;
using NewDAL.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBLL
{
  public  class SupplierService
    {
         public static SupplierDao sipplierdao = new SupplierDao();
        public IList<Supplier> GetSupplierList(int coar,string Conting)
        {
            return sipplierdao.GetSupplierList(coar,Conting);
        }
        public Supplier GetBySupplierID(string suppLierID)
        {
            return sipplierdao.GetBySupplierID(suppLierID);
        }

        public bool InputSupplier(Supplier supplier)
        {
            return sipplierdao.InputSupplier(supplier);
        }

        public bool DelectSupplier(Supplier supplier)
        {
            return sipplierdao.DelectSupplier(supplier);
        }

        public bool UpdataSupplier(Supplier supplier)
        {
            return sipplierdao.UpdataSupplier(supplier);
        }
    }
}
