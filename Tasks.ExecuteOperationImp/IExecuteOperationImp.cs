using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.ExecuteOperationImp
{
    public interface IExecuteOperationImp
    {
        IList<string> Show(string commandRest = "by project");
        void Deadline(string commandRest);
        IList<string> Today();
        void Add(string commandRest);
        void Delete(string commandRest);
        void Check(string commandRest);
        void Uncheck(string commandRest);
        IList<string> Help();
        IList<string> Error(string command);
    }
}
