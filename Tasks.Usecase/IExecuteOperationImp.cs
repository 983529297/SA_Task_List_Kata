﻿using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Usecase
{
    public interface IExecuteOperationImp
    {
        ShowOutputDto Show(ShowInputDto showDto);
        void Deadline(DeadlineInputDto deadlineDto);
        TodayOutputDto Today();
        void Add(AddInputDto addDto);
        void Delete(DeleteInputDto deleteDto);
        void Check(DoCheckInputDto doCheckDto);
        void Uncheck(DoCheckInputDto doCheckDto);
        HelpOutputDto Help();
        ErrorOutputDto Error(ErrorInputDto errorDto);
    }
}
