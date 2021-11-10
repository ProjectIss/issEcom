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
    public class CategoryController : ApiController
    {
        categoryManager objCategory = new categoryManager();
        [HttpGet]
        public List<categoryDTOs> GetCategory()
        {
            List<categoryDTOs> lstCategory = new List<categoryDTOs>();
            try
            {

                lstCategory = objCategory.GetCategory();
                return (lstCategory);
            }
            catch (Exception ex)
            {


            }
            return (lstCategory);

        }
        [HttpPost]
        public string CreateCategory(issModels.Models.category category)
        {
            try
            {
                bool reps = objCategory.createCategory(category);
                if (!reps) return $"Soming went wrong...";
                return $"Created {category.categoryName}";
            }
            catch (Exception ex)
            {
                return $"Soming went wrong {ex.Message}";

            }

        }
        [HttpGet]
        public categoryDTOs GetSuppliersById(int Id)
        {
            try
            {
                categoryDTOs reps = objCategory.getCategoryBYId(Id);
                return reps;
            }
            catch (Exception ex)
            {

                return new categoryDTOs();
            }

        }
    }
}