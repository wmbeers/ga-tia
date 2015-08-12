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

			ViewBag.albumList = flickr.PhotosetsGetList(myId).OrderByDescending(d => d.PrimaryPhoto.DateTaken);

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