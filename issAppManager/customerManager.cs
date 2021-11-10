using issModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using issModels.Models;
using issRepo.customers;

namespace issAppManager
{
    public class customerManager
    {
        customersRepo objmanager = new customersRepo();
        public List<customerDTOs> GetCustomers()
        {
            List<customerDTOs> lstCus = objmanager.getCustomersList();
            return lstCus;
        }
        public bool createCustomer(customer customer)
        {
            bool rep = objmanager.saveCustomer(customer);
            return rep;
        }
        public customerDTOs getCustomersBYId(int Id)
        {
            customerDTOs rep = objmanager.getCustomersBYId(Id);
            return rep;
        }
    }
}
