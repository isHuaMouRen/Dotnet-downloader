using HuaZi.Library.Logger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DotnetDownloader.Class.Globals;

namespace DotnetDownloader.Class
{
    public class AppLogger
    {
        public static Logger logger = new Logger(Path.Combine(AppInfo.ExecutePath, "Logs"));
    }
}
