using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID.DIP.BadCode
{
    class DataExporter
    {
        public void ExportDataFromFile()
        {
            try
            {
                //code to export data from files to database.  
            }
            //catch (IOException ex)
            //{
            //    new ExceptionLogger().LogIntoDataBase(ex);
            //}
            catch (Exception ex)
            {
                new ExceptionLogger().LogIntoFile(ex);
            }
        }
    }
}
