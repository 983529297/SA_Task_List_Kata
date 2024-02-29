using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.OperationImp
{
    public class OperationDelete : IOperationDelete
    {
        private readonly ITaskListData taskListData = TaskListData.Instance;

        public void Delete(string idString)
        {
            int id = int.Parse(idString);
            taskListData.DeleteTask(id);
        }
    }
}
