using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealership.Domain.Strategies
{
    public interface IDiscountStrategy
    {
        decimal CalculateDiscount(decimal originalPrice);
    }
}
