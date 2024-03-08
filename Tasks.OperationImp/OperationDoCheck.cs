using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.OperationImp
{
    public class OperationDoCheck : OperationBase, IOperationDoCheck
    {
        public void SetDone(string idString, bool done)
        {
            int id = int.Parse(idString);
            taskListData.SetDone(id, done);
        }
    }
}
