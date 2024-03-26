using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Output;

namespace Tasks.Controller.UsecasePresenter
{
    public interface IShowPresenter
    {
        IList<string> OutputResult(ShowOutputDto showOutputDto);
    }
}
