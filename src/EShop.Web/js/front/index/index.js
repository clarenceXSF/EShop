$(document).ready(function (e) {
    var tmpval = window.location.href;
    if (tmpval.indexOf("ucenter") >= 0) {
        $("#tbar-light a").removeAttr("target");
    }
    $("a").each(function (index, element) {
        if ($(this).attr("href") == '#') $(this).attr("href", "javascript:void(0);");
    });
    $('#tbar-light').mouseover(function(){
	    $(this).find(".my-lgt").show();
	    $(this).css("background","#fff");
    });
	$('#tbar-light').mouseout(function(){
		$(this).find(".my-lgt").hide();
	    $(this).css("background","#f2f2f2");
    });
    $('#tbar-website').mouseover(function(){
		$(this).find('.s-nvg').show();
		$(this).css("background","#fff");
	});
	$('#tbar-website').mouseout(function(){
		$(this).find('.s-nvg').hide();
		$(this).css("background","#f2f2f2");
	});
	$("a").each(function(index, element) {
        if($(this).attr("href")=="#")$(this).attr("href","javascript:void(0);");
    });
	$("#loginOut").click(function () {
	    location.href = "/Account/LoginOut";
	})
});