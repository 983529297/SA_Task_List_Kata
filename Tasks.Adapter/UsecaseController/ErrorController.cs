using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Controller.UsecaseController
{
    public class ErrorController
    {
        public ErrorOutputDto Error(string command)
        {
            return new OperationError().ExecuteOperation(new ErrorInputDto { Command = command });
            //return executeOperationImp.Error(new ErrorInputDto { Command = command });
        }
    }
}
