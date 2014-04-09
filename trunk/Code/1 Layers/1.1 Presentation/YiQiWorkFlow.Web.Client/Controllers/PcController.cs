
using NSH.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiQiWorkFlow.Application.Service.Pc;
using YiQiWorkFlow.Domain.Pc;
using YiQiWorkFlow.Domain.Basement;
using System.Web.Script.Serialization;
using YiQiWorkFlow.Application.Service.Fb;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Web.Client.Common;

namespace YiQiWorkFlow.Web.Client.Controllers
{
    public class PcController : Controller
    {

        #region 商品采购单商品明细
        public IPcPurchaseDetailService PcPurchaseDetailService { get; set; }
        #region 商品采购单商品明细编辑页面
        /// <summary>
        /// 商品采购单商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult PcPurchaseDetailEdit(string id)
        {
            PcPurchaseDetail m = PcPurchaseDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = PcPurchaseDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品采购单商品明细列表页面
        /// <summary>
        /// 商品采购单商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult PcPurchaseDetailList()
        {
            return View();
        }
        #endregion

        #region 商品采购单商品明细保存程序
        /// <summary>
        /// 商品采购单商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SavePcPurchaseDetail(PcPurchaseDetail m)
        {
            SavingResult r = new SavingResult();

            var vResult = m.GetValidateResult();
            if (vResult.IsSuccess == false)
            {
                r.IsSuccess = false;
                r.Message = m.GetValidateMessage();
            }
            else
            {
                if (m.HaveId)
                {
                    PcPurchaseDetailService.Update(m);
                }
                else
                {
                    PcPurchaseDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品采购单商品明细搜索
        /// <summary>
        /// 商品采购单商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchPcPurchaseDetailList(SearchDtoBase<PcPurchaseDetail> c, PcPurchaseDetail s)
        {
            c.entity = s;
            using (YiQiEntities e = new YiQiEntities())
            {

                var q = from l in e.pc_purchase_detail
                        join g in e.fb_goods_archives on l.goods_code equals g.goods_code into join_g
                        from j_g in join_g.DefaultIfEmpty()
                        orderby l.Id
                        select new
                        {
                            PcNumber = l.pc_number,
                            GoodsCode = l.goods_code,
                            GoodsName=j_g.goods_name,
                            GoodsBarCode = l.goods_bar_code,
                            Specification = l.specification,
                            PackUnitCode = l.pack_unit_code,
                            OfferMin = l.offer_min,
                            StockQty = l.stock_qty,
                            OrderQty = l.order_qty,
                            PackQty = l.pack_qty,
                            PackCoef = l.pack_coef,
                            PurchaseQty = l.purchase_qty,
                            PutinQty = l.putin_qty,
                            SalePrice = l.sale_price,
                            PurchasePrice = l.purchase_price,
                            NontaxPurchasePrice = l.nontax_purchase_price,
                            PurchaseMoney = l.purchase_money,
                            NontaxPurchaseMoney = l.nontax_purchase_money,
                            ProduceDate = l.produce_date,
                            SysGuid = l.sys_guid,
                            Id = l.Id

                        };
                if (c.entity.PcNumber.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.PcNumber.StartsWith(c.entity.PcNumber) select l;
                }
                if (c.entity.GoodsCode.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.GoodsCode.StartsWith(c.entity.GoodsCode) select l;
                }
                if (c.entity.GoodsBarCode.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.GoodsBarCode.StartsWith(c.entity.GoodsBarCode) select l;
                }
                if (c.entity.Specification.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.Specification.StartsWith(c.entity.Specification) select l;
                }
                if (c.entity.PackUnitCode.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.PackUnitCode.StartsWith(c.entity.PackUnitCode) select l;
                }
                if (c.entity.SysGuid.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.SysGuid.StartsWith(c.entity.SysGuid) select l;
                }
                if (c.entity.Id.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.Id.StartsWith(c.entity.Id) select l;
                }


                var result =
                    new { total = q.Count(), data = q.Skip(c.pageSize * c.pageIndex).Take(c.pageSize).ToList() };

                return Json(result, JsonRequestBehavior.AllowGet);

            }


        }
        #endregion

        #region 商品采购单商品明细删除
        /// <summary>
        /// 商品采购单商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult PcPurchaseDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            PcPurchaseDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品采购单商品明细

        #region 商品采购单
        public IPcPurchaseManageService PcPurchaseManageService { get; set; }
        #region 商品采购单编辑页面
        /// <summary>
        /// 商品采购单编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult PcPurchaseManageEdit(string id)
        {
            PcPurchaseManage m = PcPurchaseManage.Initial();
            m.Id = "";
            m.PurchaseDate = DateTime.Now;
            if (string.IsNullOrEmpty(id) == false)
            {
                m = PcPurchaseManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品采购单列表页面
        /// <summary>
        /// 商品采购单列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult PcPurchaseManageList()
        {
            return View();
        }
        #endregion

        #region 商品采购单保存程序
        /// <summary>
        /// 商品采购单保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SavePcPurchaseManage(PcPurchaseManage m)
        {
            SavingResult r = new SavingResult();

            var vResult = m.GetValidateResult();
            if (vResult.IsSuccess == false)
            {
                r.IsSuccess = false;
                r.Message = m.GetValidateMessage();
            }
            else
            {
                m.OperatorDate = DateTime.Now;
                if (m.HaveId)
                {
                    PcPurchaseManageService.Update(m);
                }
                else
                {
                    m.CreateDate = DateTime.Now;
                    m.bCode = "0000";
                    m.Id = PcPurchaseManageService.Create(m);
                }

                //PcPurchaseDetail
                var jser = new JavaScriptSerializer();
                var suppliers = jser.Deserialize<List<PcPurchaseDetail>>(Request["goods"]).ToList();
                suppliers.ForEach(p =>
                {
                    //如果是赠品订货，则价格都是0
                    if (m.PcForm == "4")
                    {
                        p.NontaxPurchasePrice = 0;
                        p.PurchasePrice = 0;
                        p.SalePrice = 0;
                        p.PurchaseMoney = 0;
                    }
                    p.PcNumber = m.Id;
                    if (p.IsAdded)
                    {
                        PcPurchaseDetailService.Create(p);
                    }
                    if (p.IsDelete)
                    {
                        PcPurchaseDetailService.Delete(p);
                    }
                    if (p.IsUpdated)
                    {
                        PcPurchaseDetailService.Update(p);
                    }
                });
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品采购单搜索
        /// <summary>
        /// 商品采购单搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchPcPurchaseManageList(SearchDtoBase<PcPurchaseManage> c, PcPurchaseManage s)
        {
            c.entity = s;
            return Json(PcPurchaseManageService.Search(c), JsonRequestBehavior.AllowGet);
        }

        public JsonResult SearchPcPurchaseManageListForList(SearchDtoBase<PcPurchaseManage> c, PcPurchaseManage s)
        {
            c.entity = s;
            return Json(PcPurchaseManageService.Search(c).data, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品采购单删除
        /// <summary>
        /// 商品采购单删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult PcPurchaseManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            PcPurchaseManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品采购单

        #region 商品辅助订货
        IFbGoodsArchivesService FbGoodsArchivesService { get; set; }
        IFbSupplierArchivesService FbSupplierArchivesService { get; set; }
        public ActionResult PcPurchaseManageGoodsEdit()
        {
            return View();
        }

        public ActionResult SavePcPurchaseManageGoods(PcPurchaseManage manage)
        {
            //PcPurchaseDetail
            var jser = new JavaScriptSerializer();
            var goods = jser.Deserialize<List<PcPurchaseDetail>>(Request["goods"]).ToList();


            //YiQiEntities3 ef = new YiQiEntities3();

            //var goodsArchives = (from l in ef.fb_goods_archives where goods.Select(x => x.GoodsCode).ToList().Contains(l.goods_code) select l).ToList();

            var goodIds = goods.Select(x => x.GoodsCode).ToList();

            var goodsArchives = FbGoodsArchivesService.GetsById(goodIds);

            var goodsSuppliers = FbSupplierArchivesService.GetById(goodsArchives.Select(p => p.SupCode).ToList());

            goodsArchives.GroupBy(p => p.SupCode).ToList().ForEach(p =>
            {
                PcPurchaseManage pc = new PcPurchaseManage();
                pc.PcForm = manage.PcForm;
                pc.dCode = manage.dCode;
                pc.WhCode = manage.WhCode;
                pc.PurchaseDate = DateTime.Now;
                pc.IfExamine = "0";
                pc.SupCode = p.Key;
                pc.SupName = goodsSuppliers.FirstOrDefault(x => x.Id == p.Key).SupName;
                pc.Id = PcPurchaseManageService.Create(pc);

                string supcode = p.Key;
                var subGoods = from l in goods
                               from s in p
                               where l.GoodsCode == s.Id
                               select l;
                subGoods.ToList().ForEach(x =>
                {
                    if (pc.PcForm == "4")
                    {
                        x.NontaxPurchasePrice = 0;
                        x.PurchasePrice = 0;
                        x.SalePrice = 0;
                        x.PurchaseMoney = 0;
                    }
                    x.PcNumber = pc.Id;
                    PcPurchaseDetailService.Create(x);
                });
            });

            return Json(new SavingResult { IsSuccess = true, Message = "保存成功" }, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region 商品入库单商品明细
        public IPcPutinDetailService PcPutinDetailService { get; set; }
        #region 商品入库单商品明细编辑页面
        /// <summary>
        /// 商品入库单商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult PcPutinDetailEdit(string id)
        {
            PcPutinDetail m = PcPutinDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = PcPutinDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品入库单商品明细列表页面
        /// <summary>
        /// 商品入库单商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult PcPutinDetailList()
        {
            return View();
        }
        #endregion

        #region 商品入库单商品明细保存程序
        /// <summary>
        /// 商品入库单商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SavePcPutinDetail(PcPutinDetail m)
        {
            SavingResult r = new SavingResult();

            var vResult = m.GetValidateResult();
            if (vResult.IsSuccess == false)
            {
                r.IsSuccess = false;
                r.Message = m.GetValidateMessage();
            }
            else
            {
                if (m.HaveId)
                {
                    PcPutinDetailService.Update(m);
                }
                else
                {
                    PcPutinDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品入库单商品明细搜索
        /// <summary>
        /// 商品入库单商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchPcPutinDetailList(SearchDtoBase<PcPutinDetail> c, PcPutinDetail s)
        {
            //c.entity = s;
            //return Json(PcPutinDetailService.Search(c), JsonRequestBehavior.AllowGet);
                        c.entity = s;
                        using (YiQiEntities e = new YiQiEntities())
                        {

                            var q = from l in e.pc_putin_detail
                                    join g in e.fb_goods_archives on l.goods_code equals g.goods_code into join_g
                                    from j_g in join_g.DefaultIfEmpty()
                                    orderby l.Id
                                    select new
                                               {
                                                   PiNumber = l.pi_number,
                                                   GoodsCode = l.goods_code,
                                                   GoodsBarCode = l.goods_bar_code,
                                                   Specification = l.specification,
                                                   PackUnitCode = l.pack_unit_code,
                                                   OfferMin = l.offer_min,
                                                   PackQty = l.pack_qty,
                                                   PackCoef = l.pack_coef,
                                                   PurchaseQty = l.purchase_qty,
                                                   PutinQty = l.putin_qty,
                                                   SalePrice = l.sale_price,
                                                   PurchasePrice = l.purchase_price,
                                                   NontaxPurchasePrice = l.nontax_purchase_price,
                                                   PurchaseMoney = l.purchase_money,
                                                   NontaxPurchaseMoney = l.nontax_purchase_money,
                                                   ProduceDate = l.produce_date,
                                                   SysGuid = l.sys_guid,
                                                   Id = l.Id,
                                                   GoodsName=j_g.goods_name

                                               };
                            if (c.entity.PiNumber.IsNullOrEmpty() == false)
                            {
                                q = from l in q where l.PiNumber.StartsWith(c.entity.PiNumber) select l;
                            }
                            if (c.entity.GoodsCode.IsNullOrEmpty() == false)
                            {
                                q = from l in q where l.GoodsCode.StartsWith(c.entity.GoodsCode) select l;
                            }
                            if (c.entity.GoodsBarCode.IsNullOrEmpty() == false)
                            {
                                q = from l in q where l.GoodsBarCode.StartsWith(c.entity.GoodsBarCode) select l;
                            }
                            if (c.entity.Specification.IsNullOrEmpty() == false)
                            {
                                q = from l in q where l.Specification.StartsWith(c.entity.Specification) select l;
                            }
                            if (c.entity.PackUnitCode.IsNullOrEmpty() == false)
                            {
                                q = from l in q where l.PackUnitCode.StartsWith(c.entity.PackUnitCode) select l;
                            }
                            if (c.entity.SysGuid.IsNullOrEmpty() == false)
                            {
                                q = from l in q where l.SysGuid.StartsWith(c.entity.SysGuid) select l;
                            }
                            if (c.entity.Id.IsNullOrEmpty() == false)
                            {
                                q = from l in q where l.Id.StartsWith(c.entity.Id) select l;
                            }


                            var result =
                                new { total = q.Count(), data = q.Skip(c.pageSize * (c.pageIndex)).Take(c.pageSize).ToList() };

                            return Json(result, JsonRequestBehavior.AllowGet);
                        }
        }
        #endregion

        #region 商品入库单商品明细删除
        /// <summary>
        /// 商品入库单商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult PcPutinDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            PcPutinDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品入库单商品明细

        #region 商品入库单
        public IPcPutinManageService PcPutinManageService { get; set; }
        #region 商品入库单编辑页面
        /// <summary>
        /// 商品入库单编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult PcPutinManageEdit(int? id)
        {
            PcPutinManage m = PcPutinManage.Initial();
            if (id.HasValue && id > 0)
            {
                m = PcPutinManageService.GetById(id.Value);
            }
            else
            {
                m._state = "added";
            }
            return View(m);
        }
        #endregion

        #region 商品入库单列表页面
        /// <summary>
        /// 商品入库单列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult PcPutinManageList()
        {
            return View();
        }
        #endregion

        #region 商品入库单保存程序
        /// <summary>
        /// 商品入库单保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>

        public ActionResult SavePcPutinManage(PcPutinManage m)
        {
            SavingResult r = new SavingResult();

            var vResult = m.GetValidateResult();
            if (vResult.IsSuccess == false)
            {
                r.IsSuccess = false;
                r.Message = m.GetValidateMessage();
            }
            else
            {
                m.OperatorDate = DateTime.Now;

                var jser = new JavaScriptSerializer();
                var details = jser.Deserialize<List<PcPutinDetail>>(Request["detail"]).ToList();

                m.PutinMoney = details.Sum(p => p.PurchaseMoney);
                if (m.HaveId)
                {
                    PcPutinManageService.Update(m);
                }
                else
                {
                    m.CreateDate = DateTime.Now;
                    m.Id = PcPutinManageService.Create(m);
                }

                //Detail
                
                details.ForEach(p =>
                {
                    p.PiNumber = m.Id.ToS();
                    if (p.IsAdded)
                    {
                        PcPutinDetailService.Create(p);
                    }
                    if (p.IsDelete)
                    {
                        PcPutinDetailService.Delete(p);
                    }
                    if (p.IsUpdated)
                    {
                        PcPutinDetailService.Update(p);
                    }
                });
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品入库单搜索
        /// <summary>
        /// 商品入库单搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchPcPutinManageList(SearchDtoBase<PcPutinManage> c, PcPutinManage s)
        {
            c.entity = s;
            return Json(PcPutinManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品入库单删除
        /// <summary>
        /// 商品入库单删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult PcPutinManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            PcPutinManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品入库单

        #region 商品批量入库
        #region 商品入库单编辑页面
        /// <summary>
        /// 商品入库单编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult PcPutinManageBatchEdit(int? id)
        {
            PcPutinManage m = PcPutinManage.Initial();
            if (id.HasValue && id > 0)
            {
                m = PcPutinManageService.GetById(id.Value);
            }
            return View(m);
        }
        #endregion

        #region 商品入库单保存程序
        /// <summary>
        /// 商品入库单保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SavePcPutinBatchManage(PcPutinManage m)
        {
            SavingResult r = new SavingResult();

            var vResult = m.GetValidateResult();
            if (vResult.IsSuccess == false)
            {
                r.IsSuccess = false;
                r.Message = m.GetValidateMessage();
            }
            else
            {
                if (m.HaveId)
                {
                    PcPutinManageService.Update(m);
                }
                else
                {
                    var jser = new JavaScriptSerializer();
                    IList<PcPurchaseManage> purchaseList = jser.Deserialize<List<PcPurchaseManage>>(Request["pcs"]).ToList();

                    var purchaseDetailList = PcPurchaseDetailService.GetByPcNumbers(purchaseList.Select(p => p.Id).ToList());




                    foreach (var purchase in purchaseList)
                    {
                        m = new PcPutinManage();

                        m.BaMoney = purchaseDetailList.Sum(p => p.PurchaseMoney);
                        m.BaNumber = "";//结算单号
                        m.bCode = purchase.bCode;
                        m.CheckDate = purchase.CheckDate;
                        m.CreateDate = DateTime.Now;
                        m.dCode = purchase.dCode;
                        m.EnCode = purchase.EnCode;
                        m.ExamineDate = purchase.ExamineDate;
                        m.ExpectArriveDate = purchase.ExpectArriveDate;
                        //m.IfAblebalance = purchase
                        m.IfBalance = "1";
                        m.IfExamine = "1";
                        m.Operator = "";
                        m.OperatorDate = DateTime.Now;
                        m.PcForm = purchase.PcForm;
                        m.PcMode = purchase.PcMode;
                        m.PcType = purchase.PcType;
                        m.PurchaseDate = purchase.PurchaseDate;
                        m.PutinDate = DateTime.Now;
                        m.PutinMoney = purchaseDetailList.Sum(p => p.PurchaseMoney);
                        m.SupCode = purchase.SupCode;
                        m.WhCode = purchase.WhCode;

                        m.Id = PcPutinManageService.Create(m);

                        var detailList = purchaseDetailList.Where(p => p.PcNumber == purchase.Id).ToList();
                        foreach (var d in detailList)
                        {
                            PcPutinDetail pcD = new PcPutinDetail();
                            pcD.PiNumber = m.Id.ToS();
                            pcD.GoodsBarCode = d.GoodsBarCode;
                            pcD.GoodsCode = d.GoodsCode;
                            pcD.NontaxPurchaseMoney = d.NontaxPurchaseMoney;
                            pcD.NontaxPurchasePrice = d.NontaxPurchasePrice;
                            pcD.OfferMin = d.OfferMin;
                            //pcD.OrderQty = d.OrderQty;
                            pcD.PackCoef = d.PackCoef;
                            pcD.PackQty = d.PackQty;
                            pcD.PackUnitCode = d.PackUnitCode;
                            //pcD.PcNumber = d.PcNumber;
                            pcD.ProduceDate = d.ProduceDate;
                            pcD.PurchaseMoney = d.PurchaseMoney;
                            pcD.PurchasePrice = d.PurchasePrice;
                            pcD.PurchaseQty = d.PurchaseQty;
                            pcD.PutinQty = d.PutinQty;
                            pcD.SalePrice = d.SalePrice;
                            pcD.Specification = d.Specification;
                            //pcD.StockQty = d.StockQty;
                            pcD.SysGuid = d.SysGuid;

                            PcPutinDetailService.Create(pcD);
                        }

                    }
                }
                r.IsSuccess = false;
                r.Message = "保存成功,但是需要执行入库存储过程！";
            }
            return Json(r);
        }
        #endregion
        #endregion

        #region 商品出库单商品明细
        public IPcPutoutDetailService PcPutoutDetailService { get; set; }
        #region 商品出库单商品明细编辑页面
        /// <summary>
        /// 商品出库单商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult PcPutoutDetailEdit(string id)
        {
            PcPutoutDetail m = PcPutoutDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = PcPutoutDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品出库单商品明细列表页面
        /// <summary>
        /// 商品出库单商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult PcPutoutDetailList()
        {
            return View();
        }
        #endregion

        #region 商品出库单商品明细保存程序
        /// <summary>
        /// 商品出库单商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SavePcPutoutDetail(PcPutoutDetail m)
        {
            SavingResult r = new SavingResult();

            var vResult = m.GetValidateResult();
            if (vResult.IsSuccess == false)
            {
                r.IsSuccess = false;
                r.Message = m.GetValidateMessage();
            }
            else
            {
                if (m.HaveId)
                {
                    PcPutoutDetailService.Update(m);
                }
                else
                {
                    PcPutoutDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品出库单商品明细搜索
        /// <summary>
        /// 商品出库单商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchPcPutoutDetailList(SearchDtoBase<PcPutoutDetail> c, PcPutoutDetail s)
        {
            c.entity = s;
            return Json(PcPutoutDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品出库单商品明细删除
        /// <summary>
        /// 商品出库单商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult PcPutoutDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            PcPutoutDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品出库单商品明细

        #region 商品出库单
        public IPcPutoutManageService PcPutoutManageService { get; set; }
        #region 商品出库单编辑页面
        /// <summary>
        /// 商品出库单编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult PcPutoutManageEdit(int? id)
        {
            PcPutoutManage m = PcPutoutManage.Initial();
            if (id.HasValue && id > 0)
            {
                m = PcPutoutManageService.GetById(id.Value);
            }
            return View(m);
        }
        #endregion

        #region 商品出库单列表页面
        /// <summary>
        /// 商品出库单列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult PcPutoutManageList()
        {
            return View();
        }
        #endregion

        #region 商品出库单保存程序
        /// <summary>
        /// 商品出库单保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SavePcPutoutManage(PcPutoutManage m)
        {
            SavingResult r = new SavingResult();

            var vResult = m.GetValidateResult();
            if (vResult.IsSuccess == false)
            {
                r.IsSuccess = false;
                r.Message = m.GetValidateMessage();
            }
            else
            {
                if (m.HaveId)
                {
                    PcPutoutManageService.Update(m);
                }
                else
                {
                    //PcPutoutManageService.Create(m);
                    var jser = new JavaScriptSerializer();
                    IList<PcReturnManage> purchaseList = jser.Deserialize<List<PcReturnManage>>(Request["pcs"]).ToList();

                    var purchaseDetailList = PcReturnDetailService.GetByRtNumbers(purchaseList.Select(p => p.Id).ToList());


                    m.BaMoney = purchaseDetailList.Sum(p => p.ReturnMoney);
                    m.BaNumber = "";//结算单号
                    m.bCode = purchaseList.First().bCode;
                    //m.CheckDate = purchaseList.First().CheckDate;
                    m.CreateDate = DateTime.Now;
                    m.dCode = purchaseList.First().dCode;
                    m.EnCode = purchaseList.First().EnCode;
                    m.ExamineDate = purchaseList.First().ExamineDate;
                    //m.ExpectArriveDate = purchaseList.First().ExpectArriveDate;
                    //m.IfAblebalance = purchaseList.First().i
                    m.IfBalance = "1";
                    m.IfExamine = "1";
                    m.Operator = "";
                    m.OperatorDate = DateTime.Now;
                    m.PcForm = purchaseList.First().PcForm;
                    //m.PcMode = purchaseList.First().PcMode;
                    //m.PcType = purchaseList.First().PcType;
                    //m.PurchaseDate = purchaseList.First().PurchaseDate;
                    //m.PutinDate = DateTime.Now;
                    //m.PutinMoney = purchaseDetailList.Sum(p => p.PurchaseMoney);
                    m.ReturnDate = purchaseList.First().ReturnDate;
                    
                    m.SupCode = purchaseList.First().SupCode;
                    m.WhCode = purchaseList.First().WhCode;

                    m.Id = PcPutoutManageService.Create(m);

                    foreach (var purchase in purchaseList)
                    {
                        var detailList = purchaseDetailList.Where(p => p.RtNumber == purchase.Id).ToList();
                        foreach (var d in detailList)
                        {
                            PcPutoutDetail pcD = new PcPutoutDetail();
                            pcD.PoNumber = m.Id.ToS();
                            pcD.GoodsBarCode = d.GoodsBarCode;
                            pcD.GoodsCode = d.GoodsCode;
                           // pcD.NontaxPurchaseMoney = d.NontaxPurchaseMoney;
                            pcD.NontaxPurchasePrice = d.NontaxPurchasePrice;
                            //pcD.OfferMin = d.OfferMin;
                            //pcD.OrderQty = d.OrderQty;
                            pcD.PackCoef = d.PackCoef;
                            pcD.PackQty = d.PackQty;
                            pcD.PackUnitCode = d.PackUnitCode;
                            //pcD.PcNumber = d.PcNumber;
                            //pcD.ProduceDate = d.ProduceDate;
                            //pcD.PurchaseMoney = d.PurchaseMoney;
                            pcD.PurchasePrice = d.PurchasePrice;
                           // pcD.PurchaseQty = d.PurchaseQty;
                            //pcD.PutinQty = d.PutinQty;
                            pcD.SalePrice = d.SalePrice;
                            pcD.Specification = d.Specification;
                            //pcD.StockQty = d.StockQty;
                            pcD.SysGuid = d.SysGuid;
                            pcD.ReturnMoney = d.ReturnMoney;
                            pcD.ReturnQty = d.ReturnQty;
                            pcD.NontaxReturnMoney = d.NontaxReturnMoney;

                            PcPutoutDetailService.Create(pcD);
                        }

                    }
                }
                r.IsSuccess = false;
                r.Message = "保存成功,但是需要执行存储过程";
            }
            return Json(r);
        }
        #endregion

        #region 商品出库单搜索
        /// <summary>
        /// 商品出库单搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchPcPutoutManageList(SearchDtoBase<PcPutoutManage> c, PcPutoutManage s)
        {
            c.entity = s;
            return Json(PcPutoutManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        public JsonResult SearchPcPutoutManageListData(SearchDtoBase<PcPutoutManage> c, PcPutoutManage s)
        {
            c.entity = s;
            return Json(PcPutoutManageService.Search(c).data, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品出库单删除
        /// <summary>
        /// 商品出库单删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult PcPutoutManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            PcPutoutManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品出库单

        #region 商品返货单商品明细
        public IPcReturnDetailService PcReturnDetailService { get; set; }
        #region 商品返货单商品明细编辑页面
        /// <summary>
        /// 商品返货单商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult PcReturnDetailEdit(string id)
        {
            PcReturnDetail m = PcReturnDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = PcReturnDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品返货单商品明细列表页面
        /// <summary>
        /// 商品返货单商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult PcReturnDetailList()
        {
            return View();
        }
        #endregion

        #region 商品返货单商品明细保存程序
        /// <summary>
        /// 商品返货单商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SavePcReturnDetail(PcReturnDetail m)
        {
            SavingResult r = new SavingResult();

            var vResult = m.GetValidateResult();
            if (vResult.IsSuccess == false)
            {
                r.IsSuccess = false;
                r.Message = m.GetValidateMessage();
            }
            else
            {
                if (m.HaveId)
                {
                    PcReturnDetailService.Update(m);
                }
                else
                {
                    PcReturnDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品返货单商品明细搜索
        /// <summary>
        /// 商品返货单商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchPcReturnDetailList(SearchDtoBase<PcReturnDetail> c, PcReturnDetail s)
        {
            c.entity = s;
            using (YiQiEntities e = new YiQiEntities())
            {

                var q = from l in e.pc_return_detail
                        join g in e.fb_goods_archives on l.goods_code equals g.goods_code into join_g
                        from j_g in join_g.DefaultIfEmpty()
                        orderby l.Id
                        select new
                        {
                            RtNumber = l.rt_number,
                            GoodsCode = l.goods_code,
                            GoodsName=j_g.goods_name,
                            GoodsBarCode = l.goods_bar_code,
                            Specification = l.specification,
                            PackUnitCode = l.pack_unit_code,
                            PackQty = l.pack_qty,
                            PackCoef = l.pack_coef,
                            ReturnQty = l.return_qty,
                            SalePrice = l.sale_price,
                            PurchasePrice = l.purchase_price,
                            NontaxPurchasePrice = l.nontax_purchase_price,
                            ReturnMoney = l.return_money,
                            NontaxReturnMoney = l.nontax_return_money,
                            SaleMoney = l.sale_money,
                            NontaxSaleMoney = l.nontax_sale_money,
                            SysGuid = l.sys_guid,
                            Id = l.Id

                        };
                if (c.entity.RtNumber.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.RtNumber.StartsWith(c.entity.RtNumber) select l;
                }
                if (c.entity.GoodsCode.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.GoodsCode.StartsWith(c.entity.GoodsCode) select l;
                }
                if (c.entity.GoodsBarCode.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.GoodsBarCode.StartsWith(c.entity.GoodsBarCode) select l;
                }
                if (c.entity.Specification.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.Specification.StartsWith(c.entity.Specification) select l;
                }
                if (c.entity.PackUnitCode.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.PackUnitCode.StartsWith(c.entity.PackUnitCode) select l;
                }
                if (c.entity.SysGuid.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.SysGuid.StartsWith(c.entity.SysGuid) select l;
                }
                if (c.entity.Id.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.Id.StartsWith(c.entity.Id) select l;
                }









                var result =
                    new { total = q.Count(), data = q.Skip(c.pageSize * c.pageIndex).Take(c.pageSize).ToList() };

                return Json(result, JsonRequestBehavior.AllowGet);

            }


        }
        #endregion

        #region 商品返货单商品明细删除
        /// <summary>
        /// 商品返货单商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult PcReturnDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            PcReturnDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品返货单商品明细

        #region 商品返货单
        public IPcReturnManageService PcReturnManageService { get; set; }
        #region 商品返货单编辑页面
        /// <summary>
        /// 商品返货单编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult PcReturnManageEdit(string id)
        {
            PcReturnManage m = PcReturnManage.Initial();
            m.Id = "";
            if (string.IsNullOrEmpty(id) == false)
            {
                m = PcReturnManageService.GetById(id);
            }
            else
            {
                m._state = "added";
            }
            return View(m);
        }
        #endregion

        #region 商品返货单列表页面
        /// <summary>
        /// 商品返货单列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult PcReturnManageList()
        {
            return View();
        }
        #endregion

        #region 商品返货单保存程序
        /// <summary>
        /// 商品返货单保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SavePcReturnManage(PcReturnManage m)
        {
            SavingResult r = new SavingResult();

            var vResult = m.GetValidateResult();
            if (vResult.IsSuccess == false)
            {
                r.IsSuccess = false;
                r.Message = m.GetValidateMessage();
            }
            else
            {
                if (m.HaveId)
                {
                    PcReturnManageService.Update(m);
                }
                else
                {
                    m.Id=PcReturnManageService.Create(m);
                }

                var jser = new JavaScriptSerializer();
                var goods = jser.Deserialize<List<PcReturnDetail>>(Request["goods"]).ToList();
                foreach (var good in goods)
                {
                    good.RtNumber = m.Id;
                    if (good.GoodsCode.IsNullOrEmpty())
                    {
                        continue;
                    }
                    if (good.IsAdded)
                    {
                        PcReturnDetailService.Create(good);
                    }
                    else if (good.IsDelete)
                    {
                        PcReturnDetailService.Delete(good);
                    }
                    else if (good.IsUpdated)
                    {
                        PcReturnDetailService.Update(good);
                    }
                }
                

                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品返货单搜索
        /// <summary>
        /// 商品返货单搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchPcReturnManageList(SearchDtoBase<PcReturnManage> c, PcReturnManage s)
        {
            c.entity = s;
            return Json(PcReturnManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品返货单删除
        /// <summary>
        /// 商品返货单删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult PcReturnManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            PcReturnManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品返货单
    }
}





