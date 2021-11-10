using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issModels.Models
{
    public class supplierDTOs
    {
        public int supplierId { get; set; }
        public string companyName { get; set; }
        public string contactFName { get; set; }
        public string contactLName { get; set; }
        public string contactTitle { get; set; }
        public string firstAddress { get; set; }
        public string secondAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string URL { get; set; }
        public string paymentMethods { get; set; }
        public string discountType { get; set; }
        public string typeGoods { get; set; }
        public string notes { get; set; }
        public string discountAvailable { get; set; }
        public string currentOrder { get; set; }
        [MaxLength(500)]
        public string logo { get; set; }
        public int customerId{ get; set; }
        public virtual customer Customer { get; set; }
        public string sizeURL { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
