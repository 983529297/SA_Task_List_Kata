using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Service
{
    public interface ITaskListService
    {
        IList<string> Run(string command);
    }
}
