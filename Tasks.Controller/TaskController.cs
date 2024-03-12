using System;
using System.Collections.Generic;
using System.Linq;
using Tasks.Console;
using Tasks.ExecuteImp;

namespace Tasks.Controller
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
			IExecuteImp executeImp = new ExecuteImp();
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
                    IList<string> result = executeImp.Execute(command);
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
