
using NSH.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiQiWorkFlow.Application.Service.Tf;
using YiQiWorkFlow.Domain.Tf;
using YiQiWorkFlow.Domain.Basement;

namespace TEWorkFlow.Web.Client.Controllers
{
    public class TfController : Controller
    {

        #region 通讯临时表
        public ITfDataDownloadService TfDataDownloadService { get; set; }
        #region 通讯临时表编辑页面
        /// <summary>
        /// 通讯临时表编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TfDataDownloadEdit(string id)
        {
            TfDataDownload m = TfDataDownload.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TfDataDownloadService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 通讯临时表保存程序
        /// <summary>
        /// 通讯临时表保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTfDataDownload(TfDataDownload m)
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
                    TfDataDownloadService.Update(m);
                }
                else
                {
                    TfDataDownloadService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 通讯临时表搜索
        /// <summary>
        /// 通讯临时表搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTfDataDownloadList(SearchDtoBase<TfDataDownload> c, TfDataDownload s)
        {
            c.entity = s;
            return Json(TfDataDownloadService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 通讯临时表删除
        /// <summary>
        /// 通讯临时表删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TfDataDownloadDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TfDataDownloadService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  通讯临时表

        #region 通讯配置表表名
        public ITfDataObjectService TfDataObjectService { get; set; }
        #region 通讯配置表表名编辑页面
        /// <summary>
        /// 通讯配置表表名编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TfDataObjectEdit(string id)
        {
            TfDataObject m = TfDataObject.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TfDataObjectService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 通讯配置表表名保存程序
        /// <summary>
        /// 通讯配置表表名保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTfDataObject(TfDataObject m)
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
                    TfDataObjectService.Update(m);
                }
                else
                {
                    TfDataObjectService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 通讯配置表表名搜索
        /// <summary>
        /// 通讯配置表表名搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTfDataObjectList(SearchDtoBase<TfDataObject> c, TfDataObject s)
        {
            c.entity = s;
            return Json(TfDataObjectService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 通讯配置表表名删除
        /// <summary>
        /// 通讯配置表表名删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TfDataObjectDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TfDataObjectService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  通讯配置表表名

        #region 通讯配置表字段
        public ITfDataPropertyService TfDataPropertyService { get; set; }
        #region 通讯配置表字段编辑页面
        /// <summary>
        /// 通讯配置表字段编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult TfDataPropertyEdit(string id)
        {
            TfDataProperty m = TfDataProperty.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = TfDataPropertyService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 通讯配置表字段保存程序
        /// <summary>
        /// 通讯配置表字段保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveTfDataProperty(TfDataProperty m)
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
                    TfDataPropertyService.Update(m);
                }
                else
                {
                    TfDataPropertyService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 通讯配置表字段搜索
        /// <summary>
        /// 通讯配置表字段搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchTfDataPropertyList(SearchDtoBase<TfDataProperty> c, TfDataProperty s)
        {
            c.entity = s;
            return Json(TfDataPropertyService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 通讯配置表字段删除
        /// <summary>
        /// 通讯配置表字段删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult TfDataPropertyDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            TfDataPropertyService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  通讯配置表字段
    }
}





