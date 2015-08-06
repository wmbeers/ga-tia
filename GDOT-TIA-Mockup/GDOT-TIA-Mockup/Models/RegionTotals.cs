using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GDOT_TIA.Models
{
    public class RegionTotals
    {
        #region Properties
        public string ApproximateRevenueCollected { get; set; }
        public string ProjectAccount { get; set; }
        public int TotalProjects { get; set; }
        public int TotalRevenueCollected { get; set; }
        #endregion End Properties
    }
}