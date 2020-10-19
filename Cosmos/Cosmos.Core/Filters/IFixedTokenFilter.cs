using Cosmos.Core.Configuration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos.Core.Filters
{
   public interface IFixedTokenFilter:IFilterMetadata
    {
        // Called early in the filter pipeline to confirm request is authorized.
        AuthorizationFilterContext OnAuthorization(AuthorizationFilterContext context);
    }

    public class FixedTokenAttribute : Attribute, IFixedTokenFilter, IAllowAnonymous
    {
        public AuthorizationFilterContext OnAuthorization(AuthorizationFilterContext context)
        {
            string fixedToken = "";
            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {
                fixedToken = context.HttpContext.Request.Headers[AppSetting.TokenHeaderName];
                fixedToken = fixedToken?.Replace("Bearer", "");

                if (string.IsNullOrEmpty(fixedToken))
                {
                    //return context.
                }
            }
            return context;
        }
    }

}
