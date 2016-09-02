using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the constructor, specify a concrete implementation of the interface. 
            Console.WriteLine("Start program");
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();
            Console.WriteLine("End program");
        }
    }
}
