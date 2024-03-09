using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.OperationImp
{
    public class OperationDelete : OperationBase, IOperateAndEnd
    {
        private readonly string idString;

        public OperationDelete(string idString)
        {
            this.idString = idString;
        }

        public void OperateAndEnd()
        {
            Delete(idString);
        }

        private void Delete(string idString)
        {
            int id = int.Parse(idString);
            taskListData.DeleteTask(id);
        }
    }
}
