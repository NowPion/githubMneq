using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{

    class Actions
    {
        private string actionId;
        public string ActionId
        {
            get { return actionId; }
            set { actionId = value; }
        }
        private string actionName;
        public string ActionName
        {
            get { return actionName; }
            set { actionName = value; }
        }
    }
}
