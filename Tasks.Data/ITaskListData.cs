using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Data
{
    public interface ITaskListData
    {
        IDictionary<string, IList<Task>> GetTaskList();

        void AddProject(String name);

        bool CheckProject(String name);

        void AddTask(String project, String description);

        void findTaskById(int id, out Task identifiedTask);

        void SetDone(bool done, ref Task task);
    }
}
