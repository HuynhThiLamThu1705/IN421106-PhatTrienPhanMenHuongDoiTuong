using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealership.Domain.Interfaces
{
    public interface IOrderService
    {
        string Description { get; }
        decimal GetTotalPrice();
    }
}
