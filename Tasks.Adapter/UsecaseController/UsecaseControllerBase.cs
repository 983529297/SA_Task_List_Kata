using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;

namespace Tasks.Controller.UsecaseController
{
    public abstract class UsecaseControllerBase
    {
        public readonly IExecuteOperationImp executeOperationImp = new Usecase.ExecuteOperationImp();

    }
}
