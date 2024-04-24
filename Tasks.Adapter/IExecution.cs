using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Adapter
{
    public interface IExecution
    {
        IList<string> Execute(IUsecaseDependency usecaseDependency, string commandLine);
    }
}
