using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ExecuteOperationImp;

namespace Tasks.Controller.UsecaseController
{
    public class ErrorController : IUsecaseController
    {
        public IList<string> Execute(string command)
        {
            IList<string> parameter = command.Split(" ".ToCharArray());
            return Error(command);
        }

        IList<string> Error(string parameter)
        {
            IExecuteOperationImp executeOperationImp = new ExecuteOperationImp.ExecuteOperationImp();
            return executeOperationImp.Error(parameter);
        }
    }
}
