using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Console;
using Tasks.Data;

namespace Tasks.OperationImp
{
    public class OperationAdd : IOperationAdd
    {

		private readonly IConsole console;
		private readonly ITaskListData taskListData;

		public OperationAdd(IConsole console, ITaskListData taskListData)
        {
			this.console = console;
			this.taskListData = taskListData;
        }

		public void Add(String commandLine)
        {
			var subcommandRest = commandLine.Split(" ".ToCharArray(), 2);
			var subcommand = subcommandRest[0];
			if (subcommand == "project")
			{
				AddProject(subcommandRest[1]);
			}
			else if (subcommand == "task")
			{
				var projectTask = subcommandRest[1].Split(" ".ToCharArray(), 2);
				AddTask(projectTask[0], projectTask[1]);
			}
		}

		private void AddProject(string name)
		{
			taskListData.AddProject(name);
		}

		private void AddTask(string project, string description)
		{
			if (!taskListData.CheckProject(project))
			{
				System.Console.WriteLine("Could not find a project with the name \"{0}\".", project);
				return;
			}
			taskListData.AddTask(project, description);
		}
	}
}
