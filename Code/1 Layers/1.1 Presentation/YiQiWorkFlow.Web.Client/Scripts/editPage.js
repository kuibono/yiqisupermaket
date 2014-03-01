jQuery.cookie = function (name, value, options) {
    if (typeof value != 'undefined') { // name and value given, set cookie
        options = options || {};
        if (value === null) {
            value = '';
            options.expires = -1;
        }
        var expires = '';
        if (options.expires && (typeof options.expires == 'number' || options.expires.toUTCString)) {
            var date;
            if (typeof options.expires == 'number') {
                date = new Date();
                date.setTime(date.getTime() + (options.expires * 24 * 60 * 60 * 1000));
            } else {
                date = options.expires;
            }
            expires = '; expires=' + date.toUTCString(); // use expires attribute, max-age is not supported by IE
        }
        var path = options.path ? '; path=' + options.path : '';
        var domain = options.domain ? '; domain=' + options.domain : '';
        var secure = options.secure ? '; secure' : '';
        document.cookie = [name, '=', encodeURIComponent(value), expires, path, domain, secure].join('');
    } else { // only name given, get cookie
        var cookieValue = null;
        if (document.cookie && document.cookie != '') {
            var cookies = document.cookie.split(';');
            for (var i = 0; i < cookies.length; i++) {
                var cookie = jQuery.trim(cookies[i]);
                // Does this cookie string begin with the name we want?
                if (cookie.substring(0, name.length + 1) == (name + '=')) {
                    cookieValue = decodeURIComponent(cookie.substring(name.length + 1));
                    break;
                }
            }
        }
        return cookieValue;
    }
};
$(function () {
    mini.parse();
    var form = new mini.Form("#formMain"); // default form
    $(window).scroll(function () {
        if ($(document).scrollTop() > 100) {
            $(".botton-up").show();
        } else {
            $(".botton-up").hide();
        }
    });
    $(".botton-up").click(function () {
        $(document).scrollTop(0);
    });
    $(".tooltip .button-close").click(function () {
        $(this).parents(".tooltip").first().hide("fast");
    });
    $(".tooltip .buttonClose").click(function () {
        $(this).parents(".tooltip").first().hide("fast");
    });
    $(".tooltip .buttonNoMoreShow").click(function () {
        $(this).parents(".tooltip").first().hide("fast");
        //setting cookie
        var id = $(this).parents(".tooltip").first().prop("id");
        $.cookie(id, "a", { expires: 3650, path: "/" });
    });
    $(".tooltip").each(function () {
        if ($.cookie($(this).prop("id"))) {
            $(this).hide();
        }
    });
    $("#btnFormSubmit").click(function () {
        form.validate();
        if (form.isValid() == false) return false;

        //form.loading();
        //提交数据
        if (SaveData) {
            SaveData();
        } else {
            alert("开发人员注意，保存函数未定义！");
        }
        form.unmask()
        return false;
    });
    $(document).keydown(function (event) {
        //alert(event.keyCode)
        //ctrl+s
        if (event.keyCode == 83 && event.ctrlKey) {
            $("#btnFormSubmit").click();
            return false;
        }
        //enter+ctrl
        else if (event.keyCode == 13 && event.ctrlKey) {
            $("#btnFormSubmit").click();
            return false;
        }
        //esc
        else if (event.keyCode == 27) {
            $("#formMain input:reset").first().click();
        }
        //Ctrl+Q
        else if (event.keyCode == 81 && event.ctrlKey) {
            closeTab();
        }
        else if (event.keyCode == 69 && event.ctrlKey) { //Ctrl+E
            $("#btnExame").click();
        }
    });
    $("#btnClosePage").click(function () {
        closeTab();
    });
    if (pageType == "Edit") {
        $("input").change(function () {
            formChanged = true;
        });
    }

    
    $("input:text:visible").first().focus();

});
function closeTab() {
    var form = new mini.Form("#formMain"); // default form

    if (form.isChanged() || formChanged) {
        mini.showMessageBox({
            title: "是否保存",
            iconCls: "mini-messagebox-question",
            buttons: ["yes", "no", "cancel"],
            message: pageTitle + "内容已经修改，是否在关闭前保存？",
            callback: function (action) {
                if (action == "yes") {
                    //save and close
                    closeWithNoValidate();
                    $("#formMain").submit();
                } else if (action == "no") {
                    //close
                    closeWithNoValidate();
                } else {
                    //return false;
                }
            }
        });
    } else {
        closeWithNoValidate();
    }
}
function closeWithNoValidate() {
    //if (window.top.location.href = location.href) {
    //    window.opener = null;
    //    window.open('', '_self');
    //    window.close();
    //} else {
    //    parent.closeTab(pageName);
    //}
    parent.closeTab(pageName);
}

