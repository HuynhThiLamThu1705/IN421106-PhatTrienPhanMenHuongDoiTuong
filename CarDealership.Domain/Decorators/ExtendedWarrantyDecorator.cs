using CarDealership.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealership.Domain.Decorators
{
    public class ExtendedWarrantyDecorator : IOrderService
    {
        private readonly IOrderService _service;
        private readonly decimal _warrantyPrice;

        public ExtendedWarrantyDecorator(
            IOrderService service,
            decimal warrantyPrice)
        {
            _service = service
                ?? throw new System.ArgumentNullException(nameof(service));

            if (warrantyPrice < 0)
            {
                throw new System.ArgumentOutOfRangeException(
                    nameof(warrantyPrice),
                    "Phí bảo hành không được âm.");
            }

            _warrantyPrice = warrantyPrice;
        }

        public string Description =>
            _service.Description + " + Bảo hành mở rộng";

        public decimal GetTotalPrice()
        {
            return _service.GetTotalPrice() + _warrantyPrice;
        }
    }
}
