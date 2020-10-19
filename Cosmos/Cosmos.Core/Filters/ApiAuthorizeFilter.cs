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
                // 如果使用了固定的Token不过期, 直接对token的合法性以及token是否存在进行验证
                if (context.Filters.Where(item => item is IFixedTokenFilter).FirstOrDefault() is IFixedTokenFilter fixedTokenFilter)
                {
                    fixedTokenFilter.OnAuthorization(context);
                    return;
                }
            }
        }
    }
}
