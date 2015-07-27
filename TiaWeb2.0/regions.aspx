<%@ Page Title="" Language="C#" MasterPageFile="~/TIA.Master" AutoEventWireup="true"
    CodeBehind="regions.aspx.cs" Inherits="TiaWeb2._0.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style11
        {
            color: #000000;
        }

        #aspnetForm .style7 td table tr td{
            text-align:left;
        }
    </style>
    <!--[if lt IE 10]>
    <style type="text/css">
        #aspnetForm .style7 td table tr td{
            text-align:left;
        }
    </style>
<![endif]-->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>--%>
    <asp:UpdatePanel ID="MyUpdatePanel" runat="server">
        <ContentTemplate>
            <td height="482" colspan="2" align="left" class="regionsT">
                <table width="100%">
                    <tr>
                        <td><p class="style17">View Projects by Region Below </p></td>
                    </tr>
                </table>            
                <img src="Images/Body_1b.jpg" height="600" usemap="#Map2" id="Image1" border="0.1" />
            </td>
            <span class="rvBudgetedText regionText">$380,828,512</span>
            <span class="rvRevenueText regionText"><asp:Literal runat="server" ID="rvRevenue" /></span>
            <span class="rvProjectsText regionText"><asp:Literal runat="server" ID="rvProjects" /></span>
            <span class="csBudgetedText regionText">$538,965,884</span>
            <span class="csRevenueText regionText"><asp:Literal runat="server" ID="csRevenue" /></span>
            <span class="csProjectsText regionText"><asp:Literal runat="server" ID="csProjects" /></span>
            <span class="hgBudgetedText regionText">$255,524,067</span>
            <span class="hgRevenueText regionText"><asp:Literal runat="server" ID="hgRevenue" /></span>
            <span class="hgProjectsText regionText"><asp:Literal runat="server" ID="hgProjects" /></span>
            <map name="Map2" id="Map2">
                <area alt="Tia" shape="circle" coords="41, 192, 6" title="Total TIA Funds Budgeted represent only the projects to be funded from the regional share, 75% of region's total TIA tax revenues." href="rivervalley.aspx" target="_self" onmouseover="MM_swapImage('Image1','','Images/Body_1a-10.jpg',1)"
                    onmouseout="MM_swapImgRestore()"/>
                <area alt="Tia" shape="circle" coords="42, 223, 6" title="Total TIA Tax Revenue Collected to Date represents the total amount of TIA revenue collected." href="rivervalley.aspx" target="_self" onmouseover="MM_swapImage('Image1','','Images/Body_1a-10.jpg',1)"
                    onmouseout="MM_swapImgRestore()"/>
                <area shape="poly" coords="21, 143, 17, 160, 18, 256, 27, 270, 264, 270, 272, 263, 271, 162, 260, 145"
                    href="rivervalley.aspx" target="_self" onmouseover="MM_swapImage('Image1','','Images/Body_2b.jpg',1)"
                    onmouseout="MM_swapImgRestore()" />
                <area shape="poly" coords="218, 431, 214, 398, 225, 372, 238, 347, 238, 334, 237, 325, 238, 312, 232, 300, 227, 285, 235, 276, 250, 275, 267, 274, 279, 269, 292, 275, 306, 281, 315, 286, 326, 297, 332, 304, 335, 318, 339, 329, 362, 328, 365, 394, 349, 394, 330, 378, 287, 380, 272, 373, 257, 381, 256, 420, 220, 430"
                    href="rivervalley.aspx" target="_self" onmouseover="MM_swapImage('Image1','','Images/Body_2b.jpg',1)"
                    onmouseout="MM_swapImgRestore()" />
                <area alt="Tia" shape="circle" coords="134, 504, 6" title="Total TIA Funds Budgeted represent only the projects to be funded from the regional share, 75% of region's total TIA tax revenues." href="heartofgeorgia.aspx" target="_self" onmouseover="MM_swapImage('Image1','','Images/Body_3b.jpg',1)"
                    onmouseout="MM_swapImgRestore()" />
                <area alt="Tia" shape="circle" coords="137, 536, 6" title="Total TIA Tax Revenue Collected to Date represents the total amount of TIA revenue collected." href="heartofgeorgia.aspx" target="_self" onmouseover="MM_swapImage('Image1','','Images/Body_3b.jpg',1)"
                    onmouseout="MM_swapImgRestore()" />
                <area shape="poly" coords="120, 463, 110, 472, 109, 568, 115, 587, 415, 586, 420, 564, 420, 469, 411, 462"
                    href="heartofgeorgia.aspx" target="_self" onmouseover="MM_swapImage('Image1','','Images/Body_3b.jpg',1)"
                    onmouseout="MM_swapImgRestore()" />
                <area shape="poly" coords="401, 370, 429, 369, 435, 358, 416, 329, 475, 295, 516, 290, 532, 286, 553, 291, 561, 320, 566, 354, 587, 381, 562, 414, 595, 464, 560, 470, 513, 425, 522, 393, 472, 412, 399, 397, 401, 370"
                    href="heartofgeorgia.aspx" target="_self" onmouseover="MM_swapImage('Image1','','Images/Body_3b.jpg',1)"
                    onmouseout="MM_swapImgRestore()" />
                <area alt="Tia" shape="circle" coords="468, 71, 6" title="Total TIA Funds Budgeted represent only the projects to be funded from the regional share, 75% of region's total TIA tax revenues." href="centralsavannah.aspx" target="_self" onmouseover="MM_swapImage('Image1','','Images/Body_4b.jpg',1)"
                    onmouseout="MM_swapImgRestore()" />
                <area alt="Tia" shape="circle" coords="469, 101, 6" title="Total TIA Tax Revenue Collected to Date represents the total amount of TIA revenue collected." href="centralsavannah.aspx" target="_self" onmouseover="MM_swapImage('Image1','','Images/Body_4b.jpg',1)"
                    onmouseout="MM_swapImgRestore()" />
                <area shape="poly" coords="466, 31, 445, 38, 445, 137, 456, 152, 702, 151, 755, 147, 756, 41, 753, 32"
                    href="centralsavannah.aspx" target="_self" onmouseover="MM_swapImage('Image1','','Images/Body_4b.jpg',1)"
                    onmouseout="MM_swapImgRestore()" />
                <area shape="poly" coords="461, 219, 485, 266, 534, 264, 556, 271, 575, 296, 581, 292, 584, 257, 499, 167, 477, 173, 465, 212"
                    href="centralsavannah.aspx" target="_self" onmouseover="MM_swapImage('Image1','','Images/Body_4b.jpg',1)"
                    onmouseout="MM_swapImgRestore()" />
                    
            </map>
            <table width="528" border="0" cellspacing="0" cellpadding="10">
                <tr bgcolor="#FFFFFF">
                    <td height="44">
                        &nbsp;</td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
