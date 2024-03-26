using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.Usecase
{
    public class OperationBase
    {
        protected ITaskListData taskListData = TaskListData.Instance;
    }
}
