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

        public IDictionary<string, IList<TaskListArg>> GetTaskList()
        {
            IDictionary<string, IList<TaskListArg>> todayTasks = new Dictionary<string, IList<TaskListArg>>();
            foreach (var project in tasks)
            {
                foreach (var task in project.Value)
                {
                    if (!todayTasks.ContainsKey(project.Key))
                    {
                        todayTasks[project.Key] = new List<TaskListArg>();
                    }
                    todayTasks[project.Key].Add(new TaskListArg { Done = task.Done ? "x" : " ", Id = task.Id.ToString(), Description = task.Description, deadline = task.deadline.HasValue ? task.deadline.Value.ToString("yyyy-MM-dd") : "" });
                }
            }
            return todayTasks;
        }

        public IDictionary<string, IList<TaskListViewByDeadlineArg>> GetTaskListOrderByDeadline()
        {
            IDictionary<string, IList<TaskListViewByDeadlineArg>> tasksByDeadline = new Dictionary<string, IList<TaskListViewByDeadlineArg>>();
            foreach (var project in tasks)
            {
                foreach (var task in project.Value)
                {
                    string deadline = task.deadline == null ? "None" : task.deadline.Value.ToString("yyyy-MM-dd");
                    if (!tasksByDeadline.ContainsKey(deadline))
                    {
                        tasksByDeadline[deadline] = new List<TaskListViewByDeadlineArg>();
                    }
                    tasksByDeadline[deadline].Add(new TaskListViewByDeadlineArg { Done = task.Done ? "x" : " ", Id = task.Id.ToString(), Description = task.Description });
                }
            }
            return tasksByDeadline;
        }

        public IDictionary<string, IList<TaskListViewByDateArg>> GetTaskListOrderByDate()
        {
            IDictionary<string, IList<TaskListViewByDateArg>> tasksByDate = new Dictionary<string, IList<TaskListViewByDateArg>>();
            foreach (var project in tasks)
            {
                foreach (var task in project.Value)
                {
                    string date = task.date.ToString("yyyy-MM-dd");
                    if (!tasksByDate.ContainsKey(date))
                    {
                        tasksByDate[date] = new List<TaskListViewByDateArg>();
                    }
                    tasksByDate[date].Add(new TaskListViewByDateArg { Done = task.Done ? "x" : " ", Id = task.Id.ToString(), Description = task.Description });
                }
            }
            return tasksByDate;
        }

        public IDictionary<string, IList<IList<string>>> GetTasksByDate(DateTime deadline)
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
                        todayTasks[project.Key].Add(new List<string> { task.Done ? "x" : " ", task.Id.ToString(), task.Description, task.deadline.Value.ToString("yyyy-MM-dd") });
                    }
                }
            }
            return todayTasks;
        }

        public void DeleteTask(int id)
        {
            findTaskById(id, out Task task);
            foreach (var taskList in tasks)
            {
                if (taskList.Value.Contains(task))
                {
                    taskList.Value.Remove(task);
                }
            }
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
                projectTasks.Add(new Task { Id = NextId(), Description = description, Done = false, date = DateTime.Now.Date });
            }
        }

        private void findTaskById(int id, out Task identifiedTask)
        {
            identifiedTask = tasks.Select(project => project.Value.FirstOrDefault(task => task.Id == id))
                .Where(task => task != null)
                .FirstOrDefault();
            if (identifiedTask == null)
            {
                throw new Exception(string.Format("Could not find a task with an ID of {0}.", id));
            }
        }
        public void SetDeadline(int id, DateTime deadline)
        {
            findTaskById(id, out Task task);
            task.deadline = deadline;
        }

        public void SetDone(int id, bool done)
        {
            findTaskById(id, out Task task);
            task.Done = done;
        }

        private int NextId()
        {
            return ++Id;
        }
    }
}
