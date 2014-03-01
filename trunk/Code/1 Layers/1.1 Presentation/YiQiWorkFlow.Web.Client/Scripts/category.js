var c_OpCode = [{ id: 1, text: '经销' }, { id: 2, text: '代销' }, { id: 3, text: '联营' }, { id: 4, text: '租赁' }, { id: 5, text: '扣率代销' }];
var c_StockVoucher = [{ id: '普通发票', text: '普通发票' }, { id: '增值税发票', text: '增值税发票' }, { id: '农收购发票', text: '农收购发票' }, { id: '农粮肉发票', text: '农粮肉发票' }];
var c_BalanceMode = [{ id: '预付货款', text: '预付货款' }, { id: '货到付款', text: '货到付款' }, { id: '实销实付', text: '实销实付' }, { id: '扣点结算', text: '扣点结算' }, { id: '销售返还', text: '销售返还' }];
var c_PayMode = [{ id: '现金', text: '现金' }, { id: '支票', text: '支票' }, { id: '银行转账', text: '银行转账' }, { id: '托收承付', text: '托收承付' }];
var c_BalancePeriod = [{ id: '月结算', text: '月结算' }, { id: '季计算', text: '季计算' }, { id: '年结算', text: '年结算' }];
var c_OfferMode = [{ id: '散件', text: '散件' }, { id: '整件', text: '整件' }];
var c_GoodsType = [{ id: '1', text: '普通商品' }, { id: '2', text: '散货商品' }, { id: '4', text: '捆绑商品' }];
var c_GoodsState = [{ id: 1, text: '正常' }, { id: 2, text: '淘汰' }, { id: 3, text: '禁采销售' }, { id: 4, text: '禁采禁销' }, { id: 5, text: '废除' }];
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