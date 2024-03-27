using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Controller
{
    public interface IExecution
    {
        IList<string> Execute(IDictionary<string, OperationBase> usecaseMap, string commandLine);
    }
}
