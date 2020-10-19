using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Cosmos.Core.Extension
{
  public static  class AuthorizationResponse
    {
        public static AuthorizationFilterContext Unauthorized(this AuthorizationFilterContext context, HttpStatusCode statusCode,
            string message=null)
        {
            context.Result = new ContentResult()
            {
                //Content = new  { message, status = false, code = (int)statusCode }.Serialize(),
                //ContentType="application/json",
                //StatusCode=(int)statusCode
            };

           
            return context;
        }
    }
}
