using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID.LSP.BadCode
{
    class ReadOnlySqlFile : SqlFile
    {
        public string LoadText()
        {
            /* Code to read text from sql file */
            return "";
        }
        public void SaveText()
        {
            /* Throw an exception when app flow tries to do save. */
            throw new IOException("Can't Save");
        }
    }
}
