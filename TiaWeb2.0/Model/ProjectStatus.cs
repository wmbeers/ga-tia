using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiaWeb2._0.Model
{
    public class ProjectStatus
    {
        public string FullCode { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int level { get; set; }
        public string Display { get; set; }
        public int SortValue { get; set; }
    }
}