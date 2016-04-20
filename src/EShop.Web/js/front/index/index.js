//$(function () {
//    ShowHotSearch();//热门搜索
//});
$(document).ready(function () {
    ShowHotSearch();//热门搜索
    var tmpval = window.location.href;
    if (tmpval.indexOf("ucenter") >= 0) {
        $("#tbar-light a").removeAttr("target");
    }
    $("a").each(function (index, element) {
        if ($(this).attr("href") == '#') $(this).attr("href", "javascript:void(0);");
    });
    $('#tbar-light').mouseover(function () {
        $(this).find(".my-lgt").show();
        $(this).css("background", "#fff");
    });
    $('#tbar-light').mouseout(function () {
        $(this).find(".my-lgt").hide();
        $(this).css("background", "#f2f2f2");
    });
    $('#tbar-website').mouseover(function () {
        $(this).find('.s-nvg').show();
        $(this).css("background", "#fff");
    });
    $('#tbar-website').mouseout(function () {
        $(this).find('.s-nvg').hide();
        $(this).css("background", "#f2f2f2");
    });
    $("a").each(function (index, element) {
        if ($(this).attr("href") == "#") $(this).attr("href", "javascript:void(0);");
    });
    $("#loginOut").click(function () {
        location.href = "/Account/LoginOut";
    })
});
//热搜显示
function ShowHotSearch() {
    $.ajax({
        url: '/Home/FindHotSearch',
        type: 'POST',
        dataType: 'json',
        async: true,
        success: function (data) {
            if (data != null) {
                console.log("热门搜索" + data);
                for (var i = 0; i < data.length; i++) {
                    $("#hotwords").append("<a href=\"/GoodsShow/Index?keyword=" + data[i].TypeContent + "\" target=\"_blank\"> " + data[i].TypeContent + " </a>");
                }
            }
        },
        error: function (xhr, textStatus, thrown) {
            console.log("请求异常：" + xhr.status + "  " + textStatus + "  " + thrown);
        }
    });
}