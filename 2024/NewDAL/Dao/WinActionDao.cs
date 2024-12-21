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
   public class WinActionDao
    {
        string Sql;
        public IList<WinAction> GetWinActionList()
        {
            Sql = "Select ActionId,ParentActionId,ActionName" +
               " from WinAction";
            
            return new DB().GetEntities<WinAction>(Sql, CommandType.Text, null);
        }

        public WinAction GetWinAction(string ActionId)
        {
            Sql = "Select ActionId,ParentActionId,ActionName" +
               " from WinAction Where ActionId=@ActionId";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ActionId", ActionId);
            return new DB().GetEntity<WinAction>(Sql, CommandType.Text, param);
        }
    }
}
