﻿
using NSH.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiQiWorkFlow.Application.Service.Ms;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Web.Client.Controllers
{
    public class MsController : Controller
    {

        #region 积分调整管理
        public IMsAdjustPointsService MsAdjustPointsService { get; set; }
        #region 积分调整管理编辑页面
        /// <summary>
        /// 积分调整管理编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsAdjustPointsEdit(int? id)
        {
            MsAdjustPoints m = MsAdjustPoints.Initial();
            if (id.HasValue && id > 0)
            {
                m = MsAdjustPointsService.GetById(id.Value);
            }
            return View(m);
        }
        #endregion

        #region 积分调整管理列表页面
        /// <summary>
        /// 积分调整管理列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsAdjustPointsList()
        {
            return View();
        }
        #endregion

        #region 积分调整管理保存程序
        /// <summary>
        /// 积分调整管理保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsAdjustPoints(MsAdjustPoints m)
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
                    MsAdjustPointsService.Update(m);
                }
                else
                {
                    MsAdjustPointsService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 积分调整管理搜索
        /// <summary>
        /// 积分调整管理搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsAdjustPointsList(SearchDtoBase<MsAdjustPoints> c, MsAdjustPoints s)
        {
            c.entity = s;
            return Json(MsAdjustPointsService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 积分调整管理删除
        /// <summary>
        /// 积分调整管理删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsAdjustPointsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsAdjustPointsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  积分调整管理

        #region 卡作废
        public IMsCancelCardManageService MsCancelCardManageService { get; set; }
        #region 卡作废编辑页面
        /// <summary>
        /// 卡作废编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsCancelCardManageEdit(string id)
        {
            MsCancelCardManage m = MsCancelCardManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsCancelCardManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 卡作废列表页面
        /// <summary>
        /// 卡作废列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsCancelCardManageList()
        {
            return View();
        }
        #endregion

        #region 卡作废保存程序
        /// <summary>
        /// 卡作废保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsCancelCardManage(MsCancelCardManage m)
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
                    MsCancelCardManageService.Update(m);
                }
                else
                {
                    MsCancelCardManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡作废搜索
        /// <summary>
        /// 卡作废搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsCancelCardManageList(SearchDtoBase<MsCancelCardManage> c, MsCancelCardManage s)
        {
            c.entity = s;
            return Json(MsCancelCardManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡作废删除
        /// <summary>
        /// 卡作废删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsCancelCardManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsCancelCardManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡作废

        #region 卡信息
        public IMsCardArchivesService MsCardArchivesService { get; set; }
        #region 卡信息编辑页面
        /// <summary>
        /// 卡信息编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsCardArchivesEdit(string id)
        {
            MsCardArchives m = MsCardArchives.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsCardArchivesService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 卡信息列表页面
        /// <summary>
        /// 卡信息列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsCardArchivesList()
        {
            return View();
        }
        #endregion

        #region 卡信息保存程序
        /// <summary>
        /// 卡信息保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsCardArchives(MsCardArchives m)
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
                    MsCardArchivesService.Update(m);
                }
                else
                {
                    MsCardArchivesService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡信息搜索
        /// <summary>
        /// 卡信息搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsCardArchivesList(SearchDtoBase<MsCardArchives> c, MsCardArchives s)
        {
            c.entity = s;
            return Json(MsCardArchivesService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡信息删除
        /// <summary>
        /// 卡信息删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsCardArchivesDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsCardArchivesService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡信息

        #region 卡折扣
        public IMsCardtypeDiscountService MsCardtypeDiscountService { get; set; }
        #region 卡折扣编辑页面
        /// <summary>
        /// 卡折扣编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsCardtypeDiscountEdit(string id)
        {
            MsCardtypeDiscount m = MsCardtypeDiscount.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsCardtypeDiscountService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 卡折扣列表页面
        /// <summary>
        /// 卡折扣列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsCardtypeDiscountList()
        {
            return View();
        }
        #endregion

        #region 卡折扣保存程序
        /// <summary>
        /// 卡折扣保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsCardtypeDiscount(MsCardtypeDiscount m)
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
                    MsCardtypeDiscountService.Update(m);
                }
                else
                {
                    MsCardtypeDiscountService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡折扣搜索
        /// <summary>
        /// 卡折扣搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsCardtypeDiscountList(SearchDtoBase<MsCardtypeDiscount> c, MsCardtypeDiscount s)
        {
            c.entity = s;
            return Json(MsCardtypeDiscountService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡折扣删除
        /// <summary>
        /// 卡折扣删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsCardtypeDiscountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsCardtypeDiscountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡折扣

        #region 商品折扣
        public IMsCardtypeGoodsDiscountService MsCardtypeGoodsDiscountService { get; set; }
        #region 商品折扣编辑页面
        /// <summary>
        /// 商品折扣编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsCardtypeGoodsDiscountEdit(string id)
        {
            MsCardtypeGoodsDiscount m = MsCardtypeGoodsDiscount.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsCardtypeGoodsDiscountService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品折扣列表页面
        /// <summary>
        /// 商品折扣列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsCardtypeGoodsDiscountList()
        {
            return View();
        }
        #endregion

        #region 商品折扣保存程序
        /// <summary>
        /// 商品折扣保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsCardtypeGoodsDiscount(MsCardtypeGoodsDiscount m)
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
                    MsCardtypeGoodsDiscountService.Update(m);
                }
                else
                {
                    MsCardtypeGoodsDiscountService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品折扣搜索
        /// <summary>
        /// 商品折扣搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsCardtypeGoodsDiscountList(SearchDtoBase<MsCardtypeGoodsDiscount> c, MsCardtypeGoodsDiscount s)
        {
            c.entity = s;
            return Json(MsCardtypeGoodsDiscountService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品折扣删除
        /// <summary>
        /// 商品折扣删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsCardtypeGoodsDiscountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsCardtypeGoodsDiscountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品折扣

        #region 商品积分
        public IMsCardtypeGoodsPointsService MsCardtypeGoodsPointsService { get; set; }
        #region 商品积分编辑页面
        /// <summary>
        /// 商品积分编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsCardtypeGoodsPointsEdit(string id)
        {
            MsCardtypeGoodsPoints m = MsCardtypeGoodsPoints.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsCardtypeGoodsPointsService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品积分列表页面
        /// <summary>
        /// 商品积分列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsCardtypeGoodsPointsList()
        {
            return View();
        }
        #endregion

        #region 商品积分保存程序
        /// <summary>
        /// 商品积分保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsCardtypeGoodsPoints(MsCardtypeGoodsPoints m)
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
                    MsCardtypeGoodsPointsService.Update(m);
                }
                else
                {
                    MsCardtypeGoodsPointsService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品积分搜索
        /// <summary>
        /// 商品积分搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsCardtypeGoodsPointsList(SearchDtoBase<MsCardtypeGoodsPoints> c, MsCardtypeGoodsPoints s)
        {
            c.entity = s;
            return Json(MsCardtypeGoodsPointsService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品积分删除
        /// <summary>
        /// 商品积分删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsCardtypeGoodsPointsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsCardtypeGoodsPointsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品积分

        #region 卡类型
        public IMsCardtypeManageService MsCardtypeManageService { get; set; }
        #region 卡类型编辑页面
        /// <summary>
        /// 卡类型编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsCardtypeManageEdit(string id)
        {
            MsCardtypeManage m = MsCardtypeManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsCardtypeManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 卡类型列表页面
        /// <summary>
        /// 卡类型列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsCardtypeManageList()
        {
            return View();
        }
        #endregion

        #region 卡类型保存程序
        /// <summary>
        /// 卡类型保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsCardtypeManage(MsCardtypeManage m)
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
                    MsCardtypeManageService.Update(m);
                }
                else
                {
                    MsCardtypeManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡类型搜索
        /// <summary>
        /// 卡类型搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsCardtypeManageList(SearchDtoBase<MsCardtypeManage> c, MsCardtypeManage s)
        {
            c.entity = s;
            return Json(MsCardtypeManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡类型删除
        /// <summary>
        /// 卡类型删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsCardtypeManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsCardtypeManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡类型

        #region 卡积分
        public IMsCardtypePointsService MsCardtypePointsService { get; set; }
        #region 卡积分编辑页面
        /// <summary>
        /// 卡积分编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsCardtypePointsEdit(string id)
        {
            MsCardtypePoints m = MsCardtypePoints.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsCardtypePointsService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 卡积分列表页面
        /// <summary>
        /// 卡积分列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsCardtypePointsList()
        {
            return View();
        }
        #endregion

        #region 卡积分保存程序
        /// <summary>
        /// 卡积分保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsCardtypePoints(MsCardtypePoints m)
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
                    MsCardtypePointsService.Update(m);
                }
                else
                {
                    MsCardtypePointsService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡积分搜索
        /// <summary>
        /// 卡积分搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsCardtypePointsList(SearchDtoBase<MsCardtypePoints> c, MsCardtypePoints s)
        {
            c.entity = s;
            return Json(MsCardtypePointsService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡积分删除
        /// <summary>
        /// 卡积分删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsCardtypePointsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsCardtypePointsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡积分

        #region 赠品兑换明细
        public IMsExchangeDetailService MsExchangeDetailService { get; set; }
        #region 赠品兑换明细编辑页面
        /// <summary>
        /// 赠品兑换明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsExchangeDetailEdit(string id)
        {
            MsExchangeDetail m = MsExchangeDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsExchangeDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 赠品兑换明细列表页面
        /// <summary>
        /// 赠品兑换明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsExchangeDetailList()
        {
            return View();
        }
        #endregion

        #region 赠品兑换明细保存程序
        /// <summary>
        /// 赠品兑换明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsExchangeDetail(MsExchangeDetail m)
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
                    MsExchangeDetailService.Update(m);
                }
                else
                {
                    MsExchangeDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 赠品兑换明细搜索
        /// <summary>
        /// 赠品兑换明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsExchangeDetailList(SearchDtoBase<MsExchangeDetail> c, MsExchangeDetail s)
        {
            c.entity = s;
            return Json(MsExchangeDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 赠品兑换明细删除
        /// <summary>
        /// 赠品兑换明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsExchangeDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsExchangeDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  赠品兑换明细

        #region 赠品兑换管理
        public IMsExchangeManageService MsExchangeManageService { get; set; }
        #region 赠品兑换管理编辑页面
        /// <summary>
        /// 赠品兑换管理编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsExchangeManageEdit(int? id)
        {
            MsExchangeManage m = MsExchangeManage.Initial();
            if (id.HasValue && id > 0)
            {
                m = MsExchangeManageService.GetById(id.Value);
            }
            return View(m);
        }
        #endregion

        #region 赠品兑换管理列表页面
        /// <summary>
        /// 赠品兑换管理列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsExchangeManageList()
        {
            return View();
        }
        #endregion

        #region 赠品兑换管理保存程序
        /// <summary>
        /// 赠品兑换管理保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsExchangeManage(MsExchangeManage m)
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
                    MsExchangeManageService.Update(m);
                }
                else
                {
                    MsExchangeManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 赠品兑换管理搜索
        /// <summary>
        /// 赠品兑换管理搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsExchangeManageList(SearchDtoBase<MsExchangeManage> c, MsExchangeManage s)
        {
            c.entity = s;
            return Json(MsExchangeManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 赠品兑换管理删除
        /// <summary>
        /// 赠品兑换管理删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsExchangeManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsExchangeManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  赠品兑换管理

        #region 卡冻结
        public IMsFreezeCardManageService MsFreezeCardManageService { get; set; }
        #region 卡冻结编辑页面
        /// <summary>
        /// 卡冻结编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsFreezeCardManageEdit(string id)
        {
            MsFreezeCardManage m = MsFreezeCardManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsFreezeCardManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 卡冻结列表页面
        /// <summary>
        /// 卡冻结列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsFreezeCardManageList()
        {
            return View();
        }
        #endregion

        #region 卡冻结保存程序
        /// <summary>
        /// 卡冻结保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsFreezeCardManage(MsFreezeCardManage m)
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
                    MsFreezeCardManageService.Update(m);
                }
                else
                {
                    MsFreezeCardManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡冻结搜索
        /// <summary>
        /// 卡冻结搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsFreezeCardManageList(SearchDtoBase<MsFreezeCardManage> c, MsFreezeCardManage s)
        {
            c.entity = s;
            return Json(MsFreezeCardManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡冻结删除
        /// <summary>
        /// 卡冻结删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsFreezeCardManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsFreezeCardManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡冻结

        #region 赠品档案管理
        public IMsGiftArchivesService MsGiftArchivesService { get; set; }
        #region 赠品档案管理编辑页面
        /// <summary>
        /// 赠品档案管理编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsGiftArchivesEdit(string id)
        {
            MsGiftArchives m = MsGiftArchives.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsGiftArchivesService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 赠品档案管理列表页面
        /// <summary>
        /// 赠品档案管理列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsGiftArchivesList()
        {
            return View();
        }
        #endregion

        #region 赠品档案管理保存程序
        /// <summary>
        /// 赠品档案管理保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsGiftArchives(MsGiftArchives m)
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
                    MsGiftArchivesService.Update(m);
                }
                else
                {
                    MsGiftArchivesService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 赠品档案管理搜索
        /// <summary>
        /// 赠品档案管理搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsGiftArchivesList(SearchDtoBase<MsGiftArchives> c, MsGiftArchives s)
        {
            c.entity = s;
            return Json(MsGiftArchivesService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 赠品档案管理删除
        /// <summary>
        /// 赠品档案管理删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsGiftArchivesDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsGiftArchivesService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  赠品档案管理

        #region 卡发放
        public IMsGrantCardManageService MsGrantCardManageService { get; set; }
        #region 卡发放编辑页面
        /// <summary>
        /// 卡发放编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsGrantCardManageEdit(string id)
        {
            MsGrantCardManage m = MsGrantCardManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsGrantCardManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 卡发放列表页面
        /// <summary>
        /// 卡发放列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsGrantCardManageList()
        {
            return View();
        }
        #endregion

        #region 卡发放保存程序
        /// <summary>
        /// 卡发放保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsGrantCardManage(MsGrantCardManage m)
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
                    MsGrantCardManageService.Update(m);
                }
                else
                {
                    MsGrantCardManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡发放搜索
        /// <summary>
        /// 卡发放搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsGrantCardManageList(SearchDtoBase<MsGrantCardManage> c, MsGrantCardManage s)
        {
            c.entity = s;
            return Json(MsGrantCardManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡发放删除
        /// <summary>
        /// 卡发放删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsGrantCardManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsGrantCardManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡发放

        #region 卡挂失
        public IMsLossCardManageService MsLossCardManageService { get; set; }
        #region 卡挂失编辑页面
        /// <summary>
        /// 卡挂失编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsLossCardManageEdit(string id)
        {
            MsLossCardManage m = MsLossCardManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsLossCardManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 卡挂失列表页面
        /// <summary>
        /// 卡挂失列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsLossCardManageList()
        {
            return View();
        }
        #endregion

        #region 卡挂失保存程序
        /// <summary>
        /// 卡挂失保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsLossCardManage(MsLossCardManage m)
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
                    MsLossCardManageService.Update(m);
                }
                else
                {
                    MsLossCardManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡挂失搜索
        /// <summary>
        /// 卡挂失搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsLossCardManageList(SearchDtoBase<MsLossCardManage> c, MsLossCardManage s)
        {
            c.entity = s;
            return Json(MsLossCardManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡挂失删除
        /// <summary>
        /// 卡挂失删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsLossCardManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsLossCardManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡挂失

        #region 卡制作
        public IMsMadecardManageService MsMadecardManageService { get; set; }
        #region 卡制作编辑页面
        /// <summary>
        /// 卡制作编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsMadecardManageEdit(string id)
        {
            MsMadecardManage m = MsMadecardManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsMadecardManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 卡制作列表页面
        /// <summary>
        /// 卡制作列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsMadecardManageList()
        {
            return View();
        }
        #endregion

        #region 卡制作保存程序
        /// <summary>
        /// 卡制作保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsMadecardManage(MsMadecardManage m)
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
                    MsMadecardManageService.Update(m);
                }
                else
                {
                    MsMadecardManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡制作搜索
        /// <summary>
        /// 卡制作搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsMadecardManageList(SearchDtoBase<MsMadecardManage> c, MsMadecardManage s)
        {
            c.entity = s;
            return Json(MsMadecardManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡制作删除
        /// <summary>
        /// 卡制作删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsMadecardManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsMadecardManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡制作

        #region 会员信息
        public IMsMemberArchivesService MsMemberArchivesService { get; set; }
        #region 会员信息编辑页面
        /// <summary>
        /// 会员信息编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsMemberArchivesEdit(string id)
        {
            MsMemberArchives m = MsMemberArchives.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsMemberArchivesService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 会员信息列表页面
        /// <summary>
        /// 会员信息列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsMemberArchivesList()
        {
            return View();
        }
        #endregion

        #region 会员信息保存程序
        /// <summary>
        /// 会员信息保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsMemberArchives(MsMemberArchives m)
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
                    MsMemberArchivesService.Update(m);
                }
                else
                {
                    MsMemberArchivesService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 会员信息搜索
        /// <summary>
        /// 会员信息搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsMemberArchivesList(SearchDtoBase<MsMemberArchives> c, MsMemberArchives s)
        {
            c.entity = s;
            return Json(MsMemberArchivesService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 会员信息删除
        /// <summary>
        /// 会员信息删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsMemberArchivesDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsMemberArchivesService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  会员信息

        #region 积分清零管理
        public IMsPointsClearService MsPointsClearService { get; set; }
        #region 积分清零管理编辑页面
        /// <summary>
        /// 积分清零管理编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsPointsClearEdit(int? id)
        {
            MsPointsClear m = MsPointsClear.Initial();
            if (id.HasValue && id > 0)
            {
                m = MsPointsClearService.GetById(id.Value);
            }
            return View(m);
        }
        #endregion

        #region 积分清零管理列表页面
        /// <summary>
        /// 积分清零管理列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsPointsClearList()
        {
            return View();
        }
        #endregion

        #region 积分清零管理保存程序
        /// <summary>
        /// 积分清零管理保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsPointsClear(MsPointsClear m)
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
                    MsPointsClearService.Update(m);
                }
                else
                {
                    MsPointsClearService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 积分清零管理搜索
        /// <summary>
        /// 积分清零管理搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsPointsClearList(SearchDtoBase<MsPointsClear> c, MsPointsClear s)
        {
            c.entity = s;
            return Json(MsPointsClearService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 积分清零管理删除
        /// <summary>
        /// 积分清零管理删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsPointsClearDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsPointsClearService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  积分清零管理

        #region 积分转储值
        public IMsPointtoprepaidManageService MsPointtoprepaidManageService { get; set; }
        #region 积分转储值编辑页面
        /// <summary>
        /// 积分转储值编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsPointtoprepaidManageEdit(int? id)
        {
            MsPointtoprepaidManage m = MsPointtoprepaidManage.Initial();
            if (id.HasValue && id > 0)
            {
                m = MsPointtoprepaidManageService.GetById(id.Value);
            }
            return View(m);
        }
        #endregion

        #region 积分转储值列表页面
        /// <summary>
        /// 积分转储值列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsPointtoprepaidManageList()
        {
            return View();
        }
        #endregion

        #region 积分转储值保存程序
        /// <summary>
        /// 积分转储值保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsPointtoprepaidManage(MsPointtoprepaidManage m)
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
                    MsPointtoprepaidManageService.Update(m);
                }
                else
                {
                    MsPointtoprepaidManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 积分转储值搜索
        /// <summary>
        /// 积分转储值搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsPointtoprepaidManageList(SearchDtoBase<MsPointtoprepaidManage> c, MsPointtoprepaidManage s)
        {
            c.entity = s;
            return Json(MsPointtoprepaidManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 积分转储值删除
        /// <summary>
        /// 积分转储值删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsPointtoprepaidManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsPointtoprepaidManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  积分转储值

        #region 卡充值
        public IMsPrepaidCardManageService MsPrepaidCardManageService { get; set; }
        #region 卡充值编辑页面
        /// <summary>
        /// 卡充值编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsPrepaidCardManageEdit(string id)
        {
            MsPrepaidCardManage m = MsPrepaidCardManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsPrepaidCardManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 卡充值列表页面
        /// <summary>
        /// 卡充值列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsPrepaidCardManageList()
        {
            return View();
        }
        #endregion

        #region 卡充值保存程序
        /// <summary>
        /// 卡充值保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsPrepaidCardManage(MsPrepaidCardManage m)
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
                    MsPrepaidCardManageService.Update(m);
                }
                else
                {
                    MsPrepaidCardManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡充值搜索
        /// <summary>
        /// 卡充值搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsPrepaidCardManageList(SearchDtoBase<MsPrepaidCardManage> c, MsPrepaidCardManage s)
        {
            c.entity = s;
            return Json(MsPrepaidCardManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡充值删除
        /// <summary>
        /// 卡充值删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsPrepaidCardManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsPrepaidCardManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡充值

        #region 卡回收
        public IMsReclaimCardManageService MsReclaimCardManageService { get; set; }
        #region 卡回收编辑页面
        /// <summary>
        /// 卡回收编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsReclaimCardManageEdit(string id)
        {
            MsReclaimCardManage m = MsReclaimCardManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsReclaimCardManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 卡回收列表页面
        /// <summary>
        /// 卡回收列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsReclaimCardManageList()
        {
            return View();
        }
        #endregion

        #region 卡回收保存程序
        /// <summary>
        /// 卡回收保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsReclaimCardManage(MsReclaimCardManage m)
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
                    MsReclaimCardManageService.Update(m);
                }
                else
                {
                    MsReclaimCardManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡回收搜索
        /// <summary>
        /// 卡回收搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsReclaimCardManageList(SearchDtoBase<MsReclaimCardManage> c, MsReclaimCardManage s)
        {
            c.entity = s;
            return Json(MsReclaimCardManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡回收删除
        /// <summary>
        /// 卡回收删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsReclaimCardManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsReclaimCardManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡回收

        #region 卡更新
        public IMsUpdateCardManageService MsUpdateCardManageService { get; set; }
        #region 卡更新编辑页面
        /// <summary>
        /// 卡更新编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsUpdateCardManageEdit(string id)
        {
            MsUpdateCardManage m = MsUpdateCardManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsUpdateCardManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 卡更新列表页面
        /// <summary>
        /// 卡更新列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsUpdateCardManageList()
        {
            return View();
        }
        #endregion

        #region 卡更新保存程序
        /// <summary>
        /// 卡更新保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsUpdateCardManage(MsUpdateCardManage m)
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
                    MsUpdateCardManageService.Update(m);
                }
                else
                {
                    MsUpdateCardManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡更新搜索
        /// <summary>
        /// 卡更新搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsUpdateCardManageList(SearchDtoBase<MsUpdateCardManage> c, MsUpdateCardManage s)
        {
            c.entity = s;
            return Json(MsUpdateCardManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡更新删除
        /// <summary>
        /// 卡更新删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsUpdateCardManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsUpdateCardManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡更新

        #region 卡升级信息
        public IMsUpgradeCardDetailService MsUpgradeCardDetailService { get; set; }
        #region 卡升级信息编辑页面
        /// <summary>
        /// 卡升级信息编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsUpgradeCardDetailEdit(string id)
        {
            MsUpgradeCardDetail m = MsUpgradeCardDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsUpgradeCardDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 卡升级信息列表页面
        /// <summary>
        /// 卡升级信息列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsUpgradeCardDetailList()
        {
            return View();
        }
        #endregion

        #region 卡升级信息保存程序
        /// <summary>
        /// 卡升级信息保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsUpgradeCardDetail(MsUpgradeCardDetail m)
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
                    MsUpgradeCardDetailService.Update(m);
                }
                else
                {
                    MsUpgradeCardDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡升级信息搜索
        /// <summary>
        /// 卡升级信息搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsUpgradeCardDetailList(SearchDtoBase<MsUpgradeCardDetail> c, MsUpgradeCardDetail s)
        {
            c.entity = s;
            return Json(MsUpgradeCardDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡升级信息删除
        /// <summary>
        /// 卡升级信息删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsUpgradeCardDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsUpgradeCardDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡升级信息

        #region 卡升级
        public IMsUpgradeCardManageService MsUpgradeCardManageService { get; set; }
        #region 卡升级编辑页面
        /// <summary>
        /// 卡升级编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsUpgradeCardManageEdit(string id)
        {
            MsUpgradeCardManage m = MsUpgradeCardManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsUpgradeCardManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 卡升级列表页面
        /// <summary>
        /// 卡升级列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsUpgradeCardManageList()
        {
            return View();
        }
        #endregion

        #region 卡升级保存程序
        /// <summary>
        /// 卡升级保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsUpgradeCardManage(MsUpgradeCardManage m)
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
                    MsUpgradeCardManageService.Update(m);
                }
                else
                {
                    MsUpgradeCardManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡升级搜索
        /// <summary>
        /// 卡升级搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsUpgradeCardManageList(SearchDtoBase<MsUpgradeCardManage> c, MsUpgradeCardManage s)
        {
            c.entity = s;
            return Json(MsUpgradeCardManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡升级删除
        /// <summary>
        /// 卡升级删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsUpgradeCardManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsUpgradeCardManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡升级
    }
}




