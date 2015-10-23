using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MeridianSystems.Solutions.Proliance.ServiceActivator.Gateway.DocumentDataService;
using MeridianSystems.Solutions.Proliance.ServiceActivator.Gateway;
using MeridianSystems.Solutions.Proliance.ServiceActivator.Connection;
using MeridianSystems.Solutions.Proliance.ServiceActivator.Platform.Lookups;
using GDOT_TIA.Models;
using MeridianSystems.Solutions.Proliance.ServiceActivator.FoundationTypes;
using System.Data;

namespace GDOT_TIA.Controllers
{
    public class ProlianceController
	{

		private ProlianceConnection connection = new ProlianceConnection("https://na2.agpmis.com", "na", "admin", "?aecom");
		private string account = "";

		public ProlianceController(string prjAccount)
		{
			account = prjAccount;
		}

		public ProlianceController() { }

		
		public DataSet GetProjectApproxValues()
		{
			DataSet nData = new DataSet();

			using (var proliance = new GatewayProxy(connection, account))
			{
				try
				{
					var pageInfo = new PageInfo();
					pageInfo.SelectFields = new List<OutputField>
					{
						new OutputField("ProjectDocument_DocumentGuid"),
					};

					var ds = proliance.ListDocumentDataSet(DocumentTypeNames.ProjectDocument, pageInfo);

					if (ds != null && ds.Tables[0].Rows.Count > 0)
					{
						nData = ds;
					}
				}
				catch (Exception ex)
				{
					throw new Exception(ex.Message, ex.InnerException);
				}
				return nData;
			}
		}

		public DataSet GetPreProjectList()
		{
            DataSet nData = new DataSet();
            //var foo = "SmallProjectDocument_PlannedFinishDate"; //TODO: this is for getting the currently shelved planned finish date
			using (var proliance = new GatewayProxy(connection, account))
			{
				try
				{
					var pageInfo = new PageInfo();
                    pageInfo.SelectFields = new List<OutputField>
                    {
                        new OutputField("SmallProjectDocument_DocumentGuid"),
                        new OutputField("SmallProjectDocument_DocVisualId"),
                        new OutputField("SmallProjectDocument_DocTitle"),
                        new OutputField("SmallProjectDocument_DocSubTypeName"),
                        new OutputField("SmallProjectDocument_WorkflowStateDisplayName"),
                        new OutputField("SmallProjectDocument_MarketSector_FullCode"),
                        new OutputField("SmallProjectDocument_ManagerCode_Description"),
                        new OutputField("SmallProjectDocument_MarketSector_Description"),
                        new OutputField("SmallProjectDocument_PlannedStartDate"),
                        new OutputField("SmallProjectDocument_AlternateNumber1"),
                        new OutputField("SmallProjectDocument_OfficeUnit_FullCode"),
                        new OutputField("SmallProjectDocument_OfficeUnit_Description"),
                        new OutputField("SmallProjectDocument_SecuredStatus_FullCode"),
                        new OutputField("SmallProjectDocument_SecuredStatus_Description"),                                           
                        new OutputField("SmallProjectDocument_ServiceType_FullCode"),
                        new OutputField("SmallProjectDocument_ServiceType_Description"),
                        new OutputField("SmallProjectDocument_Status_FullCode"),
                        new OutputField("SmallProjectDocument_Status_Description"),  
                        new OutputField("SmallProjectDocument_DocDescription"),
                        new OutputField("SmallProjectDocument_DocDescriptionFull"),                                       
                        new OutputField("SmallProjectDocument_ApproximateValueText"),
                        new OutputField("SmallProjectDocument_WorkflowStateUID"),
                        new OutputField("SmallProjectDocument_AddressInfoNote"),
                        new OutputField("SmallProjectDocument_SiteFaxInfoNote"),
                        new OutputField("SmallProjectDocument_PhoneInfoNote")//,
                        //new OutputField(foo)
                    };

					pageInfo.Filters.Add(new FilterField("SmallProjectDocument_WorkflowStateDisplayName", QueryFilterOperation.NotEqual, "Cancelled", QueryFieldType.DataField, false));
					pageInfo.Filters.Add(new FilterField("SmallProjectDocument_DocTitle", QueryFilterOperation.NotEqual, "Program Administration", QueryFieldType.DataField, false));
					pageInfo.Filters.FilterRelations = (" 0 & 1 ");
					pageInfo.PagedOrderFields.Add(new OrderField("SmallProjectDocument_DocVisualId", QueryFieldType.DataField, QueryOrderAttribute.Ascending));
					DataSet ds = null;


                    try
                    {
                        ds = proliance.ListDocumentDataSet(DocumentTypeNames.SmallProjectDocument, pageInfo);
                    } catch (Exception e) {
                        System.Diagnostics.Debug.Print(e.ToString());
                    }
                    
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
					{
						nData = ds;
						foreach (DataRow r in nData.Tables[0].Rows)
						{
							r["SmallProjectDocument_DocVisualId"] = r["SmallProjectDocument_DocVisualId"].ToString().Replace("PI-", "");
							r["SmallProjectDocument_ServiceType_Description"] = r["SmallProjectDocument_ServiceType_Description"].ToString().Replace("Band", "");
							r["SmallProjectDocument_ManagerCode_Description"] = r["SmallProjectDocument_ManagerCode_Description"].ToString().Replace("Congressional District", "");
							r["SmallProjectDocument_OfficeUnit_Description"] = r["SmallProjectDocument_OfficeUnit_Description"].ToString().Replace("County", "");
							r["SmallProjectDocument_SecuredStatus_Description"] = r["SmallProjectDocument_SecuredStatus_Description"].ToString().Replace("Status", "");

						}
					}
				}
				catch (Exception ex)
				{
					throw new Exception(ex.Message, ex.InnerException);
				}
				return nData;
			}

		}

