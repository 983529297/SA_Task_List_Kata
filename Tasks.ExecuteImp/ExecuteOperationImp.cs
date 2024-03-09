using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;
using Tasks.OperationImp;

namespace Tasks.ExecuteImp
{
    public class ExecuteOperationImp : IExecuteOperationImp
    {
		public IList<string> Show(string sortedMethod = "by project")
		{
			IOperateAndReturn operationShow = new OperationShowFactory().ShowMethod(sortedMethod);
			return operationShow.OperateAndReturn();
		}

		public void Deadline(string commandLine)
        {
			IOperateAndEnd operationDeadline = new OperationDeadline(commandLine);
			operationDeadline.OperateAndEnd();
        }

		public IList<string> Today()
        {
			IOperateAndReturn operationToday = new OperationToday();
			return operationToday.OperateAndReturn();
        }

		public void Add(string commandLine)
		{
			IOperateAndEnd operationAdd = new OperationAdd(commandLine);
			operationAdd.OperateAndEnd();
		}

		public void Delete(string idString)
        {
			IOperateAndEnd operationDelete = new OperationDelete(idString);
			operationDelete.OperateAndEnd();
        }

		public void Check(string idString)
		{
			IOperateAndEnd operationDoCheck = new OperationDoCheck(idString, true);
			operationDoCheck.OperateAndEnd();
		}

		public void Uncheck(string idString)
		{
			IOperateAndEnd operationDoCheck = new OperationDoCheck(idString, false);
			operationDoCheck.OperateAndEnd();
		}

		public IList<string> Help()
		{
			IOperateAndReturn operationHelp = new OperationHelp();
			return operationHelp.OperateAndReturn();
		}

		public IList<string> Error(string command)
		{
			IOperateAndReturn operationError = new OperationError(command);
			return operationError.OperateAndReturn();
		}
	}
}
