<%@ Page Title="" Language="C#" MasterPageFile="~/TIA.Master" AutoEventWireup="true"
    CodeBehind="meetingspresentation.aspx.cs" Inherits="TiaWeb2._0.WebForm15" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- RHTML: Page Content One -->
    <div id="ctl00_PlaceHolderMain_ctl00_label" style='display: none' align="left">
        Page Content One</div>
    <div id="ctl00_PlaceHolderMain_ctl00__ControlWrapper_RichHtmlField" class="style16"
        style="display: inline" align="left">
        <h1 style="color: #1B5F8A; text-align: left;font-family:Verdana;font-size:x-large;">
            Meeting
            Presentations</h1>
        <a name="regional"></a>
<%--        <h2 style="color: #1B5F8A;font-family:Verdana;font-size:large; padding-left: 5px">
            Citizen’s Review Panel Presentation</h2>--%>
        <p style="color: #1B5F8A; padding-left: 5px">

            <br />
        </p>
        <p style="color: #1B5F8A; padding-left: 5px">
            <asp:Accordion ID="Accordion3" runat="server" SelectedIndex="-1" RequireOpenedPane="false"
                CssClass="accordion" HeaderCssClass="accordionHeader3" HeaderSelectedCssClass="accordionHeaderSelected4"
                ContentCssClass="accordionContent3" Height="476px">
                <Panes>
                    <asp:AccordionPane ID="AccordionPane3" runat="server">
                        <Header>
                            2014 Presentations
                        </Header>
                        <Content>
                            <ul class="EditToolbarCustom-ListofLinks" style="margin-left: 80px">

                                <li><a target="_blank" style="color: #1B5F8A; font-size:medium" href="Images/FactSheets/12-9-2014%20Transportation%20Summit%20-%20Athens.pdf">
                                    12/9/2014 – 2014 Transportation Summit </a></li>
                                
                                <li><a target="_blank" style="color: #1B5F8A; font-size:medium" href="Images/FactSheets/FINAL%20DRAFT%20-%2025Sep2014%20-%20TIA%20-%20Local%20and%20Small%20Business%20Outreach%20-%20Jekyll.pdf">
                                    9/25/2014 - Jekyll Island DBE Conference </a></li>
                                
                                <li><a target="_blank" style="color: #1B5F8A; font-size:medium" href="Images/FactSheets/9-2-2014%20Rotary%20in%20Columbia%20County%20GA.pdf">
                                    9/2/2014 - Columbia County Rotary </a></li>
                                
                                <li><a target="_blank" style="color: #1B5F8A; font-size:medium" href="Images/FactSheets/Batch%203%20Industry%20Forum%20Mtg%20FINAL.pdf">
                                    8/22/14 - Industry Forum for Batch 3 Design Advertisement  </a></li>                         
                                
                                <ul style="margin-left: 80px"</ul>
                                <li><a target="_blank" style="color: #1B5F8A; font-size:medium" href="Images/FactSheets/08-22-2014%20TIA%20Industry%20Forum%20QA%20Session%20-%20Final.pdf">
                                    Meeting Q&A </a></li></ul>  
                                                             
                                <li><a target="_blank" style="color: #1B5F8A; font-size:medium" href="Images/FactSheets/September 2014 Letting Final.pdf">
                                    8/21/2014 – TIA Project Lettings, State Transportation Board Meeting  </a></li>
                                                           
                                <li><a target="_blank" style="color: #1B5F8A; font-size:medium" href="Images/FactSheets/Columbus%20TSPLOST%20Update%20April%2024,%202014%20-%20River%20Valley.pdf">
                                    4/24/2014 – Update on Columbus TIA Projects  </a></li>
                                                              
                                <li><a target="_blank" style="color: #1B5F8A; font-size:medium" href="Images/FactSheets/Local%20and%20Small%20Business%20Outreach%20-%20Statewide%20-%20Macon%20-%2009Apr2014.pdf">
                                    4/9/2014 – Local and Small Business Update, Macon Georgia  </a></li>                            
                                                               
                                <li><a target="_blank" style="color: #1B5F8A; font-size:medium" href="Images/FactSheets/Meeting%20Presentation.pdf">
                                    2/25/2014 – Industry Forum Informational Meeting for Band 2 Design Projects, Atlanta, GA    </a></li>
                                
                            
                                    <ul style="margin-left: 80px"</ul>
                                    <li><a href="Images/FactSheets/Meeting%20Q-A.pdf" 
                                            target="_blank" style="color: #1B5F8A; font-size:medium">
                                            Meeting Q&A </a></li></ul>                               

                                <li><a 
                                    target="_blank" style="color: #1B5F8A; font-size:medium" href="Images/FactSheets/21Feb2014%20-%20Presentation%20-%20Local%20and%20Small%20Business%20Outreach%20-%20CSRA%20-%20Augusta.pdf">
                                    2/21/2014 - Local and Small Business Outreach in Augusta </a></li>                                                   
                                
                            <ul style="margin-left: 80px"</ul>
                                <li><a href="Images/FactSheets/21Feb2014%20-%20Agenda%20-%20Local%20and%20Small%20Business%20Outreach%20-%20CSRA%20-%20Augusta.pdf" 
                                    target="_blank" style="color: #1B5F8A; font-size:medium">
                                    Agenda - CSRA     </a></li></ul>
                                
                            <ul style="margin-left: 80px"</ul>
                                <li><a href="Images/FactSheets/21Feb2014%20-%20Handout%20-%20CSRA%20Projects%20-%20Local%20and%20Small%20Business%20Outreach%20-%20CSRA%20-%20Augusta.pdf" 
                                    target="_blank" style="color: #1B5F8A; font-size:medium">
                                    Handout - CSRA Projects </a></li></ul>

                            <ul style="margin-left: 80px"</ul>
                                <li><a href="Images/FactSheets/21Feb2014%20-%20Handout%20-%20HOGA%20Projects%20-%20Local%20and%20Small%20Business%20Outreach%20-%20CSRA%20-%20Augusta.pdf" 
                                    target="_blank" style="color: #1B5F8A; font-size:medium">
                                    Handout - HOGA Projects  </a></li></ul>

                            <ul style="margin-left: 80px"</ul>
                                <li><a href="Images/FactSheets/21Feb2014%20-%20Handout%20from%20Augusta%20Richmond%20County%20-%20Local%20Small%20Business%20Outreach.pdf" 
                                    target="_blank" style="color: #1B5F8A; font-size:medium">
                                    Handout - Augusta Richmond County  </a></li></ul>
                            </ul>

                        </Content>
                    </asp:AccordionPane>
                </Panes>
            </asp:Accordion>
        <p style="color: #1B5F8A; padding-left: 5px">
            <asp:Accordion ID="Accordion2" runat="server" SelectedIndex="-1" RequireOpenedPane="false"
                CssClass="accordion" HeaderCssClass="accordionHeader3" HeaderSelectedCssClass="accordionHeaderSelected4"
                ContentCssClass="accordionContent3">
                <Panes>
                    <asp:AccordionPane ID="AccordionPane2" runat="server">
                        <Header>
                            2013 Presentations
                        </Header>
                        <Content>
                            <ul class="EditToolbarCustom-ListofLinks">
                                <li> <a href="Images/FactSheets/11-20-2013%20committee%20of%20the%20whole.pdf" target="_blank" style="color: #1B5F8A; font-size:medium">
                                    11/20/2013 – Presentation to the GDOT Board Committee of the Whole </a></li>

                                <li> <a href="Images/FactSheets/Laurens%200000833%20PHOH%20handouts%20-%2011.2013.pdf" target="_blank" style="color: #1B5F8A; font-size:medium">
                                    11/7/2013 – Public Hearing Open House Materials, New Oconee River Crossing,  Laurens County, PI No. 0000833 </a></li>

                                <li><a href="Images/FactSheets/Transportation%20Summit%202013.pdf" target="_blank" style="color: #1B5F8A; font-size:medium">
                                    11/7/2013 – Transportation Summit, Atlanta, GA </a></li>

                                <li><a href="Images/FactSheets/10-31-2013%20Regional%20Transportation%20Summit%20v2.pdf" target="_blank" style="color: #1B5F8A; font-size:medium">
                                    10/13/2013 - Regional Transportation Summit Presentation, Columbus, GA</a></li>
                                
                                <li><a href="http://www.southgatech.edu/index.cfm?PageID=207&NewsID=3075" target="_blank" style="color: #1B5F8A; font-size:medium">
                                    8/8/2013 - TIA River Valley Region Citizen’s Review Panel, Americus, GA</a></li>
                                
                                <li><a href="Images/FactSheets/CRPMeeting-3-15-13.pdf" target="_blank" style="color: #1B5F8A; font-size:medium">
                                    3/15/2013 - Citizen’s Review Panel Presentation, Macon, GA</a> </li>

                        </Content>
                    </asp:AccordionPane>
                </Panes>
            </asp:Accordion>
        </p>
