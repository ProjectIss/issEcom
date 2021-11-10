using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issModels.Models
{
    public class product
    {
        public int productId { get; set; }
        public string SKU { get; set; }
        public string IDSKU { get; set; }
        public string vendorproductId { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public int supplierId { get; set; }
        public virtual supplier Supplier { get; set; }
        public int categoryId { get; set; }
        public virtual category Category { get; set; }
        public string quantityPerUnit { get; set; }
        public string unitPrice { get; set; }
        public string MSRP { get; set; }
        public string availableSize { get; set; }
        public string availableColors { get; set; }
        public string size { get; set; }
        public string color { get; set; }
        public string discount { get; set; }
        public string unitWeight { get; set; }
        public string unitslnStok { get; set; }
        public string unitsOnOrder { get; set; }
        public string recorderLevel { get; set; }
        public string productAvailable { get; set; }
        public string discountAvailable { get; set; }
        public string currentOrder { get; set; }
         [MaxLength(500)]
        public string picture { get; set; }
        public string ranking { get; set; }
        public string note { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
