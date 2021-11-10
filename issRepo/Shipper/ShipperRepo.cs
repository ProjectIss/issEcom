using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using issCommon;
using issModels;
using issModels.Models;
using issRepo.SQLHelper;

namespace issRepo.Shipper
{
    public class ShipperRepo
    {
        public List<shipperDTOs> getShipperList()
        {
            List<shipperDTOs> lstShipper = new List<shipperDTOs>();

            try
            {
                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("getShipper"));
                SqlDataReader dr = objHelper.ExecuteReader(objCommand);
                lstShipper = common.DataReaderMapToList<shipperDTOs>(dr);
                return lstShipper;
            }
            catch (Exception ex)
            {


            }
            return lstShipper;
        }

        public bool saveShipper(issModels.Models.shipper shipper)
        {
            try
            {
                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("saveShipper"));
                objHelper.AddInParameter(objCommand, "companyName", SqlDbType.VarChar, shipper.companyName);
                var data = objHelper.ExecuteNonQuery(objCommand);
                if (data == null) return false;
                return true;
            }
            catch (Exception ex)
            {
                //error Log
                return false;
            }
        }
        public shipperDTOs getShipperBYId(int shipperId)
        {
            shipperDTOs shipperDTOs = new shipperDTOs();
            try
            {

                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("getShipperBYId"));
                objHelper.AddInParameter(objCommand, "ID", SqlDbType.Int, shipperId);
                SqlDataReader dr = objHelper.ExecuteReader(objCommand);

               
                return shipperDTOs;
            }
            catch (Exception ex)
            {
                //error Log
                return shipperDTOs;
            }
        }
    }
}
