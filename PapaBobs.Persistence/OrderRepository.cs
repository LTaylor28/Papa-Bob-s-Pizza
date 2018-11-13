using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PapaBobs.DTO;

namespace PapaBobs.Persistence
{
    public class OrderRepository
    {
        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {
            var db = new PapaBobsDbEntities();
            var order = convertToEnitity(orderDTO);

            order.OrderId = Guid.NewGuid();
            order.Size = 1;
            order.Crust = 0;
            order.Pepperoni = true;
            order.Name = "test";
            order.Address = "123 buck st";
            order.ZipCode = "12345";
            order.Phone = "555-555";
            order.PaymentType = 0;
            order.TotalCost = 16.50M;

            db.Orders.Add(order);
            db.SaveChanges();

        }
    
        private static Order convertToEnitity(OrderDTO orderDTO)
        {
            var order = new Order();
            order.OrderId = orderDTO.OrderId;
            order.Size = orderDTO.Size;
            order.Crust = orderDTO.Crust;
            order.Sausage = orderDTO.Sausage;
            order.Pepperoni = orderDTO.Pepperoni;
            order.Onions = orderDTO.Onions;
            order.GreenPeppers = orderDTO.GreenPeppers;
            order.Name = orderDTO.Name;
            order.Address = orderDTO.Address;
            order.ZipCode = orderDTO.ZipCode;
            order.Phone = orderDTO.Phone;
            order.TotalCost = order.TotalCost;
            order.PaymentType = orderDTO.PaymentType;

            return order;



            throw new NotImplementedException();
        }
    }
}


