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

        public Project(DataRow r)
        {
            this.projectName = r["SmallProjectDocument_DocDescription"].ToString();
            this.band = r["SmallProjectDocument_ServiceType_Description"].ToString();
            this.pino = r["SmallProjectDocument_DocVisualId"].ToString();
            this.regionalProjectId = r["SmallProjectDocument_AlternateNumber1"].ToString();
            this.county = r["SmallProjectDocument_OfficeUnit_Description"].ToString();
            this.congressionalDistrict = r["SmallProjectDocument_ManagerCode_Description"].ToString();
            this.regionalCommission = r["SmallProjectDocument_AddressInfoNote"].ToString();
            this.projectType = r["SmallProjectDocument_MarketSector_Description"].ToString();
            this.progressPhotos = r["SmallProjectDocument_PhoneInfoNote"].ToString();
            this.originalBudget = r["SmallProjectDocument_AddressInfoNote"].ToString();
            this.invoicedToDate = r["SmallProjectDocument_ApproximateValueText"].ToString();
            this.description = r["SmallProjectDocument_DocTitle"].ToString();
            this.projectStatus = r["SmallProjectDocument_SecuredStatus_FullCode"].ToString();
            this.projectPage = r["SmallProjectDocument_SiteFaxInfoNote"].ToString();
            //TODO: uncomment this if they want to see completion date
            //if (!r.IsNull("SmallProjectDocument_PlannedFinishDate"))
            //{
            //    this.completionDate = (DateTime)r["SmallProjectDocument_PlannedFinishDate"];
            //}


        }
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
        public DateTime? completionDate { get; set; }
	}

}