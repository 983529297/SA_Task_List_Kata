﻿using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.ExecuteOperationImp
{
    public class OperationDelete : OperationBase
    {
        public void Delete(int id)
        {
            taskListData.DeleteTask(id);
        }
    }
}
