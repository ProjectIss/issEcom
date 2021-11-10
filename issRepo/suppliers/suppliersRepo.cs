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

namespace issRepo.suppliers
{
   public class suppliersRepo
    {
        public List<supplierDTOs> getSupplierList()
        {
            List<supplierDTOs> lstSuppliers = new List<supplierDTOs>();

            try
            {
                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("getSupplier"));
                SqlDataReader dr = objHelper.ExecuteReader(objCommand);
                lstSuppliers = common.DataReaderMapToList<supplierDTOs>(dr);
                return lstSuppliers;
            }
            catch (Exception ex)
            {


            }
            return lstSuppliers;
        }

        public bool saveSupplier(issModels.Models.supplier supplier)
        {
            try
            {
                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("saveSupplier"));
                objHelper.AddInParameter(objCommand, "contactFName", SqlDbType.VarChar, supplier.contactFName);
                objHelper.AddInParameter(objCommand, "contactLName", SqlDbType.VarChar, supplier.contactLName);
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
        public supplierDTOs getSuppliersBYId(int supplierId)
        {
            supplierDTOs supplierDTOs = new supplierDTOs();
            try
            {

                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("getSuppliersBYId"));
                objHelper.AddInParameter(objCommand, "ID", SqlDbType.Int, supplierId);
                SqlDataReader dr = objHelper.ExecuteReader(objCommand);

                while (dr.Read())
                {
                    supplierDTOs.firstAddress = dr["firstAddress"].ToString();
                }
                return supplierDTOs;
            }
            catch (Exception ex)
            {
                //error Log
                return supplierDTOs;
            }
        }

    }
}
