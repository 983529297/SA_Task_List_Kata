using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.ExecuteOperationImp
{
    public class OperationDelete : OperationBase, IOperateAndEnd
    {
        private readonly int id;

        public OperationDelete(int id)
        {
            this.id = id;
        }

        public void OperateAndEnd()
        {
            Delete(id);
        }

        private void Delete(int id)
        {
            taskListData.DeleteTask(id);
        }
    }
}
