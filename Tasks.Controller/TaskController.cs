using System;
using System.Collections.Generic;
using System.Linq;
using Tasks.Data;
using Tasks.Console;
using Tasks.Service;

namespace Tasks
{
	public sealed class TaskController
	{
		private const string QUIT = "quit";
		private IConsole console;

		public static void Main(string[] args)
		{
			new TaskController(new RealConsole()).Run();
		}

		public TaskController(IConsole console)
		{
			this.console = console;
		}

		public void Run()
		{
			ITaskListService taskListService = new TaskListService();
			while (true)
			{
				console.Write("> ");
				var command = console.ReadLine();
				if (command == QUIT)
				{
					break;
                }
                try
                {
                    IList<string> result = taskListService.Run(command);
                    if (result.Count != 0)
                    {
                        foreach (var line in result)
                        {
                            console.WriteLine(line);
                        }
                    }
                }
                catch (Exception ex)
                {
					console.WriteLine("Error : " + ex.Message);
                }
            }
        }
	}
}
