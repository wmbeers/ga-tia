<script  type="text/javascript" src="/Style Library/JS/jquery.galleriffic.js"></script>
<script  type="text/javascript" src="/Style Library/JS/jquery.opacityrollover.js"></script>
		
		
				<div id="page">
			<div id="container">				
				<div id="gallery" class="content">
					<div id="controls" class="controls" ></div>
					<div class="slideshow-container">
						<div id="loading" class="loader" ></div>
						
						<div id="slideshow" class="slideshow">
						
						</div>
						<div id="caption" class="caption-container"></div>

 					  <div id="caption-close" class="controls-close"><a>Close Photo Gallery</a></div>

					</div>
					
				</div>
               
				<div id="thumbs" class="navigation">
				
					<ul class="thumbs noscript" id="add-pic">
					</ul>
				</div>
			     <div id="caption-descr" class="caption-container" ></div>
				<div style="clear: both;"></div>
			</div>
		</div>
<style>
//galleriffic-2.css
div.content {
	/* The display of content is enabled using jQuery so that the slideshow content won't display unless javascript is enabled. */
	
}
div.content a, div.navigation a {
	text-decoration: none;
	color: #777;
}
div.content a:focus, div.content a:hover, div.content a:active {
	text-decoration: underline;
}
div.controls {
	margin-top: 5px;
	
	height: 25px;
}
div.controls a {
	padding: 5px;
}
div.ss-controls {
	float: left;
}
div.nav-controls {
//	float: right;
	float: center;
}
div.slideshow-container {
	position: relative;
	clear: both;
	//height: 502px; /* This should be set to be at least the height of the largest image in the slideshow */	
	height: 500px;
		
}
div.loader {
	position: absolute;
	top: 0;
	left: 0;
	background-image: url('/Style Library/Images/galleriffic/loader.gif');
	background-repeat: no-repeat;
	background-position: center;
	
	//height: 502px; /* This should be set to be at least the height of the largest image in the slideshow */
	//height: 733px;
	height: 550px;
	width: 550px;
	
}
div.slideshow span.image-wrapper {
	display: block;
	position: absolute;
	top: 0;
	left: 0;
}
div.slideshow a.advance-link {
	display: block;
	
	//height: 502px; /* This should be set to be at least the height of the largest image in the slideshow */
	//width: 550px;
	height: 550px;
	//line-height: 502px; /* This should be set to be at least the height of the largest image in the slideshow */
	line-height: 0px;
	text-align: center;
	
}
div.slideshow a.advance-link:hover, div.slideshow a.advance-link:active, div.slideshow a.advance-link:visited {
	text-decoration: none;
}
div.slideshow img {
	vertical-align: middle;
	border: 2px solid #ccc;
	//height:420px;
	height:100%;
	width: auto;
    max-height: 400px;
}
div.download {
  float: bottom;
	
	
}

div.caption-container {
	position: relative;
	clear: left;
	//height: 75px;
	height: 60px;
	opacity: 0.5;
	
	
}
span.image-caption {
	display: block;
	position: absolute;
	position: center;
	top: 10;
	left: 10;
	
}
div.caption {
	//padding: 50px;
	padding: 0px;
	//border: 4px solid black;
	
}
div.image-title {
	font-weight: bold;
	font-size: 1.0em;
	float:center;
	
	//display:none;
	background-color: black;
	width: 520px;
	height: 60px;
	
}
div.image-desc {
	line-height: 1.3em;
	padding-top: 12px;
}
div.navigation {
	/* The navigation style is set using jQuery so that the javascript specific styles won't be applied unless javascript is enabled. */
}
ul.thumbs {
	clear: both;
	margin: 0;
	padding: 0;
}
ul.thumbs li {
	float: left;
	padding: 0;
	margin: 5px 10px 5px 0;
	list-style: none;
}
a.thumb {
	padding: 2px;
	display: block;
	border: 1px solid #ccc;
}
ul.thumbs li.selected a.thumb {
	background: #000;
}
a.thumb:focus {
	outline: none;
}
ul.thumbs img {
	border: none;
	display: block;
	height: 75px;
    width: auto;

}
div.pagination {
	clear: both;
}
div.navigation div.top {
	margin-bottom: 12px;
	height: 11px;
}
div.navigation div.bottom {
	margin-top: 12px;
}
div.pagination a, div.pagination span.current, div.pagination span.ellipsis {
	display: block;
	float: left;
	margin-right: 2px;
	padding: 4px 7px 2px 7px;
	border: 1px solid #ccc;
}
div.pagination a:hover {
	background-color: #eee;
	text-decoration: none;
}
div.pagination span.current {
	font-weight: bold;
	background-color: #000;
	border-color: #000;
	color: #fff;
}
div.pagination span.ellipsis {
	border: none;
	padding: 5px 0 3px 2px;
}
div.addcaption
{
  float: right;

}

