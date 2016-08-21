using System;

namespace Testability
{
    public class ShippingCalculator
    {
        public decimal CalculateShipping(Order order)
        {
            if (order.TotalCost < 30m)
                return order.TotalCost * 0.1m;

            return 0;
        }
    }
}