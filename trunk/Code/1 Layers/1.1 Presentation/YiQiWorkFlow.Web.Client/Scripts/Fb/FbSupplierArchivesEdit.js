var clearExameAfterSave = true;
function SaveData() {
    var form = new mini.Form("#formMain"); // default form
    var o = form.getData(true);
    if (clearExameAfterSave == true) {
        o["IfExamine"] = "0";
    }
    $.ajax({
        url: "/Fb/SaveFbSupplierArchives",
        type: 'post',
        data: o,
        cache: false,
        dataType: "json",
        success: function (r) {
            if (r.IsSuccess == true) {
                //closeWithNoValidate();
                history.go(-1);
            } else {
                $("#Tooltip_Critical_FbSupplierArchives .content").first().text(r.Message);
                $("#Tooltip_Critical_FbSupplierArchives").show("fast");
                form.unmask();
                $(document).scrollTop(0);
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            $("#Tooltip_Critical_FbSupplierArchives .content").first().text(jqXHR.responseText);
            $("#Tooltip_Critical_FbSupplierArchives").show("fast");
            form.unmask();
            $(document).scrollTop(0);
        }
    });
}
function onOpCodeChanged() {
    var opCode = mini.get("Control_OpCode");
    var balanceMode = mini.get("Control_BalanceMode");
    if (opCode.getValue() == "1") {//经销
        balanceMode.setData([{ id: '预付货款', text: '预付货款' }, { id: '货到付款', text: '货到付款' }]);
        balanceMode.setValue("预付货款");
        //[{id:'预付货款',text:'预付货款'},{id:'货到付款',text:'货到付款'},{id:'实销实付',text:'实销实付'},{id:'扣点结算',text:'扣点结算'}]
    }
    if (opCode.getValue() == "2") {//代销
        balanceMode.setData([{ id: '实销实付', text: '实销实付' }]);
        balanceMode.setValue("实销实付");
    }
    if (opCode.getValue() == "3" || opCode.getValue() == "5") {
        balanceMode.setData([{ id: '扣点结算', text: '扣点结算' }]);
        balanceMode.setValue("扣点结算");
    }
    if (opCode.getValue() == "4") {//租赁
        balanceMode.setData([{ id: '销售返还', text: '销售返还' }]);
        balanceMode.setValue("销售返还");
    }
    SetPoolRateEnable();
}

function SetPoolRateEnable() {
    var opCode = mini.get("Control_OpCode");
    if (opCode.getValue() == "3" || opCode.getValue() == "5") {
        mini.get("Control_PoolRate").enable();
        mini.get("Control_FloorsMoney").enable();
        mini.get("Control_ExcessRate").enable();
    } else {
        mini.get("Control_PoolRate").disable();
        mini.get("Control_FloorsMoney").disable();
        mini.get("Control_ExcessRate").disable();
    }
}

$(function () {
    SetPoolRateEnable();
    $("#btnExame").click(function () {
        var chk = mini.get("Control_IfExamine");
        chk.setValue("1");
        mini.get("Control_ExamineDate").setValue(new Date());
        clearExameAfterSave = false;
        SaveData();
    });
})
function ExameData() {
    var chk = mini.get("Control_IfExamine");
    chk.setValue("1");
    mini.get("Control_ExamineDate").setValue(new Date());
    clearExameAfterSave = false;
    SaveData();
}
function fillSupName() {
    mini.get("Control_PyCode").setValue(makePy(mini.get("Control_SupName").getValue()));
    $("#Control_SupTypeCode input:first").focus();
}