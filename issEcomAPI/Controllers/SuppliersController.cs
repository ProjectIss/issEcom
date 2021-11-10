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
    public class SuppliersController : ApiController
    {
        supplierManager objSupplier = new supplierManager();
        [HttpGet]
        public List<supplierDTOs> GetSuppliers()
        {
            List<supplierDTOs> lstSuppliers = new List<supplierDTOs>();
            try
            {

                lstSuppliers = objSupplier.GetSuppliers();
                return (lstSuppliers);
            }
            catch (Exception ex)
            {


            }
            return (lstSuppliers);

        }
        [HttpPost]
        public string CreateSupplier(issModels.Models.supplier supplier)
        {
            try
            {
                bool reps = objSupplier.createSupplier(supplier);
                if (!reps) return $"Soming went wrong...";
                return $"Created {supplier.companyName}";
            }
            catch (Exception ex)
            {
                return $"Soming went wrong {ex.Message}";

            }

        }
        [HttpGet]
        public supplierDTOs GetSuppliersById(int Id)
        {
            try
            {
                supplierDTOs reps = objSupplier.getSuppliersBYId(Id);
                return reps;
            }
            catch (Exception ex)
            {

                return new supplierDTOs();
            }

        }
    }
}