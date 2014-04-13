var alertFun = window.alert;
window.alert = function (str) {
    try {
        if (str.indexOf("www.miniui.com") == -1) {
            alertFun(str);
        }
    } catch (Exception) {
        alertFun(str);
    }
};
__CreateJSPath = function (js) {
    var scripts = document.getElementsByTagName("script");
    var path = "";
    for (var i = 0, l = scripts.length; i < l; i++) {
        var src = scripts[i].src;
        if (src.indexOf(js) != -1) {
            var ss = src.split(js);
            path = ss[0];
            break;
        }
    }
    var href = location.href;
    href = href.split("#")[0];
    href = href.split("?")[0];
    var ss = href.split("/");
    ss.length = ss.length - 1;
    href = ss.join("/");
    if (path.indexOf("https:") == -1 && path.indexOf("http:") == -1 && path.indexOf("file:") == -1 && path.indexOf("\/") != 0) {
        path = href + "/" + path;
    }
    return path;
}

var bootPATH = __CreateJSPath("boot.js");

//debugger
mini_debugger = true;

//miniui
document.write('<script src="' + bootPATH + 'jquery-1.6.2.min.js" type="text/javascript"></sc' + 'ript>');
document.write('<script src="' + bootPATH + 'miniui/miniui.js" type="text/javascript" ></sc' + 'ript>');
document.write('<script src="' + bootPATH + 'jquery.hotkeys.js" type="text/javascript" ></sc' + 'ript>');
document.write('<script src="' + bootPATH + 'category.js" type="text/javascript" ></sc' + 'ript>');
document.write('<link href="' + bootPATH + 'miniui/themes/default/miniui.css" rel="stylesheet" type="text/css" />');
document.write('<link href="' + bootPATH + 'miniui/themes/icons.css" rel="stylesheet" type="text/css" />');

//skin
var skin = getCookie("miniuiSkin");
if (skin) {
    document.write('<link href="' + bootPATH + 'miniui/themes/' + skin + '/skin.css" rel="stylesheet" type="text/css" />');
}


////////////////////////////////////////////////////////////////////////////////////////
function getCookie(sName) {
    var aCookie = document.cookie.split("; ");
    var lastMatch = null;
    for (var i = 0; i < aCookie.length; i++) {
        var aCrumb = aCookie[i].split("=");
        if (sName == aCrumb[0]) {
            lastMatch = aCrumb;
        }
    }
    if (lastMatch) {
        var v = lastMatch[1];
        if (v === undefined) return v;
        return unescape(v);
    }
    return null;
}
function labelModel(form) {
    var fields = form.getFields();
    for (var i = 0, l = fields.length; i < l; i++) {
        var c = fields[i];
        if (c.setReadOnly) c.setReadOnly(true);     //只读
        if (c.setIsValid) c.setIsValid(true);      //去除错误提示
        if (c.addCls) c.addCls("asLabel");          //增加asLabel外观
    }
}

//function onMoneyRender(e)
//{
//    return formatNum(e.value);
//}

//function formatNum(num)
//{  
//    if(!/^(/+|-)?(/d+)(/./d+)?$/.test(num))
//    {
//        //alert("wrong!"); 
//        return num;
//    }
//    var a = RegExp.$1, b = RegExp.$2, c = RegExp.$3;
//    var re = new RegExp().compile("(//d)(//d{3})(,|$)");
//    while(re.test(b)) b = b.replace(re, "$1,$2$3");
//    return a +""+ b +""+ c;
//}

window.onerror = function () { return true; }

function onEnglishValidation(e) {
    if (e.isValid) {
        if (isEnglish(e.value) == false) {
            e.errorText = "必须输入英文";
            e.isValid = false;
        }
    }
}
function onEnglishAndNumberValidation(e) {
    if (e.isValid) {
        if (isEnglishAndNumber(e.value) == false) {
            e.errorText = "必须输入英文+数字";
            e.isValid = false;
        }
    }
}
function onChineseValidation(e) {
    if (e.isValid) {
        if (isChinese(e.value) == false) {
            e.errorText = "必须输入中文";
            e.isValid = false;
        }
    }
}
function onIDCardsValidation(e) {
    if (e.isValid) {
        var pattern = /\d*/;
        if (e.value.length < 15 || e.value.length > 18 || pattern.test(e.value) == false) {
            e.errorText = "必须输入15~18位数字";
            e.isValid = false;
        }
    }
}

