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

    $("#btnExame").click(function () {
        form.validate();
        if (form.isValid() == false) {
            alert("表单存在错误，请修正后操作！");
            return false;
        }

        //form.loading();
        //提交数据
        if (ExameData) {
            ExameData();
        }
        form.unmask()
        return false;
    });

    $("#btnAbolish").click(function () {

        form.validate();
        if (form.isValid() == false) return false;

        //form.loading();
        //提交数据
        if (AbolishData) {
            AbolishData();
        }
        form.unmask()
        return false;
    });

    $("#btnAdd").click(function () {
        
        if (form.isChanged() || formChanged) {
            mini.confirm("有未保存的数据,确认新增?", "确认", function (action) {
                if (action == "ok") {
                    if (Add) {
                        Add();
                    }
                    form.unmask()
                    return false;
                } else {
                    return;
                }
            });
        } else {
            if (Add) {
                Add();
            }
            form.unmask()
            return false;
        }
    });

    $("#btnSearch").click(function () {

        if (form.isChanged() || formChanged) {
            mini.confirm("确定跳转到查询界面(有未保存的数据)?", "确认", function (action) {
                if (action == "ok") {
                    if (Search) {
                        Search();
                    }
                    form.unmask()
                    return false;
                } else {
                    return;
                }
            });
        } else {
            if (Search) {
                Search();
            }
            form.unmask()
            return false;
        }
    });

    $("#btnGoBack").click(function () {

        if (form.isChanged() || formChanged) {
            mini.confirm("确定跳转到查询界面(有未保存的数据)?", "确认", function (action) {
                if (action == "ok") {
                    if (Search) {
                        Search();
                    }
                    form.unmask()
                    return false;
                } else {
                    return;
                }
            });
        } else {
            if (Search) {
                Search();
            }
            form.unmask()
            return false;
        }
    });

    $("#btnReturn").click(function () {
        try {
            var href = location.href.replace("Edit", "List");
            location.href = href;
        }
        catch (e) { }
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

function formatTime(item, array) {
    if (item == null) {
        return "";
    }
    var ymd = new Date();
    ymd.setTime(parseInt(item.replace("\/Date(", "").replace(")\/", "")));
    return ymd.toLocaleDateString();
}
function arrayHaveValue(arr, key, value) {
    for (var i = 0; i < arr.length; i++) {
        if (arr[i][key] == value) {
            return true;
        }
    }
    return false;
}
$(document).keydown(function (e) {
    var doPrevent;
    if (e.keyCode == 8) {
        var d = e.srcElement || e.target;
        if (d.tagName.toUpperCase() == 'INPUT' || d.tagName.toUpperCase() == 'TEXTAREA') {
            doPrevent = d.readOnly || d.disabled;
        }
        else
            doPrevent = true;
    }
    else
        doPrevent = false;

    if (doPrevent)
        e.preventDefault();
});
$(function () {
    $('input:text:first').focus();
    var $inp = $('input:text');
    $inp.bind('keydown', function (e) {
        var key = e.which;
        if (key == 13) {
            e.preventDefault();
            var nxtIdx = $inp.index(this) + 1;
            $(":input:text:visible:eq(" + nxtIdx + ")").focus();
        }
    });
});

function bindMember(msCode) {

    // 绑定会员信息
    //var msCode = data[i].msCode;
    if (msCode) {
        $.ajax({
            url: "/Ms/SearchMsMemberArchivesList?MsCode=" + msCode,
            type: 'post',
            cache: false,
            dataType: "json",
            success: function (msData) {
                var data = msData.data;

                if (data) {
                    // 绑定
                    for (var i = 0; i < data.length; i++) {
                        //mini.get('Control_MsCode').setValue(data[i].MsCode);
                        mini.get('Control_MsName').setValue(data[i].MsName);
                        mini.get('Control_Birthday').setValue(data[i].Birthday);
                        mini.get('Control_Sex').setValue(data[i].Sex);
                        mini.get('Control_PoliticsCode').setValue(data[i].PoliticsCode);
                        mini.get('Control_NationCode').setValue(data[i].NationCode);
                        mini.get('Control_EducationCode').setValue(data[i].EducationCode);
                        mini.get('Control_ProfessionalTitleCode').setValue(data[i].ProfessionalTitleCode);
                        mini.get('Control_IfMarried').setValue(data[i].IfMarried);
                        mini.get('Control_NativePlace').setValue(data[i].NativePlace);;
                        mini.get('Control_Idcard').setValue(data[i].Idcard);
                        mini.get('Control_FamilyPhone').setValue(data[i].FamilyPhone);
                        mini.get('Control_Handset').setValue(data[i].Handset);
                        mini.get('Control_eMail').setValue(data[i].eMail);
                        mini.get('Control_FamilyAddress').setValue(data[i].FamilyAddress);
                        mini.get('Control_Postalcode').setValue(data[i].Postalcode);
                        mini.get('Control_Stature').setValue(data[i].Stature);
                        mini.get('Control_Width').setValue(data[i].Width);

                        break;
                    };

                } else {

                    //mini.get('Control_MsCode').disable();
                    mini.get('Control_MsName').disable();
                    mini.get('Control_Birthday').disable();
                    mini.get('Control_Sex').disable();
                    mini.get('Control_PoliticsCode').disable();
                    mini.get('Control_NationCode').disable();
                    mini.get('Control_EducationCode').disable();
                    mini.get('Control_ProfessionalTitleCode').disable();
                    mini.get('Control_IfMarried').disable();
                    mini.get('Control_NativePlace').disable();
                    mini.get('Control_Idcard').disable();
                    mini.get('Control_FamilyPhone').disable();
                    mini.get('Control_Handset').disable();
                    mini.get('Control_eMail').disable();
                    mini.get('Control_FamilyAddress').disable();
                    mini.get('Control_Postalcode').disable();
                    mini.get('Control_Stature').disable();
                    mini.get('Control_Width').disable();

                    //mini.get('Control_MsCode').setValue('');
                    mini.get('Control_MsName').setValue('');
                    mini.get('Control_Birthday').setValue('');
                    mini.get('Control_Sex').setValue('');
                    mini.get('Control_PoliticsCode').setValue('');
                    mini.get('Control_NationCode').setValue('');
                    mini.get('Control_EducationCode').setValue('');
                    mini.get('Control_ProfessionalTitleCode').setValue('');
                    mini.get('Control_IfMarried').setValue('');
                    mini.get('Control_NativePlace').setValue('');
                    mini.get('Control_Idcard').setValue('');
                    mini.get('Control_FamilyPhone').setValue('');
                    mini.get('Control_Handset').setValue('');
                    mini.get('Control_eMail').setValue('');
                    mini.get('Control_FamilyAddress').setValue('');
                    mini.get('Control_Postalcode').setValue('');
                    mini.get('Control_Stature').setValue('');
                    mini.get('Control_Width').setValue('');
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                $("#Tooltip_Critical_MsFreezeCardManage .content").first().text(jqXHR.responseText);
                $("#Tooltip_Critical_MsFreezeCardManage").show("fast");
                form.unmask();
                $(document).scrollTop(0);
            }
        });
    } else {
        mini.get('Control_MsName').disable();
        mini.get('Control_Birthday').disable();
        mini.get('Control_Sex').disable();
        mini.get('Control_PoliticsCode').disable();
        mini.get('Control_NationCode').disable();
        mini.get('Control_EducationCode').disable();
        mini.get('Control_ProfessionalTitleCode').disable();
        mini.get('Control_IfMarried').disable();
        mini.get('Control_NativePlace').disable();
        mini.get('Control_Idcard').disable();
        mini.get('Control_FamilyPhone').disable();
        mini.get('Control_Handset').disable();
        mini.get('Control_eMail').disable();
        mini.get('Control_FamilyAddress').disable();
        mini.get('Control_Postalcode').disable();
        mini.get('Control_Stature').disable();
        mini.get('Control_Width').disable();

        //mini.get('Control_MsCode').setValue('');
        mini.get('Control_MsName').setValue('');
        mini.get('Control_Birthday').setValue('');
        mini.get('Control_Sex').setValue('');
        mini.get('Control_PoliticsCode').setValue('');
        mini.get('Control_NationCode').setValue('');
        mini.get('Control_EducationCode').setValue('');
        mini.get('Control_ProfessionalTitleCode').setValue('');
        mini.get('Control_IfMarried').setValue('');
        mini.get('Control_NativePlace').setValue('');
        mini.get('Control_Idcard').setValue('');
        mini.get('Control_FamilyPhone').setValue('');
        mini.get('Control_Handset').setValue('');
        mini.get('Control_eMail').setValue('');
        mini.get('Control_FamilyAddress').setValue('');
        mini.get('Control_Postalcode').setValue('');
        mini.get('Control_Stature').setValue('');
        mini.get('Control_Width').setValue('');
    }
}
