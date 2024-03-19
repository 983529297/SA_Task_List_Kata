using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ExecuteOperationImp.Output;

namespace Tasks.ExecuteOperationImp
{
    public class OperationError : OperationBase
    {
        public ErrorOutputDto Error(string command)
        {
            return new ErrorOutputDto { ErrorCommand = command };
        }
    }
}
