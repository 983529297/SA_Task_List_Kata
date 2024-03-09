﻿using System;
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
			return operationShow.OperationAndReturn();
		}

		public void Deadline(string commandLine)
        {
			IOperateAndEnd operationDeadline = new OperationDeadline(commandLine);
			operationDeadline.OperateAndEnd();
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

		public void Delete(string idString)
        {
			IOperationDelete operationDelete = new OperationDelete();
			operationDelete.Delete(idString);
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
