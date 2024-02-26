using System;
using Tasks.Console;
using Tasks.Data;
using Tasks.Implementation;

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
			IExecuteImp executeImp = new ExecuteImp(console);
			while (true)
			{
				console.Write("> ");
				var command = console.ReadLine();
				if (command == QUIT)
				{
					break;
				}
				executeImp.Execute(command);
			}
		}
	}
}
