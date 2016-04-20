var indexban = {};

indexban.init=function(){
    indexban.len = $(".slider-banner > a").length - 1;
	indexban.n=0;
	indexban.t1=300;
	indexban.t2=5000;
	indexban.onoff=true;
	$(".slider-banner > a").each(function(index, element) {
        $(".slider-banner .dian .-h").append("<li class='l1'>"+(index+1)+"</li>");
    });
	$(".slider-banner > a").hide().eq(0).show();
	$(".slider-banner i.last").click(function(){indexban.n--;indexban.run(1);}).mousedown(function(){return false;});
	$(".slider-banner i.next").click(function(){indexban.n++;indexban.run(1);}).mousedown(function(){return false;});
	$(".slider-banner .dian .-h .l1").mouseover(function(){
		indexban.n=Number($(this).text())-1;indexban.run(1);
	});
	indexban.r=window.setInterval(indexban.run,indexban.t2);
	$(".slider-banner").hover(function(){indexban.onoff=false;}
	,function(){indexban.onoff=true;});
	
}
indexban.run=function(obj){
	if(obj!=1){
		if(indexban.onoff==false)return false;
		indexban.n++;
	}
	if(indexban.n>indexban.len)indexban.n=0;
	if(indexban.n<0)indexban.n=indexban.len;
	$("body").attr("nn",indexban.n);
	$(".slider-banner > a").stop().animate({opacity:0},indexban.t1,function(){$(this).hide();});
	$(".slider-banner > a").eq(indexban.n).stop().show().animate({opacity:1},indexban.t1,function(){
		$(".slider-banner .dian .-h .l1").removeClass("on").eq(indexban.n).addClass("on");;
		
	});
}