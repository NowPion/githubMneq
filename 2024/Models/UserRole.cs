using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
   public class UserRole
    {
        private string userId;
        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        private string roleId;
        public string RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }
    }
}
