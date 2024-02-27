using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Console;
using Tasks.Data;

namespace Tasks.Implementation
{
    public class OperationShow : IOperationShow
    {
        public void Show(IConsole console, ITaskListData taskListData)
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
