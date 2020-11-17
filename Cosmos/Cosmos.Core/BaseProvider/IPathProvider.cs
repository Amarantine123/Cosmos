using Cosmos.Core.Extension.AutofacManager;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Hosting;
namespace Cosmos.Core.BaseProvider
{
   public interface IPathProvider:IDependency
    {
        string MapPath(string path);
        string MapPath(string path, bool rootPath);
        IWebHostEnvironment GetHostingEnvironment();
    }
}
