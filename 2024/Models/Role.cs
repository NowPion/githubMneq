using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{

  public class Role
    {
        private string roleId;
        public string RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }
        private string roleName;
        public string RoleName
        {
            get { return roleName; }
            set { roleName = value; }
        }
    }
}
