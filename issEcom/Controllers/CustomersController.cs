using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using issModels;
using issAppManager;

namespace issEcom.Controllers
{
    public class CustomersController : ApiController
    {
        [HttpGet]
        public List<issModels.customerDTOs> GetCustomers()
        {
            List<issModels.customerDTOs> lstCustomers = new List<issModels.customerDTOs>();
            try
            {
                customerManager objCustomer = new customerManager();
                lstCustomers = objCustomer.GetCustomers();
                return (lstCustomers);
            }
            catch (Exception ex)
            {


            }
            return (lstCustomers);

        }
    }
}