using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.ExecuteImp
{
    public interface IExecuteOperationImp
    {
        void Show();
        void Deadline(string commandRest);
        void Add(string commandRest);
        void Check(string commandRest);
        void Uncheck(string commandRest);
        void Help();
        void Error(string command);
    }
}
