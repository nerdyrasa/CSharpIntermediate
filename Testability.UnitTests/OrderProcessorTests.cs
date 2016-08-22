using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testability;

namespace Testability.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        // how to name your unit tests
        // methodname_condition_expectedresults

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsException()
        {
            // Pass a fake object that is always working

            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());

            var order = new Order
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);

        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetShipmentPropertyOfOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();
            orderProcessor.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.ShippingCost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);   

        }
    }

    

    public class FakeShippingCalculator : IShippingCalculator
    {
        public decimal CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
