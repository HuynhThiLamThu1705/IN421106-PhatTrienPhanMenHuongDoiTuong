using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealership.Domain.Interfaces
{
    public interface IOrderObserver
    {
        void OnOrderStatusChanged(string orderId, string status);
    }
}
