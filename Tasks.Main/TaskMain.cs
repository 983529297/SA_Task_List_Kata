using System;
using System.Collections.Generic;
using System.Linq;
using Tasks.Console;
using Tasks.Adapter;

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
            Execution execution = new Execution();
			while (true)
            {
                console.Write("> ");
                var commandLine = console.ReadLine();
                if (commandLine == QUIT)
                {
                    break;
                }
                try
                {
                    IList<string> result = execution.Execute(new UsecaseDependency(), commandLine);
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
