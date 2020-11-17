using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cosmos.Core.Extension;
using Microsoft.AspNetCore.Hosting;
namespace Cosmos.Core.BaseProvider
{
   public class PathProvider
    {
        private IWebHostEnvironment _hostingEnvironment;

        public PathProvider(IWebHostEnvironment environment)
        {
            _hostingEnvironment = environment;
        }
        public IWebHostEnvironment GetHostingEnvironment()
        {
            return _hostingEnvironment;
        }

        public string MapPath(string path)
        {
            return MapPath(path, false);
        }
     
        public string MapPath(string path, bool rootPath)
        {
            if (rootPath)
            {
                if (_hostingEnvironment.WebRootPath == null)
                {
                    _hostingEnvironment.WebRootPath = _hostingEnvironment.ContentRootPath + "/wwwroot".ReplacePath();
                }
                return Path.Combine(_hostingEnvironment.WebRootPath, path).ReplacePath();
            }
            return Path.Combine(_hostingEnvironment.ContentRootPath, path).ReplacePath();
        }
    }
}
