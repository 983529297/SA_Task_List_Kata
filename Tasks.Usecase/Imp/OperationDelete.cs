using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

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
