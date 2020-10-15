using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos.Core.Configuration
{
    public class Connection
    {
        public string DBType { get; set; }
        public string DbCinnectionString { get; set; }
        public string RedisConnectionString { get; set; }
        public bool UseRedis { get; set; }
    }
}
