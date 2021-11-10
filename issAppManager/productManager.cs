using issModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using issModels.Models;
using issRepo.Product;


namespace issAppManager
{
   public class ProductManager
    {
        ProductRepo objmanager = new ProductRepo();

        public List<productDTOs> GetProduct()
        {
            List<productDTOs> lstProd = objmanager.getProductList();
            return lstProd;
        }
        public bool createProduct(product product)
        {
            bool rep = objmanager.saveProduct(product);
            return rep;
        }
        public productDTOs getProductBYId(int Id)
        {
            productDTOs rep = objmanager.getProductBYId(Id);
            return rep;
        }
    }
}
