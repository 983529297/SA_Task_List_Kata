using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Controller.UsecaseController
{
    public class ShowController : UsecaseControllerBase
    {
        public ShowOutputDto Show(string command = "by project")
        {
            return executeOperationImp.Show(new ShowInputDto { Mode = command });
        }
    }
}
