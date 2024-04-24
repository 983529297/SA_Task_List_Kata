using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Adapter.UsecaseController
{
    public class ErrorController
    {
        public ErrorOutputDto Error(IOperation<ErrorOutputDto, ErrorInputDto> operation, string command)
        {
            return operation.ExecuteOperation(new ErrorInputDto { Command = command });
        }
    }
}
