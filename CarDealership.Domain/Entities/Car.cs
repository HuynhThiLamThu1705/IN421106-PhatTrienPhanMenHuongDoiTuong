using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealership.Domain.Entities
{
    public class Car
    {
        public string Id { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public decimal Price { get; private set; }

        public Car(string id, string brand, string model, decimal price)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Mã xe không được để trống.");

            if (string.IsNullOrWhiteSpace(brand))
                throw new ArgumentException("Hãng xe không được để trống.");

            if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentException("Tên dòng xe không được để trống.");

            if (price <= 0)
                throw new ArgumentException("Giá xe phải lớn hơn 0.");

            Id = id;
            Brand = brand;
            Model = model;
            Price = price;
        }
    }
}
