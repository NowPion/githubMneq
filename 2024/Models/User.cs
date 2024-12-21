using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
   public class User
    {
        private string userId;
        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string userPwd;
        public string UserPwd
        {
            get { return userPwd; }
            set { userPwd = value; }
        }
        private string departmentId;
        public string DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }

        public string RoleId { set; get; }
        public string RoleName { set; get; }


       public IList<RoleAction> UserRoleActionList { get; set; }
    }
}
