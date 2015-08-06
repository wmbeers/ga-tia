using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

        public IQueryable<County> GetCounties(ProlianceConnection conn, string prjAccount, string attrib)
        {
            //CurrentUser = (ProlianceUser)CurrentContext.Session["user"];
            using (var proliance = new LookupProxy(conn, prjAccount))
            {
                try
                {
                    var ver = proliance.GetLookupVersionByType("ProjectOfficeUnitType");

                    var query = from item in ver.Items.AsEnumerable()
                                where item.Attributes[0].Value.ToString() == attrib
                                select new County
                                {
                                    Code = item.Code,
                                    FullCode = item.FullCode,
                                    Description = item.Description,
                                    level = item.Level,
                                    Display = item.Code + " : " + item.Description,
                                    SortValue = item.SortValue
                                };
                    return query.AsQueryable();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error occured reading lookup: ", ex);
                }
            }
        }
        
        public IQueryable<Band> GetBands(ProlianceConnection conn, string prjAccount)
        {
            //CurrentUser = (ProlianceUser)CurrentContext.Session["user"];
            using (var proliance = new LookupProxy(conn, prjAccount))
            {
                try
                {
                    var ver = proliance.GetLookupVersionByType("ProjectServiceType");

                    var query = from item in ver.Items.AsEnumerable()
                                where item.Level == 0
                                select new Band
                                {
                                    Code = item.Code,
                                    FullCode = item.FullCode,
                                    Description = item.Description,
                                    level = item.Level,
                                    Display = item.Code + " : " + item.Description,
                                    SortValue = item.SortValue
                                };
                    return query.AsQueryable();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error occured reading lookup: ", ex);
                }
            }
        }

        public IQueryable<ProjectTypes> GetProjectTypes(ProlianceConnection conn, string prjAccount)
        {
            //CurrentUser = (ProlianceUser)CurrentContext.Session["user"];
            using (var proliance = new LookupProxy(conn, prjAccount))
            {
                try
                {
                    var ver = proliance.GetLookupVersionByType("ProjectMarketSectorType");

                    var query = from item in ver.Items.AsEnumerable()
                                where item.Level == 0
                                select new ProjectTypes
                                {
                                    Code = item.Code,
                                    FullCode = item.FullCode,
                                    Description = item.Description,
                                    level = item.Level,
                                    Display = item.Code + " : " + item.Description,
                                    SortValue = item.SortValue
                                };
                    return query.AsQueryable();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error occured reading lookup: ", ex);
                }
            }
        }

        public IQueryable<ProjectStatus> GetProjectStatus(ProlianceConnection conn, string prjAccount)
        {
            //CurrentUser = (ProlianceUser)CurrentContext.Session["user"];
            using (var proliance = new LookupProxy(conn, prjAccount))
            {
                try
                {
                    var ver = proliance.GetLookupVersionByType("ProjectSecuredStatusType");

                    var query = from item in ver.Items.AsEnumerable()
                                where item.Level == 0
                                select new ProjectStatus
                                {
                                    Code = item.Code,
                                    FullCode = item.FullCode,
                                    Description = item.Description,
                                    level = item.Level,
                                    Display = item.Code + " : " + item.Description,
                                    SortValue = item.SortValue
                                };
                    return query.AsQueryable();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error occured reading lookup: ", ex);
                }
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