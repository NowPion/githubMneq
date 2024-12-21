using Models;
using NewDAL.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBLL
{
   public class WinActionService
    {
        WinActionDao winActionDao = new WinActionDao();
        public IList<WinAction> GetWinActionList()
        { 
            return winActionDao.GetWinActionList();
        }

        public WinAction GetWinAction(string ActionId)
        {
            return winActionDao.GetWinAction(ActionId);
        }
    }
}
