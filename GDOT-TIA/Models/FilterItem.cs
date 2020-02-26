using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GDOT_TIA.Models
{
    /// <summary>
    /// Represents Project Types and Project Statuses grouped together into a more user-friendly structure
    /// </summary>
    public class FilterItem
    {
        public string Display { get; set; }
        public int Id { get; set; }
        public List<string> Codes { get; set; }

        protected FilterItem(int id, string display, List<string> codes)
        {
            this.Id = id;
            this.Display = display;
            this.Codes = codes;
        }

        public static List<FilterItem> GetProjectTypes
        {
            get
            {
                List<FilterItem> items = new List<FilterItem>();
                items.Add(new FilterItem(1, "Bike and Pedestrian Projects",
                    new List<string> {
	                    "01 :  Bike-Ped Fac", 
	                    "11 :  Multi-use Trl", 
	                    "22 :  Sidewalks"}));
                items.Add(new FilterItem(2, "Bridge Projects",
                    new List<string> {
	                    "02 :  Bridge"}));
                items.Add(new FilterItem(3, "Resurfacing and Maintenance Projects",
                    new List<string> {
	                    "03 :  Resurfacing",
	                    "03a : GrdDrnBasPv",
	                    "03b : Surface Treat",
	                    "03c : Grade Adj",
	                    "19 :  Minor Widen",
	                    "20 :  Pvmt Marking"}));
                items.Add(new FilterItem(4, "Roadway Improvement Projects",
                    new List<string> {
	                    "04 :  Signals",
	                    "06 :  Widening",
	                    "07 :  Roadway",
	                    "08 :  Passing Lanes",
	                    "09 :  Realignment",
	                    "10 :  Interchange",
	                    "12 :  Turn Lanes",
	                    "13 :  Frontage Roads",
	                    "14 :  Acc/Dec Lns",
	                    "16 :  Barriers",
	                    "17 :  Intsct Imp",
	                    "18 :  Median",
	                    "21 :  Railroad Xing"}));
                items.Add(new FilterItem(5, "Airport Projects",
                    new List<string> {
                        "15 :  Airport"}));
                items.Add(new FilterItem(6, "Transit Projects",
                    new List<string> {
	                    "05 :  Transit"}));
                return items;
            }
        }

        public static List<FilterItem> GetStatuses
        {
            get
            {
                List<FilterItem> items = new List<FilterItem>();
                items.Add(new FilterItem(1, "Planning and Design",
                    new List<string> {
                        "01 Planning",
                        "02 Procure Design",
                        "03 Design"}));

                items.Add(new FilterItem(2, "Bidding",
                    new List<string> {
                        "04 Bidding"}));

                items.Add(new FilterItem(3, "Construction",
                    new List<string> {
                        "05 Construction"}));

                items.Add(new FilterItem(4, "Operations",
                    new List<string> {
                        "06 Operations"}));


                items.Add(new FilterItem(5, "Complete",
                    new List<string> {
                        "07 Complete",
                        "08 Finance Closed"}));

                items.Add(new FilterItem(6, "Inactive",
                    new List<string> {
                        "00 Inactive"}));

                return items;
            }
        }

    }
}