
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
            return Json(PcPurchaseDetailService.Search(c), JsonRequestBehavior.AllowGet);
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
                    m.Id=PcPurchaseManageService.Create(m);
                }

                //PcPurchaseDetail
                var jser = new JavaScriptSerializer();
                var suppliers = jser.Deserialize<List<PcPurchaseDetail>>(Request["goods"]).ToList();
                suppliers.ForEach(p => {
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
            c.entity = s;
            return Json(PcPutinDetailService.Search(c), JsonRequestBehavior.AllowGet);
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
                if (m.HaveId)
                {
                    PcPutinManageService.Update(m);
                }
                else
                {
                    PcPutinManageService.Create(m);
                }
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
                    PcPutoutManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
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
            return Json(PcReturnDetailService.Search(c), JsonRequestBehavior.AllowGet);
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
            if (string.IsNullOrEmpty(id) == false)
            {
                m = PcReturnManageService.GetById(id);
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
                    PcReturnManageService.Create(m);
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





