using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Usecase.Input
{
    public class DeadlineInputDto : IInputDto
    {
        public int Id { get; set; }

        public DateTime Deadline { get; set; }
    }
}
