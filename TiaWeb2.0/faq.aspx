<%@ Page Title="" Language="C#" MasterPageFile="~/TIA.Master" AutoEventWireup="true"
    CodeBehind="faq.aspx.cs" Inherits="TiaWeb2._0.WebForm9" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="MyUpdatePanel" runat="server">
        <ContentTemplate>
    <div id="bodyColumn" class="pageColumn">
        <div>
            <div align="left" id="ctl00_PlaceHolderMain_ctl00__ControlWrapper_RichHtmlField"
                class="ms-rtestate-field" style="display: inline;">
                <h1 style="color: #1B5F8A; text-align: left;font-family:Verdana;font-size:x-large;">
                    Frequently Asked Questions</h1>
                <p style="color: Black;font-family:Verdana;font-size:small;">
                    Please read the frequently asked questions listed below for more information about
                    the Transportation Referendum. Click on a question from one of the categories below
                    to view the answer.
                </p>
                <h2 align="left" style="color: #1B5F8A;font-family:Verdana;font-size:large;"><a href="Images/FactSheets/TIA%20-%20FAQ.pdf" style="color: #1B5F8A; font-family:Verdana;font-size:large; text-align:left" target="_blank">Discretionary Funding FAQ</a></h2>
            </div>
            <!-- WPZ: Top -->
            <table width="100%" cellpadding="0" cellspacing="0" border="0" align="left">
                <tr>
                    <td id="MSOZoneCell_WebPartWPQ3" valign="top" class="s4-wpcell-plain">
                        <table class="s4-wpTopTable" border="0" cellpadding="0" cellspacing="0" width="100%">
                            <tr>
                                <td valign="top">
                                        <div id="Div2" class="ms-WPBody" align="left" style="color: Black;">
                                        <h2 style="color: #1B5F8A;font-family:Verdana;font-size:large;" align="left"">
                                           Project Delivery</h2>
                                    </div>
                                </td>
                            </tr>
                        </table>
                        <div class="ms-PartSpacingVertical">
                        </div>
                    </td>
                </tr>
                <tr>
                    <td id="MSOZoneCell_WebPartWPQ9" valign="top" class="s4-wpcell-plain">
                        <table class="s4-wpTopTable" border="0" cellpadding="0" cellspacing="0" width="100%">
                            <tr>
                                <td valign="top" align="left">
                                    <div id="WebPartWPQ9" class="ms-WPBody" align="left">
                                        <div id="ctl00_ctl23_g_34365224_b074_45b3_a1ff_bc9b971f862f_accordion0">
                                            <asp:Accordion ID="Accordion1" runat="server" SelectedIndex="-1" RequireOpenedPane="false"
                                                CssClass="accordion" HeaderCssClass="accordionHeader" HeaderSelectedCssClass="accordionHeaderSelected"
                                                ContentCssClass="accordionContent">
                                                <Panes>
                                                    <asp:AccordionPane ID="AccordionPane1" runat="server">
                                                        <Header>
                                                            Who collects the special district transportation sales and use tax?
                                                        </Header>
                                                        <Content>
                                                            TIA directs the state revenue commissioner to exclusively administer, collect and
                                                            enforce the special district transportation sales and use tax for the use and benefit
                                                            of the Special District imposing the special district transportation sales and use
                                                            tax and to disburse the proceeds of the special district transportation sales and
                                                            use tax as soon as practicable after collection to GSFIC.
                                                        </Content>
                                                    </asp:AccordionPane>
                                                    <asp:AccordionPane ID="AccordionPane2" runat="server">
                                                        <Header>
                                                            Who maintains the special district transportation sales and use tax proceeds for
                                                            the Special Districts?</Header>
                                                        <Content>
                                                            TIA directs GSFIC to maintain and administer the special district transportation
                                                            sales and use tax proceeds in a trust fund, separate from other funds of GSFIC,
                                                            on behalf of the Special District imposing the special district transportation sales
                                                            and use tax, to ensure the proper application of the proceeds for the Approved Investment
                                                            List(s) for each Special District.
                                                        </Content>
                                                    </asp:AccordionPane>
                                                    <asp:AccordionPane ID="AccordionPane3" runat="server">
                                                        <Header>
                                                            Who is responsible for the management of the Projects?</Header>
                                                        <Content>
                                                            GDOT is responsible for the management of the budget, schedule, execution and delivery
                                                            of all Projects contained in the Approved Investment Lists.
                                                        </Content>
                                                    </asp:AccordionPane>
                                                    <asp:AccordionPane ID="AccordionPane4" runat="server">
                                                        <Header>
                                                            Can the special district transportation sales and use tax funds be used for Projects
                                                            other than the TIA Projects?</Header>
                                                        <Content>
                                                            The proceeds of the special district transportation sales and use tax are not funds
                                                            of the State and are instead held in trust by GSFIC on behalf of the Special Districts
                                                            imposing the special district transportation sales and use tax. The local governments
                                                            within each Special District can use the 25% portion of the tax funds disbursed
                                                            to them by GSFIC on any other transportation project in the region.
                                                        </Content>
                                                    </asp:AccordionPane>
                                                    <asp:AccordionPane ID="AccordionPane5" runat="server">
                                                        <Header>
                                                            Who determines the tax revenue projections?</Header>
                                                        <Content>
                                                            The Annual Revenue Projection is an estimate of the monthly special district transportation
                                                            sales and use tax proceeds by Special District for subsequent fiscal years and is
                                                            prepared by the Georgia State University Fiscal Research Center.
                                                        </Content>
                                                    </asp:AccordionPane>
                                                    <asp:AccordionPane ID="AccordionPane6" runat="server">
                                                        <Header>
                                                            Who determines whether GDOT or the local government will deliver the Projects?</Header>
                                                        <Content>
                                                            In managing the budget, schedule, execution, and delivery of the Projects contained
                                                            in the Approved Investment Lists, GDOT exclusively determines whether a Project
                                                            is to be designed and constructed by GDOT, by or on behalf of a local government,
                                                            or by another public or private entity. Regardless of the delivery agent, GDOT is
                                                            alone responsible for requesting disbursement of special district transportation
                                                            sales and use tax proceeds from GSFIC upon the completion of a Project or Project
                                                            Element, reporting progress and performance in the execution, schedule, and delivery
                                                            of Projects on the Approved Investment Lists to GSFIC, and providing adequate record-keeping
                                                            to allow for an annual audit in accordance with O.C.G.A. § 48-8-249(d).
                                                        </Content>
                                                    </asp:AccordionPane>
                                                    <asp:AccordionPane ID="AccordionPane7" runat="server">
                                                        <Header>
                                                            When does GSFIC generate the Annual Revenue Projection?</Header>
                                                        <Content>
                                                            GSFIC provides an Annual Revenue Projection for the subsequent fiscal years to GDOT
                                                            no later than December 31st of each year. The Annual Revenue Projection includes
                                                            monthly collection estimates by Special District. GSFIC will provide updated revenue
                                                            projections on a quarterly basis or more frequently if monthly collections vary
                                                            more than five percent (5%) from projections.
                                                        </Content>
                                                    </asp:AccordionPane>
                                                    <asp:AccordionPane ID="AccordionPane8" runat="server">
                                                        <Header>
                                                            Who develops the Annual Program Draw Schedules?</Header>
                                                        <Content>
                                                            TIA directs GSFIC to maintain and administer the special district transportation
                                                            sales and use tax proceeds in a trust fund, separate from other funds of GSFIC,
                                                            on behalf of the Special District imposing the special district transportation sales
                                                            and use tax, to ensure the proper application of the proceeds for the Approved Investment
                                                            List(s) for each Special District.
                                                        </Content>
                                                    </asp:AccordionPane>
                                                    <asp:AccordionPane ID="AccordionPane9" runat="server">
                                                        <Header>
                                                            What happens if the special district transportation sales and use tax proceeds are
                                                            insufficient to complete the Projects?</Header>
                                                        <Content>
                                                            <p>
                                                                The obligation of GSFIC to pay or reimburse any Eligible Project Cost is expressly
                                                                limited solely to the amount of special district transportation sales and use tax
                                                                proceeds remitted to GSFIC by GDOR net of the local government distributions.
                                                            </p>
                                                            <p>
                                                                Should the proceeds of the special district's transportation sales and use tax be
                                                                insufficient to meet the payment requests of GDOT as determined by GSFIC in its
                                                                sole discretion, GSFIC's payment obligation shall terminate without further obligation
                                                                of GSFIC to the extent that the obligations exceed the availability of such proceeds.
                                                            </p>
                                                            <p>
                                                                GSFIC's certification as to the availability of special district transportation
                                                                sales and use tax proceeds is conclusive.
                                                            </p>
                                                            <p>
                                                                Similarly, the obligation of GDOT to pay or reimburse any Eligible Project Cost
                                                                is expressly limited to the amount of special district transportation sales and
                                                                use tax proceeds remitted to GDOT by GSFIC and designated by GDOT for the Project
                                                            </p>
                                                        </Content>
                                                    </asp:AccordionPane>
                                                    <asp:AccordionPane ID="AccordionPane12" runat="server">
                                                        <Header>
                                                            Has the TIA Program established minimum reserves?</Header>
                                                        <Content>
                                                            <p>
                                                                In order to safeguard the availability of special district transportation sales
                                                                and use tax proceeds a reserve fund has been established by GSFIC for each Special
                                                                District. Reserves may be used throughout the year to meet extraordinary cash requirements
                                                                of GDOT in excess of the annual expenditure projections included in the Annual Program
                                                                Draw Schedule or in the event monthly revenue collections fall below the Annual
                                                                Revenue Projection. Reserves will be replenished as soon as special district transportation
                                                                sales and use tax proceeds allow.
                                                            </p>
                                                            <p>
                                                                GSFIC and GDOT have established a reserves policy. It is subject to modification
                                                                depending on Program needs.
                                                            </p>
                                                        </Content>
                                                    </asp:AccordionPane>
                                                    <asp:AccordionPane ID="AccordionPane10" runat="server">
                                                        <Header>
                                                            In the event that funds are not available, is there a priority of payments?</Header>
                                                        <Content>
                                                            In the event GDOT's monthly cash needs for Projects on the Approved Investment Lists
                                                            exceed the balance of special district transportation sales and use tax available,
                                                            GDOT will establish a prioritization of payment schedule. GDOT is currently working
                                                            on the priority of payment policy.
                                                        </Content>
                                                    </asp:AccordionPane>
                                                    <asp:AccordionPane ID="AccordionPane11" runat="server">
                                                        <Header>
                                                            Is the TIA Program audited?</Header>
                                                        <Content>
                                                            <p>
                                                                GSFIC has the right to review and audit the use of funds dispensed to GDOT upon
                                                                receipt of a complaint or as otherwise warranted. In addition, an annual audit,
                                                                paid for by the net tax proceeds available for the Projects on the Approved Investment
                                                                List for each Special District and conducted by an independent auditing firm as
                                                                selected by GSFIC. The audit will include a schedule which shows for each Project
                                                                the original estimated cost, the current estimated cost, amounts expended in prior
                                                                years, and amounts expended in the current year.
                                                            </p>
                                                            <p>
                                                                It is recognized that Projects may include funds from sources other than special
                                                                district transportation sales and use tax proceeds. For purposes of the annual audit,
                                                                GDOT shall identify the source of all funds, including funds from sources other
                                                                than special district transportation sales and use tax proceeds.
                                                            </p>
                                                        </Content>
                                                    </asp:AccordionPane>
                                                </Panes>
                                            </asp:Accordion>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                        </table>
                        <div class="ms-PartSpacingVertical">
                        </div>
                    </td>
                </tr>
                <tr>
                    <td id="MSOZoneCell_WebPartWPQ4" valign="top" class="s4-wpcell-plain">
                        <table class="s4-wpTopTable" border="0" cellpadding="0" cellspacing="0" width="100%">
                            <tr>
                                <td valign="top">
                                    <div id="WebPartWPQ4" class="ms-WPBody" align="left" style="color: Black;">
                                        <h2 style="color: #1B5F8A;font-family:Verdana;font-size:large;" align="left"">
                                            Accountability and Oversight</h2>
                                    </div>
                                </td>
                            </tr>
                        </table>
                        <div class="ms-PartSpacingVertical">
                        </div>
                    </td>
                </tr>
                <tr>
                    <td id="MSOZoneCell_WebPartWPQ11" valign="top" class="s4-wpcell-plain">
                        <table class="s4-wpTopTable" border="0" cellpadding="0" cellspacing="0" width="100%">
                            <tr>
                                <td valign="top">
                                    <div id="WebPartWPQ11" class="ms-WPBody" align="left">
                                        <asp:Accordion ID="Accordion2" runat="server" SelectedIndex="-1" RequireOpenedPane="false"
                                            CssClass="accordion" HeaderCssClass="accordionHeader" HeaderSelectedCssClass="accordionHeaderSelected"
                                            ContentCssClass="accordionContent">
                                            <Panes>
                                                <asp:AccordionPane ID="AccordionPane13" runat="server">
                                                    <Header>Is there citizen oversight for the use of these funds?
                                                    </Header>
                                                    <Content>Yes. The law created a Citizens Review Panel for each Special District in which
                                                    the tax was approved. This panel, made up of Special District citizens, is charged
                                                    with assessing the progress of Projects included on the Approved Investment Lists.
                                                    Five panel members are appointed by the Speaker of the House and the Lt. Governor.
                                                    The panel must issue an annual report to the General Assembly which includes Project
                                                    progress and expenditures.
                                                    </Content>
                                                </asp:AccordionPane>
                                                <asp:AccordionPane ID="AccordionPane14" runat="server">
                                                    <Header>What happens if Project costs exceed the Project budget?
                                                    </Header>
                                                    <Content> Project controls are in place to limit cost overruns. GDOT is committed to designing
                                                    Projects according to scope, schedule and budget as set forth in the Approved Investment
                                                    Lists. The Special District Citizens Review Panels— appointed by the state’s leadership—will
                                                    provide oversight and monitor how dollars are spent.
                                                    </Content>
                                                </asp:AccordionPane>
                                                <asp:AccordionPane ID="AccordionPane15" runat="server">
                                                    <Header>What happens if we meet the collection max before the end
                                                        of the ten years?
                                                    </Header>
                                                    <Content> If the special district transportation sales and use tax collected reaches the projected
                                                    amount before the 10 years, the tax will stop. Any additional funds collected during
                                                    that first calendar quarter will be distributed via the discretionary pot of funding.
                                                    </Content>
                                                </asp:AccordionPane>
                                                <asp:AccordionPane ID="AccordionPane16" runat="server">
                                                    <Header>What happens if we don’t have the money to finish all of
                                                        the Projects (most likely those Projects in the final funding band) before or at
                                                        the end of the 10-year period?
                                                    </Header>
                                                    <Content>Every Project on the Approved Investment Lists must be built, and in the event available
                                                    funding for Projects yet to be built is not enough, then the likely approach would
                                                    be to scale back the remaining Projects according to the available funds. However,
                                                    cash flow projections will be closely monitored during the entire period to help
                                                    prevent and resolve these issues.
                                                    </Content>
                                                </asp:AccordionPane>
                                                <asp:AccordionPane ID="AccordionPane17" runat="server">
                                                    <Header>How will transparency be achieved?
                                                    </Header>
                                                    <Content>Establishing and implementing this new TIA Project delivery program is an exercise
                                                    in cooperation, collaboration and communication. GDOT will continue to coordinate
                                                    with its partner agencies, local governments, the leadership of Regional Commissions,
                                                    and the Special District Citizens Review Panels to achieve efficiency and transparency.
                                                    In addition, periodic reports will be made to the Georgia General Assembly and to
                                                    the public, via the TIA website, that will provide updates on Projects and expenditures.
                                                    </Content>
                                                </asp:AccordionPane>
                                            </Panes>
                                        </asp:Accordion>
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                 <tr>
                    <td id="Td1" valign="top" class="s4-wpcell-plain">
                        <table class="s4-wpTopTable" border="0" cellpadding="0" cellspacing="0" width="100%">
                            <tr>
                                <td valign="top">
                                    <div id="Div1" class="ms-WPBody" align="left" style="color: Black;">
                                    </div>
                                </td>
                            </tr>
                        </table>
                        <div class="ms-PartSpacingVertical">
                        </div>
                    </td>
                </tr>
            </table>
            <div align="left">
            <br />
                <h2></h2>
            </div>
        </div>
        </ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>
