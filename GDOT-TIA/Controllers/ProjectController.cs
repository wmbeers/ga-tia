using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Mvc;
using GDOT_TIA.Models;
using MeridianSystems.Solutions.Proliance.ServiceActivator.Gateway;
using MeridianSystems.Solutions.Proliance.ServiceActivator.Connection;
using MeridianSystems.Solutions.Proliance.ServiceActivator.Platform.Lookups;

namespace GDOT_TIA.Controllers
{

    public class ProjectController : Controller
    {		
        //
        // GET: /Project/
        public ActionResult Index()
		{
            Region csra = new Region(Region.RegionAbbrs.csra);
            Region hoga = new Region(Region.RegionAbbrs.hoga);
            Region rvly = new Region(Region.RegionAbbrs.rvly);
            Region soga = new Region(Region.RegionAbbrs.soga);

            ViewBag.csraTaxCollected = csra.TotalRevenueCollected.ToString("C2");
            ViewBag.hogaTaxCollected = hoga.TotalRevenueCollected.ToString("C2");
            ViewBag.rvTaxCollected = rvly.TotalRevenueCollected.ToString("C2");
            ViewBag.sogaTaxCollected = soga.TotalRevenueCollected.ToString("C2");
            ViewBag.csraTaxCollectedNum = (int)(csra.TotalRevenueCollected / 1000000);
            ViewBag.hogaTaxCollectedNum = (int)(hoga.TotalRevenueCollected / 1000000);
            ViewBag.rvTaxCollectedNum = (int)(rvly.TotalRevenueCollected / 1000000);
            ViewBag.sogaTaxCollectedNum = (int)(soga.TotalRevenueCollected / 1000000);
            ViewBag.sogaTotalFundsBudgeted = soga.TotalFundsBudgeted.ToString("C2");
            ViewBag.rvTotalFundsBudgeted = rvly.TotalFundsBudgeted.ToString("C2");
            ViewBag.hogaTotalFundsBudgeted = hoga.TotalFundsBudgeted.ToString("C2");
            ViewBag.csraTotalFundsBudgeted = csra.TotalFundsBudgeted.ToString("C2");
            ViewBag.sogaTotalFundsBudgetedNum = (int)(soga.TotalFundsBudgeted / 1000000);
            ViewBag.rvTotalFundsBudgetedNum = (int)(rvly.TotalFundsBudgeted / 1000000);
            ViewBag.hogaTotalFundsBudgetedNum = (int)(hoga.TotalFundsBudgeted / 1000000);
            ViewBag.csraTotalFundsBudgetedNum = (int)(csra.TotalFundsBudgeted / 1000000);
            ViewBag.csraFundsSpent = csra.TotalFundsSpent.ToString("C2");
            ViewBag.hogaFundsSpent = hoga.TotalFundsSpent.ToString("C2");
            ViewBag.rvFundsSpent = rvly.TotalFundsSpent.ToString("C2");
            ViewBag.sogaFundsSpent = soga.TotalFundsSpent.ToString("C2");
            ViewBag.csraTotalProjects = csra.TotalProjects;
            ViewBag.hogaTotalProjects = hoga.TotalProjects;
            ViewBag.rvTotalProjects = rvly.TotalProjects;
            ViewBag.sogaTotalProjects = soga.TotalProjects;

            return View();
        }

		public ActionResult List(string id)
        {
            if (String.IsNullOrWhiteSpace(id))
            {
                return RedirectToAction("Index", "Project");
            }
            //specific region
            try
            {
                Region.RegionAbbrs code = (Region.RegionAbbrs)Enum.Parse(typeof(Region.RegionAbbrs), id.ToLower());
                Region region = new Region(code);
                return View(region);
            }
            catch (System.ArgumentException)
            {
                return RedirectToAction("Index", "Project");
            }
        }

		[HttpGet]
		public ActionResult Filter(string bandString, string countyString, Int32? status, Int32? type, string regionCode)
		{
            Region.RegionAbbrs code = (Region.RegionAbbrs)Enum.Parse(typeof(Region.RegionAbbrs), regionCode);
            Region region = new Region(code);

            return PartialView("_ProjectList", region.GetProjects(bandString, countyString, status, type));
		}
		
	}
}