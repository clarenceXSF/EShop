$(function () {
    $('.show-more a').click(function () {
        var tmp_val = $(this).attr("val");
        var $showBlock = $(".result-body[val='" + tmp_val + "']");
        if ($showBlock.hasClass("heightauto"))
            $showBlock.removeClass("heightauto");
        else
            $showBlock.addClass("heightauto");
    })
    ShowTypeList();//图书分类显示
});
//首页左导航栏显示
function ShowTypeList() {
    $.ajax({
        url: '/Type/FindBookType',
        type: 'POST',
        dataType: 'json',
        async: true,
        success: function (data) {
            if (data != null) {
                //console.log("分类导航" + data);
                for (var i = 0; i < data.length; i++) {
                    $("#cateone").append("<a href=\"/GoodsShow/Index?type=" + data[i].Id + "\">" + data[i].TypeName + "</a>");
                }
            }
        },
        error: function (xhr, textStatus, thrown) {
            console.log("请求异常：" + xhr.status + "  " + textStatus + "  " + thrown);
        }
    });
}