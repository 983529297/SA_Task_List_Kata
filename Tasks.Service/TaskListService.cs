using System;
using Tasks.Console;
using Tasks.Data;
using Tasks.ExecuteImp;

namespace Tasks.Service
{
    public class TaskListService : ITaskListService
    {
		private const string QUIT = "quit";
        private IConsole console;

        public TaskListService(ref IConsole console)
        {
            this.console = console;
        }

		public void Run(string command)
		{
            IExecuteImp executeImp = new ExecuteImp.ExecuteImp(ref console);
			executeImp.Execute(command);
		}
	}
}
