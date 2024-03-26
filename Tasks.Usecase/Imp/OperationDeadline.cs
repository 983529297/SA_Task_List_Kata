﻿using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.Usecase
{
    public class OperationDeadline : OperationBase
    {
        public void Deadline(int id, DateTime deadline)
        {
            taskListData.SetDeadline(id, deadline);
        }
    }
}
