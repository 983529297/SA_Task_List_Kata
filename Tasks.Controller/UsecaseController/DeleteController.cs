using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Controller.UsecaseController
{
    public class DeleteController : UsecaseControllerBase
    {
        public void Delete(string command)
        {
            executeOperationImp.Delete(command);
        }
    }
}
