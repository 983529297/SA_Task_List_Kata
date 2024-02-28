using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks.Data
{
    public class TaskListData : ITaskListData
    {
        private readonly IDictionary<string, IList<Task>> tasks = new Dictionary<string, IList<Task>>();
        private int Id = 0;
        private static readonly object lockObject = new object();
        private static TaskListData instance = null;

        private TaskListData() { }

        public static TaskListData Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new TaskListData();

                        }
                    }
                }
                return instance;
            }
        }

        public IDictionary<string, IList<Task>> GetTaskList()
        {
            return tasks;
        }

        public IDictionary<string, IList<IList<string>>> GetTaskByDate(DateTime deadline)
        {
            IDictionary<string, IList<IList<string>>> todayTasks = new Dictionary<string, IList<IList<string>>>();
            foreach (var project in tasks)
            {
                foreach (var task in project.Value)
                {
                    if (task.deadline.HasValue && task.deadline.Value.Date == DateTime.Now.Date)
                    {
                        if (!todayTasks.ContainsKey(project.Key))
                        {
                            todayTasks[project.Key] = new List<IList<string>>();
                        }
                        todayTasks[project.Key].Add(new List<string> { task.Done ? "X" : " ", task.Id.ToString(), task.Description, task.deadline.Value.ToString("yyyy-MM-dd") });
                    }
                }
            }
            return todayTasks;
        }

        public void AddProject(string name)
        {
            tasks[name] = new List<Task>();
        }

        public bool CheckProject(string name)
        {
            if (tasks.ContainsKey(name))
                return true;
            else
                return false;
        }

        public void AddTask(string project, string description)
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
        public void SetDeadline(DateTime deadline, ref Task task)
        {
            task.deadline = deadline;
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
