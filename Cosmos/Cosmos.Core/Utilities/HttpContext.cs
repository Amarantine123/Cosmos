using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos.Core.Utilities
{
   public static class HttpContext
    {
        private static IHttpContextAccessor _accessor;
        public static Microsoft.AspNetCore.Http.HttpContext Current => _accessor.HttpContext;

        internal static  void Configure(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public static IApplicationBuilder UserStaticHttpContext(this IApplicationBuilder app)
        {
            var httpContextAccessor = app.ApplicationServices.GetRequiredService<IHttpContextAccessor>();

            Configure(httpContextAccessor);
            return app;
        }
    }
}
