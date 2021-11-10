using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issModels.Models
{
    public class OrderDTOs
    {
        public int orderId { get; set; }
        public int customerId { get; set; }
        public virtual customer Customer { get; set; }
        public string orderNo { get; set; }
        public int paymentId { get; set; }
        public virtual payment Payment { get; set; }
        public DateTime? orderDate { get; set; }
        public DateTime? shipDate { get; set; }
        public DateTime? requiredDate { get; set; }
        public int shipperId { get; set; }
        public virtual shipper Shipper { get; set; }
        public string freight { get; set; }
        public string salesTax { get; set; }
        public string transactStatus { get; set; }
        public string errLoc { get; set; }
        public string errMsg { get; set; }
        public DateTime? timestamp { get; set; }
        public string fullfilled { get; set; }
        public string deleted { get; set; }
        public string paid { get; set; }
        public DateTime? paymentDate { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
