using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text.RegularExpressions;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeridianSystems.Solutions.Proliance.ServiceActivator.Connection;
using GDOT_TIA.Controllers;

namespace GDOT_TIA.Models
{
    public class Project
    {
		public string county { get; set; }
		public string band { get; set; }
		public string projectType { get; set; }
		public string projectStatus { get; set; }

		public string projectName { get; set; }
		public string projectPage { get; set; }
		public string pino { get; set; }
		public string regionalCommission { get; set; }
		public string originalBudget { get; set; }
		public string invoicedToDate { get; set; }
		public string regionalProjectId { get; set; }
		public string progressPhotos { get; set; }
		public string congressionalDistrict { get; set; }
		public string description { get; set; }
	}

}