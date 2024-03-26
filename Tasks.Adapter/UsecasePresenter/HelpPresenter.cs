using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Output;

namespace Tasks.Controller.UsecasePresenter
{
    public class HelpPresenter
    {
        public IList<string> OutputResult(HelpOutputDto helpOutputDto)
        {
            return helpOutputDto.ListOfCommand;
        }
    }
}
