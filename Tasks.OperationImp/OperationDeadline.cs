using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Console;
using Tasks.Data;

namespace Tasks.OperationImp
{
    public class OperationDeadline : IOperationDeadline
    {
        private IConsole console;
        private ITaskListData taskListData;

        public OperationDeadline(ref IConsole console, ref ITaskListData taskListData)
        {
            this.console = console;
            this.taskListData = taskListData;
        }

        public void Deadline(string commandLine)
        {
            var subcommandRest = commandLine.Split(" ".ToCharArray(), 2);
            var idString = subcommandRest[0];
            var deadlineString = subcommandRest[1];
            int id = int.Parse(idString);
            DateTime deadline = DateTime.Parse(deadlineString);
            taskListData.findTaskById(id, out Task identifiedTask); ;
            if (identifiedTask == null)
            {
                console.WriteLine("Could not find a task with an ID of {0}.", id);
                return;
            }
            taskListData.SetDeadline(deadline, ref identifiedTask);
        }
    }
}
