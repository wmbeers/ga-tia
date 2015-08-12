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
		ProlianceController pcCSRA = new ProlianceController(ProlianceController.CSRA_ACCOUNT);
		ProlianceController pcHOGA = new ProlianceController(ProlianceController.HOGA_ACCOUNT);
		ProlianceController pcRV = new ProlianceController(ProlianceController.RV_ACCOUNT);
        //
        // GET: /Project/
        public ActionResult Index()
        {
            return View();
        }

		// GET: /CSRA/
		public ActionResult CSRA()
		{
			DataSet theData;

			List<County> theCountites = pcCSRA.GetCounties("csra").ToList();
			List<Band> theBands = pcCSRA.GetBands().ToList();
            List<ProjectTypes> theProjectTypes = pcCSRA.GetProjectTypes().ToList();
            List<ProjectStatus> theProjectStatus = pcCSRA.GetProjectStatus().ToList();

			theData = pcCSRA.GetPreProjectList();
			/*foreach (County cty in theCountites)
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
            }

            theData = pcCSRA.GetPreProjectList();
            Cache["PrjData"] = theData;
            this.RepeaterProjectList.DataSource = theData;
            this.RepeaterProjectList.DataBind();
            if (!(theData.Tables[0].Rows.Count > 0))
                this.Label1.Visible = true;*/



			return View();
		}
	}
}