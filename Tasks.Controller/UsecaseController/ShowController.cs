using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Controller.UsecaseController
{
    public class ShowController : UsecaseControllerBase
    {
        public IList<string> Show(string command = "by project")
        {
            return executeOperationImp.Show(command);
        }
    }
}
