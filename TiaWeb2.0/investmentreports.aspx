<%@ Page Title="" Language="C#" MasterPageFile="~/TIA.Master" AutoEventWireup="true" CodeBehind="investmentreports.aspx.cs" Inherits="TiaWeb2._0.WebForm19" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- RHTML: Page Content One -->
    <div id="ctl00_PlaceHolderMain_ctl00_label" style='display: none'>
        Page Content One</div>
    <div id="ctl00_PlaceHolderMain_ctl00__ControlWrapper_RichHtmlField" class="style16"
        style="display: inline" aria-labelledby="ctl00_PlaceHolderMain_ctl00_label" align="left">
        <h1 style="color: #1B5F8A; text-align: left;font-family:Verdana;font-size:x-large;">
       Final Investment Reports by Region</h1>
        <p style="color: #1B5F8A; font-family:Verdana;font-size:medium;">
            <a href="Images/FactSheets/CSRA-finalinvestmentlistreport.pdf" target="_blank" 
                style="color: #1B5F8A">Central Savannah River Area Final Investment Report  </a>
            <br />
            <a href="Images/FactSheets/HOG-finalinvestmentlistreport.pdf" target="_blank" 
                style="color: #1B5F8A">Heart of Georgia - Altamaha Final Investment Report </a>
            <br />
            <a href="Images/FactSheets/RiverValley-FinalInvestmentListReport.pdf" target="_blank" 
                style="color: #1B5F8A">River Valley  Final Investment Report </a>
            <br />
        </p>
    </div>
</asp:Content>
