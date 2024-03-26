using System;
using System.Collections.Generic;
using Tasks.Usecase;
using Tasks.Console;

namespace Tasks.Controller
{
    public class TaskController
    {
		private const string QUIT = "quit";

        private readonly IConsole console;

        public TaskController(IConsole console)
        {
            this.console = console;
        }

        public IList<string> Run(string commandLine)
        {
			IExecution executeImp = new Execution();
            return executeImp.Execute(commandLine);
        }
    }
}
