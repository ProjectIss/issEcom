using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issModels.Models
{
    public class OrderDetail
    {
        public int orderDetailId { get; set; }
        public string orderId { get; set; }
        public int productId { get; set; }
        public virtual product Product { get; set; }
        public string OrderNo { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string discount { get; set; }
        public string total { get; set; }
        public string IDSKU { get; set; }
        public string size { get; set; }
        public string color { get; set; }
        public string fulfilled { get; set; }
        public DateTime? shipDate { get; set; }
        public DateTime? billDate { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
