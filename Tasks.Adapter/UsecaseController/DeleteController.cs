using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;
using Tasks.Usecase.Input;

namespace Tasks.Controller.UsecaseController
{
    public class DeleteController
    {
        public void Delete(string idString)
        {
            new OperationDelete().ExecuteOperation(new DeleteInputDto { Id = int.Parse(idString) });
            //executeOperationImp.Delete(new DeleteInputDto { Id = int.Parse(idString) });
        }
    }
}
