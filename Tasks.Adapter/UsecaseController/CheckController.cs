using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Adapter.UsecaseController
{
    public class CheckController
    {
        public void Check(IOperation<VoidOutputDto, DoCheckInputDto> operation, string idString)
        {
            operation.ExecuteOperation(new DoCheckInputDto { Id = int.Parse(idString), Done = true });
        }
    }
}
