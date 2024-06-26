﻿using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Output;

namespace Tasks.Adapter.UsecasePresenter
{
    public class ErrorPresenter
    {
        public IList<string> OutputResult(ErrorOutputDto errorOutputDto)
        {
            return new List<string> { string.Format("I don't know what the command \"{0}\" is.", errorOutputDto.ErrorCommand) };
        }
    }
}
