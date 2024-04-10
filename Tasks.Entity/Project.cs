using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Tasks.Entity
{
    public class Project
    {
        private readonly string ID;

        private readonly IList<Task> TaskList;

        public Project(string id)
        {
            ID = id;
            TaskList = new List<Task>();
        }

        public string GetID()
        {
            return ID;
        }

        public IList<ReadonlyTask> SelectTasks()
        {
            return TaskList.Select(task => new ReadonlyTask(task.GetID(), task.GetDescription(), task.GetDone(), task.GetDate(), task.GetDeadline())).ToList();
        }

        public void DeleteTaskByID(int id)
        {   
            TaskList.Remove(TaskList.Where(task => task.GetID() == id).FirstOrDefault());
        }

        public void SetDeadlineByID(int id, DateTime deadline)
        {
            TaskList.Where(task => task.GetID() == id).FirstOrDefault().SetDeadline(deadline);
        }

        public void SetDoneByID(int id, bool done)
        {
            TaskList.Where(task => task.GetID() == id).FirstOrDefault().SetDone(done);
        }

        public void AddTask(Task task)
        {
            TaskList.Add(task);
        }

        public bool CheckTask(int id)
        {
            foreach (var task in TaskList)
            {
                if (task.GetID() == id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
