$(function () {
    setType();
    TypeSelect;
    var addStock = 0;
    $(".editBook").click(function (event) {
        var href = $(this).attr("data-url");
        try {
            location.href = href;
        } catch (err) {
            alert(err);
        }
    });
    $(".addStock").click(function (event) {
        var href = $(this).attr("data-url");
        try {
            location.href = href;
        } catch (err) {
            alert(err);
        }
    });
    $(".delBook").click(function (event) {
        var href = $(this).attr("data-url");
        try {
            var name = $(this).parents("tr").children("td:eq(1)").text();
            var alterMess = new EShop("确定要删除图书<strong class='am-text-danger'>" + name + "</strong>吗?");
            var confirmFunc = function () {
                location.href = href;
            }
            alterMess.confirm(confirmFunc);
        } catch (err) {
            alert(err);
        }
    });
    $("#reduceNum").click(function () {
        if (addStock >= 10) {
            addStock = addStock - 10;
            $("#setNum").text(addStock);
            $("#stockNum").val(addStock);
        }
        else {
            var alterMess = new EShop("<label class='am-text-danger'>添加数量不得小于0</label>");
            alterMess.alert();
        }
    });
    $("#addNum").click(function () {
        addStock = addStock + 10;
        $("#setNum").text(addStock);
        $("#stockNum").val(addStock);
    });
});

//快捷模糊查询
function searchBook() {
    var content = $('#searchText').val();
    location.href = "FindBySearchText?content=" + content;
}
//添加项目
function AddBook() {
    window.location = "../Book/AddBook";
}

$(function () {
    function validate($dom) {
        var v = $dom.val();
        var id = $dom.attr("id");
        var flag = true;
        switch (id) {
            case "name":
                $("#name_prompt").html("&nbsp;");
                if (v == "") {
                    $("#name_prompt").removeClass().addClass("am-text-danger am-icon-close").html("图书名称不能为空！");
                    flag = false;
                } else {
                    $("#name_prompt").removeClass().addClass("am-text-success am-icon-check").html("输入正确");
                }
                break;
            case "author":
                $("#author_prompt").html("&nbsp;");
                if (v == "") {
                    $("#author_prompt").removeClass().addClass("am-text-danger am-icon-close").html("作者姓名不能为空！");
                    flag = false;
                } else {
                    $("#author_prompt").removeClass().addClass("am-text-success am-icon-check").html("输入正确");
                }
                break;
            case "publishDate":
                $("#publishDate_prompt").html("&nbsp;");
                if (v == "") {
                    $("#publishDate_prompt").removeClass().addClass("am-text-danger am-icon-close").html("出版日期不能为空！");
                    flag = false;
                } else {
                    $("#publishDate_prompt").removeClass().addClass("am-text-success am-icon-check").html("输入正确");
                }
                break;
            case "type":
                $("#type_prompt").html("&nbsp;");
                if (v == "") {
                    $("#type_prompt").removeClass().addClass("am-text-danger am-icon-close").html("请选择图书类型！");
                    flag = false;
                } else {
                    $("#type_prompt").removeClass().addClass("am-text-success am-icon-check").html("输入正确");
                }
                break;
            case "price":
                $("#price_prompt").html("&nbsp;");
                if (v == "") {
                    $("#price_prompt").removeClass().addClass("am-text-danger am-icon-close").html("当前售价不能为空！");
                    flag = false;
                } else {
                    $("#price_prompt").removeClass().addClass("am-text-success am-icon-check").html("输入正确");
                }
                break;
            case "original":
                $("#original_prompt").html("&nbsp;");
                if (v == "") {
                    $("#original_prompt").removeClass().addClass("am-text-danger am-icon-close").html("原售价不能为空！");
                    flag = false;
                } else {
                    $("#original_prompt").removeClass().addClass("am-text-success am-icon-check").html("输入正确");
                }
                break;
            default:
                break;
        }
        return flag;
    }

    $("#name").blur(function () {
        validate($(this));
    });
    $("#author").blur(function () {
        validate($(this));
    });
    $("#publishDate").blur(function () {
        validate($(this));
    });
    $("#type").blur(function () {
        validate($(this));
    });
    $("#price").blur(function () {
        validate($(this));
    });
    $("#original").blur(function () {
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
var uploader = new plupload.Uploader({ //实例化一个plupload上传对象
    browse_button: 'browse',
    url: '/Book/delUploadImg',
    file_data_name: "file",
    flash_swf_url: '~/js/lib/plUpload/Moxie.swf',
    silverlight_xap_url: '~/js/lib/plUpload/Moxie.xap',
    filters: {
        mime_types: [ //只允许上传图片文件
          { title: "图片文件", extensions: "jpg,gif,png" }
        ],
        prevent_duplicates: true,//不允许选取重复文件
        multi_selection: false//单文件
    }
});
uploader.init(); //初始化

//绑定文件添加进队列事件
uploader.bind('FilesAdded', function (uploader, files) {
    $.each(uploader.files, function (i, file) {
        if (uploader.files.length <= 1) {
            return;
        }
        uploader.removeFile(file);
    });
    var file_name = files[0].name; 
    $('#upName').html('您选择的文件名: ' + file_name);
    previewImage(files[0], function (imgsrc) {
        $('#upImg').empty();
        $('#upImg').append('<img src="' + imgsrc + '" width="150" height="200"/>');
    });
    uploader.start();
    $(".moxie-shim").hide();
});
function previewImage(file, callback) {
    if (!file || !/image\//.test(file.type)) return; 
    if (file.type == 'image/gif') {
        var fr = new mOxie.FileReader();
        fr.onload = function () {
            callback(fr.result);
            fr.destroy();
            fr = null;
        }
        fr.readAsDataURL(file.getSource());
    } else {
        var preloader = new mOxie.Image();
        preloader.onload = function () {
            preloader.downsize(150, 150);
            var imgsrc = preloader.type == 'image/jpeg' ? preloader.getAsDataURL('image/jpeg', 80) : preloader.getAsDataURL(); 
            callback && callback(imgsrc); 
            preloader.destroy();
            preloader = null;
        };
        preloader.load(file.getSource());
    }
}

//获取类型下拉列表
function setType() {
    $.ajax({
        url: '/Type/FindBookType',
        type: 'POST',
        dataType: 'json',
        async: true,
        success: function (data) {
            if (data != null) {
                for (var i = 0; i < data.length; i++) {
                    var obj = data[i];
                    $("#type").append("<option value=\"" + obj.Id + "\">" + obj.TypeName + "</option>");
                }
            }
        },
        error:function(xhr,textStatus,thrown){
            console.log("请求异常："+xhr.status+"  "+textStatus+"  "+thrown);
        }
    }); 
}
function TypeSelect() {
    var oldtype = $("#oldType").val();
    if (oldtype != null && oldtype != "")
        $("#type option[value='" + oldtype + "']").attr("selected", true);
}