﻿using System;
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
		public const string RVId = "pgmprj://na/tia/rvly";
		public const string CSRAId = "pgmprj://na/tia/csra";
		public const string HOGAId = "pgmprj://na/tia/hoga";

		[Required]
		public string url { get; set; }

		public RegionTotals totals;

		public Region(string s)
		{
			ProlianceController prj = new ProlianceController(s);
			ProlianceConnection conn = new ProlianceConnection("https://na2.agpmis.com", "na", "admin", "?aecom");

			totals = GetData(s, prj, conn);
		}

		#region Private Methods
		private RegionTotals GetData(string prjAccount, ProlianceController prj, ProlianceConnection conn)
		{
			RegionTotals rtrn = null;

			//rtrn = HttpContext.Current.Cache.Get(prjAccount + "cacheKey") as RegionTotals;
			if (rtrn == null)
			{
				rtrn = new RegionTotals();
				DataSet data = prj.GetPreProjectList(conn, prjAccount);
				if (data.Tables != null && data.Tables.Count > 0)
				{
					//rtrn.TotalRevenueCollected = 0;
					//int val = int.MinValue;
					//foreach (DataRow row in data.Tables[0].Rows)
					//{
					//    string textVal = row["SmallProjectDocument_ApproximateValueText"] as string;
					//    if (!string.IsNullOrEmpty(textVal))
					//    {
					//        textVal = textVal.Replace("$", string.Empty).Replace(",", string.Empty);
					//        MatchCollection mc = Regex.Matches(textVal, "\\d+");
					//        if (mc.Count > 0)
					//        {
					//            if (int.TryParse(mc[0].Value, out val))
					//                rtrn.TotalRevenueCollected += val;
					//        }
					//    }
					//}

					string appVal = null;

					DataSet ds = prj.GetProjectApproxValues(conn, prjAccount);
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
								rtrn.TotalRevenueCollected = val;
						}
					}

					rtrn.ApproximateRevenueCollected = appVal;
					rtrn.TotalProjects = data.Tables[0].Rows.Count;
					rtrn.ProjectAccount = prjAccount;
					rtrn.TotalFinishedProjects = 0;
					rtrn.TotalConstructionProjects = 0;
                    rtrn.TotalFundsBudgeted = 0;
					rtrn.TotalFundsSpent = 0;

                    Regex noNumbers = new Regex("[^0-9]");
					// count projects whose status are Complete and Construction
                    // and summarize budged amount from SmallProjectDocument_AddressInfoNote 
                    // (which contains text, such as "$1,868,002 (Blended Project - Total Budget)" or "$11,585,960 ")
					foreach (DataRow dr in data.Tables[0].Rows)
					{
						if (dr["SmallProjectDocument_SecuredStatus_FullCode"].ToString().Contains("Complete")) rtrn.TotalFinishedProjects++;
						if (dr["SmallProjectDocument_SecuredStatus_FullCode"].ToString().Contains("Construction")) rtrn.TotalConstructionProjects++;
                        String budgeted = dr.IsNull("SmallProjectDocument_AddressInfoNote") ? "" : dr["SmallProjectDocument_AddressInfoNote"].ToString();
                        budgeted = noNumbers.Replace(budgeted,""); //strip out everything except numbers
                        if (budgeted.Length > 0)
                        {
                            rtrn.TotalFundsBudgeted += Double.Parse(budgeted);
                        }
						String invoiced = dr.IsNull("SmallProjectDocument_ApproximateValueText") ? "" : dr["SmallProjectDocument_ApproximateValueText"].ToString();
						invoiced = noNumbers.Replace(invoiced, ""); //strip out everything except numbersif (budgeted.Length > 0)
						{
							rtrn.TotalFundsSpent += Double.Parse(invoiced);
						}
                    }
				}

				HttpContext.Current.Cache.Add(prjAccount + "cacheKey", rtrn, null, DateTime.Now.AddMinutes(5), System.Web.Caching.Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Default, null);
			}

			return rtrn;
		}
		#endregion End Private Methods
	}
}