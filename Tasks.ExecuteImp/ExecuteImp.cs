﻿using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.ExecuteImp
{
    public class ExecuteImp : IExecuteImp
    {
		private readonly IExecuteOperationImp executeOperationImp = new ExecuteOperationImp();

		public IList<string> Execute(string commandLine)
        {
			var commandRest = commandLine.Split(" ".ToCharArray(), 2);
			var command = commandRest[0];
			switch (command)
			{
                case "show":
					return executeOperationImp.Show();
                case "view":
					return executeOperationImp.Show(commandRest[1]);
				case "deadline":
					executeOperationImp.Deadline(commandRest[1]);
					break;
				case "today":
					return executeOperationImp.Today();
				case "add":
					executeOperationImp.Add(commandRest[1]);
					break;
				case "delete":
					executeOperationImp.Delete(commandRest[1]);
					break;
				case "check":
					executeOperationImp.Check(commandRest[1]);
					break;
				case "uncheck":
					executeOperationImp.Uncheck(commandRest[1]);
					break;
				case "help":
					return executeOperationImp.Help();
				default:
					return executeOperationImp.Error(command);
			}

			return new List<string>();
		}
    }
}
