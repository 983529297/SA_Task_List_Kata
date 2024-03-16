using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ExecuteOperationImp.Input;

namespace Tasks.Controller.UsecaseController
{
    public class ShowController : UsecaseControllerBase
    {
        public IList<string> Show(string command = "by project")
        {
            return executeOperationImp.Show(new ShowInputDto { Mode = command });
        }
    }
}
