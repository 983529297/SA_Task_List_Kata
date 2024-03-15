using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ExecuteOperationImp;

namespace Tasks.Controller.UsecaseController
{
    public class DeleteController : IUsecaseController
    {
        public IList<string> Execute(string command)
        {
            IList<string> parameter = command.Split(" ".ToCharArray());
            Delete(command);
            return new List<string>();
        }

        void Delete(string parameter)
        {
            IExecuteOperationImp executeOperationImp = new ExecuteOperationImp.ExecuteOperationImp();
            executeOperationImp.Delete(parameter);
        }
    }
}
