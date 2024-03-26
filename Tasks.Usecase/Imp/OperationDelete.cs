using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Usecase
{
    public class OperationDelete : OperationBase
    {
        public void Delete(int id)
        {
            taskListData.DeleteTask(id);
        }
    }
}
