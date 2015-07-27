<%@ Page Title="" Language="C#" MasterPageFile="~/TIA.Master" AutoEventWireup="true"
    CodeBehind="index.aspx.cs" Inherits="TiaWeb2._0.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 37px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="MyUpdatePanel" runat="server">
        <ContentTemplate>
            <td height="403" align="left">
            <table>
            <tr><td><p style="color: #1B5F8A; text-align: left;font-family:Verdana, Arial, Helvetica, sans-serif;font-size:x-large; font-weight:bold">Transportation Investment Act of 2010<br />
                        <%--<span style="color: #1B5F8A; text-align: left;font-family:Verdana, Arial, Helvetica, sans-serif;font-size:medium; font-weight:normal">Program Overview</span>--%></p>
            </td>
            </tr>
            <tr><td><p style="text-align:left; padding-left: 25px;">
                <span class="totBudgetedText statusText">$1,175,318,463</span>
                <span class="totRevenueText statusText"><asp:Literal runat="server" ID="totRevenue" /></span>
                <span class="totProjectsText statusText"><asp:Literal runat="server" ID="totProjects" /></span>
                        <img src="Images/Home-graphic-b.jpg" alt="Program Overview" usemap="#Map2" style="width:660px" />
                    </p>
            </td>
            </tr>
            <tr><td align="left">
            <h2 style="color: #1B5F8A;font-family:Verdana;font-size:large; text-align:left">Program Overview</h2>
            <p  style="color: black; font-family:Verdana;font-size:small; text-align:left">
            The Transportation Investment Act (TIA) Referendum was passed by Georgia voters in the regions of Central Savannah River Area, Heart of Georgia - Altamaha and River Valley. These three regions will implement a one percent regional sales tax over a ten year period to fund transportation improvements. Georgia DOT is responsible for the management of the budget, schedule, execution and delivery of all Projects contained in the Approved Investment Lists. Georgia DOT is collaborating with local and state agencies to ensure timely delivery of TIA projects, with a structure that focuses on high-level project management, intergovernmental coordination, transparency and successful program delivery. 
            </p>
            <h2 style="color: #1B5F8A;font-family:Verdana;font-size:large; text-align:left">Program Funding</h2>
                
            <p  style="color: black; font-family:Verdana;font-size:small; text-align:left"> 
            Collection of TIA funds began on January 1, 2013. Funds are collected by the Georgia Department of Revenue (DoR). DoR will collect and enforce the special district transportation sales and use tax for the use and benefit of the Special District imposing the special district transportation sales and use tax. Georgia State Financing and Investment Commission (GSFIC) will disburse the proceeds of the special district transportation sales and use tax as soon as practicable after collection. GSFIC will transfer the 25% distributions for the local government allocations monthly. Funds for building projects were first distributed in early Spring 2013.
                </p>
                
                <p style="color: black; font-family:Verdana;font-size:small; text-align:right">
                    <a href="regions.aspx" style="color: #1B5F8A; font-size: large; text-align: right; font-weight: 700;" target="_blank">View TIA Project Information </a>
                    <br />
                </p>
                
            </td>
            </tr>
            <tr>
            <%-- 
                <td class="auto-style1"><p style="text-align:right; padding-left: 25px;">
                        <a href="regions.aspx" onmouseout="MM_swapImgRestore()" 
                            onmouseover="MM_swapImage('Project Info Link','','Images/TIA_info_2.jpg',1)">
                        <img src="Images/TIA_info_1.jpg" width="528" height="31" id="Project Info Link" />
                        </a>
                        <br />
                    </p>
            </td>
                --%>
            </tr>
            </table>
            </td>
            <map name="Map2" id="Map2">
                <area alt="circle" shape="circle" coords="56, 89, 10"
                    title="Total TIA Funds Budgeted represent only the projects to be funded from the regional share, 75% of region's total TIA tax revenues." />
                <area alt="tia" shape="circle" coords="56, 126, 10" title="Total TIA Tax Revenue Collected to Date represents the total amount of TIA revenue collected." />
            </map>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
