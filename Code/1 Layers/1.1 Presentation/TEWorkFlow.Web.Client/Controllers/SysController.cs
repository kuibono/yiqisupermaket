
using NSH.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiQiWorkFlow.Application.Service.Sys;
using YiQiWorkFlow.Domain.Sys;
using YiQiWorkFlow.Domain.Basement;

namespace TEWorkFlow.Web.Client.Controllers
{
    public class SysController : Controller
    {

        #region 类别权限设置
        public ISysClassPowerService SysClassPowerService { get; set; }
        #region 类别权限设置编辑页面
        /// <summary>
        /// 类别权限设置编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult SysClassPowerEdit(string id)
        {
            SysClassPower m = SysClassPower.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = SysClassPowerService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 类别权限设置保存程序
        /// <summary>
        /// 类别权限设置保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveSysClassPower(SysClassPower m)
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
                    SysClassPowerService.Update(m);
                }
                else
                {
                    SysClassPowerService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 类别权限设置搜索
        /// <summary>
        /// 类别权限设置搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchSysClassPowerList(SearchDtoBase<SysClassPower> c, SysClassPower s)
        {
            c.entity = s;
            return Json(SysClassPowerService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 类别权限设置删除
        /// <summary>
        /// 类别权限设置删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult SysClassPowerDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            SysClassPowerService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  类别权限设置

        #region 岗位权限
        public ISysDepartPowerService SysDepartPowerService { get; set; }
        #region 岗位权限编辑页面
        /// <summary>
        /// 岗位权限编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult SysDepartPowerEdit(string id)
        {
            SysDepartPower m = SysDepartPower.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = SysDepartPowerService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 岗位权限保存程序
        /// <summary>
        /// 岗位权限保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveSysDepartPower(SysDepartPower m)
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
                    SysDepartPowerService.Update(m);
                }
                else
                {
                    SysDepartPowerService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 岗位权限搜索
        /// <summary>
        /// 岗位权限搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchSysDepartPowerList(SearchDtoBase<SysDepartPower> c, SysDepartPower s)
        {
            c.entity = s;
            return Json(SysDepartPowerService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 岗位权限删除
        /// <summary>
        /// 岗位权限删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult SysDepartPowerDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            SysDepartPowerService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  岗位权限

        #region 企业设置
        public ISysEnterpriseArchivesService SysEnterpriseArchivesService { get; set; }
        #region 企业设置编辑页面
        /// <summary>
        /// 企业设置编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult SysEnterpriseArchivesEdit(string id)
        {
            SysEnterpriseArchives m = SysEnterpriseArchives.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = SysEnterpriseArchivesService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 企业设置保存程序
        /// <summary>
        /// 企业设置保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveSysEnterpriseArchives(SysEnterpriseArchives m)
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
                    SysEnterpriseArchivesService.Update(m);
                }
                else
                {
                    SysEnterpriseArchivesService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 企业设置搜索
        /// <summary>
        /// 企业设置搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchSysEnterpriseArchivesList(SearchDtoBase<SysEnterpriseArchives> c, SysEnterpriseArchives s)
        {
            c.entity = s;
            return Json(SysEnterpriseArchivesService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 企业设置删除
        /// <summary>
        /// 企业设置删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult SysEnterpriseArchivesDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            SysEnterpriseArchivesService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  企业设置

        #region 登录权限设置
        public ISysLoginPowerService SysLoginPowerService { get; set; }
        #region 登录权限设置编辑页面
        /// <summary>
        /// 登录权限设置编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult SysLoginPowerEdit(string id)
        {
            SysLoginPower m = SysLoginPower.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = SysLoginPowerService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 登录权限设置保存程序
        /// <summary>
        /// 登录权限设置保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveSysLoginPower(SysLoginPower m)
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
                    SysLoginPowerService.Update(m);
                }
                else
                {
                    SysLoginPowerService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 登录权限设置搜索
        /// <summary>
        /// 登录权限设置搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchSysLoginPowerList(SearchDtoBase<SysLoginPower> c, SysLoginPower s)
        {
            c.entity = s;
            return Json(SysLoginPowerService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 登录权限设置删除
        /// <summary>
        /// 登录权限设置删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult SysLoginPowerDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            SysLoginPowerService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  登录权限设置

        #region 人员收银功能
        public ISysLoginPowerFunctionService SysLoginPowerFunctionService { get; set; }
        #region 人员收银功能编辑页面
        /// <summary>
        /// 人员收银功能编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult SysLoginPowerFunctionEdit(string id)
        {
            SysLoginPowerFunction m = SysLoginPowerFunction.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = SysLoginPowerFunctionService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 人员收银功能保存程序
        /// <summary>
        /// 人员收银功能保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveSysLoginPowerFunction(SysLoginPowerFunction m)
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
                    SysLoginPowerFunctionService.Update(m);
                }
                else
                {
                    SysLoginPowerFunctionService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 人员收银功能搜索
        /// <summary>
        /// 人员收银功能搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchSysLoginPowerFunctionList(SearchDtoBase<SysLoginPowerFunction> c, SysLoginPowerFunction s)
        {
            c.entity = s;
            return Json(SysLoginPowerFunctionService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 人员收银功能删除
        /// <summary>
        /// 人员收银功能删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult SysLoginPowerFunctionDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            SysLoginPowerFunctionService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  人员收银功能

        #region 功能模块设置
        public ISysModuleService SysModuleService { get; set; }
        #region 功能模块设置编辑页面
        /// <summary>
        /// 功能模块设置编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult SysModuleEdit(string id)
        {
            SysModule m = SysModule.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = SysModuleService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 功能模块设置保存程序
        /// <summary>
        /// 功能模块设置保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveSysModule(SysModule m)
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
                    SysModuleService.Update(m);
                }
                else
                {
                    SysModuleService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 功能模块设置搜索
        /// <summary>
        /// 功能模块设置搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchSysModuleList(SearchDtoBase<SysModule> c, SysModule s)
        {
            c.entity = s;
            return Json(SysModuleService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 功能模块设置删除
        /// <summary>
        /// 功能模块设置删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult SysModuleDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            SysModuleService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  功能模块设置

        #region 模块相关信息
        public ISysModuleContentService SysModuleContentService { get; set; }
        #region 模块相关信息编辑页面
        /// <summary>
        /// 模块相关信息编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult SysModuleContentEdit(string id)
        {
            SysModuleContent m = SysModuleContent.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = SysModuleContentService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 模块相关信息保存程序
        /// <summary>
        /// 模块相关信息保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveSysModuleContent(SysModuleContent m)
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
                    SysModuleContentService.Update(m);
                }
                else
                {
                    SysModuleContentService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 模块相关信息搜索
        /// <summary>
        /// 模块相关信息搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchSysModuleContentList(SearchDtoBase<SysModuleContent> c, SysModuleContent s)
        {
            c.entity = s;
            return Json(SysModuleContentService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 模块相关信息删除
        /// <summary>
        /// 模块相关信息删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult SysModuleContentDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            SysModuleContentService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  模块相关信息

        #region 系统模块图片
        public ISysModulePicService SysModulePicService { get; set; }
        #region 系统模块图片编辑页面
        /// <summary>
        /// 系统模块图片编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult SysModulePicEdit(string id)
        {
            SysModulePic m = SysModulePic.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = SysModulePicService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 系统模块图片保存程序
        /// <summary>
        /// 系统模块图片保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveSysModulePic(SysModulePic m)
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
                    SysModulePicService.Update(m);
                }
                else
                {
                    SysModulePicService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 系统模块图片搜索
        /// <summary>
        /// 系统模块图片搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchSysModulePicList(SearchDtoBase<SysModulePic> c, SysModulePic s)
        {
            c.entity = s;
            return Json(SysModulePicService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 系统模块图片删除
        /// <summary>
        /// 系统模块图片删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult SysModulePicDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            SysModulePicService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  系统模块图片

        #region 业务流程
        public ISysOperationFlowService SysOperationFlowService { get; set; }
        #region 业务流程编辑页面
        /// <summary>
        /// 业务流程编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult SysOperationFlowEdit(string id)
        {
            SysOperationFlow m = SysOperationFlow.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = SysOperationFlowService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 业务流程保存程序
        /// <summary>
        /// 业务流程保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveSysOperationFlow(SysOperationFlow m)
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
                    SysOperationFlowService.Update(m);
                }
                else
                {
                    SysOperationFlowService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 业务流程搜索
        /// <summary>
        /// 业务流程搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchSysOperationFlowList(SearchDtoBase<SysOperationFlow> c, SysOperationFlow s)
        {
            c.entity = s;
            return Json(SysOperationFlowService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 业务流程删除
        /// <summary>
        /// 业务流程删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult SysOperationFlowDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            SysOperationFlowService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  业务流程

        #region 业务流程明细
        public ISysOperationFlowDetailService SysOperationFlowDetailService { get; set; }
        #region 业务流程明细编辑页面
        /// <summary>
        /// 业务流程明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult SysOperationFlowDetailEdit(string id)
        {
            SysOperationFlowDetail m = SysOperationFlowDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = SysOperationFlowDetailService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 业务流程明细保存程序
        /// <summary>
        /// 业务流程明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveSysOperationFlowDetail(SysOperationFlowDetail m)
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
                    SysOperationFlowDetailService.Update(m);
                }
                else
                {
                    SysOperationFlowDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 业务流程明细搜索
        /// <summary>
        /// 业务流程明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchSysOperationFlowDetailList(SearchDtoBase<SysOperationFlowDetail> c, SysOperationFlowDetail s)
        {
            c.entity = s;
            return Json(SysOperationFlowDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 业务流程明细删除
        /// <summary>
        /// 业务流程明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult SysOperationFlowDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            SysOperationFlowDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  业务流程明细

        #region 流程最大编号表
        public ISysOperationFlowDetailMaxService SysOperationFlowDetailMaxService { get; set; }
        #region 流程最大编号表编辑页面
        /// <summary>
        /// 流程最大编号表编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult SysOperationFlowDetailMaxEdit(string id)
        {
            SysOperationFlowDetailMax m = SysOperationFlowDetailMax.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = SysOperationFlowDetailMaxService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 流程最大编号表保存程序
        /// <summary>
        /// 流程最大编号表保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveSysOperationFlowDetailMax(SysOperationFlowDetailMax m)
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
                    SysOperationFlowDetailMaxService.Update(m);
                }
                else
                {
                    SysOperationFlowDetailMaxService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 流程最大编号表搜索
        /// <summary>
        /// 流程最大编号表搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchSysOperationFlowDetailMaxList(SearchDtoBase<SysOperationFlowDetailMax> c, SysOperationFlowDetailMax s)
        {
            c.entity = s;
            return Json(SysOperationFlowDetailMaxService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 流程最大编号表删除
        /// <summary>
        /// 流程最大编号表删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult SysOperationFlowDetailMaxDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            SysOperationFlowDetailMaxService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  流程最大编号表

        #region 业务流程人员权限
        public ISysOperationWorkerService SysOperationWorkerService { get; set; }
        #region 业务流程人员权限编辑页面
        /// <summary>
        /// 业务流程人员权限编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult SysOperationWorkerEdit(string id)
        {
            SysOperationWorker m = SysOperationWorker.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = SysOperationWorkerService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 业务流程人员权限保存程序
        /// <summary>
        /// 业务流程人员权限保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveSysOperationWorker(SysOperationWorker m)
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
                    SysOperationWorkerService.Update(m);
                }
                else
                {
                    SysOperationWorkerService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 业务流程人员权限搜索
        /// <summary>
        /// 业务流程人员权限搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchSysOperationWorkerList(SearchDtoBase<SysOperationWorker> c, SysOperationWorker s)
        {
            c.entity = s;
            return Json(SysOperationWorkerService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 业务流程人员权限删除
        /// <summary>
        /// 业务流程人员权限删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult SysOperationWorkerDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            SysOperationWorkerService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  业务流程人员权限

        #region 部门编码表
        public ISysPaDepartmentService SysPaDepartmentService { get; set; }
        #region 部门编码表编辑页面
        /// <summary>
        /// 部门编码表编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult SysPaDepartmentEdit(string id)
        {
            SysPaDepartment m = SysPaDepartment.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = SysPaDepartmentService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 部门编码表保存程序
        /// <summary>
        /// 部门编码表保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveSysPaDepartment(SysPaDepartment m)
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
                    SysPaDepartmentService.Update(m);
                }
                else
                {
                    SysPaDepartmentService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 部门编码表搜索
        /// <summary>
        /// 部门编码表搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchSysPaDepartmentList(SearchDtoBase<SysPaDepartment> c, SysPaDepartment s)
        {
            c.entity = s;
            return Json(SysPaDepartmentService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 部门编码表删除
        /// <summary>
        /// 部门编码表删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult SysPaDepartmentDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            SysPaDepartmentService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  部门编码表

        #region 打印模板设计
        public ISysPrintDesignService SysPrintDesignService { get; set; }
        #region 打印模板设计编辑页面
        /// <summary>
        /// 打印模板设计编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult SysPrintDesignEdit(string id)
        {
            SysPrintDesign m = SysPrintDesign.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = SysPrintDesignService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 打印模板设计保存程序
        /// <summary>
        /// 打印模板设计保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveSysPrintDesign(SysPrintDesign m)
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
                    SysPrintDesignService.Update(m);
                }
                else
                {
                    SysPrintDesignService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 打印模板设计搜索
        /// <summary>
        /// 打印模板设计搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchSysPrintDesignList(SearchDtoBase<SysPrintDesign> c, SysPrintDesign s)
        {
            c.entity = s;
            return Json(SysPrintDesignService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 打印模板设计删除
        /// <summary>
        /// 打印模板设计删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult SysPrintDesignDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            SysPrintDesignService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  打印模板设计

        #region 人员权限
        public ISysWorkerPowerService SysWorkerPowerService { get; set; }
        #region 人员权限编辑页面
        /// <summary>
        /// 人员权限编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult SysWorkerPowerEdit(string id)
        {
            SysWorkerPower m = SysWorkerPower.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = SysWorkerPowerService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 人员权限保存程序
        /// <summary>
        /// 人员权限保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveSysWorkerPower(SysWorkerPower m)
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
                    SysWorkerPowerService.Update(m);
                }
                else
                {
                    SysWorkerPowerService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 人员权限搜索
        /// <summary>
        /// 人员权限搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchSysWorkerPowerList(SearchDtoBase<SysWorkerPower> c, SysWorkerPower s)
        {
            c.entity = s;
            return Json(SysWorkerPowerService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 人员权限删除
        /// <summary>
        /// 人员权限删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult SysWorkerPowerDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            SysWorkerPowerService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  人员权限
    }
}





