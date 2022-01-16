using System;
using System.Collections.Generic;

namespace ExtractFunction.Core
{
    public class WorkLoading
    {
        public string Name { get; set; }
        public List<Project> Projects = new List<Project>();
        public DateTime DueDate { get; set; }
    }
}