using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Input;

namespace Tasks.Controller.UsecaseController
{
    public class CheckController : UsecaseControllerBase
    {
        public void Check(string idString)
        {
            executeOperationImp.Check(new DoCheckInputDto { Id = int.Parse(idString) });
        }
    }
}
