using MeridianSystems.Solutions.Proliance.ServiceActivator.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TiaWeb2._0.Controller;
using TiaWeb2._0.Model;

namespace TiaWeb2._0
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var b = Request.QueryString["id"];
            if (b != null)
                ((TIA)(this.Master)).accordion_selectedIndexChanged(System.Convert.ToInt16(b));

            int revenue = 0;
            int projects = 0;

            ProlianceController prj = new ProlianceController();
            ProlianceConnection conn = new ProlianceConnection("https://na2.agpmis.com", "na", "admin", "?aecom");

            RegionTotals tot = GetData("pgmprj://na/tia/rvly", prj, conn);
            revenue += tot.TotalRevenueCollected;
            projects += tot.TotalProjects;

            tot = GetData("pgmprj://na/tia/csra", prj, conn);
            revenue += tot.TotalRevenueCollected;
            projects += tot.TotalProjects;

            tot = GetData("pgmprj://na/tia/hoga", prj, conn);
            revenue += tot.TotalRevenueCollected;
            projects += tot.TotalProjects;

            totProjects.Text = projects.ToString();
            totRevenue.Text = revenue.ToString("C0");
        }

        #region Private Methods
        private RegionTotals GetData(string prjAccount, ProlianceController prj, ProlianceConnection conn)
        {
            RegionTotals rtrn = null;

            rtrn = HttpContext.Current.Cache.Get(prjAccount + "cacheKey") as RegionTotals;
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
                            int val = int.MinValue;
                            if (int.TryParse(mc[0].Value, out val))
                                rtrn.TotalRevenueCollected = val;
                        }
                    }

                    rtrn.ApproximateRevenueCollected = appVal;
                    rtrn.TotalProjects = data.Tables[0].Rows.Count;
                    rtrn.ProjectAccount = prjAccount;
                }

                HttpContext.Current.Cache.Add(prjAccount + "cacheKey", rtrn, null, DateTime.Now.AddMinutes(5), System.Web.Caching.Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Default, null);
            }

            return rtrn;
        }
        #endregion End Private Methods
    }
}