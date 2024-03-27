using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;
using Tasks.Usecase.Input;

namespace Tasks.Controller.UsecaseController
{
    public class UncheckController : UsecaseControllerBase
    {
        public void Uncheck(string idString)
        {
            new OperationDoCheck().ExecuteOperation(new DoCheckInputDto { Id = int.Parse(idString), Done = false });
            //executeOperationImp.Uncheck(new DoCheckInputDto { Id = int.Parse(idString) });
        }
    }
}
