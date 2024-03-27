using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Output;
using Tasks.Usecase;
using Tasks.Usecase.Input;

namespace Tasks.Controller.UsecaseController
{
    public class TodayController
    {
        public TodayOutputDto Today(IOperation<TodayOutputDto, EmptyInputDto> operation)
        {
            return (TodayOutputDto) operation.ExecuteOperation(new EmptyInputDto());
        }
    }
}
