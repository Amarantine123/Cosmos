using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos.Core.Filters
{
   public interface IFixedTokenFilter:IFilterMetadata
    {
        AuthorizationFilterContext OnAuthorization(AuthorizationFilterContext context);
    }

    public class FixedTokenAttribute : Attribute, IFixedTokenFilter, IAllowAnonymous
    {
        public AuthorizationFilterContext OnAuthorization(AuthorizationFilterContext context)
        {
            string fixedToken = "";
            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {
                //fixedToken=context.HttpContext.Request.Headers[AppSetting]
            }
            return context;
        }
    }

}
