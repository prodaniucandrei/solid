using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.BadCode
{
    interface ILead
    {
        void CreateSubTask();
        void AssignTask();
        void WorkOnTask();
    }
}
