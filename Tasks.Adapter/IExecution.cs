using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Controller
{
    public interface IExecution
    {
        IList<string> Execute(IDictionary<string, object> usecaseMap, string commandLine);
    }
}
