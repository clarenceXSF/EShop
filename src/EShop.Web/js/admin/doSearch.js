$(function () {
    $(".editSearch").click(function (event) {
        var href = $(this).attr("data-url");
        try {
            location.href = href;
        } catch (err) {
            alert(err);
        }
    });
    $(".delSearch").click(function (event) {
        var href = $(this).attr("data-url");
        try {
            var typeContent = $(this).parents("tr").children("td:eq(2)").text();
            var alterMess = new EShop("确定要删除内容<strong class='am-text-danger'>" + typeContent + "</strong>吗?");
            var confirmFunc = function () {
                location.href = href;
            }
            alterMess.confirm(confirmFunc);
        } catch (err) {
            alert(err);
        }
    });
});

//快捷模糊查询
function searchType() {
    var content = $('#searchText').val();
    location.href = "FindBySearchText?content=" + content;
}
//添加项目
function AddSearch() {
    window.location = "../Search/AddSearch";
}

$(function () {
    function validate($dom) {
        var v = $dom.val();
        var id = $dom.attr("id");
        var flag = true;
        switch (id) {
            case "typeContent":
                $("#typeContent_prompt").html("&nbsp;");
                if (v == "") {
                    $("#typeContent_prompt").removeClass().addClass("am-text-danger am-icon-close").html("热搜内容不能为空！");
                    flag = false;
                } else {
                    $("#typeContent_prompt").removeClass().addClass("am-text-success am-icon-check").html("输入正确");
                }
                break;
            default:
                break;
        }
        return flag;
    }

    $("#typeContent").blur(function () {
        validate($(this));
    });

    $("#AddForm").submit(function () {
        var flag = true;
        $(this).find("input").each(function (i, ele) {
            if (!validate($(ele))) {
                flag = false;
            }
        });
        if (flag === false) {
            var alterMess = new EShop("<label class='am-text-danger'>输入存在错误，提交失败</label>");
            alterMess.alert();
        }
        return flag;
    });
    $("#EditForm").submit(function () {
        var flag = true;
        $(this).find("input").each(function (i, ele) {
            if (!validate($(ele))) {
                flag = false;
            }
        });
        if (flag === false) {
            var alterMess = new EShop("<label class='am-text-danger'>输入存在错误，提交失败</label>");
            alterMess.alert();
        }
        return flag;
    });
});