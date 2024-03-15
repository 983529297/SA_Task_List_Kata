using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ExecuteOperationImp;

namespace Tasks.Controller.UsecaseController
{
    public class TodayController : IUsecaseController
    {
        public IList<string> Execute(string command)
        {
            IList<string> parameter = command.Split(" ".ToCharArray());
            return today();
        }

        IList<string> today()
        {
            IExecuteOperationImp executeOperationImp = new ExecuteOperationImp.ExecuteOperationImp();
            return executeOperationImp.Today();
        }
    }
}
