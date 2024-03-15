using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.ExecuteOperationImp
{
    public class ExecuteOperationImp : IExecuteOperationImp
    {
		public IList<string> Show(string sortedMethod = "by project")
		{
			IOperateAndReturn operationShow = new OperationShowFactory().ShowMethod(sortedMethod);
			return operationShow.OperateAndReturn();
		}

		public void Deadline(string idString, string deadlineString)
        {
			IOperateAndEnd operationDeadline = new OperationDeadline(idString, deadlineString);
			operationDeadline.OperateAndEnd();
        }

		public IList<string> Today()
        {
			IOperateAndReturn operationToday = new OperationToday();
			return operationToday.OperateAndReturn();
        }

		public void Add(string mode, string projectName, string description = "")
		{
			IOperateAndEnd operationAdd = new OperationAdd(mode, projectName, description);
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
