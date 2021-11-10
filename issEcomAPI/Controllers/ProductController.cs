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
    public class ProductController : ApiController
    {
        ProductManager objProduct = new ProductManager();

        [HttpGet]
        public List<productDTOs> GetProduct()
        {
            List<productDTOs> lstProduct= new List<productDTOs>();
            try
            {

                lstProduct = objProduct.GetProduct();
                return (lstProduct);
            }
            catch (Exception ex)
            {


            }
            return (lstProduct);

        }
        [HttpPost]
        public string CreateProduct(issModels.Models.product product)
        {
            try
            {
                bool reps = objProduct.createProduct(product);
                if (!reps) return $"Soming went wrong...";
                return $"Created {product.productId}";
            }
            catch (Exception ex)
            {
                return $"Soming went wrong {ex.Message}";

            }

        }
        [HttpGet]
        public productDTOs GetOrderDetailsById(int Id)
        {
            try
            {
                productDTOs reps = objProduct.getProductBYId(Id);
                return reps;
            }
            catch (Exception ex)
            {

                return new productDTOs();
            }

        }
    }
}