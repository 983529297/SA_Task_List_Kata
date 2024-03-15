using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.ExecuteOperationImp
{
    public class OperationDeadline : OperationBase, IOperateAndEnd
    {
        private readonly string idString;
        private readonly string deadlineString;

        public OperationDeadline(string idString, string deadlineString)
        {
            this.idString = idString;
            this.deadlineString = deadlineString;
        }

        public void OperateAndEnd()
        {
            Deadline(idString, deadlineString);
        }

        private void Deadline(string idString, string deadlineString)
        {
            int id = int.Parse(idString);
            DateTime deadline = DateTime.Parse(deadlineString);
            taskListData.SetDeadline(id, deadline);
        }
    }
}
