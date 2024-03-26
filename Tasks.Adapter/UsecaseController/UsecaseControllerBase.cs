using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ExecuteOperationImp;

namespace Tasks.Controller.UsecaseController
{
    public abstract class UsecaseControllerBase
    {
        public readonly IExecuteOperationImp executeOperationImp = new ExecuteOperationImp.ExecuteOperationImp();

    }
}
