$(window).resize(function(){
  if (matchMedia('only screen and (max-width: 800px)').matches) {
		$('#sideNavBox').appendTo('#mainbody');
	}
	else
	{
		$('#sideNavBox').insertBefore('#mainbody');

	}

	var windowsize = $( window ).width();
			
	 if (windowsize > 319 && windowsize < 370) {
		$(".ms-srch-sb > input").css("width", "250px");
	}
	if (windowsize > 370 && windowsize < 400) {
		//alert($( window ).width());
		$(".ms-srch-sb > input").css("width", "300px");
	}
	if (windowsize > 400 && windowsize < 550) {
		//alert($( window ).width());
		$(".ms-srch-sb > input").css("width", "330px");
	}

});