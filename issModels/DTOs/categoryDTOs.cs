using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issModels.Models
{
    public class categoryDTOs
    {
        public int categoryId { get; set; }
        
        public string categoryName { get; set; }
        public string description { get; set; }
        [MaxLength(500)]
        public string picture { get; set; }
        public string active { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
