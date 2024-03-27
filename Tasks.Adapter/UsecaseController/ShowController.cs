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
        public ShowOutputDto Show(string command = "by project")
        {
            return new OperationShow().ExecuteOperation(new ShowInputDto { Mode = command });
            //return executeOperationImp.Show(new ShowInputDto { Mode = command });
        }
    }
}
