$(document).ready(function(){ 

jQuery.support.cors = true;

 	$('#gdottabs').responsiveTabs({
        rotate: false,
        startCollapsed: 'accordion',
        collapsible: 'accordion',
        setHash: true,
	});
    //Announcements, Key Services, Trending and Learn More button clicks
      // $('#btnVisitPressRoom').click(function() {window.location.href = '/PS/Public';return false;});
	  // $('#btnKeyServicesViewMore').click(function() {window.location.href = '/AboutGeorgia/Pages/KeyServices.aspx';return false;});
      // $('#btnTwitterViewMore').click(function() {window.open('https://twitter.com/GADeptofTrans', '_blank');return false;});
      // $('#btnLearnMore').click(function() {window.location.href = '/AboutGeorgia/Pages/TravelSmart.aspx';return false;});      
    
$(".msg_body").hide();	        
$(".msg_head").click(function () {
    $(this).next(".msg_body").slideToggle(600);
});

if (window.location.href.indexOf("AboutGDOT") > -1){
	$("[id$='RootAspMenu'] span[class='menu-item-text']").each(function(){	
	if($(this).text().trim() == "About GDOT")
	        $(this).closest('li').children().show()
	//alert($(this).text().trim());
	});
}
else
{
	$("[id$='RootAspMenu'] span[class='menu-item-text']").each(function(){	
	if($(this).text().trim() == "About GDOT")
	        $(this).closest('li').children().hide()
	//alert($(this).text().trim());
	});
}

	/*	$.ajax({
			type: "GET",
			async: false,
			cache: false,
			url: "http://gdot-dv-isosp14.tgdot.tst.local:9090/GoogleAPI/index",
			success: function (data) {
				alert(data);
			},
			error: function (jqXHR, textStatus, errorThrown) {
				alert(jqXHR.responseText);			}
		});*/

	/*$.getJSON("http://gdot-dv-isosp14.tgdot.tst.local:9090/GoogleAPI/index?count=5", function(data) {
		 $.each(data, function(key, val ) {				
			//alert(val['pageTitle']);
			buildUltag(val['pageTitle'], val['pagePath']);
		});		
	})
	.error(function(jqXHR, textStatus, errorThrown) {        
    });*/
    GetTop5Pages();
});

function buildUltag(title, url)
{
	$(".top5pages").append("<li><a href='"+ url +"'>"+ title +"</a></li>");		
}

function GetTop5Pages(){
       
        var method = "GetListItems";
        var list = "Top 5 Pages";		
        var fieldsToRead = "<ViewFields>" +
								"<FieldRef Name='Title' />" +
                                "<FieldRef Name='PagePath' />" +
								"<FieldRef Name='TotalViews' />" +
                            "</ViewFields>";
        var query = "<Query><Where><Neq><FieldRef Name='Title' /><Value Type='Text'>Welcome to the GDOT</Value></Neq></Where><OrderBy><FieldRef Name='TotalViews' Ascending='False' /></OrderBy></Query>";        
        $().SPServices({
                operation: method,
                async: false,  
                listName: list,
                webURL: "/",
                CAMLViewFields: fieldsToRead,
                CAMLRowLimit: 5,
                  CAMLQuery: query,				  
                    completefunc: function (xData, Status) {                         
                        $(xData.responseXML).SPFilterNode("z:row").each(function() {                             
                            //var url = ($(this).attr("ows_Title"));
							buildUltag($(this).attr("ows_Title"), $(this).attr("ows_PagePath"));
                            //alert($(this).attr("ows_Title") + " - " + $(this).attr("ows_Url") + " - " + $(this).attr("ows_IsExternal"));
                        });                
                    }
        });
}

