using Cosmos.Core.BaseProvider;
using Cosmos.Core.Extension.AutofacManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos.Core.Extension
{
  public  static  class ServerExtension
    {
        public static string MapPath(this string path, bool rootPath)
        {
            return AutofacContainerModule.GetService<IPathProvider>().MapPath(path, rootPath);
        }

        public static string MapPath(this string path)
        {
            return MapPath(path, false);
        }
    }
}
