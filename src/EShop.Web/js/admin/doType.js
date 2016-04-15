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
                } else {
                    $("#typeCode_prompt").removeClass().addClass("am-text-success am-icon-check").html("输入正确");
                }
                break;
            case "typeName":
                $("#typeName_prompt").html("&nbsp;");
                if (v == "") {
                    $("#typeName_prompt").removeClass().addClass("am-text-danger am-icon-close").html("类型名称不能为空！");
                    flag = false;
                } else {
                    $("#typeName_prompt").removeClass().addClass("am-text-success am-icon-check").html("输入正确");
                }
                break;
            default:
                break;
        }
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
        if (flag === false) {
            var alterMess = new EShop("<label class='am-text-danger'>输入存在错误，提交失败</label>");
            alterMess.alert();
        }
        return flag;
    });
});
var uploader = new plupload.Uploader({ //实例化一个plupload上传对象
    browse_button: 'browse',
    url: '/Type/delUploadImg',
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
    var file_name = files[0].name; //文件名
    $('#upName').html('您选择的文件名: ' + file_name);
    previewImage(files[0], function (imgsrc) {
        $('#upImg').empty();
        $('#upImg').append('<img src="' + imgsrc + '" width="150" height="200"/>');
    });
    uploader.start();
    $(".moxie-shim").hide();
});
//plupload中为我们提供了mOxie对象
//有关mOxie的介绍和说明请看：https://github.com/moxiecode/moxie/wiki/API
function previewImage(file, callback) {//file为plupload事件监听函数参数中的file对象,callback为预览图片准备完成的回调函数
    if (!file || !/image\//.test(file.type)) return; //确保文件是图片
    if (file.type == 'image/gif') {//gif使用FileReader进行预览,因为mOxie.Image只支持jpg和png
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
            preloader.downsize(150, 200);//先压缩一下要预览的图片,宽150，高200
            var imgsrc = preloader.type == 'image/jpeg' ? preloader.getAsDataURL('image/jpeg', 80) : preloader.getAsDataURL(); //得到图片src,实质为一个base64编码的数据
            callback && callback(imgsrc); //callback传入的参数为预览图片的url
            preloader.destroy();
            preloader = null;
        };
        preloader.load(file.getSource());
    }
}


