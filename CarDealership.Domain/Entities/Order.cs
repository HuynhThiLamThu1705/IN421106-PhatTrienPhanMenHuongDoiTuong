using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealership.Domain.Entities
{
    public class Order
    {
        public string Id { get; private set; }
        public Customer Customer { get; private set; }
        public Car Car { get; private set; }
        public decimal TotalAmount { get; private set; }

        public Order(string id, Customer customer, Car car)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Mã đơn hàng không được để trống.");

            Customer = customer
                ?? throw new ArgumentNullException(nameof(customer));

            Car = car
                ?? throw new ArgumentNullException(nameof(car));

            Id = id;
            TotalAmount = car.Price;
        }
    }
}
