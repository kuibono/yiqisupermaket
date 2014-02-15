
using NSH.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiQiWorkFlow.Application.Service.Rt;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Web.Client.Controllers
{
    public class RtController : Controller
    {

        #region 类别促销
        public IRtClassPromotionService RtClassPromotionService { get; set; }
        #region 类别促销编辑页面
        /// <summary>
        /// 类别促销编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtClassPromotionEdit(string id)
        {
            RtClassPromotion m = RtClassPromotion.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = RtClassPromotionService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 类别促销列表页面
        /// <summary>
        /// 类别促销列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtClassPromotionList()
        {
            return View();
        }
        #endregion

        #region 类别促销保存程序
        /// <summary>
        /// 类别促销保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtClassPromotion(RtClassPromotion m)
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
                    RtClassPromotionService.Update(m);
                }
                else
                {
                    RtClassPromotionService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 类别促销搜索
        /// <summary>
        /// 类别促销搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtClassPromotionList(SearchDtoBase<RtClassPromotion> c, RtClassPromotion s)
        {
            c.entity = s;
            return Json(RtClassPromotionService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 类别促销删除
        /// <summary>
        /// 类别促销删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtClassPromotionDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtClassPromotionService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  类别促销

        #region 类别促销分店
        public IRtClassPromotionBranchService RtClassPromotionBranchService { get; set; }
        #region 类别促销分店编辑页面
        /// <summary>
        /// 类别促销分店编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtClassPromotionBranchEdit(string id)
        {
            RtClassPromotionBranch m = RtClassPromotionBranch.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = RtClassPromotionBranchService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 类别促销分店列表页面
        /// <summary>
        /// 类别促销分店列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtClassPromotionBranchList()
        {
            return View();
        }
        #endregion

        #region 类别促销分店保存程序
        /// <summary>
        /// 类别促销分店保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtClassPromotionBranch(RtClassPromotionBranch m)
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
                    RtClassPromotionBranchService.Update(m);
                }
                else
                {
                    RtClassPromotionBranchService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 类别促销分店搜索
        /// <summary>
        /// 类别促销分店搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtClassPromotionBranchList(SearchDtoBase<RtClassPromotionBranch> c, RtClassPromotionBranch s)
        {
            c.entity = s;
            return Json(RtClassPromotionBranchService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 类别促销分店删除
        /// <summary>
        /// 类别促销分店删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtClassPromotionBranchDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtClassPromotionBranchService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  类别促销分店

        #region 类别促销商品明细
        public IRtClassPromotionGoodsService RtClassPromotionGoodsService { get; set; }
        #region 类别促销商品明细编辑页面
        /// <summary>
        /// 类别促销商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtClassPromotionGoodsEdit(string id)
        {
            RtClassPromotionGoods m = RtClassPromotionGoods.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = RtClassPromotionGoodsService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 类别促销商品明细列表页面
        /// <summary>
        /// 类别促销商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtClassPromotionGoodsList()
        {
            return View();
        }
        #endregion

        #region 类别促销商品明细保存程序
        /// <summary>
        /// 类别促销商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtClassPromotionGoods(RtClassPromotionGoods m)
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
                    RtClassPromotionGoodsService.Update(m);
                }
                else
                {
                    RtClassPromotionGoodsService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 类别促销商品明细搜索
        /// <summary>
        /// 类别促销商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtClassPromotionGoodsList(SearchDtoBase<RtClassPromotionGoods> c, RtClassPromotionGoods s)
        {
            c.entity = s;
            return Json(RtClassPromotionGoodsService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 类别促销商品明细删除
        /// <summary>
        /// 类别促销商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtClassPromotionGoodsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtClassPromotionGoodsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  类别促销商品明细

        #region 收银功能表
        public IRtPaFunctionService RtPaFunctionService { get; set; }
        #region 收银功能表编辑页面
        /// <summary>
        /// 收银功能表编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtPaFunctionEdit(string id)
        {
            RtPaFunction m = RtPaFunction.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = RtPaFunctionService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 收银功能表列表页面
        /// <summary>
        /// 收银功能表列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtPaFunctionList()
        {
            return View();
        }
        #endregion

        #region 收银功能表保存程序
        /// <summary>
        /// 收银功能表保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtPaFunction(RtPaFunction m)
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
                    RtPaFunctionService.Update(m);
                }
                else
                {
                    RtPaFunctionService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 收银功能表搜索
        /// <summary>
        /// 收银功能表搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtPaFunctionList(SearchDtoBase<RtPaFunction> c, RtPaFunction s)
        {
            c.entity = s;
            return Json(RtPaFunctionService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 收银功能表删除
        /// <summary>
        /// 收银功能表删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtPaFunctionDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtPaFunctionService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  收银功能表

        #region 付款方式
        public IRtPaPaywayService RtPaPaywayService { get; set; }
        #region 付款方式编辑页面
        /// <summary>
        /// 付款方式编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtPaPaywayEdit(string id)
        {
            RtPaPayway m = RtPaPayway.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = RtPaPaywayService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 付款方式列表页面
        /// <summary>
        /// 付款方式列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtPaPaywayList()
        {
            return View();
        }
        #endregion

        #region 付款方式保存程序
        /// <summary>
        /// 付款方式保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtPaPayway(RtPaPayway m)
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
                    RtPaPaywayService.Update(m);
                }
                else
                {
                    RtPaPaywayService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 付款方式搜索
        /// <summary>
        /// 付款方式搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtPaPaywayList(SearchDtoBase<RtPaPayway> c, RtPaPayway s)
        {
            c.entity = s;
            return Json(RtPaPaywayService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 付款方式删除
        /// <summary>
        /// 付款方式删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtPaPaywayDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtPaPaywayService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  付款方式

        #region POS机设置
        public IRtPaPosService RtPaPosService { get; set; }
        #region POS机设置编辑页面
        /// <summary>
        /// POS机设置编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtPaPosEdit(string id)
        {
            RtPaPos m = RtPaPos.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = RtPaPosService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region POS机设置列表页面
        /// <summary>
        /// POS机设置列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtPaPosList()
        {
            return View();
        }
        #endregion

        #region POS机设置保存程序
        /// <summary>
        /// POS机设置保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtPaPos(RtPaPos m)
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
                    RtPaPosService.Update(m);
                }
                else
                {
                    RtPaPosService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region POS机设置搜索
        /// <summary>
        /// POS机设置搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtPaPosList(SearchDtoBase<RtPaPos> c, RtPaPos s)
        {
            c.entity = s;
            return Json(RtPaPosService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region POS机设置删除
        /// <summary>
        /// POS机设置删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtPaPosDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtPaPosService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  POS机设置

        #region 销售设置
        public IRtPaSalesetService RtPaSalesetService { get; set; }
        #region 销售设置编辑页面
        /// <summary>
        /// 销售设置编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtPaSalesetEdit(string id)
        {
            RtPaSaleset m = RtPaSaleset.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = RtPaSalesetService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 销售设置列表页面
        /// <summary>
        /// 销售设置列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtPaSalesetList()
        {
            return View();
        }
        #endregion

        #region 销售设置保存程序
        /// <summary>
        /// 销售设置保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtPaSaleset(RtPaSaleset m)
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
                    RtPaSalesetService.Update(m);
                }
                else
                {
                    RtPaSalesetService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 销售设置搜索
        /// <summary>
        /// 销售设置搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtPaSalesetList(SearchDtoBase<RtPaSaleset> c, RtPaSaleset s)
        {
            c.entity = s;
            return Json(RtPaSalesetService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 销售设置删除
        /// <summary>
        /// 销售设置删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtPaSalesetDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtPaSalesetService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  销售设置

        #region 销售班次
        public IRtPaShiftService RtPaShiftService { get; set; }
        #region 销售班次编辑页面
        /// <summary>
        /// 销售班次编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtPaShiftEdit(string id)
        {
            RtPaShift m = RtPaShift.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = RtPaShiftService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 销售班次列表页面
        /// <summary>
        /// 销售班次列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtPaShiftList()
        {
            return View();
        }
        #endregion

        #region 销售班次保存程序
        /// <summary>
        /// 销售班次保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtPaShift(RtPaShift m)
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
                    RtPaShiftService.Update(m);
                }
                else
                {
                    RtPaShiftService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 销售班次搜索
        /// <summary>
        /// 销售班次搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtPaShiftList(SearchDtoBase<RtPaShift> c, RtPaShift s)
        {
            c.entity = s;
            return Json(RtPaShiftService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 销售班次删除
        /// <summary>
        /// 销售班次删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtPaShiftDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtPaShiftService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  销售班次

        #region 单品促销
        public IRtPluPromotionService RtPluPromotionService { get; set; }
        #region 单品促销编辑页面
        /// <summary>
        /// 单品促销编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtPluPromotionEdit(string id)
        {
            RtPluPromotion m = RtPluPromotion.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = RtPluPromotionService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 单品促销列表页面
        /// <summary>
        /// 单品促销列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtPluPromotionList()
        {
            return View();
        }
        #endregion

        #region 单品促销保存程序
        /// <summary>
        /// 单品促销保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtPluPromotion(RtPluPromotion m)
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
                    RtPluPromotionService.Update(m);
                }
                else
                {
                    RtPluPromotionService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 单品促销搜索
        /// <summary>
        /// 单品促销搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtPluPromotionList(SearchDtoBase<RtPluPromotion> c, RtPluPromotion s)
        {
            c.entity = s;
            return Json(RtPluPromotionService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 单品促销删除
        /// <summary>
        /// 单品促销删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtPluPromotionDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtPluPromotionService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  单品促销

        #region 单品促销分店
        public IRtPluPromotionBranchService RtPluPromotionBranchService { get; set; }
        #region 单品促销分店编辑页面
        /// <summary>
        /// 单品促销分店编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtPluPromotionBranchEdit(string id)
        {
            RtPluPromotionBranch m = RtPluPromotionBranch.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = RtPluPromotionBranchService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 单品促销分店列表页面
        /// <summary>
        /// 单品促销分店列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtPluPromotionBranchList()
        {
            return View();
        }
        #endregion

        #region 单品促销分店保存程序
        /// <summary>
        /// 单品促销分店保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtPluPromotionBranch(RtPluPromotionBranch m)
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
                    RtPluPromotionBranchService.Update(m);
                }
                else
                {
                    RtPluPromotionBranchService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 单品促销分店搜索
        /// <summary>
        /// 单品促销分店搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtPluPromotionBranchList(SearchDtoBase<RtPluPromotionBranch> c, RtPluPromotionBranch s)
        {
            c.entity = s;
            return Json(RtPluPromotionBranchService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 单品促销分店删除
        /// <summary>
        /// 单品促销分店删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtPluPromotionBranchDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtPluPromotionBranchService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  单品促销分店

        #region 单品促销商品明细
        public IRtPluPromotionGoodsService RtPluPromotionGoodsService { get; set; }
        #region 单品促销商品明细编辑页面
        /// <summary>
        /// 单品促销商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtPluPromotionGoodsEdit(string id)
        {
            RtPluPromotionGoods m = RtPluPromotionGoods.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = RtPluPromotionGoodsService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 单品促销商品明细列表页面
        /// <summary>
        /// 单品促销商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtPluPromotionGoodsList()
        {
            return View();
        }
        #endregion

        #region 单品促销商品明细保存程序
        /// <summary>
        /// 单品促销商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtPluPromotionGoods(RtPluPromotionGoods m)
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
                    RtPluPromotionGoodsService.Update(m);
                }
                else
                {
                    RtPluPromotionGoodsService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 单品促销商品明细搜索
        /// <summary>
        /// 单品促销商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtPluPromotionGoodsList(SearchDtoBase<RtPluPromotionGoods> c, RtPluPromotionGoods s)
        {
            c.entity = s;
            return Json(RtPluPromotionGoodsService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 单品促销商品明细删除
        /// <summary>
        /// 单品促销商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtPluPromotionGoodsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtPluPromotionGoodsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  单品促销商品明细

        #region 馈赠促销
        public IRtPresentPromotionService RtPresentPromotionService { get; set; }
        #region 馈赠促销编辑页面
        /// <summary>
        /// 馈赠促销编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtPresentPromotionEdit(string id)
        {
            RtPresentPromotion m = RtPresentPromotion.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = RtPresentPromotionService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 馈赠促销列表页面
        /// <summary>
        /// 馈赠促销列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtPresentPromotionList()
        {
            return View();
        }
        #endregion

        #region 馈赠促销保存程序
        /// <summary>
        /// 馈赠促销保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtPresentPromotion(RtPresentPromotion m)
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
                    RtPresentPromotionService.Update(m);
                }
                else
                {
                    RtPresentPromotionService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 馈赠促销搜索
        /// <summary>
        /// 馈赠促销搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtPresentPromotionList(SearchDtoBase<RtPresentPromotion> c, RtPresentPromotion s)
        {
            c.entity = s;
            return Json(RtPresentPromotionService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 馈赠促销删除
        /// <summary>
        /// 馈赠促销删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtPresentPromotionDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtPresentPromotionService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  馈赠促销

        #region 馈赠促销分店
        public IRtPresentPromotionBranchService RtPresentPromotionBranchService { get; set; }
        #region 馈赠促销分店编辑页面
        /// <summary>
        /// 馈赠促销分店编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtPresentPromotionBranchEdit(string id)
        {
            RtPresentPromotionBranch m = RtPresentPromotionBranch.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = RtPresentPromotionBranchService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 馈赠促销分店列表页面
        /// <summary>
        /// 馈赠促销分店列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtPresentPromotionBranchList()
        {
            return View();
        }
        #endregion

        #region 馈赠促销分店保存程序
        /// <summary>
        /// 馈赠促销分店保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtPresentPromotionBranch(RtPresentPromotionBranch m)
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
                    RtPresentPromotionBranchService.Update(m);
                }
                else
                {
                    RtPresentPromotionBranchService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 馈赠促销分店搜索
        /// <summary>
        /// 馈赠促销分店搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtPresentPromotionBranchList(SearchDtoBase<RtPresentPromotionBranch> c, RtPresentPromotionBranch s)
        {
            c.entity = s;
            return Json(RtPresentPromotionBranchService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 馈赠促销分店删除
        /// <summary>
        /// 馈赠促销分店删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtPresentPromotionBranchDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtPresentPromotionBranchService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  馈赠促销分店

        #region 馈赠促销商品明细
        public IRtPresentPromotionGoodsService RtPresentPromotionGoodsService { get; set; }
        #region 馈赠促销商品明细编辑页面
        /// <summary>
        /// 馈赠促销商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtPresentPromotionGoodsEdit(string id)
        {
            RtPresentPromotionGoods m = RtPresentPromotionGoods.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = RtPresentPromotionGoodsService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 馈赠促销商品明细列表页面
        /// <summary>
        /// 馈赠促销商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtPresentPromotionGoodsList()
        {
            return View();
        }
        #endregion

        #region 馈赠促销商品明细保存程序
        /// <summary>
        /// 馈赠促销商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtPresentPromotionGoods(RtPresentPromotionGoods m)
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
                    RtPresentPromotionGoodsService.Update(m);
                }
                else
                {
                    RtPresentPromotionGoodsService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 馈赠促销商品明细搜索
        /// <summary>
        /// 馈赠促销商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtPresentPromotionGoodsList(SearchDtoBase<RtPresentPromotionGoods> c, RtPresentPromotionGoods s)
        {
            c.entity = s;
            return Json(RtPresentPromotionGoodsService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 馈赠促销商品明细删除
        /// <summary>
        /// 馈赠促销商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtPresentPromotionGoodsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtPresentPromotionGoodsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  馈赠促销商品明细

        #region 销售表商品明细
        public IRtRetailDetailService RtRetailDetailService { get; set; }
        #region 销售表商品明细编辑页面
        /// <summary>
        /// 销售表商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtRetailDetailEdit(int id)
        {
            RtRetailDetail m = RtRetailDetail.Initial();
            if (id > 0)
            {
                m = RtRetailDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 销售表商品明细列表页面
        /// <summary>
        /// 销售表商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtRetailDetailList()
        {
            return View();
        }
        #endregion

        #region 销售表商品明细保存程序
        /// <summary>
        /// 销售表商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtRetailDetail(RtRetailDetail m)
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
                    RtRetailDetailService.Update(m);
                }
                else
                {
                    RtRetailDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 销售表商品明细搜索
        /// <summary>
        /// 销售表商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtRetailDetailList(SearchDtoBase<RtRetailDetail> c, RtRetailDetail s)
        {
            c.entity = s;
            return Json(RtRetailDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 销售表商品明细删除
        /// <summary>
        /// 销售表商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtRetailDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtRetailDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  销售表商品明细

        #region 收银日志
        public IRtRetailLogService RtRetailLogService { get; set; }
        #region 收银日志编辑页面
        /// <summary>
        /// 收银日志编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtRetailLogEdit(int id)
        {
            RtRetailLog m = RtRetailLog.Initial();
            if (id > 0)
            {
                m = RtRetailLogService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 收银日志列表页面
        /// <summary>
        /// 收银日志列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtRetailLogList()
        {
            return View();
        }
        #endregion

        #region 收银日志保存程序
        /// <summary>
        /// 收银日志保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtRetailLog(RtRetailLog m)
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
                    RtRetailLogService.Update(m);
                }
                else
                {
                    RtRetailLogService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 收银日志搜索
        /// <summary>
        /// 收银日志搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtRetailLogList(SearchDtoBase<RtRetailLog> c, RtRetailLog s)
        {
            c.entity = s;
            return Json(RtRetailLogService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 收银日志删除
        /// <summary>
        /// 收银日志删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtRetailLogDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtRetailLogService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  收银日志

        #region 销售主表
        public IRtRetailManageService RtRetailManageService { get; set; }
        #region 销售主表编辑页面
        /// <summary>
        /// 销售主表编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtRetailManageEdit(int id)
        {
            RtRetailManage m = RtRetailManage.Initial();
            if (id > 0)
            {
                m = RtRetailManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 销售主表列表页面
        /// <summary>
        /// 销售主表列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtRetailManageList()
        {
            return View();
        }
        #endregion

        #region 销售主表保存程序
        /// <summary>
        /// 销售主表保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtRetailManage(RtRetailManage m)
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
                    RtRetailManageService.Update(m);
                }
                else
                {
                    RtRetailManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 销售主表搜索
        /// <summary>
        /// 销售主表搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtRetailManageList(SearchDtoBase<RtRetailManage> c, RtRetailManage s)
        {
            c.entity = s;
            return Json(RtRetailManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 销售主表删除
        /// <summary>
        /// 销售主表删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtRetailManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtRetailManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  销售主表

        #region 销售表付款表
        public IRtRetailPayService RtRetailPayService { get; set; }
        #region 销售表付款表编辑页面
        /// <summary>
        /// 销售表付款表编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtRetailPayEdit(int id)
        {
            RtRetailPay m = RtRetailPay.Initial();
            if (id > 0)
            {
                m = RtRetailPayService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 销售表付款表列表页面
        /// <summary>
        /// 销售表付款表列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtRetailPayList()
        {
            return View();
        }
        #endregion

        #region 销售表付款表保存程序
        /// <summary>
        /// 销售表付款表保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtRetailPay(RtRetailPay m)
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
                    RtRetailPayService.Update(m);
                }
                else
                {
                    RtRetailPayService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 销售表付款表搜索
        /// <summary>
        /// 销售表付款表搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtRetailPayList(SearchDtoBase<RtRetailPay> c, RtRetailPay s)
        {
            c.entity = s;
            return Json(RtRetailPayService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 销售表付款表删除
        /// <summary>
        /// 销售表付款表删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtRetailPayDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtRetailPayService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  销售表付款表

        #region 整单促销
        public IRtSheetPromotionService RtSheetPromotionService { get; set; }
        #region 整单促销编辑页面
        /// <summary>
        /// 整单促销编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtSheetPromotionEdit(string id)
        {
            RtSheetPromotion m = RtSheetPromotion.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = RtSheetPromotionService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 整单促销列表页面
        /// <summary>
        /// 整单促销列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtSheetPromotionList()
        {
            return View();
        }
        #endregion

        #region 整单促销保存程序
        /// <summary>
        /// 整单促销保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtSheetPromotion(RtSheetPromotion m)
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
                    RtSheetPromotionService.Update(m);
                }
                else
                {
                    RtSheetPromotionService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 整单促销搜索
        /// <summary>
        /// 整单促销搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtSheetPromotionList(SearchDtoBase<RtSheetPromotion> c, RtSheetPromotion s)
        {
            c.entity = s;
            return Json(RtSheetPromotionService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 整单促销删除
        /// <summary>
        /// 整单促销删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtSheetPromotionDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtSheetPromotionService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  整单促销

        #region 整单促销分店
        public IRtSheetPromotionBranchService RtSheetPromotionBranchService { get; set; }
        #region 整单促销分店编辑页面
        /// <summary>
        /// 整单促销分店编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtSheetPromotionBranchEdit(string id)
        {
            RtSheetPromotionBranch m = RtSheetPromotionBranch.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = RtSheetPromotionBranchService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 整单促销分店列表页面
        /// <summary>
        /// 整单促销分店列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtSheetPromotionBranchList()
        {
            return View();
        }
        #endregion

        #region 整单促销分店保存程序
        /// <summary>
        /// 整单促销分店保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtSheetPromotionBranch(RtSheetPromotionBranch m)
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
                    RtSheetPromotionBranchService.Update(m);
                }
                else
                {
                    RtSheetPromotionBranchService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 整单促销分店搜索
        /// <summary>
        /// 整单促销分店搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtSheetPromotionBranchList(SearchDtoBase<RtSheetPromotionBranch> c, RtSheetPromotionBranch s)
        {
            c.entity = s;
            return Json(RtSheetPromotionBranchService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 整单促销分店删除
        /// <summary>
        /// 整单促销分店删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtSheetPromotionBranchDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtSheetPromotionBranchService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  整单促销分店

        #region 整单促销商品明细
        public IRtSheetPromotionGoodsService RtSheetPromotionGoodsService { get; set; }
        #region 整单促销商品明细编辑页面
        /// <summary>
        /// 整单促销商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult RtSheetPromotionGoodsEdit(string id)
        {
            RtSheetPromotionGoods m = RtSheetPromotionGoods.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = RtSheetPromotionGoodsService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 整单促销商品明细列表页面
        /// <summary>
        /// 整单促销商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RtSheetPromotionGoodsList()
        {
            return View();
        }
        #endregion

        #region 整单促销商品明细保存程序
        /// <summary>
        /// 整单促销商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveRtSheetPromotionGoods(RtSheetPromotionGoods m)
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
                    RtSheetPromotionGoodsService.Update(m);
                }
                else
                {
                    RtSheetPromotionGoodsService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 整单促销商品明细搜索
        /// <summary>
        /// 整单促销商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchRtSheetPromotionGoodsList(SearchDtoBase<RtSheetPromotionGoods> c, RtSheetPromotionGoods s)
        {
            c.entity = s;
            return Json(RtSheetPromotionGoodsService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 整单促销商品明细删除
        /// <summary>
        /// 整单促销商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult RtSheetPromotionGoodsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            RtSheetPromotionGoodsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  整单促销商品明细
    }
}





