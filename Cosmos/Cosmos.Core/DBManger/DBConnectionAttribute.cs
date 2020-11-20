using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Core.DBManger
{
    public class DBConnectionAttribute : Attribute
    {
        public string DBName { get; set; }
    }
}
