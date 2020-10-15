using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmos.Core.Filters
{
    public class ApiAuthorizeFilter : IAuthorizationFilter
    {
        public ApiAuthorizeFilter()
        {

        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.ActionDescriptor.EndpointMetadata.Any(item=>item is AllowAnonymousAttribute))
            {
                //if (context.Filters.Where(item=>item is IFixedTokenFilter))
                //{

                //}
            }
        }
    }
}
