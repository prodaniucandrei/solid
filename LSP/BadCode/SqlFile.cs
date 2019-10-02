using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.BadCode
{
    class SqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            /* Code to read text from sql file */
            return "";
        }
        public bool SaveText()
        {
            /* Code to save text into sql file */
            return true;
        }
    }
}
