
using NSH.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiQiWorkFlow.Application.Service.Tg;
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace TEWorkFlow.Web.Client.Controllers
{
    public class TgController : Controller
    {

        #region 讲解员结算管理
        public ITgExpostorBalanceService TgExpostorBalanceService { get; set; }
        #region 讲解员结算管理编辑页面
        /// <summary>
        /// 讲解员结算管理编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TgExpostorBalanceEdit(string id)
        {
            TgExpostorBalance m = TgExpostorBalance.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TgExpostorBalanceService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 讲解员结算管理列表页面
        /// <summary>
        /// 讲解员结算管理列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TgExpostorBalanceList()
        {
            return View();
        }
        #endregion

        #region 讲解员结算管理保存程序
        /// <summary>
        /// 讲解员结算管理保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTgExpostorBalance(TgExpostorBalance m)
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
                    TgExpostorBalanceService.Update(m);
                }
                else
                {
                    TgExpostorBalanceService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 讲解员结算管理搜索
        /// <summary>
        /// 讲解员结算管理搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTgExpostorBalanceList(SearchDtoBase<TgExpostorBalance> c, TgExpostorBalance s)
        {
            c.entity = s;
            return Json(TgExpostorBalanceService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 讲解员结算管理删除
        /// <summary>
        /// 讲解员结算管理删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TgExpostorBalanceDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TgExpostorBalanceService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  讲解员结算管理

        #region 讲解员结算明细
        public ITgExpostorBalanceDetailService TgExpostorBalanceDetailService { get; set; }
        #region 讲解员结算明细编辑页面
        /// <summary>
        /// 讲解员结算明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TgExpostorBalanceDetailEdit(string id)
        {
            TgExpostorBalanceDetail m = TgExpostorBalanceDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TgExpostorBalanceDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 讲解员结算明细列表页面
        /// <summary>
        /// 讲解员结算明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TgExpostorBalanceDetailList()
        {
            return View();
        }
        #endregion

        #region 讲解员结算明细保存程序
        /// <summary>
        /// 讲解员结算明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTgExpostorBalanceDetail(TgExpostorBalanceDetail m)
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
                    TgExpostorBalanceDetailService.Update(m);
                }
                else
                {
                    TgExpostorBalanceDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 讲解员结算明细搜索
        /// <summary>
        /// 讲解员结算明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTgExpostorBalanceDetailList(SearchDtoBase<TgExpostorBalanceDetail> c, TgExpostorBalanceDetail s)
        {
            c.entity = s;
            return Json(TgExpostorBalanceDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 讲解员结算明细删除
        /// <summary>
        /// 讲解员结算明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TgExpostorBalanceDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TgExpostorBalanceDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  讲解员结算明细

        #region 团队结算管理
        public ITgGroupBalanceService TgGroupBalanceService { get; set; }
        #region 团队结算管理编辑页面
        /// <summary>
        /// 团队结算管理编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TgGroupBalanceEdit(string id)
        {
            TgGroupBalance m = TgGroupBalance.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TgGroupBalanceService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 团队结算管理列表页面
        /// <summary>
        /// 团队结算管理列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TgGroupBalanceList()
        {
            return View();
        }
        #endregion

        #region 团队结算管理保存程序
        /// <summary>
        /// 团队结算管理保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTgGroupBalance(TgGroupBalance m)
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
                    TgGroupBalanceService.Update(m);
                }
                else
                {
                    TgGroupBalanceService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 团队结算管理搜索
        /// <summary>
        /// 团队结算管理搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTgGroupBalanceList(SearchDtoBase<TgGroupBalance> c, TgGroupBalance s)
        {
            c.entity = s;
            return Json(TgGroupBalanceService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 团队结算管理删除
        /// <summary>
        /// 团队结算管理删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TgGroupBalanceDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TgGroupBalanceService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  团队结算管理

        #region 团队结算明细
        public ITgGroupBalanceDetailService TgGroupBalanceDetailService { get; set; }
        #region 团队结算明细编辑页面
        /// <summary>
        /// 团队结算明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TgGroupBalanceDetailEdit(string id)
        {
            TgGroupBalanceDetail m = TgGroupBalanceDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TgGroupBalanceDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 团队结算明细列表页面
        /// <summary>
        /// 团队结算明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TgGroupBalanceDetailList()
        {
            return View();
        }
        #endregion

        #region 团队结算明细保存程序
        /// <summary>
        /// 团队结算明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTgGroupBalanceDetail(TgGroupBalanceDetail m)
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
                    TgGroupBalanceDetailService.Update(m);
                }
                else
                {
                    TgGroupBalanceDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 团队结算明细搜索
        /// <summary>
        /// 团队结算明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTgGroupBalanceDetailList(SearchDtoBase<TgGroupBalanceDetail> c, TgGroupBalanceDetail s)
        {
            c.entity = s;
            return Json(TgGroupBalanceDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 团队结算明细删除
        /// <summary>
        /// 团队结算明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TgGroupBalanceDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TgGroupBalanceDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  团队结算明细

        #region 团队策略提醒
        public ITgGroupCallService TgGroupCallService { get; set; }
        #region 团队策略提醒编辑页面
        /// <summary>
        /// 团队策略提醒编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TgGroupCallEdit(string id)
        {
            TgGroupCall m = TgGroupCall.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TgGroupCallService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 团队策略提醒列表页面
        /// <summary>
        /// 团队策略提醒列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TgGroupCallList()
        {
            return View();
        }
        #endregion

        #region 团队策略提醒保存程序
        /// <summary>
        /// 团队策略提醒保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTgGroupCall(TgGroupCall m)
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
                    TgGroupCallService.Update(m);
                }
                else
                {
                    TgGroupCallService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 团队策略提醒搜索
        /// <summary>
        /// 团队策略提醒搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTgGroupCallList(SearchDtoBase<TgGroupCall> c, TgGroupCall s)
        {
            c.entity = s;
            return Json(TgGroupCallService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 团队策略提醒删除
        /// <summary>
        /// 团队策略提醒删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TgGroupCallDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TgGroupCallService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  团队策略提醒

        #region 导游人员信息
        public ITgGuideArchivesService TgGuideArchivesService { get; set; }
        #region 导游人员信息编辑页面
        /// <summary>
        /// 导游人员信息编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TgGuideArchivesEdit(string id)
        {
            TgGuideArchives m = TgGuideArchives.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TgGuideArchivesService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 导游人员信息列表页面
        /// <summary>
        /// 导游人员信息列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TgGuideArchivesList()
        {
            return View();
        }
        #endregion

        #region 导游人员信息保存程序
        /// <summary>
        /// 导游人员信息保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTgGuideArchives(TgGuideArchives m)
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
                    TgGuideArchivesService.Update(m);
                }
                else
                {
                    TgGuideArchivesService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 导游人员信息搜索
        /// <summary>
        /// 导游人员信息搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTgGuideArchivesList(SearchDtoBase<TgGuideArchives> c, TgGuideArchives s)
        {
            c.entity = s;
            return Json(TgGuideArchivesService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 导游人员信息删除
        /// <summary>
        /// 导游人员信息删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TgGuideArchivesDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TgGuideArchivesService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  导游人员信息

        #region 导游结算管理
        public ITgGuideBalanceService TgGuideBalanceService { get; set; }
        #region 导游结算管理编辑页面
        /// <summary>
        /// 导游结算管理编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TgGuideBalanceEdit(string id)
        {
            TgGuideBalance m = TgGuideBalance.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TgGuideBalanceService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 导游结算管理列表页面
        /// <summary>
        /// 导游结算管理列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TgGuideBalanceList()
        {
            return View();
        }
        #endregion

        #region 导游结算管理保存程序
        /// <summary>
        /// 导游结算管理保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTgGuideBalance(TgGuideBalance m)
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
                    TgGuideBalanceService.Update(m);
                }
                else
                {
                    TgGuideBalanceService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 导游结算管理搜索
        /// <summary>
        /// 导游结算管理搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTgGuideBalanceList(SearchDtoBase<TgGuideBalance> c, TgGuideBalance s)
        {
            c.entity = s;
            return Json(TgGuideBalanceService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 导游结算管理删除
        /// <summary>
        /// 导游结算管理删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TgGuideBalanceDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TgGuideBalanceService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  导游结算管理

        #region 导游结算明细
        public ITgGuideBalanceDetailService TgGuideBalanceDetailService { get; set; }
        #region 导游结算明细编辑页面
        /// <summary>
        /// 导游结算明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TgGuideBalanceDetailEdit(string id)
        {
            TgGuideBalanceDetail m = TgGuideBalanceDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TgGuideBalanceDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 导游结算明细列表页面
        /// <summary>
        /// 导游结算明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TgGuideBalanceDetailList()
        {
            return View();
        }
        #endregion

        #region 导游结算明细保存程序
        /// <summary>
        /// 导游结算明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTgGuideBalanceDetail(TgGuideBalanceDetail m)
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
                    TgGuideBalanceDetailService.Update(m);
                }
                else
                {
                    TgGuideBalanceDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 导游结算明细搜索
        /// <summary>
        /// 导游结算明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTgGuideBalanceDetailList(SearchDtoBase<TgGuideBalanceDetail> c, TgGuideBalanceDetail s)
        {
            c.entity = s;
            return Json(TgGuideBalanceDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 导游结算明细删除
        /// <summary>
        /// 导游结算明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TgGuideBalanceDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TgGuideBalanceDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  导游结算明细

        #region 车停策略设置
        public ITgPaCarsChargeService TgPaCarsChargeService { get; set; }
        #region 车停策略设置编辑页面
        /// <summary>
        /// 车停策略设置编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TgPaCarsChargeEdit(string id)
        {
            TgPaCarsCharge m = TgPaCarsCharge.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TgPaCarsChargeService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 车停策略设置列表页面
        /// <summary>
        /// 车停策略设置列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TgPaCarsChargeList()
        {
            return View();
        }
        #endregion

        #region 车停策略设置保存程序
        /// <summary>
        /// 车停策略设置保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTgPaCarsCharge(TgPaCarsCharge m)
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
                    TgPaCarsChargeService.Update(m);
                }
                else
                {
                    TgPaCarsChargeService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 车停策略设置搜索
        /// <summary>
        /// 车停策略设置搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTgPaCarsChargeList(SearchDtoBase<TgPaCarsCharge> c, TgPaCarsCharge s)
        {
            c.entity = s;
            return Json(TgPaCarsChargeService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 车停策略设置删除
        /// <summary>
        /// 车停策略设置删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TgPaCarsChargeDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TgPaCarsChargeService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  车停策略设置

        #region 车型设置
        public ITgPaCarsTypeService TgPaCarsTypeService { get; set; }
        #region 车型设置编辑页面
        /// <summary>
        /// 车型设置编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TgPaCarsTypeEdit(string id)
        {
            TgPaCarsType m = TgPaCarsType.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TgPaCarsTypeService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 车型设置列表页面
        /// <summary>
        /// 车型设置列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TgPaCarsTypeList()
        {
            return View();
        }
        #endregion

        #region 车型设置保存程序
        /// <summary>
        /// 车型设置保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTgPaCarsType(TgPaCarsType m)
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
                    TgPaCarsTypeService.Update(m);
                }
                else
                {
                    TgPaCarsTypeService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 车型设置搜索
        /// <summary>
        /// 车型设置搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTgPaCarsTypeList(SearchDtoBase<TgPaCarsType> c, TgPaCarsType s)
        {
            c.entity = s;
            return Json(TgPaCarsTypeService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 车型设置删除
        /// <summary>
        /// 车型设置删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TgPaCarsTypeDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TgPaCarsTypeService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  车型设置

        #region 团队结算设置
        public ITgPaGroupService TgPaGroupService { get; set; }
        #region 团队结算设置编辑页面
        /// <summary>
        /// 团队结算设置编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TgPaGroupEdit(string id)
        {
            TgPaGroup m = TgPaGroup.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TgPaGroupService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 团队结算设置列表页面
        /// <summary>
        /// 团队结算设置列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TgPaGroupList()
        {
            return View();
        }
        #endregion

        #region 团队结算设置保存程序
        /// <summary>
        /// 团队结算设置保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTgPaGroup(TgPaGroup m)
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
                    TgPaGroupService.Update(m);
                }
                else
                {
                    TgPaGroupService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 团队结算设置搜索
        /// <summary>
        /// 团队结算设置搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTgPaGroupList(SearchDtoBase<TgPaGroup> c, TgPaGroup s)
        {
            c.entity = s;
            return Json(TgPaGroupService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 团队结算设置删除
        /// <summary>
        /// 团队结算设置删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TgPaGroupDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TgPaGroupService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  团队结算设置

        #region 团队类别
        public ITgPaGroupTypeService TgPaGroupTypeService { get; set; }
        #region 团队类别编辑页面
        /// <summary>
        /// 团队类别编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TgPaGroupTypeEdit(string id)
        {
            TgPaGroupType m = TgPaGroupType.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TgPaGroupTypeService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 团队类别列表页面
        /// <summary>
        /// 团队类别列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TgPaGroupTypeList()
        {
            return View();
        }
        #endregion

        #region 团队类别保存程序
        /// <summary>
        /// 团队类别保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTgPaGroupType(TgPaGroupType m)
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
                    TgPaGroupTypeService.Update(m);
                }
                else
                {
                    TgPaGroupTypeService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 团队类别搜索
        /// <summary>
        /// 团队类别搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTgPaGroupTypeList(SearchDtoBase<TgPaGroupType> c, TgPaGroupType s)
        {
            c.entity = s;
            return Json(TgPaGroupTypeService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 团队类别删除
        /// <summary>
        /// 团队类别删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TgPaGroupTypeDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TgPaGroupTypeService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  团队类别

        #region 旅行社类型
        public ITgPaTaTypeService TgPaTaTypeService { get; set; }
        #region 旅行社类型编辑页面
        /// <summary>
        /// 旅行社类型编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TgPaTaTypeEdit(string id)
        {
            TgPaTaType m = TgPaTaType.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TgPaTaTypeService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 旅行社类型列表页面
        /// <summary>
        /// 旅行社类型列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TgPaTaTypeList()
        {
            return View();
        }
        #endregion

        #region 旅行社类型保存程序
        /// <summary>
        /// 旅行社类型保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTgPaTaType(TgPaTaType m)
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
                    TgPaTaTypeService.Update(m);
                }
                else
                {
                    TgPaTaTypeService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 旅行社类型搜索
        /// <summary>
        /// 旅行社类型搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTgPaTaTypeList(SearchDtoBase<TgPaTaType> c, TgPaTaType s)
        {
            c.entity = s;
            return Json(TgPaTaTypeService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 旅行社类型删除
        /// <summary>
        /// 旅行社类型删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TgPaTaTypeDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TgPaTaTypeService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  旅行社类型

        #region 人员提成策略明细
        public ITgPushtacDetailService TgPushtacDetailService { get; set; }
        #region 人员提成策略明细编辑页面
        /// <summary>
        /// 人员提成策略明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TgPushtacDetailEdit(string id)
        {
            TgPushtacDetail m = TgPushtacDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TgPushtacDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 人员提成策略明细列表页面
        /// <summary>
        /// 人员提成策略明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TgPushtacDetailList()
        {
            return View();
        }
        #endregion

        #region 人员提成策略明细保存程序
        /// <summary>
        /// 人员提成策略明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTgPushtacDetail(TgPushtacDetail m)
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
                    TgPushtacDetailService.Update(m);
                }
                else
                {
                    TgPushtacDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 人员提成策略明细搜索
        /// <summary>
        /// 人员提成策略明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTgPushtacDetailList(SearchDtoBase<TgPushtacDetail> c, TgPushtacDetail s)
        {
            c.entity = s;
            return Json(TgPushtacDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 人员提成策略明细删除
        /// <summary>
        /// 人员提成策略明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TgPushtacDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TgPushtacDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  人员提成策略明细

        #region 人员提成策略
        public ITgPushtacManageService TgPushtacManageService { get; set; }
        #region 人员提成策略编辑页面
        /// <summary>
        /// 人员提成策略编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TgPushtacManageEdit(string id)
        {
            TgPushtacManage m = TgPushtacManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TgPushtacManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 人员提成策略列表页面
        /// <summary>
        /// 人员提成策略列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TgPushtacManageList()
        {
            return View();
        }
        #endregion

        #region 人员提成策略保存程序
        /// <summary>
        /// 人员提成策略保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTgPushtacManage(TgPushtacManage m)
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
                    TgPushtacManageService.Update(m);
                }
                else
                {
                    TgPushtacManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 人员提成策略搜索
        /// <summary>
        /// 人员提成策略搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTgPushtacManageList(SearchDtoBase<TgPushtacManage> c, TgPushtacManage s)
        {
            c.entity = s;
            return Json(TgPushtacManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 人员提成策略删除
        /// <summary>
        /// 人员提成策略删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TgPushtacManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TgPushtacManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  人员提成策略

        #region 团队购物管理
        public ITgTourgroupManageService TgTourgroupManageService { get; set; }
        #region 团队购物管理编辑页面
        /// <summary>
        /// 团队购物管理编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TgTourgroupManageEdit(string id)
        {
            TgTourgroupManage m = TgTourgroupManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TgTourgroupManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 团队购物管理列表页面
        /// <summary>
        /// 团队购物管理列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TgTourgroupManageList()
        {
            return View();
        }
        #endregion

        #region 团队购物管理保存程序
        /// <summary>
        /// 团队购物管理保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTgTourgroupManage(TgTourgroupManage m)
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
                    TgTourgroupManageService.Update(m);
                }
                else
                {
                    TgTourgroupManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 团队购物管理搜索
        /// <summary>
        /// 团队购物管理搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTgTourgroupManageList(SearchDtoBase<TgTourgroupManage> c, TgTourgroupManage s)
        {
            c.entity = s;
            return Json(TgTourgroupManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 团队购物管理删除
        /// <summary>
        /// 团队购物管理删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TgTourgroupManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TgTourgroupManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  团队购物管理

        #region 旅行社档案
        public ITgTravelArchivesService TgTravelArchivesService { get; set; }
        #region 旅行社档案编辑页面
        /// <summary>
        /// 旅行社档案编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TgTravelArchivesEdit(string id)
        {
            TgTravelArchives m = TgTravelArchives.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TgTravelArchivesService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 旅行社档案列表页面
        /// <summary>
        /// 旅行社档案列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TgTravelArchivesList()
        {
            return View();
        }
        #endregion

        #region 旅行社档案保存程序
        /// <summary>
        /// 旅行社档案保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTgTravelArchives(TgTravelArchives m)
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
                    TgTravelArchivesService.Update(m);
                }
                else
                {
                    TgTravelArchivesService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 旅行社档案搜索
        /// <summary>
        /// 旅行社档案搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTgTravelArchivesList(SearchDtoBase<TgTravelArchives> c, TgTravelArchives s)
        {
            c.entity = s;
            return Json(TgTravelArchivesService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 旅行社档案删除
        /// <summary>
        /// 旅行社档案删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TgTravelArchivesDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TgTravelArchivesService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  旅行社档案

        #region 旅行社提成策略
        public ITgTravelArchivesPushtacService TgTravelArchivesPushtacService { get; set; }
        #region 旅行社提成策略编辑页面
        /// <summary>
        /// 旅行社提成策略编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TgTravelArchivesPushtacEdit(string id)
        {
            TgTravelArchivesPushtac m = TgTravelArchivesPushtac.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TgTravelArchivesPushtacService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 旅行社提成策略列表页面
        /// <summary>
        /// 旅行社提成策略列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TgTravelArchivesPushtacList()
        {
            return View();
        }
        #endregion

        #region 旅行社提成策略保存程序
        /// <summary>
        /// 旅行社提成策略保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTgTravelArchivesPushtac(TgTravelArchivesPushtac m)
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
                    TgTravelArchivesPushtacService.Update(m);
                }
                else
                {
                    TgTravelArchivesPushtacService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 旅行社提成策略搜索
        /// <summary>
        /// 旅行社提成策略搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTgTravelArchivesPushtacList(SearchDtoBase<TgTravelArchivesPushtac> c, TgTravelArchivesPushtac s)
        {
            c.entity = s;
            return Json(TgTravelArchivesPushtacService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 旅行社提成策略删除
        /// <summary>
        /// 旅行社提成策略删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TgTravelArchivesPushtacDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TgTravelArchivesPushtacService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  旅行社提成策略

        #region 旅行社结算管理
        public ITgTravelBalanceService TgTravelBalanceService { get; set; }
        #region 旅行社结算管理编辑页面
        /// <summary>
        /// 旅行社结算管理编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TgTravelBalanceEdit(string id)
        {
            TgTravelBalance m = TgTravelBalance.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TgTravelBalanceService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 旅行社结算管理列表页面
        /// <summary>
        /// 旅行社结算管理列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TgTravelBalanceList()
        {
            return View();
        }
        #endregion

        #region 旅行社结算管理保存程序
        /// <summary>
        /// 旅行社结算管理保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTgTravelBalance(TgTravelBalance m)
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
                    TgTravelBalanceService.Update(m);
                }
                else
                {
                    TgTravelBalanceService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 旅行社结算管理搜索
        /// <summary>
        /// 旅行社结算管理搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTgTravelBalanceList(SearchDtoBase<TgTravelBalance> c, TgTravelBalance s)
        {
            c.entity = s;
            return Json(TgTravelBalanceService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 旅行社结算管理删除
        /// <summary>
        /// 旅行社结算管理删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TgTravelBalanceDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TgTravelBalanceService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  旅行社结算管理

        #region 旅行社结算明细
        public ITgTravelBalanceDetailService TgTravelBalanceDetailService { get; set; }
        #region 旅行社结算明细编辑页面
        /// <summary>
        /// 旅行社结算明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TgTravelBalanceDetailEdit(string id)
        {
            TgTravelBalanceDetail m = TgTravelBalanceDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TgTravelBalanceDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 旅行社结算明细列表页面
        /// <summary>
        /// 旅行社结算明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TgTravelBalanceDetailList()
        {
            return View();
        }
        #endregion

        #region 旅行社结算明细保存程序
        /// <summary>
        /// 旅行社结算明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTgTravelBalanceDetail(TgTravelBalanceDetail m)
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
                    TgTravelBalanceDetailService.Update(m);
                }
                else
                {
                    TgTravelBalanceDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 旅行社结算明细搜索
        /// <summary>
        /// 旅行社结算明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTgTravelBalanceDetailList(SearchDtoBase<TgTravelBalanceDetail> c, TgTravelBalanceDetail s)
        {
            c.entity = s;
            return Json(TgTravelBalanceDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 旅行社结算明细删除
        /// <summary>
        /// 旅行社结算明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TgTravelBalanceDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TgTravelBalanceDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  旅行社结算明细
    }
}





