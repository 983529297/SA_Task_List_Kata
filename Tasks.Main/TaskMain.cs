using System;
using System.Collections.Generic;
using System.Linq;
using Tasks.Console;

namespace Tasks.Main
{
	public sealed class TaskMain
	{
		private const string QUIT = "quit";
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
			IExecuteOperation executeImp = new ExecuteOperation();
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
