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

namespace issRepo.Product
{
   public class ProductRepo
    {
        public List<productDTOs> getProductList()
        {
            List<productDTOs> lstProduct = new List<productDTOs>();

            try
            {
                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("getProduct"));
                SqlDataReader dr = objHelper.ExecuteReader(objCommand);
                lstProduct = common.DataReaderMapToList<productDTOs>(dr);
                return lstProduct;
            }
            catch (Exception ex)
            {


            }
            return lstProduct;
        }

        public bool saveProduct(issModels.Models.product product)
        {
            try
            {
                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("saveOrder"));
                objHelper.AddInParameter(objCommand, "orderDate", SqlDbType.VarChar, product.productName);
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
        public productDTOs getProductBYId(int ProductId)
        {
            productDTOs productDTOs = new productDTOs();
            try
            {

                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("getProductBYId"));
                objHelper.AddInParameter(objCommand, "ID", SqlDbType.Int, ProductId);
                SqlDataReader dr = objHelper.ExecuteReader(objCommand);


                return productDTOs;
            }
            catch (Exception ex)
            {
                //error Log
                return productDTOs;
            }
        }
    }
}
