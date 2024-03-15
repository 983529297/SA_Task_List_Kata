using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ExecuteOperationImp;

namespace Tasks.Controller.UsecaseController
{
    public class ViewController : IUsecaseController
    {
        public IList<string> Execute(string command)
        {
            IList<string> parameter = command.Split(" ".ToCharArray());
            return view(command);
        }

        IList<string> view(string parameter)
        {
            IExecuteOperationImp executeOperationImp = new ExecuteOperationImp.ExecuteOperationImp();
            return executeOperationImp.Show(parameter);
        }
    }
}
