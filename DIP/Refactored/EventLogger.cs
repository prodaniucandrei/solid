using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP.Refactored
{
    public class EventLogger : ILogger
    {
        public void LogMessage(string aMessage)
        {
            //Code to write message in system's event viewer.  
        }
    }
}
