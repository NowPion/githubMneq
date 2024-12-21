using Models;
using NewDAL.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBLL
{
    public class RoleActionService
    {
        RoleActionDao RoleActionDao = new RoleActionDao();
        public IList<RoleAction> CetRoleActionList(string RoleId)
        {
            return RoleActionDao.RoleActionList(RoleId);
        }

        public bool UpdataRoleAction(IList<RoleAction> RoleActionList,string RoleId)
        {
            Console.WriteLine(RoleId);

            if(RoleActionDao.DelectRoleAction(RoleId))
            {
                foreach (RoleAction role in RoleActionList)
                {
                    if (!RoleActionDao.InputRoleAction(role))
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }


    }
}
