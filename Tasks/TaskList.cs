using System;
using System.Collections.Generic;
using System.Linq;
using Tasks.Data;
using Tasks.Console;
using Tasks.Service;

namespace Tasks
{
	public sealed class TaskList
	{
		private const string QUIT = "quit";

		private readonly TaskListData taskListData = new TaskListData();
		private IConsole console;

		public static void Main(string[] args)
		{
			new TaskList(new RealConsole()).Run();
		}

		public TaskList(IConsole console)
		{
			this.console = console;
		}

		public void Run()
		{
			new TaskListService(ref this.console).Run();
		}
	}
}
