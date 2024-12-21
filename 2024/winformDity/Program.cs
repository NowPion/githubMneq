using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformDity
{
    public class StaticById
    {
        public static string SupplierID;
        public static string ProductID;
        public static string SalesManID;
        public static string CustomerID;
    }
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new SalesManForm());
            //Application.Run(new SupplierForm());
            //Application.Run(new CustomerForm());
            //Application.Run(new ProductForm());
            //Application.Run(new PurchaseMasterForm());
            //Application.Run(new PurchaseDateOperateForm());
            Application.Run(new LoginForm());
            //Application.Run(new DeliveryMasterForm());
        }
    }
}
