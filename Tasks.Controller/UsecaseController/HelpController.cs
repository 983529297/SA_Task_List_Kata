using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Controller.UsecaseController
{
    public class HelpController : UsecaseControllerBase
    {
        public IList<string> Help()
        {
            return executeOperationImp.Help();
        }
    }
}
