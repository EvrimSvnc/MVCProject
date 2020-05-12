
/*===========
	search-form
===================*/

$(document).ready(function(){
    $(".search_link").click(function(){
        $(".search_form_wrap_fixed").toggleClass("show");
    });
	 $(".search_link").click(function(){
        $("body").toggleClass("search_fixed");
    });
	$(".search_close").click(function(){
        $(".search_form_wrap_fixed").removeClass("show");
		$("body").removeClass("search_fixed");
    });
});

/*===========
	slider-psot
===================*/

$(document).ready(function() {
  $("#slider-post").owlCarousel();
});



/*=============
	Popular-psot-slider
===========================*/


$(document).ready(function() {
 
  var owl = $("#popular_articles");
 
  owl.owlCarousel({
      items : 1, //1 items above 1000px browser width
      itemsDesktop : [1000,1], //1 items between 1000px and 901px
      itemsDesktopSmall : [900,1], // betweem 900px and 601px
      itemsTablet: [600,1], //1 items between 600 and 0
      itemsMobile : false, // itemsMobile disabled - inherit from itemsTablet option
	  autoPlay : true
  });
 });
 
 
 /*==============================
	Fullwidth-slider-post
=======================================*/
$(function(){ 
  var owl = $("#fullwidth-slider");
  owl.owlCarousel({
      items : 3,
     itemsDesktop : [1000,3],
      itemsDesktopSmall : [900,2],
      itemsTablet: [600,1],
	  autoPlay : true
  });
 });



/*=============
	Back to top
===========================*/

 
 $(document).ready(function(){

	// hide #back-top first
	$("#back-top").hide();
	
	// fade in #back-top
	$(function () {
		$(window).scroll(function () {
			if ($(this).scrollTop() > 100) {
				$('#back-top').fadeIn();
			} else {
				$('#back-top').fadeOut();
			}
		});

		// scroll body to 0px on click
		$('#back-top a').click(function () {
			$('body,html').animate({
				scrollTop: 0
			}, 800);
			return false;
		});
	});

});
