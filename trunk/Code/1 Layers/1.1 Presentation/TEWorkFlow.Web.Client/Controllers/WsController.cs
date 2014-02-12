
using NSH.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiQiWorkFlow.Application.Service.Ws;
using YiQiWorkFlow.Domain.Ws;
using YiQiWorkFlow.Domain.Basement;

namespace TEWorkFlow.Web.Client.Controllers
{
    public class WsController : Controller
    {

        #region 客户档案
        public IWsCustomerArchivesService WsCustomerArchivesService { get; set; }
        #region 客户档案编辑页面
        /// <summary>
        /// 客户档案编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult WsCustomerArchivesEdit(string id)
        {
            WsCustomerArchives m = WsCustomerArchives.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = WsCustomerArchivesService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 客户档案保存程序
        /// <summary>
        /// 客户档案保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveWsCustomerArchives(WsCustomerArchives m)
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
                    WsCustomerArchivesService.Update(m);
                }
                else
                {
                    WsCustomerArchivesService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 客户档案搜索
        /// <summary>
        /// 客户档案搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchWsCustomerArchivesList(SearchDtoBase<WsCustomerArchives> c, WsCustomerArchives s)
        {
            c.entity = s;
            return Json(WsCustomerArchivesService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 客户档案删除
        /// <summary>
        /// 客户档案删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult WsCustomerArchivesDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            WsCustomerArchivesService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  客户档案

        #region 客户商品
        public IWsCustomerGoodsService WsCustomerGoodsService { get; set; }
        #region 客户商品编辑页面
        /// <summary>
        /// 客户商品编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult WsCustomerGoodsEdit(string id)
        {
            WsCustomerGoods m = WsCustomerGoods.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = WsCustomerGoodsService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 客户商品保存程序
        /// <summary>
        /// 客户商品保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveWsCustomerGoods(WsCustomerGoods m)
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
                    WsCustomerGoodsService.Update(m);
                }
                else
                {
                    WsCustomerGoodsService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 客户商品搜索
        /// <summary>
        /// 客户商品搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchWsCustomerGoodsList(SearchDtoBase<WsCustomerGoods> c, WsCustomerGoods s)
        {
            c.entity = s;
            return Json(WsCustomerGoodsService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 客户商品删除
        /// <summary>
        /// 客户商品删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult WsCustomerGoodsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            WsCustomerGoodsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  客户商品

        #region 批发订单商品明细
        public IWsOrderDetailService WsOrderDetailService { get; set; }
        #region 批发订单商品明细编辑页面
        /// <summary>
        /// 批发订单商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult WsOrderDetailEdit(string id)
        {
            WsOrderDetail m = WsOrderDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = WsOrderDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 批发订单商品明细保存程序
        /// <summary>
        /// 批发订单商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveWsOrderDetail(WsOrderDetail m)
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
                    WsOrderDetailService.Update(m);
                }
                else
                {
                    WsOrderDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 批发订单商品明细搜索
        /// <summary>
        /// 批发订单商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchWsOrderDetailList(SearchDtoBase<WsOrderDetail> c, WsOrderDetail s)
        {
            c.entity = s;
            return Json(WsOrderDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 批发订单商品明细删除
        /// <summary>
        /// 批发订单商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult WsOrderDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            WsOrderDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  批发订单商品明细

        #region 批发订单
        public IWsOrderManageService WsOrderManageService { get; set; }
        #region 批发订单编辑页面
        /// <summary>
        /// 批发订单编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult WsOrderManageEdit(string id)
        {
            WsOrderManage m = WsOrderManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = WsOrderManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 批发订单保存程序
        /// <summary>
        /// 批发订单保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveWsOrderManage(WsOrderManage m)
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
                    WsOrderManageService.Update(m);
                }
                else
                {
                    WsOrderManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 批发订单搜索
        /// <summary>
        /// 批发订单搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchWsOrderManageList(SearchDtoBase<WsOrderManage> c, WsOrderManage s)
        {
            c.entity = s;
            return Json(WsOrderManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 批发订单删除
        /// <summary>
        /// 批发订单删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult WsOrderManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            WsOrderManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  批发订单

        #region 客户类型
        public IWsPaCustomerTypeService WsPaCustomerTypeService { get; set; }
        #region 客户类型编辑页面
        /// <summary>
        /// 客户类型编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult WsPaCustomerTypeEdit(string id)
        {
            WsPaCustomerType m = WsPaCustomerType.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = WsPaCustomerTypeService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 客户类型保存程序
        /// <summary>
        /// 客户类型保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveWsPaCustomerType(WsPaCustomerType m)
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
                    WsPaCustomerTypeService.Update(m);
                }
                else
                {
                    WsPaCustomerTypeService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 客户类型搜索
        /// <summary>
        /// 客户类型搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchWsPaCustomerTypeList(SearchDtoBase<WsPaCustomerType> c, WsPaCustomerType s)
        {
            c.entity = s;
            return Json(WsPaCustomerTypeService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 客户类型删除
        /// <summary>
        /// 客户类型删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult WsPaCustomerTypeDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            WsPaCustomerTypeService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  客户类型

        #region 批发销售商品明细
        public IWsWholesaleDetailService WsWholesaleDetailService { get; set; }
        #region 批发销售商品明细编辑页面
        /// <summary>
        /// 批发销售商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult WsWholesaleDetailEdit(string id)
        {
            WsWholesaleDetail m = WsWholesaleDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = WsWholesaleDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 批发销售商品明细保存程序
        /// <summary>
        /// 批发销售商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveWsWholesaleDetail(WsWholesaleDetail m)
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
                    WsWholesaleDetailService.Update(m);
                }
                else
                {
                    WsWholesaleDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 批发销售商品明细搜索
        /// <summary>
        /// 批发销售商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchWsWholesaleDetailList(SearchDtoBase<WsWholesaleDetail> c, WsWholesaleDetail s)
        {
            c.entity = s;
            return Json(WsWholesaleDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 批发销售商品明细删除
        /// <summary>
        /// 批发销售商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult WsWholesaleDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            WsWholesaleDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  批发销售商品明细

        #region 限销商品设置
        public IWsWholesaleGoodsSetService WsWholesaleGoodsSetService { get; set; }
        #region 限销商品设置编辑页面
        /// <summary>
        /// 限销商品设置编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult WsWholesaleGoodsSetEdit(string id)
        {
            WsWholesaleGoodsSet m = WsWholesaleGoodsSet.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = WsWholesaleGoodsSetService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 限销商品设置保存程序
        /// <summary>
        /// 限销商品设置保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveWsWholesaleGoodsSet(WsWholesaleGoodsSet m)
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
                    WsWholesaleGoodsSetService.Update(m);
                }
                else
                {
                    WsWholesaleGoodsSetService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 限销商品设置搜索
        /// <summary>
        /// 限销商品设置搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchWsWholesaleGoodsSetList(SearchDtoBase<WsWholesaleGoodsSet> c, WsWholesaleGoodsSet s)
        {
            c.entity = s;
            return Json(WsWholesaleGoodsSetService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 限销商品设置删除
        /// <summary>
        /// 限销商品设置删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult WsWholesaleGoodsSetDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            WsWholesaleGoodsSetService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  限销商品设置

        #region 批发销售
        public IWsWholesaleManageService WsWholesaleManageService { get; set; }
        #region 批发销售编辑页面
        /// <summary>
        /// 批发销售编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult WsWholesaleManageEdit(string id)
        {
            WsWholesaleManage m = WsWholesaleManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = WsWholesaleManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 批发销售保存程序
        /// <summary>
        /// 批发销售保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveWsWholesaleManage(WsWholesaleManage m)
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
                    WsWholesaleManageService.Update(m);
                }
                else
                {
                    WsWholesaleManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 批发销售搜索
        /// <summary>
        /// 批发销售搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchWsWholesaleManageList(SearchDtoBase<WsWholesaleManage> c, WsWholesaleManage s)
        {
            c.entity = s;
            return Json(WsWholesaleManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 批发销售删除
        /// <summary>
        /// 批发销售删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult WsWholesaleManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            WsWholesaleManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  批发销售

        #region 批发销售流水
        public IWsWholesaleManageFlowService WsWholesaleManageFlowService { get; set; }
        #region 批发销售流水编辑页面
        /// <summary>
        /// 批发销售流水编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult WsWholesaleManageFlowEdit(string id)
        {
            WsWholesaleManageFlow m = WsWholesaleManageFlow.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = WsWholesaleManageFlowService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 批发销售流水保存程序
        /// <summary>
        /// 批发销售流水保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveWsWholesaleManageFlow(WsWholesaleManageFlow m)
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
                    WsWholesaleManageFlowService.Update(m);
                }
                else
                {
                    WsWholesaleManageFlowService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 批发销售流水搜索
        /// <summary>
        /// 批发销售流水搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchWsWholesaleManageFlowList(SearchDtoBase<WsWholesaleManageFlow> c, WsWholesaleManageFlow s)
        {
            c.entity = s;
            return Json(WsWholesaleManageFlowService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 批发销售流水删除
        /// <summary>
        /// 批发销售流水删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult WsWholesaleManageFlowDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            WsWholesaleManageFlowService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  批发销售流水
    }
}





