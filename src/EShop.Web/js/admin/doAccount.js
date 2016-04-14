$(function () {
    function validate($dom) {
        var v = $dom.val();
        var id = $dom.attr("id");
        var flag = true;
        switch (id) {
            case "loginId":
                $("#typeCode_prompt").html("&nbsp;");
                if (v == "") {
                    flag = false;
                } 
                break;
            case "loginPwd":
                if (v == "") {
                    flag = false;
                } 
                break;
            default:
                break;
        }
        return flag;
    }


    $("#loginForm").submit(function () {
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