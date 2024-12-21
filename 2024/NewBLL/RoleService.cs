using Models;
using NewDAL.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBLL
{
    public class RoleService
    {
        RoleDao RoleDao = new RoleDao();
        public IList<Role> GetRoleList()
        {
            return RoleDao.GetRoleList();
        }

     
  
    }
}
