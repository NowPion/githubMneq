using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
   public class RoleAction
    {
        private string roleId;
        public string RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }
        private string actionId;
        public string ActionId
        {
            get { return actionId; }
            set { actionId = value; }
        }

        public string ParentActionId { get; set; }
    }
}
