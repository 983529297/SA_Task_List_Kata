using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Console;
using Tasks.Data;

namespace Tasks.OperationImp
{
    public class OperationToday : IOperationToday
    {
        private readonly IConsole console;
        private readonly ITaskListData taskListData = TaskListData.Instance;

        public OperationToday(ref IConsole console)
        {
            this.console = console;
        }

        public void Today()
        {
            IDictionary<string, IList<IList<string>>> todayTasks = taskListData.GetTasksByDate(DateTime.Now);
            foreach (var project in todayTasks)
            {
                console.WriteLine(project.Key);
                foreach (var taskAttribute in project.Value)
                {
                    console.WriteLine("    [{0}] {1}: {2}{3}", taskAttribute[0], taskAttribute[1], taskAttribute[2], taskAttribute[3]);
                }
				console.WriteLine();
            }
        }
    }
}
