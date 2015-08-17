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
		protected global::System.Web.UI.UpdatePanel MyUpdatePanel;
        protected global::System.Web.UI.WebControls.Panel Panel1;
        protected global::System.Web.UI.WebControls.DropDownList DropDownListCounty;     
        protected global::System.Web.UI.WebControls.DropDownList DropDownListBand;
        protected global::System.Web.UI.WebControls.DropDownList DropDownListProjectType;
        protected global::System.Web.UI.WebControls.DropDownList DropDownListProjectStatus;
        protected global::System.Web.UI.WebControls.Label LabelNoProjects;
        protected global::System.Web.UI.WebControls.Repeater RepeaterProjectList;
		
		private DataSet theData;
		private ProjectPage ppm;

		private const int CSRARegion = 0;
		private const int HOGARegion = 1;
		private const int RVRegion = 2;

		private int currentRegion;
        //
        // GET: /Project/
        public ActionResult Index()
		{
			ProlianceController pcCSRA = new ProlianceController(ProlianceController.CSRA_ACCOUNT);
			ProlianceController pcHOGA = new ProlianceController(ProlianceController.HOGA_ACCOUNT);
			ProlianceController pcRV = new ProlianceController(ProlianceController.RV_ACCOUNT);

			//int totalProjects = 0;
			//int finishedProjects = 0;

            return View();
        }

		// GET: /CSRA/
		public ActionResult CSRA()
		{
			ProlianceController pcCSRA = new ProlianceController(ProlianceController.CSRA_ACCOUNT);
			ppm = new ProjectPage();
			int totalProjects = 0;
			int finishedProjects = 0;

			List<County> theCounties = pcCSRA.GetCounties("csra").ToList();
			List<Band> theBands = pcCSRA.GetBands().ToList();
            List<ProjectTypes> theProjectTypes = pcCSRA.GetProjectTypes().ToList();
            List<ProjectStatus> theProjectStatus = pcCSRA.GetProjectStatus().ToList();

			ppm.AllBands = pcCSRA.GetBands().ToList();
			ppm.AllCounties = pcCSRA.GetCounties("csra").ToList();
			ppm.AllProjectTypes = pcCSRA.GetProjectTypes().ToList();
			ppm.AllProjectStatuses = pcCSRA.GetProjectStatus().ToList();

			foreach (ProjectStatus ps in theProjectStatus)
			{
				if (ps.Code.Contains("Complete")) finishedProjects++;
				totalProjects++;
			}

			ViewBag.totalProjects = totalProjects;
			ViewBag.finishedProjects = finishedProjects;
			ppm.totalProjects = totalProjects;
			ppm.finishedProjects = finishedProjects;

			/*ViewBag.counties = theCounties;
			ViewBag.bands = theBands;
			ViewBag.types = theProjectTypes;
			ViewBag.statuses = theProjectStatus;*/

			theData = pcCSRA.GetPreProjectList();
			/*RepeaterProjectList.DataSource = theData;
			RepeaterProjectList.DataBind();

			foreach (County cty in theCounties)
			{
				ListItem li = new ListItem { Enabled = true, Text = cty.Description, Value = cty.FullCode };
				this.DropDownListCounty.Items.Add(li);
			}
			
			foreach (Band bnd in theBands)
            {
                ListItem li = new ListItem { Enabled = true, Text = bnd.Description, Value = bnd.FullCode };
                this.DropDownListBand.Items.Add(li);
            }

            foreach (ProjectTypes pt in theProjectTypes)
            {
                ListItem li = new ListItem { Enabled = true, Text = pt.Description, Value = pt.FullCode };
                this.DropDownListProjectType.Items.Add(li);
            }

            foreach (ProjectStatus st in theProjectStatus)
            {
                ListItem li = new ListItem { Enabled = true, Text = st.Description, Value = st.FullCode };
                this.DropDownListProjectStatus.Items.Add(li);
            }*/

			theData = pcCSRA.GetPreProjectList();
			if (theData != null && theData.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow r in theData.Tables[0].Rows)
				{
					Project p = new Project();
					p.projectName = r["SmallProjectDocument_DocDescription"].ToString();
					p.band = r["SmallProjectDocument_ServiceType_Description"].ToString();
					p.pino = r["SmallProjectDocument_DocVisualId"].ToString();
					p.regionalProjectId = r["SmallProjectDocument_AlternateNumber1"].ToString();
					p.county = r["SmallProjectDocument_OfficeUnit_Description"].ToString();
					p.congressionalDistrict = r["SmallProjectDocument_ManagerCode_Description"].ToString();
					p.regionalCommission = r["SmallProjectDocument_AddressInfoNote"].ToString();
					p.projectType = r["SmallProjectDocument_MarketSector_Description"].ToString();
					p.progressPhotos = r["SmallProjectDocument_PhoneInfoNote"].ToString();
					p.originalBudget = r["SmallProjectDocument_AddressInfoNote"].ToString();
					p.invoicedToDate = r["SmallProjectDocument_ApproximateValueText"].ToString();
					p.description = r["SmallProjectDocument_DocTitle"].ToString();
					p.projectStatus = r["SmallProjectDocument_SecuredStatus_FullCode"].ToString();
					p.projectPage = r["SmallProjectDocument_SiteFaxInfoNote"].ToString();
					p.regionalCommission = "Central Savannah";

					ppm.AllProjects.Add(p);
				}
			}

            //Cache["PrjData"] = theData;
            /*this.RepeaterProjectList.DataSource = theData;
            this.RepeaterProjectList.DataBind();
            if (!(theData.Tables[0].Rows.Count > 0))
                LabelNoProjects.Visible = true;
			*/
			return View(ppm);
		}

		// GET: /RV/
		public ActionResult HOGA()
		{
			ProlianceController pcHOGA = new ProlianceController(ProlianceController.HOGA_ACCOUNT);
			ppm = new ProjectPage();
			int totalProjects = 0;
			int finishedProjects = 0;

			List<ProjectStatus> theProjectStatus = pcHOGA.GetProjectStatus().ToList();

			ppm.AllBands = pcHOGA.GetBands().ToList();
			ppm.AllCounties = pcHOGA.GetCounties("csra").ToList();
			ppm.AllProjectTypes = pcHOGA.GetProjectTypes().ToList();
			ppm.AllProjectStatuses = pcHOGA.GetProjectStatus().ToList();

			foreach (ProjectStatus ps in theProjectStatus)
			{
				if (ps.Code.Contains("Complete")) finishedProjects++;
				totalProjects++;
			}
			ppm.totalProjects = totalProjects;
			ppm.finishedProjects = finishedProjects;

			theData = pcHOGA.GetPreProjectList();

			if (theData != null && theData.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow r in theData.Tables[0].Rows)
				{
					Project p = new Project();
					p.projectName = r["SmallProjectDocument_DocDescription"].ToString();
					p.band = r["SmallProjectDocument_ServiceType_Description"].ToString();
					p.pino = r["SmallProjectDocument_DocVisualId"].ToString();
					p.regionalProjectId = r["SmallProjectDocument_AlternateNumber1"].ToString();
					p.county = r["SmallProjectDocument_OfficeUnit_Description"].ToString();
					p.congressionalDistrict = r["SmallProjectDocument_ManagerCode_Description"].ToString();
					p.regionalCommission = r["SmallProjectDocument_AddressInfoNote"].ToString();
					p.projectType = r["SmallProjectDocument_MarketSector_Description"].ToString();
					p.progressPhotos = r["SmallProjectDocument_PhoneInfoNote"].ToString();
					p.originalBudget = r["SmallProjectDocument_AddressInfoNote"].ToString();
					p.invoicedToDate = r["SmallProjectDocument_ApproximateValueText"].ToString();
					p.description = r["SmallProjectDocument_DocTitle"].ToString();
					p.projectStatus = r["SmallProjectDocument_SecuredStatus_FullCode"].ToString();
					p.projectPage = r["SmallProjectDocument_SiteFaxInfoNote"].ToString();
					p.regionalCommission = "Heart of Georgia";

					ppm.AllProjects.Add(p);
				}
			}
			return View(ppm);
		}

		// GET: /RV/
		public ActionResult RV()
		{
			ProlianceController pcRV = new ProlianceController(ProlianceController.RV_ACCOUNT);
			ppm = new ProjectPage();
			int totalProjects = 0;
			int finishedProjects = 0;

			List<ProjectStatus> theProjectStatus = pcRV.GetProjectStatus().ToList();

			ppm.AllBands = pcRV.GetBands().ToList();
			ppm.AllCounties = pcRV.GetCounties("csra").ToList();
			ppm.AllProjectTypes = pcRV.GetProjectTypes().ToList();
			ppm.AllProjectStatuses = pcRV.GetProjectStatus().ToList();

			foreach (ProjectStatus ps in theProjectStatus)
			{
				if (ps.Code.Contains("Complete")) finishedProjects++;
				totalProjects++;
			}
			ppm.totalProjects = totalProjects;
			ppm.finishedProjects = finishedProjects;

			theData = pcRV.GetPreProjectList();

			if (theData != null && theData.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow r in theData.Tables[0].Rows)
				{
					Project p = new Project();
					p.projectName = r["SmallProjectDocument_DocDescription"].ToString();
					p.band = r["SmallProjectDocument_ServiceType_Description"].ToString();
					p.pino = r["SmallProjectDocument_DocVisualId"].ToString();
					p.regionalProjectId = r["SmallProjectDocument_AlternateNumber1"].ToString();
					p.county = r["SmallProjectDocument_OfficeUnit_Description"].ToString();
					p.congressionalDistrict = r["SmallProjectDocument_ManagerCode_Description"].ToString();
					p.regionalCommission = r["SmallProjectDocument_AddressInfoNote"].ToString();
					p.projectType = r["SmallProjectDocument_MarketSector_Description"].ToString();
					p.progressPhotos = r["SmallProjectDocument_PhoneInfoNote"].ToString();
					p.originalBudget = r["SmallProjectDocument_AddressInfoNote"].ToString();
					p.invoicedToDate = r["SmallProjectDocument_ApproximateValueText"].ToString();
					p.description = r["SmallProjectDocument_DocTitle"].ToString();
					p.projectStatus = r["SmallProjectDocument_SecuredStatus_FullCode"].ToString();
					p.projectPage = r["SmallProjectDocument_SiteFaxInfoNote"].ToString();
					p.regionalCommission = "Central Savannah";

					ppm.AllProjects.Add(p);
				}
			}
			return View(ppm);
		}

		[HttpGet]
		public ActionResult Filter(string bandString, string countyString, string statusString, string typeString, int region)
		{
			ApplyAllFilters(bandString, countyString, statusString, typeString, region);
			return PartialView("_ProjectList",ppm);
		}


		private void ApplyAllFilters(string bandString, string countyString, string statusString, string typeString, int region)
		{
			string filterExp = string.Empty;
			if (!string.IsNullOrEmpty(countyString))
				if (!string.IsNullOrEmpty(filterExp))
					filterExp = filterExp + "and SmallProjectDocument_OfficeUnit_FullCode = '" + countyString + "'";
				else
					filterExp = filterExp + "SmallProjectDocument_OfficeUnit_FullCode = '" + countyString + "'";
			if (!string.IsNullOrEmpty(bandString))
				if (!string.IsNullOrEmpty(filterExp))
					filterExp = filterExp + "and SmallProjectDocument_ServiceType_FullCode = '" + bandString + "'";
				else
					filterExp = filterExp + "SmallProjectDocument_ServiceType_FullCode = '" + bandString + "'";
			if (!string.IsNullOrEmpty(statusString))
				if (!string.IsNullOrEmpty(filterExp))
					filterExp = filterExp + "and SmallProjectDocument_MarketSector_FullCode = '" + statusString + "'";
				else
					filterExp = filterExp + "SmallProjectDocument_MarketSector_FullCode = '" + statusString + "'";
			if (!string.IsNullOrEmpty(typeString))
				if (!string.IsNullOrEmpty(filterExp))
					filterExp = filterExp + "and SmallProjectDocument_SecuredStatus_FullCode = '" + typeString + "'";
				else
					filterExp = filterExp + "SmallProjectDocument_SecuredStatus_FullCode = '" + typeString + "'";

			//theData = GetPrjCache();
			//LabelNoProjects.Visible = false;
			theData = null;
			switch (region)
			{
				default:case CSRARegion:
					ProlianceController pcCSRA = new ProlianceController(ProlianceController.CSRA_ACCOUNT);
					theData = pcCSRA.GetPreProjectList();
					break;
				case HOGARegion:
					ProlianceController pcHOGA = new ProlianceController(ProlianceController.HOGA_ACCOUNT);
					theData = pcHOGA.GetPreProjectList();
					break;
				case RVRegion:
					ProlianceController pcRV = new ProlianceController(ProlianceController.RV_ACCOUNT);
					theData = pcRV.GetPreProjectList();
					break;
			}
			var dv = theData.Tables[0].DefaultView;
			dv.RowFilter = filterExp;
			var FilteredView = new DataSet();
			var newDT = dv.ToTable();
			FilteredView.Tables.Add(newDT);
			ppm = new ProjectPage();
			if (FilteredView != null && FilteredView.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow r in FilteredView.Tables[0].Rows)
				{
					Project p = new Project();
					p.projectName = r["SmallProjectDocument_DocDescription"].ToString();
					p.band = r["SmallProjectDocument_ServiceType_Description"].ToString();
					p.pino = r["SmallProjectDocument_SiteFaxInfoNote"].ToString();
					p.regionalProjectId = r["SmallProjectDocument_AlternateNumber1"].ToString();
					p.county = r["SmallProjectDocument_OfficeUnit_Description"].ToString();
					p.congressionalDistrict = r["SmallProjectDocument_ManagerCode_Description"].ToString();
					p.regionalCommission = r["SmallProjectDocument_AddressInfoNote"].ToString();
					p.projectType = r["SmallProjectDocument_MarketSector_Description"].ToString();
					p.progressPhotos = r["SmallProjectDocument_PhoneInfoNote"].ToString();
					p.originalBudget = r["SmallProjectDocument_AddressInfoNote"].ToString();
					p.invoicedToDate = r["SmallProjectDocument_ApproximateValueText"].ToString();
					p.description = r["SmallProjectDocument_DocTitle"].ToString();
					p.projectStatus = r["SmallProjectDocument_SecuredStatus_FullCode"].ToString();
					p.projectPage = r["SmallProjectDocument_SiteFaxInfoNote"].ToString();
					switch (region)
					{
						case CSRARegion:
							p.regionalCommission = "Central Savannah";
							break;
						case HOGARegion:
							p.regionalCommission = "Heart of Georgia";
							break;
						case RVRegion:
							p.regionalCommission = "River Valley";
							break;
						default:
							break;
					}

					ppm.AllProjects.Add(p);
				}
			}
		}

		private void ApplyAllFilters()
		{
			string filterExp = string.Empty;
			if (this.DropDownListCounty.SelectedIndex != 0)
				if (!string.IsNullOrEmpty(filterExp))
					filterExp = filterExp + "and SmallProjectDocument_OfficeUnit_FullCode = '" + this.DropDownListCounty.SelectedValue + "'";
				else
					filterExp = filterExp + "SmallProjectDocument_OfficeUnit_FullCode = '" + this.DropDownListCounty.SelectedValue + "'";
			if (this.DropDownListBand.SelectedIndex != 0)
				if (!string.IsNullOrEmpty(filterExp))
					filterExp = filterExp + "and SmallProjectDocument_ServiceType_FullCode = '" + this.DropDownListBand.SelectedValue + "'";
				else
					filterExp = filterExp + "SmallProjectDocument_ServiceType_FullCode = '" + this.DropDownListBand.SelectedValue + "'";
			if (this.DropDownListProjectType.SelectedIndex != 0)
				if (!string.IsNullOrEmpty(filterExp))
					filterExp = filterExp + "and SmallProjectDocument_MarketSector_FullCode = '" + this.DropDownListProjectType.SelectedValue + "'";
				else
					filterExp = filterExp + "SmallProjectDocument_MarketSector_FullCode = '" + this.DropDownListProjectType.SelectedValue + "'";
			if (this.DropDownListProjectStatus.SelectedIndex != 0)
				if (!string.IsNullOrEmpty(filterExp))
					filterExp = filterExp + "and SmallProjectDocument_SecuredStatus_FullCode = '" + this.DropDownListProjectStatus.SelectedValue + "'";
				else
					filterExp = filterExp + "SmallProjectDocument_SecuredStatus_FullCode = '" + this.DropDownListProjectStatus.SelectedValue + "'";

			//theData = GetPrjCache();
			LabelNoProjects.Visible = false;
			var dv = theData.Tables[0].DefaultView;
			dv.RowFilter = filterExp;
			var FilteredView = new DataSet();
			var newDT = dv.ToTable();
			FilteredView.Tables.Add(newDT);
			this.RepeaterProjectList.DataSource = FilteredView;
			this.RepeaterProjectList.DataBind();
			if (!(FilteredView.Tables[0].Rows.Count > 0))
				LabelNoProjects.Visible = true;
		}
	}
}