﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GDOT_TIA.Models;
using FlickrNet;
using System.Collections.Specialized;
using System.Configuration;

namespace GDOT_TIA.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
			Region csra = new Region(Region.RegionAbbrs.csra);
			Region hoga = new Region(Region.RegionAbbrs.hoga);
			Region rv = new Region(Region.RegionAbbrs.rvly);
            Region soga = new Region(Region.RegionAbbrs.soga);

			ViewBag.csraTaxCollected = csra.TotalRevenueCollected.ToString("C2");
			ViewBag.hogaTaxCollected = hoga.TotalRevenueCollected.ToString("C2");
            ViewBag.rvTaxCollected = rv.TotalRevenueCollected.ToString("C2");
            ViewBag.sogaTaxCollected = soga.TotalRevenueCollected.ToString("C2");
            ViewBag.csraTotalProjects = csra.TotalProjects;
			ViewBag.hogaTotalProjects = hoga.TotalProjects;
            ViewBag.rvTotalProjects = rv.TotalProjects;
            ViewBag.sogaTotalProjects = soga.TotalProjects;

            ViewBag.totalTaxRevenueCollected = (csra.TotalRevenueCollected + hoga.TotalRevenueCollected + rv.TotalRevenueCollected + soga.TotalRevenueCollected) / 1000000;
			ViewBag.totalTaxRevenueCollectedString = (csra.TotalRevenueCollected + hoga.TotalRevenueCollected + rv.TotalRevenueCollected + soga.TotalRevenueCollected).ToString("C2");
			ViewBag.totalProjects = csra.TotalProjects + hoga.TotalProjects + rv.TotalProjects + soga.TotalProjects;
			ViewBag.totalFinishedProjects = csra.TotalFinishedProjects + hoga.TotalFinishedProjects + rv.TotalFinishedProjects + soga.TotalFinishedProjects;
			ViewBag.totalConstructionProjects = csra.TotalConstructionProjects + hoga.TotalConstructionProjects + rv.TotalConstructionProjects + soga.TotalConstructionProjects;

            ViewBag.totalFundsBudgeted = (csra.TotalFundsBudgeted + hoga.TotalFundsBudgeted + rv.TotalFundsBudgeted + soga.TotalFundsBudgeted).ToString("C");

            ViewBag.csra = csra;
            ViewBag.hoga = hoga;
            ViewBag.rv = rv;
            ViewBag.soga = soga;

			ViewBag.totalExpenditure = ((csra.TotalFundsSpent + hoga.TotalFundsSpent + rv.TotalFundsSpent + soga.TotalFundsSpent)).ToString("C2");
			
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

        // GET: /Staff/
        public ActionResult Staff()
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
            NameValueCollection flickrSettings = (NameValueCollection)ConfigurationManager.GetSection("flickrSettings");
            Flickr flickr = new Flickr(flickrSettings["apiKey"]);

            /*IOrderedEnumerable<FlickrNet.Photoset> photoCollection = flickr.PhotosetsGetList(myId, PhotoSearchExtras.DateTaken).OrderByDescending(d => d.PrimaryPhoto.DateTaken);
			IOrderedEnumerable<FlickrNet.Photo> photoList;

			foreach (Photoset ps in photoCollection)
			{
				ps.PrimaryPhoto.
			}*/
            var photosetList = flickr.PhotosetsGetList(flickrSettings["userId"], PhotoSearchExtras.DateTaken | PhotoSearchExtras.MediumUrl).OrderByDescending(d => d.PrimaryPhoto.DateTaken);

            ViewBag.albumList = photosetList;

            return View();
		}


		// GET: /SlideShow/
		public ActionResult SlideShow(string id)
		{
            NameValueCollection flickrSettings = (NameValueCollection)ConfigurationManager.GetSection("flickrSettings");
            Flickr flickr = new Flickr(flickrSettings["apiKey"]);
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