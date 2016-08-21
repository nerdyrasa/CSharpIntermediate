using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testability
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
                DatePlaced = DateTime.Now,
                TotalCost = 100m
            };

            var orderProcessor = new OrderProcessor();

            orderProcessor.Process(order);
        }
    }
}
