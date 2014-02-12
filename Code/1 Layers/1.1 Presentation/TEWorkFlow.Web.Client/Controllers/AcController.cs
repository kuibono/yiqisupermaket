
using NSH.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiQiWorkFlow.Application.Service.Ac;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace TEWorkFlow.Web.Client.Controllers
{
    public class AcController : Controller
    {

        #region 分店商品销售帐表
        public IAcBranchGoodssaleAccountService AcBranchGoodssaleAccountService { get; set; }
        #region 分店商品销售帐表编辑页面
        /// <summary>
        /// 分店商品销售帐表编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult AcBranchGoodssaleAccountEdit(string id)
        {
            AcBranchGoodssaleAccount m = AcBranchGoodssaleAccount.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = AcBranchGoodssaleAccountService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店商品销售帐表列表页面
        /// <summary>
        /// 分店商品销售帐表列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AcBranchGoodssaleAccountList()
        {
            return View();
        }
        #endregion

        #region 分店商品销售帐表保存程序
        /// <summary>
        /// 分店商品销售帐表保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveAcBranchGoodssaleAccount(AcBranchGoodssaleAccount m)
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
                    AcBranchGoodssaleAccountService.Update(m);
                }
                else
                {
                    AcBranchGoodssaleAccountService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店商品销售帐表搜索
        /// <summary>
        /// 分店商品销售帐表搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchAcBranchGoodssaleAccountList(SearchDtoBase<AcBranchGoodssaleAccount> c, AcBranchGoodssaleAccount s)
        {
            c.entity = s;
            return Json(AcBranchGoodssaleAccountService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店商品销售帐表删除
        /// <summary>
        /// 分店商品销售帐表删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult AcBranchGoodssaleAccountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            AcBranchGoodssaleAccountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店商品销售帐表

        #region 收银员销售汇总
        public IAcCashierSummaryService AcCashierSummaryService { get; set; }
        #region 收银员销售汇总编辑页面
        /// <summary>
        /// 收银员销售汇总编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult AcCashierSummaryEdit(string id)
        {
            AcCashierSummary m = AcCashierSummary.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = AcCashierSummaryService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 收银员销售汇总列表页面
        /// <summary>
        /// 收银员销售汇总列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AcCashierSummaryList()
        {
            return View();
        }
        #endregion

        #region 收银员销售汇总保存程序
        /// <summary>
        /// 收银员销售汇总保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveAcCashierSummary(AcCashierSummary m)
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
                    AcCashierSummaryService.Update(m);
                }
                else
                {
                    AcCashierSummaryService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 收银员销售汇总搜索
        /// <summary>
        /// 收银员销售汇总搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchAcCashierSummaryList(SearchDtoBase<AcCashierSummary> c, AcCashierSummary s)
        {
            c.entity = s;
            return Json(AcCashierSummaryService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 收银员销售汇总删除
        /// <summary>
        /// 收银员销售汇总删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult AcCashierSummaryDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            AcCashierSummaryService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  收银员销售汇总

        #region 柜组销售汇总
        public IAcCounterSummaryService AcCounterSummaryService { get; set; }
        #region 柜组销售汇总编辑页面
        /// <summary>
        /// 柜组销售汇总编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult AcCounterSummaryEdit(string id)
        {
            AcCounterSummary m = AcCounterSummary.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = AcCounterSummaryService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 柜组销售汇总列表页面
        /// <summary>
        /// 柜组销售汇总列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AcCounterSummaryList()
        {
            return View();
        }
        #endregion

        #region 柜组销售汇总保存程序
        /// <summary>
        /// 柜组销售汇总保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveAcCounterSummary(AcCounterSummary m)
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
                    AcCounterSummaryService.Update(m);
                }
                else
                {
                    AcCounterSummaryService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 柜组销售汇总搜索
        /// <summary>
        /// 柜组销售汇总搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchAcCounterSummaryList(SearchDtoBase<AcCounterSummary> c, AcCounterSummary s)
        {
            c.entity = s;
            return Json(AcCounterSummaryService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 柜组销售汇总删除
        /// <summary>
        /// 柜组销售汇总删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult AcCounterSummaryDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            AcCounterSummaryService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  柜组销售汇总

        #region 分店类别进销存
        public IAcDayBranchclassJournalAccountService AcDayBranchclassJournalAccountService { get; set; }
        #region 分店类别进销存编辑页面
        /// <summary>
        /// 分店类别进销存编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult AcDayBranchclassJournalAccountEdit(string id)
        {
            AcDayBranchclassJournalAccount m = AcDayBranchclassJournalAccount.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = AcDayBranchclassJournalAccountService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店类别进销存列表页面
        /// <summary>
        /// 分店类别进销存列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AcDayBranchclassJournalAccountList()
        {
            return View();
        }
        #endregion

        #region 分店类别进销存保存程序
        /// <summary>
        /// 分店类别进销存保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveAcDayBranchclassJournalAccount(AcDayBranchclassJournalAccount m)
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
                    AcDayBranchclassJournalAccountService.Update(m);
                }
                else
                {
                    AcDayBranchclassJournalAccountService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店类别进销存搜索
        /// <summary>
        /// 分店类别进销存搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchAcDayBranchclassJournalAccountList(SearchDtoBase<AcDayBranchclassJournalAccount> c, AcDayBranchclassJournalAccount s)
        {
            c.entity = s;
            return Json(AcDayBranchclassJournalAccountService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店类别进销存删除
        /// <summary>
        /// 分店类别进销存删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult AcDayBranchclassJournalAccountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            AcDayBranchclassJournalAccountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店类别进销存

        #region 分店商品进销存日帐
        public IAcDayBranchgoodsJournalAccountService AcDayBranchgoodsJournalAccountService { get; set; }
        #region 分店商品进销存日帐编辑页面
        /// <summary>
        /// 分店商品进销存日帐编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult AcDayBranchgoodsJournalAccountEdit(string id)
        {
            AcDayBranchgoodsJournalAccount m = AcDayBranchgoodsJournalAccount.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = AcDayBranchgoodsJournalAccountService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店商品进销存日帐列表页面
        /// <summary>
        /// 分店商品进销存日帐列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AcDayBranchgoodsJournalAccountList()
        {
            return View();
        }
        #endregion

        #region 分店商品进销存日帐保存程序
        /// <summary>
        /// 分店商品进销存日帐保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveAcDayBranchgoodsJournalAccount(AcDayBranchgoodsJournalAccount m)
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
                    AcDayBranchgoodsJournalAccountService.Update(m);
                }
                else
                {
                    AcDayBranchgoodsJournalAccountService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店商品进销存日帐搜索
        /// <summary>
        /// 分店商品进销存日帐搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchAcDayBranchgoodsJournalAccountList(SearchDtoBase<AcDayBranchgoodsJournalAccount> c, AcDayBranchgoodsJournalAccount s)
        {
            c.entity = s;
            return Json(AcDayBranchgoodsJournalAccountService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店商品进销存日帐删除
        /// <summary>
        /// 分店商品进销存日帐删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult AcDayBranchgoodsJournalAccountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            AcDayBranchgoodsJournalAccountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店商品进销存日帐

        #region 类别进销存日帐
        public IAcDayClassJournalAccountService AcDayClassJournalAccountService { get; set; }
        #region 类别进销存日帐编辑页面
        /// <summary>
        /// 类别进销存日帐编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult AcDayClassJournalAccountEdit(string id)
        {
            AcDayClassJournalAccount m = AcDayClassJournalAccount.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = AcDayClassJournalAccountService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 类别进销存日帐列表页面
        /// <summary>
        /// 类别进销存日帐列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AcDayClassJournalAccountList()
        {
            return View();
        }
        #endregion

        #region 类别进销存日帐保存程序
        /// <summary>
        /// 类别进销存日帐保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveAcDayClassJournalAccount(AcDayClassJournalAccount m)
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
                    AcDayClassJournalAccountService.Update(m);
                }
                else
                {
                    AcDayClassJournalAccountService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 类别进销存日帐搜索
        /// <summary>
        /// 类别进销存日帐搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchAcDayClassJournalAccountList(SearchDtoBase<AcDayClassJournalAccount> c, AcDayClassJournalAccount s)
        {
            c.entity = s;
            return Json(AcDayClassJournalAccountService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 类别进销存日帐删除
        /// <summary>
        /// 类别进销存日帐删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult AcDayClassJournalAccountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            AcDayClassJournalAccountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  类别进销存日帐

        #region 商品进销存日帐
        public IAcDayGoodsJournalAccountService AcDayGoodsJournalAccountService { get; set; }
        #region 商品进销存日帐编辑页面
        /// <summary>
        /// 商品进销存日帐编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult AcDayGoodsJournalAccountEdit(string id)
        {
            AcDayGoodsJournalAccount m = AcDayGoodsJournalAccount.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = AcDayGoodsJournalAccountService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品进销存日帐列表页面
        /// <summary>
        /// 商品进销存日帐列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AcDayGoodsJournalAccountList()
        {
            return View();
        }
        #endregion

        #region 商品进销存日帐保存程序
        /// <summary>
        /// 商品进销存日帐保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveAcDayGoodsJournalAccount(AcDayGoodsJournalAccount m)
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
                    AcDayGoodsJournalAccountService.Update(m);
                }
                else
                {
                    AcDayGoodsJournalAccountService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品进销存日帐搜索
        /// <summary>
        /// 商品进销存日帐搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchAcDayGoodsJournalAccountList(SearchDtoBase<AcDayGoodsJournalAccount> c, AcDayGoodsJournalAccount s)
        {
            c.entity = s;
            return Json(AcDayGoodsJournalAccountService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品进销存日帐删除
        /// <summary>
        /// 商品进销存日帐删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult AcDayGoodsJournalAccountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            AcDayGoodsJournalAccountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品进销存日帐

        #region 商品进销存日帐临时表
        public IAcDayGoodsJournalAccountTempService AcDayGoodsJournalAccountTempService { get; set; }
        #region 商品进销存日帐临时表编辑页面
        /// <summary>
        /// 商品进销存日帐临时表编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult AcDayGoodsJournalAccountTempEdit(string id)
        {
            AcDayGoodsJournalAccountTemp m = AcDayGoodsJournalAccountTemp.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = AcDayGoodsJournalAccountTempService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品进销存日帐临时表列表页面
        /// <summary>
        /// 商品进销存日帐临时表列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AcDayGoodsJournalAccountTempList()
        {
            return View();
        }
        #endregion

        #region 商品进销存日帐临时表保存程序
        /// <summary>
        /// 商品进销存日帐临时表保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveAcDayGoodsJournalAccountTemp(AcDayGoodsJournalAccountTemp m)
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
                    AcDayGoodsJournalAccountTempService.Update(m);
                }
                else
                {
                    AcDayGoodsJournalAccountTempService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品进销存日帐临时表搜索
        /// <summary>
        /// 商品进销存日帐临时表搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchAcDayGoodsJournalAccountTempList(SearchDtoBase<AcDayGoodsJournalAccountTemp> c, AcDayGoodsJournalAccountTemp s)
        {
            c.entity = s;
            return Json(AcDayGoodsJournalAccountTempService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品进销存日帐临时表删除
        /// <summary>
        /// 商品进销存日帐临时表删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult AcDayGoodsJournalAccountTempDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            AcDayGoodsJournalAccountTempService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品进销存日帐临时表

        #region 总部商品进销存日帐
        public IAcDayGoodsstockJournalAccountService AcDayGoodsstockJournalAccountService { get; set; }
        #region 总部商品进销存日帐编辑页面
        /// <summary>
        /// 总部商品进销存日帐编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult AcDayGoodsstockJournalAccountEdit(string id)
        {
            AcDayGoodsstockJournalAccount m = AcDayGoodsstockJournalAccount.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = AcDayGoodsstockJournalAccountService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 总部商品进销存日帐列表页面
        /// <summary>
        /// 总部商品进销存日帐列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AcDayGoodsstockJournalAccountList()
        {
            return View();
        }
        #endregion

        #region 总部商品进销存日帐保存程序
        /// <summary>
        /// 总部商品进销存日帐保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveAcDayGoodsstockJournalAccount(AcDayGoodsstockJournalAccount m)
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
                    AcDayGoodsstockJournalAccountService.Update(m);
                }
                else
                {
                    AcDayGoodsstockJournalAccountService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 总部商品进销存日帐搜索
        /// <summary>
        /// 总部商品进销存日帐搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchAcDayGoodsstockJournalAccountList(SearchDtoBase<AcDayGoodsstockJournalAccount> c, AcDayGoodsstockJournalAccount s)
        {
            c.entity = s;
            return Json(AcDayGoodsstockJournalAccountService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 总部商品进销存日帐删除
        /// <summary>
        /// 总部商品进销存日帐删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult AcDayGoodsstockJournalAccountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            AcDayGoodsstockJournalAccountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  总部商品进销存日帐

        #region 总部商品进销存日帐临时表
        public IAcDayGoodsstockJournalAccountTempService AcDayGoodsstockJournalAccountTempService { get; set; }
        #region 总部商品进销存日帐临时表编辑页面
        /// <summary>
        /// 总部商品进销存日帐临时表编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult AcDayGoodsstockJournalAccountTempEdit(string id)
        {
            AcDayGoodsstockJournalAccountTemp m = AcDayGoodsstockJournalAccountTemp.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = AcDayGoodsstockJournalAccountTempService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 总部商品进销存日帐临时表列表页面
        /// <summary>
        /// 总部商品进销存日帐临时表列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AcDayGoodsstockJournalAccountTempList()
        {
            return View();
        }
        #endregion

        #region 总部商品进销存日帐临时表保存程序
        /// <summary>
        /// 总部商品进销存日帐临时表保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveAcDayGoodsstockJournalAccountTemp(AcDayGoodsstockJournalAccountTemp m)
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
                    AcDayGoodsstockJournalAccountTempService.Update(m);
                }
                else
                {
                    AcDayGoodsstockJournalAccountTempService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 总部商品进销存日帐临时表搜索
        /// <summary>
        /// 总部商品进销存日帐临时表搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchAcDayGoodsstockJournalAccountTempList(SearchDtoBase<AcDayGoodsstockJournalAccountTemp> c, AcDayGoodsstockJournalAccountTemp s)
        {
            c.entity = s;
            return Json(AcDayGoodsstockJournalAccountTempService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 总部商品进销存日帐临时表删除
        /// <summary>
        /// 总部商品进销存日帐临时表删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult AcDayGoodsstockJournalAccountTempDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            AcDayGoodsstockJournalAccountTempService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  总部商品进销存日帐临时表

        #region 商品销售帐表
        public IAcGoodssaleAccountService AcGoodssaleAccountService { get; set; }
        #region 商品销售帐表编辑页面
        /// <summary>
        /// 商品销售帐表编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult AcGoodssaleAccountEdit(string id)
        {
            AcGoodssaleAccount m = AcGoodssaleAccount.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = AcGoodssaleAccountService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品销售帐表列表页面
        /// <summary>
        /// 商品销售帐表列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AcGoodssaleAccountList()
        {
            return View();
        }
        #endregion

        #region 商品销售帐表保存程序
        /// <summary>
        /// 商品销售帐表保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveAcGoodssaleAccount(AcGoodssaleAccount m)
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
                    AcGoodssaleAccountService.Update(m);
                }
                else
                {
                    AcGoodssaleAccountService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品销售帐表搜索
        /// <summary>
        /// 商品销售帐表搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchAcGoodssaleAccountList(SearchDtoBase<AcGoodssaleAccount> c, AcGoodssaleAccount s)
        {
            c.entity = s;
            return Json(AcGoodssaleAccountService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品销售帐表删除
        /// <summary>
        /// 商品销售帐表删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult AcGoodssaleAccountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            AcGoodssaleAccountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品销售帐表

        #region 类别进销存月帐
        public IAcMonthClassJournalAccountService AcMonthClassJournalAccountService { get; set; }
        #region 类别进销存月帐编辑页面
        /// <summary>
        /// 类别进销存月帐编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult AcMonthClassJournalAccountEdit(string id)
        {
            AcMonthClassJournalAccount m = AcMonthClassJournalAccount.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = AcMonthClassJournalAccountService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 类别进销存月帐列表页面
        /// <summary>
        /// 类别进销存月帐列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AcMonthClassJournalAccountList()
        {
            return View();
        }
        #endregion

        #region 类别进销存月帐保存程序
        /// <summary>
        /// 类别进销存月帐保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveAcMonthClassJournalAccount(AcMonthClassJournalAccount m)
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
                    AcMonthClassJournalAccountService.Update(m);
                }
                else
                {
                    AcMonthClassJournalAccountService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 类别进销存月帐搜索
        /// <summary>
        /// 类别进销存月帐搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchAcMonthClassJournalAccountList(SearchDtoBase<AcMonthClassJournalAccount> c, AcMonthClassJournalAccount s)
        {
            c.entity = s;
            return Json(AcMonthClassJournalAccountService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 类别进销存月帐删除
        /// <summary>
        /// 类别进销存月帐删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult AcMonthClassJournalAccountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            AcMonthClassJournalAccountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  类别进销存月帐

        #region 商品进销存月帐
        public IAcMonthGoodsJournalAccountService AcMonthGoodsJournalAccountService { get; set; }
        #region 商品进销存月帐编辑页面
        /// <summary>
        /// 商品进销存月帐编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult AcMonthGoodsJournalAccountEdit(string id)
        {
            AcMonthGoodsJournalAccount m = AcMonthGoodsJournalAccount.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = AcMonthGoodsJournalAccountService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品进销存月帐列表页面
        /// <summary>
        /// 商品进销存月帐列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AcMonthGoodsJournalAccountList()
        {
            return View();
        }
        #endregion

        #region 商品进销存月帐保存程序
        /// <summary>
        /// 商品进销存月帐保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveAcMonthGoodsJournalAccount(AcMonthGoodsJournalAccount m)
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
                    AcMonthGoodsJournalAccountService.Update(m);
                }
                else
                {
                    AcMonthGoodsJournalAccountService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品进销存月帐搜索
        /// <summary>
        /// 商品进销存月帐搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchAcMonthGoodsJournalAccountList(SearchDtoBase<AcMonthGoodsJournalAccount> c, AcMonthGoodsJournalAccount s)
        {
            c.entity = s;
            return Json(AcMonthGoodsJournalAccountService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品进销存月帐删除
        /// <summary>
        /// 商品进销存月帐删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult AcMonthGoodsJournalAccountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            AcMonthGoodsJournalAccountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品进销存月帐

        #region 日帐设置
        public IAcPaDayaccountService AcPaDayaccountService { get; set; }
        #region 日帐设置编辑页面
        /// <summary>
        /// 日帐设置编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult AcPaDayaccountEdit(string id)
        {
            AcPaDayaccount m = AcPaDayaccount.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = AcPaDayaccountService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 日帐设置列表页面
        /// <summary>
        /// 日帐设置列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AcPaDayaccountList()
        {
            return View();
        }
        #endregion

        #region 日帐设置保存程序
        /// <summary>
        /// 日帐设置保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveAcPaDayaccount(AcPaDayaccount m)
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
                    AcPaDayaccountService.Update(m);
                }
                else
                {
                    AcPaDayaccountService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 日帐设置搜索
        /// <summary>
        /// 日帐设置搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchAcPaDayaccountList(SearchDtoBase<AcPaDayaccount> c, AcPaDayaccount s)
        {
            c.entity = s;
            return Json(AcPaDayaccountService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 日帐设置删除
        /// <summary>
        /// 日帐设置删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult AcPaDayaccountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            AcPaDayaccountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  日帐设置

        #region 总部日帐设置
        public IAcPaDayaccountStockService AcPaDayaccountStockService { get; set; }
        #region 总部日帐设置编辑页面
        /// <summary>
        /// 总部日帐设置编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult AcPaDayaccountStockEdit(string id)
        {
            AcPaDayaccountStock m = AcPaDayaccountStock.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = AcPaDayaccountStockService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 总部日帐设置列表页面
        /// <summary>
        /// 总部日帐设置列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AcPaDayaccountStockList()
        {
            return View();
        }
        #endregion

        #region 总部日帐设置保存程序
        /// <summary>
        /// 总部日帐设置保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveAcPaDayaccountStock(AcPaDayaccountStock m)
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
                    AcPaDayaccountStockService.Update(m);
                }
                else
                {
                    AcPaDayaccountStockService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 总部日帐设置搜索
        /// <summary>
        /// 总部日帐设置搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchAcPaDayaccountStockList(SearchDtoBase<AcPaDayaccountStock> c, AcPaDayaccountStock s)
        {
            c.entity = s;
            return Json(AcPaDayaccountStockService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 总部日帐设置删除
        /// <summary>
        /// 总部日帐设置删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult AcPaDayaccountStockDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            AcPaDayaccountStockService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  总部日帐设置

        #region 销售记账设置
        public IAcPaSalesetService AcPaSalesetService { get; set; }
        #region 销售记账设置编辑页面
        /// <summary>
        /// 销售记账设置编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult AcPaSalesetEdit(string id)
        {
            AcPaSaleset m = AcPaSaleset.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = AcPaSalesetService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 销售记账设置列表页面
        /// <summary>
        /// 销售记账设置列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AcPaSalesetList()
        {
            return View();
        }
        #endregion

        #region 销售记账设置保存程序
        /// <summary>
        /// 销售记账设置保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveAcPaSaleset(AcPaSaleset m)
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
                    AcPaSalesetService.Update(m);
                }
                else
                {
                    AcPaSalesetService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 销售记账设置搜索
        /// <summary>
        /// 销售记账设置搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchAcPaSalesetList(SearchDtoBase<AcPaSaleset> c, AcPaSaleset s)
        {
            c.entity = s;
            return Json(AcPaSalesetService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 销售记账设置删除
        /// <summary>
        /// 销售记账设置删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult AcPaSalesetDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            AcPaSalesetService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  销售记账设置

        #region 客流销售汇总
        public IAcPeriodTimeSummaryService AcPeriodTimeSummaryService { get; set; }
        #region 客流销售汇总编辑页面
        /// <summary>
        /// 客流销售汇总编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult AcPeriodTimeSummaryEdit(string id)
        {
            AcPeriodTimeSummary m = AcPeriodTimeSummary.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = AcPeriodTimeSummaryService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 客流销售汇总列表页面
        /// <summary>
        /// 客流销售汇总列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AcPeriodTimeSummaryList()
        {
            return View();
        }
        #endregion

        #region 客流销售汇总保存程序
        /// <summary>
        /// 客流销售汇总保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveAcPeriodTimeSummary(AcPeriodTimeSummary m)
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
                    AcPeriodTimeSummaryService.Update(m);
                }
                else
                {
                    AcPeriodTimeSummaryService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 客流销售汇总搜索
        /// <summary>
        /// 客流销售汇总搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchAcPeriodTimeSummaryList(SearchDtoBase<AcPeriodTimeSummary> c, AcPeriodTimeSummary s)
        {
            c.entity = s;
            return Json(AcPeriodTimeSummaryService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 客流销售汇总删除
        /// <summary>
        /// 客流销售汇总删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult AcPeriodTimeSummaryDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            AcPeriodTimeSummaryService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  客流销售汇总

        #region 营业员销售汇总
        public IAcSalesmanSummaryService AcSalesmanSummaryService { get; set; }
        #region 营业员销售汇总编辑页面
        /// <summary>
        /// 营业员销售汇总编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult AcSalesmanSummaryEdit(string id)
        {
            AcSalesmanSummary m = AcSalesmanSummary.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = AcSalesmanSummaryService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 营业员销售汇总列表页面
        /// <summary>
        /// 营业员销售汇总列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AcSalesmanSummaryList()
        {
            return View();
        }
        #endregion

        #region 营业员销售汇总保存程序
        /// <summary>
        /// 营业员销售汇总保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveAcSalesmanSummary(AcSalesmanSummary m)
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
                    AcSalesmanSummaryService.Update(m);
                }
                else
                {
                    AcSalesmanSummaryService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 营业员销售汇总搜索
        /// <summary>
        /// 营业员销售汇总搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchAcSalesmanSummaryList(SearchDtoBase<AcSalesmanSummary> c, AcSalesmanSummary s)
        {
            c.entity = s;
            return Json(AcSalesmanSummaryService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 营业员销售汇总删除
        /// <summary>
        /// 营业员销售汇总删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult AcSalesmanSummaryDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            AcSalesmanSummaryService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  营业员销售汇总

        #region 商品帐务库存
        public IAcStockAccountService AcStockAccountService { get; set; }
        #region 商品帐务库存编辑页面
        /// <summary>
        /// 商品帐务库存编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult AcStockAccountEdit(string id)
        {
            AcStockAccount m = AcStockAccount.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = AcStockAccountService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品帐务库存列表页面
        /// <summary>
        /// 商品帐务库存列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AcStockAccountList()
        {
            return View();
        }
        #endregion

        #region 商品帐务库存保存程序
        /// <summary>
        /// 商品帐务库存保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveAcStockAccount(AcStockAccount m)
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
                    AcStockAccountService.Update(m);
                }
                else
                {
                    AcStockAccountService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品帐务库存搜索
        /// <summary>
        /// 商品帐务库存搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchAcStockAccountList(SearchDtoBase<AcStockAccount> c, AcStockAccount s)
        {
            c.entity = s;
            return Json(AcStockAccountService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品帐务库存删除
        /// <summary>
        /// 商品帐务库存删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult AcStockAccountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            AcStockAccountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品帐务库存

        #region 供货商流水帐
        public IAcSupplierJournalService AcSupplierJournalService { get; set; }
        #region 供货商流水帐编辑页面
        /// <summary>
        /// 供货商流水帐编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult AcSupplierJournalEdit(string id)
        {
            AcSupplierJournal m = AcSupplierJournal.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = AcSupplierJournalService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 供货商流水帐列表页面
        /// <summary>
        /// 供货商流水帐列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AcSupplierJournalList()
        {
            return View();
        }
        #endregion

        #region 供货商流水帐保存程序
        /// <summary>
        /// 供货商流水帐保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveAcSupplierJournal(AcSupplierJournal m)
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
                    AcSupplierJournalService.Update(m);
                }
                else
                {
                    AcSupplierJournalService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 供货商流水帐搜索
        /// <summary>
        /// 供货商流水帐搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchAcSupplierJournalList(SearchDtoBase<AcSupplierJournal> c, AcSupplierJournal s)
        {
            c.entity = s;
            return Json(AcSupplierJournalService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 供货商流水帐删除
        /// <summary>
        /// 供货商流水帐删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult AcSupplierJournalDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            AcSupplierJournalService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  供货商流水帐
    }
}





