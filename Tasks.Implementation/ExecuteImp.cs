using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;
using Tasks.Console;

namespace Tasks.Implementation
{
    public class ExecuteImp : IExecuteImp
    {
		private readonly ITaskListData taskListData = new TaskListData();
		private readonly IExecuteOperationImp executeOperationImp;

		public ExecuteImp(ref IConsole console)
        {
			executeOperationImp = new ExecuteOperationImp(ref console, ref taskListData);
        }

		public void Execute(String commandLine)
        {
			var commandRest = commandLine.Split(" ".ToCharArray(), 2);
			var command = commandRest[0];
			switch (command)
			{
				case "show":
					executeOperationImp.Show();
					break;
				case "add":
					executeOperationImp.Add(commandRest[1]);
					break;
				case "check":
					executeOperationImp.Check(commandRest[1]);
					break;
				case "uncheck":
					executeOperationImp.Uncheck(commandRest[1]);
					break;
				case "help":
					executeOperationImp.Help();
					break;
				default:
					executeOperationImp.Error(command);
					break;
			}
		}
    }
}
