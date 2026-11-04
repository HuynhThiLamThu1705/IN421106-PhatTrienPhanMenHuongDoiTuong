using CarDealership.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealership.Domain.Factories
{
    public class OrderFactory
    {
        public Order CreateOrder(
            string orderId,
            Customer customer,
            Car car)
        {
            return new Order(orderId, customer, car);
        }
    }
}
