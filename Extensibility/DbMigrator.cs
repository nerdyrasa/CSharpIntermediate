using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    // Just a shell of a Db Migrator class to illustrate how logging can be implemented
    // in such a way that the class is an example of the Open-Closed Principle (OCP).
    // Open to extension, closed to modification

    public class DbMigrator
    {
        private readonly ILogger _logger;

        // This is an example of dependency injection: Constructor Injection

        // Good reference for dependency injection:
        // http://www.dotnet-tricks.com/Tutorial/dependencyinjection/67LX120413-Implementation-of-Dependency-Injection-Pattern-in-C

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

    }
}
