using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.ExecuteOperationImp
{
    public class OperationDeadline : OperationBase, IOperateAndEnd
    {
        private readonly int id;
        private readonly DateTime deadline;

        public OperationDeadline(int id, DateTime deadline)
        {
            this.id = id;
            this.deadline = deadline;
        }

        public void OperateAndEnd()
        {
            Deadline(id, deadline);
        }

        private void Deadline(int id, DateTime deadline)
        {
            taskListData.SetDeadline(id, deadline);
        }
    }
}
