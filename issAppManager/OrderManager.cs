using issModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using issModels.Models;
using issRepo.Order;

namespace issAppManager
{
   public class OrderManager
    {
        OrderRepo objmanager = new OrderRepo();

        public List<OrderDTOs> GetOrder()
        {
            List<OrderDTOs> lstOrd = objmanager.getOrderList();
            return lstOrd;
        }
        public bool createOrder(Order Order)
        {
            bool rep = objmanager.saveOrder(Order);
            return rep;
        }
        public OrderDTOs getOrderBYId(int Id)
        {
            OrderDTOs rep = objmanager.getOrderBYId(Id);
            return rep;
        }
    }
}
