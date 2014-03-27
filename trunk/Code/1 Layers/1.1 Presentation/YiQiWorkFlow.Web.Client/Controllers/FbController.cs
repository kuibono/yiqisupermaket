
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
using YiQiWorkFlow.Web.Client.Common;
using System.Data;

namespace YiQiWorkFlow.Web.Client.Controllers
{
    public class FbController : FbBaseController
    {
        #region 树数据源

        #region 类别树

        public ActionResult GetClassTree()
        {
            var gb = FbPaGoodsGbService.GetAll();
            var gm = FbPaGoodsGmService.GetAll();
            var gs = FbPaGoodsGsService.GetAll();
            var gl = FbPaGoodsGlService.GetAll();

            var tGb = gb.Where(p => p.GbCode != "01").Select(p => new
            {
                id = p.GbCode,
                text = p.GbName,
                type = "GbCode",
                children = gm.Where(m => m.GbCode == p.GbCode).Select(m => new
                {
                    id = m.GmCode,
                    text = m.GmName,
                    type = "GmCode",
                    children = gs.Where(s => s.GmCode == m.GmCode).Select(s => new
                    {
                        id = s.GsCode,
                        text = s.GsName,
                        type = "GsCode",
                        children = gl.Where(l => l.GsCode == s.GsCode).Select(l => new
                        {
                            id = l.GlCode,
                            text = l.GlName,
                            type = "GlCode"
                        })
                    })
                }).ToList()
            }).ToList();

            return Json(tGb.ToArray(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetGoodsClassList()
        {
            var gb = FbPaGoodsGbService.GetAll().Where(entity => entity.GbCode != "01").ToList();
            var gm = FbPaGoodsGmService.GetAll().Where(entity => entity.GmCode != "01").ToList();
            var gs = FbPaGoodsGsService.GetAll().Where(entity => entity.GsCode != "01").ToList();
            var gl = FbPaGoodsGlService.GetAll().Where(entity => entity.GlCode != "01").ToList();

            List<GoodsClassDto> goodsClassDtoList = new List<GoodsClassDto>();

            foreach (var gbItem in gb)
            {
                GoodsClassDto goodsClassDto = new GoodsClassDto()
                {
                    id = gbItem.GbCode,
                    text = gbItem.GbName,
                    level = "1",
                    type = "GbCode",
                    pid = string.Empty
                };

                if (!goodsClassDtoList.Contains(goodsClassDto))
                {
                    goodsClassDtoList.Add(goodsClassDto);
                }
            }

            foreach (var gmItem in gm)
            {
                GoodsClassDto goodsClassDto = new GoodsClassDto()
                {
                    id = gmItem.GmCode,
                    text = gmItem.GmName,
                    level = "2",
                    type = "GmCode",
                    pid = gmItem.GbCode
                };

                if (!goodsClassDtoList.Contains(goodsClassDto))
                {
                    goodsClassDtoList.Add(goodsClassDto);
                }
            }

            foreach (var gsItem in gs)
            {
                GoodsClassDto goodsClassDto = new GoodsClassDto()
                {
                    id = gsItem.GsCode,
                    text = gsItem.GsName,
                    level = "3",
                    type = "GsCode",
                    pid = gsItem.GmCode
                };

                if (!goodsClassDtoList.Contains(goodsClassDto))
                {
                    goodsClassDtoList.Add(goodsClassDto);
                }
            }

            foreach (var glItem in gl)
            {
                GoodsClassDto goodsClassDto = new GoodsClassDto()
                {
                    id = glItem.GlCode,
                    text = glItem.GlName,
                    level = "4",
                    type = "GlCode",
                    pid = glItem.GsCode
                };

                if (!goodsClassDtoList.Contains(goodsClassDto))
                {
                    goodsClassDtoList.Add(goodsClassDto);
                }
            }

            return Json(goodsClassDtoList, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #endregion

        #region 修改商品属性
        public ActionResult FbAdjustGoodsPropty()
        {
            return View();
        }

        public ActionResult SaveFbAdjustGoodsPropty()
        {
            string GoodsType = getRequestValue("GoodsType");
            string CheckMode = getRequestValue("CheckMode");
            string CheckUnitCode = getRequestValue("CheckUnitCode");
            string UnderCounterCode = getRequestValue("UnderCounterCode");
            string ArticleNumber = getRequestValue("ArticleNumber");
            string ProducingArea = getRequestValue("ProducingArea");
            string Specification = getRequestValue("Specification");
            string PackUnitCode = getRequestValue("PackUnitCode");
            string ShelfLife = getRequestValue("ShelfLife");
            string StockUpperLimit = getRequestValue("StockUpperLimit");
            string StockLowerLimit = getRequestValue("StockLowerLimit");
            string IfExamine = getRequestValue("IfExamine");

            var jser = new JavaScriptSerializer();
            var goods = jser.Deserialize<List<FbGoodsArchives>>(Request["goods"]);

            foreach (var good in goods)
            {
                var dataGood = FbGoodsArchivesService.GetById(good.Id);
                if (string.IsNullOrEmpty(GoodsType) == false)
                {
                    dataGood.GoodsType = GoodsType;
                }
                if (string.IsNullOrEmpty(CheckMode) == false)
                {
                    dataGood.CheckMode = CheckMode;
                }
                if (string.IsNullOrEmpty(CheckUnitCode) == false)
                {
                    dataGood.CheckUnitCode = CheckUnitCode;
                }
                if (string.IsNullOrEmpty(UnderCounterCode) == false)
                {
                    dataGood.UnderCounterCode = UnderCounterCode;
                }
                if (string.IsNullOrEmpty(ArticleNumber) == false)
                {
                    dataGood.ArticleNumber = ArticleNumber;
                }
                if (string.IsNullOrEmpty(ProducingArea) == false)
                {
                    dataGood.ProducingArea = ProducingArea;
                }
                if (string.IsNullOrEmpty(Specification) == false)
                {
                    dataGood.Specification = Specification;
                }
                if (string.IsNullOrEmpty(PackUnitCode) == false)
                {
                    dataGood.PackUnitCode = PackUnitCode;
                }
                if (string.IsNullOrEmpty(ShelfLife) == false)
                {
                    dataGood.ShelfLife = ShelfLife;
                }
                if (string.IsNullOrEmpty(GoodsType) == false)
                {
                    dataGood.StockUpperLimit = StockUpperLimit.ToDecimal();
                }
                if (string.IsNullOrEmpty(GoodsType) == false)
                {
                    dataGood.StockLowerLimit = StockLowerLimit.ToDecimal();
                }
                if (string.IsNullOrEmpty(IfExamine) == false)
                {
                    dataGood.IfExamine = IfExamine;
                }
                FbGoodsArchivesService.Update(dataGood);
            }
            return Json(new SavingResult { IsSuccess = true, Message = "保存成功！" }, JsonRequestBehavior.AllowGet);
        }

        private string getRequestValue(string key)
        {
            if (Request[key] == null)
                return "";
            if (Request[key].Split(',').Contains("on") == false)
                return "";

            var items = Request[key].Split(',');
            if (items.Count() <= 1)
            {
                return "";
            }
            else
            {
                return items.Where(p => p != "on").First();
            }
        }

        #endregion

        #region 修改商品编码

        #region 商品编码修改页面
        public ActionResult FbAdjustGoodsCode()
        {
            return View();
        }
        #endregion

        #region 商品编码修改保存
        public ActionResult SaveAdjustGoodsCode(string codeType, string GoodsCode, string newCode)
        {
            NSH.VSTO.SqlHelper Helper = (new FbGoodsArchives()).GetSqlHelper();
            string sql = "";
            if (codeType == "0")
            {
                //修改商品编码
                string strExist = string.Format("select count(0) from fb_goods_bar_code where goods_code =N'{0}'", newCode);
                if (Convert.ToInt32((new FbGoodsArchives()).GetSqlHelper().ExecuteScalar(CommandType.Text, strExist)) > 0)
                {
                    return Json(new SavingResult { IsSuccess = false, Message = "新编码已经存在不能进行更新！" }, JsonRequestBehavior.AllowGet);
                }
                sql = string.Format(@"
                    update fb_goods_archives_bind set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update ms_exchange_detail set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update pc_return_detail set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update ac_day_goods_journal_account set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update op_goods_batch set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update ws_customer_goods set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update ba_offer_detail set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update ms_gift_archives set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update ws_wholesale_detail set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update fb_goods_bar_code set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update fb_goods_archives_supplier set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update ba_pool_detail set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update rt_plu_promotion_goods set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update op_dynamic_stock_branch set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update ac_salesman_summary set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update ws_order_detail set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update ac_stock_account set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update fb_adjust_class_goods set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update op_check_detail set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update pc_putout_detail set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update rt_retail_detail set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update op_check_transfer set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update fb_adjust_poolrate_goods set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update ws_wholesale_goods_set set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update op_dynamic_stock set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update ac_goodssale_account set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update fb_adjust_purchaseprice_goods set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update pc_putin_detail set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update pc_purchase_detail set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update bs_return_detail set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update ba_branch_offer_detail set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update fb_goods_archives_bar set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update fb_adjust_supplier_goods set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update op_adjust_detail set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update rt_present_promotion_goods set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update bs_supply_detail set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update op_loss_detail set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update fb_adjust_saleprice_goods set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update ac_month_goods_journal_account set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update op_allot_detail set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update fb_goods_archives set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update op_dynamic_stock_wh set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update fb_goods_archives_bind set goods_code_bind =  N'{0}' where goods_code_bind =  N'{1}';
	                update rt_present_promotion_goods set goods_code_present =  N'{0}' where goods_code_present =  N'{1}';
	                update fb_goods_archives_photo set goods_code =  N'{0}' where goods_code =  N'{1}';
	                update ac_supplier_journal set goods_code =  N'{0}' where goods_code =  N'{1}';
                ", newCode, GoodsCode);
            }
            else
            {
                //修改销售码
                string strExist = string.Format("select count(0) from fb_goods_bar_code where goods_bar_code =N'{0}'", newCode);
                if (Convert.ToInt32((new FbGoodsArchives()).GetSqlHelper().ExecuteScalar(CommandType.Text, strExist)) > 0)
                {
                    return Json(new SavingResult { IsSuccess = false, Message = "新编码已经存在不能进行更新！" }, JsonRequestBehavior.AllowGet);
                }
                sql = string.Format(@"
                        update fb_goods_archives_bind set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update ws_order_detail set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update bs_supply_detail set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update pc_purchase_detail set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update pc_return_detail set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update rt_present_promotion_goods set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update ws_wholesale_goods_set set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update op_check_transfer set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update op_allot_detail set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update pc_putout_detail set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update fb_adjust_saleprice_goods set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update rt_retail_detail set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update op_loss_detail set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update ws_customer_goods set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update ws_wholesale_detail set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update ac_goodssale_account set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update pc_putin_detail set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update rt_plu_promotion_goods set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update ac_salesman_summary set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update op_check_detail set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update bs_return_detail set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update fb_goods_archives_bind set goods_bar_code_bind = N'{0}' where goods_bar_code_bind = N'{1}';
	                    update rt_present_promotion_goods set goods_bar_code_present = N'{0}' where goods_bar_code_present = N'{1}';
	                    update fb_goods_bar_code set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update fb_goods_archives_bar set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update fb_goods_archives_bar set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update op_goods_batch set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
	                    update fb_goods_archives set goods_bar_code = N'{0}' where goods_bar_code = N'{1}';
                     update ac_supplier_journal set goods_bar_code = N'{0}' where goods_code = N'{1}';
                    ", newCode, GoodsCode);
            }
            try
            {
                Helper.ExecuteNonQuery(CommandType.Text, sql);
                return Json(new SavingResult { IsSuccess = true, Message = "保存成功" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new SavingResult { IsSuccess = false, Message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        #endregion

        #endregion

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
            FbAdjustClass m = new FbAdjustClass();
            m.AdjustDate = DateTime.Now;
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbAdjustClassService.GetById(id);
            }
            else
            {
                m._state = "added";
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

                var jser = new JavaScriptSerializer();
                var goods = jser.Deserialize<List<FbAdjustClassGoods>>(Request["goods"]);

                foreach (var item in goods)
                {
                    if (item.GoodsCode.IsNullOrEmpty())
                    {
                        continue;
                    }
                    item.AdjustNumber = m.Id;
                    if (item.IsAdded)
                    {
                        FbAdjustClassGoodsService.Create(item);
                    }
                    else if (m.IsDelete)
                    {
                        FbAdjustClassGoodsService.Delete(item);
                    }
                    else if (m.IsUpdated)
                    {
                        FbAdjustClassGoodsService.Update(item);
                    }
                }

                if (m.IfExamine == "1")
                {
                    //获取所有子项目
                    FbAdjustClassService.ExameByNumber(m.Id);
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
            FbAdjustPoolrate m = new FbAdjustPoolrate();
            m.AdjustDate = DateTime.Now;
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbAdjustPoolrateService.GetById(id);
            }
            else
            {
                m._state = "added";
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

                var jser = new JavaScriptSerializer();
                var goods = jser.Deserialize<List<FbAdjustPoolrateGoods>>(Request["goods"]);

                foreach (var item in goods)
                {
                    if (item.GoodsCode.IsNullOrEmpty())
                    {
                        continue;
                    }
                    item.AdjustNumber = m.Id;
                    if (item.IsAdded)
                    {
                        FbAdjustPoolrateGoodsService.Create(item);
                    }
                    else if (m.IsDelete)
                    {
                        FbAdjustPoolrateGoodsService.Delete(item);
                    }
                    else if (m.IsUpdated)
                    {
                        FbAdjustPoolrateGoodsService.Update(item);
                    }
                }

                if (m.IfExamine == "1")
                {
                    //获取所有子项目
                    FbAdjustPoolrateService.ExameByNumber(m.Id);
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
            FbAdjustPurchaseprice m = new FbAdjustPurchaseprice();
            m.AdjustDate = DateTime.Now;
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbAdjustPurchasepriceService.GetById(id);
            }
            else
            {
                m._state = "added";
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
                var jser = new JavaScriptSerializer();
                var goods = jser.Deserialize<List<FbAdjustPurchasepriceGoods>>(Request["goods"]);

                foreach (var item in goods)
                {
                    if (item.GoodsCode.IsNullOrEmpty())
                    {
                        continue;
                    }
                    item.AdjustNumber = m.Id;
                    if (item.IsAdded)
                    {
                        FbAdjustPurchasepriceGoodsService.Create(item);
                    }
                    else if (m.IsDelete)
                    {
                        FbAdjustPurchasepriceGoodsService.Delete(item);
                    }
                    else if (m.IsUpdated)
                    {
                        FbAdjustPurchasepriceGoodsService.Update(item);
                    }
                }

                if (m.IfExamine == "1")
                {
                    //获取所有子项目
                    FbAdjustPurchasepriceService.ExameByNumber(m.Id);
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
            FbAdjustSaleprice m = new FbAdjustSaleprice();
            m.AdjustDate = DateTime.Now;
            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbAdjustSalepriceService.GetById(id);
            }
            else
            {
                m._state = "added";
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
                var jser = new JavaScriptSerializer();
                var goods = jser.Deserialize<List<FbAdjustSalepriceGoods>>(Request["goods"]);

                foreach (var item in goods)
                {
                    if (item.GoodsCode.IsNullOrEmpty())
                    {
                        continue;
                    }
                    item.AdjustNumber = m.Id;
                    if (item.IsAdded)
                    {
                        FbAdjustSalepriceGoodsService.Create(item);
                    }
                    else if (m.IsDelete)
                    {
                        FbAdjustSalepriceGoodsService.Delete(item);
                    }
                    else if (m.IsUpdated)
                    {
                        FbAdjustSalepriceGoodsService.Update(item);
                    }
                }

                if (m.IfExamine == "1")
                {
                    //获取所有子项目
                    FbAdjustSalepriceService.ExameByNumber(m.Id);
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
            FbAdjustSupplier m = new FbAdjustSupplier();
            m.AdjustDate = DateTime.Now;

            if (string.IsNullOrEmpty(id) == false)
            {
                m = FbAdjustSupplierService.GetById(id);
            }
            else
            {
                m._state = "added";
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
                m.OperatorDate = DateTime.Now;
                if (m.HaveId)
                {
                    FbAdjustSupplierService.Update(m);
                }
                else
                {
                    m.CreateDate = DateTime.Now;
                    m.Id = FbAdjustSupplierService.Create(m);
                }

                var jser = new JavaScriptSerializer();
                var goods = jser.Deserialize<List<FbAdjustSupplierGoods>>(Request["goods"]);

                foreach (var item in goods)
                {
                    if (item.GoodsCode.IsNullOrEmpty())
                    {
                        continue;
                    }
                    item.AdjustNumber = m.Id;
                    if (item.IsAdded)
                    {
                        FbAdjustSupplierGoodsService.Create(item);
                    }
                    else if (m.IsDelete)
                    {
                        FbAdjustSupplierGoodsService.Delete(item);
                    }
                    else if (m.IsUpdated)
                    {
                        FbAdjustSupplierGoodsService.Update(item);
                    }
                }

                if (m.IfExamine == "1")
                {
                    //获取所有子项目
                    FbAdjustSupplierService.ExameByNumber(m.Id);
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
                m.GoodsSubCode = m.GetTableSerialNumber().ToString().FillByStrings('0', FbPaBaseSet.GoodsLen.ToInt32());
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

        #region 商品检索
        public ActionResult FbGoodsArchiveSearch()
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


                var jser = new JavaScriptSerializer();
                var suppliers = jser.Deserialize<List<FbGoodsArchivesSupplier>>(Request["suppliers"]);
                var saleCodes = jser.Deserialize<List<FbGoodsArchivesBar>>(Request["saleCode"]);
                var binding = jser.Deserialize<List<FbGoodsArchivesBind>>(Request["binding"]);
                var images = jser.Deserialize<List<FbGoodsArchivesPhoto>>(Request["images"]);

                if (saleCodes.Where(p => p.IfExamine == "1").Count() > 0)
                {
                    m.GoodsBarCode = saleCodes.First(p => p.IfExamine == "1").GoodsBarCode;
                }



                bool mainSup = false;
                suppliers.ForEach(p =>
                {
                    if (p.IfMainSupplier == "1" && mainSup == false)
                    {
                        mainSup = true;//主供货商出现
                        m.SupCode = p.SupCode;
                        m.OpCode = p.OpCode;
                        m.PoolRate = p.PoolRate;
                        m.OfferMode = p.OfferMode;
                        //m.PackCoef=p.co
                        m.OfferMin = p.OfferMin;
                        m.InputTax = p.InputTax;
                        //m.OutputTax=
                        m.PurchasePrice = p.PurchasePrice;
                        m.NontaxPurchasePrice = p.NontaxPurchasePrice;
                        //m.GrossRate=p.
                        //m.PushRate=p.
                        //m.SalePrice=
                    }
                    else
                    {
                        p.IfMainSupplier = "0";
                    }

                });
                saleCodes.ForEach(p =>
                {
                    if (p.IfMainBar == "1")
                    {
                        m.GoodsBarCode = p.GoodsBarCode;
                        m.PackCoef = p.PackCoef;
                        m.PackUnitCode = p.PackUnitCode;
                        m.SalePrice = p.SalePrice;
                        m.VipPrice = p.VipPrice;
                        m.TradePrice = p.TradePrice;
                        m.PushRate = p.PushRate;
                    }
                });
                FbGoodsArchivesService.SaveOrUpdate(m);

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
                    if (item.IfMainBar == "1")//主销售码的包装系数一定是1
                    {
                        item.PackCoef = 1;
                    }
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
            if (Request["confirm"] == null && MyEnv.RecordExist("ac_day_goodsstock_journal_account", "goods_code", string.Join(",", ids)))//需要验证是否可以直接删除
            {
                return Json(new SavingResult() { IsSuccess = false, Message = "存在关联数据，不可删除！" }, JsonRequestBehavior.AllowGet);
            }
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("if_examine", "1");
            if (MyEnv.RecordExist("fb_goods_archives", "goods_code", string.Join(",", ids), dic))
            {
                return Json(new SavingResult() { IsSuccess = false, Message = "不得删除已经审核的数据！" }, JsonRequestBehavior.AllowGet);
            }
            FbGoodsArchivesService.Delete(ids);
            return Json(new SavingResult() { IsSuccess = true, Message = "删除成功！" }, JsonRequestBehavior.AllowGet);
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

        public JsonResult SearchFbGoodsArchivesSupplierListData(SearchDtoBase<FbGoodsArchivesSupplier> c, FbGoodsArchivesSupplier s)
        {
            c.entity = s;
            return Json(FbGoodsArchivesSupplierService.Search(c).data, JsonRequestBehavior.AllowGet);
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
            return View(FbPaBaseSetService.GetFirst());
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
            m.OperatorDate = DateTime.Now;
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
                    m.Id = FbPaBaseSetService.Create(m);
                }
                XmlHelper.SaveSerialize(m, Server.MapPath("/Data/Cache/FbPaBaseSet.xml"));
                CacheHelper.SetCache("FbPaBaseSet", m, Server.MapPath("/Data/Cache/FbPaBaseSet.xml"));

                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
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
            m.GbCode = m.GetTableSerialNumber().ToS().FillByStrings('0', FbPaBaseSet.GoodsGbLen.ToInt32());
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
            if (Request["confirm"] == null && MyEnv.RecordExist("fb_pa_goods_gm", "gb_code", string.Join(",", ids)))//需要验证是否可以直接删除
            {
                return Json(new SavingResult { Message = "存在子类别，不得删除！", IsSuccess = false }, JsonRequestBehavior.AllowGet);
            }
            FbPaGoodsGbService.Delete(ids);
            return Json(new SavingResult { Message = "删除成功！", IsSuccess = true }, JsonRequestBehavior.AllowGet);
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
            FbPaGoodsGl m = new FbPaGoodsGl();
            m.GlCode = m.GetTableSerialNumber().ToS().FillByStrings('0', FbPaBaseSet.GoodsGlLen.ToInt32());
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
                    if (m.GlCode.Length == FbPaBaseSet.GoodsGlLen.ToInt32())
                    {
                        m.GlCode = m.GsCode + m.GlCode;
                    }
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
            FbPaGoodsGm m = new FbPaGoodsGm();
            m.GmCode = m.GetTableSerialNumber().ToS().FillByStrings('0', FbPaBaseSet.GoodsGmLen.ToInt32());
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
                    if (m.GmCode.Length == FbPaBaseSet.GoodsGmLen.ToInt32())
                    {
                        m.GmCode = m.GbCode + m.GmCode;
                    }
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
            if (Request["confirm"] == null && MyEnv.RecordExist("fb_pa_goods_gs", "gm_code", string.Join(",", ids)))//需要验证是否可以直接删除
            {
                return Json(new SavingResult { Message = "存在子类别，不得删除！", IsSuccess = false }, JsonRequestBehavior.AllowGet);
            }
            FbPaGoodsGmService.Delete(ids);
            return Json(new SavingResult { Message = "删除成功！", IsSuccess = true }, JsonRequestBehavior.AllowGet);
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
            FbPaGoodsGs m = new FbPaGoodsGs();
            m.GsCode = m.GetTableSerialNumber().ToS().FillByStrings('0', FbPaBaseSet.GoodsGsLen.ToInt32());
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
                    if (m.GsCode.Length == FbPaBaseSet.GoodsGsLen.ToInt32())
                    {
                        m.GsCode = m.GmCode + m.GsCode;
                    }
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
            if (Request["confirm"] == null && MyEnv.RecordExist("fb_pa_goods_gl", "gs_code", string.Join(",", ids)))//需要验证是否可以直接删除
            {
                return Json(new SavingResult { Message = "存在子类别，不得删除！", IsSuccess = false }, JsonRequestBehavior.AllowGet);
            }
            FbPaGoodsGsService.Delete(ids);
            return Json(new SavingResult { Message = "删除成功！", IsSuccess = true }, JsonRequestBehavior.AllowGet);

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
                    m.Id = FbPaSupTypeService.Create(m);
                }
                JsonHelper.SaveJsonToFile(FbPaSupTypeService.GetAll(), Server.MapPath("/Data/FbPaSupTypes.js"), "c_FbPaSupTypes");
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

        #region 序列化供货商列表到js文件
        /// <summary>
        /// 序列化供货商列表到js文件
        /// </summary>
        private void SuppliersToJson()
        {
            var suppliers = FbSupplierArchivesService.GetAll().Where(p => p.IfExamine == "1").ToList();
            JsonHelper.SaveJsonToFile(suppliers, Server.MapPath("/Data/c_FbSupplierArchives.js"), "c_FbSupplierArchives");
            JsonHelper.SaveJsonToFile(suppliers, Server.MapPath("/Data/FbSupplierArchives.js"));
        }
        #endregion

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
                    string pre = "";
                    //新增供货商，生成供货商编码
                    if (FbPaBaseSet.SupPrefixType == "经营方式")
                    {
                        pre = m.OpCode;
                    }
                    else if (FbPaBaseSet.SupPrefixType == "指定")
                    {
                        pre = FbPaBaseSet.SupPrefixContent;
                    }
                    string serNum = m.GetTableSerialNumber().ToString().FillByStrings('0', FbPaBaseSet.SupLen.ToInt32());
                    m.Id = pre + serNum;
                    FbSupplierArchivesService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            SuppliersToJson();
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
        public JsonResult SearchFbSupplierArchivesListForList(SearchDtoBase<FbSupplierArchives> c, FbSupplierArchives s)
        {
            c.entity = s;
            return Json(FbSupplierArchivesService.Search(c).data, JsonRequestBehavior.AllowGet);
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
            if (Request["confirm"] == null && MyEnv.RecordExist("fb_goods_archives_supplier", "sup_code", string.Join(",", ids)))//需要验证是否可以直接删除
            {
                return Json(new SavingResult { IsSuccess = false, Message = "供货商存在商品，不可删除！" }, JsonRequestBehavior.AllowGet);
            }
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("if_examine", "1");
            if (MyEnv.RecordExist("fb_supplier_archives", "sup_code", string.Join(",", ids), dic))
            {
                return Json(new SavingResult { IsSuccess = false, Message = "审核的供货商，不可删除！" }, JsonRequestBehavior.AllowGet);
            }
            FbSupplierArchivesService.Delete(ids);
            SuppliersToJson();
            return Json(new SavingResult { IsSuccess = true, Message = "删除成功！" }, JsonRequestBehavior.AllowGet);
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