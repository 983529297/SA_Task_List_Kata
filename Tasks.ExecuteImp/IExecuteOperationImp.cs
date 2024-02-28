using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.ExecuteImp
{
    public interface IExecuteOperationImp
    {
        IList<string> Show();
        void Deadline(string commandRest);
        void Today();
        void Add(string commandRest);
        void Check(string commandRest);
        void Uncheck(string commandRest);
        IList<string> Help();
        IList<string> Error(string command);
    }
}
