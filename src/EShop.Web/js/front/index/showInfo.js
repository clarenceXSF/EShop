$(function () {
    ShowTypeList();//首页左导航栏显示
    ShowRecommend();//首页中间店长推荐
    ShowNewBook();//新书上架
    ShowHotSale();//畅销书籍
    ShowAuthor();//优秀作者
    ShowRenwen();//人文类
    ShowShaoer();//少儿类
    ShowShenghuo()//生活类
    Showkeji();//科技类
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
                    if (i > 9) continue;
                    
                    $("#showTypeList").append("<li><a href=\"/GoodsShow/Index?type=" + data[i].Id + "\"><div class=\"left-item1\"><i><img src=\"/Images/typemenu/xz_" + i + ".png\" width=\"18\" height=\"18\" /></i> " + data[i].TypeName + " </div></a></li>");
                }
            }
        },
        error: function (xhr, textStatus, thrown) {
            console.log("请求异常：" + xhr.status + "  " + textStatus + "  " + thrown);
        }
    });
}
//店长推荐
function ShowRecommend() {
    $.ajax({
        url: '/Home/FindRecommend',
        type: 'POST',
        dataType: 'json',
        async: true,
        success: function (data) {
            if (data != null) {
                console.log("店长推荐" + data);
                for (var i = 0; i < data.length; i++) {
                    $(".slider-banner .dian").before("<a href=\"/BookDetail/Index?bookid=" + data[i].BookId + "\"><img src=\"" + data[i].ShowImage + "\" alt=\"" + data[i].ShowTitle + "\" title=\"" + data[i].ShowTitle + "\" /></a>");
                }
                indexban.init();
            }
        },
        error: function (xhr, textStatus, thrown) {
            console.log("请求异常：" + xhr.status + "  " + textStatus + "  " + thrown);
        }
    });
}
//新书上架
function ShowNewBook() {
    $.ajax({
        url: '/Home/FindNewCreateBook',
        type: 'POST',
        dataType: 'json',
        async: true,
        success: function (data) {
            if (data != null) {
                //console.log("新书上架" + data);
                for (var i = 0; i < data.length; i++) {
                    $("#showNewBook").append("<li class=\"line1 item\" >" + "<a href=\"/BookDetail/Index?bookid="
                        + data[i].Id + "\" target=\"_blank\"><img src=\"" + setImgShow(data[i].ISBN)
                        + "\" alt=\"" + data[i].Name + "\" ></a><div><p class=\"name\" ><a title=\"" + data[i].Name
                        + "\" href=\"/BookDetail/Index?bookid=" + data[i].Id + "\" target=\"_blank\">" + data[i].Name
                        + "</a></p><br /><p class=\"price\">￥" + setMoney(data[i].Price) + "</p><br /><p class=\"yj\">￥"
                        + setMoney(data[i].Original) + "</p><br /></div></li>");
                }
            }
        },
        error: function (xhr, textStatus, thrown) {
            console.log("请求异常：" + xhr.status + "  " + textStatus + "  " + thrown);
        }
    });
}
//畅销书籍
function ShowHotSale() {
    $.ajax({
        url: '/Home/FindHotSaleBook',
        type: 'POST',
        dataType: 'json',
        async: true,
        success: function (data) {
            if (data != null) {
                //console.log("畅销书籍" + data);
                for (var i = 0; i < data.length; i++) {
                    $("#showHotSale").append("<li><div class=\"f-mimg f-mimg1\">"
                        + "<a href=\"/BookDetail/Index?bookid=" + data[i].Id
                        + "\" target=\"_blank\"><img src=\"" + data[i].ISBN + "\" /></a></div>"
                        + "<div class=\"f-mname f-mname1\"> <a href=\"/BookDetail/Index?bookid=" + data[i].Id
                        + "\" target=\"_blank\">" + data[i].Name + "</a> </div><div class=\"f-mprice f-mprice1\">"
                        + "<span class=\"price\">￥" + setMoney(data[i].Price) + "</span><span class=\"yj\">￥"
                        + setMoney(data[i].Original) + "</span></div></li>");
                }
            }
        },
        error: function (xhr, textStatus, thrown) {
            console.log("请求异常：" + xhr.status + "  " + textStatus + "  " + thrown);
        }
    });
}
//优秀作者
function ShowAuthor() {
    $.ajax({
        url: '/Home/FindAuthor',
        type: 'POST',
        dataType: 'json',
        async: true,
        success: function (data) {
            if (data != null) {
                //console.log("优秀作者" + data);
                for (var i = 0; i < data.length; i++) {
                    $("#showAuthor").append("<a href=\"/GoodsShow/Index?author=" + data[i] + "\" target=\"_blank\"> " + data[i] + " </a>");
                }
            }
        },
        error: function (xhr, textStatus, thrown) {
            console.log("请求异常：" + xhr.status + "  " + textStatus + "  " + thrown);
        }
    });
}
//人文类
function ShowRenwen() {
    var type_name = "人文";
    var $renwen = $("#renwenInfo");
    var $malllist = $renwen.find("#malllist");
    setTypeInfo(type_name, $renwen, $malllist);
}
//少儿类
function ShowShaoer() {
    var type_name = "少儿";
    var $shaoer = $("#shaoerInfo");
    var $malllist = $shaoer.find("#malllist");
    setTypeInfo(type_name, $shaoer, $malllist);
}
//生活类
function ShowShenghuo() {
    var type_name = "生活";
    var $shenghuo = $("#shenghuoInfo");
    var $malllist = $shenghuo.find("#malllist");
    setTypeInfo(type_name, $shenghuo, $malllist);
}
//科技类
function Showkeji() {
    var type_name = "科技";
    var $keji = $("#kejiInfo");
    var $malllist = $keji.find("#malllist");
    setTypeInfo(type_name, $keji, $malllist);
}

