﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Core.Model
{
    public class Assignment
    {
        public int Id { get; set; }
        public int TaskStatus { get; set; }
        public string TaskName { get; set; }
        public DateTime LastModified { get; set; }
    }
}
