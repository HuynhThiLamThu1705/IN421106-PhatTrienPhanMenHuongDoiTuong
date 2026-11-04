using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealership.Domain.Entities
{
    public class Customer
    {
        public string Id { get; private set; }
        public string FullName { get; private set; }
        public string Phone { get; private set; }

        public Customer(string id, string fullName, string phone)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Mã khách hàng không được để trống.");

            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Tên khách hàng không được để trống.");

            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("Số điện thoại không được để trống.");

            Id = id;
            FullName = fullName;
            Phone = phone;
        }
    }
}
