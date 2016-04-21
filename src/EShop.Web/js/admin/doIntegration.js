$(function () {
    getBookNum();
    getCustomerNum();
});

//获取书籍总量
function getBookNum() {
    $.ajax({
        url: '/Book/GetBookNum',
        type: 'POST',
        dataType: 'text',
        async: true,
        success: function (data) {
            $("#bookNum").text(data);
        },
        error: function (xhr, textStatus, thrown) {
            console.log("请求异常：" + xhr.status + "  " + textStatus + "  " + thrown);
        }
    });
}
//获取注册客户数量
function getCustomerNum() {
    $.ajax({
        url: '/User/GetCustomerNum',
        type: 'POST',
        dataType: 'text',
        async: true,
        success: function (data) {
            $("#customerNum").text(data);
        },
        error: function (xhr, textStatus, thrown) {
            console.log("请求异常：" + xhr.status + "  " + textStatus + "  " + thrown);
        }
    });
}