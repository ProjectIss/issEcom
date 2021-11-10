using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using issModels;
using issAppManager;
using issModels.Models;

namespace issEcomAPI.Controllers
{
    public class PaymentController : ApiController
    {
        PaymentManager objPayment = new PaymentManager();

        [HttpGet]
        public List<paymentDTOs> GetPaymentDetails()
        {
            List<paymentDTOs> lstPayment = new List<paymentDTOs>();
            try
            {

                lstPayment = objPayment.GetPayment();
                return (lstPayment);
            }
            catch (Exception ex)
            {


            }
            return (lstPayment);

        }
        [HttpPost]
        public string CreatePaymentDetails(issModels.Models.payment payment)
        {
            try
            {
                bool reps = objPayment.createPayment(payment);
                if (!reps) return $"Soming went wrong...";
                return $"Created {payment.paymentId}";
            }
            catch (Exception ex)
            {
                return $"Soming went wrong {ex.Message}";

            }

        }
        [HttpGet]
        public paymentDTOs GetOrderDetailsById(int Id)
        {
            try
            {
                paymentDTOs reps = objPayment.getPaymentBYId(Id);
                return reps;
            }
            catch (Exception ex)
            {

                return new paymentDTOs();
            }

        }
    }
}