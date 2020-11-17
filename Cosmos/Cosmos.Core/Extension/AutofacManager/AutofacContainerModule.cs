using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos.Core.Extension.AutofacManager
{
  public static  class AutofacContainerModule
    {
        public static TService GetService<TService>()where TService:class
        {
            return typeof(TService).GetService() as TService;
        }

        public static object GetService(this Type serviceType)
        {
            return Utilities.HttpContext.Current.RequestServices.GetService(serviceType);
        }
    }
}
