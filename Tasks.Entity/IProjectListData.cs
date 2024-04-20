using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Entity
{
    public interface IProjectListData
    {
        IDictionary<string, IList<ReadonlyTask>> GetTaskList();

        void AddProject(string name);

        void AddTask(string project, string description);

        void SetDone(int id, bool done);

        string GetID();
    }
}
