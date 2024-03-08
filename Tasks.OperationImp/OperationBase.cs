using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.OperationImp
{
    public class OperationBase
    {
        protected ITaskListData taskListData = TaskListData.Instance;
    }
}
