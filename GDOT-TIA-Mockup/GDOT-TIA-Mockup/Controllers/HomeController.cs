using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GDOT_TIA.Models;

namespace GDOT_TIA.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
			Region csra = new Region(Region.CSRAId);
			Region hoga = new Region(Region.HOGAId);
			Region rv = new Region(Region.RVId);

			ViewBag.totalTaxRevenueCollected = (csra.totalRevenueCollected + hoga.totalRevenueCollected + rv.totalRevenueCollected).ToString("C2");
			ViewBag.totalProjects = csra.totalProjects + hoga.totalProjects + rv.totalProjects;

            return View();
        }

		// GET: /Gallery/
		public ActionResult FactSheet()
		{
			return View();
		}

		// GET: /Gallery/
		public ActionResult Gallery()
		{
			return View();
		}
	}
}