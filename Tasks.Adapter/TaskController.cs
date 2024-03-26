﻿using System;
using System.Collections.Generic;
using Tasks.ExecuteOperationImp;
using Tasks.Console;

namespace Tasks.Controller
{
    public class TaskController
    {
		private const string QUIT = "quit";

        private readonly IConsole console;

        public TaskController(IConsole console)
        {
            this.console = console;
        }

        public void Run()
        {
            while (true)
            {
			    IExecution executeImp = new Execution();
                console.Write("> ");
                var commandLine = console.ReadLine();
                if (commandLine == QUIT)
                {
                    break;
                }
                try
                {
                    IList<string> result = executeImp.Execute(commandLine);
                    if (result.Count != 0)
                    {
                        foreach (var line in result)
                        {
                            console.WriteLine(line);
                        }
                    }
                }
                catch (Exception ex)
                {
                    console.WriteLine("Error : " + ex.Message);
                }
            }
        }
    }
}
