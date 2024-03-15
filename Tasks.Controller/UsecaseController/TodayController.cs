using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Controller.UsecaseController
{
    public class TodayController : UsecaseControllerBase
    {
        public IList<string> Today()
        {
            return executeOperationImp.Today();
        }
    }
}
