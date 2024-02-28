using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Console;
using Tasks.Data;

namespace Tasks.OperationImp
{
    public class OperationDoCheck : IOperationDoCheck
    {
        private readonly ITaskListData taskListData = TaskListData.Instance;

        public void SetDone(string idString, bool done)
        {
            int id = int.Parse(idString);
            taskListData.SetDone(id, done);
        }
    }
}
