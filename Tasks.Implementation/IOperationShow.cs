using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Console;
using Tasks.Data;

namespace Tasks.Implementation
{
    public interface IOperationShow
    {
        void Show(IConsole console, ITaskListData taskListData);
    }
}
