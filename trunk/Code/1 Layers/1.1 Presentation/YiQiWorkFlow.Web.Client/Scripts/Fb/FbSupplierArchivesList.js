mini.parse();
var grid = mini.get("datagrid1");
grid.load();
//对"createtime"字段，进行降级排序
grid.sortBy("Id", "desc");
$("#key").bind("keydown", function (e) {
    if (e.keyCode == 13) {
        search();
    }
});
function onActionRenderer(e) {
    var grid = e.sender;
    var record = e.record;
    var uid = record.Id;
    var rowIndex = e.rowIndex;
    if (record.IfExamine) {
        if (record.IfExamine == "1") {
            return ' <a class="Edit_Button" href="javascript:editRow(\'' + uid + '\')" >编辑</a>';
        }
    }
    var s = ' <a class="Edit_Button" href="javascript:editRow(\'' + uid + '\')" >编辑</a>'
        + ' <a class="Delete_Button" href="javascript:if(confirm(\'确定要删除这条记录吗？\')){deleteItem(\'' + uid + '\')}">删除</a>';
    return s;
}

function onNoExamActionRenderer(e) {
    var grid = e.sender;
    var record = e.record;
    var uid = record.Id;
    var rowIndex = e.rowIndex;
    var s = ' <a class="Edit_Button" href="javascript:editRow(\'' + uid + '\')" >编辑</a>'
        + ' <a class="Delete_Button" href="javascript:if(confirm(\'确定要删除这条记录吗？\')){deleteItem(\'' + uid + '\')}">删除</a>';
    return s;
}

function remove() {
    var rows = grid.getSelecteds();
    if (rows.length > 0) {
        if (confirm("确定删除选中记录？")) {
            var ids = [];
            for (var i = 0, l = rows.length; i < l; i++) {
                var r = rows[i];
                ids.push(r.Id);
            }
            var id = ids.join(',');
            grid.loading("操作中，请稍后......");
            deleteItem(id);
        }
    } else {
        alert("请选中一条记录");
    }
}
function search() {
    var data = {};
    if (mini.get("#ifexame") != undefined) {
        data["IfExamine"] = mini.get("#ifexame").value;
    }
    if (mini.get("#keyword") != undefined) {
        data["key"] = mini.get("#keyword").value;
    }
    $("#datagrid1 .mini-grid-filterRow :text:visible").each(function () {
        if ($(this).val().length > 0) {
            data[$(this).prop("name")] = $(this).val();
        }
    });
    grid.load(data);
}
function editRow(id) {
    parent.showTab({ id: "FbSupplierArchivesEdit", text: "供货商档案管理", iconCls: "icon-edit", url: "/Fb/FbSupplierArchivesEdit/" + id });
}
function deleteItem(id) {
    $.ajax({
        url: "/Fb/FbSupplierArchivesDelete",
        data: { ids: id },
        dataType: "json",
        success: function (j) {
            if (j == false) {
                if (confirm("数据存在关联数据数据，删除后将影响整个系统运行，是否确认删除？") == true) {
                    $.ajax({
                        url: "/Fb/FbSupplierArchivesDelete",
                        data: { ids: id, confirm: "true" },
                        dataType: "json",
                        success: function (r) {
                            grid.reload();
                        }
                    });
                }
            }
            else {
                grid.reload();
            }
        },
        error: function () {
        }
    });
}
function exame(obj, itemid, old) {
    $.ajax({
        url: "/Fb/FbSupplierArchivesDeleteExame/" + itemid,
        success: function (j) {
            if (j == true) {
                $(obj).css("color", "green").text("是");
            }
            else {
                $(obj).css("color", "red").text("否");
            }
            $(obj).removeProp("onclick");
            $(obj).unbind("click").click(function () {
                exame(obj, itemid, !old)
            })
        },
        error: function () {
            alert("失败")
        }
    });
}
function showFilterRow() {
    $("#datagrid1 .mini-grid-filterRow").toggle();
}
function dropSelected() {
    var selected = grid.getSelecteds();
    if (selected.length > 0) {
        mini.confirm("是否废弃选中的" + selected.length + "条记录", "废弃", function (action) {
            if (action == "ok") {
                var ids = "";
                for (var i = 0; i < selected.length; i++) {
                    ids += selected[i].Id;
                    if (i != selected.length - 1) {
                        ids += ",";
                    }
                }
                $.ajax({
                    url: "/Common/ChangeDbValue",
                    data: { table: "fb_supplier_archives", pkcolumn: "sup_code", pk: ids,if_examine:"-1" },
                    dataType: "json",
                    success: function (r) {
                        if (r == true) {
                            grid.reload();
                        }
                        else {
                            alert("失败");
                        }
                    }
                });
            }
        });
    }
}