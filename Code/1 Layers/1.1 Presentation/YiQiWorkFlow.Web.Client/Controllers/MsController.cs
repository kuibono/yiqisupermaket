using NSH.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiQiWorkFlow.Application.Service.Ms;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;
using System.Data;
using YiQiWorkFlow.Web.Client.Common;
using System.Web.Script.Serialization;
using YiQiWorkFlow.Application.Service.Fb;

namespace YiQiWorkFlow.Web.Client.Controllers
{
    public class MsController : Controller
    {
        #region 积分调整管理
        public IMsAdjustPointsService MsAdjustPointsService { get; set; }
        #region 积分调整管理编辑页面
        /// <summary>
        /// 积分调整管理编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsAdjustPointsEdit(int? id)
        {
            MsAdjustPoints m = MsAdjustPoints.Initial();
            if (id.HasValue && id > 0)
            {
                m = MsAdjustPointsService.GetById(id.Value);
            }
            return View(m);
        }
        #endregion

        #region 积分调整管理列表页面
        /// <summary>
        /// 积分调整管理列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsAdjustPointsList()
        {
            return View();
        }
        #endregion

        #region 积分调整管理保存程序
        /// <summary>
        /// 积分调整管理保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsAdjustPoints(MsAdjustPoints m)
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
                    MsAdjustPointsService.Update(m);
                }
                else
                {
                    MsAdjustPointsService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 积分调整管理搜索
        /// <summary>
        /// 积分调整管理搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsAdjustPointsList(SearchDtoBase<MsAdjustPoints> c, MsAdjustPoints s)
        {
            c.entity = s;
            return Json(MsAdjustPointsService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 积分调整管理删除
        /// <summary>
        /// 积分调整管理删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsAdjustPointsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsAdjustPointsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  积分调整管理

        #region 卡作废
        public IMsCancelCardManageService MsCancelCardManageService { get; set; }
        #region 卡作废编辑页面
        /// <summary>
        /// 卡作废编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsCancelCardManageEdit(string id)
        {
            MsCancelCardManage m = MsCancelCardManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsCancelCardManageService.GetById(id);
            }
            else
            {
                m.Id = string.Empty;
            }
            return View(m);
        }
        #endregion

        #region 卡作废列表页面
        /// <summary>
        /// 卡作废列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsCancelCardManageList()
        {
            return View();
        }
        #endregion

        #region 卡作废保存程序
        /// <summary>
        /// 卡作废保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsCancelCardManage(MsCancelCardManage m)
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
                    MsCancelCardManageService.Update(m);
                }
                else
                {
                    // 判断是否可以作废

                    // 作废卡片
                    MsCardArchives card = MsCardArchivesService.GetCardArchivesBySurfaceNumber(m.SurfaceNumber);
                    if (card != null && !string.IsNullOrEmpty(card.Id))
                    {
                        card.CardState = "4";
                    }

                    MsCardArchivesService.Update(card);

                    MsCancelCardManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡作废搜索
        /// <summary>
        /// 卡作废搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsCancelCardManageList(SearchDtoBase<MsCancelCardManage> c, MsCancelCardManage s)
        {
            c.entity = s;
            return Json(MsCancelCardManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡作废删除
        /// <summary>
        /// 卡作废删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsCancelCardManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsCancelCardManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡作废

        #region 卡信息
        public IMsCardArchivesService MsCardArchivesService { get; set; }
        #region 卡信息编辑页面
        /// <summary>
        /// 卡信息编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsCardArchivesEdit(string id)
        {
            MsCardArchives m = MsCardArchives.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsCardArchivesService.GetById(id);
            }
            else
            {
                m.Id = string.Empty;
            }
            return View(m);
        }
        #endregion

        #region 卡信息列表页面
        /// <summary>
        /// 卡信息列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsCardArchivesList()
        {
            return View();
        }
        #endregion

        #region 卡信息保存程序
        /// <summary>
        /// 卡信息保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsCardArchives(MsCardArchives m)
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
                    m.CurrentPrepaidEncrypt = m.CurrentPrepaid.ToUInt16().ToString();
                    MsCardArchivesService.Update(m);
                }
                else
                {
                    // 计算卡号


                    m.CurrentPrepaidEncrypt = m.CurrentPrepaid.ToUInt16().ToString();
                    MsCardArchivesService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡信息搜索
        /// <summary>
        /// 卡信息搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult GetMsCardArchivesListByMadeNumber(SearchDtoBase<MsCardArchives> c, MsCardArchives s, MsMadecardManage m)
        {
            if (!string.IsNullOrEmpty(s.MadeNumber))
            {
                c.entity = s;
                return Json(MsCardArchivesService.Search(c), JsonRequestBehavior.AllowGet);
            }
            else
            {
                //MsMadecardManage m = new MsMadecardManage();
                return GenerateCardArchivesListByMadeCardInfo(m);
            }
        }

        public JsonResult SearchMsCardArchivesList(SearchDtoBase<MsCardArchives> c, MsCardArchives s, MsMadecardManage m)
        {
            c.entity = s;
            return Json(MsCardArchivesService.Search(c), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetMsCardArchivesList()
        {
            var searchDtoBase = MsCardArchivesService.Search(new SearchDtoBase<MsCardArchives>() { pageSize = int.MaxValue, entity = new MsCardArchives() { CardState = "0" } });

            IList<MsCardArchives> msCardArvhicesList = searchDtoBase.data;

            return Json(msCardArvhicesList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GenerateCardArchivesListByMadeCardInfo(MsMadecardManage m)
        {
            List<MsCardArchives> cardArchivesList = GetMsCardArchivesByMadeInfo(m);

            return Json(cardArchivesList.ToArray(), JsonRequestBehavior.AllowGet);

            //return Content(cardArchivesList.ToJson(), "application/json");
        }

        private List<MsCardArchives> GetMsCardArchivesByMadeInfo(MsMadecardManage m)
        {
            // 根据制卡信息生成虚拟卡信息集合
            List<MsCardArchives> cardArchivesList = new List<MsCardArchives>();

            if (m != null)
            {
                // 获取卡类型信息 用于计算卡号 卡面明码
                MsCardtypeManage cardType = MsCardtypeManageService.GetById(m.CardCode);

                for (int i = 0; i < m.MadeQty; i++)
                {
                    string cardName = cardType.CardName;
                    int length = cardType.CardNumberLen.ToInt32() - (Convert.ToInt32(m.BeginCardNumber) + i).ToString().Length;
                    string cardPositionStr = string.Empty;
                    if (length > 0)
                    {
                        for (int j = 0; j < length; j++)
                        {
                            cardPositionStr += "0";
                        }
                    }

                    MsCardArchives entity = new MsCardArchives()
                    {
                        CardCode = m.CardCode,
                        CardName = cardName,
                        CardState = "-1",
                        ClearPoints = 0,
                        CreateDate = DateTime.Now,
                        CurrentPoints = 0,
                        CurrentPrepaid = 0,
                        CurrentPrepaidEncrypt = "0",
                        DepositMoney = 0,
                        ExchangePoints = 0,
                        LastExpendMoney = 0,
                        LimitTimes = 0,
                        MsCode = string.Empty,
                        MsName = string.Empty,
                        PrepaidPassword = string.Empty,
                        SaleTimes = 0,
                        TotalMoney = 0,
                        TotalExpendTimes = 0,
                        TotalPoints = 0,
                        TotalPrepaid = 0,
                        TransactCharge = 0,
                        UsePrepaid = 0,
                        // 卡面明码 = 流水位数 + (开始卡号补充之后的长度) + 
                        SurfaceNumber = cardPositionStr + (m.BeginCardNumber + i).ToString(),

                        // 卡号 = 卡类型前缀 + 卡面明码 + 随机位数
                        Id = cardType.CardNumberPrefix + cardPositionStr + (m.BeginCardNumber + i).ToString() + StaticClass.RandCode(cardType.RandLen.ToInt32())
                    };

                    // 卡有效期、积分有效期 = 制卡发放信息 + 卡类型有效期(逻辑判断)
                    if (m.EffectiveType.Equals("2") && m.EffectiveDate != null && m.EffectiveDate.HasValue)
                    {
                        entity.EffectiveDate = m.EffectiveDate;

                        entity.CardUsefulLifeDate = m.EffectiveDate.Value.AddDays(cardType.CardUsefulLife.ToInt32());
                        entity.CardUsefulLifeDate = m.EffectiveDate.Value.AddDays(cardType.PointsUsefulLife.ToInt32());
                    }

                    if (m.IfMade.Equals("1"))
                    {
                        entity.GrantDate = DateTime.Now;
                    }

                    cardArchivesList.Add(entity);
                }
            }
            return cardArchivesList;
        }

        #endregion

        #region 卡信息删除
        /// <summary>
        /// 卡信息删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsCardArchivesDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsCardArchivesService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡信息

        #region 卡折扣
        public IMsCardtypeDiscountService MsCardtypeDiscountService { get; set; }
        #region 卡折扣编辑页面
        /// <summary>
        /// 卡折扣编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsCardtypeDiscountEdit(string id)
        {
            MsCardtypeDiscount m = MsCardtypeDiscount.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsCardtypeDiscountService.GetById(id);
            }
            else
            {
                m.Id = string.Empty;
            }
            return View(m);
        }
        #endregion

        #region 卡折扣列表页面
        /// <summary>
        /// 卡折扣列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsCardtypeDiscountList()
        {
            return View();
        }
        #endregion

        #region 卡折扣保存程序
        /// <summary>
        /// 卡折扣保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsCardtypeDiscount(MsCardtypeDiscount m)
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
                var cardtypeDiscount = jser.Deserialize<List<MsCardtypeDiscount>>(Request["CardtypeDiscount"]).ToList();
                cardtypeDiscount.ForEach(p =>
                {
                    if (p.HaveId)
                    {
                        MsCardtypeDiscountService.Update(p);
                    }
                    else
                    {
                        MsCardtypeDiscountService.Create(p);
                    }
                });

                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡折扣搜索

        /// <summary>
        /// 卡折扣搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsCardtypeDiscountList(SearchDtoBase<MsCardtypeDiscount> c, MsCardtypeDiscount s)
        {
            var msCardtypeDiscountList = new SearchResult<MsCardtypeDiscount>() { data = new List<MsCardtypeDiscount>() };

            c.entity = s;

            string CardCode = Request["CardCode"];
            if (!string.IsNullOrEmpty(CardCode))
            {
                c.entity.CardCode = CardCode;
            }
            else
            {
                c.entity.CardCode = "!#$";
            }

            IList<MsCardtypeDiscount> tempMsCardtypeDiscountList = MsCardtypeDiscountService.Search(c).data;

            List<GoodsClassDto> goodsClassDtoList = new List<GoodsClassDto>();

            // 遍历赋值
            goodsClassDtoList = GetGoodsClassList();

            MsCardtypeDiscountWithGoodsClassCodeEqualityCompare compare = new MsCardtypeDiscountWithGoodsClassCodeEqualityCompare();
            foreach (var item in goodsClassDtoList)
            {
                if (tempMsCardtypeDiscountList.Contains(new MsCardtypeDiscount() { GoodsClassCode = item.id }, compare))
                {
                    MsCardtypeDiscount entity = tempMsCardtypeDiscountList.FirstOrDefault(x => x.GoodsClassCode == item.id);

                    if (!msCardtypeDiscountList.data.Contains(entity, compare))
                    {
                        entity.ParentGoodsClassCode = item.pid;
                        msCardtypeDiscountList.data.Add(entity);
                    }
                }
                else
                {
                    MsCardtypeDiscount entity = new MsCardtypeDiscount()
                    {
                        CardCode = CardCode,
                        ClassDiscountRate = 1,
                        DiscountBase = 0,
                        GoodsClassCode = item.id,
                        GoodsClassName = item.text,
                        ParentGoodsClassCode = item.pid
                    };

                    if (!msCardtypeDiscountList.data.Contains(entity, compare))
                    {
                        msCardtypeDiscountList.data.Add(entity);
                    }
                }
            }

            return Json(msCardtypeDiscountList.data.ToArray(), JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region 卡折扣删除
        /// <summary>
        /// 卡折扣删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsCardtypeDiscountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsCardtypeDiscountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #endregion  卡折扣

        #region 商品折扣
        public IMsCardtypeGoodsDiscountService MsCardtypeGoodsDiscountService { get; set; }
        #region 商品折扣编辑页面
        /// <summary>
        /// 商品折扣编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsCardtypeGoodsDiscountEdit(string id)
        {
            MsCardtypeGoodsDiscount m = MsCardtypeGoodsDiscount.Initial();

            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsCardtypeGoodsDiscountService.GetById(id);
            }
            else
            {
                m.Id = string.Empty;
            }
            return View(m);
        }
        #endregion

        #region 商品折扣列表页面
        /// <summary>
        /// 商品折扣列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsCardtypeGoodsDiscountList()
        {
            return View();
        }
        #endregion

        #region 商品折扣保存程序
        /// <summary>
        /// 商品折扣保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsCardtypeGoodsDiscount(MsCardtypeGoodsDiscount m)
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
                var suppliers = jser.Deserialize<List<MsCardtypeGoodsDiscount>>(Request["goods"]).ToList();
                suppliers.ForEach(p =>
                {
                    if (m.HaveId)
                    {
                        MsCardtypeGoodsDiscountService.Update(m);
                    }
                    else
                    {
                        MsCardtypeGoodsDiscountService.Create(m);
                    }
                });

                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品折扣搜索
        /// <summary>
        /// 商品折扣搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsCardtypeGoodsDiscountList(SearchDtoBase<MsCardtypeGoodsDiscount> c, MsCardtypeGoodsDiscount s)
        {
            c.entity = s;

            string CardCode = Request["CardCode"];
            if (!string.IsNullOrEmpty(CardCode))
            {
                c.entity.CardCode = CardCode;
            }

            return Json(MsCardtypeGoodsDiscountService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品折扣删除
        /// <summary>
        /// 商品折扣删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsCardtypeGoodsDiscountDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsCardtypeGoodsDiscountService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品折扣

        #region 商品积分
        public IMsCardtypeGoodsPointsService MsCardtypeGoodsPointsService { get; set; }
        #region 商品积分编辑页面
        /// <summary>
        /// 商品积分编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsCardtypeGoodsPointsEdit(string id)
        {
            MsCardtypeGoodsPoints m = MsCardtypeGoodsPoints.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsCardtypeGoodsPointsService.GetById(id);
            }
            else
            {
                m.Id = string.Empty;
            }
            return View(m);
        }
        #endregion

        #region 商品积分列表页面
        /// <summary>
        /// 商品积分列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsCardtypeGoodsPointsList()
        {
            return View();
        }
        #endregion

        #region 商品积分保存程序
        /// <summary>
        /// 商品积分保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsCardtypeGoodsPoints(MsCardtypeGoodsPoints m)
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
                var suppliers = jser.Deserialize<List<MsCardtypeGoodsDiscount>>(Request["goods"]).ToList();
                suppliers.ForEach(p =>
                {
                    if (m.HaveId)
                    {
                        MsCardtypeGoodsPointsService.Update(m);
                    }
                    else
                    {
                        MsCardtypeGoodsPointsService.Create(m);
                    }
                });
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 商品积分搜索
        /// <summary>
        /// 商品积分搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsCardtypeGoodsPointsList(SearchDtoBase<MsCardtypeGoodsPoints> c, MsCardtypeGoodsPoints s)
        {
            c.entity = s;

            string CardCode = Request["CardCode"];
            if (!string.IsNullOrEmpty(CardCode))
            {
                c.entity.CardCode = CardCode;
            }

            return Json(MsCardtypeGoodsPointsService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 商品积分删除
        /// <summary>
        /// 商品积分删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsCardtypeGoodsPointsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsCardtypeGoodsPointsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  商品积分

        #region 卡类型
        public IMsCardtypeManageService MsCardtypeManageService { get; set; }
        #region 卡类型编辑页面
        /// <summary>
        /// 卡类型编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsCardtypeManageEdit(string id)
        {
            MsCardtypeManage m = MsCardtypeManage.Initial();

            ViewData["CardCode"] = string.Empty;
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsCardtypeManageService.GetById(id);
                ViewData["CardCode"] = m.Id;
            }
            else
            {
                m.Id = string.Empty;
                m.CardType = "1";
                m.CardMedium = "1";
                m.CardUsefulLife = 365;
                m.PointsUsefulLife = 365;
                m.IfVip = "1";
                m.DiscountRate = 1;
                m.BirthdayPoints = 1;
                m.UpgradeType = "1";
                ViewData["CardCode"] = MsCardtypeManageService.GenerateCardtypeCode();
            }
            return View(m);
        }
        #endregion

        #region 卡类型列表页面
        /// <summary>
        /// 卡类型列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsCardtypeManageList()
        {
            return View();
        }
        #endregion

        #region 卡类型保存程序
        /// <summary>
        /// 卡类型保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsCardtypeManage(MsCardtypeManage m)
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
                    // 当前操作人 操作时间
                    m.OperatorDate = DateTime.Now;

                    if (!string.IsNullOrEmpty(m.IfExamine) && !m.IfExamine.Equals("0") && m.ExamineDate == null)
                    {
                        m.ExamineDate = DateTime.Now;
                    }
                    MsCardtypeManageService.Update(m);
                }
                else
                {
                    // 操作人 创建时间
                    m.CreateDate = DateTime.Now;

                    if (string.IsNullOrEmpty(m.IfExamine))
                    {
                        m.IfExamine = "0";
                    }

                    MsCardtypeManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡类型搜索
        /// <summary>
        /// 卡类型搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsCardtypeManageList(SearchDtoBase<MsCardtypeManage> c, MsCardtypeManage s)
        {
            c.entity = s;
            return Json(MsCardtypeManageService.Search(c), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetMsCardtypeManageList()
        {
            var searchDtoBase = MsCardtypeManageService.Search(new SearchDtoBase<MsCardtypeManage>() { pageSize = int.MaxValue, entity = new MsCardtypeManage() { IfExamine = "1" } });

            IList<MsCardtypeManage> msCardtypeManageList = searchDtoBase.data;

            return Json(msCardtypeManageList.Select(entity => new { Id = entity.Id, CardName = entity.CardName }), JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region 卡类型删除
        /// <summary>
        /// 卡类型删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsCardtypeManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsCardtypeManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡类型

        #region 卡积分
        public IMsCardtypePointsService MsCardtypePointsService { get; set; }
        #region 卡积分编辑页面
        /// <summary>
        /// 卡积分编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsCardtypePointsEdit(string id)
        {
            MsCardtypePoints m = MsCardtypePoints.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsCardtypePointsService.GetById(id);
            }
            else
            {
                m.Id = string.Empty;
            }
            return View(m);
        }
        #endregion

        #region 卡积分列表页面
        /// <summary>
        /// 卡积分列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsCardtypePointsList()
        {
            return View();
        }
        #endregion

        #region 卡积分保存程序
        /// <summary>
        /// 卡积分保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsCardtypePoints(MsCardtypePoints m)
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
                var cardtypeDiscount = jser.Deserialize<List<MsCardtypePoints>>(Request["MsCardtypePoints"]).ToList();
                cardtypeDiscount.ForEach(p =>
                {
                    if (p.HaveId)
                    {
                        MsCardtypePointsService.Update(p);
                    }
                    else
                    {
                        MsCardtypePointsService.Create(p);
                    }
                });

                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡积分搜索
        /// <summary>
        /// 卡积分搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsCardtypePointsList(SearchDtoBase<MsCardtypePoints> c, MsCardtypePoints s)
        {
            //c.entity = s;

            //string CardCode = Request["CardCode"];
            //if (!string.IsNullOrEmpty(CardCode))
            //{
            //    c.entity.CardCode = CardCode;
            //}

            //return Json(MsCardtypePointsService.Search(c), JsonRequestBehavior.AllowGet);

            var msCardtypePointsList = new SearchResult<MsCardtypePoints>() { data = new List<MsCardtypePoints>() };

            c.entity = s;

            string CardCode = Request["CardCode"];
            if (!string.IsNullOrEmpty(CardCode))
            {
                c.entity.CardCode = CardCode;
            }
            else
            {
                c.entity.CardCode = "!#$";
            }

            IList<MsCardtypePoints> tempMsCardtypeDiscountList = MsCardtypePointsService.Search(c).data;

            List<GoodsClassDto> goodsClassDtoList = new List<GoodsClassDto>();

            // 遍历赋值
            goodsClassDtoList = GetGoodsClassList();

            MsCardtypePointsWithGoodsClassCodeEqualityCompare compare = new MsCardtypePointsWithGoodsClassCodeEqualityCompare();
            foreach (var item in goodsClassDtoList)
            {
                if (tempMsCardtypeDiscountList.Contains(new MsCardtypePoints() { GoodsClassCode = item.id }, compare))
                {
                    MsCardtypePoints entity = tempMsCardtypeDiscountList.FirstOrDefault(x => x.GoodsClassCode == item.id);

                    if (!msCardtypePointsList.data.Contains(entity, compare))
                    {
                        //entity.ParentGoodsClassCode = item.pid;
                        msCardtypePointsList.data.Add(entity);
                    }
                }
                else
                {
                    MsCardtypePoints entity = new MsCardtypePoints()
                    {
                        CardCode = CardCode,
                        ExpendBase = 0,
                        PointsValues = 0,
                        GoodsClassCode = item.id,
                        GoodsClassName = item.text,
                        //ParentGoodsClassCode = item.pid
                    };

                    if (!msCardtypePointsList.data.Contains(entity, compare))
                    {
                        msCardtypePointsList.data.Add(entity);
                    }
                }
            }

            return Json(msCardtypePointsList, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡积分删除
        /// <summary>
        /// 卡积分删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsCardtypePointsDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsCardtypePointsService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡积分

        #region 赠品兑换明细
        public IMsExchangeDetailService MsExchangeDetailService { get; set; }
        #region 赠品兑换明细编辑页面
        /// <summary>
        /// 赠品兑换明细编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsExchangeDetailEdit(string id)
        {
            MsExchangeDetail m = MsExchangeDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsExchangeDetailService.GetById(id);
            }
            else
            {
                m.Id = string.Empty;
            }
            return View(m);
        }
        #endregion

        #region 赠品兑换明细列表页面
        /// <summary>
        /// 赠品兑换明细列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsExchangeDetailList()
        {
            return View();
        }
        #endregion

        #region 赠品兑换明细保存程序
        /// <summary>
        /// 赠品兑换明细保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsExchangeDetail(MsExchangeDetail m)
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
                    MsExchangeDetailService.Update(m);
                }
                else
                {
                    MsExchangeDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 赠品兑换明细搜索
        /// <summary>
        /// 赠品兑换明细搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsExchangeDetailList(SearchDtoBase<MsExchangeDetail> c, MsExchangeDetail s)
        {
            c.entity = s;
            return Json(MsExchangeDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 赠品兑换明细删除
        /// <summary>
        /// 赠品兑换明细删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsExchangeDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsExchangeDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  赠品兑换明细

        #region 赠品兑换管理
        public IMsExchangeManageService MsExchangeManageService { get; set; }
        #region 赠品兑换管理编辑页面
        /// <summary>
        /// 赠品兑换管理编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsExchangeManageEdit(int? id)
        {
            MsExchangeManage m = MsExchangeManage.Initial();
            if (id.HasValue && id > 0)
            {
                m = MsExchangeManageService.GetById(id.Value);
            }

            return View(m);
        }
        #endregion

        #region 赠品兑换管理列表页面
        /// <summary>
        /// 赠品兑换管理列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsExchangeManageList()
        {
            return View();
        }
        #endregion

        #region 赠品兑换管理保存程序
        /// <summary>
        /// 赠品兑换管理保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsExchangeManage(MsExchangeManage m)
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
                    MsExchangeManageService.Update(m);
                }
                else
                {
                    MsExchangeManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 赠品兑换管理搜索
        /// <summary>
        /// 赠品兑换管理搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsExchangeManageList(SearchDtoBase<MsExchangeManage> c, MsExchangeManage s)
        {
            c.entity = s;
            return Json(MsExchangeManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 赠品兑换管理删除
        /// <summary>
        /// 赠品兑换管理删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsExchangeManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsExchangeManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  赠品兑换管理

        #region 卡冻结
        public IMsFreezeCardManageService MsFreezeCardManageService { get; set; }
        #region 卡冻结编辑页面
        /// <summary>
        /// 卡冻结编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsFreezeCardManageEdit(string id)
        {
            MsFreezeCardManage m = MsFreezeCardManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsFreezeCardManageService.GetById(id);
            }
            else
            {
                m.Id = string.Empty;
            }
            return View(m);
        }
        #endregion

        #region 卡冻结列表页面
        /// <summary>
        /// 卡冻结列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsFreezeCardManageList()
        {
            return View();
        }
        #endregion

        #region 卡冻结保存程序
        /// <summary>
        /// 卡冻结保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsFreezeCardManage(MsFreezeCardManage m)
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
                    MsFreezeCardManageService.Update(m);
                }
                else
                {
                    // 判断是否可以冻结

                    // 冻结卡片
                    MsCardArchives card = MsCardArchivesService.GetCardArchivesBySurfaceNumber(m.SurfaceNumber);
                    if (card != null && !string.IsNullOrEmpty(card.Id))
                    {
                        card.CardState = "3";
                    }

                    MsCardArchivesService.Update(card);

                    MsFreezeCardManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡冻结搜索
        /// <summary>
        /// 卡冻结搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsFreezeCardManageList(SearchDtoBase<MsFreezeCardManage> c, MsFreezeCardManage s)
        {
            c.entity = s;
            return Json(MsFreezeCardManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡冻结删除
        /// <summary>
        /// 卡冻结删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsFreezeCardManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsFreezeCardManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡冻结

        #region 赠品档案管理
        public IMsGiftArchivesService MsGiftArchivesService { get; set; }
        #region 赠品档案管理编辑页面
        /// <summary>
        /// 赠品档案管理编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsGiftArchivesEdit(string id)
        {
            MsGiftArchives m = MsGiftArchives.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsGiftArchivesService.GetById(id);
            }
            else
            {
                m.Id = string.Empty;
            }
            return View(m);
        }
        #endregion

        #region 赠品档案管理列表页面
        /// <summary>
        /// 赠品档案管理列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsGiftArchivesList()
        {
            return View();
        }
        #endregion

        #region 赠品档案管理保存程序
        /// <summary>
        /// 赠品档案管理保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsGiftArchives(MsGiftArchives m)
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
                    MsGiftArchivesService.Update(m);
                }
                else
                {
                    MsGiftArchivesService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 赠品档案管理搜索
        /// <summary>
        /// 赠品档案管理搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsGiftArchivesList(SearchDtoBase<MsGiftArchives> c, MsGiftArchives s)
        {
            c.entity = s;
            return Json(MsGiftArchivesService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 赠品档案管理删除
        /// <summary>
        /// 赠品档案管理删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsGiftArchivesDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsGiftArchivesService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  赠品档案管理

        #region 卡发放
        public IMsGrantCardManageService MsGrantCardManageService { get; set; }
        #region 卡发放编辑页面
        /// <summary>
        /// 卡发放编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsGrantCardManageEdit(string id)
        {
            MsGrantCardManage m = MsGrantCardManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsGrantCardManageService.GetById(id);
            }
            else
            {
                m.Id = string.Empty;
            }
            return View(m);
        }
        #endregion

        #region 卡发放列表页面
        /// <summary>
        /// 卡发放列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsGrantCardManageList()
        {
            return View();
        }
        #endregion

        #region 卡发放保存程序
        /// <summary>
        /// 卡发放保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsGrantCardManage(MsGrantCardManage m)
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
                    //MsGrantCardManageService.Update(m);
                }
                else
                {
                    // 发放逻辑 1 : 更新卡状态、卡所属会员编号
                    MsCardArchives msCardArchivesEntity = MsCardArchivesService.GetById(m.CardNumber);
                    if (msCardArchivesEntity != null && !string.IsNullOrEmpty(msCardArchivesEntity.Id))
                    {
                        msCardArchivesEntity.CardState = "1";

                        // 判断是否是发卡生效期,是则 开始赋值
                        if (msCardArchivesEntity.CardUsefulLifeDate == null)
                        {
                            MsCardtypeManage msCardtypeManageEntity = MsCardtypeManageService.GetById(m.CardCode);
                            msCardArchivesEntity.CardUsefulLifeDate = DateTime.Now.AddYears(msCardtypeManageEntity.CardUsefulLife.ToInt32());
                            msCardArchivesEntity.PointsUsefulLifeDate = DateTime.Now.AddYears(msCardtypeManageEntity.CardUsefulLife.ToInt32());
                            msCardArchivesEntity.GrantDate = DateTime.Now;
                            msCardArchivesEntity.OperatorDate = DateTime.Now;
                        }

                        // 修改卡信息
                        MsCardArchivesService.Update(msCardArchivesEntity);
                    }

                    // 发放逻辑 2 : 会员信息(判断是否需要新增会员)
                    if (true)
                    {
                    }

                    MsGrantCardManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡发放搜索
        /// <summary>
        /// 卡发放搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsGrantCardManageList(SearchDtoBase<MsGrantCardManage> c, MsGrantCardManage s)
        {
            c.entity = s;
            return Json(MsGrantCardManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡发放删除
        /// <summary>
        /// 卡发放删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsGrantCardManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsGrantCardManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡发放

        #region 卡挂失
        public IMsLossCardManageService MsLossCardManageService { get; set; }
        #region 卡挂失编辑页面
        /// <summary>
        /// 卡挂失编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsLossCardManageEdit(string id)
        {
            MsLossCardManage m = MsLossCardManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsLossCardManageService.GetById(id);
            }
            else
            {
                m.Id = string.Empty;
            }
            return View(m);
        }
        #endregion

        #region 卡挂失列表页面
        /// <summary>
        /// 卡挂失列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsLossCardManageList()
        {
            return View();
        }
        #endregion

        #region 卡挂失保存程序
        /// <summary>
        /// 卡挂失保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsLossCardManage(MsLossCardManage m)
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
                    MsLossCardManageService.Update(m);
                }
                else
                {
                    // 判断是否可以挂失

                    // 挂失卡片
                    MsCardArchives card = MsCardArchivesService.GetCardArchivesBySurfaceNumber(m.SurfaceNumber);
                    if (card != null && !string.IsNullOrEmpty(card.Id))
                    {
                        card.CardState = "2";
                    }

                    MsCardArchivesService.Update(card);

                    MsLossCardManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡挂失搜索
        /// <summary>
        /// 卡挂失搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsLossCardManageList(SearchDtoBase<MsLossCardManage> c, MsLossCardManage s)
        {
            c.entity = s;
            return Json(MsLossCardManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡挂失删除
        /// <summary>
        /// 卡挂失删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsLossCardManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsLossCardManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡挂失

        #region 卡制作
        public IMsMadecardManageService MsMadecardManageService { get; set; }
        #region 卡制作编辑页面
        /// <summary>
        /// 卡制作编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsMadecardManageEdit(string id)
        {
            MsMadecardManage m = MsMadecardManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsMadecardManageService.GetById(id);
            }
            else
            {
                m.Id = string.Empty;
            }
            return View(m);
        }
        #endregion

        #region 卡制作列表页面
        /// <summary>
        /// 卡制作列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsMadecardManageList()
        {
            return View();
        }
        #endregion

        #region 卡制作保存程序
        /// <summary>
        /// 卡制作保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsMadecardManage(MsMadecardManage m)
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
                    // 当前操作人 操作时间
                    m.OperatorDate = DateTime.Now;

                    if (!string.IsNullOrEmpty(m.IfExamine) && !m.IfExamine.Equals("0") && m.ExamineDate == null)
                    {
                        // 审核逻辑 : 制卡
                        MsCardArchivesService.ExamByMadeCardManage(m);

                        MsMadecardManage entity = MsMadecardManageService.GetById(m.Id);
                        entity.ExamineDate = DateTime.Now;
                        entity.IfExamine = m.IfExamine;
                        MsMadecardManageService.Update(entity);
                    }

                    r.IsSuccess = true;
                    r.Message = "审核成功";

                    MsMadecardManageService.Update(m);
                }
                else
                {
                    // 获取卡信息集合
                    List<MsCardArchives> cardArchivesList = GetMsCardArchivesByMadeInfo(m);

                    // 验证是否重复卡号,没有重复保存,否则返回false 和 error message
                    string message = MsCardArchivesService.SaveList(cardArchivesList);

                    if (string.IsNullOrEmpty(message))
                    {
                        // 操作人 创建时间
                        m.CreateDate = DateTime.Now;

                        if (string.IsNullOrEmpty(m.IfExamine))
                        {
                            m.IfExamine = "0";
                        }

                        MsMadecardManageService.Create(m);

                        foreach (var item in cardArchivesList)
                        {
                            item.MadeNumber = m.Id;
                            MsCardArchivesService.Update(item);
                        }

                        r.IsSuccess = true;
                        r.Message = "保存成功";
                    }
                    else
                    {
                        r.IsSuccess = false;
                        r.Message = message;
                    }
                }
            }
            return Json(r);
        }
        #endregion

        #region 卡制作搜索
        /// <summary>
        /// 卡制作搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsMadecardManageList(SearchDtoBase<MsMadecardManage> c, MsMadecardManage s)
        {
            c.entity = s;
            return Json(MsMadecardManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡制作删除
        /// <summary>
        /// 卡制作删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsMadecardManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsMadecardManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡制作

        #region 会员信息
        public IMsMemberArchivesService MsMemberArchivesService { get; set; }
        #region 会员信息编辑页面
        /// <summary>
        /// 会员信息编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsMemberArchivesEdit(string id)
        {
            MsMemberArchives m = MsMemberArchives.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsMemberArchivesService.GetById(id);
            }
            else
            {
                m.CardNumber = MsMemberArchivesService.GenerateMsCode();
            }
            return View(m);
        }
        #endregion

        #region 会员信息列表页面
        /// <summary>
        /// 会员信息列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsMemberArchivesList()
        {
            return View();
        }
        #endregion

        #region 会员信息保存程序
        /// <summary>
        /// 会员信息保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsMemberArchives(MsMemberArchives m)
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
                    MsMemberArchivesService.Update(m);
                }
                else
                {
                    MsMemberArchivesService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 会员信息搜索
        /// <summary>
        /// 会员信息搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsMemberArchivesList(SearchDtoBase<MsMemberArchives> c, MsMemberArchives s)
        {
            c.entity = s;
            return Json(MsMemberArchivesService.Search(c), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetMsMemberArchivesList()
        {
            var searchDtoBase = MsMemberArchivesService.Search(new SearchDtoBase<MsMemberArchives>() { pageSize = int.MaxValue });

            IList<MsMemberArchives> msCardtypeManageList = searchDtoBase.data;

            return Json(msCardtypeManageList.Select(entity => new { id = entity.CardNumber, text = entity.MsName, mscode = entity.Id, cardNumber = entity.CardNumber, msName = entity.MsName, sex = entity.Sex, idCard = entity.Idcard, birthday = entity.Birthday, handSet = entity.Handset }), JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region 会员信息删除
        /// <summary>
        /// 会员信息删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsMemberArchivesDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsMemberArchivesService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  会员信息

        #region 积分清零管理
        public IMsPointsClearService MsPointsClearService { get; set; }
        #region 积分清零管理编辑页面
        /// <summary>
        /// 积分清零管理编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsPointsClearEdit(int? id)
        {
            MsPointsClear m = MsPointsClear.Initial();
            if (id.HasValue && id > 0)
            {
                m = MsPointsClearService.GetById(id.Value);
            }

            return View(m);
        }
        #endregion

        #region 积分清零管理列表页面
        /// <summary>
        /// 积分清零管理列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsPointsClearList()
        {
            return View();
        }
        #endregion

        #region 积分清零管理保存程序
        /// <summary>
        /// 积分清零管理保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsPointsClear(MsPointsClear m)
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
                    MsPointsClearService.Update(m);
                }
                else
                {
                    MsPointsClearService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 积分清零管理搜索
        /// <summary>
        /// 积分清零管理搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsPointsClearList(SearchDtoBase<MsPointsClear> c, MsPointsClear s)
        {
            c.entity = s;
            return Json(MsPointsClearService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 积分清零管理删除
        /// <summary>
        /// 积分清零管理删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsPointsClearDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsPointsClearService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  积分清零管理

        #region 积分转储值
        public IMsPointtoprepaidManageService MsPointtoprepaidManageService { get; set; }
        #region 积分转储值编辑页面
        /// <summary>
        /// 积分转储值编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsPointtoprepaidManageEdit(int? id)
        {
            MsPointtoprepaidManage m = MsPointtoprepaidManage.Initial();
            if (id.HasValue && id > 0)
            {
                m = MsPointtoprepaidManageService.GetById(id.Value);
            }
            return View(m);
        }
        #endregion

        #region 积分转储值列表页面
        /// <summary>
        /// 积分转储值列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsPointtoprepaidManageList()
        {
            return View();
        }
        #endregion

        #region 积分转储值保存程序
        /// <summary>
        /// 积分转储值保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsPointtoprepaidManage(MsPointtoprepaidManage m)
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
                    MsPointtoprepaidManageService.Update(m);
                }
                else
                {
                    MsPointtoprepaidManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 积分转储值搜索
        /// <summary>
        /// 积分转储值搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsPointtoprepaidManageList(SearchDtoBase<MsPointtoprepaidManage> c, MsPointtoprepaidManage s)
        {
            c.entity = s;
            return Json(MsPointtoprepaidManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 积分转储值删除
        /// <summary>
        /// 积分转储值删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsPointtoprepaidManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsPointtoprepaidManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  积分转储值

        #region 卡充值
        public IMsPrepaidCardManageService MsPrepaidCardManageService { get; set; }
        #region 卡充值编辑页面
        /// <summary>
        /// 卡充值编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsPrepaidCardManageEdit(string id)
        {
            MsPrepaidCardManage m = MsPrepaidCardManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsPrepaidCardManageService.GetById(id);
            }
            else
            {
                m.Id = string.Empty;
            }
            return View(m);
        }
        #endregion

        #region 卡充值列表页面
        /// <summary>
        /// 卡充值列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsPrepaidCardManageList()
        {
            return View();
        }
        #endregion

        #region 卡充值保存程序
        /// <summary>
        /// 卡充值保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsPrepaidCardManage(MsPrepaidCardManage m)
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
                    MsPrepaidCardManageService.Update(m);
                }
                else
                {
                    // 卡充值,获取卡类型信息,判断是否超越了充值上限(当前余额+充值金额 <= 上限)


                    MsPrepaidCardManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡充值搜索
        /// <summary>
        /// 卡充值搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsPrepaidCardManageList(SearchDtoBase<MsPrepaidCardManage> c, MsPrepaidCardManage s)
        {
            c.entity = s;
            return Json(MsPrepaidCardManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡充值删除
        /// <summary>
        /// 卡充值删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsPrepaidCardManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsPrepaidCardManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡充值

        #region 卡回收
        public IMsReclaimCardManageService MsReclaimCardManageService { get; set; }
        #region 卡回收编辑页面
        /// <summary>
        /// 卡回收编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsReclaimCardManageEdit(string id)
        {
            MsReclaimCardManage m = MsReclaimCardManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsReclaimCardManageService.GetById(id);
            }
            else
            {
                m.Id = string.Empty;
            }
            return View(m);
        }
        #endregion

        #region 卡回收列表页面
        /// <summary>
        /// 卡回收列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsReclaimCardManageList()
        {
            return View();
        }
        #endregion

        #region 卡回收保存程序
        /// <summary>
        /// 卡回收保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsReclaimCardManage(MsReclaimCardManage m)
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
                    MsReclaimCardManageService.Update(m);
                }
                else
                {
                    MsReclaimCardManageService.Create(m);

                    // 回收卡片
                    MsCardArchives card = MsCardArchivesService.GetCardArchivesBySurfaceNumber(m.SurfaceNumber);
                    
                    // @todo主要数据清空

                    if (card != null && !string.IsNullOrEmpty(card.Id))
                    {
                        card.CardState = "4";
                    }
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡回收搜索
        /// <summary>
        /// 卡回收搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsReclaimCardManageList(SearchDtoBase<MsReclaimCardManage> c, MsReclaimCardManage s)
        {
            c.entity = s;
            return Json(MsReclaimCardManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡回收删除
        /// <summary>
        /// 卡回收删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsReclaimCardManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsReclaimCardManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡回收

        #region 卡更新
        public IMsUpdateCardManageService MsUpdateCardManageService { get; set; }
        #region 卡更新编辑页面
        /// <summary>
        /// 卡更新编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsUpdateCardManageEdit(string id)
        {
            MsUpdateCardManage m = MsUpdateCardManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsUpdateCardManageService.GetById(id);
            }
            else
            {
                m.Id = string.Empty;
            }
            return View(m);
        }
        #endregion

        #region 卡更新列表页面
        /// <summary>
        /// 卡更新列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsUpdateCardManageList()
        {
            return View();
        }
        #endregion

        #region 卡更新保存程序
        /// <summary>
        /// 卡更新保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsUpdateCardManage(MsUpdateCardManage m)
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
                    MsUpdateCardManageService.Update(m);
                }
                else
                {
                    // 获取旧卡信息

                    // 获取新卡信息

                    // 复制旧卡信息,保存

                    MsUpdateCardManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡更新搜索
        /// <summary>
        /// 卡更新搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsUpdateCardManageList(SearchDtoBase<MsUpdateCardManage> c, MsUpdateCardManage s)
        {
            c.entity = s;
            return Json(MsUpdateCardManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡更新删除
        /// <summary>
        /// 卡更新删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsUpdateCardManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsUpdateCardManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡更新

        #region 卡升级信息
        public IMsUpgradeCardDetailService MsUpgradeCardDetailService { get; set; }
        #region 卡升级信息编辑页面
        /// <summary>
        /// 卡升级信息编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsUpgradeCardDetailEdit(string id)
        {
            MsUpgradeCardDetail m = MsUpgradeCardDetail.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsUpgradeCardDetailService.GetById(id);
            }
            else
            {
                m.Id = string.Empty;
            }
            return View(m);
        }
        #endregion

        #region 卡升级信息列表页面
        /// <summary>
        /// 卡升级信息列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsUpgradeCardDetailList()
        {
            // 查询语句
            //            select aa.card_number,aa.surface_number,aa.card_code as card_code_old,aa.card_name as card_name_old,bb.card_code,bb.card_name,
            //    (case bb.if_deduct_points when '1' then bb.points_needs else 0 end) as deduct_points ,aa.total_points,aa.exchange_points,
            //    aa.current_points,aa.clear_points,aa.card_state,'' as upgrade_number,'0' as if_select ,'0' as select_all
            //from 
            //(
            //select a.card_number,a.surface_number,a.card_code,a.card_name,a.total_points,a.exchange_points,a.current_points,a.clear_points,a.card_state,b.points_needs from ms_card_archives a , ms_cardtype_manage b
            //where a.card_code = b.card_code and a.card_state = '1' 
            //) aa,
            //(select card_code,card_name,points_needs,if_deduct_points from ms_cardtype_manage ) bb
            //where bb.points_needs > aa.points_needs and bb.points_needs <= aa.current_points
            //"  sort="card_number A deduct_points A

            return View();
        }
        #endregion

        #region 卡升级信息保存程序
        /// <summary>
        /// 卡升级信息保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsUpgradeCardDetail(MsUpgradeCardDetail m)
        {
            //update ms_card_archives set card_code = :ls_card_code, card_name = :ls_card_name,
            //    current_points = isnull(current_points,0) - :ldc_deduct_points ,
            //    clear_points = isnull(clear_points,0) + :ldc_deduct_points,
            //    operator = :gs_em_code ,operator_date = getdate() where card_number = :ls_card_number;

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
                    MsUpgradeCardDetailService.Update(m);
                }
                else
                {
                    // 卡升级detail...

                    MsUpgradeCardDetailService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡升级信息搜索
        /// <summary>
        /// 卡升级信息搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsUpgradeCardDetailList(SearchDtoBase<MsUpgradeCardDetail> c, MsUpgradeCardDetail s)
        {
            c.entity = s;
            return Json(MsUpgradeCardDetailService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡升级信息删除
        /// <summary>
        /// 卡升级信息删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsUpgradeCardDetailDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsUpgradeCardDetailService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡升级信息

        #region 卡升级
        public IMsUpgradeCardManageService MsUpgradeCardManageService { get; set; }
        #region 卡升级编辑页面
        /// <summary>
        /// 卡升级编辑页面
        /// </summary>
        /// <param name="id">主键，没有就是新增</param>
        /// <returns></returns>
        public ActionResult MsUpgradeCardManageEdit(string id)
        {
            MsUpgradeCardManage m = MsUpgradeCardManage.Initial();
            if (string.IsNullOrEmpty(id) == false)
            {
                m = MsUpgradeCardManageService.GetById(id);
            }
            else
            {
                m.Id = string.Empty;
            }
            return View(m);
        }
        #endregion

        #region 卡升级列表页面
        /// <summary>
        /// 卡升级列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult MsUpgradeCardManageList()
        {
            return View();
        }
        #endregion

        #region 卡升级保存程序
        /// <summary>
        /// 卡升级保存程序
        /// </summary>
        /// <param name="m">表单数据</param>
        /// <returns></returns>
        public ActionResult SaveMsUpgradeCardManage(MsUpgradeCardManage m)
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
                    MsUpgradeCardManageService.Update(m);
                }
                else
                {
                    MsUpgradeCardManageService.Create(m);
                }
                r.IsSuccess = true;
                r.Message = "保存成功";
            }
            return Json(r);
        }
        #endregion

        #region 卡升级搜索
        /// <summary>
        /// 卡升级搜索
        /// </summary>
        /// <param name="c">搜索dto包括keyword分页数据</param>
        /// <param name="s">搜索内容，表数据填充</param>
        /// <returns></returns>
        public JsonResult SearchMsUpgradeCardManageList(SearchDtoBase<MsUpgradeCardManage> c, MsUpgradeCardManage s)
        {
            c.entity = s;
            return Json(MsUpgradeCardManageService.Search(c), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 卡升级删除
        /// <summary>
        /// 卡升级删除
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public JsonResult MsUpgradeCardManageDelete(List<string> ids)
        {
            if (Request["confirm"] == null)//需要验证是否可以直接删除
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            MsUpgradeCardManageService.Delete(ids);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion  卡升级

        #region 商品类别

        public ActionResult GetGoodTypeComboData()
        {
            Dictionary<string, string> searchOptions = new Dictionary<string, string>();
            string table = "v_fb_class";
            string valueColumn = "class_code";
            string textColumn = "class_name";

            string str_sql = string.Format("select distinct {0} as value,{1} as text from {2} where class_code <> '01' order by class_level,class_code ", valueColumn, textColumn, table);
            if (searchOptions.Count > 0)
            {
                str_sql += " where ";
                foreach (var options in searchOptions)
                {
                    str_sql += string.Format("{0}='{1}' and", options.Key, options.Value);
                }
                if (str_sql.EndsWith("and"))
                {
                    str_sql = str_sql.Substring(0, str_sql.Length - 3);
                }
            }
            DataTable _tb = MyEnv.GetSqlHelper().ExecuteDataTable(CommandType.Text, str_sql);
            Dictionary<string, string> result = new Dictionary<string, string>();
            foreach (DataRow row in _tb.Rows)
            {
                result.Add(row["value"].ToString(), row["text"].ToString());
            }
            return Json(result.Select(p => new { id = p.Key, text = p.Value }), JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region 自定义方法

        public IFbPaGoodsGbService FbPaGoodsGbService { get; set; }
        public IFbPaGoodsGmService FbPaGoodsGmService { get; set; }
        public IFbPaGoodsGsService FbPaGoodsGsService { get; set; }
        public IFbPaGoodsGlService FbPaGoodsGlService { get; set; }

        private List<GoodsClassDto> GetGoodsClassList()
        {
            List<GoodsClassDto> goodsClassDtoList = new List<GoodsClassDto>();
            #region 获取商品类别信息

            var gb = FbPaGoodsGbService.GetAll().Where(entity => entity.GbCode != "01").ToList();
            var gm = FbPaGoodsGmService.GetAll().Where(entity => entity.GmCode != "01").ToList();
            var gs = FbPaGoodsGsService.GetAll().Where(entity => entity.GsCode != "01").ToList();
            var gl = FbPaGoodsGlService.GetAll().Where(entity => entity.GlCode != "01").ToList();

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

            return goodsClassDtoList;
            #endregion
        }

        #endregion

        #region Report

        #region 会员消费明细查询

        public ActionResult MsMemberSaleReport()
        {
            return View();
        }

        public ActionResult SearchMsMemberSaleReport()
        {
            // 获取查询条件

            // 查询返回

            return View();
        }

        #endregion

        #endregion

        #region User Control

        public ActionResult UCMemberArchives()
        {
            string id = Request["id"];
            MsMemberArchives m = MsMemberArchives.Initial();
            if (!string.IsNullOrEmpty(id))
            {
                m = MsMemberArchivesService.GetById(id);
            }
            else
            {
                m.CardNumber = MsMemberArchivesService.GenerateMsCode();
            }
            return View("/Ms/UserControl/UCMemberArchives", m);
        }

        #endregion
    }

    public partial class UCMemberArchives : System.Web.Mvc.ViewUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 处理会员信息数据
        }
    }
}