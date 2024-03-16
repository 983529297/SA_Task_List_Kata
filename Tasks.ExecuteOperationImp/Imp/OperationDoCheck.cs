using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.ExecuteOperationImp
{
    public class OperationDoCheck : OperationBase
    {
        private readonly int id;
        private readonly bool done;

        public OperationDoCheck(int id, bool done)
        {
            this.id = id;
            this.done = done;
        }

        public void OperateAndEnd()
        {
            SetDone(id, done);
        }

        public void SetDone(int id, bool done)
        {
            taskListData.SetDone(id, done);
        }
    }
}
