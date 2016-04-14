var headcate={};
$(document).ready(function(e) {
    $(".left-sidebar ul li").mouseover(function(){
		$(".left-sidebar ul li").removeClass("on");
		$(this).addClass("on");
		var tmpn=$(this).attr("n");
		headcate.on();
	});
	$(".left-sidebar").mouseover(function(){headcate.on();})
	.mouseout(function(){headcate.out();});
	$(".z-menu .ul2").mouseover(function(){headcate.on()})
	.mouseout(function(){headcate.out()});
	/*
	$(".wit .categorys").mouseover(function(){
		$(".z-menu")	
	});*/
	
});
headcate.on=function(){
	$(".z-menu .ul2").stop();
	$(".z-menu .ul2").show();
}
headcate.out=function(){
	$(".z-menu .ul2").stop().animate({opacity:1},200,function(){
		$(".z-menu .ul2").hide();
		$(".left-sidebar ul .ll").removeClass("on");
	});	
}