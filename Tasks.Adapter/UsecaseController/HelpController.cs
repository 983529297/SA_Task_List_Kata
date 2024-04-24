using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Output;
using Tasks.Usecase;
using Tasks.Usecase.Input;

namespace Tasks.Adapter.UsecaseController
{
    public class HelpController
    {
        public HelpOutputDto Help(IOperation<HelpOutputDto, EmptyInputDto> operation)
        {
            return operation.ExecuteOperation(new EmptyInputDto());
        }
    }
}
