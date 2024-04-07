using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Entity
{
    public class ReadonlyTask : Task
    {
        public ReadonlyTask(long id, string description, bool done, DateTime date, DateTime? deadline = null) : base(id, description, done, date, deadline) { }

        public override void SetDone(bool done)
        {
            throw new Exception("It is readonly task");
        }

        public override void SetDeadline(DateTime deadline)
        {
            throw new Exception("It is readonly task");
        }
    }
}
