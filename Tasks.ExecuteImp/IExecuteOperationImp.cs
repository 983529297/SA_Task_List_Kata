using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.ExecuteImp
{
    public interface IExecuteOperationImp
    {
        void Show();
        void Deadline(string commandRest);
        void Today();
        void Add(string commandRest);
        void Check(string commandRest);
        void Uncheck(string commandRest);
        void Help();
        string Error(string command);
    }
}
