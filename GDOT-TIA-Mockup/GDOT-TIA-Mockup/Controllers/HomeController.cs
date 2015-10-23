using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GDOT_TIA.Models;
using FlickrNet;

namespace GDOT_TIA.Controllers
{
    public class HomeController : Controller
    {
		private const string _myAPIKey = "8f69ca7e3ad465173e52b244198ec521";
		private const string _myId = "135336406@N07";
		
		private string myApiKey { get { return _myAPIKey; } }
		private string myId { get { return _myId; } }

        //
        // GET: /Home/
        public ActionResult Index()
        {
			Region csra = new Region(Region.RegionAbbrs.csra);
			Region hoga = new Region(Region.RegionAbbrs.hoga);
			Region rv = new Region(Region.RegionAbbrs.rvly);

			ViewBag.csraTaxCollected = csra.TotalRevenueCollected.ToString("C2");
			ViewBag.hogaTaxCollected = hoga.TotalRevenueCollected.ToString("C2");
			ViewBag.rvTaxCollected = rv.TotalRevenueCollected.ToString("C2");
			ViewBag.csraTotalProjects = csra.TotalProjects;
			ViewBag.hogaTotalProjects = hoga.TotalProjects;
			ViewBag.rvTotalProjects = rv.TotalProjects;

			ViewBag.totalTaxRevenueCollected = (csra.TotalRevenueCollected + hoga.TotalRevenueCollected + rv.TotalRevenueCollected) / 1000000;
			ViewBag.totalTaxRevenueCollectedString = (csra.TotalRevenueCollected + hoga.TotalRevenueCollected + rv.TotalRevenueCollected).ToString("C2");
			ViewBag.totalProjects = csra.TotalProjects + hoga.TotalProjects + rv.TotalProjects;
			ViewBag.totalFinishedProjects = csra.TotalFinishedProjects + hoga.TotalFinishedProjects + rv.TotalFinishedProjects;
			ViewBag.totalConstructionProjects = csra.TotalConstructionProjects + hoga.TotalConstructionProjects + rv.TotalConstructionProjects;

            ViewBag.csra = csra;
            ViewBag.hoga = hoga;
            ViewBag.rv = rv;

			ViewBag.totalExpenditure = ((csra.TotalFundsSpent + hoga.TotalFundsSpent + rv.TotalFundsSpent)).ToString("C2");
			
            return View();
        }

		// GET: /Procurement/
		public ActionResult Procurement()
		{
			return View();
		}

		// GET: /FactSheet/
		public ActionResult FactSheet()
		{
			return View();
		}

		// GET: /FAQ/
		public ActionResult FAQ()
		{
			return View();
		}

		// GET: /News/
		public ActionResult News()
		{
			return View();
		}

		// GET: /Calendar/
		/*public ActionResult Calendar()
		{
			return View();
		}*/

		// GET: /Annual Report/
		public ActionResult AnnualReport()
		{
			return View();
		}

		// GET: /Citizen Review Panel/
		public ActionResult CitizenReview()
		{
			return View();
		}
        public ActionResult MeetingPresentations()
        {
            return View();
        }

        public ActionResult Manuals()
        {
            return View();
        }


		// GET: /Contact Us/
		public ActionResult Contact()
		{
			return View();
		}

		// GET: /Regional Discretionary Funding Estimates /
		public ActionResult Discretionary()
		{
			return View();
		}

		// GET: /Final Investment Reports by Region/
		public ActionResult Investment()
		{
			return View();
		}

		// GET: /Gallery/
		public ActionResult Gallery()
		{
			Flickr flickr = new Flickr(myApiKey);

			/*IOrderedEnumerable<FlickrNet.Photoset> photoCollection = flickr.PhotosetsGetList(myId, PhotoSearchExtras.DateTaken).OrderByDescending(d => d.PrimaryPhoto.DateTaken);
			IOrderedEnumerable<FlickrNet.Photo> photoList;

			foreach (Photoset ps in photoCollection)
			{
				ps.PrimaryPhoto.
			}*/

			ViewBag.albumList = flickr.PhotosetsGetList(myId, PhotoSearchExtras.DateTaken | PhotoSearchExtras.MediumUrl).OrderByDescending(d => d.PrimaryPhoto.DateTaken);

			return View();
		}


		// GET: /SlideShow/
		public ActionResult SlideShow(string id)
		{
			Flickr flickr = new Flickr(myApiKey);
			Photoset ps= flickr.PhotosetsGetInfo(id);

			if (ps != null)
			{
				ViewBag.Title = ps.Title + " Slideshow";
			}

			ViewBag.albumId = id;

			return View();
		}
	}
}