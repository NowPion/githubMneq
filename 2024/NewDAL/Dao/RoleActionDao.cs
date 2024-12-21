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
  public class RoleActionDao
    {
      string Sql;
      public  IList<RoleAction> RoleActionList(string RoleId)
      {
            Sql = "Select RoleId,ActionId,ParentActionId from RoleAction Where RoleId=@RoleId";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@RoleId", RoleId);
            return new DB().GetEntities<RoleAction>(Sql, CommandType.Text, param);
      }
        public bool DelectRoleAction(string RoleId)
        {
            Sql = "Delete RoleAction where RoleId=@RoleId";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@RoleId", RoleId);
            return new DB().executeSql(Sql, CommandType.Text, param);
        }

        public bool InputRoleAction(RoleAction roleAction)
        {
            Sql = "insert into RoleAction(RoleId,ActionId,ParentActionId)" +
                 " values (@RoleId,@ActionId,@ParentActionId);";
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@RoleId", roleAction.RoleId);
            param[1] = new SqlParameter("@ActionId", roleAction.ActionId);
            param[2] = new SqlParameter("@ParentActionId", roleAction.ParentActionId);

            return new DB().executeSql(Sql, CommandType.Text, param);
        }

    }
}
