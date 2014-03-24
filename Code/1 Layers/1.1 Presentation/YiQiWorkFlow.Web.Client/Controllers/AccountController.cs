using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiQiWorkFlow.Web.Client.Models;
//using NSH.Authorization.Service;
using System.Web.Security;
using YiQiWorkFlow.Web.Client.Common;
///using NSH.Core.WPF;
using NSH.VSTO;
using System.Data;
using System.Configuration;
using System.Threading;

namespace YiQiWorkFlow.Web.Client.Controllers
{
    public class AccountController : Controller
    {

        public JsonResult GetModelesTree()
        {
            var results = new List<object>();

            var m1 = new List<object>();
            var m2 = new List<object>();
            var m3 = new List<object>();
            var m4 = new List<object>();
            var m5 = new List<object>();
            var m6 = new List<object>();
            var m7 = new List<object>();
            var m8 = new List<object>();
            var m9 = new List<object>();
            var m10 = new List<object>();
            var m11 = new List<object>();
            m1.Add(new { id = "101", iconCls = "icon-add", pid = "m1", text = "供货商档案管理", url = "/Fb/FbSupplierArchivesList" });
            m1.Add(new { id = "102", iconCls = "icon-add", pid = "m1", text = "商品档案管理", url = "/Fb/FbGoodsArchivesList" });
            m1.Add(new { id = "103", iconCls = "icon-add", pid = "m1", text = "商品供货商调整", url = "/Fb/FbAdjustSupplierEdit" });
            m1.Add(new { id = "104", iconCls = "icon-add", pid = "m1", text = "商品扣率调整", url = "/Fb/FbAdjustPoolrateEdit" });
            m1.Add(new { id = "105", iconCls = "icon-add", pid = "m1", text = "商品进价调整", url = "/Fb/FbAdjustPurchasepriceEdit" });
            m1.Add(new { id = "106", iconCls = "icon-add", pid = "m1", text = "商品售价调整", url = "/Fb/FbAdjustSalepriceEdit" });
            m1.Add(new { id = "107", iconCls = "icon-add", pid = "m1", text = "商品类别调整", url = "/Fb/FbAdjustClassEdit" });
            m1.Add(new { id = "108", iconCls = "icon-add", pid = "m1", text = "商品编码更新", url = "/Fb/FbAdjustGoodsCode" });
            m1.Add(new { id = "109", iconCls = "icon-add", pid = "m1", text = "商品信息查询", url = "/Fb/FbGoodsArchiveSearch" });
            m1.Add(new { id = "1024", iconCls = "icon-add", pid = "m1", text = "商品属性批量更新", url = "/Fb/FbAdjustGoodsPropty" });
            m1.Add(new { id = "110", iconCls = "icon-add", pid = "m1", text = "基础档案设置", url = "/Fb/FbPaBaseSetEdit" });
            m1.Add(new { id = "111", iconCls = "icon-add", pid = "m1", text = "供货商类型设置", url = "/Fb/FbPaSupTypeList" });
            m1.Add(new { id = "112", iconCls = "icon-add", pid = "m1", text = "商品大类设置", url = "/Fb/FbPaGoodsGbList" });
            m1.Add(new { id = "113", iconCls = "icon-add", pid = "m1", text = "商品中类设置", url = "/Fb/FbPaGoodsGmList" });
            m1.Add(new { id = "114", iconCls = "icon-add", pid = "m1", text = "商品小类设置", url = "/Fb/FbPaGoodsGsList" });
            m1.Add(new { id = "115", iconCls = "icon-add", pid = "m1", text = "商品细类设置", url = "/Fb/FbPaGoodsGlList" });
            m1.Add(new { id = "116", iconCls = "icon-add", pid = "m1", text = "商品包装单位设置", url = "/Fb/FbPaGoodsPackUnitList" });
            m1.Add(new { id = "117", iconCls = "icon-add", pid = "m1", text = "商品核算单位设置", url = "/Fb/FbPaGoodsCheckUnitList" });
            m1.Add(new { id = "118", iconCls = "icon-add", pid = "m1", text = "柜组编码设置", url = "/Fb/FbPaGoodsCounterList" });
            
            m2.Add(new { id = "119", iconCls = "icon-add", pid = "m2", text = "供货商采购管理", url = "/Pc/PcPurchaseManageList" });
            m2.Add(new { id = "120", iconCls = "icon-add", pid = "m2", text = "商品辅助订货", url = "/Pc/PcPurchaseManageGoodsEdit" });
            m2.Add(new { id = "121", iconCls = "icon-add", pid = "m2", text = "到货验收入库", url = "/Pc/PcPutinManageEdit/" });//url = "/Pc/PcPutinManageList" });
            m2.Add(new { id = "122", iconCls = "icon-add", pid = "m2", text = "采购批量入库", url = "/Pc/PcPutinManageBatchEdit" });
            m2.Add(new { id = "123", iconCls = "icon-add", pid = "m2", text = "供货商返货管理", url = "/Pc/PcReturnManageEdit" });
            m2.Add(new { id = "124", iconCls = "icon-add", pid = "m2", text = "商品返货管理", url = "/Pc/PcReturnManageEdit" });
            m2.Add(new { id = "125", iconCls = "icon-add", pid = "m2", text = "返货批量出库", url = "/Pc/PcPutoutManageEdit" });
            m2.Add(new { id = "126", iconCls = "icon-add", pid = "m2", text = "商品采购单批量打印", url = "" });
            m2.Add(new { id = "127", iconCls = "icon-add", pid = "m2", text = "商品验收单批量打印", url = "" });
            m2.Add(new { id = "128", iconCls = "icon-add", pid = "m2", text = "商品返货单批量打印", url = "" });
            m2.Add(new { id = "129", iconCls = "icon-add", pid = "m2", text = "商品采购单据查询", url = "" });
            m2.Add(new { id = "130", iconCls = "icon-add", pid = "m2", text = "商品采购汇总查询", url = "" });
            m2.Add(new { id = "131", iconCls = "icon-add", pid = "m2", text = "商品采购明细查询", url = "/Pc/PcPurchaseManageList" });
            m2.Add(new { id = "132", iconCls = "icon-add", pid = "m2", text = "商品采购类别汇总查询", url = "" });
            m2.Add(new { id = "133", iconCls = "icon-add", pid = "m2", text = "商品采购供货商查询", url = "" });
            m2.Add(new { id = "134", iconCls = "icon-add", pid = "m2", text = "商品返货单据汇总查询", url = "" });
            m2.Add(new { id = "135", iconCls = "icon-add", pid = "m2", text = "商品返货汇总查询", url = "" });
            m2.Add(new { id = "136", iconCls = "icon-add", pid = "m2", text = "商品返货明细查询", url = "/Pc/PcReturnManageList" });
            m2.Add(new { id = "137", iconCls = "icon-add", pid = "m2", text = "商品返货类别汇总查询", url = "" });
            m2.Add(new { id = "138", iconCls = "icon-add", pid = "m2", text = "商品返货供货商查询", url = "" });
            m2.Add(new { id = "139", iconCls = "icon-add", pid = "m2", text = "商品采购到货预警查询", url = "" });
            m2.Add(new { id = "140", iconCls = "icon-add", pid = "m2", text = "供货商到货率分析", url = "" });
            m2.Add(new { id = "141", iconCls = "icon-add", pid = "m2", text = "商品保质期预警查询", url = "" });
            m2.Add(new { id = "142", iconCls = "icon-add", pid = "m2", text = "商品库存预警查询", url = "" });
            
            m3.Add(new { id = "143", iconCls = "icon-add", pid = "m3", text = "商品移库管理", url = "" });
            m3.Add(new { id = "144", iconCls = "icon-add", pid = "m3", text = "盘点单生成", url = "" });
            m3.Add(new { id = "145", iconCls = "icon-add", pid = "m3", text = "商品盘点管理", url = "/Op/OpCheckManageList" });
            m3.Add(new { id = "146", iconCls = "icon-add", pid = "m3", text = "商品盘点查询", url = "" });
            m3.Add(new { id = "147", iconCls = "icon-add", pid = "m3", text = "商品盘点差异", url = "" });
            m3.Add(new { id = "148", iconCls = "icon-add", pid = "m3", text = "商品损溢管理", url = "/Op/OpLossManageList" });
            m3.Add(new { id = "149", iconCls = "icon-add", pid = "m3", text = "商品库存查询", url = "" });
            m3.Add(new { id = "150", iconCls = "icon-add", pid = "m3", text = "组合拆零商品", url = "" });
            m3.Add(new { id = "151", iconCls = "icon-add", pid = "m3", text = "组合拆零管理", url = "" });
            m3.Add(new { id = "152", iconCls = "icon-add", pid = "m3", text = "商品调整管理", url = "" });
            m3.Add(new { id = "153", iconCls = "icon-add", pid = "m3", text = "进货成本调整", url = "" });
            m3.Add(new { id = "154", iconCls = "icon-add", pid = "m3", text = "仓库参数设置", url = "" });
            
            m4.Add(new { id = "155", iconCls = "icon-add", pid = "m4", text = "单品促销管理", url = "" });
            m4.Add(new { id = "156", iconCls = "icon-add", pid = "m4", text = "类别促销管理", url = "" });
            m4.Add(new { id = "157", iconCls = "icon-add", pid = "m4", text = "馈赠促销管理", url = "" });
            m4.Add(new { id = "158", iconCls = "icon-add", pid = "m4", text = "整单促销管理", url = "" });
            m4.Add(new { id = "159", iconCls = "icon-add", pid = "m4", text = "电子称商品管理", url = "" });
            m4.Add(new { id = "160", iconCls = "icon-add", pid = "m4", text = "商品条码价签打印", url = "" });
            m4.Add(new { id = "161", iconCls = "icon-add", pid = "m4", text = "商品销售汇总查询", url = "" });
            m4.Add(new { id = "162", iconCls = "icon-add", pid = "m4", text = "类别销售查询", url = "" });
            m4.Add(new { id = "163", iconCls = "icon-add", pid = "m4", text = "商品销售单据查询", url = "" });
            m4.Add(new { id = "164", iconCls = "icon-add", pid = "m4", text = "商品销售流水查询", url = "" });
            m4.Add(new { id = "165", iconCls = "icon-add", pid = "m4", text = "付款方式查询", url = "/Rt/RtPaPaywayList" });
            m4.Add(new { id = "166", iconCls = "icon-add", pid = "m4", text = "收银收款查询", url = "/Rt/RtPaFunctionList" });
            m4.Add(new { id = "167", iconCls = "icon-add", pid = "m4", text = "收款机收款查询", url = "" });
            m4.Add(new { id = "168", iconCls = "icon-add", pid = "m4", text = "营业员类别销售查询", url = "" });
            m4.Add(new { id = "169", iconCls = "icon-add", pid = "m4", text = "营业员销售查询", url = "/Ac/AcSalesmanSummaryList" });
            m4.Add(new { id = "170", iconCls = "icon-add", pid = "m4", text = "滞销商品查询", url = "" });
            m4.Add(new { id = "171", iconCls = "icon-add", pid = "m4", text = "时段销售查询", url = "" });
            m4.Add(new { id = "172", iconCls = "icon-add", pid = "m4", text = "供货商销售汇总查询", url = "" });
            m4.Add(new { id = "173", iconCls = "icon-add", pid = "m4", text = "销售设置", url = "/Rt/RtPaSalesetList" });
            m4.Add(new { id = "174", iconCls = "icon-add", pid = "m4", text = "POS机设置", url = "/Rt/RtPaPosList" });
            m4.Add(new { id = "175", iconCls = "icon-add", pid = "m4", text = "功能键设置", url = "" });
            m4.Add(new { id = "176", iconCls = "icon-add", pid = "m4", text = "前台付款方式设置", url = "/Rt/RtPaPaywayList" });
            m4.Add(new { id = "177", iconCls = "icon-add", pid = "m4", text = "班次设置", url = "/Rt/RtPaShiftList" });
            
            m5.Add(new { id = "178", iconCls = "icon-add", pid = "m5", text = "客户档案管理", url = "/Ws/WsCustomerArchivesList" });
            m5.Add(new { id = "179", iconCls = "icon-add", pid = "m5", text = "客户销售管理", url = "" });
            m5.Add(new { id = "180", iconCls = "icon-add", pid = "m5", text = "客户退货管理", url = "" });
            m5.Add(new { id = "181", iconCls = "icon-add", pid = "m5", text = "客户销售单据汇总查询", url = "" });
            m5.Add(new { id = "182", iconCls = "icon-add", pid = "m5", text = "客户销售商品汇总查询", url = "" });
            m5.Add(new { id = "183", iconCls = "icon-add", pid = "m5", text = "客户销售明细查询", url = "" });
            m5.Add(new { id = "184", iconCls = "icon-add", pid = "m5", text = "业务员销售查询", url = "" });
            m5.Add(new { id = "185", iconCls = "icon-add", pid = "m5", text = "客户销售商品毛利分析", url = "" });
            m5.Add(new { id = "186", iconCls = "icon-add", pid = "m5", text = "客户类型设置", url = "/Ws/WsPaCustomerTypeList" });
            m5.Add(new { id = "187", iconCls = "icon-add", pid = "m5", text = "限销商品设置", url = "/Ws/WsWholesaleGoodsSetList" });
            
            m6.Add(new { id = "188", iconCls = "icon-add", pid = "m6", text = "卡类型设置", url = "/Ms/MsCardtypeManageList" });
            m6.Add(new { id = "189", iconCls = "icon-add", pid = "m6", text = "卡折扣设置", url = "/Ms/MsCardtypeDiscountList" });
            m6.Add(new { id = "190", iconCls = "icon-add", pid = "m6", text = "卡积分设置", url = "/Ms/MsCardtypePointsList" });
            m6.Add(new { id = "191", iconCls = "icon-add", pid = "m6", text = "商品折扣设置", url = "/Ms/MsCardtypeGoodsDiscountList" });
            m6.Add(new { id = "192", iconCls = "icon-add", pid = "m6", text = "商品积分设置", url = "/Ms/MsCardtypeGoodsPointsList" });
            m6.Add(new { id = "193", iconCls = "icon-add", pid = "m6", text = "卡制作管理", url = "/Ms/MsMadecardManageList" });
            m6.Add(new { id = "194", iconCls = "icon-add", pid = "m6", text = "会员档案管理", url = "/Ms/MsMemberArchivesList" });
            m6.Add(new { id = "195", iconCls = "icon-add", pid = "m6", text = "卡发放管理", url = "/Ms/MsGrantCardManageList" });
            m6.Add(new { id = "196", iconCls = "icon-add", pid = "m6", text = "卡挂失管理", url = "/Ms/MsLossCardManageList" });
            m6.Add(new { id = "197", iconCls = "icon-add", pid = "m6", text = "卡冻结管理", url = "/Ms/MsFreezeCardManageList" });
            m6.Add(new { id = "198", iconCls = "icon-add", pid = "m6", text = "卡废除管理", url = "/Ms/MsCancelCardManageList" });
            m6.Add(new { id = "199", iconCls = "icon-add", pid = "m6", text = "卡更新管理", url = "/Ms/MsUpdateCardManageList" });
            m6.Add(new { id = "200", iconCls = "icon-add", pid = "m6", text = "卡充值管理", url = "/Ms/MsPrepaidCardManageList" });
            m6.Add(new { id = "201", iconCls = "icon-add", pid = "m6", text = "卡升级管理", url = "/Ms/MsUpgradeCardManageList" });
            m6.Add(new { id = "202", iconCls = "icon-add", pid = "m6", text = "卡回收管理", url = "/Ms/MsReclaimCardManageList" });
            m6.Add(new { id = "203", iconCls = "icon-add", pid = "m6", text = "赠品档案管理", url = "/Ms/MsGiftArchivesList" });
            m6.Add(new { id = "204", iconCls = "icon-add", pid = "m6", text = "赠品兑换管理", url = "/Ms/MsExchangeManageList" });
            m6.Add(new { id = "205", iconCls = "icon-add", pid = "m6", text = "会员积分转储值", url = "/Ms/MsPointtoprepaidManageList" });
            m6.Add(new { id = "206", iconCls = "icon-add", pid = "m6", text = "积分清零管理", url = "/Ms/MsPointsClearList" });
            m6.Add(new { id = "207", iconCls = "icon-add", pid = "m6", text = "积分调整管理", url = "/Ms/MsAdjustPointsList" });
            m6.Add(new { id = "208", iconCls = "icon-add", pid = "m6", text = "会员消费明细查询", url = "" });
            m6.Add(new { id = "209", iconCls = "icon-add", pid = "m6", text = "会员消费汇总查询", url = "" });
            m6.Add(new { id = "210", iconCls = "icon-add", pid = "m6", text = "会员卡信息查询", url = "/Ms/MsCardArchivesList" });
            m6.Add(new { id = "211", iconCls = "icon-add", pid = "m6", text = "无消费会员查询", url = "" });
            m6.Add(new { id = "212", iconCls = "icon-add", pid = "m6", text = "会员储值消费查询", url = "" });
            m6.Add(new { id = "213", iconCls = "icon-add", pid = "m6", text = "会员储值消费汇总查询", url = "" });
            m6.Add(new { id = "214", iconCls = "icon-add", pid = "m6", text = "会员消费排行", url = "" });
            m6.Add(new { id = "215", iconCls = "icon-add", pid = "m6", text = "会员积分排行", url = "" });
            m6.Add(new { id = "216", iconCls = "icon-add", pid = "m6", text = "会员积分转储值查询", url = "" });
            
            m7.Add(new { id = "217", iconCls = "icon-add", pid = "m7", text = "分店档案管理", url = "/Bs/BsBranchArchivesList" });
            m7.Add(new { id = "218", iconCls = "icon-add", pid = "m7", text = "分店订货管理", url = "/Bs/BsSupplyManageList" });
            m7.Add(new { id = "219", iconCls = "icon-add", pid = "m7", text = "分店返货管理", url = "/Bs/BsReturnManageList" });
            m7.Add(new { id = "220", iconCls = "icon-add", pid = "m7", text = "分店配送处理", url = "" });
            m7.Add(new { id = "221", iconCls = "icon-add", pid = "m7", text = "分店配送管理", url = "/Bs/BsSupplyManageList" });
            m7.Add(new { id = "222", iconCls = "icon-add", pid = "m7", text = "配送单批量打印", url = "" });
            m7.Add(new { id = "223", iconCls = "icon-add", pid = "m7", text = "分店商品售价调整", url = "" });
            m7.Add(new { id = "224", iconCls = "icon-add", pid = "m7", text = "分店售价查询", url = "" });
            m7.Add(new { id = "225", iconCls = "icon-add", pid = "m7", text = "分店调拨管理", url = "" });
            m7.Add(new { id = "226", iconCls = "icon-add", pid = "m7", text = "分店订货单据汇总查询", url = "" });
            m7.Add(new { id = "227", iconCls = "icon-add", pid = "m7", text = "分店订货商品汇总查询", url = "" });
            m7.Add(new { id = "228", iconCls = "icon-add", pid = "m7", text = "分店订货商品明细查询", url = "" });
            m7.Add(new { id = "229", iconCls = "icon-add", pid = "m7", text = "分店订货汇总查询", url = "" });
            m7.Add(new { id = "230", iconCls = "icon-add", pid = "m7", text = "分店返货单据汇总查询", url = "" });
            m7.Add(new { id = "231", iconCls = "icon-add", pid = "m7", text = "分店返货商品汇总查询", url = "" });
            m7.Add(new { id = "232", iconCls = "icon-add", pid = "m7", text = "分店返货商品明细查询", url = "" });
            m7.Add(new { id = "233", iconCls = "icon-add", pid = "m7", text = "分店返货汇总查询", url = "" });
            m7.Add(new { id = "234", iconCls = "icon-add", pid = "m7", text = "分店区域设置", url = "/Bs/BsPaAreaList" });
            m7.Add(new { id = "235", iconCls = "icon-add", pid = "m7", text = "分店分类设置", url = "/Bs/BsPaClassList" });
            m7.Add(new { id = "236", iconCls = "icon-add", pid = "m7", text = "分店仓库设置", url = "/Bs/BsPaBranchWarehouseList" });
            
            m8.Add(new { id = "237", iconCls = "icon-add", pid = "m8", text = "帐务日结", url = "" });
            m8.Add(new { id = "238", iconCls = "icon-add", pid = "m8", text = "商品日销售汇总查询", url = "" });
            m8.Add(new { id = "239", iconCls = "icon-add", pid = "m8", text = "商品汇总查询", url = "" });
            m8.Add(new { id = "240", iconCls = "icon-add", pid = "m8", text = "类别日销售汇总查询", url = "" });
            m8.Add(new { id = "241", iconCls = "icon-add", pid = "m8", text = "类别销售汇总查询", url = "" });
            m8.Add(new { id = "242", iconCls = "icon-add", pid = "m8", text = "收银员日汇总查询", url = "" });
            m8.Add(new { id = "243", iconCls = "icon-add", pid = "m8", text = "收银员销售汇总查询", url = "" });
            m8.Add(new { id = "244", iconCls = "icon-add", pid = "m8", text = "营业员日汇总查询", url = "" });
            m8.Add(new { id = "245", iconCls = "icon-add", pid = "m8", text = "营业员销售汇总查询", url = "" });
            m8.Add(new { id = "246", iconCls = "icon-add", pid = "m8", text = "商品负毛利查询", url = "" });
            m8.Add(new { id = "247", iconCls = "icon-add", pid = "m8", text = "时段销售汇总查询", url = "" });
            m8.Add(new { id = "248", iconCls = "icon-add", pid = "m8", text = "商品进销存日报", url = "" });
            m8.Add(new { id = "249", iconCls = "icon-add", pid = "m8", text = "商品进销存汇总", url = "" });
            m8.Add(new { id = "250", iconCls = "icon-add", pid = "m8", text = "类别进销存日报", url = "" });
            m8.Add(new { id = "251", iconCls = "icon-add", pid = "m8", text = "类别进销存汇总", url = "" });
            m8.Add(new { id = "252", iconCls = "icon-add", pid = "m8", text = "供货商进销存日报", url = "" });
            
            m9.Add(new { id = "253", iconCls = "icon-add", pid = "m9", text = "供货商代销对帐", url = "" });
            m9.Add(new { id = "254", iconCls = "icon-add", pid = "m9", text = "供货商联营对帐", url = "" });
            m9.Add(new { id = "255", iconCls = "icon-add", pid = "m9", text = "供货商结算确认", url = "" });
            m9.Add(new { id = "256", iconCls = "icon-add", pid = "m9", text = "供货商结算管理", url = "/Ba/BaSupplierBalanceList" });
            m9.Add(new { id = "257", iconCls = "icon-add", pid = "m9", text = "分店对帐管理", url = "/Ba/BaPoolAccountList" });
            m9.Add(new { id = "258", iconCls = "icon-add", pid = "m9", text = "分店结算管理", url = "/Ba/BaBranchBalanceList" });
            m9.Add(new { id = "259", iconCls = "icon-add", pid = "m9", text = "客户结算管理", url = "/Ba/BaCustomerBalanceList" });
            m9.Add(new { id = "260", iconCls = "icon-add", pid = "m9", text = "费用管理", url = "/Ba/BaChargeManageList" });
            m9.Add(new { id = "261", iconCls = "icon-add", pid = "m9", text = "费用标准", url = "/Ba/BaPaChargeList" });
            m9.Add(new { id = "262", iconCls = "icon-add", pid = "m9", text = "供货商结算汇总查询", url = "" });
            m9.Add(new { id = "263", iconCls = "icon-add", pid = "m9", text = "供货商结算明细查询", url = "" });
            m9.Add(new { id = "264", iconCls = "icon-add", pid = "m9", text = "供货商应付帐款查询", url = "" });
            m9.Add(new { id = "265", iconCls = "icon-add", pid = "m9", text = "分店结算汇总查询", url = "" });
            m9.Add(new { id = "266", iconCls = "icon-add", pid = "m9", text = "分店结算明细查询", url = "" });
            
            m10.Add(new { id = "267", iconCls = "icon-add", pid = "m10", text = "人员档案管理", url = "/Em/EmEmployeeArchivesList" });
            m10.Add(new { id = "268", iconCls = "icon-add", pid = "m10", text = "学历参数设置", url = "/Em/EmPaEducationList" });
            m10.Add(new { id = "269", iconCls = "icon-add", pid = "m10", text = "职称参数设置", url = "/Em/EmPaProfessionalTitleList" });
            m10.Add(new { id = "270", iconCls = "icon-add", pid = "m10", text = "政治面貌参数设置", url = "/Em/EmPaPoliticsList" });
            m10.Add(new { id = "271", iconCls = "icon-add", pid = "m10", text = "民族参数设置", url = "/Em/EmPaNationList" });
            m10.Add(new { id = "272", iconCls = "icon-add", pid = "m10", text = "职务参数设置", url = "/Em/EmPaDutyList" });
            m11.Add(new { id = "273", iconCls = "icon-add", pid = "m11", text = "企业信息设置", url = "/Sys/SysEnterpriseArchivesList" });
            m11.Add(new { id = "274", iconCls = "icon-add", pid = "m11", text = "组织架构设置", url = "" });
            m11.Add(new { id = "275", iconCls = "icon-add", pid = "m11", text = "登陆权限设置", url = "/Sys/SysLoginPowerList" });
            m11.Add(new { id = "276", iconCls = "icon-add", pid = "m11", text = "岗位权限设置", url = "/Sys/SysDepartPowerList" });
            m11.Add(new { id = "277", iconCls = "icon-add", pid = "m11", text = "人员权限设置", url = "/Sys/SysWorkerPowerList" });
            m11.Add(new { id = "278", iconCls = "icon-add", pid = "m11", text = "业务流程设置", url = "/Sys/SysOperationFlowList" });

            results.Add(new { id = "1", iconCls = "icon-add", text = "基础档案", pid = "0", menus = m1 });
            results.Add(new { id = "2", iconCls = "icon-add", text = "采购管理", pid = "0", menus = m2 });
            results.Add(new { id = "3", iconCls = "icon-add", text = "仓库管理", pid = "0", menus = m3 });
            results.Add(new { id = "4", iconCls = "icon-add", text = "销售管理", pid = "0", menus = m4 });
            results.Add(new { id = "5", iconCls = "icon-add", text = "客户销售", pid = "0", menus = m5 });
            results.Add(new { id = "6", iconCls = "icon-add", text = "会员卡券", pid = "0", menus = m6 });
            results.Add(new { id = "7", iconCls = "icon-add", text = "分店配送", pid = "0", menus = m7 });
            results.Add(new { id = "8", iconCls = "icon-add", text = "帐务管理", pid = "0", menus = m8 });
            results.Add(new { id = "9", iconCls = "icon-add", text = "结算管理", pid = "0", menus = m9 });
            results.Add(new { id = "10", iconCls = "icon-add", text = "人力资源", pid = "0", menus = m10 });
            results.Add(new { id = "11", iconCls = "icon-add", text = "系统维护", pid = "0", menus = m11 });

            #region 旧的
            //var ac= new List<object>();
            //var ba=new List<object>();
            //var bs = new List<object>();
            //var em = new List<object>();
            //var fb = new List<object>();
            //var ms = new List<object>();
            //var op = new List<object>();
            //var pc = new List<object>();
            //var rt = new List<object>();
            //var sys = new List<object>();
            //var tf = new List<object>();
            //var tg = new List<object>();
            //var ws = new List<object>();


            //ac.Add(new
            //{
            //    id = "1",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "",
            //    text = "档案",
            //    url = ""
            //});

            //ac.Add(new
            //{
            //    id = "AcBranchGoodssaleAccount",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店商品销售帐表",
            //    url = "/Ac/AcBranchGoodssaleAccountList"
            //});
            //ac.Add(new
            //{
            //    id = "AcCashierSummary",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "收银员销售汇总",
            //    url = "/Ac/AcCashierSummaryList"
            //});
            //ac.Add(new
            //{
            //    id = "AcCounterSummary",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "柜组销售汇总",
            //    url = "/Ac/AcCounterSummaryList"
            //});
            //ac.Add(new
            //{
            //    id = "AcDayBranchclassJournalAccount",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店类别进销存",
            //    url = "/Ac/AcDayBranchclassJournalAccountList"
            //});
            //ac.Add(new
            //{
            //    id = "AcDayBranchgoodsJournalAccount",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店商品进销存日帐",
            //    url = "/Ac/AcDayBranchgoodsJournalAccountList"
            //});
            //ac.Add(new
            //{
            //    id = "AcDayClassJournalAccount",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "类别进销存日帐",
            //    url = "/Ac/AcDayClassJournalAccountList"
            //});
            //ac.Add(new
            //{
            //    id = "AcDayGoodsJournalAccount",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品进销存日帐",
            //    url = "/Ac/AcDayGoodsJournalAccountList"
            //});
            //ac.Add(new
            //{
            //    id = "AcDayGoodsJournalAccountTemp",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品进销存日帐临时表",
            //    url = "/Ac/AcDayGoodsJournalAccountTempList"
            //});
            //ac.Add(new
            //{
            //    id = "AcDayGoodsstockJournalAccount",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "总部商品进销存日帐",
            //    url = "/Ac/AcDayGoodsstockJournalAccountList"
            //});
            //ac.Add(new
            //{
            //    id = "AcDayGoodsstockJournalAccountTemp",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "总部商品进销存日帐临时表",
            //    url = "/Ac/AcDayGoodsstockJournalAccountTempList"
            //});
            //ac.Add(new
            //{
            //    id = "AcGoodssaleAccount",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品销售帐表",
            //    url = "/Ac/AcGoodssaleAccountList"
            //});
            //ac.Add(new
            //{
            //    id = "AcMonthClassJournalAccount",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "类别进销存月帐",
            //    url = "/Ac/AcMonthClassJournalAccountList"
            //});
            //ac.Add(new
            //{
            //    id = "AcMonthGoodsJournalAccount",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品进销存月帐",
            //    url = "/Ac/AcMonthGoodsJournalAccountList"
            //});
            //ac.Add(new
            //{
            //    id = "AcPaDayaccount",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "日帐设置",
            //    url = "/Ac/AcPaDayaccountList"
            //});
            //ac.Add(new
            //{
            //    id = "AcPaDayaccountStock",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "总部日帐设置",
            //    url = "/Ac/AcPaDayaccountStockList"
            //});
            //ac.Add(new
            //{
            //    id = "AcPaSaleset",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "销售记账设置",
            //    url = "/Ac/AcPaSalesetList"
            //});
            //ac.Add(new
            //{
            //    id = "AcPeriodTimeSummary",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "客流销售汇总",
            //    url = "/Ac/AcPeriodTimeSummaryList"
            //});
            //ac.Add(new
            //{
            //    id = "AcSalesmanSummary",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "营业员销售汇总",
            //    url = "/Ac/AcSalesmanSummaryList"
            //});
            //ac.Add(new
            //{
            //    id = "AcStockAccount",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品帐务库存",
            //    url = "/Ac/AcStockAccountList"
            //});
            //ac.Add(new
            //{
            //    id = "AcSupplierJournal",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "供货商流水帐",
            //    url = "/Ac/AcSupplierJournalList"
            //});

            //ba.Add(new
            //{
            //    id = "BaBranchBalance",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店结算",
            //    url = "/Ba/BaBranchBalanceList"
            //});
            //ba.Add(new
            //{
            //    id = "BaBranchDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店结算明细",
            //    url = "/Ba/BaBranchDetailList"
            //});
            //ba.Add(new
            //{
            //    id = "BaBranchOfferAccount",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店代销对帐",
            //    url = "/Ba/BaBranchOfferAccountList"
            //});
            //ba.Add(new
            //{
            //    id = "BaBranchOfferDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店代销对帐明细",
            //    url = "/Ba/BaBranchOfferDetailList"
            //});
            //ba.Add(new
            //{
            //    id = "BaChargeDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "费用费用费用明细",
            //    url = "/Ba/BaChargeDetailList"
            //});
            //ba.Add(new
            //{
            //    id = "BaChargeManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "费用管理",
            //    url = "/Ba/BaChargeManageList"
            //});
            //ba.Add(new
            //{
            //    id = "BaCustomerBalance",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "客户结算",
            //    url = "/Ba/BaCustomerBalanceList"
            //});
            //ba.Add(new
            //{
            //    id = "BaCustomerDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "客户结算明细",
            //    url = "/Ba/BaCustomerDetailList"
            //});
            //ba.Add(new
            //{
            //    id = "BaLeaseAccount",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "租赁对帐单",
            //    url = "/Ba/BaLeaseAccountList"
            //});
            //ba.Add(new
            //{
            //    id = "BaLeaseDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "租赁对帐单商品明细",
            //    url = "/Ba/BaLeaseDetailList"
            //});
            //ba.Add(new
            //{
            //    id = "BaOfferAccount",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "代销对账单",
            //    url = "/Ba/BaOfferAccountList"
            //});
            //ba.Add(new
            //{
            //    id = "BaOfferDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "代销对账单商品明细",
            //    url = "/Ba/BaOfferDetailList"
            //});
            //ba.Add(new
            //{
            //    id = "BaPaAccount",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "结算对账设置",
            //    url = "/Ba/BaPaAccountList"
            //});
            //ba.Add(new
            //{
            //    id = "BaPaBranchAccount",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店对帐设置",
            //    url = "/Ba/BaPaBranchAccountList"
            //});
            //ba.Add(new
            //{
            //    id = "BaPaCharge",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "费用设置",
            //    url = "/Ba/BaPaChargeList"
            //});
            //ba.Add(new
            //{
            //    id = "BaPoolAccount",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "联营对帐单",
            //    url = "/Ba/BaPoolAccountList"
            //});
            //ba.Add(new
            //{
            //    id = "BaPoolDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "联营对帐单商品明细",
            //    url = "/Ba/BaPoolDetailList"
            //});
            //ba.Add(new
            //{
            //    id = "BaSupplierBalance",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "供货商结算",
            //    url = "/Ba/BaSupplierBalanceList"
            //});
            //ba.Add(new
            //{
            //    id = "BaSupplierDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "供货商结算明细",
            //    url = "/Ba/BaSupplierDetailList"
            //});
            //bs.Add(new
            //{
            //    id = "BsAdjustSaleprice",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店商品调价",
            //    url = "/Bs/BsAdjustSalepriceList"
            //});
            //bs.Add(new
            //{
            //    id = "BsAdjustSalepriceGoods",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店商品调价商品明细",
            //    url = "/Bs/BsAdjustSalepriceGoodsList"
            //});
            //bs.Add(new
            //{
            //    id = "BsBranchAllotDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店调拨商品",
            //    url = "/Bs/BsBranchAllotDetailList"
            //});
            //bs.Add(new
            //{
            //    id = "BsBranchAllotManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店调拨",
            //    url = "/Bs/BsBranchAllotManageList"
            //});
            //bs.Add(new
            //{
            //    id = "BsBranchArchives",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店档案管理",
            //    url = "/Bs/BsBranchArchivesList"
            //});
            //bs.Add(new
            //{
            //    id = "BsBranchPrice",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店商品价格",
            //    url = "/Bs/BsBranchPriceList"
            //});
            //bs.Add(new
            //{
            //    id = "BsPaArea",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店区域",
            //    url = "/Bs/BsPaAreaList"
            //});
            //bs.Add(new
            //{
            //    id = "BsPaBranchWarehouse",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店仓库设置",
            //    url = "/Bs/BsPaBranchWarehouseList"
            //});
            //bs.Add(new
            //{
            //    id = "BsPaClass",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店分类",
            //    url = "/Bs/BsPaClassList"
            //});
            //bs.Add(new
            //{
            //    id = "BsReturnDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店商品返货单明细",
            //    url = "/Bs/BsReturnDetailList"
            //});
            //bs.Add(new
            //{
            //    id = "BsReturnManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店商品返货单",
            //    url = "/Bs/BsReturnManageList"
            //});
            //bs.Add(new
            //{
            //    id = "BsReturnManageFlow",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店商品返货单流水",
            //    url = "/Bs/BsReturnManageFlowList"
            //});
            //bs.Add(new
            //{
            //    id = "BsSupplyDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店订货配送单明细",
            //    url = "/Bs/BsSupplyDetailList"
            //});
            //bs.Add(new
            //{
            //    id = "BsSupplyManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店商品订货配送单",
            //    url = "/Bs/BsSupplyManageList"
            //});
            //bs.Add(new
            //{
            //    id = "BsSupplyManageFlow",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "分店商品订货配送单流水",
            //    url = "/Bs/BsSupplyManageFlowList"
            //});

            //em.Add(new
            //{
            //    id = "EmEmployeeArchives",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "人员档案",
            //    url = "/Em/EmEmployeeArchivesList"
            //});
            //em.Add(new
            //{
            //    id = "EmEmployeeFamily",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "人员家庭信息",
            //    url = "/Em/EmEmployeeFamilyList"
            //});
            //em.Add(new
            //{
            //    id = "EmEmployeePhoto",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "人员照片",
            //    url = "/Em/EmEmployeePhotoList"
            //});
            //em.Add(new
            //{
            //    id = "EmPaDuty",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "职务编码表",
            //    url = "/Em/EmPaDutyList"
            //});
            //em.Add(new
            //{
            //    id = "EmPaEducation",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "学历编码表",
            //    url = "/Em/EmPaEducationList"
            //});
            //em.Add(new
            //{
            //    id = "EmPaNation",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "民族编码表",
            //    url = "/Em/EmPaNationList"
            //});
            //em.Add(new
            //{
            //    id = "EmPaPolitics",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "政治面貌编码表",
            //    url = "/Em/EmPaPoliticsList"
            //});
            //em.Add(new
            //{
            //    id = "EmPaProfessionalTitle",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "职称编码表",
            //    url = "/Em/EmPaProfessionalTitleList"
            //});
            //fb.Add(new
            //{
            //    id = "FbAdjustClass",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "调商品所属类别",
            //    url = "/Fb/FbAdjustClassList"
            //});
            //fb.Add(new
            //{
            //    id = "FbAdjustClassGoods",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "调商品所属类别商品明细",
            //    url = "/Fb/FbAdjustClassGoodsList"
            //});
            //fb.Add(new
            //{
            //    id = "FbAdjustPoolrate",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "调商品扣率",
            //    url = "/Fb/FbAdjustPoolrateList"
            //});
            //fb.Add(new
            //{
            //    id = "FbAdjustPoolrateGoods",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "调商品扣率商品明细",
            //    url = "/Fb/FbAdjustPoolrateGoodsList"
            //});
            //fb.Add(new
            //{
            //    id = "FbAdjustPurchaseprice",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "调商品进价",
            //    url = "/Fb/FbAdjustPurchasepriceList"
            //});
            //fb.Add(new
            //{
            //    id = "FbAdjustPurchasepriceGoods",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "调商品进价商品明细",
            //    url = "/Fb/FbAdjustPurchasepriceGoodsList"
            //});
            //fb.Add(new
            //{
            //    id = "FbAdjustSaleprice",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "调商品售价",
            //    url = "/Fb/FbAdjustSalepriceList"
            //});
            //fb.Add(new
            //{
            //    id = "FbAdjustSalepriceGoods",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "调商品售价商品明细",
            //    url = "/Fb/FbAdjustSalepriceGoodsList"
            //});
            //fb.Add(new
            //{
            //    id = "FbAdjustSupplier",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "调商品供货商",
            //    url = "/Fb/FbAdjustSupplierList"
            //});
            //fb.Add(new
            //{
            //    id = "FbAdjustSupplierGoods",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "调商品供货商商品明细",
            //    url = "/Fb/FbAdjustSupplierGoodsList"
            //});
            //fb.Add(new
            //{
            //    id = "FbGoodsArchives",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品档案",
            //    url = "/Fb/FbGoodsArchivesList"
            //});
            //fb.Add(new
            //{
            //    id = "FbGoodsArchivesBar",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品销售码",
            //    url = "/Fb/FbGoodsArchivesBarList"
            //});
            //fb.Add(new
            //{
            //    id = "FbGoodsArchivesBind",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品捆绑",
            //    url = "/Fb/FbGoodsArchivesBindList"
            //});
            //fb.Add(new
            //{
            //    id = "FbGoodsArchivesLibrary",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品条码库",
            //    url = "/Fb/FbGoodsArchivesLibraryList"
            //});
            //fb.Add(new
            //{
            //    id = "FbGoodsArchivesParts",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品部件",
            //    url = "/Fb/FbGoodsArchivesPartsList"
            //});
            //fb.Add(new
            //{
            //    id = "FbGoodsArchivesPhoto",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品视图表",
            //    url = "/Fb/FbGoodsArchivesPhotoList"
            //});
            //fb.Add(new
            //{
            //    id = "FbGoodsArchivesSupplier",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品供货商",
            //    url = "/Fb/FbGoodsArchivesSupplierList"
            //});
            //fb.Add(new
            //{
            //    id = "FbGoodsBarCode",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "销售编码表",
            //    url = "/Fb/FbGoodsBarCodeList"
            //});
            //fb.Add(new
            //{
            //    id = "FbPaBaseSet",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "基础参数设置",
            //    url = "/Fb/FbPaBaseSetList"
            //});
            //fb.Add(new
            //{
            //    id = "FbPaGoodsCheckUnit",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "核算单位编码",
            //    url = "/Fb/FbPaGoodsCheckUnitList"
            //});
            //fb.Add(new
            //{
            //    id = "FbPaGoodsCounter",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "柜组编码",
            //    url = "/Fb/FbPaGoodsCounterList"
            //});
            //fb.Add(new
            //{
            //    id = "FbPaGoodsGb",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "大类编码",
            //    url = "/Fb/FbPaGoodsGbList"
            //});
            //fb.Add(new
            //{
            //    id = "FbPaGoodsGl",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "细类编码",
            //    url = "/Fb/FbPaGoodsGlList"
            //});
            //fb.Add(new
            //{
            //    id = "FbPaGoodsGm",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "中类编码",
            //    url = "/Fb/FbPaGoodsGmList"
            //});
            //fb.Add(new
            //{
            //    id = "FbPaGoodsGs",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "小类编码",
            //    url = "/Fb/FbPaGoodsGsList"
            //});
            //fb.Add(new
            //{
            //    id = "FbPaGoodsPackUnit",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "包装单位编码",
            //    url = "/Fb/FbPaGoodsPackUnitList"
            //});
            //fb.Add(new
            //{
            //    id = "FbPaSupType",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "供货商类型",
            //    url = "/Fb/FbPaSupTypeList"
            //});
            //fb.Add(new
            //{
            //    id = "FbSupplierArchives",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "供货商档案",
            //    url = "/Fb/FbSupplierArchivesList"
            //});
            //fb.Add(new
            //{
            //    id = "FbSupplierLease",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "供货商租赁合同",
            //    url = "/Fb/FbSupplierLeaseList"
            //});
            //ms.Add(new
            //{
            //    id = "MsAdjustPoints",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "积分调整管理",
            //    url = "/Ms/MsAdjustPointsList"
            //});
            //ms.Add(new
            //{
            //    id = "MsCancelCardManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "卡作废",
            //    url = "/Ms/MsCancelCardManageList"
            //});
            //ms.Add(new
            //{
            //    id = "MsCardArchives",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "卡信息",
            //    url = "/Ms/MsCardArchivesList"
            //});
            //ms.Add(new
            //{
            //    id = "MsCardtypeDiscount",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "卡折扣",
            //    url = "/Ms/MsCardtypeDiscountList"
            //});
            //ms.Add(new
            //{
            //    id = "MsCardtypeGoodsDiscount",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品折扣",
            //    url = "/Ms/MsCardtypeGoodsDiscountList"
            //});
            //ms.Add(new
            //{
            //    id = "MsCardtypeGoodsPoints",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品积分",
            //    url = "/Ms/MsCardtypeGoodsPointsList"
            //});
            //ms.Add(new
            //{
            //    id = "MsCardtypeManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "卡类型",
            //    url = "/Ms/MsCardtypeManageList"
            //});
            //ms.Add(new
            //{
            //    id = "MsCardtypePoints",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "卡积分",
            //    url = "/Ms/MsCardtypePointsList"
            //});
            //ms.Add(new
            //{
            //    id = "MsExchangeDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "赠品兑换明细",
            //    url = "/Ms/MsExchangeDetailList"
            //});
            //ms.Add(new
            //{
            //    id = "MsExchangeManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "赠品兑换管理",
            //    url = "/Ms/MsExchangeManageList"
            //});
            //ms.Add(new
            //{
            //    id = "MsFreezeCardManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "卡冻结",
            //    url = "/Ms/MsFreezeCardManageList"
            //});
            //ms.Add(new
            //{
            //    id = "MsGiftArchives",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "赠品档案管理",
            //    url = "/Ms/MsGiftArchivesList"
            //});
            //ms.Add(new
            //{
            //    id = "MsGrantCardManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "卡发放",
            //    url = "/Ms/MsGrantCardManageList"
            //});
            //ms.Add(new
            //{
            //    id = "MsLossCardManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "卡挂失",
            //    url = "/Ms/MsLossCardManageList"
            //});
            //ms.Add(new
            //{
            //    id = "MsMadecardManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "卡制作",
            //    url = "/Ms/MsMadecardManageList"
            //});
            //ms.Add(new
            //{
            //    id = "MsMemberArchives",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "会员信息",
            //    url = "/Ms/MsMemberArchivesList"
            //});
            //ms.Add(new
            //{
            //    id = "MsPointsClear",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "积分清零管理",
            //    url = "/Ms/MsPointsClearList"
            //});
            //ms.Add(new
            //{
            //    id = "MsPointtoprepaidManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "积分转储值",
            //    url = "/Ms/MsPointtoprepaidManageList"
            //});
            //ms.Add(new
            //{
            //    id = "MsPrepaidCardManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "卡充值",
            //    url = "/Ms/MsPrepaidCardManageList"
            //});
            //ms.Add(new
            //{
            //    id = "MsReclaimCardManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "卡回收",
            //    url = "/Ms/MsReclaimCardManageList"
            //});
            //ms.Add(new
            //{
            //    id = "MsUpdateCardManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "卡更新",
            //    url = "/Ms/MsUpdateCardManageList"
            //});
            //ms.Add(new
            //{
            //    id = "MsUpgradeCardDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "卡升级信息",
            //    url = "/Ms/MsUpgradeCardDetailList"
            //});
            //ms.Add(new
            //{
            //    id = "MsUpgradeCardManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "卡升级",
            //    url = "/Ms/MsUpgradeCardManageList"
            //});
            //op.Add(new
            //{
            //    id = "OpAdjustDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品调整单商品明细",
            //    url = "/Op/OpAdjustDetailList"
            //});
            //op.Add(new
            //{
            //    id = "OpAdjustManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品调整单",
            //    url = "/Op/OpAdjustManageList"
            //});
            //op.Add(new
            //{
            //    id = "OpAdjustManageFlow",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品调整流水帐单",
            //    url = "/Op/OpAdjustManageFlowList"
            //});
            //op.Add(new
            //{
            //    id = "OpAdjustPurchaseDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "进货成本调整批次明细",
            //    url = "/Op/OpAdjustPurchaseDetailList"
            //});
            //op.Add(new
            //{
            //    id = "OpAdjustPurchaseManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "进货成本调整单",
            //    url = "/Op/OpAdjustPurchaseManageList"
            //});
            //op.Add(new
            //{
            //    id = "OpAllotDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品调拨单商品明细",
            //    url = "/Op/OpAllotDetailList"
            //});
            //op.Add(new
            //{
            //    id = "OpAllotManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品调拨单",
            //    url = "/Op/OpAllotManageList"
            //});
            //op.Add(new
            //{
            //    id = "OpAllotManageFlow",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品调拨流水帐单",
            //    url = "/Op/OpAllotManageFlowList"
            //});
            //op.Add(new
            //{
            //    id = "OpCheckDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品盘点单商品明细",
            //    url = "/Op/OpCheckDetailList"
            //});
            //op.Add(new
            //{
            //    id = "OpCheckManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品盘点单",
            //    url = "/Op/OpCheckManageList"
            //});
            //op.Add(new
            //{
            //    id = "OpCheckStock",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "盘点库存",
            //    url = "/Op/OpCheckStockList"
            //});
            //op.Add(new
            //{
            //    id = "OpCheckTransfer",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品盘点接转单商品汇总明细",
            //    url = "/Op/OpCheckTransferList"
            //});
            //op.Add(new
            //{
            //    id = "OpDynamicStock",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品实时库存",
            //    url = "/Op/OpDynamicStockList"
            //});
            //op.Add(new
            //{
            //    id = "OpDynamicStockBranch",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品分店实时库存",
            //    url = "/Op/OpDynamicStockBranchList"
            //});
            //op.Add(new
            //{
            //    id = "OpDynamicStockWh",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品仓储实时库存",
            //    url = "/Op/OpDynamicStockWhList"
            //});
            //op.Add(new
            //{
            //    id = "OpGoodsBatch",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品库存批次表",
            //    url = "/Op/OpGoodsBatchList"
            //});
            //op.Add(new
            //{
            //    id = "OpLossDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品损溢商品明细",
            //    url = "/Op/OpLossDetailList"
            //});
            //op.Add(new
            //{
            //    id = "OpLossManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品损溢",
            //    url = "/Op/OpLossManageList"
            //});
            //op.Add(new
            //{
            //    id = "OpLossManageFlow",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品损溢流水帐单",
            //    url = "/Op/OpLossManageFlowList"
            //});
            //op.Add(new
            //{
            //    id = "OpPaWarehouse",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "仓库参数维护",
            //    url = "/Op/OpPaWarehouseList"
            //});
            //op.Add(new
            //{
            //    id = "OpSplitComDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "组合拆零管理商品明细",
            //    url = "/Op/OpSplitComDetailList"
            //});
            //op.Add(new
            //{
            //    id = "OpSplitComGoods",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "组合拆零商品",
            //    url = "/Op/OpSplitComGoodsList"
            //});
            //op.Add(new
            //{
            //    id = "OpSplitComManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "组合拆零管理",
            //    url = "/Op/OpSplitComManageList"
            //});
            //op.Add(new
            //{
            //    id = "OpSplitComManageFlow",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "组合拆零管理流水单",
            //    url = "/Op/OpSplitComManageFlowList"
            //});
            //pc.Add(new
            //{
            //    id = "PcPurchaseDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品采购单商品明细",
            //    url = "/Pc/PcPurchaseDetailList"
            //});
            //pc.Add(new
            //{
            //    id = "PcPurchaseManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品采购单",
            //    url = "/Pc/PcPurchaseManageList"
            //});
            //pc.Add(new
            //{
            //    id = "PcPutinDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品入库单商品明细",
            //    url = "/Pc/PcPutinDetailList"
            //});
            //pc.Add(new
            //{
            //    id = "PcPutinManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品入库单",
            //    url = "/Pc/PcPutinManageList"
            //});
            //pc.Add(new
            //{
            //    id = "PcPutoutDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品出库单商品明细",
            //    url = "/Pc/PcPutoutDetailList"
            //});
            //pc.Add(new
            //{
            //    id = "PcPutoutManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品出库单",
            //    url = "/Pc/PcPutoutManageList"
            //});
            //pc.Add(new
            //{
            //    id = "PcReturnDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品返货单商品明细",
            //    url = "/Pc/PcReturnDetailList"
            //});
            //pc.Add(new
            //{
            //    id = "PcReturnManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "商品返货单",
            //    url = "/Pc/PcReturnManageList"
            //});
            //rt.Add(new
            //{
            //    id = "RtClassPromotion",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "类别促销",
            //    url = "/Rt/RtClassPromotionList"
            //});
            //rt.Add(new
            //{
            //    id = "RtClassPromotionBranch",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "类别促销分店",
            //    url = "/Rt/RtClassPromotionBranchList"
            //});
            //rt.Add(new
            //{
            //    id = "RtClassPromotionGoods",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "类别促销商品明细",
            //    url = "/Rt/RtClassPromotionGoodsList"
            //});
            //rt.Add(new
            //{
            //    id = "RtPaFunction",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "收银功能表",
            //    url = "/Rt/RtPaFunctionList"
            //});
            //rt.Add(new
            //{
            //    id = "RtPaPayway",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "付款方式",
            //    url = "/Rt/RtPaPaywayList"
            //});
            //rt.Add(new
            //{
            //    id = "RtPaPos",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "POS机设置",
            //    url = "/Rt/RtPaPosList"
            //});
            //rt.Add(new
            //{
            //    id = "RtPaSaleset",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "销售设置",
            //    url = "/Rt/RtPaSalesetList"
            //});
            //rt.Add(new
            //{
            //    id = "RtPaShift",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "销售班次",
            //    url = "/Rt/RtPaShiftList"
            //});
            //rt.Add(new
            //{
            //    id = "RtPluPromotion",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "单品促销",
            //    url = "/Rt/RtPluPromotionList"
            //});
            //rt.Add(new
            //{
            //    id = "RtPluPromotionBranch",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "单品促销分店",
            //    url = "/Rt/RtPluPromotionBranchList"
            //});
            //rt.Add(new
            //{
            //    id = "RtPluPromotionGoods",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "单品促销商品明细",
            //    url = "/Rt/RtPluPromotionGoodsList"
            //});
            //rt.Add(new
            //{
            //    id = "RtPresentPromotion",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "馈赠促销",
            //    url = "/Rt/RtPresentPromotionList"
            //});
            //rt.Add(new
            //{
            //    id = "RtPresentPromotionBranch",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "馈赠促销分店",
            //    url = "/Rt/RtPresentPromotionBranchList"
            //});
            //rt.Add(new
            //{
            //    id = "RtPresentPromotionGoods",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "馈赠促销商品明细",
            //    url = "/Rt/RtPresentPromotionGoodsList"
            //});
            //rt.Add(new
            //{
            //    id = "RtRetailDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "销售表商品明细",
            //    url = "/Rt/RtRetailDetailList"
            //});
            //rt.Add(new
            //{
            //    id = "RtRetailManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "销售主表",
            //    url = "/Rt/RtRetailManageList"
            //});
            //rt.Add(new
            //{
            //    id = "RtRetailPay",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "销售表付款表",
            //    url = "/Rt/RtRetailPayList"
            //});
            //rt.Add(new
            //{
            //    id = "RtSheetPromotion",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "整单促销",
            //    url = "/Rt/RtSheetPromotionList"
            //});
            //rt.Add(new
            //{
            //    id = "RtSheetPromotionBranch",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "整单促销分店",
            //    url = "/Rt/RtSheetPromotionBranchList"
            //});
            //rt.Add(new
            //{
            //    id = "RtSheetPromotionGoods",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "整单促销商品明细",
            //    url = "/Rt/RtSheetPromotionGoodsList"
            //});

            //sys.Add(new
            //{
            //    id = "SysClassPower",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "类别权限设置",
            //    url = "/Sys/SysClassPowerList"
            //});
            //sys.Add(new
            //{
            //    id = "SysDepartPower",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "岗位权限",
            //    url = "/Sys/SysDepartPowerList"
            //});
            //sys.Add(new
            //{
            //    id = "SysEnterpriseArchives",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "企业设置",
            //    url = "/Sys/SysEnterpriseArchivesList"
            //});
            //sys.Add(new
            //{
            //    id = "SysLoginPower",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "登录权限设置",
            //    url = "/Sys/SysLoginPowerList"
            //});
            //sys.Add(new
            //{
            //    id = "SysLoginPowerFunction",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "人员收银功能",
            //    url = "/Sys/SysLoginPowerFunctionList"
            //});
            //sys.Add(new
            //{
            //    id = "SysModule",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "功能模块设置",
            //    url = "/Sys/SysModuleList"
            //});
            //sys.Add(new
            //{
            //    id = "SysModuleContent",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "模块相关信息",
            //    url = "/Sys/SysModuleContentList"
            //});
            //sys.Add(new
            //{
            //    id = "SysModulePic",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "系统模块图片",
            //    url = "/Sys/SysModulePicList"
            //});
            //sys.Add(new
            //{
            //    id = "SysOperationFlow",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "业务流程",
            //    url = "/Sys/SysOperationFlowList"
            //});
            //sys.Add(new
            //{
            //    id = "SysOperationFlowDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "业务流程明细",
            //    url = "/Sys/SysOperationFlowDetailList"
            //});
            //sys.Add(new
            //{
            //    id = "SysOperationFlowDetailMax",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "流程最大编号表",
            //    url = "/Sys/SysOperationFlowDetailMaxList"
            //});
            //sys.Add(new
            //{
            //    id = "SysOperationWorker",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "业务流程人员权限",
            //    url = "/Sys/SysOperationWorkerList"
            //});
            //sys.Add(new
            //{
            //    id = "SysPaDepartment",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "部门编码表",
            //    url = "/Sys/SysPaDepartmentList"
            //});
            //sys.Add(new
            //{
            //    id = "SysPrintDesign",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "打印模板设计",
            //    url = "/Sys/SysPrintDesignList"
            //});
            //sys.Add(new
            //{
            //    id = "SysWorkerPower",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "人员权限",
            //    url = "/Sys/SysWorkerPowerList"
            //});
            //tf.Add(new
            //{
            //    id = "TfDataDownload",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "通讯临时表",
            //    url = "/Tf/TfDataDownloadList"
            //});
            //tf.Add(new
            //{
            //    id = "TfDataObject",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "通讯配置表表名",
            //    url = "/Tf/TfDataObjectList"
            //});
            //tf.Add(new
            //{
            //    id = "TfDataProperty",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "通讯配置表字段",
            //    url = "/Tf/TfDataPropertyList"
            //});
            //tg.Add(new
            //{
            //    id = "TgExpostorBalance",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "讲解员结算管理",
            //    url = "/Tg/TgExpostorBalanceList"
            //});
            //tg.Add(new
            //{
            //    id = "TgExpostorBalanceDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "讲解员结算明细",
            //    url = "/Tg/TgExpostorBalanceDetailList"
            //});
            //tg.Add(new
            //{
            //    id = "TgGroupBalance",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "团队结算管理",
            //    url = "/Tg/TgGroupBalanceList"
            //});
            //tg.Add(new
            //{
            //    id = "TgGroupBalanceDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "团队结算明细",
            //    url = "/Tg/TgGroupBalanceDetailList"
            //});
            //tg.Add(new
            //{
            //    id = "TgGroupCall",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "团队策略提醒",
            //    url = "/Tg/TgGroupCallList"
            //});
            //tg.Add(new
            //{
            //    id = "TgGuideArchives",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "导游人员信息",
            //    url = "/Tg/TgGuideArchivesList"
            //});
            //tg.Add(new
            //{
            //    id = "TgGuideBalance",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "导游结算管理",
            //    url = "/Tg/TgGuideBalanceList"
            //});
            //tg.Add(new
            //{
            //    id = "TgGuideBalanceDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "导游结算明细",
            //    url = "/Tg/TgGuideBalanceDetailList"
            //});
            //tg.Add(new
            //{
            //    id = "TgPaCarsCharge",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "车停策略设置",
            //    url = "/Tg/TgPaCarsChargeList"
            //});
            //tg.Add(new
            //{
            //    id = "TgPaCarsType",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "车型设置",
            //    url = "/Tg/TgPaCarsTypeList"
            //});
            //tg.Add(new
            //{
            //    id = "TgPaGroup",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "团队结算设置",
            //    url = "/Tg/TgPaGroupList"
            //});
            //tg.Add(new
            //{
            //    id = "TgPaGroupType",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "团队类别",
            //    url = "/Tg/TgPaGroupTypeList"
            //});
            //tg.Add(new
            //{
            //    id = "TgPaTaType",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "旅行社类型",
            //    url = "/Tg/TgPaTaTypeList"
            //});
            //tg.Add(new
            //{
            //    id = "TgPushtacDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "人员提成策略明细",
            //    url = "/Tg/TgPushtacDetailList"
            //});
            //tg.Add(new
            //{
            //    id = "TgPushtacManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "人员提成策略",
            //    url = "/Tg/TgPushtacManageList"
            //});
            //tg.Add(new
            //{
            //    id = "TgTourgroupManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "团队购物管理",
            //    url = "/Tg/TgTourgroupManageList"
            //});
            //tg.Add(new
            //{
            //    id = "TgTravelArchives",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "旅行社档案",
            //    url = "/Tg/TgTravelArchivesList"
            //});
            //tg.Add(new
            //{
            //    id = "TgTravelArchivesPushtac",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "旅行社提成策略",
            //    url = "/Tg/TgTravelArchivesPushtacList"
            //});
            //tg.Add(new
            //{
            //    id = "TgTravelBalance",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "旅行社结算管理",
            //    url = "/Tg/TgTravelBalanceList"
            //});
            //tg.Add(new
            //{
            //    id = "TgTravelBalanceDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "旅行社结算明细",
            //    url = "/Tg/TgTravelBalanceDetailList"
            //});
            //ws.Add(new
            //{
            //    id = "WsCustomerArchives",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "客户档案",
            //    url = "/Ws/WsCustomerArchivesList"
            //});
            //ws.Add(new
            //{
            //    id = "WsCustomerGoods",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "客户商品",
            //    url = "/Ws/WsCustomerGoodsList"
            //});
            //ws.Add(new
            //{
            //    id = "WsOrderDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "批发订单商品明细",
            //    url = "/Ws/WsOrderDetailList"
            //});
            //ws.Add(new
            //{
            //    id = "WsOrderManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "批发订单",
            //    url = "/Ws/WsOrderManageList"
            //});
            //ws.Add(new
            //{
            //    id = "WsPaCustomerType",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "客户类型",
            //    url = "/Ws/WsPaCustomerTypeList"
            //});
            //ws.Add(new
            //{
            //    id = "WsWholesaleDetail",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "批发销售商品明细",
            //    url = "/Ws/WsWholesaleDetailList"
            //});
            //ws.Add(new
            //{
            //    id = "WsWholesaleGoodsSet",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "限销商品设置",
            //    url = "/Ws/WsWholesaleGoodsSetList"
            //});
            //ws.Add(new
            //{
            //    id = "WsWholesaleManage",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "批发销售",
            //    url = "/Ws/WsWholesaleManageList"
            //});
            //ws.Add(new
            //{
            //    id = "WsWholesaleManageFlow",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "1",
            //    text = "批发销售流水",
            //    url = "/Ws/WsWholesaleManageFlowList"
            //});

            //results.Add(new{
            //    id = "ac",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "0",
            //    text = "AC",
            //    menus=ac
            //});
            //results.Add(new{
            //    id = "ba",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "0",
            //    text = "BA",
            //    menus=ba
            //});
            //results.Add(new{
            //    id = "bs",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "0",
            //    text = "BS",
            //    menus=bs
            //});
            //results.Add(new{
            //    id = "em",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "0",
            //    text = "EM",
            //    menus=em
            //});
            //results.Add(new{
            //    id = "fb",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "0",
            //    text = "FB",
            //    menus=fb
            //});
            //results.Add(new{
            //    id = "ms",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "0",
            //    text = "MS",
            //    menus=ms
            //});
            //results.Add(new{
            //    id = "op",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "0",
            //    text = "OP",
            //    menus=op
            //});
            //results.Add(new{
            //    id = "pc",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "0",
            //    text = "PC",
            //    menus=pc
            //});
            //results.Add(new{
            //    id = "rt",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "0",
            //    text = "RT",
            //    menus=rt
            //});
            //results.Add(new{
            //    id = "sys",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "0",
            //    text = "sys",
            //    menus=sys
            //});
            //results.Add(new{
            //    id = "tf",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "0",
            //    text = "TF",
            //    menus=tf
            //});
            //results.Add(new{
            //    id = "tg",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "0",
            //    text = "TG",
            //    menus=tg
            //});
            //results.Add(new
            //{
            //    id = "ws",
            //    iconCls = "icon-add",
            //    newwindow = false,
            //    pid = "0",
            //    text = "WS",
            //    menus = ws
            //});
            #endregion
            return Json(results, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetModules()
        {
            
            var r = new List<object>();
            r.Add(new
            {
                id = "1",
                iconCls = "icon-add",
                newwindow = false,
                pid = "",
                text = "档案",
                url = ""
            });

            r.Add(new
            {
                id = "AcBranchGoodssaleAccount",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店商品销售帐表",
                url = "/Ac/AcBranchGoodssaleAccountList"
            });
            r.Add(new
            {
                id = "AcCashierSummary",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "收银员销售汇总",
                url = "/Ac/AcCashierSummaryList"
            });
            r.Add(new
            {
                id = "AcCounterSummary",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "柜组销售汇总",
                url = "/Ac/AcCounterSummaryList"
            });
            r.Add(new
            {
                id = "AcDayBranchclassJournalAccount",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店类别进销存",
                url = "/Ac/AcDayBranchclassJournalAccountList"
            });
            r.Add(new
            {
                id = "AcDayBranchgoodsJournalAccount",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店商品进销存日帐",
                url = "/Ac/AcDayBranchgoodsJournalAccountList"
            });
            r.Add(new
            {
                id = "AcDayClassJournalAccount",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "类别进销存日帐",
                url = "/Ac/AcDayClassJournalAccountList"
            });
            r.Add(new
            {
                id = "AcDayGoodsJournalAccount",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品进销存日帐",
                url = "/Ac/AcDayGoodsJournalAccountList"
            });
            r.Add(new
            {
                id = "AcDayGoodsJournalAccountTemp",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品进销存日帐临时表",
                url = "/Ac/AcDayGoodsJournalAccountTempList"
            });
            r.Add(new
            {
                id = "AcDayGoodsstockJournalAccount",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "总部商品进销存日帐",
                url = "/Ac/AcDayGoodsstockJournalAccountList"
            });
            r.Add(new
            {
                id = "AcDayGoodsstockJournalAccountTemp",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "总部商品进销存日帐临时表",
                url = "/Ac/AcDayGoodsstockJournalAccountTempList"
            });
            r.Add(new
            {
                id = "AcGoodssaleAccount",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品销售帐表",
                url = "/Ac/AcGoodssaleAccountList"
            });
            r.Add(new
            {
                id = "AcMonthClassJournalAccount",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "类别进销存月帐",
                url = "/Ac/AcMonthClassJournalAccountList"
            });
            r.Add(new
            {
                id = "AcMonthGoodsJournalAccount",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品进销存月帐",
                url = "/Ac/AcMonthGoodsJournalAccountList"
            });
            r.Add(new
            {
                id = "AcPaDayaccount",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "日帐设置",
                url = "/Ac/AcPaDayaccountList"
            });
            r.Add(new
            {
                id = "AcPaDayaccountStock",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "总部日帐设置",
                url = "/Ac/AcPaDayaccountStockList"
            });
            r.Add(new
            {
                id = "AcPaSaleset",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "销售记账设置",
                url = "/Ac/AcPaSalesetList"
            });
            r.Add(new
            {
                id = "AcPeriodTimeSummary",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "客流销售汇总",
                url = "/Ac/AcPeriodTimeSummaryList"
            });
            r.Add(new
            {
                id = "AcSalesmanSummary",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "营业员销售汇总",
                url = "/Ac/AcSalesmanSummaryList"
            });
            r.Add(new
            {
                id = "AcStockAccount",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品帐务库存",
                url = "/Ac/AcStockAccountList"
            });
            r.Add(new
            {
                id = "AcSupplierJournal",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "供货商流水帐",
                url = "/Ac/AcSupplierJournalList"
            });
            r.Add(new
            {
                id = "BaBranchBalance",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店结算",
                url = "/Ba/BaBranchBalanceList"
            });
            r.Add(new
            {
                id = "BaBranchDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店结算明细",
                url = "/Ba/BaBranchDetailList"
            });
            r.Add(new
            {
                id = "BaBranchOfferAccount",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店代销对帐",
                url = "/Ba/BaBranchOfferAccountList"
            });
            r.Add(new
            {
                id = "BaBranchOfferDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店代销对帐明细",
                url = "/Ba/BaBranchOfferDetailList"
            });
            r.Add(new
            {
                id = "BaChargeDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "费用费用费用明细",
                url = "/Ba/BaChargeDetailList"
            });
            r.Add(new
            {
                id = "BaChargeManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "费用管理",
                url = "/Ba/BaChargeManageList"
            });
            r.Add(new
            {
                id = "BaCustomerBalance",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "客户结算",
                url = "/Ba/BaCustomerBalanceList"
            });
            r.Add(new
            {
                id = "BaCustomerDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "客户结算明细",
                url = "/Ba/BaCustomerDetailList"
            });
            r.Add(new
            {
                id = "BaLeaseAccount",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "租赁对帐单",
                url = "/Ba/BaLeaseAccountList"
            });
            r.Add(new
            {
                id = "BaLeaseDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "租赁对帐单商品明细",
                url = "/Ba/BaLeaseDetailList"
            });
            r.Add(new
            {
                id = "BaOfferAccount",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "代销对账单",
                url = "/Ba/BaOfferAccountList"
            });
            r.Add(new
            {
                id = "BaOfferDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "代销对账单商品明细",
                url = "/Ba/BaOfferDetailList"
            });
            r.Add(new
            {
                id = "BaPaAccount",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "结算对账设置",
                url = "/Ba/BaPaAccountList"
            });
            r.Add(new
            {
                id = "BaPaBranchAccount",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店对帐设置",
                url = "/Ba/BaPaBranchAccountList"
            });
            r.Add(new
            {
                id = "BaPaCharge",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "费用设置",
                url = "/Ba/BaPaChargeList"
            });
            r.Add(new
            {
                id = "BaPoolAccount",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "联营对帐单",
                url = "/Ba/BaPoolAccountList"
            });
            r.Add(new
            {
                id = "BaPoolDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "联营对帐单商品明细",
                url = "/Ba/BaPoolDetailList"
            });
            r.Add(new
            {
                id = "BaSupplierBalance",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "供货商结算",
                url = "/Ba/BaSupplierBalanceList"
            });
            r.Add(new
            {
                id = "BaSupplierDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "供货商结算明细",
                url = "/Ba/BaSupplierDetailList"
            });
            r.Add(new
            {
                id = "BsAdjustSaleprice",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店商品调价",
                url = "/Bs/BsAdjustSalepriceList"
            });
            r.Add(new
            {
                id = "BsAdjustSalepriceGoods",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店商品调价商品明细",
                url = "/Bs/BsAdjustSalepriceGoodsList"
            });
            r.Add(new
            {
                id = "BsBranchAllotDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店调拨商品",
                url = "/Bs/BsBranchAllotDetailList"
            });
            r.Add(new
            {
                id = "BsBranchAllotManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店调拨",
                url = "/Bs/BsBranchAllotManageList"
            });
            r.Add(new
            {
                id = "BsBranchArchives",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店档案管理",
                url = "/Bs/BsBranchArchivesList"
            });
            r.Add(new
            {
                id = "BsBranchPrice",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店商品价格",
                url = "/Bs/BsBranchPriceList"
            });
            r.Add(new
            {
                id = "BsPaArea",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店区域",
                url = "/Bs/BsPaAreaList"
            });
            r.Add(new
            {
                id = "BsPaBranchWarehouse",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店仓库设置",
                url = "/Bs/BsPaBranchWarehouseList"
            });
            r.Add(new
            {
                id = "BsPaClass",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店分类",
                url = "/Bs/BsPaClassList"
            });
            r.Add(new
            {
                id = "BsReturnDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店商品返货单明细",
                url = "/Bs/BsReturnDetailList"
            });
            r.Add(new
            {
                id = "BsReturnManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店商品返货单",
                url = "/Bs/BsReturnManageList"
            });
            r.Add(new
            {
                id = "BsReturnManageFlow",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店商品返货单流水",
                url = "/Bs/BsReturnManageFlowList"
            });
            r.Add(new
            {
                id = "BsSupplyDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店订货配送单明细",
                url = "/Bs/BsSupplyDetailList"
            });
            r.Add(new
            {
                id = "BsSupplyManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店商品订货配送单",
                url = "/Bs/BsSupplyManageList"
            });
            r.Add(new
            {
                id = "BsSupplyManageFlow",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "分店商品订货配送单流水",
                url = "/Bs/BsSupplyManageFlowList"
            });
            r.Add(new
            {
                id = "EmEmployeeArchives",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "人员档案",
                url = "/Em/EmEmployeeArchivesList"
            });
            r.Add(new
            {
                id = "EmEmployeeFamily",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "人员家庭信息",
                url = "/Em/EmEmployeeFamilyList"
            });
            r.Add(new
            {
                id = "EmEmployeePhoto",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "人员照片",
                url = "/Em/EmEmployeePhotoList"
            });
            r.Add(new
            {
                id = "EmPaDuty",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "职务编码表",
                url = "/Em/EmPaDutyList"
            });
            r.Add(new
            {
                id = "EmPaEducation",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "学历编码表",
                url = "/Em/EmPaEducationList"
            });
            r.Add(new
            {
                id = "EmPaNation",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "民族编码表",
                url = "/Em/EmPaNationList"
            });
            r.Add(new
            {
                id = "EmPaPolitics",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "政治面貌编码表",
                url = "/Em/EmPaPoliticsList"
            });
            r.Add(new
            {
                id = "EmPaProfessionalTitle",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "职称编码表",
                url = "/Em/EmPaProfessionalTitleList"
            });
            r.Add(new
            {
                id = "FbAdjustClass",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "调商品所属类别",
                url = "/Fb/FbAdjustClassList"
            });
            r.Add(new
            {
                id = "FbAdjustClassGoods",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "调商品所属类别商品明细",
                url = "/Fb/FbAdjustClassGoodsList"
            });
            r.Add(new
            {
                id = "FbAdjustPoolrate",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "调商品扣率",
                url = "/Fb/FbAdjustPoolrateList"
            });
            r.Add(new
            {
                id = "FbAdjustPoolrateGoods",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "调商品扣率商品明细",
                url = "/Fb/FbAdjustPoolrateGoodsList"
            });
            r.Add(new
            {
                id = "FbAdjustPurchaseprice",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "调商品进价",
                url = "/Fb/FbAdjustPurchasepriceList"
            });
            r.Add(new
            {
                id = "FbAdjustPurchasepriceGoods",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "调商品进价商品明细",
                url = "/Fb/FbAdjustPurchasepriceGoodsList"
            });
            r.Add(new
            {
                id = "FbAdjustSaleprice",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "调商品售价",
                url = "/Fb/FbAdjustSalepriceList"
            });
            r.Add(new
            {
                id = "FbAdjustSalepriceGoods",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "调商品售价商品明细",
                url = "/Fb/FbAdjustSalepriceGoodsList"
            });
            r.Add(new
            {
                id = "FbAdjustSupplier",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "调商品供货商",
                url = "/Fb/FbAdjustSupplierList"
            });
            r.Add(new
            {
                id = "FbAdjustSupplierGoods",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "调商品供货商商品明细",
                url = "/Fb/FbAdjustSupplierGoodsList"
            });
            r.Add(new
            {
                id = "FbGoodsArchives",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品档案",
                url = "/Fb/FbGoodsArchivesList"
            });
            r.Add(new
            {
                id = "FbGoodsArchivesBar",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品销售码",
                url = "/Fb/FbGoodsArchivesBarList"
            });
            r.Add(new
            {
                id = "FbGoodsArchivesBind",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品捆绑",
                url = "/Fb/FbGoodsArchivesBindList"
            });
            r.Add(new
            {
                id = "FbGoodsArchivesLibrary",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品条码库",
                url = "/Fb/FbGoodsArchivesLibraryList"
            });
            r.Add(new
            {
                id = "FbGoodsArchivesParts",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品部件",
                url = "/Fb/FbGoodsArchivesPartsList"
            });
            r.Add(new
            {
                id = "FbGoodsArchivesPhoto",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品视图表",
                url = "/Fb/FbGoodsArchivesPhotoList"
            });
            r.Add(new
            {
                id = "FbGoodsArchivesSupplier",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品供货商",
                url = "/Fb/FbGoodsArchivesSupplierList"
            });
            r.Add(new
            {
                id = "FbGoodsBarCode",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "销售编码表",
                url = "/Fb/FbGoodsBarCodeList"
            });
            r.Add(new
            {
                id = "FbPaBaseSet",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "基础参数设置",
                url = "/Fb/FbPaBaseSetList"
            });
            r.Add(new
            {
                id = "FbPaGoodsCheckUnit",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "核算单位编码",
                url = "/Fb/FbPaGoodsCheckUnitList"
            });
            r.Add(new
            {
                id = "FbPaGoodsCounter",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "柜组编码",
                url = "/Fb/FbPaGoodsCounterList"
            });
            r.Add(new
            {
                id = "FbPaGoodsGb",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "大类编码",
                url = "/Fb/FbPaGoodsGbList"
            });
            r.Add(new
            {
                id = "FbPaGoodsGl",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "细类编码",
                url = "/Fb/FbPaGoodsGlList"
            });
            r.Add(new
            {
                id = "FbPaGoodsGm",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "中类编码",
                url = "/Fb/FbPaGoodsGmList"
            });
            r.Add(new
            {
                id = "FbPaGoodsGs",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "小类编码",
                url = "/Fb/FbPaGoodsGsList"
            });
            r.Add(new
            {
                id = "FbPaGoodsPackUnit",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "包装单位编码",
                url = "/Fb/FbPaGoodsPackUnitList"
            });
            r.Add(new
            {
                id = "FbPaSupType",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "供货商类型",
                url = "/Fb/FbPaSupTypeList"
            });
            r.Add(new
            {
                id = "FbSupplierArchives",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "供货商档案",
                url = "/Fb/FbSupplierArchivesList"
            });
            r.Add(new
            {
                id = "FbSupplierLease",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "供货商租赁合同",
                url = "/Fb/FbSupplierLeaseList"
            });
            r.Add(new
            {
                id = "MsAdjustPoints",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "积分调整管理",
                url = "/Ms/MsAdjustPointsList"
            });
            r.Add(new
            {
                id = "MsCancelCardManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "卡作废",
                url = "/Ms/MsCancelCardManageList"
            });
            r.Add(new
            {
                id = "MsCardArchives",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "卡信息",
                url = "/Ms/MsCardArchivesList"
            });
            r.Add(new
            {
                id = "MsCardtypeDiscount",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "卡折扣",
                url = "/Ms/MsCardtypeDiscountList"
            });
            r.Add(new
            {
                id = "MsCardtypeGoodsDiscount",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品折扣",
                url = "/Ms/MsCardtypeGoodsDiscountList"
            });
            r.Add(new
            {
                id = "MsCardtypeGoodsPoints",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品积分",
                url = "/Ms/MsCardtypeGoodsPointsList"
            });
            r.Add(new
            {
                id = "MsCardtypeManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "卡类型",
                url = "/Ms/MsCardtypeManageList"
            });
            r.Add(new
            {
                id = "MsCardtypePoints",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "卡积分",
                url = "/Ms/MsCardtypePointsList"
            });
            r.Add(new
            {
                id = "MsExchangeDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "赠品兑换明细",
                url = "/Ms/MsExchangeDetailList"
            });
            r.Add(new
            {
                id = "MsExchangeManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "赠品兑换管理",
                url = "/Ms/MsExchangeManageList"
            });
            r.Add(new
            {
                id = "MsFreezeCardManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "卡冻结",
                url = "/Ms/MsFreezeCardManageList"
            });
            r.Add(new
            {
                id = "MsGiftArchives",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "赠品档案管理",
                url = "/Ms/MsGiftArchivesList"
            });
            r.Add(new
            {
                id = "MsGrantCardManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "卡发放",
                url = "/Ms/MsGrantCardManageList"
            });
            r.Add(new
            {
                id = "MsLossCardManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "卡挂失",
                url = "/Ms/MsLossCardManageList"
            });
            r.Add(new
            {
                id = "MsMadecardManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "卡制作",
                url = "/Ms/MsMadecardManageList"
            });
            r.Add(new
            {
                id = "MsMemberArchives",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "会员信息",
                url = "/Ms/MsMemberArchivesList"
            });
            r.Add(new
            {
                id = "MsPointsClear",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "积分清零管理",
                url = "/Ms/MsPointsClearList"
            });
            r.Add(new
            {
                id = "MsPointtoprepaidManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "积分转储值",
                url = "/Ms/MsPointtoprepaidManageList"
            });
            r.Add(new
            {
                id = "MsPrepaidCardManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "卡充值",
                url = "/Ms/MsPrepaidCardManageList"
            });
            r.Add(new
            {
                id = "MsReclaimCardManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "卡回收",
                url = "/Ms/MsReclaimCardManageList"
            });
            r.Add(new
            {
                id = "MsUpdateCardManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "卡更新",
                url = "/Ms/MsUpdateCardManageList"
            });
            r.Add(new
            {
                id = "MsUpgradeCardDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "卡升级信息",
                url = "/Ms/MsUpgradeCardDetailList"
            });
            r.Add(new
            {
                id = "MsUpgradeCardManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "卡升级",
                url = "/Ms/MsUpgradeCardManageList"
            });
            r.Add(new
            {
                id = "OpAdjustDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品调整单商品明细",
                url = "/Op/OpAdjustDetailList"
            });
            r.Add(new
            {
                id = "OpAdjustManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品调整单",
                url = "/Op/OpAdjustManageList"
            });
            r.Add(new
            {
                id = "OpAdjustManageFlow",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品调整流水帐单",
                url = "/Op/OpAdjustManageFlowList"
            });
            r.Add(new
            {
                id = "OpAdjustPurchaseDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "进货成本调整批次明细",
                url = "/Op/OpAdjustPurchaseDetailList"
            });
            r.Add(new
            {
                id = "OpAdjustPurchaseManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "进货成本调整单",
                url = "/Op/OpAdjustPurchaseManageList"
            });
            r.Add(new
            {
                id = "OpAllotDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品调拨单商品明细",
                url = "/Op/OpAllotDetailList"
            });
            r.Add(new
            {
                id = "OpAllotManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品调拨单",
                url = "/Op/OpAllotManageList"
            });
            r.Add(new
            {
                id = "OpAllotManageFlow",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品调拨流水帐单",
                url = "/Op/OpAllotManageFlowList"
            });
            r.Add(new
            {
                id = "OpCheckDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品盘点单商品明细",
                url = "/Op/OpCheckDetailList"
            });
            r.Add(new
            {
                id = "OpCheckManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品盘点单",
                url = "/Op/OpCheckManageList"
            });
            r.Add(new
            {
                id = "OpCheckStock",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "盘点库存",
                url = "/Op/OpCheckStockList"
            });
            r.Add(new
            {
                id = "OpCheckTransfer",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品盘点接转单商品汇总明细",
                url = "/Op/OpCheckTransferList"
            });
            r.Add(new
            {
                id = "OpDynamicStock",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品实时库存",
                url = "/Op/OpDynamicStockList"
            });
            r.Add(new
            {
                id = "OpDynamicStockBranch",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品分店实时库存",
                url = "/Op/OpDynamicStockBranchList"
            });
            r.Add(new
            {
                id = "OpDynamicStockWh",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品仓储实时库存",
                url = "/Op/OpDynamicStockWhList"
            });
            r.Add(new
            {
                id = "OpGoodsBatch",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品库存批次表",
                url = "/Op/OpGoodsBatchList"
            });
            r.Add(new
            {
                id = "OpLossDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品损溢商品明细",
                url = "/Op/OpLossDetailList"
            });
            r.Add(new
            {
                id = "OpLossManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品损溢",
                url = "/Op/OpLossManageList"
            });
            r.Add(new
            {
                id = "OpLossManageFlow",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品损溢流水帐单",
                url = "/Op/OpLossManageFlowList"
            });
            r.Add(new
            {
                id = "OpPaWarehouse",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "仓库参数维护",
                url = "/Op/OpPaWarehouseList"
            });
            r.Add(new
            {
                id = "OpSplitComDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "组合拆零管理商品明细",
                url = "/Op/OpSplitComDetailList"
            });
            r.Add(new
            {
                id = "OpSplitComGoods",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "组合拆零商品",
                url = "/Op/OpSplitComGoodsList"
            });
            r.Add(new
            {
                id = "OpSplitComManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "组合拆零管理",
                url = "/Op/OpSplitComManageList"
            });
            r.Add(new
            {
                id = "OpSplitComManageFlow",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "组合拆零管理流水单",
                url = "/Op/OpSplitComManageFlowList"
            });
            r.Add(new
            {
                id = "PcPurchaseDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品采购单商品明细",
                url = "/Pc/PcPurchaseDetailList"
            });
            r.Add(new
            {
                id = "PcPurchaseManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品采购单",
                url = "/Pc/PcPurchaseManageList"
            });
            r.Add(new
            {
                id = "PcPutinDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品入库单商品明细",
                url = "/Pc/PcPutinDetailList"
            });
            r.Add(new
            {
                id = "PcPutinManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品入库单",
                url = "/Pc/PcPutinManageList"
            });
            r.Add(new
            {
                id = "PcPutoutDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品出库单商品明细",
                url = "/Pc/PcPutoutDetailList"
            });
            r.Add(new
            {
                id = "PcPutoutManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品出库单",
                url = "/Pc/PcPutoutManageList"
            });
            r.Add(new
            {
                id = "PcReturnDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品返货单商品明细",
                url = "/Pc/PcReturnDetailList"
            });
            r.Add(new
            {
                id = "PcReturnManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "商品返货单",
                url = "/Pc/PcReturnManageList"
            });
            r.Add(new
            {
                id = "RtClassPromotion",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "类别促销",
                url = "/Rt/RtClassPromotionList"
            });
            r.Add(new
            {
                id = "RtClassPromotionBranch",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "类别促销分店",
                url = "/Rt/RtClassPromotionBranchList"
            });
            r.Add(new
            {
                id = "RtClassPromotionGoods",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "类别促销商品明细",
                url = "/Rt/RtClassPromotionGoodsList"
            });
            r.Add(new
            {
                id = "RtPaFunction",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "收银功能表",
                url = "/Rt/RtPaFunctionList"
            });
            r.Add(new
            {
                id = "RtPaPayway",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "付款方式",
                url = "/Rt/RtPaPaywayList"
            });
            r.Add(new
            {
                id = "RtPaPos",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "POS机设置",
                url = "/Rt/RtPaPosList"
            });
            r.Add(new
            {
                id = "RtPaSaleset",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "销售设置",
                url = "/Rt/RtPaSalesetList"
            });
            r.Add(new
            {
                id = "RtPaShift",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "销售班次",
                url = "/Rt/RtPaShiftList"
            });
            r.Add(new
            {
                id = "RtPluPromotion",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "单品促销",
                url = "/Rt/RtPluPromotionList"
            });
            r.Add(new
            {
                id = "RtPluPromotionBranch",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "单品促销分店",
                url = "/Rt/RtPluPromotionBranchList"
            });
            r.Add(new
            {
                id = "RtPluPromotionGoods",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "单品促销商品明细",
                url = "/Rt/RtPluPromotionGoodsList"
            });
            r.Add(new
            {
                id = "RtPresentPromotion",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "馈赠促销",
                url = "/Rt/RtPresentPromotionList"
            });
            r.Add(new
            {
                id = "RtPresentPromotionBranch",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "馈赠促销分店",
                url = "/Rt/RtPresentPromotionBranchList"
            });
            r.Add(new
            {
                id = "RtPresentPromotionGoods",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "馈赠促销商品明细",
                url = "/Rt/RtPresentPromotionGoodsList"
            });
            r.Add(new
            {
                id = "RtRetailDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "销售表商品明细",
                url = "/Rt/RtRetailDetailList"
            });
            r.Add(new
            {
                id = "RtRetailManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "销售主表",
                url = "/Rt/RtRetailManageList"
            });
            r.Add(new
            {
                id = "RtRetailPay",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "销售表付款表",
                url = "/Rt/RtRetailPayList"
            });
            r.Add(new
            {
                id = "RtSheetPromotion",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "整单促销",
                url = "/Rt/RtSheetPromotionList"
            });
            r.Add(new
            {
                id = "RtSheetPromotionBranch",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "整单促销分店",
                url = "/Rt/RtSheetPromotionBranchList"
            });
            r.Add(new
            {
                id = "RtSheetPromotionGoods",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "整单促销商品明细",
                url = "/Rt/RtSheetPromotionGoodsList"
            });
            r.Add(new
            {
                id = "SysClassPower",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "类别权限设置",
                url = "/Sys/SysClassPowerList"
            });
            r.Add(new
            {
                id = "SysDepartPower",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "岗位权限",
                url = "/Sys/SysDepartPowerList"
            });
            r.Add(new
            {
                id = "SysEnterpriseArchives",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "企业设置",
                url = "/Sys/SysEnterpriseArchivesList"
            });
            r.Add(new
            {
                id = "SysLoginPower",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "登录权限设置",
                url = "/Sys/SysLoginPowerList"
            });
            r.Add(new
            {
                id = "SysLoginPowerFunction",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "人员收银功能",
                url = "/Sys/SysLoginPowerFunctionList"
            });
            r.Add(new
            {
                id = "SysModule",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "功能模块设置",
                url = "/Sys/SysModuleList"
            });
            r.Add(new
            {
                id = "SysModuleContent",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "模块相关信息",
                url = "/Sys/SysModuleContentList"
            });
            r.Add(new
            {
                id = "SysModulePic",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "系统模块图片",
                url = "/Sys/SysModulePicList"
            });
            r.Add(new
            {
                id = "SysOperationFlow",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "业务流程",
                url = "/Sys/SysOperationFlowList"
            });
            r.Add(new
            {
                id = "SysOperationFlowDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "业务流程明细",
                url = "/Sys/SysOperationFlowDetailList"
            });
            r.Add(new
            {
                id = "SysOperationFlowDetailMax",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "流程最大编号表",
                url = "/Sys/SysOperationFlowDetailMaxList"
            });
            r.Add(new
            {
                id = "SysOperationWorker",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "业务流程人员权限",
                url = "/Sys/SysOperationWorkerList"
            });
            r.Add(new
            {
                id = "SysPaDepartment",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "部门编码表",
                url = "/Sys/SysPaDepartmentList"
            });
            r.Add(new
            {
                id = "SysPrintDesign",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "打印模板设计",
                url = "/Sys/SysPrintDesignList"
            });
            r.Add(new
            {
                id = "SysWorkerPower",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "人员权限",
                url = "/Sys/SysWorkerPowerList"
            });
            r.Add(new
            {
                id = "TfDataDownload",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "通讯临时表",
                url = "/Tf/TfDataDownloadList"
            });
            r.Add(new
            {
                id = "TfDataObject",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "通讯配置表表名",
                url = "/Tf/TfDataObjectList"
            });
            r.Add(new
            {
                id = "TfDataProperty",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "通讯配置表字段",
                url = "/Tf/TfDataPropertyList"
            });
            r.Add(new
            {
                id = "TgExpostorBalance",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "讲解员结算管理",
                url = "/Tg/TgExpostorBalanceList"
            });
            r.Add(new
            {
                id = "TgExpostorBalanceDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "讲解员结算明细",
                url = "/Tg/TgExpostorBalanceDetailList"
            });
            r.Add(new
            {
                id = "TgGroupBalance",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "团队结算管理",
                url = "/Tg/TgGroupBalanceList"
            });
            r.Add(new
            {
                id = "TgGroupBalanceDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "团队结算明细",
                url = "/Tg/TgGroupBalanceDetailList"
            });
            r.Add(new
            {
                id = "TgGroupCall",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "团队策略提醒",
                url = "/Tg/TgGroupCallList"
            });
            r.Add(new
            {
                id = "TgGuideArchives",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "导游人员信息",
                url = "/Tg/TgGuideArchivesList"
            });
            r.Add(new
            {
                id = "TgGuideBalance",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "导游结算管理",
                url = "/Tg/TgGuideBalanceList"
            });
            r.Add(new
            {
                id = "TgGuideBalanceDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "导游结算明细",
                url = "/Tg/TgGuideBalanceDetailList"
            });
            r.Add(new
            {
                id = "TgPaCarsCharge",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "车停策略设置",
                url = "/Tg/TgPaCarsChargeList"
            });
            r.Add(new
            {
                id = "TgPaCarsType",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "车型设置",
                url = "/Tg/TgPaCarsTypeList"
            });
            r.Add(new
            {
                id = "TgPaGroup",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "团队结算设置",
                url = "/Tg/TgPaGroupList"
            });
            r.Add(new
            {
                id = "TgPaGroupType",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "团队类别",
                url = "/Tg/TgPaGroupTypeList"
            });
            r.Add(new
            {
                id = "TgPaTaType",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "旅行社类型",
                url = "/Tg/TgPaTaTypeList"
            });
            r.Add(new
            {
                id = "TgPushtacDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "人员提成策略明细",
                url = "/Tg/TgPushtacDetailList"
            });
            r.Add(new
            {
                id = "TgPushtacManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "人员提成策略",
                url = "/Tg/TgPushtacManageList"
            });
            r.Add(new
            {
                id = "TgTourgroupManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "团队购物管理",
                url = "/Tg/TgTourgroupManageList"
            });
            r.Add(new
            {
                id = "TgTravelArchives",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "旅行社档案",
                url = "/Tg/TgTravelArchivesList"
            });
            r.Add(new
            {
                id = "TgTravelArchivesPushtac",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "旅行社提成策略",
                url = "/Tg/TgTravelArchivesPushtacList"
            });
            r.Add(new
            {
                id = "TgTravelBalance",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "旅行社结算管理",
                url = "/Tg/TgTravelBalanceList"
            });
            r.Add(new
            {
                id = "TgTravelBalanceDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "旅行社结算明细",
                url = "/Tg/TgTravelBalanceDetailList"
            });
            r.Add(new
            {
                id = "WsCustomerArchives",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "客户档案",
                url = "/Ws/WsCustomerArchivesList"
            });
            r.Add(new
            {
                id = "WsCustomerGoods",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "客户商品",
                url = "/Ws/WsCustomerGoodsList"
            });
            r.Add(new
            {
                id = "WsOrderDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "批发订单商品明细",
                url = "/Ws/WsOrderDetailList"
            });
            r.Add(new
            {
                id = "WsOrderManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "批发订单",
                url = "/Ws/WsOrderManageList"
            });
            r.Add(new
            {
                id = "WsPaCustomerType",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "客户类型",
                url = "/Ws/WsPaCustomerTypeList"
            });
            r.Add(new
            {
                id = "WsWholesaleDetail",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "批发销售商品明细",
                url = "/Ws/WsWholesaleDetailList"
            });
            r.Add(new
            {
                id = "WsWholesaleGoodsSet",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "限销商品设置",
                url = "/Ws/WsWholesaleGoodsSetList"
            });
            r.Add(new
            {
                id = "WsWholesaleManage",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "批发销售",
                url = "/Ws/WsWholesaleManageList"
            });
            r.Add(new
            {
                id = "WsWholesaleManageFlow",
                iconCls = "icon-add",
                newwindow = false,
                pid = "1",
                text = "批发销售流水",
                url = "/Ws/WsWholesaleManageFlowList"
            });







            return Json(r, JsonRequestBehavior.AllowGet);
        }

        //public JsonResult ReIniAllSupplierLoginNameAndPassword()
        //{
        //    string connstr = ConfigurationManager.AppSettings["connectionString"];
        //    SqlHelper Helper = new SqlHelper(connstr);
        //    DataTable allSupplier = Helper.ExecuteDataTable(CommandType.Text, "select sup_code from fb_supplier_archives");

        //    List<int> existName = new List<int>();

        //    for (int i = 0; i < allSupplier.Rows.Count; i++)
        //    {
        //        int name = NSH.VSTO.Extend.GetRandomNumber(10000, 99999);

        //        while (existName.Any(p => p == name))
        //        {
        //            name = NSH.VSTO.Extend.GetRandomNumber(10000, 99999);
        //        }
        //        Helper = new SqlHelper(connstr);
        //        string str_sql = string.Format("update fb_supplier_archives set  login_name='{0}', login_pass='{1}' where sup_code={2}", name, "888888", allSupplier.Rows[i]["sup_code"].ToString());
        //        Helper.ExecuteNonQuery(CommandType.Text, str_sql);
        //        Response.Buffer = false;
        //        Response.Write(name + "<br/>");

        //        Thread.Sleep(13);
        //    }

        //    return Json(true, JsonRequestBehavior.AllowGet);
        //}

        //public ActionResult Login()
        //{
        //    return View();
        //}
        //public ActionResult SLogin()
        //{
        //    return View();
        //}
        //public ActionResult ELogin()
        //{
        //    return View();
        //}

        //public ActionResult VCode()
        //{
        //    VerifyCode v = new VerifyCode();
        //    string vcode = VerifyCode.GetRandomNumber(1000, 9999).ToString();
        //    Session["SafeCode"] = vcode;
        //    v.CreateImageOnPage(vcode, System.Web.HttpContext.Current);
        //    return null;
        //}

        //public JsonResult GetDepatmentTree()
        //{
        //    return Json(
        //    SysPaDepartmentService.ModelListToDto(SysPaDepartmentService.GetAll()),
        //    JsonRequestBehavior.AllowGet);

        //}


        //[HttpPost]
        //public ActionResult Login(LoginModel model, string returnUrl)
        //{
        //    if (String.IsNullOrWhiteSpace(model.UserName))
        //    {
        //        ModelState.AddModelError("", "账号不能为空");
        //        return View(model);
        //    }

        //    if (String.IsNullOrWhiteSpace(model.Password))
        //    {
        //        ModelState.AddModelError("", "密码不能为空");
        //        return View(model);
        //    }
        //    if (String.IsNullOrWhiteSpace(model.VCode))
        //    {
        //        ModelState.AddModelError("", "验证码不能为空");
        //        return View(model);
        //    }
        //    if (Session["SafeCode"] == null || Session["SafeCode"].ToString() != model.VCode)
        //    {
        //        ModelState.AddModelError("", "验证码错误");
        //        Session.Remove("SafeCode");
        //        return View(model);
        //    }
        //    Session.Remove("SafeCode");//删除验证码Session 防止机器登录


        //    LoginResult result = SysLoginPowerService.CheckUser(model.UserName, model.Password, model.logintype);
        //    if (result.IsSuccess)
        //    {
        //        if (result.Employee != null)
        //        {
        //            Session[AuthorizeSettings.SessionUserName] = result.Employee.LoginName;
        //            Session[AuthorizeSettings.SessionUserID] = result.Employee.Id;
        //            Session[AuthorizeSettings.SessionUserType] = "0";

        //        }
        //        else
        //        {
        //            Session[AuthorizeSettings.SessionUserName] = result.Supplier.LoginName;
        //            Session[AuthorizeSettings.SessionUserID] = result.Supplier.Id;
        //            Session[AuthorizeSettings.SessionUserType] = "1";
        //        }
        //        SetUserType(false);
        //        return RedirectToAction("Index", "Home");
        //    }
        //    else
        //    {
        //        ModelState.AddModelError("", "账号或密码错误，请重试");
        //        return View(model);
        //    }
        //    //if (String.IsNullOrWhiteSpace(model.UserName))
        //    //{
        //    //    ModelState.AddModelError("", "账号不能为空");
        //    //    return View(model);
        //    //}

        //    //if (String.IsNullOrWhiteSpace(model.Password))
        //    //{
        //    //    ModelState.AddModelError("", "密码不能为空");
        //    //    return View(model);
        //    //}
        //    //if (String.IsNullOrWhiteSpace(model.VCode))
        //    //{
        //    //    ModelState.AddModelError("", "验证码不能为空");
        //    //    return View(model);
        //    //}
        //    //if (Session["SafeCode"] == null || Session["SafeCode"].ToString() != model.VCode)
        //    //{
        //    //    ModelState.AddModelError("", "验证码错误");
        //    //    Session.Remove("SafeCode");
        //    //    return View(model);
        //    //}
        //    //Session.Remove("SafeCode");//删除验证码Session 防止机器登录


        //    //LoginResult result = SysLoginPowerService.CheckUser(model.UserName, model.Password, model.logintype);
        //    //if (result.IsSuccess)
        //    //{
        //    //    if (result.Employee != null)
        //    //    {
        //    //        Session[AuthorizeSettings.SessionUserName] = result.Employee.LoginName;
        //    //        Session[AuthorizeSettings.SessionUserID] = result.Employee.Id;
        //    //        Session[AuthorizeSettings.SessionUserType] = "0";

        //    //    }
        //    //    else
        //    //    {
        //    //        Session[AuthorizeSettings.SessionUserName] = result.Supplier.LoginName;
        //    //        Session[AuthorizeSettings.SessionUserID] = result.Supplier.Id;
        //    //        Session[AuthorizeSettings.SessionUserType] = "1";
        //    //    }
        //    //    return RedirectToAction("Index", "Home");
        //    //}
        //    //else
        //    //{
        //    //    ModelState.AddModelError("", "账号或密码错误，请重试");
        //    //    return View(model);
        //    //}


        //    //var u = SysLoginPowerService.CheckUser(model.UserName, model.Password);
        //    //if (u == null)
        //    //{
        //    //    ModelState.AddModelError("", "账号或密码错误，请重试");
        //    //    return View(model);
        //    //}
        //    //else
        //    //{
        //    //    Session[AuthorizeSettings.SessionUserName] = u.Username;
        //    //    Session[AuthorizeSettings.SessionUserID] = u.Id;
        //    //    return RedirectToAction("Index", "Home");
        //    //}

        //    //NSH.Authorization.Domain.User user = new NSH.Authorization.Domain.User();
        //    //user.LoginName = model.UserName;
        //    //user.Password = model.Password.ToMD5();
        //    //Session.Remove("SafeCode");//删除验证码Session 防止机器登录
        //    //if (UserService.CheckLoginUser(ref user))
        //    //{
        //    //    Session[AuthorizeSettings.SessionUserName] = user.UserName;
        //    //    Session[AuthorizeSettings.SessionUserID] = user.Id;
        //    //    return RedirectToAction("Index", "Home");
        //    //}
        //    //else
        //    //{
        //    //    ModelState.AddModelError("", "账号或密码错误，请重试");
        //    //    return View(model);
        //    //}

        //}

        //[HttpPost]
        //public ActionResult SLogin(LoginModel model, string returnUrl)
        //{

        //    if (String.IsNullOrWhiteSpace(model.UserName))
        //    {
        //        ModelState.AddModelError("", "账号不能为空");
        //        return View(model);
        //    }

        //    if (String.IsNullOrWhiteSpace(model.Password))
        //    {
        //        ModelState.AddModelError("", "密码不能为空");
        //        return View(model);
        //    }
        //    if (String.IsNullOrWhiteSpace(model.VCode))
        //    {
        //        ModelState.AddModelError("", "验证码不能为空");
        //        return View(model);
        //    }
        //    if (Session["SafeCode"] == null || Session["SafeCode"].ToString() != model.VCode)
        //    {
        //        ModelState.AddModelError("", "验证码错误");
        //        Session.Remove("SafeCode");
        //        return View(model);
        //    }
        //    Session.Remove("SafeCode");//删除验证码Session 防止机器登录


        //    LoginResult result = SysLoginPowerService.CheckUser(model.UserName, model.Password, model.logintype);
        //    if (result.IsSuccess)
        //    {
        //        if (result.Employee != null)
        //        {
        //            Session[AuthorizeSettings.SessionUserName] = result.Employee.LoginName;
        //            Session[AuthorizeSettings.SessionUserID] = result.Employee.Id;
        //            Session[AuthorizeSettings.SessionUserType] = "0";

        //        }
        //        else
        //        {
        //            Session[AuthorizeSettings.SessionUserName] = result.Supplier.LoginName;
        //            Session[AuthorizeSettings.SessionUserID] = result.Supplier.Id;
        //            Session[AuthorizeSettings.SessionUserType] = "1";
        //        }
        //        SetUserType(false);
        //        return RedirectToAction("Index", "Home");
        //    }
        //    else
        //    {
        //        ModelState.AddModelError("", "账号或密码错误，请重试");
        //        return View(model);
        //    }

        //}

        //[HttpPost]
        //public ActionResult ELogin(LoginModel model, string returnUrl)
        //{

        //    if (String.IsNullOrWhiteSpace(model.UserName))
        //    {
        //        ModelState.AddModelError("", "账号不能为空");
        //        return View(model);
        //    }

        //    if (String.IsNullOrWhiteSpace(model.Password))
        //    {
        //        ModelState.AddModelError("", "密码不能为空");
        //        return View(model);
        //    }
        //    if (String.IsNullOrWhiteSpace(model.VCode))
        //    {
        //        ModelState.AddModelError("", "验证码不能为空");
        //        return View(model);
        //    }
        //    if (Session["SafeCode"] == null || Session["SafeCode"].ToString() != model.VCode)
        //    {
        //        ModelState.AddModelError("", "验证码错误");
        //        Session.Remove("SafeCode");
        //        return View(model);
        //    }
        //    Session.Remove("SafeCode");//删除验证码Session 防止机器登录


        //    LoginResult result = SysLoginPowerService.CheckUser(model.UserName, model.Password, model.logintype);
        //    if (result.IsSuccess)
        //    {
        //        if (result.Employee != null)
        //        {
        //            Session[AuthorizeSettings.SessionUserName] = result.Employee.LoginName;
        //            Session[AuthorizeSettings.SessionUserID] = result.Employee.Id;
        //            Session[AuthorizeSettings.SessionUserType] = "0";

        //        }
        //        else
        //        {
        //            Session[AuthorizeSettings.SessionUserName] = result.Supplier.LoginName;
        //            Session[AuthorizeSettings.SessionUserID] = result.Supplier.Id;
        //            Session[AuthorizeSettings.SessionUserType] = "1";
        //        }
        //        SetUserType(true);
        //        return RedirectToAction("Index", "Home");
        //    }
        //    else
        //    {
        //        ModelState.AddModelError("", result.Text);
        //        return View(model);
        //    }

        //}

        //public ActionResult DepartmentSelectTree()
        //{
        //    return View();
        //}

        //public ActionResult SysSetting()
        //{
        //    return View(SysEnterpriseArchivesService.Get());
        //}

        //public JsonResult SaveSysSetting(SysEnterpriseArchives setting)
        //{
        //    SysEnterpriseArchivesService.Save(setting);
        //    return Json(true, JsonRequestBehavior.AllowGet);
        //}

        //public ActionResult LogOut()
        //{
        //    if (Common.MyEnv.IsHistoryEmloyee)
        //    {
        //        Session.Abandon();
        //        return RedirectToAction("ELogin", "Account");
        //    }
        //    if (Common.MyEnv.IsHistorySupplier)
        //    {
        //        Session.Abandon();
        //        return RedirectToAction("Login", "Account");
        //    }
        //    Session.Abandon();
        //    return RedirectToAction("Login", "Account");
        //}

        //public void SetUserType(bool isEmployee)
        //{
        //    HttpCookie cookie = new HttpCookie("userType");
        //    cookie.Value = isEmployee ? "e" : "s";
        //    cookie.Expires = DateTime.Now.AddMonths(1);
        //    cookie.Path = "/";
        //    HttpContext.Response.SetCookie(cookie);
        //}

        //public ActionResult BaseSetting()
        //{
        //    return View(FbPaBaseSetService.Get());
        //}

        //public JsonResult SaveBaseSetting(FbPaBaseSet setting)
        //{
        //    setting.Id = "1";
        //    setting.Operator = "1";
        //    setting.OperatorDate = DateTime.Now;
        //    FbPaBaseSetService.Save(setting);
        //    return Json(true, JsonRequestBehavior.AllowGet);
        //}

        //public ActionResult ChangePassword()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public JsonResult ChangePassword(string old, string newpass, string confirmpass)
        //{
        //    if (Common.MyEnv.IsEmployeeLogin == false && Common.MyEnv.IsSupplierLogin == false)
        //    {
        //        return Json(new cResult() { Success = false, Text = "没有登录，请登录后修改密码！" }, JsonRequestBehavior.AllowGet);
        //    }

        //    if (newpass != confirmpass)
        //    {
        //        return Json(new cResult() { Success = false, Text = "新密码和确认密码输入不一致，请重新输入" }, JsonRequestBehavior.AllowGet);
        //    }

        //    if (Common.MyEnv.IsEmployeeLogin)
        //    {
        //        //员工
        //        var currentEmployee = Common.MyEnv.CurrentEmployee;
        //        if (old != currentEmployee.LoginPass)
        //        {
        //            return Json(new cResult() { Success = false, Text = "旧密码输入错误，请重新输入" }, JsonRequestBehavior.AllowGet);
        //        }
        //        else
        //        {
        //            currentEmployee.LoginPass = newpass;
        //            EmemployeearchiveService.Update(currentEmployee);
        //            return Json(new cResult() { Success = true, Text = "密码修改成功！" }, JsonRequestBehavior.AllowGet);
        //        }
        //    }
        //    else
        //    {
        //        //供货商
        //        var currentSupplier = Common.MyEnv.CurrentSupplier;
        //        if (old != currentSupplier.LoginPass)
        //        {
        //            return Json(new cResult() { Success = false, Text = "旧密码输入错误，请重新输入" }, JsonRequestBehavior.AllowGet);
        //        }
        //        else
        //        {
        //            currentSupplier.LoginPass = newpass;
        //            FbSupplierArchivesService.Update(currentSupplier);
        //            return Json(new cResult() { Success = true, Text = "密码修改成功！" }, JsonRequestBehavior.AllowGet);
        //        }
        //    }
        //}
    }
}
