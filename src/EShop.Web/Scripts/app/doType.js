$(function () {
    //$("#admin-offcanvas").find("li:eq(0)").children("a").addClass("am-active");
    //$("#admin-offcanvas").find("li:eq(0)").siblings().children("a").removeClass("am-active");
    $(".editType").click(function (event) {
        var href = $(this).attr("data-url");
        try {
            location.href = href;
        } catch (err) {
            alert(err);
        }
    });
    $(".delType").click(function (event) {
        var href = $(this).attr("data-url");
        try {
            var typeName = $(this).parents("tr").children("td:eq(2)").text();
            var alterMess = new EShop("确定要删除类型<strong class='am-text-danger'>" + typeName + "</strong>吗?");
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
function AddType() {
    window.location = "../Type/AddType";
}

$(function () {
    function validate($dom) {
        var v = $dom.val();
        var id = $dom.attr("id");
        var flag = true;
        switch (id) {
            case "typeCode":
                $("#typeCode_prompt").html("&nbsp;");
                var reg = /^[a-zA-Z0-9;]+$/;
                if (v == "") {
                    $("#typeCode_prompt").removeClass().addClass("am-text-danger am-icon-close").html("类型代码不能为空！");
                    flag = false;
                } else if (!reg.test(v)) {
                    $("#typeCode_prompt").removeClass().addClass("am-text-danger am-icon-close").html("类型代码只能由大小写英文和数字组成！");
                    flag = false;
                } else if (!VerifyOnly(v)) { //验证名称是否唯一
                    var oldTypeCode = $("#oldTypeCode").text();
                    if (oldTypeCode != "" && oldTypeCode != null && oldTypeCode == v) {
                        $("#typeCode_prompt").removeClass().addClass("am-text-success am-icon-heart").html("此代码为原类型代码");
                        flag = true;
                    } else {
                        $("#typeCode_prompt").removeClass().addClass("am-text-danger am-icon-close").html("此类型代码已存在，可添加代号以避免重复！");
                        flag = false;
                    }
                } else {
                    $("#typeCode_prompt").removeClass().addClass("am-text-success am-icon-check").html("输入正确");
                }
                break;
            case "typeName":
                $("#typeName_prompt").html("&nbsp;");
                if (v == "") {
                    $("#typeName_prompt").removeClass().addClass("am-text-danger am-icon-close").html("类型名称不能为空！");
                    flag = false;
                } else if (!VerifyOnly(v)) { //验证类型名称是否唯一
                    var oldTypeName = $("#oldTypeName").text();
                    if (oldTypeName != "" && oldTypeName != null && oldTypeName == v) {
                        $("#typeName_prompt").removeClass().addClass("am-text-success am-icon-heart").html("此名称为原类型名称");
                        flag = true;
                    } else {
                        $("#typeName_prompt").removeClass().addClass("am-text-danger am-icon-close").html("此类型名称已存在，可添加代号以避免重复！");
                        flag = false;
                    }
                } else {
                    $("#typeName_prompt").removeClass().addClass("am-text-success am-icon-check").html("输入正确");
                }
                break;
            default:
                break;
        }
        return flag;
    }

    function hasChanged() {
        var flag = false;
        var oldTypeCode = $("#oldTypeCode").text();
        if (oldTypeCode != "" && oldTypeCode != null && oldTypeCode == $("#typeCode").val()) { //存在原类型代码，且与当前类型代码一致（未更改）
            var oldTypeName = $("#oldTypeName").text();
            if (oldTypeName != "" && oldTypeName != null && oldTypeName == $("#typeName").val()) { //存在原类型名称，且与当前类型名称一致（未更改）
                var oldUpImg = $("#oldUpImg").text();
                if (oldUpImg != "" && oldUpImg != null && oldUpImg == $("#upImg").val()) { //存在原目录图片，且与当前目录图片一致（未更改）
                    flag = true;
                } else
                    flag = false;
            } else
                flag = false;
        } else
            flag = false;
        return flag;
    }

    $("#typeCode").blur(function () {
        validate($(this));
    });
    $("#typeName").blur(function () {
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
        $(this).find("textarea").each(function (i, ele) {
            if (!validate($(ele))) {
                flag = false;
            }
        });
        if (flag === false) {
            var alterMess = new EShop("<label class='am-text-danger'>输入存在错误，提交失败</label>");
            alterMess.alert();
        }
        else if (hasChanged()) {
            var alterMess = new EShop("<label class='am-text-warning'>您暂未做任何修改</label><br/>是否返回<span class='am-text-primary'>类型列表页面</span>？");
            var confirmFunc = function () {
                location.href = 'Index';
            }
            alterMess.confirm(confirmFunc);
            flag = false;
        }
        return flag;
    });
});

//验证项目的中文名称和英文名称是否唯一
function VerifyOnly(name) {
    var isOnly = false;
    $.ajax({
        url: 'CheckTheName',
        type: 'POST',
        data: { 'checkName': name },
        dataType: 'text',
        async: false,
        error: function () {
            var alterMess = new EShop("<label class='am-text-danger'>验证唯一性操作失败</label>");
            alterMess.alert();
        },
        success: function (data) {
            if (data == "1") {
                isOnly = true; //返回值为1，表示是唯一值
            } else {
                isOnly = false;//非唯一值
            }
        }
    });
    return isOnly;
}


