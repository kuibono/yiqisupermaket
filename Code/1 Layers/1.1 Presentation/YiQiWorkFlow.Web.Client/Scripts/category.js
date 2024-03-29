﻿var c_OpCode = [{ id: 1, text: '经销' }, { id: 2, text: '代销' }, { id: 3, text: '联营' }, { id: 4, text: '租赁' }, { id: 5, text: '扣率代销' }];
var c_StockVoucher = [{ id: '普通发票', text: '普通发票' }, { id: '增值税发票', text: '增值税发票' }, { id: '农收购发票', text: '农收购发票' }, { id: '农粮肉发票', text: '农粮肉发票' }];
var c_BalanceMode = [{ id: '预付货款', text: '预付货款' }, { id: '货到付款', text: '货到付款' }, { id: '实销实付', text: '实销实付' }, { id: '扣点结算', text: '扣点结算' }, { id: '销售返还', text: '销售返还' }];
var c_PayMode = [{ id: '现金', text: '现金' }, { id: '支票', text: '支票' }, { id: '银行转账', text: '银行转账' }, { id: '托收承付', text: '托收承付' }];
var c_BalancePeriod = [{ id: '月结算', text: '月结算' }, { id: '季计算', text: '季计算' }, { id: '年结算', text: '年结算' }];
var c_OfferMode = [{ id: '散件', text: '散件' }, { id: '整件', text: '整件' }];
var c_GoodsType = [{ id: '1', text: '普通商品' }, { id: '2', text: '散货商品' }, { id: '4', text: '捆绑商品' }];
var c_GoodsState = [{ id: 1, text: '正常' }, { id: 2, text: '淘汰' }, { id: 3, text: '禁采销售' }, { id: 4, text: '禁采禁销' }, { id: 5, text: '废除' }];
var c_PcForm = [{ id: 1, text: '普通订货' }, { id: 2, text: '开放订货' }, { id: 3, text: '促销订货' }, { id: 4, text: '赠品订货' }];
var c_YesNoAll = [{ id: '', text: '所有' }, { id: 0, text: '否' }, { id: 1, text: '是' }];
var c_YesOrNo = [{ id: 0, text: '否' }, { id: 1, text: '是' }];

var c_Sex = [{ id: '男', text: '男' }, { id: '女', text: '女' }];
var c_PoliticsCode = [{ id: 0, text: '请选择...' }, { id: 1, text: '党员' }, { id: 2, text: '团员' }, { id: 3, text: '其他' }];
var c_NationCode = [{ id: 0, text: '请选择...' }, { id: 1, text: '汉族' }, { id: 2, text: '满族' }, { id: 3, text: '回族' }, { id: 4, text: '其他' }];
var c_EducationCode = [{ id: 0, text: '请选择...' }, { id: 1, text: '博士' }, { id: 2, text: '硕士' }, { id: 3, text: '本科' }, { id: 4, text: '专科' }, { id: 5, text: '其他' }];
var c_ProfessionalTitleCode = [{ id: 0, text: '请选择...' }, { id: 1, text: '高级职称' }, { id: 2, text: '中级职称' }, { id: 3, text: '普通职称' }, { id: 4, text: '其他' }];

