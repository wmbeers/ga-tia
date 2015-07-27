<%@ Page Title="" Language="C#" MasterPageFile="~/TIA.Master" AutoEventWireup="true"
    CodeBehind="centralsavannah.aspx.cs" Inherits="TiaWeb2._0.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <td height="482">
        <p align="left">
            <img src="Images/CSRA-Header.jpg" width="375" height="41" /></p>
        <%--<asp:ScriptManager ID="ScriptManager1" runat="server">
			</asp:ScriptManager>  --%>
        <asp:UpdatePanel ID="MyUpdatePanel" runat="server">
            <ContentTemplate>
                <table width="100%" border="0" align="left" cellpadding="0" cellspacing="0">
                    <tr>
                    <td style="padding-left: 1.5px;"></td>
                        <td align="left" bgcolor="#0669A7" style="color: White; padding-bottom: 1px; text-align: left"; >                           
                                 &nbsp;Filter Projects By:
                                <table>
                                    <tr>
                                        <td style="text-align: left; color: #FFFFFF"">
                                                County</td>
                                        <td style="text-align: left; color: #FFFFFF"">
                                                Band
                                        </td>
                                        <td style="text-align: left; color: #FFFFFF"">
                                                Project Type
                                        </td>
                                        <td style="text-align: left; color: #FFFFFF"">
                                                Status
                                        </td>

