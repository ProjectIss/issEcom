using issModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using issModels.Models;
using issRepo.suppliers;

namespace issAppManager
{
    public class supplierManager
    {
        suppliersRepo objmanager = new suppliersRepo();
       
        public List<supplierDTOs> GetSuppliers()
        {
            List<supplierDTOs> lstSup = objmanager.getSupplierList();
            return lstSup;
        }
        public bool createSupplier(supplier supplier)
        {
            bool rep = objmanager.saveSupplier(supplier);
            return rep;
        }
        public supplierDTOs getSuppliersBYId(int Id)
        {
            supplierDTOs rep = objmanager.getSuppliersBYId(Id);
            return rep;
        }
    }
}