var c_CardState = [{ id: 0, text: '待发' }, { id: 1, text: '正常' }, { id: 2, text: '挂失' }, { id: 3, text: '冻结' }, { id: 4, text: '废除' }];
var c_EnCode = [{ id: 0, text: '000001' }, { id: 1, text: '000002' }, { id: 2, text: '000003' }, { id: 3, text: '000004' }];
var c_IfMember = [{ id: 1, text: '新会员' }, { id: 2, text: '老会员' }, { id: 2, text: '非会员' }, { id: 3, text: '000004' }];
var c_lossType = [{ id: 1, text: '电话挂失' }, { id: 2, text: '现场挂失' }];
var c_EnCharacter = [{ id: '国营企业', text: '国营企业' }, { id: '私营企业', text: '私营企业' }, { id: '有限公司', text: '有限公司' }, { id: '合资企业', text: '合资企业' }, { id: '其他', text: '其他' }];
var c_CardType = [{ id: 1, text: '单店使用' }, { id: 2, text: '同城使用' }, { id: 3, text: '异地使用' }];
var c_CardMedium = [{ id: 1, text: '磁条卡' }, { id: 2, text: 'IC卡' }, { id: 3, text: '条码卡' }, { id: 4, text: '普通卡' }];
var c_UpgradeType = [{ id: 1, text: '累计积分' }, { id: 2, text: '当前积分' }];
var c_EffectiveType = [{ id: 1, text: "发卡生效" }, { id: 2, text: "指定生效" }];
var c_MemberType = [{ id: 1, text: "新会员" }, { id: 2, text: "老会员" }];
var c_WsType = [{ id: 1, text: "零售价" }, { id: 2, text: "批发价" }];
var c_CustomerPayMode = [{ id: 1, text: '现金' }, { id: 2, text: '支票' }, { id: 3, text: '汇票' }];
var c_CustomerBalancePeriod = [{ id: 1, text: '月结算' }, { id: 2, text: '季计算' }, { id: 3, text: '年结算' }];
var c_CustomerBalanceMode = [{ id: 1, text: '预付货款' }, { id: 2, text: '货到付款' }, { id: 3, text: '实销实付' }, { id: 4, text: '扣点结算' }];
var c_CustomerSalePeriod = [{ id: 1, text: '无限定帐期' }, { id: 2, text: '周帐期' }, { id: 3, text: '月帐期' }, { id: 4, text: '季帐期' }, { id: 4, text: '年帐期' }];

function onExamRender(e) {
    if (e.value == "true" || e.value == "1") return "审核";
    else if (e.value == "false" || e.value == "0") return "未审核";
    else return "废弃";
}
function onOpCodeRender(e) {
    for (var i = 0; i < c_OpCode.length; i++) {
        if (e.value == c_OpCode[i].id) {
            return c_OpCode[i].text;
        }
    }
    return "";
}
function onGoodsTypeRender(e) {
    for (var i = 0; i < c_GoodsType.length; i++) {
        if (e.value == c_GoodsType[i].id) {
            return c_GoodsType[i].text;
        }
    }
    return "";
}
function onGoodsStateRender(e) {
    for (var i = 0; i < c_GoodsState.length; i++) {
        if (e.value == c_GoodsState[i].id) {
            return c_GoodsState[i].text;
        }
    }
    return "";
}
function onSupCodeRender(e) {
    for (var i = 0; i < c_FbSupplierArchives.length; i++) {
        if (e.value == c_FbSupplierArchives[i].Id) {
            return c_FbSupplierArchives[i].SupName;
        }
    }
    return "";
}
function onPcFormRender(e) {
    for (var i = 0; i < c_PcForm.length; i++) {
        if (e.value == c_PcForm[i].id) {
            return c_PcForm[i].text;
        }
    }
    return "";
}
function onYesNoRender(e) {
    if (e.value == '0') {
        return "否";
    }
    else if (e.value == '1') {
        return "是 ";
    }
    else {
        return e.value;
    }
}
function onPercentRender(e) {
    try {
        return parseFloat(e.value) * 100 + "%";
    }
    catch (e) {
        return "";
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

    if (e.value) {
        return mini.formatDate(e.value, "yyyy-MM-dd HH:mm:ss");
    }
    return "";
}
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
function onCardStateRender(e) {
    if (e.value == "0") {
        return "待发";
    } else if (e.value == "1") {
        return "正常";
    } else if (e.value == "2") {
        return "挂失";
    } else if (e.value == "3") {
        return "冻结";
    } else if (e.value == "4") {
        return "废除";
    }
}
function onEffectiveTypeRender(e) {
    if (e.value == "1") {
        return "发卡生效";
    } else if (e.value == "2") {
        return "指定生效";
    }
}
function onLossTypeRender(e) {
    if (e.value == "1") {
        return "电话挂失";
    } else if (e.value == "2") {
        return "现场挂失";
    }
}
function onSexRender(e) {
    if (e.value == "1") {
        return "男";
    } else if (e.value == "2") {
        return "女";
    }
}
function onWsTypeRender(e) {
    if (e.value == "1") {
        return "零售价";
    } else if (e.value == "2") {
        return "批发价";
    }
}