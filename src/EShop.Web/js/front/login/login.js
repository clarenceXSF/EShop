$(document).ready(function (e) {
    $(".l-link").click(function () {
        $(".l-title ul li:not(this)").css("background", "#f3f3f3");
        $(this).css("background", "#fff");
        $(".login").slideDown();
        $(".register").slideUp();
    });
    $(".r-link").click(function () {
        $(".l-title ul li:not(this)").css("background", "#f3f3f3");
        $(this).css("background", "#fff");
        $(".login").slideUp();
        $(".register").slideDown();
    });
});
$(function () {
    function validate($dom) {
        var v = $dom.val();
        var id = $dom.attr("id");
        var flag = true;
        switch (id) {
            case "account_num":
                $("#account_tips").html(' ');
                if (v == "") {
                    $("#account_tips").html("登录账户不能为空！");
                    flag = false;
                }
                break;
            case "pwd":
                $("#pwd_tips").html(' ');
                if (v == "") {
                    $("#pwd_tips").html("登录密码不能为空！");
                    flag = false;
                }
                break;
            case "username":
                $("#username_tips").html(' ');
                var reg = /^[a-zA-Z0-9\u4e00-\u9fa5]+$/;
                if (v == "") {
                    $("#username_tips").html("用户名不能为空！");
                    flag = false;
                } else if (!reg.test(v)) {
                    $("#username_tips").html("用户名只能由中文、大小写英文和数字组成！");
                    flag = false;
                } else if (!TheNameOnly(v)) { //验证登录名是否唯一
                    $("#username_tips").html("用户名已存在，请重新输入！");
                    flag = false;
                }
                break;
            case "setPwd":
                $("#password_tips").html(' ');
                if (v == "") {
                    $("#password_tips").html("登录密码不能为空！");
                    flag = false;
                } else if ($("#setPwd").val().length < 6 || $("#setPwd").val().length > 15) {
                    $("#password_tips").html("密码只能6-15位");
                    flag = false;
                }
                break;
            case "confirmPwd":
                $("#con_password_tips").html(' ');
                if (v == "") {
                    $("#con_password_tips").html("请再次输入登录密码！");
                    flag = false;
                } else if (v != $("#setPwd").val()) {
                    $("#con_password_tips").html("密码输入不一致！");
                    flag = false;
                }
                break;
            default:
                break;
        }
        return flag;
    }
    $("#username").blur(function () {
        validate($(this));
    });
    $("#setPwd").blur(function () {
        validate($(this));
    });
    $("#confirmPwd").blur(function () {
        validate($(this));
    });
    $("#loginform").submit(function () {
        var flag = true;
        $(this).find("input").each(function (i, ele) {
            if (!validate($(ele))) {
                flag = false;
            }
        });
        if (flag === false) {
            alert("输入存在错误，登录失败");
        }
        return flag;
    });
    $("#regform").submit(function () {
        var flag = true;
        $(this).find("input").each(function (i, ele) {
            if (!validate($(ele))) {
                flag = false;
            }
        });
        if (flag === false) {
            alert("输入存在错误，注册失败");
        }
        return flag;
    });
})
//获取页面id=mess的隐藏域的值，非空就alert出来
$(function () {
    var mess = $("#mess").val();
    if (typeof mess !== "undefined" && mess !== "") {
        alert(mess);
        //alert完成后清空值，避免多次alert()
        $("#mess").val("");
    }
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