	    public DataSet GetProjectApproxValues(ProlianceConnection conn, string prjAccount)
        {
            DataSet nData = new DataSet();
            
            using (var proliance = new GatewayProxy(conn, prjAccount))
            {
                try
                {
                    var pageInfo = new PageInfo();
                    pageInfo.SelectFields = new List<OutputField>
                                       {
                                           new OutputField("ProjectDocument_DocumentGuid"),
                                           new OutputField("ProjectDocument_ProjectApproximateValueText")
                                       };

                    //pageInfo.Filters.Add(new FilterField("SmallProjectDocument_WorkflowStateDisplayName", QueryFilterOperation.NotEqual, "Cancelled", QueryFieldType.DataField, false));
                    //pageInfo.Filters.Add(new FilterField("SmallProjectDocument_DocTitle", QueryFilterOperation.NotEqual, "Program Administration", QueryFieldType.DataField, false));
                    //pageInfo.Filters.FilterRelations = (" 0 & 1 ");
                    //pageInfo.PagedOrderFields.Add(new OrderField("SmallProjectDocument_DocVisualId", QueryFieldType.DataField, QueryOrderAttribute.Ascending));
                    var ds = proliance.ListDocumentDataSet(DocumentTypeNames.ProjectDocument, pageInfo);

                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        nData = ds;
                        //foreach (DataRow r in nData.Tables[0].Rows)
                        //{
                        //    r["SmallProjectDocument_DocVisualId"] = r["SmallProjectDocument_DocVisualId"].ToString().Replace("PI-", "");
                        //    r["SmallProjectDocument_ServiceType_Description"] = r["SmallProjectDocument_ServiceType_Description"].ToString().Replace("Band", "");
                        //    r["SmallProjectDocument_ManagerCode_Description"] = r["SmallProjectDocument_ManagerCode_Description"].ToString().Replace("Congressional District", "");
                        //    r["SmallProjectDocument_OfficeUnit_Description"] = r["SmallProjectDocument_OfficeUnit_Description"].ToString().Replace("County", "");
                        //    r["SmallProjectDocument_SecuredStatus_Description"] = r["SmallProjectDocument_SecuredStatus_Description"].ToString().Replace("Status", "");

                        //}
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex.InnerException);
                }
                return nData;
            }
        }

