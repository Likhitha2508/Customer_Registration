using LikhithaIT.DataAccess;
using LikhithaIT.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikhithaIT.BusinessLogic
{
    public class CustomerBAL
    {
        public DataSet GetCustomers(CustomerListDTO objCustomerListDTO)
        {
            CustomerDAL objCustomerDAL = new CustomerDAL();
            return objCustomerDAL.GetCustomersDB(objCustomerListDTO);
        }
        public object AddCustomers(CustomerListDTO objCustomerListDTO)
        {
            CustomerDAL objCustomerDAL = new CustomerDAL();
            return objCustomerDAL.AddCustomersDB(objCustomerListDTO);
        }

        public object UpdateCustomers(CustomerListDTO objCustomerListDTO)
        {
            CustomerDAL objCustomerDAL = new CustomerDAL();
            return objCustomerDAL.UpdateCustomersDB(objCustomerListDTO);
        }
        public DataSet GetCustomerById(CustomerListDTO objCustomerListDTO)
        {
            CustomerDAL objCustomerDAL = new CustomerDAL();
            return objCustomerDAL.GetCustomersByIdDB(objCustomerListDTO);
        }
        public object DeleteCustomer(CustomerListDTO objCustomerListDTO)
        {
            CustomerDAL objCustomerDAL = new CustomerDAL();
            return objCustomerDAL.DeleteCustomerDB(objCustomerListDTO);
        }
    }
}
