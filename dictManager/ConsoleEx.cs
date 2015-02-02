using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace dictManager
{
    public class ConsoleEx
    {
        /// <summary>
        /// 启动控制台
        /// </summary>
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();

        /// <summary>
        /// 释放控制台
        /// </summary>
        [DllImport("kernel32.dll")]
        public static extern bool FreeConsole();
    }
}