        public DataSet GetPreProjectList(ProlianceConnection conn, string prjAccount)
        {
            DataSet nData = new DataSet();
            //List<Attachment> Attachments = GetAttachmentCache();
            //List<PreProjectDocument> docs = new List<PreProjectDocument>();
            using (var proliance = new GatewayProxy(conn, prjAccount))
            {
                try
                {
                    var pageInfo = new PageInfo();
                    pageInfo.SelectFields = new List<OutputField>
                                       {
                                           new OutputField("SmallProjectDocument_DocumentGuid"),
                                           new OutputField("SmallProjectDocument_DocVisualId"),
                                           new OutputField("SmallProjectDocument_DocTitle"),
                                           new OutputField("SmallProjectDocument_DocSubTypeName"),
                                           new OutputField("SmallProjectDocument_WorkflowStateDisplayName"),
                                           new OutputField("SmallProjectDocument_MarketSector_FullCode"),
                                           new OutputField("SmallProjectDocument_ManagerCode_Description"),
                                           new OutputField("SmallProjectDocument_MarketSector_Description"),
                                           new OutputField("SmallProjectDocument_PlannedStartDate"),
                                           new OutputField("SmallProjectDocument_AlternateNumber1"),
                                           new OutputField("SmallProjectDocument_OfficeUnit_FullCode"),
                                           new OutputField("SmallProjectDocument_OfficeUnit_Description"),
                                           new OutputField("SmallProjectDocument_SecuredStatus_FullCode"),
                                           new OutputField("SmallProjectDocument_SecuredStatus_Description"),                                           
                                           new OutputField("SmallProjectDocument_ServiceType_FullCode"),
                                           new OutputField("SmallProjectDocument_ServiceType_Description"),
                                           new OutputField("SmallProjectDocument_Status_FullCode"),
                                           new OutputField("SmallProjectDocument_Status_Description"),  
                                           new OutputField("SmallProjectDocument_DocDescription"),
                                           new OutputField("SmallProjectDocument_DocDescriptionFull"),                                       
                                           new OutputField("SmallProjectDocument_ApproximateValueText"),
                                           new OutputField("SmallProjectDocument_WorkflowStateUID"),
                                           new OutputField("SmallProjectDocument_AddressInfoNote"),
                                           new OutputField("SmallProjectDocument_SiteFaxInfoNote"),
                                           new OutputField("SmallProjectDocument_PhoneInfoNote")
                                       };

                    pageInfo.Filters.Add(new FilterField("SmallProjectDocument_WorkflowStateDisplayName", QueryFilterOperation.NotEqual, "Cancelled", QueryFieldType.DataField, false));
                    pageInfo.Filters.Add(new FilterField("SmallProjectDocument_DocTitle", QueryFilterOperation.NotEqual, "Program Administration", QueryFieldType.DataField, false));
                    pageInfo.Filters.FilterRelations = (" 0 & 1 ");
                    pageInfo.PagedOrderFields.Add(new OrderField("SmallProjectDocument_DocVisualId", QueryFieldType.DataField, QueryOrderAttribute.Ascending));
                    var ds = proliance.ListDocumentDataSet(DocumentTypeNames.SmallProjectDocument, pageInfo);

                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        nData = ds;
                        foreach (DataRow r in nData.Tables[0].Rows)
                        {
                            r["SmallProjectDocument_DocVisualId"] = r["SmallProjectDocument_DocVisualId"].ToString().Replace("PI-", "");
                            r["SmallProjectDocument_ServiceType_Description"] = r["SmallProjectDocument_ServiceType_Description"].ToString().Replace("Band", "");
                            r["SmallProjectDocument_ManagerCode_Description"] = r["SmallProjectDocument_ManagerCode_Description"].ToString().Replace("Congressional District", "");
                            r["SmallProjectDocument_OfficeUnit_Description"] = r["SmallProjectDocument_OfficeUnit_Description"].ToString().Replace("County", "");
                            r["SmallProjectDocument_SecuredStatus_Description"] = r["SmallProjectDocument_SecuredStatus_Description"].ToString().Replace("Status", "");

                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex.InnerException);
                }
                return nData;
            }

        }

    }
}