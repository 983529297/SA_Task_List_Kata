﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Data
{
    public class Task
    {
        public long Id { get; set; }

        public string Description { get; set; }

        public bool Done { get; set; }

        public DateTime date { get; set; }

        public DateTime? deadline { get; set; }
    }
}
