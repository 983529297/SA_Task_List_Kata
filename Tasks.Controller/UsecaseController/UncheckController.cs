using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ExecuteOperationImp.Input;

namespace Tasks.Controller.UsecaseController
{
    public class UncheckController : UsecaseControllerBase
    {
        public void Uncheck(string idString)
        {
            executeOperationImp.Uncheck(new DoCheckInputDto { Id = int.Parse(idString) });
        }
    }
}
