using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using NewDAL.Dao;
namespace NewBLL
{
   public class SalesManService
    {

        public static SalesManDao salesmandao = new SalesManDao();
        public IList<SalesMan> GetSalesManList()
        {
            return salesmandao.GetSalesManList();
        }
        public SalesMan GetBySalesManID(string salesManID)
        {
            return salesmandao.GetBySalesManID(salesManID);
        }

        public bool InputSalesMan(SalesMan salesMan)
        {
            return salesmandao.InputSalesMan(salesMan);
        }

        public bool DelectSalesMan(SalesMan salesMan)
        {
            return salesmandao.DelectSalesMan(salesMan);
        }

        public bool UpdataSalesMan(SalesMan salesMan)
        {
            return salesmandao.UpdataSalesMan(salesMan);
        }
    }
}
