
using NSH.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiQiWorkFlow.Application.Service.Em;
using YiQiWorkFlow.Domain.Em;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Web.Client.Controllers
{
    public class EmController : Controller
    {
        #region 人员档案
        public IEmEmployeeArchivesService EmEmployeeArchivesService { get; set; }
        #region 人员档案编辑页面
        /// <summary>
        /// 人员档案编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult EmEmployeeArchivesEdit(string id)
        {
            EmEmployeeArchives m = new EmEmployeeArchives();

            if (string.IsNullOrEmpty(id) == false)
            {
                m = EmEmployeeArchivesService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 人员档案列表页面
        /// <summary>
        /// 人员档案列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult EmEmployeeArchivesList()
        {
            return View();
        }
        #endregion

        #region 人员档案保存程序
        /// <summary>
        /// 人员档案保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveEmEmployeeArchives(EmEmployeeArchives m)
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
                    EmEmployeeArchivesService.Update(m);
                }
                else
                {
                    EmEmployeeArchivesService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 人员档案搜索
        /// <summary>
        /// 人员档案搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchEmEmployeeArchivesList(SearchDtoBase<EmEmployeeArchives> c, EmEmployeeArchives s)
        {
            c.entity = s;
            return Json(EmEmployeeArchivesService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 人员档案删除
        /// <summary>
        /// 人员档案删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult EmEmployeeArchivesDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            EmEmployeeArchivesService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  人员档案

        #region 人员家庭信息
        public IEmEmployeeFamilyService EmEmployeeFamilyService { get; set; }
        #region 人员家庭信息编辑页面
        /// <summary>
        /// 人员家庭信息编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult EmEmployeeFamilyEdit(string id)
        {
            EmEmployeeFamily m = EmEmployeeFamily.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = EmEmployeeFamilyService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 人员家庭信息列表页面
        /// <summary>
        /// 人员家庭信息列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult EmEmployeeFamilyList()
        {
            return View();
        }
        #endregion

        #region 人员家庭信息保存程序
        /// <summary>
        /// 人员家庭信息保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveEmEmployeeFamily(EmEmployeeFamily m)
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
                    EmEmployeeFamilyService.Update(m);
                }
                else
                {
                    EmEmployeeFamilyService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 人员家庭信息搜索
        /// <summary>
        /// 人员家庭信息搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchEmEmployeeFamilyList(SearchDtoBase<EmEmployeeFamily> c, EmEmployeeFamily s)
        {
            c.entity = s;
            return Json(EmEmployeeFamilyService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 人员家庭信息删除
        /// <summary>
        /// 人员家庭信息删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult EmEmployeeFamilyDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            EmEmployeeFamilyService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  人员家庭信息

        #region 人员照片
        public IEmEmployeePhotoService EmEmployeePhotoService { get; set; }
        #region 人员照片编辑页面
        /// <summary>
        /// 人员照片编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult EmEmployeePhotoEdit(string id)
        {
            EmEmployeePhoto m = EmEmployeePhoto.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = EmEmployeePhotoService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 人员照片列表页面
        /// <summary>
        /// 人员照片列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult EmEmployeePhotoList()
        {
            return View();
        }
        #endregion

        #region 人员照片保存程序
        /// <summary>
        /// 人员照片保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveEmEmployeePhoto(EmEmployeePhoto m)
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
                    EmEmployeePhotoService.Update(m);
                }
                else
                {
                    EmEmployeePhotoService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 人员照片搜索
        /// <summary>
        /// 人员照片搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchEmEmployeePhotoList(SearchDtoBase<EmEmployeePhoto> c, EmEmployeePhoto s)
        {
            c.entity = s;
            return Json(EmEmployeePhotoService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 人员照片删除
        /// <summary>
        /// 人员照片删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult EmEmployeePhotoDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            EmEmployeePhotoService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  人员照片

        #region 职务编码表
        public IEmPaDutyService EmPaDutyService { get; set; }
        #region 职务编码表编辑页面
        /// <summary>
        /// 职务编码表编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult EmPaDutyEdit(string id)
        {
            EmPaDuty m = new EmPaDuty();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = EmPaDutyService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 职务编码表列表页面
        /// <summary>
        /// 职务编码表列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult EmPaDutyList()
        {
            return View();
        }
        #endregion

        #region 职务编码表保存程序
        /// <summary>
        /// 职务编码表保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveEmPaDuty(EmPaDuty m)
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
                    EmPaDutyService.Update(m);
                }
                else
                {
                    EmPaDutyService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 职务编码表搜索
        /// <summary>
        /// 职务编码表搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchEmPaDutyList(SearchDtoBase<EmPaDuty> c, EmPaDuty s)
        {
            c.entity = s;
            return Json(EmPaDutyService.Search(c), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetEmPaDutyList()
        {
            var searchDtoBase = EmPaDutyService.Search(new SearchDtoBase<EmPaDuty>() { pageSize = int.MaxValue });

            IList<EmPaDuty> msCardtypeManageList = searchDtoBase.data;

            return Json(msCardtypeManageList.Select(entity => new { id = entity.DutyCode, text = entity.DutyName}), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 职务编码表删除
        /// <summary>
        /// 职务编码表删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult EmPaDutyDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            String idStr = ids[0];
            String[] sid = idStr.Split(',');
            List<String> list = new List<string>();
            for (int i = 0, l = sid.Length; i < l; i++)
            {
                list.Add(sid[i]);
            }
            EmPaDutyService.Delete(list);
            // EmPaDutyService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  职务编码表

        #region 学历编码表
        public IEmPaEducationService EmPaEducationService { get; set; }
        #region 学历编码表编辑页面
        /// <summary>
        /// 学历编码表编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult EmPaEducationEdit(string id)
        {
            EmPaEducation m = new EmPaEducation();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = EmPaEducationService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 学历编码表列表页面
        /// <summary>
        /// 学历编码表列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult EmPaEducationList()
        {
            return View();
        }
        #endregion

        #region 学历编码表保存程序
        /// <summary>
        /// 学历编码表保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveEmPaEducation(EmPaEducation m)
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
                    EmPaEducationService.Update(m);
                }
                else
                {
                    EmPaEducationService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 学历编码表搜索
        /// <summary>
        /// 学历编码表搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchEmPaEducationList(SearchDtoBase<EmPaEducation> c, EmPaEducation s)
        {
            c.entity = s;
            return Json(EmPaEducationService.Search(c), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetEmPaEducationList()
        {
            var searchDtoBase = EmPaEducationService.Search(new SearchDtoBase<EmPaEducation>() { pageSize = int.MaxValue });

            IList<EmPaEducation> emPaEducationList = searchDtoBase.data;

            return Json(emPaEducationList.Select(entity => new { id = entity.EducationCode, text = entity.EducationName }), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 学历编码表删除
        /// <summary>
        /// 学历编码表删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult EmPaEducationDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

            String idStr = ids[0];
            String[] sid = idStr.Split(',');
            List<String> list = new List<string>();
            for (int i = 0, l = sid.Length; i < l; i++)
            {
                list.Add(sid[i]);
            }
            EmPaEducationService.Delete(list);

            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  学历编码表

        #region 民族编码表
        public IEmPaNationService EmPaNationService { get; set; }
        #region 民族编码表编辑页面
        /// <summary>
        /// 民族编码表编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult EmPaNationEdit(string id)
        {
            EmPaNation m = new EmPaNation();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = EmPaNationService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 民族编码表列表页面
        /// <summary>
        /// 民族编码表列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult EmPaNationList()
        {
            return View();
        }
        #endregion

        #region 民族编码表保存程序
        /// <summary>
        /// 民族编码表保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveEmPaNation(EmPaNation m)
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
                    EmPaNationService.Update(m);
                }
                else
                {
                    EmPaNationService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 民族编码表搜索
        /// <summary>
        /// 民族编码表搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchEmPaNationList(SearchDtoBase<EmPaNation> c, EmPaNation s)
        {
            c.entity = s;
            return Json(EmPaNationService.Search(c), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetEmPaNationList()
        {
            var searchDtoBase = EmPaNationService.Search(new SearchDtoBase<EmPaNation>() { pageSize = int.MaxValue });

            IList<EmPaNation> emPaPoliticsList = searchDtoBase.data;

            return Json(emPaPoliticsList.Select(entity => new { id = entity.NationCode, text = entity.NationName }), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 民族编码表删除
        /// <summary>
        /// 民族编码表删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult EmPaNationDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            String idStr = ids[0];
            String[] sid = idStr.Split(',');
            List<String> list = new List<string>();
            for (int i = 0, l = sid.Length; i < l; i++)
            {
                list.Add(sid[i]);
            }
            EmPaNationService.Delete(list);
            // EmPaNationService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  民族编码表

        #region 政治面貌编码表
        public IEmPaPoliticsService EmPaPoliticsService { get; set; }
        #region 政治面貌编码表编辑页面
        /// <summary>
        /// 政治面貌编码表编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult EmPaPoliticsEdit(string id)
        {
            EmPaPolitics m = new EmPaPolitics();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = EmPaPoliticsService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 政治面貌编码表列表页面
        /// <summary>
        /// 政治面貌编码表列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult EmPaPoliticsList()
        {
            return View();
        }
        #endregion

        #region 政治面貌编码表保存程序
        /// <summary>
        /// 政治面貌编码表保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveEmPaPolitics(EmPaPolitics m)
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
                    EmPaPoliticsService.Update(m);
                }
                else
                {
                    EmPaPoliticsService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 政治面貌编码表搜索
        /// <summary>
        /// 政治面貌编码表搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchEmPaPoliticsList(SearchDtoBase<EmPaPolitics> c, EmPaPolitics s)
        {
            c.entity = s;
            return Json(EmPaPoliticsService.Search(c), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetEmPaPoliticsList()
        {
            var searchDtoBase = EmPaPoliticsService.Search(new SearchDtoBase<EmPaPolitics>() { pageSize = int.MaxValue });

            IList<EmPaPolitics> emPaPoliticsList = searchDtoBase.data;

            return Json(emPaPoliticsList.Select(entity => new { id = entity.PoliticsCode, text = entity.PoliticsName }), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 政治面貌编码表删除
        /// <summary>
        /// 政治面貌编码表删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult EmPaPoliticsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            String idStr = ids[0];
            String[] sid = idStr.Split(',');
            List<String> list = new List<string>();
            for (int i = 0, l = sid.Length; i < l; i++)
            {
                list.Add(sid[i]);
            }
            EmPaPoliticsService.Delete(list);
            // EmPaPoliticsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  政治面貌编码表

        #region 职称编码表
        public IEmPaProfessionalTitleService EmPaProfessionalTitleService { get; set; }
        #region 职称编码表编辑页面
        /// <summary>
        /// 职称编码表编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult EmPaProfessionalTitleEdit(string id)
        {
            EmPaProfessionalTitle m = new EmPaProfessionalTitle();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = EmPaProfessionalTitleService.GetById(id);
            }
            return View(m);
        }
        #endregion

        #region 职称编码表列表页面
        /// <summary>
        /// 职称编码表列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult EmPaProfessionalTitleList()
        {
            return View();
        }
        #endregion

        #region 职称编码表保存程序
        /// <summary>
        /// 职称编码表保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveEmPaProfessionalTitle(EmPaProfessionalTitle m)
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
                    EmPaProfessionalTitleService.Update(m);
                }
                else
                {
                    EmPaProfessionalTitleService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 职称编码表搜索
        /// <summary>
        /// 职称编码表搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchEmPaProfessionalTitleList(SearchDtoBase<EmPaProfessionalTitle> c, EmPaProfessionalTitle s)
        {
            c.entity = s;
            return Json(EmPaProfessionalTitleService.Search(c), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetEmPaProfessionalTitleList()
        {
            var searchDtoBase = EmPaProfessionalTitleService.Search(new SearchDtoBase<EmPaProfessionalTitle>() { pageSize = int.MaxValue });

            IList<EmPaProfessionalTitle> emPaProfessionalTitleList = searchDtoBase.data;

            return Json(emPaProfessionalTitleList.Select(entity => new { id = entity.ProfessionalTitleCode, text = entity.ProfessionalTitleName }), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 职称编码表删除
        /// <summary>
        /// 职称编码表删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult EmPaProfessionalTitleDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            String idStr = ids[0];
            String[] sid = idStr.Split(',');
            List<String> list = new List<string>();
            for (int i = 0, l = sid.Length; i < l; i++)
            {
                list.Add(sid[i]);
            }
            EmPaProfessionalTitleService.Delete(list);
            // EmPaProfessionalTitleService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  职称编码表
    }
}