using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ExecuteOperationImp;

namespace Tasks.Controller.UsecaseController
{
    public class AddController : IUsecaseController
    {
        public IList<string> Execute(string command)
        {
            IList<string> parameter = command.Split(" ".ToCharArray());
            Add(command);
            return new List<string>();
        }

        void Add(string parameter)
        {
            IExecuteOperationImp executeOperationImp = new ExecuteOperationImp.ExecuteOperationImp();
            executeOperationImp.Add(parameter);
        }
    }
}
