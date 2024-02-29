using System;
using System.Collections.Generic;

namespace Tasks.ExecuteImp
{
    public interface IExecuteImp
    {
        IList<string> Execute(string commandLine);
    }
}
