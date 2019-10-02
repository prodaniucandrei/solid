using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.Refactored
{
    interface ILead
    {
        void AssignTask();
        void CreateSubTask();
    }
}
