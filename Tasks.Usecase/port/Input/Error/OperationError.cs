using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Usecase
{
    public class OperationError : OperationBase, IOperation<ErrorOutputDto, ErrorInputDto>
    {
        public ErrorOutputDto ExecuteOperation(ErrorInputDto errorInputDto)
        {
            return new ErrorOutputDto { ErrorCommand = errorInputDto.Command };
        }
    }
}
