using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Output;

namespace Tasks.Controller.UsecaseController
{
    public class TodayController : UsecaseControllerBase
    {
        public TodayOutputDto Today()
        {
            return executeOperationImp.Today();
        }
    }
}
