using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;
using Tasks.Console;

namespace Tasks.Implementation
{
    public class ExecuteOperationImp
    {
		private readonly IConsole console;
		private readonly TaskListData taskListData;
		public ExecuteOperationImp(IConsole console, TaskListData taskListData)
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

		public void Add(string commandLine)
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

		public void Check(string idString)
		{
			SetDone(idString, true);
		}

		public void Uncheck(string idString)
		{
			SetDone(idString, false);
		}

		private void SetDone(string idString, bool done)
		{
			int id = int.Parse(idString);
			taskListData.findTaskById(id, out Tasks.Data.Task identifiedTask); ;
			if (identifiedTask == null)
			{
				console.WriteLine("Could not find a task with an ID of {0}.", id);
				return;
			}

			taskListData.SetDone(done, ref identifiedTask);
		}

		public void Help()
		{
			console.WriteLine("Commands:");
			console.WriteLine("  show");
			console.WriteLine("  add project <project name>");
			console.WriteLine("  add task <project name> <task description>");
			console.WriteLine("  check <task ID>");
			console.WriteLine("  uncheck <task ID>");
			console.WriteLine();
		}

		public void Error(string command)
		{
			console.WriteLine("I don't know what the command \"{0}\" is.", command);
		}
	}
}
