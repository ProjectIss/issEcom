using issModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using issModels.Models;
using issRepo.Category;

namespace issAppManager
{
   public class categoryManager
    {
        CategoryRepo objmanager = new CategoryRepo();

        public List<categoryDTOs> GetCategory()
        {
            List<categoryDTOs> lstCat = objmanager.getCategoryList();
            return lstCat;
        }
        public bool createCategory(category category)
        {
            bool rep = objmanager.saveCategory(category);
            return rep;
        }
        public categoryDTOs getCategoryBYId(int Id)
        {
            categoryDTOs rep = objmanager.getCategoryBYId(Id);
            return rep;
        }
    }
}
