using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Controller.UsecaseController
{
    public interface IUsecaseController
    {
        IList<string> Execute(string commandParameter);
    }
}
