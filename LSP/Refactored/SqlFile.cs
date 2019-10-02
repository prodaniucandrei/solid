using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.Refactored
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
        public void SaveText()
        {
            /* Code to save text into sql file */
        }
    }
}
