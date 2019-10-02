using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP.Refactored
{
    public class FileLogger : ILogger
    {
        public void LogMessage(string aStackTrace)
        {
            //code to log stack trace into a file.  
        }
    }
}