div.symbol-download
{
   float: left;
   padding: 2px 2px 2px 2px;
   color: white;
   font-weight: bold;
   font-size: 1em;
  // text-decoration: underline;
   right: 10px;
   
 
}

div.symbol-title
{
  //float: left;
  color: white;
   padding: 2px 2px 2px 2px;
   font-size: 1.5em;


}

div.caption-description
{
      
     /* padding:200px 0px 0px 560px; */
     padding:400px 0px 0px 0px;
     height: 100px;
	 max-width: 800px;

}

div.controls-close
{
      
    /* padding:370px 0px 0px 420px;*/
    padding:370px 0px 0px 0px;
}

</style>

<script type="text/javascript">

/*
$(document).ready(function(){
       

     var mylocation ="PhotoGallery_sample3/";
      
     GetGDOTPhotoGalleryImages(mylocation);
  
				
});

*/

function SetGDOTGalleryImages()
{

// We only want these styles applied when javascript is enabled
				$('div.navigation').css({ 'float' : 'bottom'});
			
				$('div.content').css('display','none');
				
   				// Initially set opacity on thumbs and add
				// additional styling for hover effect on thumbs
				var onMouseOutOpacity = 0.67;
				$('#thumbs ul.thumbs li').opacityrollover({
					mouseOutOpacity:   onMouseOutOpacity,
					mouseOverOpacity:  1.0,
					fadeSpeed:         'fast',
					exemptionSelector: '.selected'
				});
				
				$('#thumbs ul.thumbs li').click(function()
				{
			    
				    $('div.content').css('display','block');
				    
				});
				
				$('#caption-close').click(function()
				{
					$('div.content').css('display','none');

				
				});
				



				// Initialize Advanced Galleriffic Gallery
				var gallery = $('#thumbs').galleriffic({
					delay:                     2500, // in milliseconds
					numThumbs:                 14, // The number of thumbnails to show page
					preloadAhead:              2,
					enableTopPager:            false,
					enableBottomPager:         true,
					maxPagesToShow:            10, // The maximum number of pages to display in either the top or bottom pager				
					imageContainerSel:         '#slideshow',
					controlsContainerSel:      '#controls',
					captionContainerSel:       '#caption',
					loadingContainerSel:       '#loading',
					renderSSControls:          true,
					renderNavControls:         false,
					playLinkText:              'Play Photo Gallery',
					pauseLinkText:             'Pause Slideshow',
					prevLinkText:              '&lsaquo; Previous Photo',
					nextLinkText:              'Next Photo &rsaquo;',
					nextPageLinkText:          'Next &rsaquo;',
					prevPageLinkText:          '&lsaquo; Prev',
					enableHistory:             false,
					autoStart:                 false,
					syncTransitions:           true,
					defaultTransitionDuration: 900,
					onSlideChange:             function(prevIndex, nextIndex) {
						// 'this' refers to the gallery, which is an extension of $('#thumbs')
						this.find('ul.thumbs').children()
							.eq(prevIndex).fadeTo('fast', onMouseOutOpacity).end()
							.eq(nextIndex).fadeTo('fast', 1.0);
					},
					onPageTransitionOut:       function(callback) {
						this.fadeTo('fast', 0.0, callback);
					},
					onPageTransitionIn:        function() {
						this.fadeTo('fast', 1.0);
					}
				});
				
				//gallery

}
function GetGDOTPhotoGalleryImages(){
       
        var method = "GetListItems";
        var list = "Slider Images";
		
		var folderName = "/SliderImages/Photo Gallery/PhotoGallery_sample2/";

        var fieldsToRead = "<ViewFields>" +
                                "<FieldRef Name='EncodedAbsUrl' />" +
								"<FieldRef Name='IsActive' />" +
								"<FieldRef Name='Title' />" +
								"<FieldRef Name='URL' />" +
								"<FieldRef Name='NewWindow' />" +
								"<FieldRef Name='RoutingRuleDescription' />" +								
                            "</ViewFields>";
        //var query = "<Query></Query>";
		var query = "<Query><Where><Eq><FieldRef Name='IsActive' /><Value Type='Boolean'>1</Value></Eq></Where></Query>";
		var i =0;
        $().SPServices({
                operation: method,
                async: false,
				webURL: "/",				
                listName: list,
                CAMLViewFields: fieldsToRead,
                  CAMLQuery: query,
				  CAMLQueryOptions: "<QueryOptions><Folder>" + folderName + "</Folder></QueryOptions>",
                    completefunc: function (xData, Status) {                         
                        $(xData.responseXML).SPFilterNode("z:row").each(function() {                             
                           AddLiToUlImg($(this).attr("ows_EncodedAbsUrl"), $(this).attr("ows_Title"), i, $(this).attr("ows_RoutingRuleDescription"));
                          i++;
                        });                
                    }
        });
}


