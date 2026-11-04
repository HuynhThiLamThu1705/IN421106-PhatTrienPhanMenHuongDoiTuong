using CarDealership.Domain.Entities;
using CarDealership.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealership.Domain.Decorators
{
    public class BasicOrderService : IOrderService
    {
        private readonly Order _order;

        public BasicOrderService(Order order)
        {
            _order = order
                ?? throw new System.ArgumentNullException(nameof(order));
        }

        public string Description => "Đơn hàng xe cơ bản";

        public decimal GetTotalPrice()
        {
            return _order.TotalAmount;
        }
    }
}
