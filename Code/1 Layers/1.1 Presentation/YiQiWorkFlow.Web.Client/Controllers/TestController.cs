using NSH.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiQiWorkFlow.Application.Service.Fb;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Web.Client.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public IFbGoodsArchivesService FbGoodsArchivesService { get; set; }
        public ActionResult Index(string id)
        {
            FbGoodsArchives m = FbGoodsArchives.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbGoodsArchivesService.GetById(id);
            }
            return View(m);
        }

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
            }
            return View(m);
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
                if (m.HaveId)
                {
                    FbGoodsArchivesService.Update(m);
                }
                else
                {
                    FbGoodsArchivesService.Create(m);
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

    }
}
