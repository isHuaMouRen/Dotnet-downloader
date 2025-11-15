using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DotnetDownloader.Class
{
    public static class AppInfo
    {
        public static readonly string ExecutePath = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}";//执行位置
        public static readonly string Version = $"1.0.0-alpha.1";//版本
        public static readonly string DotnetIndexUrl = $"https://dotnetcli.blob.core.windows.net/dotnet/release-metadata/releases-index.json";
    }
}
