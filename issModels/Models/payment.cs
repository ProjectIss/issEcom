using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issModels.Models
{
    public class payment
    {
        public int paymentId { get; set; }
        public string paymentType { get; set; }
        public string allowed { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
