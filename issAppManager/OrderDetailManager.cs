using issModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using issModels.Models;
using issRepo.OrderDetail;


namespace issAppManager
{
   public class OrderDetailManager
    {
        OrderDetailsRepo objmanager = new OrderDetailsRepo();

        public List<OrderDetailDTOs> GetOrderDetails()
        {
            List<OrderDetailDTOs> lstOrderDetails = objmanager.getOrderDetailsList();
            return lstOrderDetails;
        }
        public bool createOrderDetails(OrderDetail OrderDetail)
        {
            bool rep = objmanager.saveOrderDetails(OrderDetail);
            return rep;
        }
        public OrderDetailDTOs getOrderDetailsBYId(int Id)
        {
            OrderDetailDTOs rep = objmanager.getOrderDetailsBYId(Id);
            return rep;
        }
    }
}
