using System;
using System.Collections.Generic;
using Tasks.Console;
using Tasks.Data;
using Tasks.ExecuteImp;

namespace Tasks.Service
{
    public class TaskListService : ITaskListService
    {
		public IList<string> Run(string command)
		{
            IExecuteImp executeImp = new ExecuteImp.ExecuteImp();
			return executeImp.Execute(command);
		}
	}
}
