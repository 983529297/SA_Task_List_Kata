using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Controller.UsecaseController
{
    public class UncheckController
    {
        public void Uncheck(IOperation<VoidOutputDto, DoCheckInputDto> operation, string idString)
        {
            operation.ExecuteOperation(new DoCheckInputDto { Id = int.Parse(idString), Done = false });
            //executeOperationImp.Uncheck(new DoCheckInputDto { Id = int.Parse(idString) });
        }
    }
}
