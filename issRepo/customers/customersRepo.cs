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

namespace issRepo.customers
{
    public class customersRepo
    {
        public List<customerDTOs> getCustomersList()
        {
            List<customerDTOs> lstCustomers = new List<customerDTOs>();

            try
            {
                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("getCustomers"));
                SqlDataReader dr = objHelper.ExecuteReader(objCommand);
                lstCustomers = common.DataReaderMapToList<customerDTOs>(dr);
                return lstCustomers;
            }
            catch (Exception ex)
            {


            }
            return lstCustomers;
        }

        public bool saveCustomer(issModels.Models.customer customer)
        {
            try
            {
                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("saveCusomter"));
                objHelper.AddInParameter(objCommand, "firstName", SqlDbType.VarChar, customer.firstName);
                objHelper.AddInParameter(objCommand, "lastName", SqlDbType.VarChar, customer.lastName);
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
        public customerDTOs getCustomersBYId(int customerId)
        {
            customerDTOs customerDTOs = new customerDTOs();
            try
            {
               
                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("getCustomersBYId"));
                objHelper.AddInParameter(objCommand, "ID", SqlDbType.Int, customerId);
                SqlDataReader dr = objHelper.ExecuteReader(objCommand);
                
                while (dr.Read())
                {
                    customerDTOs.address1 = dr["address1"].ToString();
                }
                return customerDTOs;
            }
            catch (Exception ex)
            {
                //error Log
                return customerDTOs;
            }
        }
    }
}
