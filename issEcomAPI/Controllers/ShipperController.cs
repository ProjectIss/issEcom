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
    public class ShipperController : ApiController
    {
        shipperManager objShipper = new shipperManager();

        [HttpGet]
        public List<shipperDTOs> GetShipper()
        {
            List<shipperDTOs> lstShipper = new List<shipperDTOs>();
            try
            {

                lstShipper = objShipper.GetShipper();
                return (lstShipper);
            }
            catch (Exception ex)
            {


            }
            return (lstShipper);

        }
        [HttpPost]
        public string CreateShipper(issModels.Models.shipper shipper)
        {
            try
            {
                bool reps = objShipper.createShipper(shipper);
                if (!reps) return $"Soming went wrong...";
                return $"Created {shipper.companyName}";
            }
            catch (Exception ex)
            {
                return $"Soming went wrong {ex.Message}";

            }

        }
        [HttpGet]
        public shipperDTOs GetShipperById(int Id)
        {
            try
            {
                shipperDTOs reps = objShipper.getShipperBYId(Id);
                return reps;
            }
            catch (Exception ex)
            {

                return new shipperDTOs();
            }

        }
    }
}