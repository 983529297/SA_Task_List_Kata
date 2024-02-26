using System;
using Tasks.Console;
using Tasks.Data;

namespace Tasks.Service
{
    public class TaskListService : ITaskListService
    {
		private const string QUIT = "quit";

        private readonly IConsole console;
		private readonly TaskListData taskListData = new TaskListData();

        public TaskListService(ref IConsole console)
        {
            this.console = console;
        }

		public void Run()
		{
			while (true)
			{
				console.Write("> ");
				var command = console.ReadLine();
				if (command == QUIT)
				{
					break;
				}
				Execute(command);
			}
		}

		private void Execute(string commandLine)
		{
			var commandRest = commandLine.Split(" ".ToCharArray(), 2);
			var command = commandRest[0];
			switch (command)
			{
				case "show":
					Show();
					break;
				case "add":
					Add(commandRest[1]);
					break;
				case "check":
					Check(commandRest[1]);
					break;
				case "uncheck":
					Uncheck(commandRest[1]);
					break;
				case "help":
					Help();
					break;
				default:
					Error(command);
					break;
			}
		}

		private void Show()
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

		private void Add(string commandLine)
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

		private void Check(string idString)
		{
			SetDone(idString, true);
		}

		private void Uncheck(string idString)
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

		private void Help()
		{
			console.WriteLine("Commands:");
			console.WriteLine("  show");
			console.WriteLine("  add project <project name>");
			console.WriteLine("  add task <project name> <task description>");
			console.WriteLine("  check <task ID>");
			console.WriteLine("  uncheck <task ID>");
			console.WriteLine();
		}

		private void Error(string command)
		{
			console.WriteLine("I don't know what the command \"{0}\" is.", command);
		}
	}
}
