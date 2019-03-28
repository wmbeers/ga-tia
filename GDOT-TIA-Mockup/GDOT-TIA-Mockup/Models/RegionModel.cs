using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text.RegularExpressions;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeridianSystems.Solutions.Proliance.ServiceActivator.Connection;
using GDOT_TIA.Controllers;

namespace GDOT_TIA.Models
{
    public class Region
    {
        public enum RegionAbbrs
        {
            hoga, rvly, csra, soga
        }

        public Int16 GetMaxValue
        {
            get
            {
                if (this.Abbreviation == RegionAbbrs.hoga) return 300;
                return 600;
            }
        }

        public string GetColor
        {
            get
            {
                string[] colors = new string[] { "#1B69B4", "#bf7436", "#BB598C", "#3E89C9" };
                return colors[(int)this.Abbreviation];
            }
        }

        public RegionAbbrs Abbreviation { get; private set; }

        public String Name
        {
            get
            {
                string[] names = new string[] { "Heart of Georgia Altamaha", "River Valley", "Central Savannah River", "Southern Georgia" };
                return names[(int)this.Abbreviation];
            }
        }

        public List<String> Counties { get; private set; }

        [Required]
        public string url { get; set; }

        public string ApproximateRevenueCollected { get; private set; }
        public string ProjectAccount { get; private set; }
        public int TotalProjects { get; private set; }
        public int TotalFinishedProjects { get; private set; }
        public int TotalConstructionProjects { get; private set; }
        public Double TotalRevenueCollected { get; private set; }
        public Double TotalFundsBudgeted { get; private set; }
        public Double TotalFundsSpent { get; private set; }

        public ProlianceController ProlianceController { get; private set; }

        public Region(RegionAbbrs regionAbbr)
        {
            this.Abbreviation = regionAbbr;

            switch (this.Abbreviation)
            {
                case RegionAbbrs.hoga:
                    this.Counties = new List<string> {
                        "Appling",
                        "Bleckley",
                        "Candler",
                        "Dodge",
                        "Emanuel",
                        "Evans",
                        "Jeff Davis",
                        "Johnson",
                        "Laurens",
                        "Montgomery",
                        "Tattnall",
                        "Telfair",
                        "Toombs",
                        "Treutlen",
                        "Wayne",
                        "Wheeler",
                        "Wilcox"
                    };
                    break;
                case RegionAbbrs.csra:
                    this.Counties = new List<string> {
                        "Burke",
                        "Columbia",
                        "Glascock",
                        "Hancock",
                        "Jefferson",
                        "Jenkins",
                        "Lincoln",
                        "McDuffie",
                        "Richmond",
                        "Taliaferro",
                        "Warren",
                        "Washington",
                        "Wilkes"
                    };
                    break;
                case RegionAbbrs.rvly:
                    this.Counties = new List<string> {
                        "Clay",
                        "Crisp",
                        "Dooly",
                        "Harris",
                        "Macon",
                        "Marion",
                        "Muscogee",
                        "Quitman",
                        "Randolph",
                        "Schley",
                        "Stewart",
                        "Sumter",
                        "Talbot",
                        "Taylor",
                        "Webster"
                    };
                    break;
                case RegionAbbrs.soga:
                    this.Counties = new List<string>
                    {
                        "Atkinson",
                        "Bacon",
                        "Ben Hill",
                        "Berrien",
                        "Brantley",
                        "Brooks",
                        "Charlton",
                        "Clinch",
                        "Cook",
                        "Coffee",
                        "Echols",
                        "Irwin",
                        "Lanier",
                        "Lowndes",
                        "Pierce",
                        "Tift",
                        "Turner",
                        "Ware"
                    };
                    break;
            }

            string prjAccount = "pgmprj://na/tia/" + this.Abbreviation.ToString();
            this.ProlianceController = new ProlianceController(prjAccount);
            ProlianceConnection conn = ProlianceController.GetProlianceConnection();


            DataSet data = ProlianceController.GetPreProjectList(conn, prjAccount);
            if (data.Tables != null && data.Tables.Count > 0)
            {

                string appVal = null;

                DataSet ds = ProlianceController.GetProjectApproxValues(conn, prjAccount);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    appVal = ds.Tables[0].Rows[0]["ProjectDocument_ProjectApproximateValueText"] as string;
                }

                if (!string.IsNullOrEmpty(appVal))
                {
                    appVal = appVal.Replace("$", string.Empty).Replace(",", string.Empty);
                    MatchCollection mc = Regex.Matches(appVal, "\\d+");
                    if (mc.Count > 0)
                    {
                        Double val = 0d;
                        if (Double.TryParse(mc[0].Value, out val))
                            this.TotalRevenueCollected = val;
                    }
                }

                this.ApproximateRevenueCollected = appVal;
                this.TotalProjects = data.Tables[0].Rows.Count;
                this.ProjectAccount = prjAccount;
                this.TotalFinishedProjects = 0;
                this.TotalConstructionProjects = 0;
                this.TotalFundsBudgeted = 0;
                this.TotalFundsSpent = 0;

                Regex noNumbers = new Regex("[^0-9,\\.]");
                // count projects whose status are Complete and Construction
                // and summarize budged amount from SmallProjectDocument_AddressInfoNote 
                // (which contains text, such as "$1,868,002 (Blended Project - Total Budget)" or "$11,585,960 ")
                foreach (DataRow dr in data.Tables[0].Rows)
                {
                    if (dr["SmallProjectDocument_SecuredStatus_FullCode"].ToString().Contains("Complete"))
                    {
                        this.TotalFinishedProjects++;
                    }
                    if (dr["SmallProjectDocument_SecuredStatus_FullCode"].ToString().Contains("Construction"))
                    {
                        this.TotalConstructionProjects++;
                    }
                    String budgeted = dr.IsNull("SmallProjectDocument_AddressInfoNote") ? "" : dr["SmallProjectDocument_AddressInfoNote"].ToString();
                    budgeted = noNumbers.Replace(budgeted, ""); //strip out everything except numbers
                    if (budgeted.Length > 0)
                    {
                        this.TotalFundsBudgeted += Double.Parse(budgeted);
                    }
                    String invoiced = dr.IsNull("SmallProjectDocument_ApproximateValueText") ? "" : dr["SmallProjectDocument_ApproximateValueText"].ToString();
                    invoiced = noNumbers.Replace(invoiced, ""); //strip out everything except numbersif (budgeted.Length > 0)
                    {
                        this.TotalFundsSpent += Double.Parse(invoiced);
                    }
                }
            }
            //TODO: the following is never read--the idea is that we can cache the data for five minutes
            HttpContext.Current.Cache.Add(prjAccount + "cacheKey", this, null, DateTime.Now.AddMinutes(5), System.Web.Caching.Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Default, null);
        }

