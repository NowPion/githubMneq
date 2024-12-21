using Models;
using NewDAL.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBLL
{
   public class UserRoleService
    {
        UserRoleDao userRoleDao = new UserRoleDao();

        public UserRole GetUserRole(string UserId)
        {
            return userRoleDao.GetUserRole(UserId);
        }
    }
}
