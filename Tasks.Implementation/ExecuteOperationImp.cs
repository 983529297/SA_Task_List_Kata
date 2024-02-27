using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;
using Tasks.Console;

namespace Tasks.Implementation
{
    public class ExecuteOperationImp : IExecuteOperationImp
    {
		private IConsole console;
		private ITaskListData taskListData;
		public ExecuteOperationImp(ref IConsole console, ref ITaskListData taskListData)
        {
			this.console = console;
			this.taskListData = taskListData;
        }

		public void Show()
		{
			IOperationShow operationShow = new OperationShow(ref this.console, ref this.taskListData);
			operationShow.Show();
		}

		public void Add(string commandLine)
		{
			IOperationAdd operationAdd = new OperationAdd(this.console, this.taskListData);
			operationAdd.Add(commandLine);
		}

		public void Check(string idString)
		{
			IOperationDoCheck operationDoCheck = new OperationDoCheck(this.console, this.taskListData);
			operationDoCheck.SetDone(idString, true);
		}

		public void Uncheck(string idString)
		{
			IOperationDoCheck operationDoCheck = new OperationDoCheck(this.console, this.taskListData);
			operationDoCheck.SetDone(idString, false);
		}

		public void Help()
		{
			IOperationHelp operationHelp = new OperationHelp(this.console);
			operationHelp.Help();
		}

		public void Error(string command)
		{
			console.WriteLine("I don't know what the command \"{0}\" is.", command);
		}
	}
}
