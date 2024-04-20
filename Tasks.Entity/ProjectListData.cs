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
        private string projectListID = "1";

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

        public string GetID()
        {
            return projectListID;
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
