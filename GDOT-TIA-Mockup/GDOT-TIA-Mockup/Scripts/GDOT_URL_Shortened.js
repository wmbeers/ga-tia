$(document).ready(function(){ 
	GetGDOTLongURL();
	
function GetGDOTLongURL(){
	var newurl;
	var method = "GetListItems";
        var list = "Short Urls";		
        var fieldsToRead = "<ViewFields>" +
								"<FieldRef Name='Title' />" +
                                "<FieldRef Name='LongURL' />" +								
                            "</ViewFields>";
        var query = "<Query><Where><Contains><FieldRef Name='Title' /><Value Type='Text'>" + window.location.href.substring(window.location.href.lastIndexOf('/') + 1)  + "</Value></Contains></Where></Query>";
        $().SPServices({
                operation: method,
                async: false,  
                listName: list,
                webURL: "/",
                CAMLViewFields: fieldsToRead,
                  CAMLQuery: query,				  
                    completefunc: function (xData, Status) {                         
                        $(xData.responseXML).SPFilterNode("z:row").each(function() { 
                        	var shorturl = window.location.host.toUpperCase() + $(this).attr("ows_Title").toUpperCase();
                        	
                        	if(window.location.href.toUpperCase().indexOf(shorturl) > -1)
                        	{                        		
                        		window.location.replace($(this).attr("ows_LongURL"));
                        	}
                        });                
                    }
        });        
    }
});
