using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GDOT_TIA_Mockup.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
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