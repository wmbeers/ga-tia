﻿using System;
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

			ViewBag.csraTaxCollected = csra.totals.TotalRevenueCollected.ToString("C2");
			ViewBag.hogaTaxCollected = hoga.totals.TotalRevenueCollected.ToString("C2");
			ViewBag.rvTaxCollected = rv.totals.TotalRevenueCollected.ToString("C2");
			ViewBag.csraTotalProjects = csra.totals.TotalProjects;
			ViewBag.hogaTotalProjects = hoga.totals.TotalProjects;
			ViewBag.rvTotalProjects = rv.totals.TotalProjects;

			ViewBag.totalTaxRevenueCollected = (csra.totals.TotalRevenueCollected + hoga.totals.TotalRevenueCollected + rv.totals.TotalRevenueCollected) / 1000000;
			ViewBag.totalTaxRevenueCollectedString = (csra.totals.TotalRevenueCollected + hoga.totals.TotalRevenueCollected + rv.totals.TotalRevenueCollected).ToString("C2");
			ViewBag.totalProjects = csra.totals.TotalProjects + hoga.totals.TotalProjects + rv.totals.TotalProjects;
			ViewBag.totalFinishedProjects = csra.totals.TotalFinishedProjects + hoga.totals.TotalFinishedProjects + rv.totals.TotalFinishedProjects;
			ViewBag.totalConstructionProjects = csra.totals.TotalConstructionProjects + hoga.totals.TotalConstructionProjects + rv.totals.TotalConstructionProjects;

            ViewBag.csra = csra;
            ViewBag.hoga = hoga;
            ViewBag.rv = rv;

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

		// GET: /Contact Us/
		public ActionResult Contact()
		{
			return View();
		}

		// GET: /Gallery/
		public ActionResult Gallery()
		{
			Flickr flickr = new Flickr(myApiKey);

			ViewBag.albumList = flickr.PhotosetsGetList(myId, PhotoSearchExtras.DateTaken).OrderByDescending(d => d.PrimaryPhoto.DateTaken);

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