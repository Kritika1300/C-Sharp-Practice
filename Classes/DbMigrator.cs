using System.Collections.Generic;
using System;

namespace Classes
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo($"We are migrating on { DateTime.Today}");
            _logger.LogInfo($"We are migrating till {DateTime.Today.AddHours(2)}");
        }

    }

}