////////////////////////////////////
/* 是否英文 */
function isEnglish(v) {
    var re = new RegExp("^[a-zA-Z\_]+$");
    if (re.test(v)) return true;
    return false;
}

/* 是否英文+数字 */
function isEnglishAndNumber(v) {

    var re = new RegExp("^[0-9a-zA-Z\_]+$");
    if (re.test(v)) return true;
    return false;
}

/* 是否汉字 */
function isChinese(v) {
    var re = new RegExp("^[\u4e00-\u9fa5]+$");
    if (re.test(v)) return true;
    return false;
}

/*自定义vtype*/
//mini.VTypes["englishErrorText"] = "请输入英文";
//mini.VTypes["english"] = function (v) {
//    var re = new RegExp("^[a-zA-Z\_]+$");
//    if (re.test(v)) return true;
//    return false;
//}
function _onActionRenderer(e) {
    var grid = e.sender;
    var record = e.record;
    var uid = record._uid;
    var rowIndex = e.rowIndex;

    var s = '<a class="New_Button" href="javascript:_newRow(\'' + grid.id + '\')">新增</a>'
            +' <a class="Edit_Button" href="javascript:_editRow(\'' + grid.id + '\',\'' + uid + '\')" >编辑</a>'
            + ' <a class="Delete_Button" href="javascript:_delRow(\'' + grid.id + '\',\'' + uid + '\')">删除</a>';

    if (grid.isEditingRow(record)) {
        s = '<a class="Update_Button" href="javascript:_updateRow(\'' + grid.id + '\',\'' + uid + '\')">更新</a>'
            + ' <a class="Cancel_Button" href="javascript:_cancelRow(\'' + grid.id + '\',\'' + uid + '\')">取消</a>'
    }
    return s;
}

function _newRow(gridId) {
    var grid = mini.get(gridId);
    var row = {};
    grid.addRow(row, 0);

    grid.commitEdit();
    grid.beginEditRow(row);
}
function _editRow(gridId, row_uid) {
    var grid = mini.get(gridId);
    var row = grid.getRowByUID(row_uid);
    if (row) {
        grid.commitEdit();
        grid.beginEditRow(row);
    }
}
function _cancelRow(gridId, row_uid) {
    var grid = mini.get(gridId);
    grid.cancelEditRow(grid.getRowByUID(row_uid));
    //grid.reload();
}
function _delRow(gridId, row_uid) {
    var grid = mini.get(gridId);
    grid.removeRows(grid.getSelecteds());
    //grid.removeRows(grid.getRowByUID(row_uid));
}

function _updateRow(gridId,row_uid) {
    var grid = mini.get(gridId);
    var row = grid.getRowByUID(row_uid);
    grid.commitEdit();

}
Date.prototype.format = function (format) {
    var o = {
        "M+": this.getMonth() + 1, //month
        "d+": this.getDate(), //day
        "h+": this.getHours(), //hour
        "m+": this.getMinutes(), //minute
        "s+": this.getSeconds(), //second
        "q+": Math.floor((this.getMonth() + 3) / 3), //quarter
        "S": this.getMilliseconds() //millisecond
    }
    if (/(y+)/.test(format)) format = format.replace(RegExp.$1,
    (this.getFullYear() + "").substr(4 - RegExp.$1.length));
    for (var k in o) if (new RegExp("(" + k + ")").test(format))
        format = format.replace(RegExp.$1,
        RegExp.$1.length == 1 ? o[k] :
        ("00" + o[k]).substr(("" + o[k]).length));
    return format;
}