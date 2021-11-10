using issModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using issModels.Models;
using issRepo.Shipper;

namespace issAppManager
{
   public class shipperManager
    {
        ShipperRepo objmanager = new ShipperRepo();

        public List<shipperDTOs> GetShipper()
        {
            List<shipperDTOs> lstSip = objmanager.getShipperList();
            return lstSip;
        }
        public bool createShipper(shipper shipper)
        {
            bool rep = objmanager.saveShipper(shipper);
            return rep;
        }
        public shipperDTOs getShipperBYId(int Id)
        {
            shipperDTOs rep = objmanager.getShipperBYId(Id);
            return rep;
        }
    }
}
