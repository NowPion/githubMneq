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
   public class UserRoleDao
    {
        string Sql;
        public UserRole GetUserRole(string UserId)
        {
            Sql = "select UserId,RoleId from UserRole Where UserId=@UserId";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@UserId", UserId);
            return new DB().GetEntity<UserRole>(Sql, CommandType.Text, param);
        }
    }
}
