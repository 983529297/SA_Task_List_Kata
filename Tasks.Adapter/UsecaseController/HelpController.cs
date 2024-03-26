using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Output;

namespace Tasks.Controller.UsecaseController
{
    public class HelpController : UsecaseControllerBase
    {
        public HelpOutputDto Help()
        {
            return executeOperationImp.Help();
        }
    }
}
