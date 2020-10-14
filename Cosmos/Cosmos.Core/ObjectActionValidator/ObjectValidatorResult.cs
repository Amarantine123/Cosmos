using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos.Core.ObjectActionValidator
{
  public  class ObjectValidatorResult
    {
        public ObjectValidatorResult()
        {

        }
        public ObjectValidatorResult(bool status)
        {
            this.Status = status;
        }

        public ObjectValidatorResult Ok(string message)
        {
            this.Status = true;
            this.Message = message;
            return this;

        }

        public ObjectValidatorResult Error(string message)
        {
            this.Status = false;
            this.Message = message;
            return this;
        }

        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
