using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issModels.Models
{
   public class customer
    {
      
        public int customerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string doorNo { get; set; }
        public string buliding { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string userName { get; set; }
        public string creditCard { get; set; }
        public string creditCardTypeId { get; set; }
        public string cardExpMo { get; set; }
        public string cardExpYr { get; set; }
        public string billingAddress { get; set; }
        public string billingCity { get; set; }
        public string billingRegion { get; set; }
        public string billingPostalCode { get; set; }
        public string billingCountry { get; set; }
        public string shipAddress { get; set; }
        public string shipCity { get; set; }
        public string shipRegion { get; set; }
        public string shipPostalCode { get; set; }
        public string shipCountry { get; set; }
        public DateTime? dateEntered { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
