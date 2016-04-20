$(function () {
    setType();
    $(".editRecommend").click(function (event) {
        var href = $(this).attr("data-url");
        try {
            location.href = href;
        } catch (err) {
            alert(err);
        }
    });
    $(".delRecommend").click(function (event) {
        var href = $(this).attr("data-url");
        try {
            var name = $(this).parents("tr").children("td:eq(1)").text();
            var alterMess = new EShop("确定要删除推荐信息<strong class='am-text-danger'>" + name + "</strong>吗?");
            var confirmFunc = function () {
                location.href = href;
            }
            alterMess.confirm(confirmFunc);
        } catch (err) {
            alert(err);
        }
    });
    $("#type").change(function () {
        var type = $(this).children('option:selected').val();
        //alert(type);
        $.ajax({
            url: '/Book/FindBookByType',
            type: 'POST',
            data: { "type": type },
            dataType: 'json',
            async: true,
            success: function (data) {
                $("#book").empty();
                if (data != null) {
                    console.log(data);
                    for (var i = 0; i < data.length; i++) {
                        var obj = data[i];
                        $("#book").append("<option value=\"" + obj.Id + "\">" + obj.Name + "</option>");
                    }
                } else {
                    $("#book").append("<option disabled>暂无此类型书籍</option>");
                }
            },
            error: function (xhr, textStatus, thrown) {
                console.log("请求异常：" + xhr.status + "  " + textStatus + "  " + thrown);
            }
        });
    })
});

//快捷模糊查询
function searchRecommend() {
    var content = $('#searchText').val();
    location.href = "FindBySearchText?content=" + content;
}
//添加推荐信息
function AddRecommend() {
    window.location = "../Recommend/AddRecommend";
}

$(function () {
    function validate($dom) {
        var v = $dom.val();
        var id = $dom.attr("id");
        var flag = true;
        switch (id) {
            case "title":
                $("#title_prompt").html("&nbsp;");
                if (v == "") {
                    $("#title_prompt").removeClass().addClass("am-text-danger am-icon-close").html("推荐标题不能为空！");
                    flag = false;
                } else {
                    $("#title_prompt").removeClass().addClass("am-text-success am-icon-check").html("输入正确");
                }
                break;
            default:
                break;
        }
        return flag;
    }

    $("#title").blur(function () {
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
    url: '/Recommend/delUploadImg',
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
        $('#upImg').append('<img src="' + imgsrc + '" width="220" height="150"/>');
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
            preloader.downsize(750, 530);
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