<%--        <h2 style="color: Gray">
            Regional Commission / Chamber of Commerce Presentations</h2>
        <ul class="EditToolbarCustom-ListofLinks">
            <li><a href="Images/FactSheets/TIADeliv-RC.pdf" target="_blank" style="color: #1B5F8A">
                Transportation Referendum 2012 Spring Regional Commission Forum</a></li>
        </ul>
        <h2 style="color: Gray">
            General Presentations</h2>
        <ul class="EditToolbarCustom-ListofLinks">
            <li><a href="Images/FactSheets/BasicTIAPresentation.pdf" target="_blank" style="color: #1B5F8A">
                Transportation Investments in Georgia</a> </li>
        </ul>
        <div class="ruler">
        </div>
        <a name="Industry"></a>
        <h2 style="color: Gray">
            Industry Briefing Information <span class="EditToolbarCustom-LinkDescriptiveText">8/15/12</span>
        </h2>
        <p style="color: black">
            This briefing highlighted general roles and responsibilities of the agencies involved
            and outlined the steps for industry consultants interested in submitting qualifications
            for the Request for Proposals (RFP) short list.
        </p>
        <p style="color: black">
            If you missed the briefing or need a refresher please view the following information
            given to attendees. <a href="Images/FactSheets/TIAIndustryBriefingAgenda.pdf" target="_blank"
                style="color: #1B5F8A">Agenda</a><a name="presentations"> | </a><a href="Images/FactSheets/TIAIndustryBriefingPresentation-8-15-12.pdf"
                    target="_blank" style="color: #1B5F8A">Presentation</a><a name="presentations"> |
            </a><a href="Images/FactSheets/TIABriefingSign-In.pdf" target="_blank" style="color: #1B5F8A">
                Sign-in Sheet</a>
        </p>--%>
        <div>
            <div class="ruler">
            </div>
            <asp:Accordion ID="Accordion1" runat="server" SelectedIndex="-1" RequireOpenedPane="false"
                CssClass="accordion" HeaderCssClass="accordionHeader3" HeaderSelectedCssClass="accordionHeaderSelected4"
                ContentCssClass="accordionContent3">
                <Panes>
                    <asp:AccordionPane ID="AccordionPane1" runat="server">
                        <Header>
                            2012 Presentations
                        </Header>
                        <Content>
                            <ul class="EditToolbarCustom-ListofLinks">
                                <li><a href="Images/FactSheets/BasicTIAPresentation.pdf" target="_blank" style="color: #1B5F8A">
                                   Transportation Investments in Georgia</a> </li>
                                <li><a href="Images/FactSheets/CCColumbiaCounty-10-1-12.pdf" target="_blank" style="color: #1B5F8A">
                                   10/1/12 - Columbia County Chamber of Commerce</a></li>
                                <li><a href="Images/FactSheets/RVRC%20meeting%208-22-12.pdf" target="_blank" style="color: #1B5F8A">
                                   8/22/12 - River Valley Regional Commission</a></li>
                                <li><a href="Images/FactSheets/CSRA%20RC%20meeting%208-21-12.pdf" target="_blank" style="color: #1B5F8A">
                                   8/21/12 - Central Savannah River Area</a> <span class="EditToolbarCustom-LinkDescriptiveText"></li>
                                <li><a href="Images/FactSheets/HOGA%20RC%20meeting%208-20-12.pdf" target="_blank" style="color: #1B5F8A">
                                   8/20/12 - Heart of Georgia</a> </li>
                                <li><a href="Images/FactSheets/TIAIndustryBriefingPresentation-8-15-12.pdf" target="_blank" style="color: #1B5F8A">
                                    8/15/12 - Pre –RFQ Industry Briefing Program Management for TIA Program</a></li>
                                <li><a href="Images/FactSheets/TIADelivery.pdf" target="_blank" style="color: #1B5F8A">
                                    Transportation Investment Act Delivery Framework</a> </li>
                                <li><a href="Images/FactSheets/TIADeliv-RC.pdf" target="_blank" style="color: #1B5F8A">
                                    Transportation Referendum 2012 Spring Regional Commission Forum</a></li></ul>
                        </Content>
                    </asp:AccordionPane>
                </Panes>
            </asp:Accordion>
        </div>
    </div>
</asp:Content>
