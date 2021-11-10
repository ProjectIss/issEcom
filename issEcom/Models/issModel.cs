using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace issEcom.Models
{
    public class issDB : DbContext
    {
        public issDB()
            : base("name=ISSModel")
        {
        }
       

        public System.Data.Entity.DbSet<issModels.customer> Customers { get; set; }
       
    }
}