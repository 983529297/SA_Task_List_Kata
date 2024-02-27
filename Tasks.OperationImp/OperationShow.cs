using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Console;
using Tasks.Data;

namespace Tasks.OperationImp
{
    public class OperationShow : IOperationShow
    {
		private readonly IConsole console;
		private readonly ITaskListData taskListData;

		public OperationShow(ref IConsole console, ref ITaskListData taskListData)
        {
			this.console = console;
			this.taskListData = taskListData;
        }

        public void Show()
        {
			foreach (var project in taskListData.GetTaskList())
			{
				console.WriteLine(project.Key);
				foreach (var task in project.Value)
				{
					console.WriteLine("    [{0}] {1}: {2}", (task.Done ? 'x' : ' '), task.Id, task.Description);
				}
				console.WriteLine();
			}
		}
    }
}