<%--                                        <td style="text-align: left; color: #FFFFFF"">
                                                Under Construction
                                        </td>--%>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:DropDownList ID="DropDownListCounty" runat="server" AutoPostBack="True" 
                                                OnSelectedIndexChanged="DropDownListCounty_SelectedIndexChanged1" 
                                                ToolTip="Select County" Width="150">
                                                <asp:ListItem>All</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="DropDownListBand" runat="server" AutoPostBack="True" 
                                                OnSelectedIndexChanged="DropDownListBand_SelectedIndexChanged" 
                                                ToolTip="Select Band" Width="150">
                                                <asp:ListItem>All</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="DropDownListProjectType" runat="server" 
                                                AutoPostBack="True" 
                                                OnSelectedIndexChanged="DropDownListProjectType_SelectedIndexChanged" 
                                                ToolTip="Select Project Type" Width="125">
                                                <asp:ListItem>All</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="DropDownListProjectStatus" runat="server" 
                                                AutoPostBack="True" 
                                                OnSelectedIndexChanged="DropDownListProjectStatus_SelectedIndexChanged" 
                                                ToolTip="Select Project Status" Width="125">
                                                <asp:ListItem>All</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <%--<asp:DropDownList ID="DropDownListActive" runat="server" AutoPostBack="True" 
                                                OnSelectedIndexChanged="DropDownListActive_SelectedIndexChanged" 
                                                ToolTip="Select Active Projects" Width="100">
                                                <asp:ListItem>All</asp:ListItem>
                                                <asp:ListItem>Yes</asp:ListItem>
                                                <asp:ListItem>No</asp:ListItem>
                                            </asp:DropDownList>--%>
                                        </td>
                                    </tr>
                                 </table>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" colspan="2">
                            <asp:Label ID="Label1" runat="server" Text="No Results" Visible="false"></asp:Label>
                            <asp:Panel Height="550" ScrollBars="Vertical" ID="Panel1" runat="server" align="left">
                                <asp:Repeater ID="RepeaterProjectList" runat="server">
                                    <HeaderTemplate>
                                        <table style="width: 98%">
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <td>
                                            <table class="myTable" style="width: 100%">
                                                <tr>
                                                    <td style="color:Green;text-align: left;font-weight:bold;font-size:small;width: 80%;">
                                                              <%#Eval("SmallProjectDocument_DocDescription")%>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td style="width: 20%;color: red;text-align:right;font-weight:bold;">
                                                            <a href="Images/FactSheets/<%#Eval("SmallProjectDocument_SiteFaxInfoNote")%>" target="new">
                                                                <asp:Label CssClass="style14" ID="LabelLink" runat="server" Text="view project page" Visible='<%# Eval("SmallProjectDocument_SiteFaxInfoNote").ToString() != string.Empty %>'></asp:Label></a>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table class="myTable" style="width: 100%">
                                                <tr>
                                                    <td style="color:Black; text-align: left; vertical-align:top; font-size: 11px ">                                                        
                                                            <asp:Label CssClass="style11" ID="Label5" runat="server" Text="PI No: "></asp:Label><%#Eval("SmallProjectDocument_DocVisualId")%>
                                                    </td>
                                                    <td style="color:Black; text-align: left; vertical-align:top; font-size: 11px ">                                                     
                                                            <asp:Label CssClass="style11" ID="Label13" runat="server" Text="Regional Commission: "></asp:Label>
                                                            Central Savannah
                                                    </td>
                                                    <td style="color:Black; text-align: left; vertical-align:top; font-size: 11px ">                                                        
                                                            <asp:Label CssClass="style11" ID="Label10" runat="server" Text="Original Project Budget: "></asp:Label><%#Eval("SmallProjectDocument_AddressInfoNote")%>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="color:Black; text-align: left; vertical-align:top; font-size: 11px">                                                       
                                                            <asp:Label CssClass="style11" ID="Label7" runat="server" Text="Regional Project ID: "></asp:Label><%#Eval("SmallProjectDocument_AlternateNumber1")%>
                                                    </td>
                                                    <td style="color:Black; text-align: left; vertical-align:top; font-size: 11px">
                                                        
                                                            <asp:Label CssClass="style11" ID="Label3" runat="server" Text="Type: " /><%#Eval("SmallProjectDocument_MarketSector_Description")%>
                                                    </td>
                                                    <td style="color:Black; text-align: left; vertical-align:top; font-size: 11px">
                                                            <asp:Label CssClass="style11" ID="Label12" runat="server" Text="Current Project Budget: "></asp:Label>
                                                            <%#Eval("SmallProjectDocument_ApproximateValueText")%>
                                                    </td>
                                                </tr>
                                                <tr>
							                        <td style="color:Black; text-align: left; vertical-align:top; font-size: 11px"><asp:Label CssClass="style11" ID="Label9" runat="server" Text="County: "></asp:Label><%#Eval("SmallProjectDocument_OfficeUnit_Description")%> </td>
							
							                        <%--  <td style="color:Black; text-align: left; vertical-align:top; font-size: 11px"><asp:Label CssClass="style11" ID="Label14" runat="server" Text="Estimated Construction Start: "></asp:Label> <%#Eval("SmallProjectDocument_PlannedStartDate", "{0:M/dd/yyyy}")%></td>--%>
                                                    <td style="color:Black; text-align: left; vertical-align:top; font-size: 11px"><asp:HyperLink ID="HyperLink1" NavigateUrl='<%#Eval("SmallProjectDocument_PhoneInfoNote")%>' target="_blank" runat="server"><asp:Label CssClass='<%#(String.IsNullOrEmpty(Eval("SmallProjectDocument_PhoneInfoNote").ToString()) ? "style11" : "style10")%>' ID="Label6" runat="server" Text="Project Progress Photos"></asp:Label></asp:HyperLink></td>

						                        </tr>
						                        <tr>
							                        <td style="color:Black; text-align: left; vertical-align:top; font-size: 11px"><asp:Label CssClass="style11" ID="Label11" runat="server" Text="Congressional District: "></asp:Label> <%#Eval("SmallProjectDocument_ManagerCode_Description")%></td>
							                        <td style="color:Black; text-align: left; vertical-align:top; font-size: 11px"><asp:Label CssClass="style11" ID="Label8" runat="server" Text="Band: "></asp:Label><%#Eval("SmallProjectDocument_ServiceType_Description")%> </td>
							                        <td style="color:Black; text-align: left; vertical-align:top; font-size: 11px"></td>							
						                        </tr>
						                        <tr>					
							                        <td colspan="3" style="color:Black; text-align: left; vertical-align:top; font-size: 11px"><asp:Label CssClass="style11" ID="Label4" runat="server" Text="Project Description: "></asp:Label><%#Eval("SmallProjectDocument_DocTitle")%></td>
						                        </tr>
                                            </table>

                                        </td>
                                    </ItemTemplate>
                                    <SeparatorTemplate>
                                        <tr>
                                            <td>
                                                <br></br>
                                            </td>
                                        </tr>
                                    </SeparatorTemplate>
                                    <FooterTemplate>
                                        </table></FooterTemplate>
                                </asp:Repeater>
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
    </td>
</asp:Content>
