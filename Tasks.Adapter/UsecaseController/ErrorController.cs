using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Controller.UsecaseController
{
    public class ErrorController : UsecaseControllerBase
    {
        public ErrorOutputDto Error(string command)
        {
            return executeOperationImp.Error(new ErrorInputDto { Command = command });
        }
    }
}
