using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Console;
using Tasks.Data;

namespace Tasks.OperationImp
{
    public class OperationDoCheck : IOperationDoCheck
    {
        private readonly IConsole console;
        private readonly ITaskListData taskListData = TaskListData.Instance;

        public OperationDoCheck(IConsole console)
        {
            this.console = console;
        }

        public void SetDone(string idString, bool done)
        {
            int id = int.Parse(idString);
            taskListData.findTaskById(id, out Task identifiedTask); ;
            if (identifiedTask == null)
            {
                console.WriteLine("Could not find a task with an ID of {0}.", id);
                return;
            }

            taskListData.SetDone(done, ref identifiedTask);
        }
    }
}
