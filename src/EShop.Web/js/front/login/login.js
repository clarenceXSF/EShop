$(document).ready(function(e) {
	$(".l-link").click(function() {
		$(".l-title ul li:not(this)").css("background", "#f3f3f3");
		$(this).css("background", "#fff");
		$(".login").slideDown();
		$(".register").slideUp();
	});
	$(".r-link").click(function() {
		$(".l-title ul li:not(this)").css("background", "#f3f3f3");
		$(this).css("background", "#fff");
		$(".login").slideUp();
		$(".register").slideDown();
	});
	//var count = 0;

	//$("#username").focus(function() {
	//	$("#username_tips").html(' ');
	//});
	//$("#set-pwd").focus(function() {
	//	$("#password_tips").html(' ');
	//});
	//$("#confirm-pwd").focus(function() {
	//	$("#con_password_tips").html(' ');
	//});
	//$("#account-num").focus(function() {
	//	$("#account_tips").html(' ');
	//});
	//$("#pwd").focus(function() {
	//	$("#pwd_tips").html(' ');
	//});
	//$("#register").click(function() {
	//	$.post(window.urlreg, {
	//		'username': $("#username").val(),
	//		"set-pwd": $("#set-pwd").val(),
	//		"confirm-pwd": $("#confirm-pwd").val(),
	//		"t": $("#t").val(),
	//	}, function(data) {
	//		if (data == 2) {
	//			$("#username_tips").html('请输入账号');
	//		} else if (data == 3) {
	//			$("#password_tips").html('请输入密码');
	//		} else if (data == 4) {
	//			$("#con_password_tips").html('请再次输入密码');
	//		} else if (data == 5) {
	//			$("#con_password_tips").html('确认密码输入不一致');
	//		} else if (data == 7) {
	//			$("#password_tips").html('密码只能6-15位,字母，下划线跟数字!');
	//		} else if (data == 8) {
	//			$("#username_tips").html('用户已存在');
	//		} else if (data == 10) {
	//			alert('注册失败!');
	//		} else if (data == 1) {
	//			$("#code_tips").html('验证码不正确');
	//		} else if (data == 9) {
	//			window.location.href = ucenterUrl;
	//		}
	//	});
	//});
});

//function checkNull() {
//	if ($("#account-num").val() == "") {
//		$("#account_tips").html('用户名不能为空');
//		return false;
//	} else if ($("#pwd").val() == "") {
//		$("#pwd_tips").html('密码不能为空');
//		return false;
//	} else {
//		return true;
//	}
//}

$(function () {
    function validate($dom) {
        var v = $dom.val();
        var id = $dom.attr("id");
        var flag = true;
        switch (id) {
            case "account-num":
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
            case "set-pwd":
                $("#password_tips").html(' ');
                if (v == "") {
                    $("#password_tips").html("登录密码不能为空！");
                    flag = false;
                } else if ($("#set-pwd").val().length < 6 || $("#set-pwd").val().length > 15) {
                    $("#password_tips").html("密码只能6-15位");
                }
                break;
            case "confirm-pwd":
                $("#con_password_tips").html(' ');
                if (v == "") {
                    $("#con_password_tips").html("请重新确认密码！");
                    flag = false;
                } else if (v != $("#set-pwd").val()) {
                    $("#con_password_tips").html("密码输入不一致！");
                    flag = false;
                }
                break;
            default:
                break;
        }
        return flag;
    }
    $("#account-num").blur(function () {
        validate($(this));
    });
    $("#pwd").blur(function () {
        validate($(this));
    });
    $("#username").blur(function () {
        validate($(this));
    });
    $("#set-pwd").blur(function () {
        validate($(this));
    });
    $("#confirm-pwd").blur(function () {
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
            alter("输入存在错误，注册失败");
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