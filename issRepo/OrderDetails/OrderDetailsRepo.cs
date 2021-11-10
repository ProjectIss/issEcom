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

namespace issRepo.OrderDetail
{
    public class OrderDetailsRepo
    {
        public List<OrderDetailDTOs> getOrderDetailsList()
        {
            List<OrderDetailDTOs> lstOrderDetails = new List<OrderDetailDTOs>();

            try
            {
                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("getOrderDetails"));
                SqlDataReader dr = objHelper.ExecuteReader(objCommand);
                lstOrderDetails = common.DataReaderMapToList<OrderDetailDTOs>(dr);
                return lstOrderDetails;
            }
            catch (Exception ex)
            {


            }
            return lstOrderDetails;
        }

        public bool saveOrderDetails(issModels.Models.OrderDetail OrderDetail)
        {
            try
            {
                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("saveSupplier"));
                objHelper.AddInParameter(objCommand, "orderDetailId", SqlDbType.VarChar, OrderDetail.orderDetailId);
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
        public OrderDetailDTOs getOrderDetailsBYId(int orderDetailId)
        {
            OrderDetailDTOs OrderDetailDTOs = new OrderDetailDTOs();
            try
            {

                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("GetOrderDetailsById"));
                objHelper.AddInParameter(objCommand, "ID", SqlDbType.Int, orderDetailId);
                SqlDataReader dr = objHelper.ExecuteReader(objCommand);


            }
            catch (Exception ex)
            {
                //error Log
               
            }
            return OrderDetailDTOs;
        }

    }
}
