using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP.Refactored
{
    public class DbLogger : ILogger
    {
        public void LogMessage(string aMessage)
        {
            //Code to write message in database.  
        }
    }
}
