using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Entity
{
    public class Project
    {
        internal string ID { get; set; }

        internal IList<Task> TaskList { get; set; }

        public void DeleteTask(Task task)
        {
            TaskList.Remove(task);
        }

        public void AddTask(Task task)
        {
            TaskList.Add(task);
        }

        public Task FindTaskById(int id)
        {
            foreach (var task in TaskList)
            {
                if (task.ID == id)
                {
                    return task;
                }
            }
            return null;
        }
    }
}
