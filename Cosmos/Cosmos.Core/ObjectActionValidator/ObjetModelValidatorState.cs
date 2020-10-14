using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos.Core.ObjectActionValidator
{
  public  class ObjetModelValidatorState
    {
        public ObjetModelValidatorState()
        {
            this.Status = true;
        }

        public bool Status { get; set; }
        public bool HasModelContent { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
    }
}
