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

function onReadonlyExamRender(e) {
    if (e.value == "true" || e.value == "1") return "<span style='color:green'>是</span>";
    else return "<span style='color:red'>否</span>";
}
function onYesNoRender(e) {
    if (e.value == "true" || e.value == "1") return "是";
    else return "否";
}

function onExamineRender(e) {
    if (e.value == "0") {
        return "未审核";
    } else if (e.value == "1") {
        return "已审核";
    } else if (e.value == "-1") {
        return "已废除";
    }
}

function onFormatTimeRender(e) {
    
    if (e.value){
        return mini.formatDate(e.value, "yyyy-MM-dd HH:mm:ss");
    }
    return "";
}

// 会员管理

function onCardTypeRender(e) {
    if (e.value == "1") {
        return "单店使用";
    } else if (e.value == "2") {
        return "同城使用";
    } else if (e.value == "3") {
        return "异地使用";
    }
}

function onCardMediumRender(e) {
    if (e.value == "1") {
        return "磁条卡";
    } else if (e.value == "2") {
        return "IC卡";
    } else if (e.value == "3") {
        return "条码卡";
    } else if (e.value == "3") {
        return "普通卡";
    }
}

function onUpgradeTypeRender(e) {
    if (e.value == "1") {
        return "累积积分";
    } else if (e.value == "2") {
        return "当前积分";
    }
}

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