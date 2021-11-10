using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using issModels.Models;

namespace issEcomAPI.Models
{
    public class issDB : DbContext
    {
        public issDB()
            : base("name=ISSModel")
        {
        }
       

        public System.Data.Entity.DbSet<customer> Customers { get; set; }
        public System.Data.Entity.DbSet<category> Categories { get; set; }
        public System.Data.Entity.DbSet<OrderDetail> OrderDetails { get; set; }
        public System.Data.Entity.DbSet<payment> Payments { get; set; }
        public System.Data.Entity.DbSet<product> Products { get; set; }
        public System.Data.Entity.DbSet<shipper> Shippers { get; set; }
        public System.Data.Entity.DbSet<Order> Orders { get; set; }
        public System.Data.Entity.DbSet<supplier> Suppliers { get; set; }
    }
}

