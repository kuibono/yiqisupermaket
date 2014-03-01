
using NSH.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using YiQiWorkFlow.Application.Service.Fb;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Web.Client.Controllers
{
    public class FbController : Controller
    {

        #region 调商品所属类别
        public IFbAdjustClassService FbAdjustClassService { get; set; }
        #region 调商品所属类别编辑页面
        /// <summary>
        /// 调商品所属类别编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbAdjustClassEdit(string id)
        {
            FbAdjustClass m = FbAdjustClass.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbAdjustClassService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 调商品所属类别列表页面
        /// <summary>
        /// 调商品所属类别列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbAdjustClassList()
        {
            return View();
        }
        #endregion

        #region 调商品所属类别保存程序
        /// <summary>
        /// 调商品所属类别保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbAdjustClass(FbAdjustClass m)
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
                    FbAdjustClassService.Update(m);
                }
                else
                {
                    FbAdjustClassService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 调商品所属类别搜索
        /// <summary>
        /// 调商品所属类别搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbAdjustClassList(SearchDtoBase<FbAdjustClass> c, FbAdjustClass s)
        {
            c.entity = s;
            return Json(FbAdjustClassService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 调商品所属类别删除
        /// <summary>
        /// 调商品所属类别删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbAdjustClassDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbAdjustClassService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  调商品所属类别

        #region 调商品所属类别商品明细
        public IFbAdjustClassGoodsService FbAdjustClassGoodsService { get; set; }
        #region 调商品所属类别商品明细编辑页面
        /// <summary>
        /// 调商品所属类别商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbAdjustClassGoodsEdit(string id)
        {
            FbAdjustClassGoods m = FbAdjustClassGoods.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbAdjustClassGoodsService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 调商品所属类别商品明细列表页面
        /// <summary>
        /// 调商品所属类别商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbAdjustClassGoodsList()
        {
            return View();
        }
        #endregion

        #region 调商品所属类别商品明细保存程序
        /// <summary>
        /// 调商品所属类别商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbAdjustClassGoods(FbAdjustClassGoods m)
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
                    FbAdjustClassGoodsService.Update(m);
                }
                else
                {
                    FbAdjustClassGoodsService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 调商品所属类别商品明细搜索
        /// <summary>
        /// 调商品所属类别商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbAdjustClassGoodsList(SearchDtoBase<FbAdjustClassGoods> c, FbAdjustClassGoods s)
        {
            c.entity = s;
            return Json(FbAdjustClassGoodsService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 调商品所属类别商品明细删除
        /// <summary>
        /// 调商品所属类别商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbAdjustClassGoodsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbAdjustClassGoodsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  调商品所属类别商品明细

        #region 调商品扣率
        public IFbAdjustPoolrateService FbAdjustPoolrateService { get; set; }
        #region 调商品扣率编辑页面
        /// <summary>
        /// 调商品扣率编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbAdjustPoolrateEdit(string id)
        {
            FbAdjustPoolrate m = FbAdjustPoolrate.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbAdjustPoolrateService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 调商品扣率列表页面
        /// <summary>
        /// 调商品扣率列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbAdjustPoolrateList()
        {
            return View();
        }
        #endregion

        #region 调商品扣率保存程序
        /// <summary>
        /// 调商品扣率保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbAdjustPoolrate(FbAdjustPoolrate m)
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
                    FbAdjustPoolrateService.Update(m);
                }
                else
                {
                    FbAdjustPoolrateService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 调商品扣率搜索
        /// <summary>
        /// 调商品扣率搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbAdjustPoolrateList(SearchDtoBase<FbAdjustPoolrate> c, FbAdjustPoolrate s)
        {
            c.entity = s;
            return Json(FbAdjustPoolrateService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 调商品扣率删除
        /// <summary>
        /// 调商品扣率删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbAdjustPoolrateDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbAdjustPoolrateService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  调商品扣率

        #region 调商品扣率商品明细
        public IFbAdjustPoolrateGoodsService FbAdjustPoolrateGoodsService { get; set; }
        #region 调商品扣率商品明细编辑页面
        /// <summary>
        /// 调商品扣率商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbAdjustPoolrateGoodsEdit(string id)
        {
            FbAdjustPoolrateGoods m = FbAdjustPoolrateGoods.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbAdjustPoolrateGoodsService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 调商品扣率商品明细列表页面
        /// <summary>
        /// 调商品扣率商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbAdjustPoolrateGoodsList()
        {
            return View();
        }
        #endregion

        #region 调商品扣率商品明细保存程序
        /// <summary>
        /// 调商品扣率商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbAdjustPoolrateGoods(FbAdjustPoolrateGoods m)
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
                    FbAdjustPoolrateGoodsService.Update(m);
                }
                else
                {
                    FbAdjustPoolrateGoodsService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 调商品扣率商品明细搜索
        /// <summary>
        /// 调商品扣率商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbAdjustPoolrateGoodsList(SearchDtoBase<FbAdjustPoolrateGoods> c, FbAdjustPoolrateGoods s)
        {
            c.entity = s;
            return Json(FbAdjustPoolrateGoodsService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 调商品扣率商品明细删除
        /// <summary>
        /// 调商品扣率商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbAdjustPoolrateGoodsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbAdjustPoolrateGoodsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  调商品扣率商品明细

        #region 调商品进价
        public IFbAdjustPurchasepriceService FbAdjustPurchasepriceService { get; set; }
        #region 调商品进价编辑页面
        /// <summary>
        /// 调商品进价编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbAdjustPurchasepriceEdit(string id)
        {
            FbAdjustPurchaseprice m = FbAdjustPurchaseprice.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbAdjustPurchasepriceService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 调商品进价列表页面
        /// <summary>
        /// 调商品进价列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbAdjustPurchasepriceList()
        {
            return View();
        }
        #endregion

        #region 调商品进价保存程序
        /// <summary>
        /// 调商品进价保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbAdjustPurchaseprice(FbAdjustPurchaseprice m)
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
                    FbAdjustPurchasepriceService.Update(m);
                }
                else
                {
                    FbAdjustPurchasepriceService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 调商品进价搜索
        /// <summary>
        /// 调商品进价搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbAdjustPurchasepriceList(SearchDtoBase<FbAdjustPurchaseprice> c, FbAdjustPurchaseprice s)
        {
            c.entity = s;
            return Json(FbAdjustPurchasepriceService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 调商品进价删除
        /// <summary>
        /// 调商品进价删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbAdjustPurchasepriceDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbAdjustPurchasepriceService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  调商品进价

        #region 调商品进价商品明细
        public IFbAdjustPurchasepriceGoodsService FbAdjustPurchasepriceGoodsService { get; set; }
        #region 调商品进价商品明细编辑页面
        /// <summary>
        /// 调商品进价商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbAdjustPurchasepriceGoodsEdit(string id)
        {
            FbAdjustPurchasepriceGoods m = FbAdjustPurchasepriceGoods.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbAdjustPurchasepriceGoodsService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 调商品进价商品明细列表页面
        /// <summary>
        /// 调商品进价商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbAdjustPurchasepriceGoodsList()
        {
            return View();
        }
        #endregion

        #region 调商品进价商品明细保存程序
        /// <summary>
        /// 调商品进价商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbAdjustPurchasepriceGoods(FbAdjustPurchasepriceGoods m)
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
                    FbAdjustPurchasepriceGoodsService.Update(m);
                }
                else
                {
                    FbAdjustPurchasepriceGoodsService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 调商品进价商品明细搜索
        /// <summary>
        /// 调商品进价商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbAdjustPurchasepriceGoodsList(SearchDtoBase<FbAdjustPurchasepriceGoods> c, FbAdjustPurchasepriceGoods s)
        {
            c.entity = s;
            return Json(FbAdjustPurchasepriceGoodsService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 调商品进价商品明细删除
        /// <summary>
        /// 调商品进价商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbAdjustPurchasepriceGoodsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbAdjustPurchasepriceGoodsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  调商品进价商品明细

        #region 调商品售价
        public IFbAdjustSalepriceService FbAdjustSalepriceService { get; set; }
        #region 调商品售价编辑页面
        /// <summary>
        /// 调商品售价编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbAdjustSalepriceEdit(string id)
        {
            FbAdjustSaleprice m = FbAdjustSaleprice.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbAdjustSalepriceService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 调商品售价列表页面
        /// <summary>
        /// 调商品售价列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbAdjustSalepriceList()
        {
            return View();
        }
        #endregion

        #region 调商品售价保存程序
        /// <summary>
        /// 调商品售价保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbAdjustSaleprice(FbAdjustSaleprice m)
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
                    FbAdjustSalepriceService.Update(m);
                }
                else
                {
                    FbAdjustSalepriceService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 调商品售价搜索
        /// <summary>
        /// 调商品售价搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbAdjustSalepriceList(SearchDtoBase<FbAdjustSaleprice> c, FbAdjustSaleprice s)
        {
            c.entity = s;
            return Json(FbAdjustSalepriceService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 调商品售价删除
        /// <summary>
        /// 调商品售价删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbAdjustSalepriceDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbAdjustSalepriceService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  调商品售价

        #region 调商品售价商品明细
        public IFbAdjustSalepriceGoodsService FbAdjustSalepriceGoodsService { get; set; }
        #region 调商品售价商品明细编辑页面
        /// <summary>
        /// 调商品售价商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbAdjustSalepriceGoodsEdit(string id)
        {
            FbAdjustSalepriceGoods m = FbAdjustSalepriceGoods.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbAdjustSalepriceGoodsService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 调商品售价商品明细列表页面
        /// <summary>
        /// 调商品售价商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbAdjustSalepriceGoodsList()
        {
            return View();
        }
        #endregion

        #region 调商品售价商品明细保存程序
        /// <summary>
        /// 调商品售价商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbAdjustSalepriceGoods(FbAdjustSalepriceGoods m)
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
                    FbAdjustSalepriceGoodsService.Update(m);
                }
                else
                {
                    FbAdjustSalepriceGoodsService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 调商品售价商品明细搜索
        /// <summary>
        /// 调商品售价商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbAdjustSalepriceGoodsList(SearchDtoBase<FbAdjustSalepriceGoods> c, FbAdjustSalepriceGoods s)
        {
            c.entity = s;
            return Json(FbAdjustSalepriceGoodsService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 调商品售价商品明细删除
        /// <summary>
        /// 调商品售价商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbAdjustSalepriceGoodsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbAdjustSalepriceGoodsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  调商品售价商品明细

        #region 调商品供货商
        public IFbAdjustSupplierService FbAdjustSupplierService { get; set; }
        #region 调商品供货商编辑页面
        /// <summary>
        /// 调商品供货商编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbAdjustSupplierEdit(string id)
        {
            FbAdjustSupplier m = FbAdjustSupplier.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbAdjustSupplierService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 调商品供货商列表页面
        /// <summary>
        /// 调商品供货商列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbAdjustSupplierList()
        {
            return View();
        }
        #endregion

        #region 调商品供货商保存程序
        /// <summary>
        /// 调商品供货商保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbAdjustSupplier(FbAdjustSupplier m)
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
                    FbAdjustSupplierService.Update(m);
                }
                else
                {
                    FbAdjustSupplierService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 调商品供货商搜索
        /// <summary>
        /// 调商品供货商搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbAdjustSupplierList(SearchDtoBase<FbAdjustSupplier> c, FbAdjustSupplier s)
        {
            c.entity = s;
            return Json(FbAdjustSupplierService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 调商品供货商删除
        /// <summary>
        /// 调商品供货商删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbAdjustSupplierDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbAdjustSupplierService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  调商品供货商

        #region 调商品供货商商品明细
        public IFbAdjustSupplierGoodsService FbAdjustSupplierGoodsService { get; set; }
        #region 调商品供货商商品明细编辑页面
        /// <summary>
        /// 调商品供货商商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbAdjustSupplierGoodsEdit(string id)
        {
            FbAdjustSupplierGoods m = FbAdjustSupplierGoods.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbAdjustSupplierGoodsService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 调商品供货商商品明细列表页面
        /// <summary>
        /// 调商品供货商商品明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbAdjustSupplierGoodsList()
        {
            return View();
        }
        #endregion

        #region 调商品供货商商品明细保存程序
        /// <summary>
        /// 调商品供货商商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbAdjustSupplierGoods(FbAdjustSupplierGoods m)
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
                    FbAdjustSupplierGoodsService.Update(m);
                }
                else
                {
                    FbAdjustSupplierGoodsService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 调商品供货商商品明细搜索
        /// <summary>
        /// 调商品供货商商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbAdjustSupplierGoodsList(SearchDtoBase<FbAdjustSupplierGoods> c, FbAdjustSupplierGoods s)
        {
            c.entity = s;
            return Json(FbAdjustSupplierGoodsService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 调商品供货商商品明细删除
        /// <summary>
        /// 调商品供货商商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbAdjustSupplierGoodsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbAdjustSupplierGoodsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  调商品供货商商品明细

        #region 商品档案
        public IFbGoodsArchivesService FbGoodsArchivesService { get; set; }
        #region 商品档案编辑页面
        /// <summary>
        /// 商品档案编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbGoodsArchivesEdit(string id)
        {
            FbGoodsArchives m = FbGoodsArchives.Initial();
            
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbGoodsArchivesService.GetById(id);
                m._state = "modified";
            }
            else
            {
                m.GoodsSubCode = FbGoodsArchives.GenerateSubCode();
                m._state = "added";
            }
            return View(m);
        }
        #endregion

        #region 生成商品简码
        /// <summary>
        /// 生成商品简码
        /// </summary>
        /// <returns></returns>
        public ActionResult GenerateGoodsId()
        {
            FbGoodsArchives m = FbGoodsArchives.Initial();
            m.GoodsSubCode = FbGoodsArchives.GenerateSubCode();
            return Json(m, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品档案列表页面
        /// <summary>
        /// 商品档案列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbGoodsArchivesList()
        {
            return View();
        }
        #endregion

        #region 商品档案保存程序
        /// <summary>
        /// 商品档案保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbGoodsArchives(FbGoodsArchives m)
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
                FbGoodsArchivesService.SaveOrUpdate(m);

                var jser = new JavaScriptSerializer();
                var suppliers = jser.Deserialize<List<FbGoodsArchivesSupplier>>(Request["suppliers"]);
                var saleCodes = jser.Deserialize<List<FbGoodsArchivesBar>>(Request["saleCode"]);
                var binding = jser.Deserialize<List<FbGoodsArchivesBind>>(Request["binding"]);
                var images = jser.Deserialize<List<FbGoodsArchivesPhoto>>(Request["images"]);

                foreach (var item in suppliers)
                {
                    if (string.IsNullOrEmpty(item.SupCode))
                    {
                        continue;
                    }
                    if (item.IsAdded)
                    {
                        item.GoodsCode = m.Id;
                        FbGoodsArchivesSupplierService.Create(item);
                    }
                    if (item.IsDelete)
                    {
                        FbGoodsArchivesSupplierService.Delete(item);
                    }
                    if (item.IsUpdated)
                    {
                        FbGoodsArchivesSupplierService.Update(item);
                    }
                }
                foreach (var item in saleCodes)
                {
                    if (string.IsNullOrEmpty(item.GoodsBarCode))
                    {
                        continue;
                    }
                    if (item.IsAdded)
                    {
                        item.GoodsCode = m.Id;
                        FbGoodsArchivesBarService.Create(item);
                    }
                    if (item.IsDelete)
                    {
                        FbGoodsArchivesBarService.Delete(item);
                    }
                    if (item.IsUpdated)
                    {
                        FbGoodsArchivesBarService.Update(item);
                    }
                }
                foreach (var item in binding)
                {
                    if (string.IsNullOrEmpty(item.GoodsCodeBind))
                    {
                        continue;
                    }
                    if (item.IsAdded)
                    {
                        item.GoodsCode = m.Id;
                        FbGoodsArchivesBindService.Create(item);
                    }
                    if (item.IsDelete)
                    {
                        FbGoodsArchivesBindService.Delete(item);
                    }
                    if (item.IsUpdated)
                    {
                        FbGoodsArchivesBindService.Update(item);
                    }
                }
                foreach (var item in images)
                {
                    if (string.IsNullOrEmpty(item.PhotoType))
                    {
                        continue;
                    }
                    if (item.IsAdded)
                    {
                        item.GoodsCode = m.Id;
                        FbGoodsArchivesPhotoService.Create(item);
                    }
                    if (item.IsDelete)
                    {
                        FbGoodsArchivesPhotoService.Delete(item);
                    }
                    if (item.IsUpdated)
                    {
                        FbGoodsArchivesPhotoService.Update(item);
                    }
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品档案搜索
        /// <summary>
        /// 商品档案搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbGoodsArchivesList(SearchDtoBase<FbGoodsArchives> c, FbGoodsArchives s)
        {
            c.entity = s;
            return Json(FbGoodsArchivesService.Search(c), JsonRequestBehavior.AllowGet);
        }

        public JsonResult SearchFbGoodsArchivesListForList(SearchDtoBase<FbGoodsArchives> c, FbGoodsArchives s)
        {
            c.entity = s;
            return Json(FbGoodsArchivesService.Search(c).data, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品档案删除
        /// <summary>
        /// 商品档案删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbGoodsArchivesDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbGoodsArchivesService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品档案

        #region 商品销售码
        public IFbGoodsArchivesBarService FbGoodsArchivesBarService { get; set; }
        #region 商品销售码编辑页面
        /// <summary>
        /// 商品销售码编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbGoodsArchivesBarEdit(string id)
        {
            FbGoodsArchivesBar m = FbGoodsArchivesBar.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbGoodsArchivesBarService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品销售码列表页面
        /// <summary>
        /// 商品销售码列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbGoodsArchivesBarList()
        {
            return View();
        }
        #endregion

        #region 商品销售码保存程序
        /// <summary>
        /// 商品销售码保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbGoodsArchivesBar(FbGoodsArchivesBar m)
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
                    FbGoodsArchivesBarService.Update(m);
                }
                else
                {
                    FbGoodsArchivesBarService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品销售码搜索
        /// <summary>
        /// 商品销售码搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbGoodsArchivesBarList(SearchDtoBase<FbGoodsArchivesBar> c, FbGoodsArchivesBar s)
        {
            c.entity = s;
            return Json(FbGoodsArchivesBarService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品销售码删除
        /// <summary>
        /// 商品销售码删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbGoodsArchivesBarDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbGoodsArchivesBarService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品销售码

        #region 商品捆绑
        public IFbGoodsArchivesBindService FbGoodsArchivesBindService { get; set; }
        #region 商品捆绑编辑页面
        /// <summary>
        /// 商品捆绑编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbGoodsArchivesBindEdit(string id)
        {
            FbGoodsArchivesBind m = FbGoodsArchivesBind.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbGoodsArchivesBindService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品捆绑列表页面
        /// <summary>
        /// 商品捆绑列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbGoodsArchivesBindList()
        {
            return View();
        }
        #endregion

        #region 商品捆绑保存程序
        /// <summary>
        /// 商品捆绑保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbGoodsArchivesBind(FbGoodsArchivesBind m)
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
                    FbGoodsArchivesBindService.Update(m);
                }
                else
                {
                    FbGoodsArchivesBindService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品捆绑搜索
        /// <summary>
        /// 商品捆绑搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbGoodsArchivesBindList(SearchDtoBase<FbGoodsArchivesBind> c, FbGoodsArchivesBind s)
        {
            c.entity = s;
            return Json(FbGoodsArchivesBindService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品捆绑删除
        /// <summary>
        /// 商品捆绑删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbGoodsArchivesBindDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbGoodsArchivesBindService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品捆绑

        #region 商品条码库
        public IFbGoodsArchivesLibraryService FbGoodsArchivesLibraryService { get; set; }
        #region 商品条码库编辑页面
        /// <summary>
        /// 商品条码库编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbGoodsArchivesLibraryEdit(string id)
        {
            FbGoodsArchivesLibrary m = FbGoodsArchivesLibrary.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbGoodsArchivesLibraryService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品条码库列表页面
        /// <summary>
        /// 商品条码库列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbGoodsArchivesLibraryList()
        {
            return View();
        }
        #endregion

        #region 商品条码库保存程序
        /// <summary>
        /// 商品条码库保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbGoodsArchivesLibrary(FbGoodsArchivesLibrary m)
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
                    FbGoodsArchivesLibraryService.Update(m);
                }
                else
                {
                    FbGoodsArchivesLibraryService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品条码库搜索
        /// <summary>
        /// 商品条码库搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbGoodsArchivesLibraryList(SearchDtoBase<FbGoodsArchivesLibrary> c, FbGoodsArchivesLibrary s)
        {
            c.entity = s;
            return Json(FbGoodsArchivesLibraryService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品条码库删除
        /// <summary>
        /// 商品条码库删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbGoodsArchivesLibraryDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbGoodsArchivesLibraryService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品条码库

        #region 商品部件
        public IFbGoodsArchivesPartsService FbGoodsArchivesPartsService { get; set; }
        #region 商品部件编辑页面
        /// <summary>
        /// 商品部件编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbGoodsArchivesPartsEdit(string id)
        {
            FbGoodsArchivesParts m = FbGoodsArchivesParts.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbGoodsArchivesPartsService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品部件列表页面
        /// <summary>
        /// 商品部件列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbGoodsArchivesPartsList()
        {
            return View();
        }
        #endregion

        #region 商品部件保存程序
        /// <summary>
        /// 商品部件保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbGoodsArchivesParts(FbGoodsArchivesParts m)
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
                    FbGoodsArchivesPartsService.Update(m);
                }
                else
                {
                    FbGoodsArchivesPartsService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品部件搜索
        /// <summary>
        /// 商品部件搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbGoodsArchivesPartsList(SearchDtoBase<FbGoodsArchivesParts> c, FbGoodsArchivesParts s)
        {
            c.entity = s;
            return Json(FbGoodsArchivesPartsService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品部件删除
        /// <summary>
        /// 商品部件删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbGoodsArchivesPartsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbGoodsArchivesPartsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品部件

        #region 商品视图表
        public IFbGoodsArchivesPhotoService FbGoodsArchivesPhotoService { get; set; }
        #region 商品视图表编辑页面
        /// <summary>
        /// 商品视图表编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbGoodsArchivesPhotoEdit(string id)
        {
            FbGoodsArchivesPhoto m = FbGoodsArchivesPhoto.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbGoodsArchivesPhotoService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品视图表列表页面
        /// <summary>
        /// 商品视图表列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbGoodsArchivesPhotoList()
        {
            return View();
        }
        #endregion

        #region 商品视图表保存程序
        /// <summary>
        /// 商品视图表保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbGoodsArchivesPhoto(FbGoodsArchivesPhoto m)
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
                    FbGoodsArchivesPhotoService.Update(m);
                }
                else
                {
                    FbGoodsArchivesPhotoService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品视图表搜索
        /// <summary>
        /// 商品视图表搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbGoodsArchivesPhotoList(SearchDtoBase<FbGoodsArchivesPhoto> c, FbGoodsArchivesPhoto s)
        {
            c.entity = s;
            return Json(FbGoodsArchivesPhotoService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品视图表删除
        /// <summary>
        /// 商品视图表删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbGoodsArchivesPhotoDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbGoodsArchivesPhotoService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品视图表

        #region 商品供货商
        public IFbGoodsArchivesSupplierService FbGoodsArchivesSupplierService { get; set; }
        #region 商品供货商编辑页面
        /// <summary>
        /// 商品供货商编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbGoodsArchivesSupplierEdit(string id)
        {
            FbGoodsArchivesSupplier m = FbGoodsArchivesSupplier.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbGoodsArchivesSupplierService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 商品供货商列表页面
        /// <summary>
        /// 商品供货商列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbGoodsArchivesSupplierList()
        {
            return View();
        }
        #endregion

        #region 商品供货商保存程序
        /// <summary>
        /// 商品供货商保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbGoodsArchivesSupplier(FbGoodsArchivesSupplier m)
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
                    FbGoodsArchivesSupplierService.Update(m);
                }
                else
                {
                    FbGoodsArchivesSupplierService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品供货商搜索
        /// <summary>
        /// 商品供货商搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbGoodsArchivesSupplierList(SearchDtoBase<FbGoodsArchivesSupplier> c, FbGoodsArchivesSupplier s)
        {
            c.entity = s;
            return Json(FbGoodsArchivesSupplierService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品供货商删除
        /// <summary>
        /// 商品供货商删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbGoodsArchivesSupplierDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbGoodsArchivesSupplierService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品供货商

        #region 销售编码表
        public IFbGoodsBarCodeService FbGoodsBarCodeService { get; set; }
        #region 销售编码表编辑页面
        /// <summary>
        /// 销售编码表编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbGoodsBarCodeEdit(string id)
        {
            FbGoodsBarCode m = FbGoodsBarCode.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbGoodsBarCodeService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 销售编码表列表页面
        /// <summary>
        /// 销售编码表列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbGoodsBarCodeList()
        {
            return View();
        }
        #endregion

        #region 销售编码表保存程序
        /// <summary>
        /// 销售编码表保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbGoodsBarCode(FbGoodsBarCode m)
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
                    FbGoodsBarCodeService.Update(m);
                }
                else
                {
                    FbGoodsBarCodeService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 销售编码表搜索
        /// <summary>
        /// 销售编码表搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbGoodsBarCodeList(SearchDtoBase<FbGoodsBarCode> c, FbGoodsBarCode s)
        {
            c.entity = s;
            return Json(FbGoodsBarCodeService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 销售编码表删除
        /// <summary>
        /// 销售编码表删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbGoodsBarCodeDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbGoodsBarCodeService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  销售编码表

        #region 基础参数设置
        public IFbPaBaseSetService FbPaBaseSetService { get; set; }
        #region 基础参数设置编辑页面
        /// <summary>
        /// 基础参数设置编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbPaBaseSetEdit(string id)
        {
            FbPaBaseSet m = FbPaBaseSet.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbPaBaseSetService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 基础参数设置列表页面
        /// <summary>
        /// 基础参数设置列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbPaBaseSetList()
        {
            return View();
        }
        #endregion

        #region 基础参数设置保存程序
        /// <summary>
        /// 基础参数设置保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbPaBaseSet(FbPaBaseSet m)
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
                    FbPaBaseSetService.Update(m);
                }
                else
                {
                    FbPaBaseSetService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 基础参数设置搜索
        /// <summary>
        /// 基础参数设置搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbPaBaseSetList(SearchDtoBase<FbPaBaseSet> c, FbPaBaseSet s)
        {
            c.entity = s;
            return Json(FbPaBaseSetService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 基础参数设置删除
        /// <summary>
        /// 基础参数设置删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbPaBaseSetDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbPaBaseSetService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  基础参数设置

        #region 品牌编码
        public IFbPaGoodsBrandService FbPaGoodsBrandService { get; set; }
        #region 品牌编码编辑页面
        /// <summary>
        /// 品牌编码编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbPaGoodsBrandEdit(string id)
        {
            FbPaGoodsBrand m = FbPaGoodsBrand.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbPaGoodsBrandService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 品牌编码列表页面
        /// <summary>
        /// 品牌编码列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbPaGoodsBrandList()
        {
            return View();
        }
        #endregion

        #region 品牌编码保存程序
        /// <summary>
        /// 品牌编码保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbPaGoodsBrand(FbPaGoodsBrand m)
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
                    FbPaGoodsBrandService.Update(m);
                }
                else
                {
                    FbPaGoodsBrandService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 品牌编码搜索
        /// <summary>
        /// 品牌编码搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbPaGoodsBrandList(SearchDtoBase<FbPaGoodsBrand> c, FbPaGoodsBrand s)
        {
            c.entity = s;
            return Json(FbPaGoodsBrandService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 品牌编码删除
        /// <summary>
        /// 品牌编码删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbPaGoodsBrandDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbPaGoodsBrandService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  品牌编码

        #region 核算单位编码
        public IFbPaGoodsCheckUnitService FbPaGoodsCheckUnitService { get; set; }
        #region 核算单位编码编辑页面
        /// <summary>
        /// 核算单位编码编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbPaGoodsCheckUnitEdit(string id)
        {
            FbPaGoodsCheckUnit m = FbPaGoodsCheckUnit.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbPaGoodsCheckUnitService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 核算单位编码列表页面
        /// <summary>
        /// 核算单位编码列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbPaGoodsCheckUnitList()
        {
            return View();
        }
        #endregion

        #region 核算单位编码保存程序
        /// <summary>
        /// 核算单位编码保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbPaGoodsCheckUnit(FbPaGoodsCheckUnit m)
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
                    FbPaGoodsCheckUnitService.Update(m);
                }
                else
                {
                    FbPaGoodsCheckUnitService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 核算单位编码搜索
        /// <summary>
        /// 核算单位编码搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbPaGoodsCheckUnitList(SearchDtoBase<FbPaGoodsCheckUnit> c, FbPaGoodsCheckUnit s)
        {
            c.entity = s;
            return Json(FbPaGoodsCheckUnitService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 核算单位编码删除
        /// <summary>
        /// 核算单位编码删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbPaGoodsCheckUnitDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbPaGoodsCheckUnitService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  核算单位编码

        #region 柜组编码
        public IFbPaGoodsCounterService FbPaGoodsCounterService { get; set; }
        #region 柜组编码编辑页面
        /// <summary>
        /// 柜组编码编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbPaGoodsCounterEdit(string id)
        {
            FbPaGoodsCounter m = FbPaGoodsCounter.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbPaGoodsCounterService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 柜组编码列表页面
        /// <summary>
        /// 柜组编码列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbPaGoodsCounterList()
        {
            return View();
        }
        #endregion

        #region 柜组编码保存程序
        /// <summary>
        /// 柜组编码保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbPaGoodsCounter(FbPaGoodsCounter m)
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
                    FbPaGoodsCounterService.Update(m);
                }
                else
                {
                    FbPaGoodsCounterService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 柜组编码搜索
        /// <summary>
        /// 柜组编码搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbPaGoodsCounterList(SearchDtoBase<FbPaGoodsCounter> c, FbPaGoodsCounter s)
        {
            c.entity = s;
            return Json(FbPaGoodsCounterService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 柜组编码删除
        /// <summary>
        /// 柜组编码删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbPaGoodsCounterDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbPaGoodsCounterService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  柜组编码

        #region 大类编码
        public IFbPaGoodsGbService FbPaGoodsGbService { get; set; }
        #region 大类编码编辑页面
        /// <summary>
        /// 大类编码编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbPaGoodsGbEdit(string id)
        {
            FbPaGoodsGb m = new FbPaGoodsGb();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbPaGoodsGbService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 大类编码列表页面
        /// <summary>
        /// 大类编码列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbPaGoodsGbList()
        {
            return View();
        }
        #endregion

        #region 大类编码保存程序
        /// <summary>
        /// 大类编码保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbPaGoodsGb(FbPaGoodsGb m)
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
                    FbPaGoodsGbService.Update(m);
                }
                else
                {
                    FbPaGoodsGbService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 大类编码搜索
        /// <summary>
        /// 大类编码搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbPaGoodsGbList(SearchDtoBase<FbPaGoodsGb> c, FbPaGoodsGb s)
        {
            c.entity = s;
            return Json(FbPaGoodsGbService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 大类编码删除
        /// <summary>
        /// 大类编码删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbPaGoodsGbDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbPaGoodsGbService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  大类编码

        #region 细类编码
        public IFbPaGoodsGlService FbPaGoodsGlService { get; set; }
        #region 细类编码编辑页面
        /// <summary>
        /// 细类编码编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbPaGoodsGlEdit(string id)
        {
            FbPaGoodsGl m = FbPaGoodsGl.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbPaGoodsGlService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 细类编码列表页面
        /// <summary>
        /// 细类编码列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbPaGoodsGlList()
        {
            return View();
        }
        #endregion

        #region 细类编码保存程序
        /// <summary>
        /// 细类编码保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbPaGoodsGl(FbPaGoodsGl m)
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
                    FbPaGoodsGlService.Update(m);
                }
                else
                {
                    FbPaGoodsGlService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 细类编码搜索
        /// <summary>
        /// 细类编码搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbPaGoodsGlList(SearchDtoBase<FbPaGoodsGl> c, FbPaGoodsGl s)
        {
            c.entity = s;
            return Json(FbPaGoodsGlService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 细类编码删除
        /// <summary>
        /// 细类编码删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbPaGoodsGlDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbPaGoodsGlService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  细类编码

        #region 中类编码
        public IFbPaGoodsGmService FbPaGoodsGmService { get; set; }
        #region 中类编码编辑页面
        /// <summary>
        /// 中类编码编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbPaGoodsGmEdit(string id)
        {
            FbPaGoodsGm m = FbPaGoodsGm.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbPaGoodsGmService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 中类编码列表页面
        /// <summary>
        /// 中类编码列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbPaGoodsGmList()
        {
            return View();
        }
        #endregion

        #region 中类编码保存程序
        /// <summary>
        /// 中类编码保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbPaGoodsGm(FbPaGoodsGm m)
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
                    FbPaGoodsGmService.Update(m);
                }
                else
                {
                    FbPaGoodsGmService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 中类编码搜索
        /// <summary>
        /// 中类编码搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbPaGoodsGmList(SearchDtoBase<FbPaGoodsGm> c, FbPaGoodsGm s)
        {
            c.entity = s;
            return Json(FbPaGoodsGmService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 中类编码删除
        /// <summary>
        /// 中类编码删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbPaGoodsGmDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbPaGoodsGmService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  中类编码

        #region 小类编码
        public IFbPaGoodsGsService FbPaGoodsGsService { get; set; }
        #region 小类编码编辑页面
        /// <summary>
        /// 小类编码编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbPaGoodsGsEdit(string id)
        {
            FbPaGoodsGs m = FbPaGoodsGs.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbPaGoodsGsService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 小类编码列表页面
        /// <summary>
        /// 小类编码列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbPaGoodsGsList()
        {
            return View();
        }
        #endregion

        #region 小类编码保存程序
        /// <summary>
        /// 小类编码保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbPaGoodsGs(FbPaGoodsGs m)
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
                    FbPaGoodsGsService.Update(m);
                }
                else
                {
                    FbPaGoodsGsService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 小类编码搜索
        /// <summary>
        /// 小类编码搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbPaGoodsGsList(SearchDtoBase<FbPaGoodsGs> c, FbPaGoodsGs s)
        {
            c.entity = s;
            return Json(FbPaGoodsGsService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 小类编码删除
        /// <summary>
        /// 小类编码删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbPaGoodsGsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbPaGoodsGsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  小类编码

        #region 包装单位编码
        public IFbPaGoodsPackUnitService FbPaGoodsPackUnitService { get; set; }
        #region 包装单位编码编辑页面
        /// <summary>
        /// 包装单位编码编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbPaGoodsPackUnitEdit(string id)
        {
            FbPaGoodsPackUnit m = FbPaGoodsPackUnit.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbPaGoodsPackUnitService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 包装单位编码列表页面
        /// <summary>
        /// 包装单位编码列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbPaGoodsPackUnitList()
        {
            return View();
        }
        #endregion

        #region 包装单位编码保存程序
        /// <summary>
        /// 包装单位编码保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbPaGoodsPackUnit(FbPaGoodsPackUnit m)
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
                    FbPaGoodsPackUnitService.Update(m);
                }
                else
                {
                    FbPaGoodsPackUnitService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 包装单位编码搜索
        /// <summary>
        /// 包装单位编码搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbPaGoodsPackUnitList(SearchDtoBase<FbPaGoodsPackUnit> c, FbPaGoodsPackUnit s)
        {
            c.entity = s;
            return Json(FbPaGoodsPackUnitService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 包装单位编码删除
        /// <summary>
        /// 包装单位编码删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbPaGoodsPackUnitDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbPaGoodsPackUnitService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  包装单位编码

        #region 供货商类型
        public IFbPaSupTypeService FbPaSupTypeService { get; set; }
        #region 供货商类型编辑页面
        /// <summary>
        /// 供货商类型编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbPaSupTypeEdit(string id)
        {
            FbPaSupType m = FbPaSupType.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbPaSupTypeService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 供货商类型列表页面
        /// <summary>
        /// 供货商类型列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbPaSupTypeList()
        {
            return View();
        }
        #endregion

        #region 供货商类型保存程序
        /// <summary>
        /// 供货商类型保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbPaSupType(FbPaSupType m)
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
                    FbPaSupTypeService.Update(m);
                }
                else
                {
                    FbPaSupTypeService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 供货商类型搜索
        /// <summary>
        /// 供货商类型搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbPaSupTypeList(SearchDtoBase<FbPaSupType> c, FbPaSupType s)
        {
            c.entity = s;
            return Json(FbPaSupTypeService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 供货商类型删除
        /// <summary>
        /// 供货商类型删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbPaSupTypeDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbPaSupTypeService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  供货商类型

        #region 供货商档案
        public IFbSupplierArchivesService FbSupplierArchivesService { get; set; }
        #region 供货商档案编辑页面
        /// <summary>
        /// 供货商档案编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbSupplierArchivesEdit(string id)
        {
            FbSupplierArchives m = FbSupplierArchives.Initial();
            m.Id = null;
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbSupplierArchivesService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 供货商档案列表页面
        /// <summary>
        /// 供货商档案列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbSupplierArchivesList()
        {
            return View();
        }
        #endregion

        #region 供货商档案保存程序
        /// <summary>
        /// 供货商档案保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbSupplierArchives(FbSupplierArchives m)
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
                    FbSupplierArchivesService.Update(m);
                }
                else
                {
                    m.CreateDate = DateTime.Now;
                    FbSupplierArchivesService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 供货商档案搜索
        /// <summary>
        /// 供货商档案搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbSupplierArchivesList(SearchDtoBase<FbSupplierArchives> c, FbSupplierArchives s)
        {
            c.entity = s;
            return Json(FbSupplierArchivesService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 供货商档案删除
        /// <summary>
        /// 供货商档案删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbSupplierArchivesDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbSupplierArchivesService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  供货商档案

        #region 供货商租赁合同
        public IFbSupplierLeaseService FbSupplierLeaseService { get; set; }
        #region 供货商租赁合同编辑页面
        /// <summary>
        /// 供货商租赁合同编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult FbSupplierLeaseEdit(string id)
        {
            FbSupplierLease m = FbSupplierLease.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbSupplierLeaseService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 供货商租赁合同列表页面
        /// <summary>
        /// 供货商租赁合同列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult FbSupplierLeaseList()
        {
            return View();
        }
        #endregion

        #region 供货商租赁合同保存程序
        /// <summary>
        /// 供货商租赁合同保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveFbSupplierLease(FbSupplierLease m)
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
                    FbSupplierLeaseService.Update(m);
                }
                else
                {
                    FbSupplierLeaseService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 供货商租赁合同搜索
        /// <summary>
        /// 供货商租赁合同搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchFbSupplierLeaseList(SearchDtoBase<FbSupplierLease> c, FbSupplierLease s)
        {
            c.entity = s;
            return Json(FbSupplierLeaseService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 供货商租赁合同删除
        /// <summary>
        /// 供货商租赁合同删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult FbSupplierLeaseDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            FbSupplierLeaseService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  供货商租赁合同
    }
}





