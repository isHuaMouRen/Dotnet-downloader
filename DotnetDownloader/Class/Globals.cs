using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using HuaZi.Library.Logger;

namespace DotnetDownloader.Class
{
    public static class Globals
    {
        //变量
        public static class Var
        {
            public static readonly string ExecutePath = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}";//执行位置
            public static readonly string Version = $"1.0.0-alpha.1";
        }

        //对象
        public static class Obj
        {
            public static Logger logger = new Logger(Path.Combine(Var.ExecutePath, "Logs"));
        }
    }
}
