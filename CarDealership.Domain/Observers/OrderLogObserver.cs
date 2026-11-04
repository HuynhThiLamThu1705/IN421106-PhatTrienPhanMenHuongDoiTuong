using CarDealership.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealership.Domain.Observers
{
    public class OrderLogObserver : IOrderObserver
    {
        public List<string> Messages { get; } = new();

        public void OnOrderStatusChanged(string orderId, string status)
        {
            Messages.Add(
                $"Đơn hàng {orderId} chuyển sang trạng thái: {status}");
        }
    }
}
