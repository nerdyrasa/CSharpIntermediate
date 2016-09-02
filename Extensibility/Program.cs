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

            // var dbMigrator = new DbMigrator(new ConsoleLogger());

            // Now, we can simply change the behavior by passing in a different implementation of ILogger

            var dbMigrator = new DbMigrator(new FileLogger("C:\\projects\\log.txt"));

            dbMigrator.Migrate();
        }
    }
}
