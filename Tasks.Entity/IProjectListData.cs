using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Entity
{
    public interface IProjectListData
    {
        IDictionary<string, IList<ReadonlyTask>> GetTaskList();

        IDictionary<string, IList<ReadonlyTask>> GetTaskListOrderByDeadline();

        IDictionary<string, IList<ReadonlyTask>> GetTaskListOrderByDate();

        IDictionary<string, IList<ReadonlyTask>> GetTasksByDate(DateTime deadline);

        void AddProject(string name);

        void DeleteTask(int id);

        void AddTask(string project, string description);

        void SetDeadline(int id, DateTime deadline);

        void SetDone(int id, bool done);
    }
}
