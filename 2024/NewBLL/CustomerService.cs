using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using NewDAL.Dao;

namespace NewBLL
{
    public class CustomerService
    {
        public static SalesManDao SalesMandao = new SalesManDao();
        public static CusomerDao cusomerdao = new CusomerDao();
        //public static ProductsDao productsdao = new ProductsDao();
        public IList<Customer> GetCustomerList()
        {
            IList<Customer> Customers = cusomerdao.GetCustomerList();
            //foreach(Customer customer in Customers)
            //{
            //    SalesMan salesman = SalesMandao.GetBySalesManID(customer.SalesManId);
            //    if (salesman != null)
            //    {

            //    }
            //}
            for(int index = 0; index < Customers.Count(); index++)
            {
                SalesMan salesman = SalesMandao.GetBySalesManID(Customers[index].SalesManId);
                if(salesman != null)
                {
                    Customers[index].SalesManName = salesman.ChineseName;
                }
            }

            return Customers;
        }



        public Customer GetByCustomerID(string customerID)
        {
            Customer customer = cusomerdao.GetByCustomerID(customerID);
            SalesMan salesman = SalesMandao.GetBySalesManID(customer.SalesManId);
            customer.SalesManName = salesman.ChineseName;
            return customer;
        }

        public bool InputCustomer(Customer customer)
        {
            return cusomerdao.InputCustomer(customer);
        }

        public bool DelectCustomer(Customer customer)
        {
            return cusomerdao.DelectCustomer(customer);
        }

        public bool UpdataCustomer(Customer customer)
        {
            return cusomerdao.UpdataCustomer(customer);
        }
    }
}
