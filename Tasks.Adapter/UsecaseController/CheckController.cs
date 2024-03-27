using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;
using Tasks.Usecase.Input;

namespace Tasks.Controller.UsecaseController
{
    public class CheckController
    {
        public void Check(string idString)
        {
            new OperationDoCheck().ExecuteOperation(new DoCheckInputDto { Id = int.Parse(idString), Done = true });
            //executeOperationImp.Check(new DoCheckInputDto { Id = int.Parse(idString) });
        }
    }
}
