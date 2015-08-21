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
		public int TotalFinishedProjects { get; set; }
		public int TotalConstructionProjects { get; set; }
        public Double TotalRevenueCollected { get; set; }
		public Double TotalFundsBudgeted { get; set; }
		public Double TotalFundsSpent { get; set; }
        #endregion End Properties
    }
}