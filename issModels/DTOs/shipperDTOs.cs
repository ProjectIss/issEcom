using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issModels.Models
{
    public class shipperDTOs
    {
        public int shipperId { get; set; }
        public string companyName { get; set; }
        public string phoneNo { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
