using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;
using Tasks.Console;
using Tasks.OperationImp;

namespace Tasks.ExecuteImp
{
    public class ExecuteOperationImp : IExecuteOperationImp
    {
		public IList<string> Show()
		{
			IOperationShow operationShow = new OperationShow();
			return operationShow.Show();
		}

		public void Deadline(string commandLine)
        {
			IOperationDeadline operationDeadline = new OperationDeadline();
			operationDeadline.Deadline(commandLine);
        }

		public IList<string> Today()
        {
			IOperationToday operationToday = new OperationToday();
			return operationToday.Today();
        }

		public void Add(string commandLine)
		{
			IOperationAdd operationAdd = new OperationAdd();
			operationAdd.Add(commandLine);
		}

		public void Check(string idString)
		{
			IOperationDoCheck operationDoCheck = new OperationDoCheck();
			operationDoCheck.SetDone(idString, true);
		}

		public void Uncheck(string idString)
		{
			IOperationDoCheck operationDoCheck = new OperationDoCheck();
			operationDoCheck.SetDone(idString, false);
		}

		public IList<string> Help()
		{
			IOperationHelp operationHelp = new OperationHelp();
			return operationHelp.Help();
		}

		public IList<string> Error(string command)
		{
			IOperationError operationError = new OperationError();
			return operationError.Error(command);
		}
	}
}
