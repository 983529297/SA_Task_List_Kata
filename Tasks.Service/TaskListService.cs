﻿using System;
using System.Collections.Generic;
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

		public IList<string> Run(string command)
		{
            IExecuteImp executeImp = new ExecuteImp.ExecuteImp(ref console);
			return executeImp.Execute(command);
		}
	}
}
