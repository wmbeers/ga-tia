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
		private const string _myAPIKey= "4838674b035d35b548f65a8e7a2622b1";
		private const string _myId = "134938648@N06";
		
		private string myApiKey { get { return _myAPIKey; } }
		private string myId { get { return _myId; } }

        //
        // GET: /Home/
        public ActionResult Index()
        {
			Region csra = new Region(Region.CSRAId);
			Region hoga = new Region(Region.HOGAId);
			Region rv = new Region(Region.RVId);

			ViewBag.totalTaxRevenueCollected = (csra.totalRevenueCollected + hoga.totalRevenueCollected + rv.totalRevenueCollected) / 1000000;
			ViewBag.totalTaxRevenueCollectedString = (csra.totalRevenueCollected + hoga.totalRevenueCollected + rv.totalRevenueCollected).ToString("C2");
			ViewBag.totalProjects = csra.totalProjects + hoga.totalProjects + rv.totalProjects;

            return View();
        }

		// GET: /FactSheet/
		public ActionResult FactSheet()
		{
			return View();
		}

		// GET: /Gallery/
		public ActionResult Gallery()
		{
			Flickr flickr = new Flickr(myApiKey);

			ViewBag.albumList = flickr.PhotosetsGetList(myId);

			return View();
		}


		// GET: /SlideShow/
		public ActionResult SlideShow(string id)
		{
			ViewBag.albumId = id;

			return View();
		}
	}
}