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
    public class OrderController : ApiController
    {
        OrderManager objorder = new OrderManager();

        [HttpGet]
        public List<OrderDTOs> GetOrder()
        {
            List<OrderDTOs> lstOrder = new List<OrderDTOs>();
            try
            {

                lstOrder = objorder.GetOrder();
                return (lstOrder);
            }
            catch (Exception ex)
            {


            }
            return (lstOrder);

        }
        [HttpPost]
        public string CreateOrder(issModels.Models.Order Order)
        {
            try
            {
                bool reps = objorder.createOrder(Order);
                if (!reps) return $"Soming went wrong...";
                return $"Created {Order.orderNo}";
            }
            catch (Exception ex)
            {
                return $"Soming went wrong {ex.Message}";

            }

        }
        [HttpGet]
        public OrderDTOs GetOrderById(int Id)
        {
            try
            {
                OrderDTOs reps = objorder.getOrderBYId(Id);
                return reps;
            }
            catch (Exception ex)
            {

                return new OrderDTOs();
            }

        }
    }
}