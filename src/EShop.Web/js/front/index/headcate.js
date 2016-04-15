var headcate={};
$(document).ready(function(e) {
    $(".left-sidebar ul li").mouseover(function(){
		$(".left-sidebar ul li").removeClass("on");
		$(this).addClass("on");
		var tmpn=$(this).attr("n");
		headcate.on();
	});
	
});