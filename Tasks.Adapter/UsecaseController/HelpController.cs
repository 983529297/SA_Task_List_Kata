using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Output;
using Tasks.Usecase;

namespace Tasks.Controller.UsecaseController
{
    public class HelpController : UsecaseControllerBase
    {
        public HelpOutputDto Help()
        {
            return new OperationHelp().ExecuteOperation();
            //return executeOperationImp.Help();
        }
    }
}
