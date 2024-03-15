using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Main
{
    public interface IExecuteOperation
    {
        IList<string> Execute(string commandLine);
    }
}
