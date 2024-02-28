using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Data
{
    public interface ITaskListData
    {
        IDictionary<string, IList<IList<string>>> GetTaskList();

        IDictionary<string, IList<IList<string>>> GetTasksByDate(DateTime deadline);
        void AddProject(string name);

        bool CheckProject(string name);

        void AddTask(string project, string description);

        void findTaskById(int id, out Task identifiedTask);

        void SetDeadline(DateTime deadline, ref Task identifiedTask);

        void SetDone(bool done, ref Task task);
    }
}
