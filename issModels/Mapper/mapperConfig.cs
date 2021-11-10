using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using issModels.Models;

namespace issModels.Mapper
{
    public class mapperConfig
    {
        public static void mapper()
        {
            //Initialize the mapper
            var customer = new MapperConfiguration(cfg =>
                    cfg.CreateMap<issModels.Models.customer, customerDTOs>()
                );
            var category = new MapperConfiguration(cfg =>
                   cfg.CreateMap<issModels.Models.category, categoryDTOs>()
               );
            var OrderDetail = new MapperConfiguration(cfg =>
                 cfg.CreateMap<issModels.Models.OrderDetail, OrderDetailDTOs>()
             );
            var Order = new MapperConfiguration(cfg =>
                cfg.CreateMap<issModels.Models.Order, OrderDTOs>()
            );
            var payment = new MapperConfiguration(cfg =>
               cfg.CreateMap<issModels.Models.payment, paymentDTOs>()
           );
            var product = new MapperConfiguration(cfg =>
              cfg.CreateMap<issModels.Models.product, productDTOs>()
          );
            var shipper = new MapperConfiguration(cfg =>
              cfg.CreateMap<issModels.Models.shipper, shipperDTOs>()
          );
            var supplier = new MapperConfiguration(cfg =>
             cfg.CreateMap<issModels.Models.supplier, supplierDTOs>()
         );
        }
    }
}
