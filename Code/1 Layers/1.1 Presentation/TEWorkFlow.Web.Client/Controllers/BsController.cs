
using NSH.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiQiWorkFlow.Application.Service.Bs;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace TEWorkFlow.Web.Client.Controllers
{
    public class BsController : Controller
    {

        #region 分店商品调价
        public IBsAdjustSalepriceService BsAdjustSalepriceService { get; set; }
        #region 分店商品调价编辑页面
        /// <summary>
        /// 分店商品调价编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BsAdjustSalepriceEdit(string id)
        {
            BsAdjustSaleprice m = BsAdjustSaleprice.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BsAdjustSalepriceService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店商品调价保存程序
        /// <summary>
        /// 分店商品调价保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBsAdjustSaleprice(BsAdjustSaleprice m)
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
                    BsAdjustSalepriceService.Update(m);
                }
                else
                {
                    BsAdjustSalepriceService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店商品调价搜索
        /// <summary>
        /// 分店商品调价搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBsAdjustSalepriceList(SearchDtoBase<BsAdjustSaleprice> c, BsAdjustSaleprice s)
        {
            c.entity = s;
            return Json(BsAdjustSalepriceService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店商品调价删除
        /// <summary>
        /// 分店商品调价删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BsAdjustSalepriceDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BsAdjustSalepriceService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店商品调价

        #region 分店商品调价商品明细
        public IBsAdjustSalepriceGoodsService BsAdjustSalepriceGoodsService { get; set; }
        #region 分店商品调价商品明细编辑页面
        /// <summary>
        /// 分店商品调价商品明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BsAdjustSalepriceGoodsEdit(string id)
        {
            BsAdjustSalepriceGoods m = BsAdjustSalepriceGoods.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BsAdjustSalepriceGoodsService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店商品调价商品明细保存程序
        /// <summary>
        /// 分店商品调价商品明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBsAdjustSalepriceGoods(BsAdjustSalepriceGoods m)
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
                    BsAdjustSalepriceGoodsService.Update(m);
                }
                else
                {
                    BsAdjustSalepriceGoodsService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店商品调价商品明细搜索
        /// <summary>
        /// 分店商品调价商品明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBsAdjustSalepriceGoodsList(SearchDtoBase<BsAdjustSalepriceGoods> c, BsAdjustSalepriceGoods s)
        {
            c.entity = s;
            return Json(BsAdjustSalepriceGoodsService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店商品调价商品明细删除
        /// <summary>
        /// 分店商品调价商品明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BsAdjustSalepriceGoodsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BsAdjustSalepriceGoodsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店商品调价商品明细

        #region 分店调拨商品
        public IBsBranchAllotDetailService BsBranchAllotDetailService { get; set; }
        #region 分店调拨商品编辑页面
        /// <summary>
        /// 分店调拨商品编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BsBranchAllotDetailEdit(string id)
        {
            BsBranchAllotDetail m = BsBranchAllotDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BsBranchAllotDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店调拨商品保存程序
        /// <summary>
        /// 分店调拨商品保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBsBranchAllotDetail(BsBranchAllotDetail m)
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
                    BsBranchAllotDetailService.Update(m);
                }
                else
                {
                    BsBranchAllotDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店调拨商品搜索
        /// <summary>
        /// 分店调拨商品搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBsBranchAllotDetailList(SearchDtoBase<BsBranchAllotDetail> c, BsBranchAllotDetail s)
        {
            c.entity = s;
            return Json(BsBranchAllotDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店调拨商品删除
        /// <summary>
        /// 分店调拨商品删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BsBranchAllotDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BsBranchAllotDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店调拨商品

        #region 分店调拨
        public IBsBranchAllotManageService BsBranchAllotManageService { get; set; }
        #region 分店调拨编辑页面
        /// <summary>
        /// 分店调拨编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BsBranchAllotManageEdit(string id)
        {
            BsBranchAllotManage m = BsBranchAllotManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BsBranchAllotManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店调拨保存程序
        /// <summary>
        /// 分店调拨保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBsBranchAllotManage(BsBranchAllotManage m)
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
                    BsBranchAllotManageService.Update(m);
                }
                else
                {
                    BsBranchAllotManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店调拨搜索
        /// <summary>
        /// 分店调拨搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBsBranchAllotManageList(SearchDtoBase<BsBranchAllotManage> c, BsBranchAllotManage s)
        {
            c.entity = s;
            return Json(BsBranchAllotManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店调拨删除
        /// <summary>
        /// 分店调拨删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BsBranchAllotManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BsBranchAllotManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店调拨

        #region 分店档案管理
        public IBsBranchArchivesService BsBranchArchivesService { get; set; }
        #region 分店档案管理编辑页面
        /// <summary>
        /// 分店档案管理编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BsBranchArchivesEdit(string id)
        {
            BsBranchArchives m = BsBranchArchives.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BsBranchArchivesService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店档案管理保存程序
        /// <summary>
        /// 分店档案管理保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBsBranchArchives(BsBranchArchives m)
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
                    BsBranchArchivesService.Update(m);
                }
                else
                {
                    BsBranchArchivesService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店档案管理搜索
        /// <summary>
        /// 分店档案管理搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBsBranchArchivesList(SearchDtoBase<BsBranchArchives> c, BsBranchArchives s)
        {
            c.entity = s;
            return Json(BsBranchArchivesService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店档案管理删除
        /// <summary>
        /// 分店档案管理删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BsBranchArchivesDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BsBranchArchivesService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店档案管理

        #region 分店商品价格
        public IBsBranchPriceService BsBranchPriceService { get; set; }
        #region 分店商品价格编辑页面
        /// <summary>
        /// 分店商品价格编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BsBranchPriceEdit(string id)
        {
            BsBranchPrice m = BsBranchPrice.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BsBranchPriceService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店商品价格保存程序
        /// <summary>
        /// 分店商品价格保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBsBranchPrice(BsBranchPrice m)
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
                    BsBranchPriceService.Update(m);
                }
                else
                {
                    BsBranchPriceService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店商品价格搜索
        /// <summary>
        /// 分店商品价格搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBsBranchPriceList(SearchDtoBase<BsBranchPrice> c, BsBranchPrice s)
        {
            c.entity = s;
            return Json(BsBranchPriceService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店商品价格删除
        /// <summary>
        /// 分店商品价格删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BsBranchPriceDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BsBranchPriceService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店商品价格

        #region 分店区域
        public IBsPaAreaService BsPaAreaService { get; set; }
        #region 分店区域编辑页面
        /// <summary>
        /// 分店区域编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BsPaAreaEdit(string id)
        {
            BsPaArea m = BsPaArea.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BsPaAreaService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店区域保存程序
        /// <summary>
        /// 分店区域保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBsPaArea(BsPaArea m)
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
                    BsPaAreaService.Update(m);
                }
                else
                {
                    BsPaAreaService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店区域搜索
        /// <summary>
        /// 分店区域搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBsPaAreaList(SearchDtoBase<BsPaArea> c, BsPaArea s)
        {
            c.entity = s;
            return Json(BsPaAreaService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店区域删除
        /// <summary>
        /// 分店区域删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BsPaAreaDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BsPaAreaService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店区域

        #region 分店仓库设置
        public IBsPaBranchWarehouseService BsPaBranchWarehouseService { get; set; }
        #region 分店仓库设置编辑页面
        /// <summary>
        /// 分店仓库设置编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BsPaBranchWarehouseEdit(string id)
        {
            BsPaBranchWarehouse m = BsPaBranchWarehouse.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BsPaBranchWarehouseService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店仓库设置保存程序
        /// <summary>
        /// 分店仓库设置保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBsPaBranchWarehouse(BsPaBranchWarehouse m)
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
                    BsPaBranchWarehouseService.Update(m);
                }
                else
                {
                    BsPaBranchWarehouseService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店仓库设置搜索
        /// <summary>
        /// 分店仓库设置搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBsPaBranchWarehouseList(SearchDtoBase<BsPaBranchWarehouse> c, BsPaBranchWarehouse s)
        {
            c.entity = s;
            return Json(BsPaBranchWarehouseService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店仓库设置删除
        /// <summary>
        /// 分店仓库设置删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BsPaBranchWarehouseDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BsPaBranchWarehouseService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店仓库设置

        #region 分店分类
        public IBsPaClassService BsPaClassService { get; set; }
        #region 分店分类编辑页面
        /// <summary>
        /// 分店分类编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BsPaClassEdit(string id)
        {
            BsPaClass m = BsPaClass.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BsPaClassService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店分类保存程序
        /// <summary>
        /// 分店分类保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBsPaClass(BsPaClass m)
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
                    BsPaClassService.Update(m);
                }
                else
                {
                    BsPaClassService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店分类搜索
        /// <summary>
        /// 分店分类搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBsPaClassList(SearchDtoBase<BsPaClass> c, BsPaClass s)
        {
            c.entity = s;
            return Json(BsPaClassService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店分类删除
        /// <summary>
        /// 分店分类删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BsPaClassDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BsPaClassService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店分类

        #region 分店商品返货单明细
        public IBsReturnDetailService BsReturnDetailService { get; set; }
        #region 分店商品返货单明细编辑页面
        /// <summary>
        /// 分店商品返货单明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BsReturnDetailEdit(string id)
        {
            BsReturnDetail m = BsReturnDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BsReturnDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店商品返货单明细保存程序
        /// <summary>
        /// 分店商品返货单明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBsReturnDetail(BsReturnDetail m)
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
                    BsReturnDetailService.Update(m);
                }
                else
                {
                    BsReturnDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店商品返货单明细搜索
        /// <summary>
        /// 分店商品返货单明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBsReturnDetailList(SearchDtoBase<BsReturnDetail> c, BsReturnDetail s)
        {
            c.entity = s;
            return Json(BsReturnDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店商品返货单明细删除
        /// <summary>
        /// 分店商品返货单明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BsReturnDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BsReturnDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店商品返货单明细

        #region 分店商品返货单
        public IBsReturnManageService BsReturnManageService { get; set; }
        #region 分店商品返货单编辑页面
        /// <summary>
        /// 分店商品返货单编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BsReturnManageEdit(string id)
        {
            BsReturnManage m = BsReturnManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BsReturnManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店商品返货单保存程序
        /// <summary>
        /// 分店商品返货单保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBsReturnManage(BsReturnManage m)
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
                    BsReturnManageService.Update(m);
                }
                else
                {
                    BsReturnManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店商品返货单搜索
        /// <summary>
        /// 分店商品返货单搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBsReturnManageList(SearchDtoBase<BsReturnManage> c, BsReturnManage s)
        {
            c.entity = s;
            return Json(BsReturnManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店商品返货单删除
        /// <summary>
        /// 分店商品返货单删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BsReturnManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BsReturnManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店商品返货单

        #region 分店商品返货单流水
        public IBsReturnManageFlowService BsReturnManageFlowService { get; set; }
        #region 分店商品返货单流水编辑页面
        /// <summary>
        /// 分店商品返货单流水编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BsReturnManageFlowEdit(string id)
        {
            BsReturnManageFlow m = BsReturnManageFlow.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BsReturnManageFlowService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店商品返货单流水保存程序
        /// <summary>
        /// 分店商品返货单流水保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBsReturnManageFlow(BsReturnManageFlow m)
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
                    BsReturnManageFlowService.Update(m);
                }
                else
                {
                    BsReturnManageFlowService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店商品返货单流水搜索
        /// <summary>
        /// 分店商品返货单流水搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBsReturnManageFlowList(SearchDtoBase<BsReturnManageFlow> c, BsReturnManageFlow s)
        {
            c.entity = s;
            return Json(BsReturnManageFlowService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店商品返货单流水删除
        /// <summary>
        /// 分店商品返货单流水删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BsReturnManageFlowDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BsReturnManageFlowService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店商品返货单流水

        #region 分店订货配送单明细
        public IBsSupplyDetailService BsSupplyDetailService { get; set; }
        #region 分店订货配送单明细编辑页面
        /// <summary>
        /// 分店订货配送单明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BsSupplyDetailEdit(string id)
        {
            BsSupplyDetail m = BsSupplyDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BsSupplyDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店订货配送单明细保存程序
        /// <summary>
        /// 分店订货配送单明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBsSupplyDetail(BsSupplyDetail m)
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
                    BsSupplyDetailService.Update(m);
                }
                else
                {
                    BsSupplyDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店订货配送单明细搜索
        /// <summary>
        /// 分店订货配送单明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBsSupplyDetailList(SearchDtoBase<BsSupplyDetail> c, BsSupplyDetail s)
        {
            c.entity = s;
            return Json(BsSupplyDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店订货配送单明细删除
        /// <summary>
        /// 分店订货配送单明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BsSupplyDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BsSupplyDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店订货配送单明细

        #region 分店商品订货配送单
        public IBsSupplyManageService BsSupplyManageService { get; set; }
        #region 分店商品订货配送单编辑页面
        /// <summary>
        /// 分店商品订货配送单编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BsSupplyManageEdit(string id)
        {
            BsSupplyManage m = BsSupplyManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BsSupplyManageService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店商品订货配送单保存程序
        /// <summary>
        /// 分店商品订货配送单保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBsSupplyManage(BsSupplyManage m)
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
                    BsSupplyManageService.Update(m);
                }
                else
                {
                    BsSupplyManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店商品订货配送单搜索
        /// <summary>
        /// 分店商品订货配送单搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBsSupplyManageList(SearchDtoBase<BsSupplyManage> c, BsSupplyManage s)
        {
            c.entity = s;
            return Json(BsSupplyManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店商品订货配送单删除
        /// <summary>
        /// 分店商品订货配送单删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BsSupplyManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BsSupplyManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店商品订货配送单

        #region 分店商品订货配送单流水
        public IBsSupplyManageFlowService BsSupplyManageFlowService { get; set; }
        #region 分店商品订货配送单流水编辑页面
        /// <summary>
        /// 分店商品订货配送单流水编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult BsSupplyManageFlowEdit(string id)
        {
            BsSupplyManageFlow m = BsSupplyManageFlow.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = BsSupplyManageFlowService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 分店商品订货配送单流水保存程序
        /// <summary>
        /// 分店商品订货配送单流水保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveBsSupplyManageFlow(BsSupplyManageFlow m)
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
                    BsSupplyManageFlowService.Update(m);
                }
                else
                {
                    BsSupplyManageFlowService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 分店商品订货配送单流水搜索
        /// <summary>
        /// 分店商品订货配送单流水搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchBsSupplyManageFlowList(SearchDtoBase<BsSupplyManageFlow> c, BsSupplyManageFlow s)
        {
            c.entity = s;
            return Json(BsSupplyManageFlowService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 分店商品订货配送单流水删除
        /// <summary>
        /// 分店商品订货配送单流水删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult BsSupplyManageFlowDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            BsSupplyManageFlowService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  分店商品订货配送单流水
    }
}





