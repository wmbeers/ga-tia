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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var b = Request.QueryString["id"];
            if (b != null)
                ((TIA)(this.Master)).accordion_selectedIndexChanged(System.Convert.ToInt16(b));

            ProlianceController prj = new ProlianceController();
            ProlianceConnection conn = new ProlianceConnection("https://na2.agpmis.com", "na", "admin", "?aecom");

            //DataSet ds = prj.GetProjectApproxValues(conn, "pgmprj://na/tia/rvly");
            //foreach (DataTable dt in ds.Tables)
            //{
            //    int count = dt.Rows.Count;
            //}

            ProcessProject("pgmprj://na/tia/rvly", prj, conn, rvRevenue, rvProjects);
            ProcessProject("pgmprj://na/tia/csra", prj, conn, csRevenue, csProjects);
            ProcessProject("pgmprj://na/tia/hoga", prj, conn, hgRevenue, hgProjects);
        }

        #region Private Methods
        private void ProcessProject(string prjAccount, ProlianceController prj, ProlianceConnection conn, Literal revenue, Literal projects)
        {
            string appVal = null;

            DataSet ds = prj.GetProjectApproxValues(conn, prjAccount);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                appVal = ds.Tables[0].Rows[0]["ProjectDocument_ProjectApproximateValueText"] as string;
            }

            FillData(prjAccount, prj, conn, revenue, projects, appVal);
        }

        private void FillData(string prjAccount, ProlianceController prj, ProlianceConnection conn, Literal revenue, Literal projects, string appVal)
        {
            RegionTotals tot = null;

            tot = HttpContext.Current.Cache.Get(prjAccount + "cacheKey") as RegionTotals;
            if (tot == null)
            {
                tot = new RegionTotals();
                DataSet data = prj.GetPreProjectList(conn, prjAccount);
                if (data.Tables != null && data.Tables.Count > 0)
                {
                    //tot.TotalRevenueCollected = 0;
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
                    //                tot.TotalRevenueCollected += val;
                    //        }
                    //    }
                    //}

                    if (!string.IsNullOrEmpty(appVal))
                    {
                        appVal = appVal.Replace("$", string.Empty).Replace(",", string.Empty);
                        MatchCollection mc = Regex.Matches(appVal, "\\d+");
                        if (mc.Count > 0)
                        {
                            int val = int.MinValue;
                            if (int.TryParse(mc[0].Value, out val))
                                tot.TotalRevenueCollected = val;
                        }
                    }

                    tot.ApproximateRevenueCollected = appVal;
                    tot.TotalProjects = data.Tables[0].Rows.Count;
                    tot.ProjectAccount = prjAccount;
                }

                HttpContext.Current.Cache.Add(prjAccount + "cacheKey", tot, null, DateTime.Now.AddMinutes(5), System.Web.Caching.Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Default, null);
            }

            projects.Text = tot.TotalProjects.ToString();
            revenue.Text = tot.TotalRevenueCollected.ToString("C0");
        }
        #endregion End Private Methods
    }
}