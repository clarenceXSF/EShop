$(function () {
    $(".editUser").click(function (event) {
        var href = $(this).attr("data-url");
        try {
            location.href = href;
        } catch (err) {
            alert(err);
        }
    });
    $(".delUser").click(function (event) {
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
function searchUser() {
    var content = $('#searchText').val();
    location.href = "FindBySearchText?content=" + content;
}
//添加项目
function AddUser() {
    window.location = "../User/AddUser";
}

$(function () {
    function validate($dom) {
        var v = $dom.val();
        var id = $dom.attr("id");
        var flag = true;
        switch (id) {
            case "loginId":
                $("#loginId_prompt").html("&nbsp;");
                var reg = /^[a-zA-Z0-9\u4e00-\u9fa5]+$/;
                if (v == "") {
                    $("#loginId_prompt").removeClass().addClass("am-text-danger am-icon-close").html("登录名不能为空！");
                    flag = false;
                } else if (!reg.test(v)) {
                    $("#loginId_prompt").removeClass().addClass("am-text-danger am-icon-close").html("登录名只能由中文、大小写英文和数字组成！");
                    flag = false;
                } else if (!TheNameOnly(v)) { //验证登录名是否唯一
                    var oldloginName = $("#oldUIloginName").text();
                    if (oldloginName != "" && oldloginName != null && oldloginName == v) {
                        $("#loginId_prompt").removeClass().addClass("am-text-success am-icon-heart").html("此登录名为原登录名");
                        flag = true;
                    } else {
                        $("#loginId_prompt").removeClass().addClass("am-text-danger am-icon-close").html("此登录名已存在，请重新输入！");
                        flag = false;
                    }
                } else {
                    $("#loginId_prompt").removeClass().addClass("am-text-success am-icon-check").html("输入正确");
                }
                break;
            case "loginPwd":
                $("#loginPwd_prompt").html("&nbsp;");
                if (v == "") {
                    $("#loginPwd_prompt").removeClass().addClass("am-text-danger am-icon-close").html("登录密码不能为空！");
                    flag = false;
                } else {
                    $("#loginPwd_prompt").removeClass().addClass("am-text-success am-icon-check").html("输入正确");
                }
                break;
            case "name":
                $("#name_prompt").html("&nbsp;");
                if (v == "") {
                    $("#name_prompt").removeClass().addClass("am-text-danger am-icon-close").html("真实姓名不能为空！");
                    flag = false;
                } else {
                    $("#name_prompt").removeClass().addClass("am-text-success am-icon-check").html("输入正确");
                }
                break;
            case "phone":
                $("#phone_prompt").html("&nbsp;");
                if (v == "") {
                    $("#phone_prompt").removeClass().addClass("am-text-danger am-icon-close").html("联系电话不能为空！");
                    flag = false;
                } else {
                    $("#phone_prompt").removeClass().addClass("am-text-success am-icon-check").html("输入正确");
                }
                break;
            case "email":
                $("#email_prompt").html("&nbsp;");
                var chkemail = /^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*/;
                if (v == "") {
                    $("#email_prompt").removeClass().addClass("am-text-danger am-icon-close").html("邮箱地址不能为空！");
                    flag = false;
                } else if (!chkemail.test(v)) {
                    $("#email_prompt").removeClass().addClass("am-text-danger am-icon-close").html("请正确输入邮箱地址！");
                    flag = false;
                } else {
                    $("#email_prompt").removeClass().addClass("am-text-success am-icon-check").html("输入正确");
                }
                break;
            default:
                break;
        }
        return flag;
    }

    $("#loginId").blur(function () {
        validate($(this));
    });
    $("#loginPwd").blur(function () {
        validate($(this));
    });
    $("#name").blur(function () {
        validate($(this));
    });
    $("#phone").blur(function () {
        validate($(this));
    });
    $("#email").blur(function () {
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
//验证登录名是否唯一
function TheNameOnly(loginId) {
    var isOnly = false;
    $.ajax({
        url: 'CheckTheloginId',
        type: 'POST',
        data: { 'loginId': loginId },
        dataType: 'text',
        async: false,
        error: function () {
            var alterMess = new EasyBuild("<label class='am-text-danger'>验证登录名操作失败</label>");
            alterMess.alert();
        },
        success: function (data) {
            if (data == "1") {//存在
                isOnly = false; 
            } else {
                isOnly = true;
            }
        }
    });
    return isOnly;
}