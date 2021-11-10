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
    public class OrderDetailsController : ApiController
    {
        OrderDetailManager objOrderDetails = new OrderDetailManager();

        [HttpGet]
        public List<OrderDetailDTOs> GetOrderDetails()
        {
            List<OrderDetailDTOs> lstOrderDetails = new List<OrderDetailDTOs>();
            try
            {

                lstOrderDetails = objOrderDetails.GetOrderDetails();
                return (lstOrderDetails);
            }
            catch (Exception ex)
            {


            }
            return (lstOrderDetails);

        }
        [HttpPost]
        public string CreateOrderDetails(issModels.Models.OrderDetail OrderDetail)
        {
            try
            {
                bool reps = objOrderDetails.createOrderDetails(OrderDetail);
                if (!reps) return $"Soming went wrong...";
                return $"Created {OrderDetail.orderDetailId}";
            }
            catch (Exception ex)
            {
                return $"Soming went wrong {ex.Message}";

            }

        }
        [HttpGet]
        public OrderDetailDTOs GetOrderDetailsById(int Id)
        {
            try
            {
                OrderDetailDTOs reps = objOrderDetails.getOrderDetailsBYId(Id);
                return reps;
            }
            catch (Exception ex)
            {

                return new OrderDetailDTOs();
            }

        }
    }
}