using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using issModels;
using issAppManager;
using issModels.Models;

namespace issEcom.Controllers
{
    public class CustomersController : ApiController
    {
        customerManager objCustomer = new customerManager();
        [HttpGet]
        public List<customerDTOs> GetCustomers()
        {
            List<customerDTOs> lstCustomers = new List<customerDTOs>();
            try
            {
               
                lstCustomers = objCustomer.GetCustomers();
                return (lstCustomers);
            }
            catch (Exception ex)
            {


            }
            return (lstCustomers);

        }
        [HttpPost]
        public string CreateCustomer(issModels.Models.customer customer)
        {
            try
            {
                bool reps = objCustomer.createCustomer(customer);
                if(!reps) return $"Soming went wrong...";
                return $"Created {customer.firstName}";
            }
            catch (Exception ex)
            {
                return $"Soming went wrong {ex.Message}";

            }

        }
        [HttpGet]
        public customerDTOs GetCustomersById(int Id)
        {
            try
            {
                customerDTOs reps = objCustomer.getCustomersBYId(Id);
                return reps;
            }
            catch (Exception ex)
            {

                return new customerDTOs();
            }

        }
    }
}