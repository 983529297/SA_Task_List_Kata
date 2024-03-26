using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ExecuteOperationImp.Output;

namespace Tasks.Controller.UsecasePresenter
{
    public interface IShowPresenter
    {
        IList<string> OutputResult(ShowOutputDto showOutputDto);
    }
}
