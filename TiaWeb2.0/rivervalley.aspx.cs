using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TiaWeb2._0.Model;
using MeridianSystems.Solutions.Proliance.ServiceActivator.Gateway;
using MeridianSystems.Solutions.Proliance.ServiceActivator.Connection;
using MeridianSystems.Solutions.Proliance.ServiceActivator.Platform.Lookups;
using TiaWeb2._0.Controller;
using System.Data;

namespace TiaWeb2._0
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        private DataSet theData;        
        protected void Page_Load(object sender, EventArgs e)
        {            
            if (!this.IsPostBack)
            {
                var b = Request.QueryString["id"];
                if (b != null)
                    ((TIA)(this.Master)).accordion_selectedIndexChanged(System.Convert.ToInt16(b));          

                ProlianceController prj = new ProlianceController();
                ProlianceConnection conn = new ProlianceConnection("https://na2.agpmis.com", "na", "admin", "?aecom");
                string prjAccount = "pgmprj://na/tia/rvly";
                
                List<County> theCountites = prj.GetCounties(conn, prjAccount, "rvly").ToList();
                foreach (County cty in theCountites)
                {
                    ListItem li = new ListItem { Enabled = true, Text = cty.Description, Value = cty.FullCode };
                    this.DropDownListCounty.Items.Add(li);
                }

                List<Band> theBands = prj.GetBands(conn, prjAccount).ToList();
                foreach (Band bnd in theBands)
                {
                    ListItem li = new ListItem { Enabled = true, Text = bnd.Description, Value = bnd.FullCode };
                    this.DropDownListBand.Items.Add(li);
                }

                List<ProjectTypes> theProjectTypes = prj.GetProjectTypes(conn, prjAccount).ToList();
                foreach (ProjectTypes pt in theProjectTypes)
                {
                    ListItem li = new ListItem { Enabled = true, Text = pt.Description, Value = pt.FullCode };
                    this.DropDownListProjectType.Items.Add(li);
                }

                List<ProjectStatus> theProjectStatus = prj.GetProjectStatus(conn, prjAccount).ToList();
                foreach (ProjectStatus st in theProjectStatus)
                {
                    ListItem li = new ListItem { Enabled = true, Text = st.Description, Value = st.FullCode };
                    this.DropDownListProjectStatus.Items.Add(li);
                }


                //List<Status> theStatusTypes = prj.GetStatusTypes(conn, prjAccount).ToList();
                //foreach (Status pt in theStatusTypes)
                //{
                //    ListItem li = new ListItem { Enabled = true, Text = pt.Description, Value = pt.FullCode };
                //    this.DropDownListActive.Items.Add(li);
                //}


                theData = prj.GetPreProjectList(conn, prjAccount);
                Cache["PrjData"] = theData;
                this.RepeaterProjectList.DataSource = theData;
                this.RepeaterProjectList.DataBind();
                if (!(theData.Tables[0].Rows.Count > 0))
                    this.Label1.Visible = true;
            }          
        }

        protected void DropDownListCounty_SelectedIndexChanged1(object sender, EventArgs e)
        {
            ApplyAllFilters();
        }

        private DataSet GetPrjCache()
        {
            ProlianceController prj = new ProlianceController();
            ProlianceConnection conn = new ProlianceConnection("https://na2.agpmis.com", "na", "admin", "?aecom");
            string prjAccount = "pgmprj://na/tia/rvly";
            string cacheKey = "PRjData";
            object cacheItem = Cache[cacheKey] as DataSet;
            if( (cacheItem == null))
            {
                cacheItem = prj.GetPreProjectList(conn, prjAccount);                
            }
            return (DataSet)cacheItem;
        }
                
        protected void DropDownListBand_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyAllFilters();
        }

        protected void DropDownListProjectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyAllFilters();
        }

        protected void DropDownListProjectStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyAllFilters();
        }


        protected void DropDownListActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyAllFilters();
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


            //if (this.DropDownListActive.SelectedIndex != 0)
            //{
            //    if (this.DropDownListActive.SelectedIndex == 1)
            //    {
            //        if (!string.IsNullOrEmpty(filterExp))
            //            filterExp = filterExp + "and SmallProjectDocument_Status_FullCode = '01'";
            //        else
            //            filterExp = filterExp + "SmallProjectDocument_Status_FullCode = '01'";
            //    }
            //    else
            //    {
            //        if (!string.IsNullOrEmpty(filterExp))
            //            filterExp = filterExp + "and SmallProjectDocument_Status_FullCode = '02' or SmallProjectDocument_Status_FullCode = '10' or SmallProjectDocument_Status_FullCode is null";
            //        else
            //            filterExp = filterExp + "SmallProjectDocument_Status_FullCode = '02' or SmallProjectDocument_Status_FullCode = '10' or SmallProjectDocument_Status_FullCode is null";
            //    }
            //}


            theData = GetPrjCache();
            this.Label1.Visible = false;           
            var dv = theData.Tables[0].DefaultView;
            dv.RowFilter = filterExp;
            var FilteredView = new DataSet();
            var newDT = dv.ToTable();
            FilteredView.Tables.Add(newDT);
            this.RepeaterProjectList.DataSource = FilteredView;
            this.RepeaterProjectList.DataBind();
            if (!(FilteredView.Tables[0].Rows.Count > 0))
                this.Label1.Visible = true;         
         }


    }
}