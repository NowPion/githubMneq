using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Products
    {
        public int ProductId { set; get; }
        public String Pname { set; get; }
        public String Unit { set; get; }
        public String ShowText { set; get; }
        public float Price { set; get; }
        public byte[] Photo { set; get; }
    }
}
