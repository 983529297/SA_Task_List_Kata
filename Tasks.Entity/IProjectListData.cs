using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Data
{
    public interface IProjectListData
    {
        IDictionary<string, IList<TaskListArg>> GetTaskList();

        IDictionary<string, IList<TaskListViewByDeadlineArg>> GetTaskListOrderByDeadline();

        IDictionary<string, IList<TaskListViewByDateArg>> GetTaskListOrderByDate();

        IDictionary<string, IList<TaskListTodayArg>> GetTasksByDate(DateTime deadline);
        void AddProject(string name);

        bool CheckProject(string name);

        void DeleteTask(int id);

        void AddTask(string project, string description);

        void SetDeadline(int id, DateTime deadline);

        void SetDone(int id, bool done);
    }
}
