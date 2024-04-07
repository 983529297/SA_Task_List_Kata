using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Entity
{
    public class Task
    {
        protected long ID;
        protected string Description;
        protected bool Done;
        protected DateTime Date;
        protected DateTime? Deadline;

        public Task(long id, string description, bool done, DateTime date, DateTime? deadline = null)
        {
            ID = id;
            Description = description;
            Done = done;
            Date = date;
            Deadline = deadline;
        }

        public long GetID()
        {
            return ID;
        }

        public string GetDescription()
        {
            return Description;
        }

        public bool GetDone()
        {
            return Done;
        }

        public virtual void SetDone(bool done)
        {
            Done = done;
        }

        public DateTime GetDate()
        {
            return Date;
        }

        public DateTime? GetDeadline()
        {
            return Deadline;
        }

        public virtual void SetDeadline(DateTime deadline)
        {
            Deadline = deadline;
        }
    }
}
