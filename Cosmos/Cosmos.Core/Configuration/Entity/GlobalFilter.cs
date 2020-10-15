using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos.Core.Configuration
{
  public  class GlobalFilter
    {
        public string Message { get; set; }
        public bool Enable { get; set; }
        public string[] Actions { get; set; }
    }
}
