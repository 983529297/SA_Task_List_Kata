using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Usecase
{
    public class OperationError : OperationBase
    {
        public ErrorOutputDto Error(string command)
        {
            return new ErrorOutputDto { ErrorCommand = command };
        }
    }
}
