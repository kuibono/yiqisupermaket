
using NSH.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiQiWorkFlow.Application.Service.Ba;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Web.Client.Controllers
{
    public class BaController : Controller
    {

        #region 分店结算
        public IBaBranchBalanceService BaBranchBalanceService { get; set; }
        #region 分店结算编辑页面
        /// <summary>
        /// 分店结算编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BaBranchBalanceEdit(string id)
        {
            BaBranchBalance m = BaBranchBalance.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BaBranchBalanceService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店结算列表页面
        /// <summary>
        /// 分店结算列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaBranchBalanceList()
        {
            return View();
        }
        #endregion

        #region 分店结算保存程序
        /// <summary>
        /// 分店结算保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBaBranchBalance(BaBranchBalance m)
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
                    BaBranchBalanceService.Update(m);
                }
                else
                {
                    BaBranchBalanceService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店结算搜索
        /// <summary>
        /// 分店结算搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBaBranchBalanceList(SearchDtoBase<BaBranchBalance> c, BaBranchBalance s)
        {
            c.entity = s;
            return Json(BaBranchBalanceService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店结算删除
        /// <summary>
        /// 分店结算删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BaBranchBalanceDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BaBranchBalanceService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店结算

        #region 分店结算明细
        public IBaBranchDetailService BaBranchDetailService { get; set; }
        #region 分店结算明细编辑页面
        /// <summary>
        /// 分店结算明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BaBranchDetailEdit(string id)
        {
            BaBranchDetail m = BaBranchDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BaBranchDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店结算明细列表页面
        /// <summary>
        /// 分店结算明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaBranchDetailList()
        {
            return View();
        }
        #endregion

        #region 分店结算明细保存程序
        /// <summary>
        /// 分店结算明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBaBranchDetail(BaBranchDetail m)
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
                    BaBranchDetailService.Update(m);
                }
                else
                {
                    BaBranchDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店结算明细搜索
        /// <summary>
        /// 分店结算明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBaBranchDetailList(SearchDtoBase<BaBranchDetail> c, BaBranchDetail s)
        {
            c.entity = s;
            return Json(BaBranchDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店结算明细删除
        /// <summary>
        /// 分店结算明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BaBranchDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BaBranchDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店结算明细

        #region 分店代销对帐
        public IBaBranchOfferAccountService BaBranchOfferAccountService { get; set; }
        #region 分店代销对帐编辑页面
        /// <summary>
        /// 分店代销对帐编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BaBranchOfferAccountEdit(string id)
        {
            BaBranchOfferAccount m = BaBranchOfferAccount.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BaBranchOfferAccountService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店代销对帐列表页面
        /// <summary>
        /// 分店代销对帐列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaBranchOfferAccountList()
        {
            return View();
        }
        #endregion

        #region 分店代销对帐保存程序
        /// <summary>
        /// 分店代销对帐保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBaBranchOfferAccount(BaBranchOfferAccount m)
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
                    BaBranchOfferAccountService.Update(m);
                }
                else
                {
                    BaBranchOfferAccountService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店代销对帐搜索
        /// <summary>
        /// 分店代销对帐搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBaBranchOfferAccountList(SearchDtoBase<BaBranchOfferAccount> c, BaBranchOfferAccount s)
        {
            c.entity = s;
            return Json(BaBranchOfferAccountService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店代销对帐删除
        /// <summary>
        /// 分店代销对帐删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BaBranchOfferAccountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BaBranchOfferAccountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店代销对帐

        #region 分店代销对帐明细
        public IBaBranchOfferDetailService BaBranchOfferDetailService { get; set; }
        #region 分店代销对帐明细编辑页面
        /// <summary>
        /// 分店代销对帐明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BaBranchOfferDetailEdit(string id)
        {
            BaBranchOfferDetail m = BaBranchOfferDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BaBranchOfferDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店代销对帐明细列表页面
        /// <summary>
        /// 分店代销对帐明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaBranchOfferDetailList()
        {
            return View();
        }
        #endregion

        #region 分店代销对帐明细保存程序
        /// <summary>
        /// 分店代销对帐明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBaBranchOfferDetail(BaBranchOfferDetail m)
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
                    BaBranchOfferDetailService.Update(m);
                }
                else
                {
                    BaBranchOfferDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店代销对帐明细搜索
        /// <summary>
        /// 分店代销对帐明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBaBranchOfferDetailList(SearchDtoBase<BaBranchOfferDetail> c, BaBranchOfferDetail s)
        {
            c.entity = s;
            return Json(BaBranchOfferDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店代销对帐明细删除
        /// <summary>
        /// 分店代销对帐明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BaBranchOfferDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BaBranchOfferDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店代销对帐明细

        #region 费用费用费用明细
        public IBaChargeDetailService BaChargeDetailService { get; set; }
        #region 费用费用费用明细编辑页面
        /// <summary>
        /// 费用费用费用明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BaChargeDetailEdit(int? id)
        {
            BaChargeDetail m = BaChargeDetail.Initial();
            if (id.HasValue && id > 0)
            {
                m = BaChargeDetailService.GetById(id.Value);
            }
            return View(m);
        }
        #endregion

        #region 费用费用费用明细列表页面
        /// <summary>
        /// 费用费用费用明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaChargeDetailList()
        {
            return View();
        }
        #endregion

        #region 费用费用费用明细保存程序
        /// <summary>
        /// 费用费用费用明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBaChargeDetail(BaChargeDetail m)
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
                    BaChargeDetailService.Update(m);
                }
                else
                {
                    BaChargeDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 费用费用费用明细搜索
        /// <summary>
        /// 费用费用费用明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBaChargeDetailList(SearchDtoBase<BaChargeDetail> c, BaChargeDetail s)
        {
            c.entity = s;
            return Json(BaChargeDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 费用费用费用明细删除
        /// <summary>
        /// 费用费用费用明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BaChargeDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BaChargeDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  费用费用费用明细

        #region 费用管理
        public IBaChargeManageService BaChargeManageService { get; set; }
        #region 费用管理编辑页面
        /// <summary>
        /// 费用管理编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BaChargeManageEdit(string id)
        {
            BaChargeManage m = BaChargeManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BaChargeManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 费用管理列表页面
        /// <summary>
        /// 费用管理列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaChargeManageList()
        {
            return View();
        }
        #endregion

        #region 费用管理保存程序
        /// <summary>
        /// 费用管理保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBaChargeManage(BaChargeManage m)
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
                    BaChargeManageService.Update(m);
                }
                else
                {
                    BaChargeManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 费用管理搜索
        /// <summary>
        /// 费用管理搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBaChargeManageList(SearchDtoBase<BaChargeManage> c, BaChargeManage s)
        {
            c.entity = s;
            return Json(BaChargeManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 费用管理删除
        /// <summary>
        /// 费用管理删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BaChargeManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BaChargeManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  费用管理

        #region 客户结算
        public IBaCustomerBalanceService BaCustomerBalanceService { get; set; }
        #region 客户结算编辑页面
        /// <summary>
        /// 客户结算编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BaCustomerBalanceEdit(string id)
        {
            BaCustomerBalance m = BaCustomerBalance.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BaCustomerBalanceService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 客户结算列表页面
        /// <summary>
        /// 客户结算列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaCustomerBalanceList()
        {
            return View();
        }
        #endregion

        #region 客户结算保存程序
        /// <summary>
        /// 客户结算保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBaCustomerBalance(BaCustomerBalance m)
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
                    BaCustomerBalanceService.Update(m);
                }
                else
                {
                    BaCustomerBalanceService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 客户结算搜索
        /// <summary>
        /// 客户结算搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBaCustomerBalanceList(SearchDtoBase<BaCustomerBalance> c, BaCustomerBalance s)
        {
            c.entity = s;
            return Json(BaCustomerBalanceService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 客户结算删除
        /// <summary>
        /// 客户结算删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BaCustomerBalanceDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BaCustomerBalanceService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  客户结算

        #region 客户结算明细
        public IBaCustomerDetailService BaCustomerDetailService { get; set; }
        #region 客户结算明细编辑页面
        /// <summary>
        /// 客户结算明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BaCustomerDetailEdit(string id)
        {
            BaCustomerDetail m = BaCustomerDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BaCustomerDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 客户结算明细列表页面
        /// <summary>
        /// 客户结算明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaCustomerDetailList()
        {
            return View();
        }
        #endregion

        #region 客户结算明细保存程序
        /// <summary>
        /// 客户结算明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBaCustomerDetail(BaCustomerDetail m)
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
                    BaCustomerDetailService.Update(m);
                }
                else
                {
                    BaCustomerDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 客户结算明细搜索
        /// <summary>
        /// 客户结算明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBaCustomerDetailList(SearchDtoBase<BaCustomerDetail> c, BaCustomerDetail s)
        {
            c.entity = s;
            return Json(BaCustomerDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 客户结算明细删除
        /// <summary>
        /// 客户结算明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BaCustomerDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BaCustomerDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  客户结算明细

        #region 租赁对帐单
        public IBaLeaseAccountService BaLeaseAccountService { get; set; }
        #region 租赁对帐单编辑页面
        /// <summary>
        /// 租赁对帐单编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BaLeaseAccountEdit(string id)
        {
            BaLeaseAccount m = BaLeaseAccount.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BaLeaseAccountService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 租赁对帐单列表页面
        /// <summary>
        /// 租赁对帐单列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaLeaseAccountList()
        {
            return View();
        }
        #endregion

        #region 租赁对帐单保存程序
        /// <summary>
        /// 租赁对帐单保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBaLeaseAccount(BaLeaseAccount m)
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
                    BaLeaseAccountService.Update(m);
                }
                else
                {
                    BaLeaseAccountService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 租赁对帐单搜索
        /// <summary>
        /// 租赁对帐单搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBaLeaseAccountList(SearchDtoBase<BaLeaseAccount> c, BaLeaseAccount s)
        {
            c.entity = s;
            return Json(BaLeaseAccountService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 租赁对帐单删除
        /// <summary>
        /// 租赁对帐单删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BaLeaseAccountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BaLeaseAccountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  租赁对帐单

        #region 租赁对帐单商品明细
        public IBaLeaseDetailService BaLeaseDetailService { get; set; }
        #region 租赁对帐单商品明细编辑页面
        /// <summary>
        /// 租赁对帐单商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BaLeaseDetailEdit(string id)
        {
            BaLeaseDetail m = BaLeaseDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BaLeaseDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 租赁对帐单商品明细列表页面
        /// <summary>
        /// 租赁对帐单商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaLeaseDetailList()
        {
            return View();
        }
        #endregion

        #region 租赁对帐单商品明细保存程序
        /// <summary>
        /// 租赁对帐单商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBaLeaseDetail(BaLeaseDetail m)
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
                    BaLeaseDetailService.Update(m);
                }
                else
                {
                    BaLeaseDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 租赁对帐单商品明细搜索
        /// <summary>
        /// 租赁对帐单商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBaLeaseDetailList(SearchDtoBase<BaLeaseDetail> c, BaLeaseDetail s)
        {
            c.entity = s;
            return Json(BaLeaseDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 租赁对帐单商品明细删除
        /// <summary>
        /// 租赁对帐单商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BaLeaseDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BaLeaseDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  租赁对帐单商品明细

        #region 代销对账单
        public IBaOfferAccountService BaOfferAccountService { get; set; }
        #region 代销对账单编辑页面
        /// <summary>
        /// 代销对账单编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BaOfferAccountEdit(string id)
        {
            BaOfferAccount m = BaOfferAccount.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BaOfferAccountService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 代销对账单列表页面
        /// <summary>
        /// 代销对账单列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaOfferAccountList()
        {
            return View();
        }
        #endregion

        #region 代销对账单保存程序
        /// <summary>
        /// 代销对账单保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBaOfferAccount(BaOfferAccount m)
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
                    BaOfferAccountService.Update(m);
                }
                else
                {
                    BaOfferAccountService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 代销对账单搜索
        /// <summary>
        /// 代销对账单搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBaOfferAccountList(SearchDtoBase<BaOfferAccount> c, BaOfferAccount s)
        {
            c.entity = s;
            return Json(BaOfferAccountService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 代销对账单删除
        /// <summary>
        /// 代销对账单删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BaOfferAccountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BaOfferAccountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  代销对账单

        #region 代销对账单商品明细
        public IBaOfferDetailService BaOfferDetailService { get; set; }
        #region 代销对账单商品明细编辑页面
        /// <summary>
        /// 代销对账单商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BaOfferDetailEdit(string id)
        {
            BaOfferDetail m = BaOfferDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BaOfferDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 代销对账单商品明细列表页面
        /// <summary>
        /// 代销对账单商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaOfferDetailList()
        {
            return View();
        }
        #endregion

        #region 代销对账单商品明细保存程序
        /// <summary>
        /// 代销对账单商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBaOfferDetail(BaOfferDetail m)
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
                    BaOfferDetailService.Update(m);
                }
                else
                {
                    BaOfferDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 代销对账单商品明细搜索
        /// <summary>
        /// 代销对账单商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBaOfferDetailList(SearchDtoBase<BaOfferDetail> c, BaOfferDetail s)
        {
            c.entity = s;
            return Json(BaOfferDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 代销对账单商品明细删除
        /// <summary>
        /// 代销对账单商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BaOfferDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BaOfferDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  代销对账单商品明细

        #region 结算对账设置
        public IBaPaAccountService BaPaAccountService { get; set; }
        #region 结算对账设置编辑页面
        /// <summary>
        /// 结算对账设置编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BaPaAccountEdit(string id)
        {
            BaPaAccount m = BaPaAccount.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BaPaAccountService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 结算对账设置列表页面
        /// <summary>
        /// 结算对账设置列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaPaAccountList()
        {
            return View();
        }
        #endregion

        #region 结算对账设置保存程序
        /// <summary>
        /// 结算对账设置保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBaPaAccount(BaPaAccount m)
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
                    BaPaAccountService.Update(m);
                }
                else
                {
                    BaPaAccountService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 结算对账设置搜索
        /// <summary>
        /// 结算对账设置搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBaPaAccountList(SearchDtoBase<BaPaAccount> c, BaPaAccount s)
        {
            c.entity = s;
            return Json(BaPaAccountService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 结算对账设置删除
        /// <summary>
        /// 结算对账设置删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BaPaAccountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BaPaAccountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  结算对账设置

        #region 分店对帐设置
        public IBaPaBranchAccountService BaPaBranchAccountService { get; set; }
        #region 分店对帐设置编辑页面
        /// <summary>
        /// 分店对帐设置编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BaPaBranchAccountEdit(string id)
        {
            BaPaBranchAccount m = BaPaBranchAccount.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BaPaBranchAccountService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店对帐设置列表页面
        /// <summary>
        /// 分店对帐设置列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaPaBranchAccountList()
        {
            return View();
        }
        #endregion

        #region 分店对帐设置保存程序
        /// <summary>
        /// 分店对帐设置保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBaPaBranchAccount(BaPaBranchAccount m)
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
                    BaPaBranchAccountService.Update(m);
                }
                else
                {
                    BaPaBranchAccountService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店对帐设置搜索
        /// <summary>
        /// 分店对帐设置搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBaPaBranchAccountList(SearchDtoBase<BaPaBranchAccount> c, BaPaBranchAccount s)
        {
            c.entity = s;
            return Json(BaPaBranchAccountService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店对帐设置删除
        /// <summary>
        /// 分店对帐设置删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BaPaBranchAccountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BaPaBranchAccountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店对帐设置

        #region 费用设置
        public IBaPaChargeService BaPaChargeService { get; set; }
        #region 费用设置编辑页面
        /// <summary>
        /// 费用设置编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BaPaChargeEdit(string id)
        {
            BaPaCharge m = BaPaCharge.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BaPaChargeService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 费用设置列表页面
        /// <summary>
        /// 费用设置列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaPaChargeList()
        {
            return View();
        }
        #endregion

        #region 费用设置保存程序
        /// <summary>
        /// 费用设置保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBaPaCharge(BaPaCharge m)
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
                    BaPaChargeService.Update(m);
                }
                else
                {
                    BaPaChargeService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 费用设置搜索
        /// <summary>
        /// 费用设置搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBaPaChargeList(SearchDtoBase<BaPaCharge> c, BaPaCharge s)
        {
            c.entity = s;
            return Json(BaPaChargeService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 费用设置删除
        /// <summary>
        /// 费用设置删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BaPaChargeDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BaPaChargeService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  费用设置

        #region 财务科目设置
        public IBaPaSubjectService BaPaSubjectService { get; set; }
        #region 财务科目设置编辑页面
        /// <summary>
        /// 财务科目设置编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BaPaSubjectEdit(int? id)
        {
            BaPaSubject m = BaPaSubject.Initial();
            if (id.HasValue && id > 0)
            {
                m = BaPaSubjectService.GetById(id.Value);
            }
            return View(m);
        }
        #endregion

        #region 财务科目设置列表页面
        /// <summary>
        /// 财务科目设置列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaPaSubjectList()
        {
            return View();
        }
        #endregion

        #region 财务科目设置保存程序
        /// <summary>
        /// 财务科目设置保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBaPaSubject(BaPaSubject m)
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
                    BaPaSubjectService.Update(m);
                }
                else
                {
                    BaPaSubjectService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 财务科目设置搜索
        /// <summary>
        /// 财务科目设置搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBaPaSubjectList(SearchDtoBase<BaPaSubject> c, BaPaSubject s)
        {
            c.entity = s;
            return Json(BaPaSubjectService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 财务科目设置删除
        /// <summary>
        /// 财务科目设置删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BaPaSubjectDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BaPaSubjectService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  财务科目设置

        #region 联营对帐单
        public IBaPoolAccountService BaPoolAccountService { get; set; }
        #region 联营对帐单编辑页面
        /// <summary>
        /// 联营对帐单编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BaPoolAccountEdit(string id)
        {
            BaPoolAccount m = BaPoolAccount.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BaPoolAccountService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 联营对帐单列表页面
        /// <summary>
        /// 联营对帐单列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaPoolAccountList()
        {
            return View();
        }
        #endregion

        #region 联营对帐单保存程序
        /// <summary>
        /// 联营对帐单保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBaPoolAccount(BaPoolAccount m)
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
                    BaPoolAccountService.Update(m);
                }
                else
                {
                    BaPoolAccountService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 联营对帐单搜索
        /// <summary>
        /// 联营对帐单搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBaPoolAccountList(SearchDtoBase<BaPoolAccount> c, BaPoolAccount s)
        {
            c.entity = s;
            return Json(BaPoolAccountService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 联营对帐单删除
        /// <summary>
        /// 联营对帐单删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BaPoolAccountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BaPoolAccountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  联营对帐单

        #region 联营对帐单商品明细
        public IBaPoolDetailService BaPoolDetailService { get; set; }
        #region 联营对帐单商品明细编辑页面
        /// <summary>
        /// 联营对帐单商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BaPoolDetailEdit(string id)
        {
            BaPoolDetail m = BaPoolDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BaPoolDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 联营对帐单商品明细列表页面
        /// <summary>
        /// 联营对帐单商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaPoolDetailList()
        {
            return View();
        }
        #endregion

        #region 联营对帐单商品明细保存程序
        /// <summary>
        /// 联营对帐单商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBaPoolDetail(BaPoolDetail m)
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
                    BaPoolDetailService.Update(m);
                }
                else
                {
                    BaPoolDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 联营对帐单商品明细搜索
        /// <summary>
        /// 联营对帐单商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBaPoolDetailList(SearchDtoBase<BaPoolDetail> c, BaPoolDetail s)
        {
            c.entity = s;
            return Json(BaPoolDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 联营对帐单商品明细删除
        /// <summary>
        /// 联营对帐单商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BaPoolDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BaPoolDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  联营对帐单商品明细

        #region 供货商结算
        public IBaSupplierBalanceService BaSupplierBalanceService { get; set; }
        #region 供货商结算编辑页面
        /// <summary>
        /// 供货商结算编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BaSupplierBalanceEdit(string id)
        {
            BaSupplierBalance m = BaSupplierBalance.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BaSupplierBalanceService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 供货商结算列表页面
        /// <summary>
        /// 供货商结算列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaSupplierBalanceList()
        {
            return View();
        }
        #endregion

        #region 供货商结算保存程序
        /// <summary>
        /// 供货商结算保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBaSupplierBalance(BaSupplierBalance m)
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
                    BaSupplierBalanceService.Update(m);
                }
                else
                {
                    BaSupplierBalanceService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 供货商结算搜索
        /// <summary>
        /// 供货商结算搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBaSupplierBalanceList(SearchDtoBase<BaSupplierBalance> c, BaSupplierBalance s)
        {
            c.entity = s;
            return Json(BaSupplierBalanceService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 供货商结算删除
        /// <summary>
        /// 供货商结算删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BaSupplierBalanceDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BaSupplierBalanceService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  供货商结算

        #region 供货商结算明细
        public IBaSupplierDetailService BaSupplierDetailService { get; set; }
        #region 供货商结算明细编辑页面
        /// <summary>
        /// 供货商结算明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BaSupplierDetailEdit(string id)
        {
            BaSupplierDetail m = BaSupplierDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BaSupplierDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 供货商结算明细列表页面
        /// <summary>
        /// 供货商结算明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaSupplierDetailList()
        {
            return View();
        }
        #endregion

        #region 供货商结算明细保存程序
        /// <summary>
        /// 供货商结算明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBaSupplierDetail(BaSupplierDetail m)
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
                    BaSupplierDetailService.Update(m);
                }
                else
                {
                    BaSupplierDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 供货商结算明细搜索
        /// <summary>
        /// 供货商结算明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBaSupplierDetailList(SearchDtoBase<BaSupplierDetail> c, BaSupplierDetail s)
        {
            c.entity = s;
            return Json(BaSupplierDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 供货商结算明细删除
        /// <summary>
        /// 供货商结算明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BaSupplierDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BaSupplierDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  供货商结算明细
    }
}





