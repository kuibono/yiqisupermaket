
using NSH.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiQiWorkFlow.Application.Service.Op;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;
using YiQiWorkFlow.Web.Client.Common;
using System.Web.Script.Serialization;

namespace YiQiWorkFlow.Web.Client.Controllers
{
    public class OpController : Controller
    {

        #region 商品调整单商品明细
        public IOpAdjustDetailService OpAdjustDetailService { get; set; }
        #region 商品调整单商品明细编辑页面
        /// <summary>
        /// 商品调整单商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpAdjustDetailEdit(string id)
        {
            OpAdjustDetail m = OpAdjustDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = OpAdjustDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品调整单商品明细列表页面
        /// <summary>
        /// 商品调整单商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpAdjustDetailList()
        {
            return View();
        }
        #endregion

        #region 商品调整单商品明细保存程序
        /// <summary>
        /// 商品调整单商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpAdjustDetail(OpAdjustDetail m)
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
                    OpAdjustDetailService.Update(m);
                }
                else
                {
                    OpAdjustDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品调整单商品明细搜索
        /// <summary>
        /// 商品调整单商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpAdjustDetailList(SearchDtoBase<OpAdjustDetail> c, OpAdjustDetail s)
        {
            c.entity = s;
            return Json(OpAdjustDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品调整单商品明细删除
        /// <summary>
        /// 商品调整单商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpAdjustDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpAdjustDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品调整单商品明细

        #region 商品调整单
        public IOpAdjustManageService OpAdjustManageService { get; set; }
        #region 商品调整单编辑页面
        /// <summary>
        /// 商品调整单编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpAdjustManageEdit(string id)
        {
            OpAdjustManage m = OpAdjustManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = OpAdjustManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品调整单列表页面
        /// <summary>
        /// 商品调整单列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpAdjustManageList()
        {
            return View();
        }
        #endregion

        #region 商品调整单保存程序
        /// <summary>
        /// 商品调整单保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpAdjustManage(OpAdjustManage m)
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
                    OpAdjustManageService.Update(m);
                }
                else
                {
                    OpAdjustManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品调整单搜索
        /// <summary>
        /// 商品调整单搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpAdjustManageList(SearchDtoBase<OpAdjustManage> c, OpAdjustManage s)
        {
            c.entity = s;
            return Json(OpAdjustManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品调整单删除
        /// <summary>
        /// 商品调整单删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpAdjustManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpAdjustManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品调整单

        #region 商品调整流水帐单
        public IOpAdjustManageFlowService OpAdjustManageFlowService { get; set; }
        #region 商品调整流水帐单编辑页面
        /// <summary>
        /// 商品调整流水帐单编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpAdjustManageFlowEdit(int? id)
        {
            OpAdjustManageFlow m = OpAdjustManageFlow.Initial();
            if (id.HasValue && id > 0)
            {
                m = OpAdjustManageFlowService.GetById(id.Value);
            }
            return View(m);
        }
        #endregion

        #region 商品调整流水帐单列表页面
        /// <summary>
        /// 商品调整流水帐单列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpAdjustManageFlowList()
        {
            return View();
        }
        #endregion

        #region 商品调整流水帐单保存程序
        /// <summary>
        /// 商品调整流水帐单保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpAdjustManageFlow(OpAdjustManageFlow m)
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
                    OpAdjustManageFlowService.Update(m);
                }
                else
                {
                    OpAdjustManageFlowService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品调整流水帐单搜索
        /// <summary>
        /// 商品调整流水帐单搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpAdjustManageFlowList(SearchDtoBase<OpAdjustManageFlow> c, OpAdjustManageFlow s)
        {
            c.entity = s;
            return Json(OpAdjustManageFlowService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品调整流水帐单删除
        /// <summary>
        /// 商品调整流水帐单删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpAdjustManageFlowDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpAdjustManageFlowService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品调整流水帐单

        #region 进货成本调整批次明细
        public IOpAdjustPurchaseDetailService OpAdjustPurchaseDetailService { get; set; }
        #region 进货成本调整批次明细编辑页面
        /// <summary>
        /// 进货成本调整批次明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpAdjustPurchaseDetailEdit(string id)
        {
            OpAdjustPurchaseDetail m = OpAdjustPurchaseDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = OpAdjustPurchaseDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 进货成本调整批次明细列表页面
        /// <summary>
        /// 进货成本调整批次明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpAdjustPurchaseDetailList()
        {
            return View();
        }
        #endregion

        #region 进货成本调整批次明细保存程序
        /// <summary>
        /// 进货成本调整批次明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpAdjustPurchaseDetail(OpAdjustPurchaseDetail m)
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
                    OpAdjustPurchaseDetailService.Update(m);
                }
                else
                {
                    OpAdjustPurchaseDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 进货成本调整批次明细搜索
        /// <summary>
        /// 进货成本调整批次明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpAdjustPurchaseDetailList(SearchDtoBase<OpAdjustPurchaseDetail> c, OpAdjustPurchaseDetail s)
        {
            c.entity = s;
            return Json(OpAdjustPurchaseDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 进货成本调整批次明细删除
        /// <summary>
        /// 进货成本调整批次明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpAdjustPurchaseDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpAdjustPurchaseDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  进货成本调整批次明细

        #region 进货成本调整单
        public IOpAdjustPurchaseManageService OpAdjustPurchaseManageService { get; set; }
        #region 进货成本调整单编辑页面
        /// <summary>
        /// 进货成本调整单编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpAdjustPurchaseManageEdit(string id)
        {
            OpAdjustPurchaseManage m = OpAdjustPurchaseManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = OpAdjustPurchaseManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 进货成本调整单列表页面
        /// <summary>
        /// 进货成本调整单列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpAdjustPurchaseManageList()
        {
            return View();
        }
        #endregion

        #region 进货成本调整单保存程序
        /// <summary>
        /// 进货成本调整单保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpAdjustPurchaseManage(OpAdjustPurchaseManage m)
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
                    OpAdjustPurchaseManageService.Update(m);
                }
                else
                {
                    OpAdjustPurchaseManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 进货成本调整单搜索
        /// <summary>
        /// 进货成本调整单搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpAdjustPurchaseManageList(SearchDtoBase<OpAdjustPurchaseManage> c, OpAdjustPurchaseManage s)
        {
            c.entity = s;
            return Json(OpAdjustPurchaseManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 进货成本调整单删除
        /// <summary>
        /// 进货成本调整单删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpAdjustPurchaseManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpAdjustPurchaseManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  进货成本调整单

        #region 商品调拨单商品明细
        public IOpAllotDetailService OpAllotDetailService { get; set; }
        #region 商品调拨单商品明细编辑页面
        /// <summary>
        /// 商品调拨单商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpAllotDetailEdit(string id)
        {
            OpAllotDetail m = OpAllotDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = OpAllotDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品调拨单商品明细列表页面
        /// <summary>
        /// 商品调拨单商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpAllotDetailList()
        {
            return View();
        }
        #endregion

        #region 商品调拨单商品明细保存程序
        /// <summary>
        /// 商品调拨单商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpAllotDetail(OpAllotDetail m)
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
                    OpAllotDetailService.Update(m);
                }
                else
                {
                    OpAllotDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品调拨单商品明细搜索
        /// <summary>
        /// 商品调拨单商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpAllotDetailList(SearchDtoBase<OpAllotDetail> c, OpAllotDetail s)
        {
            c.entity = s;
            using (YiQiEntities e = new YiQiEntities())
            {

                var q = from l in e.op_allot_detail
                        join g in e.fb_goods_archives on l.goods_code equals g.goods_code into join_g
                        from j_g in join_g.DefaultIfEmpty()
                        orderby l.Id
                        select new
                        {
                            AlNumber = l.al_number,
                            GoodsCode = l.goods_code,
                            GoodsName=j_g.goods_name,
                            GoodsBarCode = l.goods_bar_code,
                            Specification = l.specification,
                            PackUnitCode = l.pack_unit_code,
                            StockQty = l.stock_qty,
                            PackQty = l.pack_qty,
                            PackCoef = l.pack_coef,
                            AllotQty = l.allot_qty,
                            SalePrice = l.sale_price,
                            PurchasePrice = l.purchase_price,
                            NontaxPurchasePrice = l.nontax_purchase_price,
                            AllotMoney = l.allot_money,
                            NontaxAllotMoney = l.nontax_allot_money,
                            SaleMoney = l.sale_money,
                            NontaxSaleMoney = l.nontax_sale_money,
                            Id = l.Id

                        };
                if (c.entity.AlNumber.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.AlNumber.StartsWith(c.entity.AlNumber) select l;
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

        #region 商品调拨单商品明细删除
        /// <summary>
        /// 商品调拨单商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpAllotDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpAllotDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品调拨单商品明细

        #region 商品调拨单
        public IOpAllotManageService OpAllotManageService { get; set; }
        #region 商品调拨单编辑页面
        /// <summary>
        /// 商品调拨单编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpAllotManageEdit(string id)
        {
            OpAllotManage m = OpAllotManage.Initial();
            m.CreateDate = DateTime.Now;
            m.AlDate = DateTime.Now;
            if (string.IsNullOrEmpty(id) == false)
            {
                m = OpAllotManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品调拨单列表页面
        /// <summary>
        /// 商品调拨单列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpAllotManageList()
        {
            return View();
        }
        #endregion

        #region 商品调拨单保存程序
        /// <summary>
        /// 商品调拨单保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpAllotManage(OpAllotManage m)
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
                m.Operator = MyEnv.LoginUser.Id;
                m.OperatorDate = DateTime.Now;
                if (m.HaveId)
                {
                    OpAllotManageService.Update(m);
                }
                else
                {
                    m.CreateDate = DateTime.Now;
                    m.Id = OpAllotManageService.Create(m);
                }

                //Detail
                var jser = new JavaScriptSerializer();
                var details = jser.Deserialize<List<OpAllotDetail>>(Request["detail"]).ToList();
                details.ForEach(p =>
                {
                    p.AlNumber = m.Id;
                    if (p.IsAdded)
                    {
                        OpAllotDetailService.Create(p);
                    }
                    if (p.IsDelete)
                    {
                        OpAllotDetailService.Delete(p);
                    }
                    if (p.IsUpdated)
                    {
                        OpAllotDetailService.Update(p);
                    }
                });

                //验证是否审核，如果审核则调用入库出库存储过程

                r.IsSuccess = true;
                r.Message = "保存成功!";
            }
            return Json(r);
        }


        #endregion

        #region 商品调拨单搜索
        /// <summary>
        /// 商品调拨单搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpAllotManageList(SearchDtoBase<OpAllotManage> c, OpAllotManage s)
        {
                        c.entity = s;
            using (YiQiEntities e = new YiQiEntities())
            {

                var q = from l in e.op_allot_manage
                        join ea in e.em_employee_archives on l.assessor equals ea.em_code into join_ea
                        from j_ea in join_ea.DefaultIfEmpty()
                        join eo in e.em_employee_archives on l.@operator equals eo.em_code into join_eo
                        from j_eo in join_eo.DefaultIfEmpty()
                        join whi in e.op_pa_warehouse on l.wh_code_in equals whi.wh_code into join_whi
                        from j_whi in join_whi.DefaultIfEmpty()
                        join who in e.op_pa_warehouse on l.wh_code_out equals who.wh_code into join_who
                        from j_who in join_who.DefaultIfEmpty()
                        orderby l.al_number
                        select new
                                   {
                                    AlNumber=l.al_number,
                                    AlType=l.al_type,
                                    OrganOut=l.organ_out,
                                    OrganNameOut=l.organ_name_out,
                                    WhCodeOut=j_who.wh_name,
                                    OrganIn=l.organ_in,
                                    OrganNameIn=l.organ_name_in,
                                    WhCodeIn=j_whi.wh_name,
                                    AlDate=l.al_date,
                                    CreateDate=l.create_date,
                                    Operator=j_eo.em_name,
                                    Assessor=j_ea.em_name,
                                    IfExamine=l.if_examine,
                                    ExamineDate=l.examine_date,
                                    OperatorDate=l.operator_date

                                   };
                if (c.entity.Id.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.AlNumber.StartsWith(c.entity.Id) select l;
                }
                if (c.entity.AlType.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.AlType.StartsWith(c.entity.AlType) select l;
                }
                if (c.entity.OrganOut.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.OrganOut.StartsWith(c.entity.OrganOut) select l;
                }
                if (c.entity.OrganNameOut.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.OrganNameOut.StartsWith(c.entity.OrganNameOut) select l;
                }
                if (c.entity.WhCodeOut.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.WhCodeOut.StartsWith(c.entity.WhCodeOut) select l;
                }
                if (c.entity.OrganIn.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.OrganIn.StartsWith(c.entity.OrganIn) select l;
                }
                if (c.entity.OrganNameIn.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.OrganNameIn.StartsWith(c.entity.OrganNameIn) select l;
                }
                if (c.entity.WhCodeIn.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.WhCodeIn.StartsWith(c.entity.WhCodeIn) select l;
                }
                if (c.entity.Operator.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.Operator.StartsWith(c.entity.Operator) select l;
                }
                if (c.entity.Assessor.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.Assessor.StartsWith(c.entity.Assessor) select l;
                }
                if (c.entity.IfExamine.IsNullOrEmpty() == false)
                {
                    q = from l in q where l.IfExamine.StartsWith(c.entity.IfExamine) select l;
                }
                
                
                if(c.OperatorDateH.HasValue)
                {
                    q = from l in q where l.OperatorDate<=c.OperatorDateH select l;
                }
                if(c.OperatorDateL.HasValue)
                {
                    q = from l in q where l.OperatorDate >= c.OperatorDateL select l;
                }
    
                
                if(c.ExamineDateH.HasValue)
                {
                    q = from l in q where l.ExamineDate<=c.ExamineDateH select l;
                }
                if(c.OperatorDateL.HasValue)
                {
                    q = from l in q where l.ExamineDate >= c.ExamineDateL select l;
                }
    
                
                if(c.CreateDateH.HasValue)
                {
                    q = from l in q where l.CreateDate<=c.CreateDateH select l;
                }
                if(c.OperatorDateL.HasValue)
                {
                    q = from l in q where l.CreateDate >= c.CreateDateL select l;
                }
    
                
                
                
                

                var result =
                    new { total = q.Count(), data = q.Skip(c.pageSize * c.pageIndex).Take(c.pageSize).ToList() };

                return Json(result, JsonRequestBehavior.AllowGet);
                
		}


        }
        #endregion

        #region 商品调拨单删除
        /// <summary>
        /// 商品调拨单删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpAllotManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpAllotManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品调拨单

        #region 商品调拨流水帐单
        public IOpAllotManageFlowService OpAllotManageFlowService { get; set; }
        #region 商品调拨流水帐单编辑页面
        /// <summary>
        /// 商品调拨流水帐单编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpAllotManageFlowEdit(int? id)
        {
            OpAllotManageFlow m = OpAllotManageFlow.Initial();
            if (id.HasValue && id > 0)
            {
                m = OpAllotManageFlowService.GetById(id.Value);
            }
            return View(m);
        }
        #endregion

        #region 商品调拨流水帐单列表页面
        /// <summary>
        /// 商品调拨流水帐单列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpAllotManageFlowList()
        {
            return View();
        }
        #endregion

        #region 商品调拨流水帐单保存程序
        /// <summary>
        /// 商品调拨流水帐单保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpAllotManageFlow(OpAllotManageFlow m)
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
                    OpAllotManageFlowService.Update(m);
                }
                else
                {
                    OpAllotManageFlowService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品调拨流水帐单搜索
        /// <summary>
        /// 商品调拨流水帐单搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpAllotManageFlowList(SearchDtoBase<OpAllotManageFlow> c, OpAllotManageFlow s)
        {
            c.entity = s;
            return Json(OpAllotManageFlowService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品调拨流水帐单删除
        /// <summary>
        /// 商品调拨流水帐单删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpAllotManageFlowDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpAllotManageFlowService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品调拨流水帐单

        #region 商品盘点单商品明细
        public IOpCheckDetailService OpCheckDetailService { get; set; }
        #region 商品盘点单商品明细编辑页面
        /// <summary>
        /// 商品盘点单商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpCheckDetailEdit(int? id)
        {
            OpCheckDetail m = OpCheckDetail.Initial();
            if (id.HasValue && id > 0)
            {
                m = OpCheckDetailService.GetById(id.Value);
            }
            return View(m);
        }
        #endregion

        #region 商品盘点单商品明细列表页面
        /// <summary>
        /// 商品盘点单商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpCheckDetailList()
        {
            return View();
        }
        #endregion

        #region 商品盘点单商品明细保存程序
        /// <summary>
        /// 商品盘点单商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpCheckDetail(OpCheckDetail m)
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
                    OpCheckDetailService.Update(m);
                }
                else
                {
                    OpCheckDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品盘点单商品明细搜索
        /// <summary>
        /// 商品盘点单商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpCheckDetailList(SearchDtoBase<OpCheckDetail> c, OpCheckDetail s)
        {
            c.entity = s;
            return Json(OpCheckDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品盘点单商品明细删除
        /// <summary>
        /// 商品盘点单商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpCheckDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpCheckDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品盘点单商品明细

        #region 商品盘点单
        public IOpCheckManageService OpCheckManageService { get; set; }

        #region 盘点单生成
        public ActionResult OpCheckManageCreate()
        {
            return View(new OpCheckManage());
        }
        #endregion
        #region 商品盘点单编辑页面
        /// <summary>
        /// 商品盘点单编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpCheckManageEdit(string id)
        {
            OpCheckManage m = OpCheckManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = OpCheckManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品盘点单列表页面
        /// <summary>
        /// 商品盘点单列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpCheckManageList()
        {
            return View();
        }
        #endregion

        #region 商品盘点单保存程序
        /// <summary>
        /// 商品盘点单保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpCheckManage(OpCheckManage m)
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
                    OpCheckManageService.Update(m);
                }
                else
                {
                    OpCheckManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }

        public ActionResult SaveOpCheckManageCreate(OpCheckManage m)
        {
            using (YiQiEntities e = new YiQiEntities())
            {
                SavingResult r = new SavingResult();
                r.IsSuccess = false;

                if (m.WhCode.IsNullOrEmpty())
                {
                    r.Message = "盘点仓库不能为空！";
                    return json(r);
                }

                if (m.CkType.IsNullOrEmpty())
                {
                    r.Message = "盘点仓库不能为空！";
                    return json(r);
                }
                if (e.op_check_manage.Any(p => p.wh_code == m.WhCode && p.if_transfer == "0" && p.ck_area == m.CkArea))
                {
                    r.Message = "该盘点仓库的类别有未结转盘点单不能重新生成！";
                    return json(r);
                }
                if (e.op_check_manage.Any(p => p.wh_code == m.WhCode && p.if_transfer == "0"))
                {
                    r.Message = "该盘点仓库有未结转盘点单不能重新生成！";
                    return json(r);
                }

                ///判断是否业务流程
                ///if gf_operation_query(parent.tag,ls_ck_number,this.buttontext) = 0 Then return
                ///

                ///if gf_operation_save(parent.tag,ls_ck_number,this.buttontext,"","") = -1 then return
                ///

                //保存
                OpCheckManageService.Create(m);

                //根据不同条件向op_check_stock 插入数据


                r.IsSuccess = true;
                r.Message = "创建成功！";
                return json(r);

            }
        }


        private ActionResult json(object value)
        {
            return Json(value, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品盘点单搜索
        /// <summary>
        /// 商品盘点单搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpCheckManageList(SearchDtoBase<OpCheckManage> c, OpCheckManage s)
        {
            c.entity = s;
            return Json(OpCheckManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品盘点单删除
        /// <summary>
        /// 商品盘点单删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpCheckManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpCheckManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品盘点单

        #region 盘点库存
        public IOpCheckStockService OpCheckStockService { get; set; }
        #region 盘点库存编辑页面
        /// <summary>
        /// 盘点库存编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpCheckStockEdit(string id)
        {
            OpCheckStock m = OpCheckStock.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = OpCheckStockService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 盘点库存列表页面
        /// <summary>
        /// 盘点库存列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpCheckStockList()
        {
            return View();
        }
        #endregion

        #region 盘点库存保存程序
        /// <summary>
        /// 盘点库存保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpCheckStock(OpCheckStock m)
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
                    OpCheckStockService.Update(m);
                }
                else
                {
                    OpCheckStockService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 盘点库存搜索
        /// <summary>
        /// 盘点库存搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpCheckStockList(SearchDtoBase<OpCheckStock> c, OpCheckStock s)
        {
            c.entity = s;
            return Json(OpCheckStockService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 盘点库存删除
        /// <summary>
        /// 盘点库存删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpCheckStockDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpCheckStockService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  盘点库存

        #region 商品盘点接转单商品汇总明细
        public IOpCheckTransferService OpCheckTransferService { get; set; }
        #region 商品盘点接转单商品汇总明细编辑页面
        /// <summary>
        /// 商品盘点接转单商品汇总明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpCheckTransferEdit(int? id)
        {
            OpCheckTransfer m = OpCheckTransfer.Initial();
            if (id.HasValue && id > 0)
            {
                m = OpCheckTransferService.GetById(id.Value);
            }
            return View(m);
        }
        #endregion

        #region 商品盘点接转单商品汇总明细列表页面
        /// <summary>
        /// 商品盘点接转单商品汇总明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpCheckTransferList()
        {
            return View();
        }
        #endregion

        #region 商品盘点接转单商品汇总明细保存程序
        /// <summary>
        /// 商品盘点接转单商品汇总明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpCheckTransfer(OpCheckTransfer m)
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
                    OpCheckTransferService.Update(m);
                }
                else
                {
                    OpCheckTransferService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品盘点接转单商品汇总明细搜索
        /// <summary>
        /// 商品盘点接转单商品汇总明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpCheckTransferList(SearchDtoBase<OpCheckTransfer> c, OpCheckTransfer s)
        {
            c.entity = s;
            return Json(OpCheckTransferService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品盘点接转单商品汇总明细删除
        /// <summary>
        /// 商品盘点接转单商品汇总明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpCheckTransferDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpCheckTransferService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品盘点接转单商品汇总明细

        #region 商品实时库存
        public IOpDynamicStockService OpDynamicStockService { get; set; }
        #region 商品实时库存编辑页面
        /// <summary>
        /// 商品实时库存编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpDynamicStockEdit(string id)
        {
            OpDynamicStock m = OpDynamicStock.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = OpDynamicStockService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品实时库存列表页面
        /// <summary>
        /// 商品实时库存列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpDynamicStockList()
        {
            return View();
        }
        #endregion

        #region 商品实时库存保存程序
        /// <summary>
        /// 商品实时库存保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpDynamicStock(OpDynamicStock m)
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
                    OpDynamicStockService.Update(m);
                }
                else
                {
                    OpDynamicStockService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品实时库存搜索
        /// <summary>
        /// 商品实时库存搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpDynamicStockList(SearchDtoBase<OpDynamicStock> c, OpDynamicStock s)
        {
            c.entity = s;
            return Json(OpDynamicStockService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品实时库存删除
        /// <summary>
        /// 商品实时库存删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpDynamicStockDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpDynamicStockService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品实时库存

        #region 商品分店实时库存
        public IOpDynamicStockBranchService OpDynamicStockBranchService { get; set; }
        #region 商品分店实时库存编辑页面
        /// <summary>
        /// 商品分店实时库存编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpDynamicStockBranchEdit(string id)
        {
            OpDynamicStockBranch m = OpDynamicStockBranch.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = OpDynamicStockBranchService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品分店实时库存列表页面
        /// <summary>
        /// 商品分店实时库存列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpDynamicStockBranchList()
        {
            return View();
        }
        #endregion

        #region 商品分店实时库存保存程序
        /// <summary>
        /// 商品分店实时库存保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpDynamicStockBranch(OpDynamicStockBranch m)
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
                    OpDynamicStockBranchService.Update(m);
                }
                else
                {
                    OpDynamicStockBranchService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品分店实时库存搜索
        /// <summary>
        /// 商品分店实时库存搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpDynamicStockBranchList(SearchDtoBase<OpDynamicStockBranch> c, OpDynamicStockBranch s)
        {
            c.entity = s;
            return Json(OpDynamicStockBranchService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品分店实时库存删除
        /// <summary>
        /// 商品分店实时库存删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpDynamicStockBranchDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpDynamicStockBranchService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品分店实时库存

        #region 商品仓储实时库存
        public IOpDynamicStockWhService OpDynamicStockWhService { get; set; }
        #region 商品仓储实时库存编辑页面
        /// <summary>
        /// 商品仓储实时库存编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpDynamicStockWhEdit(string id)
        {
            OpDynamicStockWh m = OpDynamicStockWh.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = OpDynamicStockWhService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品仓储实时库存列表页面
        /// <summary>
        /// 商品仓储实时库存列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpDynamicStockWhList()
        {
            return View();
        }
        #endregion

        #region 商品仓储实时库存保存程序
        /// <summary>
        /// 商品仓储实时库存保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpDynamicStockWh(OpDynamicStockWh m)
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
                    OpDynamicStockWhService.Update(m);
                }
                else
                {
                    OpDynamicStockWhService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品仓储实时库存搜索
        /// <summary>
        /// 商品仓储实时库存搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpDynamicStockWhList(SearchDtoBase<OpDynamicStockWh> c, OpDynamicStockWh s)
        {
            c.entity = s;
            return Json(OpDynamicStockWhService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品仓储实时库存删除
        /// <summary>
        /// 商品仓储实时库存删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpDynamicStockWhDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpDynamicStockWhService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品仓储实时库存

        #region 商品库存批次表
        public IOpGoodsBatchService OpGoodsBatchService { get; set; }
        #region 商品库存批次表编辑页面
        /// <summary>
        /// 商品库存批次表编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpGoodsBatchEdit(int? id)
        {
            OpGoodsBatch m = OpGoodsBatch.Initial();
            if (id.HasValue && id > 0)
            {
                m = OpGoodsBatchService.GetById(id.Value);
            }
            return View(m);
        }
        #endregion

        #region 商品库存批次表列表页面
        /// <summary>
        /// 商品库存批次表列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpGoodsBatchList()
        {
            return View();
        }
        #endregion

        #region 商品库存批次表保存程序
        /// <summary>
        /// 商品库存批次表保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpGoodsBatch(OpGoodsBatch m)
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
                    OpGoodsBatchService.Update(m);
                }
                else
                {
                    OpGoodsBatchService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品库存批次表搜索
        /// <summary>
        /// 商品库存批次表搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpGoodsBatchList(SearchDtoBase<OpGoodsBatch> c, OpGoodsBatch s)
        {
            c.entity = s;
            return Json(OpGoodsBatchService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品库存批次表删除
        /// <summary>
        /// 商品库存批次表删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpGoodsBatchDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpGoodsBatchService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品库存批次表

        #region 商品损溢商品明细
        public IOpLossDetailService OpLossDetailService { get; set; }
        #region 商品损溢商品明细编辑页面
        /// <summary>
        /// 商品损溢商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpLossDetailEdit(string id)
        {
            OpLossDetail m = OpLossDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = OpLossDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品损溢商品明细列表页面
        /// <summary>
        /// 商品损溢商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpLossDetailList()
        {
            return View();
        }
        #endregion

        #region 商品损溢商品明细保存程序
        /// <summary>
        /// 商品损溢商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpLossDetail(OpLossDetail m)
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
                    OpLossDetailService.Update(m);
                }
                else
                {
                    OpLossDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品损溢商品明细搜索
        /// <summary>
        /// 商品损溢商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpLossDetailList(SearchDtoBase<OpLossDetail> c, OpLossDetail s)
        {
            c.entity = s;
            return Json(OpLossDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品损溢商品明细删除
        /// <summary>
        /// 商品损溢商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpLossDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpLossDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品损溢商品明细

        #region 商品损溢
        public IOpLossManageService OpLossManageService { get; set; }
        #region 商品损溢编辑页面
        /// <summary>
        /// 商品损溢编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpLossManageEdit(string id)
        {
            OpLossManage m = OpLossManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = OpLossManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品损溢列表页面
        /// <summary>
        /// 商品损溢列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpLossManageList()
        {
            return View();
        }
        #endregion

        #region 商品损溢保存程序
        /// <summary>
        /// 商品损溢保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpLossManage(OpLossManage m)
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
                    OpLossManageService.Update(m);
                }
                else
                {
                    OpLossManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品损溢搜索
        /// <summary>
        /// 商品损溢搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpLossManageList(SearchDtoBase<OpLossManage> c, OpLossManage s)
        {
            c.entity = s;
            return Json(OpLossManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品损溢删除
        /// <summary>
        /// 商品损溢删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpLossManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpLossManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品损溢

        #region 商品损溢流水帐单
        public IOpLossManageFlowService OpLossManageFlowService { get; set; }
        #region 商品损溢流水帐单编辑页面
        /// <summary>
        /// 商品损溢流水帐单编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpLossManageFlowEdit(int? id)
        {
            OpLossManageFlow m = OpLossManageFlow.Initial();
            if (id.HasValue && id > 0)
            {
                m = OpLossManageFlowService.GetById(id.Value);
            }
            return View(m);
        }
        #endregion

        #region 商品损溢流水帐单列表页面
        /// <summary>
        /// 商品损溢流水帐单列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpLossManageFlowList()
        {
            return View();
        }
        #endregion

        #region 商品损溢流水帐单保存程序
        /// <summary>
        /// 商品损溢流水帐单保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpLossManageFlow(OpLossManageFlow m)
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
                    OpLossManageFlowService.Update(m);
                }
                else
                {
                    OpLossManageFlowService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品损溢流水帐单搜索
        /// <summary>
        /// 商品损溢流水帐单搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpLossManageFlowList(SearchDtoBase<OpLossManageFlow> c, OpLossManageFlow s)
        {
            c.entity = s;
            return Json(OpLossManageFlowService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品损溢流水帐单删除
        /// <summary>
        /// 商品损溢流水帐单删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpLossManageFlowDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpLossManageFlowService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品损溢流水帐单

        #region 仓库参数维护
        public IOpPaWarehouseService OpPaWarehouseService { get; set; }
        #region 仓库参数维护编辑页面
        /// <summary>
        /// 仓库参数维护编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpPaWarehouseEdit(string id)
        {
            OpPaWarehouse m = OpPaWarehouse.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = OpPaWarehouseService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 仓库参数维护列表页面
        /// <summary>
        /// 仓库参数维护列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpPaWarehouseList()
        {
            return View();
        }
        #endregion

        #region 仓库参数维护保存程序
        /// <summary>
        /// 仓库参数维护保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpPaWarehouse(OpPaWarehouse m)
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
                    OpPaWarehouseService.Update(m);
                }
                else
                {
                    OpPaWarehouseService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 仓库参数维护搜索
        /// <summary>
        /// 仓库参数维护搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpPaWarehouseList(SearchDtoBase<OpPaWarehouse> c, OpPaWarehouse s)
        {
            c.entity = s;
            return Json(OpPaWarehouseService.Search(c), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetOpPaWarehouseList()
        {
            var searchDtoBase = OpPaWarehouseService.Search(new SearchDtoBase<OpPaWarehouse>() { pageSize = int.MaxValue });

            IList<OpPaWarehouse> opPaWarehouseList = searchDtoBase.data;

            return Json(opPaWarehouseList.Select(entity => new { id = entity.WhCode, text = entity }), JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region 仓库参数维护删除
        /// <summary>
        /// 仓库参数维护删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpPaWarehouseDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpPaWarehouseService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  仓库参数维护

        #region 组合拆零管理商品明细
        public IOpSplitComDetailService OpSplitComDetailService { get; set; }
        #region 组合拆零管理商品明细编辑页面
        /// <summary>
        /// 组合拆零管理商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpSplitComDetailEdit(string id)
        {
            OpSplitComDetail m = OpSplitComDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = OpSplitComDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 组合拆零管理商品明细列表页面
        /// <summary>
        /// 组合拆零管理商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpSplitComDetailList()
        {
            return View();
        }
        #endregion

        #region 组合拆零管理商品明细保存程序
        /// <summary>
        /// 组合拆零管理商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpSplitComDetail(OpSplitComDetail m)
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
                    OpSplitComDetailService.Update(m);
                }
                else
                {
                    OpSplitComDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 组合拆零管理商品明细搜索
        /// <summary>
        /// 组合拆零管理商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpSplitComDetailList(SearchDtoBase<OpSplitComDetail> c, OpSplitComDetail s)
        {
            c.entity = s;
            return Json(OpSplitComDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 组合拆零管理商品明细删除
        /// <summary>
        /// 组合拆零管理商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpSplitComDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpSplitComDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  组合拆零管理商品明细

        #region 组合拆零商品
        public IOpSplitComGoodsService OpSplitComGoodsService { get; set; }
        #region 组合拆零商品编辑页面
        /// <summary>
        /// 组合拆零商品编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpSplitComGoodsEdit(string id)
        {
            OpSplitComGoods m = OpSplitComGoods.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = OpSplitComGoodsService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 组合拆零商品列表页面
        /// <summary>
        /// 组合拆零商品列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpSplitComGoodsList()
        {
            return View();
        }
        #endregion

        #region 组合拆零商品保存程序
        /// <summary>
        /// 组合拆零商品保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpSplitComGoods(OpSplitComGoods m)
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
                    OpSplitComGoodsService.Update(m);
                }
                else
                {
                    OpSplitComGoodsService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 组合拆零商品搜索
        /// <summary>
        /// 组合拆零商品搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpSplitComGoodsList(SearchDtoBase<OpSplitComGoods> c, OpSplitComGoods s)
        {
            c.entity = s;
            return Json(OpSplitComGoodsService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 组合拆零商品删除
        /// <summary>
        /// 组合拆零商品删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpSplitComGoodsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpSplitComGoodsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  组合拆零商品

        #region 组合拆零管理
        public IOpSplitComManageService OpSplitComManageService { get; set; }
        #region 组合拆零管理编辑页面
        /// <summary>
        /// 组合拆零管理编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpSplitComManageEdit(string id)
        {
            OpSplitComManage m = OpSplitComManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = OpSplitComManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 组合拆零管理列表页面
        /// <summary>
        /// 组合拆零管理列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpSplitComManageList()
        {
            return View();
        }
        #endregion

        #region 组合拆零管理保存程序
        /// <summary>
        /// 组合拆零管理保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpSplitComManage(OpSplitComManage m)
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
                    OpSplitComManageService.Update(m);
                }
                else
                {
                    OpSplitComManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 组合拆零管理搜索
        /// <summary>
        /// 组合拆零管理搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpSplitComManageList(SearchDtoBase<OpSplitComManage> c, OpSplitComManage s)
        {
            c.entity = s;
            return Json(OpSplitComManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 组合拆零管理删除
        /// <summary>
        /// 组合拆零管理删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpSplitComManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpSplitComManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  组合拆零管理

        #region 组合拆零管理流水单
        public IOpSplitComManageFlowService OpSplitComManageFlowService { get; set; }
        #region 组合拆零管理流水单编辑页面
        /// <summary>
        /// 组合拆零管理流水单编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult OpSplitComManageFlowEdit(int? id)
        {
            OpSplitComManageFlow m = OpSplitComManageFlow.Initial();
            if (id.HasValue && id > 0)
            {
                m = OpSplitComManageFlowService.GetById(id.Value);
            }
            return View(m);
        }
        #endregion

        #region 组合拆零管理流水单列表页面
        /// <summary>
        /// 组合拆零管理流水单列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OpSplitComManageFlowList()
        {
            return View();
        }
        #endregion

        #region 组合拆零管理流水单保存程序
        /// <summary>
        /// 组合拆零管理流水单保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveOpSplitComManageFlow(OpSplitComManageFlow m)
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
                    OpSplitComManageFlowService.Update(m);
                }
                else
                {
                    OpSplitComManageFlowService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 组合拆零管理流水单搜索
        /// <summary>
        /// 组合拆零管理流水单搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchOpSplitComManageFlowList(SearchDtoBase<OpSplitComManageFlow> c, OpSplitComManageFlow s)
        {
            c.entity = s;
            return Json(OpSplitComManageFlowService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 组合拆零管理流水单删除
        /// <summary>
        /// 组合拆零管理流水单删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult OpSplitComManageFlowDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            OpSplitComManageFlowService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  组合拆零管理流水单
    }
}





