using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ExecuteOperationImp.Input;
using Tasks.ExecuteOperationImp.Output;

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