function GetGDOTPhotoGalleryImages(ilocation){
       
        var method = "GetListItems";
        var list = "Slider Images";
        //var mylocation = "PhotoGallery_sample3/";
        var mylocation = ilocation;
		
		var folderName = "/SliderImages/Photo Gallery/" + mylocation;

        var fieldsToRead = "<ViewFields>" +
                                "<FieldRef Name='EncodedAbsUrl' />" +
								"<FieldRef Name='IsActive' />" +
								"<FieldRef Name='Title' />" +
								"<FieldRef Name='URL' />" +
								"<FieldRef Name='NewWindow' />" +
								"<FieldRef Name='RoutingRuleDescription' />" +								
                            "</ViewFields>";
        //var query = "<Query></Query>";
		var query = "<Query><Where><Eq><FieldRef Name='IsActive' /><Value Type='Boolean'>1</Value></Eq></Where></Query>";
		var i =0;
        $().SPServices({
                operation: method,
                async: false,
				webURL: "/",				
                listName: list,
                CAMLViewFields: fieldsToRead,
                  CAMLQuery: query,
				  CAMLQueryOptions: "<QueryOptions><Folder>" + folderName + "</Folder></QueryOptions>",
                    completefunc: function (xData, Status) {                         
                        $(xData.responseXML).SPFilterNode("z:row").each(function() {                             
                           AddLiToUlImg($(this).attr("ows_EncodedAbsUrl"), $(this).attr("ows_Title"), i, $(this).attr("ows_RoutingRuleDescription"));
                          i++;
                        });                
                    }
        });
        
        SetGDOTGalleryImages();
}


function AddLiToUlImg(imgurl, title, i, descr)
{
//<img alt="Texting #1" src="http://devgdotauthoring.dot.ga.gov/SliderImages/Photo%20Gallery/CMO_1377.jpg">
// +  " <div class=\"image-title\"><a target=\"_blank\" href=\"" + imgurl + "\">"   + "<div class=\"symbol-title\"><strong>"+ title + "#" + i + "<br>" +  descr + "</strong></div> " + "<div class=\"symbol-download\"> Download original (&#8595;)</div> " + "</a></div>  "


   var myimgurl = "href=\"" + imgurl;
  var mydescr = "";
   
  if (typeof descr  === "undefined")
  {
     mydescr = '';
     
  }else
  {
     mydescr = descr;
  }


   $("#add-pic").append( 
		  " <li> "
		+ " <a class=\"thumb\" name=\" "+ title +"\" href=\"" + imgurl +  "\" title=\"" + title + "#" + i +"\"> "
		
        + "	<img src=\"" + imgurl   + "\" alt=\" "+ title + "#" + i +"\" /> "
        
	    + " </a> "
	    + " <div class=\"caption\"> "
	    +  " <div class=\"image-title\"><a target=\"_blank\" href=\"" + imgurl + "\">"   + "<div class=\"symbol-title\"><strong>"+ title + "<br></strong></div> " + "<div class=\"symbol-download\"> Download original (&#8595;)</div> " + "</a></div>  "
	    + "<div class=\"caption-description\">" + mydescr + "</div>"
		+ " </li> "
			
	 );			 
    	
}
</script>