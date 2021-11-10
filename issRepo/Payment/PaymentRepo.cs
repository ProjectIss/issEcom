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

namespace issRepo.Payment
{
   public class PaymentRepo
    {
        public List<paymentDTOs> getPaymentList()
        {
            List<paymentDTOs> lstPayment = new List<paymentDTOs>();

            try
            {
                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("getPayment"));
                SqlDataReader dr = objHelper.ExecuteReader(objCommand);
                lstPayment = common.DataReaderMapToList<paymentDTOs>(dr);
                return lstPayment;
            }
            catch (Exception ex)
            {


            }
            return lstPayment;
        }

        public bool savePayment(issModels.Models.payment payment)
        {
            try
            {
                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("saveOrder"));
                objHelper.AddInParameter(objCommand, "orderDate", SqlDbType.VarChar, payment.paymentType);
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
        public paymentDTOs getPaymentBYId(int PaymentId)
        {
            paymentDTOs paymentDTOs = new paymentDTOs();
            try
            {

                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("getPaymentBYId"));
                objHelper.AddInParameter(objCommand, "ID", SqlDbType.Int, PaymentId);
                SqlDataReader dr = objHelper.ExecuteReader(objCommand);


                return paymentDTOs;
            }
            catch (Exception ex)
            {
                //error Log
                return paymentDTOs;
            }
        }
    }
}
