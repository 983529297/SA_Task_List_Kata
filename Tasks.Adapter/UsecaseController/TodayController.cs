using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Output;
using Tasks.Usecase;

namespace Tasks.Controller.UsecaseController
{
    public class TodayController : UsecaseControllerBase
    {
        public TodayOutputDto Today()
        {
            return new OperationToday().ExecuteOperation();
            //return executeOperationImp.Today();
        }
    }
}
