using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks.Data
{
    public class TaskListData : ITaskListData
    {
        private readonly IDictionary<string, IList<Task>> tasks = new Dictionary<string, IList<Task>>();
        private int Id = 0;

        public IDictionary<string, IList<Task>> GetTaskList()
        {
            return tasks;
        }

        public void AddProject(String name)
        {
            tasks[name] = new List<Task>();
        }

        public bool CheckProject(String name)
        {
            if (tasks.ContainsKey(name))
                return true;
            else
                return false;
        }

        public void AddTask(String project, String description)
        {
            if (tasks.TryGetValue(project, out IList<Task> projectTasks))
            {
                projectTasks.Add(new Task { Id = NextId(), Description = description, Done = false });
            }
        }

        public void findTaskById(int id, out Task identifiedTask)
        {
            identifiedTask = tasks.Select(project => project.Value.FirstOrDefault(task => task.Id == id))
                .Where(task => task != null)
                .FirstOrDefault();
        }

        public void SetDone(bool done, ref Task task)
        {
            task.Done = done;
        }

        private int NextId()
        {
            return ++Id;
        }
    }
}
