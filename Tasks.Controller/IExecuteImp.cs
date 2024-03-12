using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Controller
{
    public interface IExecuteImp
    {
        IList<string> Execute(string commandLine);
    }
}
