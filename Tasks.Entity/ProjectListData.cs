using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks.Entity
{
    public class ProjectListData : IProjectListData
    {
        private readonly IList<Project> projectList = new List<Project>();
        private int Id = 0;
        private static ProjectListData instance = null;

        private ProjectListData() { }

        public static ProjectListData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProjectListData();
                }
                return instance;
            }
        }

        public IDictionary<string, IList<ReadonlyTask>> GetTaskList()
        {
            IDictionary<string, IList<ReadonlyTask>> todayTasks = new Dictionary<string, IList<ReadonlyTask>>();
            foreach (var project in projectList)
            {
                todayTasks[project.GetID()] = project.SelectTasks();
            }
            return todayTasks;
        }

        public IDictionary<string, IList<TaskListViewByDeadlineArg>> GetTaskListOrderByDeadline()
        {
            IDictionary<string, IList<TaskListViewByDeadlineArg>> tasksByDeadline = new Dictionary<string, IList<TaskListViewByDeadlineArg>>();
            foreach (var project in projectList)
            {
                foreach (var task in project.SelectTasks())
                {
                    string deadline = task.GetDeadline() == null ? "None" : task.GetDeadline().Value.ToString("yyyy-MM-dd");
                    if (!tasksByDeadline.ContainsKey(deadline))
                    {
                        tasksByDeadline[deadline] = new List<TaskListViewByDeadlineArg>();
                    }
                    tasksByDeadline[deadline].Add(new TaskListViewByDeadlineArg { Done = task.GetDone(), Id = task.GetID(), Description = task.GetDescription() });
                }
            }
            return tasksByDeadline;
        }

        public IDictionary<string, IList<TaskListViewByDateArg>> GetTaskListOrderByDate()
        {
            IDictionary<string, IList<TaskListViewByDateArg>> tasksByDate = new Dictionary<string, IList<TaskListViewByDateArg>>();
            foreach (var project in projectList)
            {
                foreach (var task in project.SelectTasks())
                {
                    string date = task.GetDate().ToString("yyyy-MM-dd");
                    if (!tasksByDate.ContainsKey(date))
                    {
                        tasksByDate[date] = new List<TaskListViewByDateArg>();
                    }
                    tasksByDate[date].Add(new TaskListViewByDateArg { Done = task.GetDone(), Id = task.GetID(), Description = task.GetDescription() });
                }
            }
            return tasksByDate;
        }

        public IDictionary<string, IList<TaskListTodayArg>> GetTasksByDate(DateTime deadline)
        {
            IDictionary<string, IList<TaskListTodayArg>> todayTasks = new Dictionary<string, IList<TaskListTodayArg>>();
            foreach (var project in projectList)
            {
                foreach (var task in project.SelectTasks())
                {
                    if (task.GetDeadline().HasValue && task.GetDeadline().Value.Date == DateTime.Now.Date)
                    {
                        if (!todayTasks.ContainsKey(project.GetID()))
                        {
                            todayTasks[project.GetID()] = new List<TaskListTodayArg>();
                        }
                        todayTasks[project.GetID()].Add(new TaskListTodayArg { Done = task.GetDone(), Id = task.GetID(), Description = task.GetDescription(), Deadline = task.GetDeadline() });
                    }
                }
            }
            return todayTasks;
        }

        public void DeleteTask(int id)
        {
            foreach (var project in projectList)
            {
                if (project.CheckTask(id))
                {
                    project.DeleteTaskByID(id);
                }
            }
        }

        public void AddProject(string name)
        {
			if (!CheckProject(name))
            {
                projectList.Add(new Project (name));
            }
        }

        public void AddTask(string projectID, string description)
        {
            foreach (var project in projectList)
            {
                if (project.GetID() == projectID)
                {
                    project.AddTask(new Task (NextId(), description, false, DateTime.Now.Date));
                }
            }
        }

        public void SetDeadline(int id, DateTime deadline)
        {
            foreach (var project in projectList)
            {
                if (project.CheckTask(id))
                {
                    project.SetDeadlineByID(id, deadline);
                }
            }
        }

        public void SetDone(int id, bool done)
        {
            foreach (var project in projectList)
            {
                if (project.CheckTask(id))
                {
                    project.SetDoneByID(id, done);
                }
            }
        }

        private bool CheckProject(string name)
        {
            foreach (var project in projectList)
            {
                if (project.GetID() == name)
                    return true;
            }
            return false;
        }

        private int NextId()
        {
            return ++Id;
        }
    }
}
