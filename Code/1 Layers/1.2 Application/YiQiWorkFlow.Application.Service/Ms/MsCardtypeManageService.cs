/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public class MsCardtypeManageService : IMsCardtypeManageService
    {
        public IRepositoryGUID<MsCardtypeManage> EntityRepository { get; set; }

        [Transaction]
        public string Create(MsCardtypeManage entity)
        {
            if (entity.HaveId == false)
            {
                //entity.GenerateId();
                entity.Id = GenerateCardtypeCode();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public MsCardtypeManage GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<MsCardtypeManage> GetAll()
        {
            var result = EntityRepository.LinqQuery.ToList();

            return result;
        }

        [Transaction]
        public void Update(MsCardtypeManage entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(MsCardtypeManage entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<MsCardtypeManage> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }

        [Transaction]
        public SearchResult<MsCardtypeManage> Search(SearchDtoBase<MsCardtypeManage> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
                if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
                if (string.IsNullOrEmpty(c.entity.CardName) == false)
                {
                    q = q.Where(p => p.CardName.Contains(c.entity.CardName));
                }
                if (string.IsNullOrEmpty(c.entity.CardType) == false)
                {
                    q = q.Where(p => p.CardType.Contains(c.entity.CardType));
                }
                if (string.IsNullOrEmpty(c.entity.CardMedium) == false)
                {
                    q = q.Where(p => p.CardMedium.Contains(c.entity.CardMedium));
                }
                if (c.entity.CardUsefulLife > 0)
                {
                    q = q.Where(p => p.CardUsefulLife == c.entity.CardUsefulLife);
                }

                if (c.entity.PointsUsefulLife > 0)
                {
                    q = q.Where(p => p.PointsUsefulLife == c.entity.PointsUsefulLife);
                }

                if (c.entity.TransactCharge > 0)
                {
                    q = q.Where(p => p.TransactCharge == c.entity.TransactCharge);
                }

                if (c.entity.DepositMoney > 0)
                {
                    q = q.Where(p => p.DepositMoney == c.entity.DepositMoney);
                }

                if (string.IsNullOrEmpty(c.entity.IfVip) == false)
                {
                    q = q.Where(p => p.IfVip.Contains(c.entity.IfVip));
                }
                if (string.IsNullOrEmpty(c.entity.IfDiscount) == false)
                {
                    q = q.Where(p => p.IfDiscount.Contains(c.entity.IfDiscount));
                }
                if (c.entity.DiscountBase > 0)
                {
                    q = q.Where(p => p.DiscountBase == c.entity.DiscountBase);
                }

                if (c.entity.DiscountRate > 0)
                {
                    q = q.Where(p => p.DiscountRate == c.entity.DiscountRate);
                }

                if (string.IsNullOrEmpty(c.entity.IfPoints) == false)
                {
                    q = q.Where(p => p.IfPoints.Contains(c.entity.IfPoints));
                }
                if (c.entity.ExpendBase > 0)
                {
                    q = q.Where(p => p.ExpendBase == c.entity.ExpendBase);
                }

                if (c.entity.PointsValues > 0)
                {
                    q = q.Where(p => p.PointsValues == c.entity.PointsValues);
                }

                if (c.entity.BirthdayPoints > 0)
                {
                    q = q.Where(p => p.BirthdayPoints == c.entity.BirthdayPoints);
                }

                if (string.IsNullOrEmpty(c.entity.IfPrepaid) == false)
                {
                    q = q.Where(p => p.IfPrepaid.Contains(c.entity.IfPrepaid));
                }
                if (string.IsNullOrEmpty(c.entity.IfPrepaidPassword) == false)
                {
                    q = q.Where(p => p.IfPrepaidPassword.Contains(c.entity.IfPrepaidPassword));
                }
                if (c.entity.LimitTimes > 0)
                {
                    q = q.Where(p => p.LimitTimes == c.entity.LimitTimes);
                }

                if (c.entity.PrestoreMoney > 0)
                {
                    q = q.Where(p => p.PrestoreMoney == c.entity.PrestoreMoney);
                }

                if (string.IsNullOrEmpty(c.entity.PrestorePw) == false)
                {
                    q = q.Where(p => p.PrestorePw.Contains(c.entity.PrestorePw));
                }
                if (c.entity.PrepaidMin > 0)
                {
                    q = q.Where(p => p.PrepaidMin == c.entity.PrepaidMin);
                }

                if (c.entity.PrepaidMax > 0)
                {
                    q = q.Where(p => p.PrepaidMax == c.entity.PrepaidMax);
                }

                if (string.IsNullOrEmpty(c.entity.IfPointToPrepaid) == false)
                {
                    q = q.Where(p => p.IfPointToPrepaid.Contains(c.entity.IfPointToPrepaid));
                }
                if (c.entity.PointsBase > 0)
                {
                    q = q.Where(p => p.PointsBase == c.entity.PointsBase);
                }

                if (c.entity.PrepaidMoney > 0)
                {
                    q = q.Where(p => p.PrepaidMoney == c.entity.PrepaidMoney);
                }

                if (string.IsNullOrEmpty(c.entity.CardNumberPrefix) == false)
                {
                    q = q.Where(p => p.CardNumberPrefix.Contains(c.entity.CardNumberPrefix));
                }
                if (c.entity.CardNumberLen > 0)
                {
                    q = q.Where(p => p.CardNumberLen == c.entity.CardNumberLen);
                }

                if (c.entity.RandLen > 0)
                {
                    q = q.Where(p => p.RandLen == c.entity.RandLen);
                }

                if (string.IsNullOrEmpty(c.entity.UpgradeType) == false)
                {
                    q = q.Where(p => p.UpgradeType.Contains(c.entity.UpgradeType));
                }
                if (c.entity.PointsNeeds > 0)
                {
                    q = q.Where(p => p.PointsNeeds == c.entity.PointsNeeds);
                }

                if (string.IsNullOrEmpty(c.entity.IfDeductPoints) == false)
                {
                    q = q.Where(p => p.IfDeductPoints.Contains(c.entity.IfDeductPoints));
                }
                if (string.IsNullOrEmpty(c.entity.IfAutoup) == false)
                {
                    q = q.Where(p => p.IfAutoup.Contains(c.entity.IfAutoup));
                }
                if (string.IsNullOrEmpty(c.entity.Operator) == false)
                {
                    q = q.Where(p => p.Operator.Contains(c.entity.Operator));
                }
                if (string.IsNullOrEmpty(c.entity.Assessor) == false)
                {
                    q = q.Where(p => p.Assessor.Contains(c.entity.Assessor));
                }
                if (string.IsNullOrEmpty(c.entity.IfExamine) == false)
                {
                    q = q.Where(p => p.IfExamine.Contains(c.entity.IfExamine));
                }
            }
            if (string.IsNullOrEmpty(c.key) == false)
            {
                q = from l in q
                    where
                    l.Id.Contains(c.key)
                    || l.CardName.Contains(c.key)
                    || l.CardType.Contains(c.key)
                    || l.CardMedium.Contains(c.key)
                    || l.IfVip.Contains(c.key)
                    || l.IfDiscount.Contains(c.key)
                    || l.IfPoints.Contains(c.key)
                    || l.IfPrepaid.Contains(c.key)
                    || l.IfPrepaidPassword.Contains(c.key)
                    || l.PrestorePw.Contains(c.key)
                    || l.IfPointToPrepaid.Contains(c.key)
                    || l.CardNumberPrefix.Contains(c.key)
                    || l.UpgradeType.Contains(c.key)
                    || l.IfDeductPoints.Contains(c.key)
                    || l.IfAutoup.Contains(c.key)
                    || l.Operator.Contains(c.key)
                    || l.Assessor.Contains(c.key)
                    || l.IfExamine.Contains(c.key)
                    select l;


            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);

            var result = q.ToList();
            return result.ToSearchResult(count);
        }

        [Transaction]
        public IList<MsCardtypeManage> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key) == false)
            {
                q = from l in q
                    where
                    l.Id.Contains(key)
                    || l.CardName.Contains(key)
                    || l.CardType.Contains(key)
                    || l.CardMedium.Contains(key)
                    || l.IfVip.Contains(key)
                    || l.IfDiscount.Contains(key)
                    || l.IfPoints.Contains(key)
                    || l.IfPrepaid.Contains(key)
                    || l.IfPrepaidPassword.Contains(key)
                    || l.PrestorePw.Contains(key)
                    || l.IfPointToPrepaid.Contains(key)
                    || l.CardNumberPrefix.Contains(key)
                    || l.UpgradeType.Contains(key)
                    || l.IfDeductPoints.Contains(key)
                    || l.IfAutoup.Contains(key)
                    || l.Operator.Contains(key)
                    || l.Assessor.Contains(key)
                    || l.IfExamine.Contains(key)
                    select l;
            }
            q = q.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            var result = q.ToList();
            return result.ToList();
        }

        [Transaction]
        public void Delete(IList<string> ids)
        {
            var q = EntityRepository.LinqQuery.Where(p => ids.Contains(p.Id));
            foreach (var each in q)
            {
                Delete(each);
            }
        }

        [Transaction(ReadOnly = true)]
        public string GenerateCardtypeCode()
        {
            string maxCardTypeCode = GetMaxCardtypeCode();

            if (string.IsNullOrEmpty(maxCardTypeCode))
            {
                return "00001";
            }
            else
            {
                int maxCardTypeCodeInt = Convert.ToInt32(maxCardTypeCode);

                return (maxCardTypeCodeInt + 1).ToString("00000");
            }
        }

        private string GetMaxCardtypeCode()
        {
            //SearchResult<MsCardtypeManage> searchResult = Search(new SearchDtoBase<MsCardtypeManage>() { pageIndex = 1, pageSize = 1, sortOrder = "CardCode", sortField = "CardCode" });

            IList<MsCardtypeManage> msCardtypeManageList = EntityRepository.Exec("SELECT MAX(CARD_CODE) FROM [ms_cardtype_manage]").ToList();

            string maxCardCode = msCardtypeManageList == null || msCardtypeManageList.Count <= 0 || msCardtypeManageList[0] == null || string.IsNullOrEmpty(msCardtypeManageList[0].Id) ? string.Empty : msCardtypeManageList[0].Id;

            if (string.IsNullOrEmpty(maxCardCode))
            {
                return string.Empty;
            }
            else
            {
                return maxCardCode;
            }
        }
    }
}