//处理价格显示
function setMoney(p) {
    var money = parseFloat(p).toFixed(2);
    return money;
}
//处理图片显示
function setImgShow(isbn) {
    var imgsrc = null;
    if (isbn != null && isbn != "")
        imgsrc = isbn;
    else
        imgsrc = "/Images/notImage.jpg"
    return imgsrc;
}
//根据类型名称找到对应类型信息
function setTypeInfo(tn, $info, $malllist) {
    $.ajax({
        url: '/Home/FindTypeByName',
        data: { 'name': tn },
        type: 'POST',
        dataType: 'json',
        async: true,
        success: function (data) {
            if (data != null) {
                //console.log("类型--" + tn + "数据：" + data);
                $info.find("#type_name").html(data.TypeName);
                $info.find("#type_img").append("<img src=\"" + data.ImgSrc
                    + "\" width=\"330\" height=\"470\" alt=\"" + data.TypeName + "\" />");
                setBookListByType(data.Id, $malllist)
            }
        },
        error: function (xhr, textStatus, thrown) {
            console.log("请求异常：" + xhr.status + "  " + textStatus + "  " + thrown);
        }
    });
}
//根据类型信息显示相关数据列表
function setBookListByType(type, $malllist) {
    $.ajax({
        url: '/Home/FindByType',
        data: { 'type': type },
        type: 'POST',
        dataType: 'json',
        async: true,
        success: function (data) {
            if (data != null) {
                //console.log("类型" + type + "图书加载:" + data);
                for (var i = 0; i < data.length; i++) {
                    $malllist.append("<li><div class=\"f-mimg f-mimg1\">"
                        + "<a href=\"/BookDetail/Index?bookid=" + data[i].Id
                        + "\" target=\"_blank\"><img src=\"" + setImgShow(data[i].ISBN) + "\" /></a></div>"
                        + "<div class=\"f-mname f-mname1\"> <a href=\"/BookDetail/Index?bookid=" + data[i].Id
                        + "\" target=\"_blank\">" + data[i].Name + "</a> </div>"
                        + "<div class=\"f-mprice f-mprice1\"><span class=\"price\">￥" + setMoney(data[i].Price)
                        + "</span><span class=\"yj\">￥"
                        + setMoney(data[i].Original) + "</span></div></li>");
                }
            }
        },
        error: function (xhr, textStatus, thrown) {
            console.log("请求异常：" + xhr.status + "  " + textStatus + "  " + thrown);
        }
    });
}
