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

namespace issRepo.Order
{
   public class OrderRepo
    {
        public List<OrderDTOs> getOrderList()
        {
            List<OrderDTOs> lstOrder = new List<OrderDTOs>();

            try
            {
                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("getOrder"));
                SqlDataReader dr = objHelper.ExecuteReader(objCommand);
                lstOrder = common.DataReaderMapToList<OrderDTOs>(dr);
                return lstOrder;
            }
            catch (Exception ex)
            {


            }
            return lstOrder;
        }

        public bool saveOrder(issModels.Models.Order Order)
        {
            try
            {
                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("saveOrder"));
                objHelper.AddInParameter(objCommand, "orderDate", SqlDbType.VarChar, Order.orderDate);
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
        public OrderDTOs getOrderBYId(int OrderId)
        {
            OrderDTOs OrderDTOs = new OrderDTOs();
            try
            {

                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("getOrderBYId"));
                objHelper.AddInParameter(objCommand, "ID", SqlDbType.Int, OrderId);
                SqlDataReader dr = objHelper.ExecuteReader(objCommand);


                return OrderDTOs;
            }
            catch (Exception ex)
            {
                //error Log
                return OrderDTOs;
            }
        }
    }
}
