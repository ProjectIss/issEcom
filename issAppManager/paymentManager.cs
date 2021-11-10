using issModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using issModels.Models;
using issRepo.Payment;


namespace issAppManager
{
   public class PaymentManager
    {
        PaymentRepo objmanager = new PaymentRepo();

        public List<paymentDTOs> GetPayment()
        {
            List<paymentDTOs> lstPay = objmanager.getPaymentList();
            return lstPay;
        }
        public bool createPayment(payment payment)
        {
            bool rep = objmanager.savePayment(payment);
            return rep;
        }
        public paymentDTOs getPaymentBYId(int Id)
        {
            paymentDTOs rep = objmanager.getPaymentBYId(Id);
            return rep;
        }
    }
}
