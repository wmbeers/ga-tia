<%@ Page Title="" Language="C#" MasterPageFile="~/TIA.Master" AutoEventWireup="true"
    CodeBehind="photogallery.aspx.cs" Inherits="TiaWeb2._0.WebForm24" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- RHTML: Page Content One -->
    <div id="ctl00_PlaceHolderMain_ctl00_label" style='display: none'>
        Page Content One</div>
    <div id="ctl00_PlaceHolderMain_ctl00__ControlWrapper_RichHtmlField" class="style16"
        style="display: inline" aria-labelledby="ctl00_PlaceHolderMain_ctl00_label" align="left">
        <h1 style="color: #1B5F8A; text-align: left;font-family:Verdana;font-size:x-large;">
            Photo Gallery</h1>
        <p style="color: #1B5F8A; font-family:Verdana;font-size:medium;">

            &nbsp;<br />

            <asp:Accordion ID="Accordion6" runat="server" SelectedIndex="-1" RequireOpenedPane="false"
                CssClass="accordion" HeaderCssClass="accordionHeader3" HeaderSelectedCssClass="accordionHeaderSelected4"
                ContentCssClass="accordionContent3">
                <Panes>
                    <asp:AccordionPane ID="AccordionPane6" runat="server">
                        <Header>
                            Program Wide
                        </Header>
                        <Content>
                            <ul class="EditToolbarCustom-ListofLinks">
                            <li><a target="_blank" style="color: #1B5F8A" href="http://dev.ga-tia.com/Photo">
                               Events</a><br /></li>
                                                            
                        </Content>
                    </asp:AccordionPane>
                </Panes>
            </asp:Accordion>

            <asp:Accordion ID="Accordion4" runat="server" SelectedIndex="-1" RequireOpenedPane="false"
                CssClass="accordion" HeaderCssClass="accordionHeader3" HeaderSelectedCssClass="accordionHeaderSelected4"
                ContentCssClass="accordionContent3">
                <Panes>
                    <asp:AccordionPane ID="AccordionPane4" runat="server">
                        <Header>
                            Central Savannah River
                        </Header>
                        <Content>
                            <ul class="EditToolbarCustom-ListofLinks">
                            <li><a href='http://dev.ga-tia.com/Photo' target="_blank" style="color: #1B5F8A">
                               Events</a><br /></li>
                            
                            <li><a href='"http://dev.ga-tia.com/Photo"' target="_blank" style="color: #1B5F8A">
                              County</a><br /></li>
                            
                            <li><a href="http://dev.ga-tia.com/Photo" target="_blank" style="color: #1B5F8A">
                              Projects</a><br /></li>
                            
                            <li><a href="http://dev.ga-tia.com/Photo" target="_blank" style="color: #1B5F8A">
                               Before</a><br /></li>
                            
                            <li><a href="http://dev.ga-tia.com/Photo" target="_blank" style="color: #1B5F8A">
                               Progress</a><br /></li>
                            
                            <li><a href="http://dev.ga-tia.com/Photo" target="_blank" style="color: #1B5F8A">
                               Complete</a><br /></li>
                            
                                
                        </Content>
                    </asp:AccordionPane>
                </Panes>
            </asp:Accordion>

            <asp:Accordion ID="Accordion2" runat="server" SelectedIndex="-1" RequireOpenedPane="false"
                CssClass="accordion" HeaderCssClass="accordionHeader3" HeaderSelectedCssClass="accordionHeaderSelected4"
                ContentCssClass="accordionContent3">
                <Panes>
                    <asp:AccordionPane ID="AccordionPane2" runat="server">
                        <Header>
                            Heart of Georgia Altamaha
                        </Header>
                        <Content>
                            <ul class="EditToolbarCustom-ListofLinks">
                            <li><a href="http://dev.ga-tia.com/Photo" target="_blank" style="color: #1B5F8A">
                               Events</a><br /></li>
                            
                            <li><a href="http://dev.ga-tia.com/Photo" target="_blank" style="color: #1B5F8A">
                              County</a><br /></li>
                            
                            <li><a href="http://dev.ga-tia.com/Photo" target="_blank" style="color: #1B5F8A">
                              Projects</a><br /></li>
                            
                            <li><a href="http://dev.ga-tia.com/Photo" target="_blank" style="color: #1B5F8A">
                               Before</a><br /></li>
                            
                            <li><a href="http://dev.ga-tia.com/Photo" target="_blank" style="color: #1B5F8A">
                               Progress</a><br /></li>
                            
                            <li><a href="http://dev.ga-tia.com/Photo" target="_blank" style="color: #1B5F8A">
                               Complete</a><br /></li>
                                
                        </Content>
                    </asp:AccordionPane>
                </Panes>
            </asp:Accordion>
        
            <asp:Accordion ID="Accordion5" runat="server" SelectedIndex="-1" RequireOpenedPane="false"
                CssClass="accordion" HeaderCssClass="accordionHeader3" HeaderSelectedCssClass="accordionHeaderSelected4"
                ContentCssClass="accordionContent3">
                <Panes>
                    <asp:AccordionPane ID="AccordionPane5" runat="server">
                        <Header>
                            River Valley
                        </Header>
                        <Content>
                            <ul class="EditToolbarCustom-ListofLinks">
                            <li><a href="http://dev.ga-tia.com/Photo" target="_blank" style="color: #1B5F8A">
                               Events</a><br /></li>
                            
                            <li><a href="http://dev.ga-tia.com/Photo" target="_blank" style="color: #1B5F8A">
                              County</a><br /></li>
                            
                            <li><a href="http://dev.ga-tia.com/Photo" target="_blank" style="color: #1B5F8A">
                              Projects</a><br /></li>
                            
                            <li><a href="http://dev.ga-tia.com/Photo" target="_blank" style="color: #1B5F8A">
                               Before</a><br /></li>
                            
                            <li><a href="http://dev.ga-tia.com/Photo" target="_blank" style="color: #1B5F8A">
                               Progress</a><br /></li>
                            
                            <li><a href="http://dev.ga-tia.com/Photo" target="_blank" style="color: #1B5F8A">
                               Complete</a><br /></li>
                                
                        </Content>
                    </asp:AccordionPane>
                </Panes>
            </asp:Accordion>
        </p>
        
    <!-- RHTML: Page Content One -->
    <div id="ctl00_PlaceHolderMain_ctl00_label0" style='display: none'>
        Page Content One</div>
    <div id="ctl00_PlaceHolderMain_ctl00__ControlWrapper_RichHtmlField0" class="style16"
        style="display: inline" aria-labelledby="ctl00_PlaceHolderMain_ctl00_label" 
            align="left">
            </p>

            </p>
        
        </div>
        <p style="color: #1B5F8A; font-family:Verdana;font-size:medium;">
            &nbsp;<span class="EditToolbarCustom-LinkDescriptiveText"></span></p>
        
        </div>
</asp:Content>
