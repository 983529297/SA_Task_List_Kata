using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.ExecuteImp
{
    public interface IExecuteOperationImp
    {
        void Show();
        void Add(String commandRest);
        void Check(String commandRest);
        void Uncheck(String commandRest);
        void Help();
        void Error(String command);
    }
}
