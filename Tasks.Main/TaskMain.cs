using System;
using System.Collections.Generic;
using System.Linq;
using Tasks.Console;
using Tasks.Controller;

namespace Tasks.Main
{
	public sealed class TaskMain
	{
		private IConsole console;

		public static void Main(string[] args)
		{
			new TaskMain(new RealConsole()).Run();
		}

		public TaskMain(IConsole console)
		{
			this.console = console;
		}

		public void Run()
		{
			new TaskController(console).Run();
        }
	}
}
