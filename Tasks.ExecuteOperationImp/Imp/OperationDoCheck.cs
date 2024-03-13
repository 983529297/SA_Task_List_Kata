using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.ExecuteOperationImp
{
    public class OperationDoCheck : OperationBase, IOperateAndEnd
    {
        private readonly string idString;
        private readonly bool done;

        public OperationDoCheck(string idString, bool done)
        {
            this.idString = idString;
            this.done = done;
        }

        public void OperateAndEnd()
        {
            SetDone(idString, done);
        }

        public void SetDone(string idString, bool done)
        {
            int id = int.Parse(idString);
            taskListData.SetDone(id, done);
        }
    }
}
