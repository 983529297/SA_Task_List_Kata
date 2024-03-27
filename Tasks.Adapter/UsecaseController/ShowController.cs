using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Controller.UsecaseController
{
    public class ShowController
    {
        public ShowOutputDto Show(IOperation<ShowOutputDto, ShowInputDto> operation, string command = "by project")
        {
            return operation.ExecuteOperation(new ShowInputDto { Mode = command });
        }
    }
}
