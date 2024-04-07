using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks.Entity
{
    public class ProjectListData : IProjectListData
    {
        private readonly IList<Project> projectList = new List<Project>();
        private int Id = 0;
        private static readonly object lockObject = new object();
        private static ProjectListData instance = null;

        private ProjectListData() { }

        public static ProjectListData Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new ProjectListData();

                        }
                    }
                }
                return instance;
            }
        }

        public IDictionary<string, IList<TaskListArg>> GetTaskList()
        {
            IDictionary<string, IList<TaskListArg>> todayTasks = new Dictionary<string, IList<TaskListArg>>();
            foreach (var project in projectList)
            {
                foreach (var task in project.TaskList)
                {
                    if (!todayTasks.ContainsKey(project.ID))
                    {
                        todayTasks[project.ID] = new List<TaskListArg>();
                    }
                    todayTasks[project.ID].Add(new TaskListArg { Done = task.Done ? "x" : " ", Id = task.ID.ToString(), Description = task.Description, deadline = task.Deadline.HasValue ? task.Deadline.Value.ToString("yyyy-MM-dd") : "" });
                }
            }
            return todayTasks;
        }

        public IDictionary<string, IList<TaskListViewByDeadlineArg>> GetTaskListOrderByDeadline()
        {
            IDictionary<string, IList<TaskListViewByDeadlineArg>> tasksByDeadline = new Dictionary<string, IList<TaskListViewByDeadlineArg>>();
            foreach (var project in projectList)
            {
                foreach (var task in project.TaskList)
                {
                    string deadline = task.Deadline == null ? "None" : task.Deadline.Value.ToString("yyyy-MM-dd");
                    if (!tasksByDeadline.ContainsKey(deadline))
                    {
                        tasksByDeadline[deadline] = new List<TaskListViewByDeadlineArg>();
                    }
                    tasksByDeadline[deadline].Add(new TaskListViewByDeadlineArg { Done = task.Done ? "x" : " ", Id = task.ID.ToString(), Description = task.Description });
                }
            }
            return tasksByDeadline;
        }

        public IDictionary<string, IList<TaskListViewByDateArg>> GetTaskListOrderByDate()
        {
            IDictionary<string, IList<TaskListViewByDateArg>> tasksByDate = new Dictionary<string, IList<TaskListViewByDateArg>>();
            foreach (var project in projectList)
            {
                foreach (var task in project.TaskList)
                {
                    string date = task.Date.ToString("yyyy-MM-dd");
                    if (!tasksByDate.ContainsKey(date))
                    {
                        tasksByDate[date] = new List<TaskListViewByDateArg>();
                    }
                    tasksByDate[date].Add(new TaskListViewByDateArg { Done = task.Done ? "x" : " ", Id = task.ID.ToString(), Description = task.Description });
                }
            }
            return tasksByDate;
        }

        public IDictionary<string, IList<TaskListTodayArg>> GetTasksByDate(DateTime deadline)
        {
            IDictionary<string, IList<TaskListTodayArg>> todayTasks = new Dictionary<string, IList<TaskListTodayArg>>();
            foreach (var project in projectList)
            {
                foreach (var task in project.TaskList)
                {
                    if (task.Deadline.HasValue && task.Deadline.Value.Date == DateTime.Now.Date)
                    {
                        if (!todayTasks.ContainsKey(project.ID))
                        {
                            todayTasks[project.ID] = new List<TaskListTodayArg>();
                        }
                        todayTasks[project.ID].Add(new TaskListTodayArg { Done = task.Done ? "x" : " ", Id = task.ID.ToString(), Description = task.Description, Deadline = task.Deadline.Value.ToString("yyyy-MM-dd") });
                    }
                }
            }
            return todayTasks;
        }

        public void DeleteTask(int id)
        {
            FindTaskById(id, out Task task);
            foreach (var project in projectList)
            {
                if (project.TaskList.Contains(task))
                {
                    project.DeleteTask(task);
                }
            }
        }

        public void AddProject(string name)
        {
			if (!CheckProject(name))
            {
                projectList.Add(new Project { ID = name, TaskList = new List<Task>() });
            }
        }

        public void AddTask(string projectID, string description)
        {
            foreach (var project in projectList)
            {
                if (project.ID == projectID)
                {
                    project.AddTask(new Task { ID = NextId(), Description = description, Done = false, Date = DateTime.Now.Date });
                }
            }
        }

        public void SetDeadline(int id, DateTime deadline)
        {
            FindTaskById(id, out Task task);
            task.Deadline = deadline;
        }

        public void SetDone(int id, bool done)
        {
            FindTaskById(id, out Task task);
            task.Done = done;
        }

        private bool CheckProject(string name)
        {
            foreach (var project in projectList)
            {
                if (project.ID == name)
                    return true;
            }
            return false;
        }

        private void FindTaskById(int id, out Task identifiedTask)
        {
            foreach (var project in projectList)
            {
                identifiedTask = project.FindTaskById(id);
                if (identifiedTask != null)
                {
                    return;
                }
            }
            throw new Exception(string.Format("Could not find a task with an ID of {0}.", id));
        }

        private int NextId()
        {
            return ++Id;
        }
    }
}
