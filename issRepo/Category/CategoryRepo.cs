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

namespace issRepo.Category
{
   public class CategoryRepo
    {
        public List<categoryDTOs> getCategoryList()
        {
            List<categoryDTOs> lstcategory = new List<categoryDTOs>();

            try
            {
                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("getCategory"));
                SqlDataReader dr = objHelper.ExecuteReader(objCommand);
                lstcategory = common.DataReaderMapToList<categoryDTOs>(dr);
                return lstcategory;
            }
            catch (Exception ex)
            {


            }
            return lstcategory;
        }

        public bool saveCategory(issModels.Models.category category)
        {
            try
            {
                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("saveCategory"));
                objHelper.AddInParameter(objCommand, "companyName", SqlDbType.VarChar, category.categoryName);
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
        public categoryDTOs getCategoryBYId(int categoryId)
        {
            categoryDTOs categoryDTOs = new categoryDTOs();
            try
            {

                SQLHelper.SQLHelper objHelper = new SQLHelper.SQLHelper();
                SqlCommand objCommand = new SqlCommand();
                QueryBuilder objBuilder = new QueryBuilder();
                objCommand = objHelper.GetSqlQueryCommand(objBuilder.BuildQuery("getCategoryBYId"));
                objHelper.AddInParameter(objCommand, "ID", SqlDbType.Int, categoryId);
                SqlDataReader dr = objHelper.ExecuteReader(objCommand);


                return categoryDTOs;
            }
            catch (Exception ex)
            {
                //error Log
                return categoryDTOs;
            }
        }
    }
}
