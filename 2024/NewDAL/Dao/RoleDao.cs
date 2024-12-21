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
   public class RoleDao
    {
        string Sql;
        public Role GetRole(string RoleId)
        {
            Sql = "Select RoleId,RoleName from Role Where RoleId=@RoleId";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@RoleId", RoleId);
            return new DB().GetEntity<Role>(Sql, CommandType.Text, param);
        }

        public IList<Role> GetRoleList()
        {
            Sql = "Select RoleId,RoleName from Role";
            return new DB().GetEntities<Role>(Sql, CommandType.Text, null);
        }

    }
}
