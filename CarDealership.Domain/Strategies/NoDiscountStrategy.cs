using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealership.Domain.Strategies
{
    public class NoDiscountStrategy : IDiscountStrategy
    {
        public decimal CalculateDiscount(decimal originalPrice)
        {
            if (originalPrice <= 0)
            {
                throw new ArgumentException(
                    "Giá xe phải lớn hơn 0.");
            }

            return 0;
        }
    }
}
