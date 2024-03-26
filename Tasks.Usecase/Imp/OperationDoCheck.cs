using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.Usecase
{
    public class OperationDoCheck : OperationBase
    {
        public void SetDone(int id, bool done)
        {
            taskListData.SetDone(id, done);
        }
    }
}