        public List<Project> GetProjects(string bandString, string countyString, Int32? statusString, Int32? typeString)
		{
            List<Project> projects = new List<Project>();
            
            string filterExp = string.Empty;
			if (!string.IsNullOrEmpty(countyString))
				if (!string.IsNullOrEmpty(filterExp))
					filterExp = filterExp + "and SmallProjectDocument_OfficeUnit_FullCode = '" + countyString + "'";
				else
					filterExp = filterExp + "SmallProjectDocument_OfficeUnit_FullCode = '" + countyString + "'";
			if (!string.IsNullOrEmpty(bandString))
				if (!string.IsNullOrEmpty(filterExp))
					filterExp = filterExp + "and SmallProjectDocument_ServiceType_FullCode = '" + bandString + "'";
				else
					filterExp = filterExp + "SmallProjectDocument_ServiceType_FullCode = '" + bandString + "'";
            //TODO: translate filters of project types and statuses
            if (typeString.HasValue)
            {
                //translate typeString, which is just the ID of the filter item, and get the code
                FilterItem filterItem = FilterItem.GetProjectTypes.FirstOrDefault(pt => pt.Id == typeString.Value);
                string types = String.Join("','", filterItem.Codes);
                if (!string.IsNullOrEmpty(filterExp))
                {
                    filterExp = filterExp + "and SmallProjectDocument_MarketSector_FullCode in ('" + types + "')";
                }
                else
                {
                    filterExp = filterExp + "SmallProjectDocument_MarketSector_FullCode in ('" + types + "')";
                }
            }
            if (statusString.HasValue)
            {
                FilterItem filterItem = FilterItem.GetStatuses.FirstOrDefault(pt => pt.Id == statusString.Value);
                string statuses = String.Join("','", filterItem.Codes); 
                if (!string.IsNullOrEmpty(filterExp))
                {
                    filterExp = filterExp + "and SmallProjectDocument_SecuredStatus_FullCode in ('" + statuses + "')";
                }
                else
                {
                    filterExp = filterExp + "SmallProjectDocument_SecuredStatus_FullCode in ('" + statuses + "')";
                }
            }
			DataSet theData = this.ProlianceController.GetPreProjectList();

			var dv = theData.Tables[0].DefaultView;
			
            dv.RowFilter = filterExp;
			var FilteredView = new DataSet();
			var newDT = dv.ToTable();
			FilteredView.Tables.Add(newDT);

            if (FilteredView != null && FilteredView.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow r in FilteredView.Tables[0].Rows)
				{
					Project p = new Project(r);
                    p.regionalCommission = this.Name;

					projects.Add(p);
				}
			}
            return projects;
        }
    }
}