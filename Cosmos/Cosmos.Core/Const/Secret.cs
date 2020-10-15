using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos.Core.Const
{
    public class Secret
    {
        public string UserKey { get; set; }
        public string DBKey { get; set; }
        public string RedisKey { get; set; }
        public string JWTKey { get; set; }

        public string Audicen { get; set; }
        public string Issuer { get; set; }
        public  const  string ExportFile = "C5ABA9E202D94C13A3CB66002BF77FAF";
    }
}
