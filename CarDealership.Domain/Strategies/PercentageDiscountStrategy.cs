using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealership.Domain.Strategies
{
    public class PercentageDiscountStrategy : IDiscountStrategy
    {
        private readonly decimal _percentage;

        public PercentageDiscountStrategy(decimal percentage)
        {
            if (percentage < 0 || percentage > 100)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(percentage),
                    "Phần trăm giảm giá phải từ 0 đến 100.");
            }

            _percentage = percentage;
        }

        public decimal CalculateDiscount(decimal originalPrice)
        {
            if (originalPrice <= 0)
            {
                throw new ArgumentException(
                    "Giá xe phải lớn hơn 0.");
            }

            return originalPrice * _percentage / 100;
        }
    }
}
