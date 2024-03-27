using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Controller.UsecaseController
{
    public class DeleteController
    {
        public void Delete(IOperation<VoidOutputDto, DeleteInputDto> operation, string idString)
        {
            operation.ExecuteOperation(new DeleteInputDto { Id = int.Parse(idString) });
            //executeOperationImp.Delete(new DeleteInputDto { Id = int.Parse(idString) });
        }
    }
}
