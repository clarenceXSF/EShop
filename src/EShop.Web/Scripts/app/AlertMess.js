//混合的构造函数/原型方式
//content为要提示的内容，支持html格式
function EShop(content, title) {
    this.title = title;
    this.content = content;
}

var modalHtml =
    '<div class="am-modal am-modal-confirm" tabindex="-1" id="confirm">' +
        '<div class="am-modal-dialog">' +
        '<div class="am-modal-hd"><span class="am-text-primary">风御轩 EShop</span><small>系统提示</small></div>' +
        '<div class="am-modal-bd">' +
        '</div>' +
        '<div class="am-modal-footer">' +
        '<span class="am-modal-btn" data-am-modal-confirm>确定</span>' +
        '</div>' +
        '</div>' +
        '</div>';

//alert提示方法，func为点击确定后要执行的函数
EShop.prototype.alert = function (func) {
    $("#confirm").remove();
    $("body").append(modalHtml);
    if (typeof this.title != "undefined") {
        $("#confirm").find(".am-modal-hd").html(this.title); //设置提示标题
    }
    $("#confirm").find(".am-modal-bd").html(this.content); //设置提示内容
    $('#confirm').modal({
        relatedTarget: this,
        onConfirm: func
    });
}
//confirm用户选择提示，cancelFunc点击取消要执行的函数,confirmFunc点击确定要执行的函数
EShop.prototype.confirm = function (confirmFunc, cancelFunc) {
    $("#confirm").remove();
    $("body").append(modalHtml);
    if ($("#confirm").find(".am-modal-footer").children().length === 1) {
        $("#confirm").find(".am-modal-footer").prepend('<span class="am-modal-btn" data-am-modal-cancel>取消</span>');
    }
    if (typeof this.title != "undefined") {
        $("#confirm").find(".am-modal-hd").html(this.title); //设置提示标题
    }
    $("#confirm").find(".am-modal-bd").html(this.content); //设置提示内容
    $('#confirm').modal({
        relatedTarget: this,
        onCancel: cancelFunc,
        onConfirm: confirmFunc
    });
}

//获取页面id=mess的隐藏域的值，非空就alert出来
$(function () {
    var mess = $("#mess").val();
    if (typeof mess !== "undefined" && mess !== "") {
        var eshop = new EShop(mess);
        var func = function () {
            //alert完成后清空值，避免多次alert()
            $("#mess").val("");
        }
        //进行提示
        eshop.alert(func);
    }
});
