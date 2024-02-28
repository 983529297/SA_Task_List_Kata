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
		private readonly ITaskListData taskListData = TaskListData.Instance;

		public OperationShow(ref IConsole console)
        {
			this.console = console;
        }

        public void Show()
        {
			foreach (var project in taskListData.GetTaskList())
			{
				console.WriteLine(project.Key);
				foreach (var task in project.Value)
				{
					console.WriteLine("    [{0}] {1}: {2}{3}", (task.Done ? 'x' : ' '), task.Id, task.Description, task.deadline.HasValue ? " " + task.deadline.Value.ToString("yyyy-MM-dd") : "");
				}
				console.WriteLine();
			}
		}
    }
}
