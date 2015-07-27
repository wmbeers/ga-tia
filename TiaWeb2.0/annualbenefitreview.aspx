<%@ Page Title="" Language="C#" MasterPageFile="~/TIA.Master" AutoEventWireup="true" CodeBehind="annualbenefitreview.aspx.cs" Inherits="TiaWeb2._0.WebForm21" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="ctl00_PlaceHolderMain_ctl00__ControlWrapper_RichHtmlField" class="style16"
        style="display: inline" aria-labelledby="ctl00_PlaceHolderMain_ctl00_label" align="left">
    <!-- RHTML: Page Content One -->
    <div id="ctl00_PlaceHolderMain_ctl00_label1" style='display: none'>
        Page Content One</div>
    <div id="ctl00_PlaceHolderMain_ctl00__ControlWrapper_RichHtmlField1" class="style16"
        style="display: inline" aria-labelledby="ctl00_PlaceHolderMain_ctl00_label" 
            align="left">
        <h1 style="color: #1B5F8A; text-align: left;font-family:Verdana;font-size:x-large;">
        Citizen Review Panel Annual Benefit Review Reports </h1>

                <p style="color: #1B5F8A; font-family:Verdana;font-size:large;">
            <asp:Accordion ID="Accordion3" runat="server" SelectedIndex="-1" RequireOpenedPane="false"
                CssClass="accordion" HeaderCssClass="accordionHeader3" HeaderSelectedCssClass="accordionHeaderSelected4"
                ContentCssClass="accordionContent3">
                <Panes>
                    <asp:AccordionPane ID="AccordionPane3" runat="server">
                        <Header>
                            2014 Citizen Review Panel Reports by Region
                        </Header>
                        <Content>
                            <ul class="EditToolbarCustom-ListofLinks">
                                <li> <a href="Images/FactSheets/2014 RV CRP Annual Report.pdf" target="_blank" style="color: #1B5F8A; font-size:medium">
                                    2014 River Valley Citizen Review Panel Report </a></li>

                                <li> <a href="Images/FactSheets/2014 HOGA CRP Annual Report.pdf" target="_blank" style="color: #1B5F8A; font-size:medium">
                                    2014 Heart of Georgia-Altamaha Citizen Review Panel Report </a></li>

                                <li><a href="Images/FactSheets/2014 CSRA CRP Annual Report.pdf" target="_blank" style="color: #1B5F8A; font-size:medium">
                                    2014 Central Savannah River Area Citizen Review Panel Report </a></li>

                        </Content>
                    </asp:AccordionPane>
                </Panes>
            </asp:Accordion>


        <br />
        <br />
            <asp:Accordion ID="Accordion2" runat="server" SelectedIndex="-1" RequireOpenedPane="false"
                CssClass="accordion" HeaderCssClass="accordionHeader3" HeaderSelectedCssClass="accordionHeaderSelected4"
                ContentCssClass="accordionContent3">
                <Panes>
                    <asp:AccordionPane ID="AccordionPane2" runat="server">
                        <Header>
                            2013 Citizen Review Panel Reports by Region
                        </Header>
                        <Content>
                            <ul class="EditToolbarCustom-ListofLinks">
                                <li> <a href="Images/FactSheets/River%20Valley%20CRP%20Report.pdf" target="_blank" style="color: #1B5F8A; font-size:medium">
                                    2013 River Valley Citizen Review Panel Report </a></li>

                                <li> <a href="Images/FactSheets/Heart%20of%20Georgia%20Altamaha%20Citizen's%20Review%20Panel%20Report%202013.pdf" target="_blank" style="color: #1B5F8A; font-size:medium">
                                    2013 Heart of Georgia-Altamaha Citizen Review Panel Report </a></li>

                                <li><a href="Images/FactSheets/CSRA%20CRP%202013%20Final%20Report.pdf" target="_blank" style="color: #1B5F8A; font-size:medium">
                                    2013 Central Savannah River Area Citizen Review Panel Report </a></li>

                        </Content>
                    </asp:AccordionPane>
                </Panes>
            </asp:Accordion>


        <p style="color: #1B5F8A; font-family:Verdana;font-size:large;">
                        <asp:Accordion ID="Accordion1" runat="server" SelectedIndex="-1" RequireOpenedPane="false"
                CssClass="accordion" HeaderCssClass="accordionHeader3" HeaderSelectedCssClass="accordionHeaderSelected4"
                ContentCssClass="accordionContent3">
                <Panes>
                    <asp:AccordionPane ID="AccordionPane1" runat="server">
                        <Header>
                            Citizen Review Panel Meeting Minutes
                        </Header>
                        <Content>
                            <ul class="EditToolbarCustom-ListofLinks">
                                <li> <a href="Images/FactSheets/HOGA - CRP Meeting Minutes 02-27-14.pdf" target="_blank" style="color: #1B5F8A; font-size:medium">
                                    2/27/14 - HOGA – CRP Meeting Minutes </a></li>



                        </Content>
                    </asp:AccordionPane>
                </Panes>
            </asp:Accordion>
            <br />
            <br />
            <br />
        </p>
    </div>
    </div>
</asp:Content>
