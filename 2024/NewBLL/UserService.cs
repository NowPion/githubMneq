using Models;
using NewDAL.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBLL
{
  public class UserService
    {
        UserDao UserDao = new UserDao();
        UserRoleDao UserRoleDao = new UserRoleDao();
        RoleDao RoleDao = new RoleDao();
        RoleActionDao RoleActionDao = new RoleActionDao();
        public User GetUser(string username)
        {
            User user = UserDao.GetUser(username);
            user.RoleId = UserRoleDao.GetUserRole(user.UserId).RoleId;
            user.RoleName = RoleDao.GetRole(user.RoleId).RoleName;
            user.UserRoleActionList = RoleActionDao.RoleActionList(user.RoleId);


            return user;
        }
    }
}
