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
        //public IUserService UserService { get; set; }

        //public ISysLoginPowerService SysLoginPowerService { get; set; }
        //public ISysmodulecontentService SysmodulecontentService { get; set; }
        //public IBsPaClassService BsPaClassService { get; set; }
        //public IBsPaAreaService BsPaAreaService { get; set; }
        //public ISysPaDepartmentService SysPaDepartmentService { get; set; }
        //public ISysEnterpriseArchivesService SysEnterpriseArchivesService { get; set; }
        //public IFbPaBaseSetService FbPaBaseSetService { get; set; }
        //public IEmemployeearchiveService EmemployeearchiveService { get; set; }
        //public IFbSupplierArchivesService FbSupplierArchivesService { get; set; }
        //public ActionResult IniAll()
        //{
        //    IniUser();
        //    IniUserS();
        //    InISysPaClassAndArea();
        //    InISysModule();
        //    return Json("成功", JsonRequestBehavior.AllowGet);
        //}

        //public ActionResult IniUser()
        //{
        //    SysLoginPower u = new SysLoginPower();
        //    u.Emname = "管理员";
        //    u.Id = "default";
        //    u.Ifcash = "false";
        //    u.Maxdiscount = 0;
        //    u.UserType = 0;
        //    u.Username = "sysadmin";
        //    u.Userpw = "1";
        //    u.Userstate = "0";
        //    SysLoginPowerService.Create(u);
        //    return null;
        //}

        //public ActionResult IniUserS()
        //{
        //    for (int i = 0; i < 50; i++)
        //    {
        //        SysLoginPower u = new SysLoginPower();
        //        u.Emname = "管理员" + i;
        //        u.Id = i.ToString();
        //        u.Ifcash = "false";
        //        u.Maxdiscount = 0;
        //        u.UserType = i % 2;
        //        u.Username = "user" + i;
        //        u.Userpw = "1";
        //        u.Userstate = "0";
        //        SysLoginPowerService.Create(u);
        //    }

        //    return null;
        //}

        //public ActionResult InISysPaClassAndArea()
        //{
        //    BsPaAreaService.Create(new BsPaArea() { Id = "1", AreaName = "中山" });
        //    BsPaAreaService.Create(new BsPaArea() { Id = "2", AreaName = "西岗" });
        //    BsPaAreaService.Create(new BsPaArea() { Id = "3", AreaName = "沙河口" });
        //    BsPaAreaService.Create(new BsPaArea() { Id = "4", AreaName = "甘井子" });
        //    BsPaAreaService.Create(new BsPaArea() { Id = "5", AreaName = "开发区" });
        //    BsPaAreaService.Create(new BsPaArea() { Id = "6", AreaName = "金州" });
        //    BsPaAreaService.Create(new BsPaArea() { Id = "7", AreaName = "旅顺" });

        //    BsPaClassService.Create(new BsPaClass() { Id = "1", ClassName = "直营店" });
        //    BsPaClassService.Create(new BsPaClass() { Id = "2", ClassName = "加盟店" });
        //    return null;
        //}

        //public ActionResult InISysModule()
        //{
        //    Sysmodulecontent m1 = new Sysmodulecontent();
        //    m1.Icon = "";
        //    m1.Id = "root";
        //    m1.ParentId = "";
        //    m1.Url = "";
        //    m1.Windowname = "root";
        //    m1.SupplierVisible = true;
        //    m1.EmployeeVisible = true;

        //    SysmodulecontentService.Create(m1);

        //    #region 员工菜单

        //    #region 数据查询
        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-search",
        //        Id = "em-query",
        //        ParentId = "root",
        //        Url = "",
        //        Windowname = "数据查询",
        //        EmployeeVisible = true,
        //        Index = 1
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-cart",
        //        Id = "report-supplier-purchase",
        //        ParentId = "em-query",
        //        Url = "/Report/SupplierPurchase",
        //        Windowname = "供货商订单查询统计",
        //        Index = 11,
        //        EmployeeVisible = true
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-cart",
        //        Id = "report-supplier-purchase-history",
        //        ParentId = "em-query",
        //        Url = "/Report/SupplierPurchaseHistory",
        //        Windowname = "供货商历史订单查询",
        //        Index = 12,
        //        EmployeeVisible = true
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-cart",
        //        Id = "report-branch-purchase",
        //        ParentId = "em-query",
        //        Url = "/Report/BranchPurchase",
        //        Windowname = "分店订单查询统计",
        //        Index = 13,
        //        EmployeeVisible = true
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-cart",
        //        Id = "report-branch-purchase-history",
        //        ParentId = "em-query",
        //        Url = "/Report/BranchPurchaseHistory",
        //        Windowname = "分店历史订单查询",
        //        Index = 14,
        //        EmployeeVisible = true
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-cart",
        //        Id = "report-branch-goods",
        //        ParentId = "em-query",
        //        Url = "/Query/BranchPurchaseGoods",
        //        Windowname = "分店商品统计",
        //        Index = 15,
        //        EmployeeVisible = true
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-cart",
        //        Id = "report-branch-goods-retail",
        //        ParentId = "em-query",
        //        Url = "/Report/BranchRetail/",
        //        Windowname = "分店销售数据统计",
        //        Index = 16,
        //        EmployeeVisible = true
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-cart",
        //        Id = "report-branch-purchase-retail-compare",
        //        ParentId = "em-query",
        //        Url = "/Report/BranchPurchaseRetailCompare/",
        //        Windowname = "分店采购销售对比",
        //        Index = 17,
        //        EmployeeVisible = true
        //    };
        //    SysmodulecontentService.Create(m1);
        //    #endregion

        //    #region 档案管理
        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-vcard",
        //        Id = "archives",
        //        ParentId = "root",
        //        Url = "",
        //        Windowname = "档案管理",
        //        EmployeeVisible = true,
        //        Index = 2
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-vcard-edit",
        //        Id = "user_archives",
        //        ParentId = "archives",
        //        Url = "/Archives/EmployeeList",
        //        Windowname = "公司人员档案",
        //        Index = 11,
        //        EmployeeVisible = true,
        //        SupplierVisible = false
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-user-suit",
        //        Id = "supplier_archives",
        //        ParentId = "archives",
        //        Url = "/Archives/SupplierList",
        //        Windowname = "供应商档案",
        //        Index = 12,
        //        EmployeeVisible = true,
        //        SupplierVisible = false
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-chart-organisation",
        //        Id = "branch_archives",
        //        ParentId = "archives",
        //        Url = "/Archives/BranchList",
        //        Windowname = "连锁店档案",
        //        Index = 13,
        //        EmployeeVisible = true,
        //        SupplierVisible = false
        //    };
        //    SysmodulecontentService.Create(m1);

        //    //m1 = new Sysmodulecontent()
        //    //{
        //    //    Icon = "icon-cart",
        //    //    Id = "goods_archives",
        //    //    ParentId = "archives",
        //    //    Url = "/Archives/GoodsList",
        //    //    Windowname = "商品档案",
        //    //    Index = 14,
        //    //    EmployeeVisible = true,
        //    //    SupplierVisible = false
        //    //};
        //    //SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-cart",
        //        Id = "goods_archivestree",
        //        ParentId = "archives",
        //        Url = "/Archives/GoodsListTree",
        //        Windowname = "商品档案",
        //        Index = 15,
        //        EmployeeVisible = true,
        //        SupplierVisible = false
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-chart-organisation",
        //        Id = "SupplierBranchRelationManagement",
        //        ParentId = "archives",
        //        Url = "/Archives/SupplierBranchRelationManagement",
        //        Windowname = "供货商分店关系管理",
        //        Index = 16,
        //        EmployeeVisible = true,
        //        SupplierVisible = false
        //    };
        //    SysmodulecontentService.Create(m1);
        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-chart-organisation",
        //        Id = "BranchSupplierRelationManagement",
        //        ParentId = "archives",
        //        Url = "/Archives/BranchSupplierRelationManagement",
        //        Windowname = "分店供货商关系管理",
        //        Index = 16,
        //        EmployeeVisible = true,
        //        SupplierVisible = false
        //    };
        //    SysmodulecontentService.Create(m1);
        //    #endregion

        //    #region 补货管理
        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-car",
        //        Id = "business-em",
        //        ParentId = "root",
        //        Url = "",
        //        Windowname = "补货管理",
        //        EmployeeVisible = true,
        //        Index = 3
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-cart-add",
        //        Id = "business-supplement",
        //        ParentId = "business-em",
        //        Url = "/Business/SupplementList",
        //        Windowname = "产品补货",
        //        EmployeeVisible = true
        //    };
        //    SysmodulecontentService.Create(m1);
        //    #endregion

        //    #region 系统设置
        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-node",
        //        Id = "system",
        //        ParentId = "root",
        //        Url = "",
        //        Windowname = "系统设置",
        //        EmployeeVisible = true,
        //        Index = 4
        //    };
        //    SysmodulecontentService.Create(m1);

        //    //m1 = new Sysmodulecontent()
        //    //{
        //    //    Icon = "icon-user",
        //    //    Id = "users",
        //    //    ParentId = "system",
        //    //    Url = "/Home/List",
        //    //    Windowname = "用户管理",
        //    //    EmployeeVisible = true,
        //    //    SupplierVisible = true
        //    //};
        //    //SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-bricks",
        //        Id = "suptypelist",
        //        ParentId = "system",
        //        Url = "/Category/SupTypeList",
        //        Windowname = "行业管理",
        //        EmployeeVisible = true,
        //        SupplierVisible = false,
        //        Index = 41
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-brick",
        //        Id = "paclasslist",
        //        ParentId = "system",
        //        Url = "/Category/PaClassList",
        //        Windowname = "分店类型",
        //        EmployeeVisible = true,
        //        SupplierVisible = false,
        //        Index = 42
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-group-link",
        //        Id = "empapoliticslist",
        //        ParentId = "system",
        //        Url = "/Category/EmPaPoliticsList",
        //        Windowname = "员工政治面貌",
        //        EmployeeVisible = true,
        //        SupplierVisible = false,
        //        Index = 43
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-map",
        //        Id = "BsAreaList",
        //        ParentId = "system",
        //        Url = "/Category/BsPaAreaList",
        //        Windowname = "区域管理",
        //        EmployeeVisible = true,
        //        SupplierVisible = false,
        //        Index = 44
        //    };
        //    SysmodulecontentService.Create(m1);
        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-drive-user",
        //        Id = "nationlist",
        //        ParentId = "system",
        //        Url = "/Category/NationList",
        //        Windowname = "员工民族",
        //        EmployeeVisible = true,
        //        SupplierVisible = false,
        //        Index = 45
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-coins",
        //        Id = "classlist",
        //        ParentId = "system",
        //        Url = "/Category/ClassList",
        //        Windowname = "商品分类",
        //        EmployeeVisible = true,
        //        SupplierVisible = false,
        //        Index = 46
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-cog-edit",
        //        Id = "bussiness-setting",
        //        ParentId = "system",
        //        Url = "/Account/BaseSetting/",
        //        Windowname = "业务设置",
        //        EmployeeVisible = true,
        //        SupplierVisible = false,
        //        OpenInNewWindow = true,
        //        Index = 47
        //    };
        //    SysmodulecontentService.Create(m1);
        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-edit",
        //        Id = "websystem-setting",
        //        ParentId = "system",
        //        Url = "/Account/SysSetting/",
        //        Windowname = "系统设置",
        //        EmployeeVisible = true,
        //        SupplierVisible = false,
        //        OpenInNewWindow = true,
        //        Index = 48
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-bell",
        //        Id = "system-postlist",
        //        ParentId = "system",
        //        Url = "/Home/PostList/",
        //        Windowname = "公告管理",
        //        EmployeeVisible = true,
        //        SupplierVisible = false,
        //        OpenInNewWindow = false,
        //        Index = 48
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-bell",
        //        Id = "system-branchpostlist",
        //        ParentId = "system",
        //        Url = "/Home/BranchPostList/",
        //        Windowname = "分店通知",
        //        EmployeeVisible = true,
        //        SupplierVisible = false,
        //        OpenInNewWindow = false,
        //        Index = 49
        //    };
        //    SysmodulecontentService.Create(m1);
        //    #endregion

        //    #endregion






        //    #region 业务管理
        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-car",
        //        Id = "business",
        //        ParentId = "root",
        //        Url = "",
        //        Windowname = "业务管理",
        //        SupplierVisible = true
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-cart",
        //        Id = "business-purchase",
        //        ParentId = "business",
        //        Url = "/Business/PurchaseList",
        //        Windowname = "超市订单",
        //        SupplierVisible = true
        //    };
        //    SysmodulecontentService.Create(m1);

        //    //m1 = new Sysmodulecontent()
        //    //{
        //    //    Icon = "icon-cart-delete",
        //    //    Id = "business-return",
        //    //    ParentId = "business",
        //    //    Url = "/Business/ReturnList",
        //    //    Windowname = "产品退货",
        //    //    SupplierVisible = true
        //    //};
        //    //SysmodulecontentService.Create(m1);

        //    //m1 = new Sysmodulecontent()
        //    //{
        //    //    Icon = "icon-cart-add",
        //    //    Id = "business-supplement",
        //    //    ParentId = "business",
        //    //    Url = "/Business/SupplementList",
        //    //    Windowname = "产品补货",
        //    //    EmployeeVisible = true,
        //    //    SupplierVisible = false
        //    //};
        //    //SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-cart",
        //        Id = "query-goods",
        //        ParentId = "business",
        //        Url = "/Query/GoodsArchiveList",
        //        Windowname = "产品管理",
        //        Index = 24,
        //        EmployeeVisible = false,
        //        SupplierVisible = true
        //    };
        //    SysmodulecontentService.Create(m1);
        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-cart",
        //        Id = "query-supplier_branch",
        //        ParentId = "business",
        //        Url = "/Archives/BranchList",
        //        Windowname = "分店查看",
        //        Index = 25,
        //        EmployeeVisible = false,
        //        SupplierVisible = true
        //    };
        //    SysmodulecontentService.Create(m1);

        //    #endregion

        //    #region 数据查询
        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-search",
        //        Id = "query",
        //        ParentId = "root",
        //        Url = "",
        //        Windowname = "数据查询",
        //        SupplierVisible = true
        //    };
        //    SysmodulecontentService.Create(m1);
        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-cart",
        //        Id = "report-branch-purchase-sup",
        //        ParentId = "query",
        //        Url = "/Report/BranchPurchase",
        //        Windowname = "分店订单查询统计",
        //        Index = 31,
        //        SupplierVisible = true,
        //        EmployeeVisible = false
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-cart",
        //        Id = "report-branch-purchase-sup-history",
        //        ParentId = "query",
        //        Url = "/Report/BranchPurchaseHistory",
        //        Windowname = "分店历史订单查询",
        //        Index = 32,
        //        SupplierVisible = true
        //    };
        //    SysmodulecontentService.Create(m1);

        //    m1 = new Sysmodulecontent()
        //    {
        //        Icon = "icon-cart",
        //        Id = "report-branch-goods-sup",
        //        ParentId = "query",
        //        Url = "/Query/BranchPurchaseGoods",
        //        Windowname = "分店商品统计",
        //        Index = 33,
        //        SupplierVisible = true,
        //        EmployeeVisible = false
        //    };
        //    SysmodulecontentService.Create(m1);
        //    //m1 = new Sysmodulecontent()
        //    //{
        //    //    Icon = "icon-cart",
        //    //    Id = "query-purchase",
        //    //    ParentId = "query",
        //    //    Url = "/Query/PurchaseQuery",
        //    //    Windowname = "超市订单",
        //    //    Index = 21,
        //    //    SupplierVisible = true
        //    //};
        //    //SysmodulecontentService.Create(m1);

        //    //m1 = new Sysmodulecontent()
        //    //{
        //    //    Icon = "icon-cart",
        //    //    Id = "query-branch-order-purchase",
        //    //    ParentId = "query",
        //    //    Url = "/Query/BranchPurchaseOrder",
        //    //    Windowname = "分店订货单据",
        //    //    Index = 21,
        //    //    SupplierVisible = true
        //    //};
        //    //SysmodulecontentService.Create(m1);

        //    //m1 = new Sysmodulecontent()
        //    //{
        //    //    Icon = "icon-cart",
        //    //    Id = "query-branch-order-goods",
        //    //    ParentId = "query",
        //    //    Url = "/Query/BranchPurchaseGoods",
        //    //    Windowname = "分店订货商品",
        //    //    Index = 33,
        //    //    SupplierVisible = true,
        //    //    EmployeeVisible = false
        //    //};
        //    //SysmodulecontentService.Create(m1);

        //    //m1 = new Sysmodulecontent()
        //    //{
        //    //    Icon = "icon-cart",
        //    //    Id = "query-branch-order-supplier",
        //    //    ParentId = "query",
        //    //    Url = "/Query/BranchPurchaseSupplier",
        //    //    Windowname = "分店供货商订货",
        //    //    Index = 23,
        //    //    EmployeeVisible = true,
        //    //    SupplierVisible = true
        //    //};
        //    //SysmodulecontentService.Create(m1);



        //    #endregion

        //    return null;
        //}

        public JsonResult GetModules()
        {
            //if (Session[AuthorizeSettings.SessionUserType] == null)
            //{
            //    return Json("", JsonRequestBehavior.AllowGet);
            //}
            //if (Session[AuthorizeSettings.SessionUserType].ToString() == "0")
            //{
            //    return Json(
            //        SysmodulecontentService.ModelListToDto(
            //            SysmodulecontentService.GetAll().Where(p => p.ParentId.Length > 0 && p.EmployeeVisible).OrderBy(p => p.Index).ToList()
            //            ),
            //        JsonRequestBehavior.AllowGet);
            //}
            //else if (Session[AuthorizeSettings.SessionUserType].ToString() == "1")
            //{
            //    return Json(
            //        SysmodulecontentService.ModelListToDto(
            //            SysmodulecontentService.GetAll().Where(p => p.ParentId.Length > 0 && p.SupplierVisible).OrderBy(p => p.Index).ToList()
            //            ),
            //        JsonRequestBehavior.AllowGet);
            //}
            //else
            //{
            //    return Json("", JsonRequestBehavior.AllowGet);
            //}
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
